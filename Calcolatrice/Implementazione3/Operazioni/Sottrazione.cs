using Calcolatrice.Implementazione3.Core;
using Calcolatrice.Implementazione3.CreatoriOperazione;
using System;

namespace Calcolatrice.Implementazione3.Operazioni
{
    [Operazione("-", "Sottrazione")]
    public class Sottrazione : IOperazione
    {
        public decimal Esegui(decimal numero1, decimal numero2)
        {
            return numero1 - numero2;
        }
    }
}
