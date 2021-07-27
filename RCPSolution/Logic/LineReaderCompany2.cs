using RCPSolution.Models;
using RCPSolution.Resx;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RCPSolution.Logic {
    public class LineReaderCompany2 : ILineReader {

        private List<Line> lines;
        private int count;

        public string Message => string.Format(Messages.IMPORTED_LINES, lines.Count, count);

        public LineReaderCompany2() {
            lines = new List<Line>();
            count = 0;
        }

        public void ReadLine(string line) {
            count++;

            var lineArr = line.Split(';');
            if (lineArr.Length != 4) {
                Console.WriteLine(Messages.INCORRECT_ARGUMENT_COUNT, line);
                return;
            }


            if (!int.TryParse(lineArr[0], out int code)) {
                Console.WriteLine(Messages.INCORRECT_FORMAT, line, "kodem pracownika");
                return;
            }
            if (!DateTime.TryParse(lineArr[1], out DateTime date)) {
                Console.WriteLine(Messages.INCORRECT_FORMAT, line, "datą");
                return;
            }
            if (!TimeSpan.TryParse(lineArr[2], out TimeSpan time)) {
                Console.WriteLine(Messages.INCORRECT_FORMAT, line, "czasem");
                return;
            }
            if (!Enum.TryParse(lineArr[3], true, out WeWy weWy)) {
                Console.WriteLine(Messages.INCORRECT_FORMAT, line, "typem we/wy");
                return;
            }

            lines.Add(new Line() {
                Code = code,
                Date = date,
                Time = time,
                WeWy = weWy
            });
        }

        public IEnumerable<DzienPracy> GetDniPracy() {
            var output = new List<DzienPracy>();
            var groups = lines.GroupBy(x => new { x.Code, x.Date.Date });
            foreach (var group in groups) {
                var line = group.FirstOrDefault();

                if (group.Count() > 2) {
                    Console.WriteLine(Messages.TOO_MANY_ENTRIES, line.Code, line.Date);
                    continue;
                }
                if (group.Count() < 2) {
                    Console.WriteLine(Messages.TOO_MANY_EXITS, line.Code, line.Date);
                    continue;
                }

                var entry = group.FirstOrDefault(x => x.WeWy == WeWy.We);
                if (entry == null) {
                    Console.WriteLine(Messages.NO_ENTRY_FOUND, line.Code, line.Date);
                    continue;
                }

                var exit = group.FirstOrDefault(x => x.WeWy == WeWy.Wy);
                if (exit == null) {
                    Console.WriteLine(Messages.NO_EXIT_FOUND, line.Code, line.Date);
                    continue;
                }

                output.Add(new DzienPracy() {
                    KodPracownika = line.Code,
                    Data = line.Date,
                    GodzinaWejscia = entry.Time,
                    GodzinaWyjscia = exit.Time
                });
            }

            return output;
        }


        public class Line {
            public int Code { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan Time { get; set; }
            public WeWy WeWy { get; set; }
        }

        public enum WeWy {
            We,
            Wy,
        }
    }
}
