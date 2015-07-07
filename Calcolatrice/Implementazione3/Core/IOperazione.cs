using System;

namespace Calcolatrice.Implementazione3.Core
{
    public interface IOperazione
    {
        decimal Esegui(decimal numero1, decimal numero2);
    }
}
