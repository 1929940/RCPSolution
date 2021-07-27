using RCPSolution.Models;
using System.Collections.Generic;

namespace RCPSolution.Logic {
    public interface ILineReader {

        string Message { get; }
        void ReadLine(string line);
        IEnumerable<DzienPracy> GetDniPracy();
    }
}
