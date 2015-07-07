using Calcolatrice.Implementazione3.Core;
using Calcolatrice.Implementazione3.CreatoriOperazione;
using System;

namespace Calcolatrice.Implementazione3.Operazioni
{
    [Operazione("/", "Divisione")]
    public class Divisione : IOperazione
    {
        public decimal Esegui(decimal numero1, decimal numero2)
        {
            if (numero2 == 0m)
            {
                throw new DivideByZeroException();
            }

            return numero1 / numero2;
        }
    }
}
