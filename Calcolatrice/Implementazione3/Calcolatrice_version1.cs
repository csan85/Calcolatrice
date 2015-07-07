using Calcolatrice.Implementazione3.Core;
using Calcolatrice.Implementazione3.Operazioni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice.Implementazione3
{
    public class Calcolatrice_version1
    {
        public Calcolatrice_version1()
        {
            List<string> listaOperazioni = new List<string>();
            listaOperazioni.Add("+");
            listaOperazioni.Add("-");
            listaOperazioni.Add("*");
            listaOperazioni.Add("/");

            this.Operazioni = listaOperazioni;
        }

        public IEnumerable<string> Operazioni { get; private set; }

        public decimal EseguiOperazione(string operazione, decimal numero1, decimal numero2)
        {
            IOperazione strategia = CreaOperazione(operazione);
            return strategia.Esegui(numero1, numero2);
        }

        private IOperazione CreaOperazione(string operazione)
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
