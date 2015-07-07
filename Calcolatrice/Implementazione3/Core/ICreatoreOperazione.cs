using System;
using System.Collections.Generic;

namespace Calcolatrice.Implementazione3.Core
{
    public interface ICreatoreOperazione
    {
        IEnumerable<string> ListaOperazioni { get; }
        IOperazione Crea(string operazione);
    }
}
