using Calcolatrice.Implementazione3.Core;
using Calcolatrice.Implementazione3.CreatoriOperazione;
using System;
using System.Collections.Generic;

namespace Calcolatrice.Implementazione3
{
    public class Calcolatrice_version2
    {
        public Calcolatrice_version2()
        {
            //this.creatore = new CreatoreOperazione();
            this.creatore = new CreatoreOperazioneReflection();
        }

        private ICreatoreOperazione creatore = null;

        public IEnumerable<string> Operazioni { get { return this.creatore.ListaOperazioni; } }

        public decimal EseguiOperazione(string operazione, decimal numero1, decimal numero2)
        {
            IOperazione strategia = this.creatore.Crea(operazione);
            return strategia.Esegui(numero1, numero2);
        }
    }
}
