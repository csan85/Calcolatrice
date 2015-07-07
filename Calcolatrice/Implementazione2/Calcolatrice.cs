using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice.Implementazione2
{
    public class Calcolatrice
    {
        public Calcolatrice()
        {
            List<string> listaOperazioni = new List<string>();
            listaOperazioni.Add("+");
            listaOperazioni.Add("-");
            listaOperazioni.Add("*");
            listaOperazioni.Add("/");

            this.Operazioni = listaOperazioni;
        }

        public IEnumerable<string> Operazioni { get; private set; }

        private decimal Addizione(decimal numero1, decimal numero2)
        {
            return numero1 + numero2;
        }

        private decimal Sottrazione(decimal numero1, decimal numero2)
        {
            return numero1 - numero2;
        }

        private decimal Moltiplicazione(decimal numero1, decimal numero2)
        {
            return numero1 * numero2;
        }

        private decimal Divisione(decimal numero1, decimal numero2)
        {
            if (numero2 == 0m)
            {
                throw new DivideByZeroException();
            }

            return numero1 / numero2;
        }

        public decimal EseguiOperazione(string operazione, decimal numero1, decimal numero2)
        {
            decimal risultato = 0m;
            switch (operazione)
            {
                case "+":
                    risultato = Addizione(numero1, numero2);
                    break;
                case "-":
                    risultato = Sottrazione(numero1, numero2);
                    break;
                case "*":
                    risultato = Moltiplicazione(numero1, numero2);
                    break;
                case "/":
                    risultato = Divisione(numero1, numero2);
                    break;
                default:
                    throw new ArgumentException("Operazione non supportata");
            }

            return risultato;
        }
    }
}
