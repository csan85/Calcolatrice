using Calcolatrice.Implementazione3.Core;
using Calcolatrice.Implementazione3.Operazioni;
using System;
using System.Collections.Generic;

namespace Calcolatrice.Implementazione3.CreatoriOperazione
{
    public class CreatoreOperazione : ICreatoreOperazione
    {
        public IEnumerable<string> ListaOperazioni
        {
            get
            {
                return new List<string>() { "+", "-", "*", "/" };
            }
        }

        public IOperazione Crea(string operazione)
        {
            IOperazione result = null;
            switch (operazione)
            {
                case "+":
                    result = new Addizione();
                    break;
                case "-":
                    result = new Sottrazione();
                    break;
                case "*":
                    result = new Moltiplicazione();
                    break;
                case "/":
                    result = new Divisione();
                    break;
                default:
                    throw new ArgumentException("Operazione non supportata");
            }

            return result;
        }
    }
}
