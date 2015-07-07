using Calcolatrice.Implementazione3.Core;
using Calcolatrice.Implementazione3.Operazioni;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Calcolatrice.Implementazione3.CreatoriOperazione
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class OperazioneAttribute : Attribute
    {
        public OperazioneAttribute(string key, string descrizione)
        {
            this.Key = key;
            this.Descrizione = descrizione;
        }

        public string Key { get; private set; }
        public string Descrizione { get; private set; }
    }

    public class CreatoreOperazioneReflection : ICreatoreOperazione
    {
        public CreatoreOperazioneReflection()
        {
            Type interfaceType = typeof(IOperazione);
            var operazioni = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(type => type != interfaceType &&
                               interfaceType.IsAssignableFrom(type) &&
                               type.IsDefined(typeof(OperazioneAttribute), false));

            foreach (Type t in operazioni)
            {
                OperazioneAttribute attributo = t.GetCustomAttributes(typeof(OperazioneAttribute), false).FirstOrDefault() as OperazioneAttribute;
                if (attributo != null)
                {
                    Func<IOperazione> function = Expression.Lambda<Func<IOperazione>>(Expression.New(t)).Compile();

                    this.hashOperazioni.Add(attributo.Key, function);
                }
            }
        }

        private Dictionary<string, Func<IOperazione>> hashOperazioni = new Dictionary<string, Func<IOperazione>>();

        public IEnumerable<string> ListaOperazioni
        {
            get { return this.hashOperazioni.Keys; }
        }

        public IOperazione Crea(string operazione)
        {
            IOperazione result = null;

            Func<IOperazione> function = null;
            if (this.hashOperazioni.TryGetValue(operazione, out function))
            {
                result = function();
            }

            return result;
        }
    }
}
