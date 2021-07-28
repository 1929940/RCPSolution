using RCPSolution.Models;
using RCPSolution.Resx;
using System;
using System.Collections.Generic;
using System.IO;

namespace RCPSolution.Logic {
    public class RcpImporter {
        public void Start() {
            string directory = GetDirectory();
            ReadDirectory(directory);

            Console.WriteLine(Messages.IMPORT_ENDED);
            Console.ReadKey();
        }

        string GetDirectory() {
            string directory = string.Empty;

            while (string.IsNullOrEmpty(directory) || !Directory.Exists(directory)) {
                Console.WriteLine(Messages.ENTER_PATH);
                directory = Console.ReadLine();
            }
            return directory;
        }
        void ReadDirectory(string directory) {
            var paths = Directory.GetFiles(directory, "*.csv");
            foreach (var path in paths) {
                ReadFile(path);
            }
        }
        void ReadFile(string path) {
            var fileName = Path.GetFileName(path);
            Console.WriteLine(Messages.IMPORT_STARTED, fileName);
            ILineReader lineReader = null;

            using (StreamReader sr = new StreamReader(path)) {
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();

                    if (lineReader == null) {
                        lineReader = new LineReaderProvider().GetLineReader(line);
                        if (lineReader == null) {
                            Console.WriteLine(Messages.UNKNOWN_FORMAT, fileName);
                            break;
                        }
                    }

                    lineReader.ReadLine(line);
                }

                var dniPracy = lineReader.GetDniPracy();
                PrintDniPracy(dniPracy);

                Console.WriteLine(lineReader.Message);
            }
        }
        void PrintDniPracy(IEnumerable<DzienPracy> dniPracy) {
            foreach (var dzienPracy in dniPracy) {
                Console.WriteLine($"{dzienPracy.KodPracownika}\t{dzienPracy.Data:d}\t{dzienPracy.GodzinaWejscia}\t{dzienPracy.GodzinaWyjscia}");
            }
        }
    }
}
