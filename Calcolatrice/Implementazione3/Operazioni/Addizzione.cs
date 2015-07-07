using Calcolatrice.Implementazione3.Core;
using Calcolatrice.Implementazione3.CreatoriOperazione;
using System;

namespace Calcolatrice.Implementazione3.Operazioni
{
    [Operazione("+", "Addizzione")]
    public class Addizione : IOperazione
    {
        public decimal Esegui(decimal numero1, decimal numero2)
        {
            return numero1 + numero2;
        }
    }
}
