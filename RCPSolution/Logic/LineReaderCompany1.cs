using RCPSolution.Models;
using RCPSolution.Resx;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RCPSolution.Logic {
    public class LineReaderCompany1 : ILineReader {

        private List<Line> lines;
        private int count;

        public string Message => string.Format(Messages.IMPORTED_LINES, lines.Count, count);

        public LineReaderCompany1() {
            lines = new List<Line>();
            count = 0;
        }

        public void ReadLine(string line) {
            count++;

            var lineArr = line.Split(';');
            if (lineArr.Length != 5) {
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
            if (!TimeSpan.TryParse(lineArr[2], out TimeSpan entryTime)) {
                Console.WriteLine(Messages.INCORRECT_FORMAT, line, "czasem wejścia");
                return;
            }
            if (!TimeSpan.TryParse(lineArr[3], out TimeSpan exitTime)) {
                Console.WriteLine(Messages.INCORRECT_FORMAT, line, "czasem wyjścia");
                return;
            }

            lines.Add(new Line() {
                Code = code,
                Date = date,
                EntryTime = entryTime,
                ExitTime = exitTime
            });
        }

        public IEnumerable<DzienPracy> GetDniPracy() =>
            lines.Select(x => new DzienPracy() {
                KodPracownika = x.Code,
                Data = x.Date,
                GodzinaWejscia = x.EntryTime,
                GodzinaWyjscia = x.ExitTime
            });

        public class Line {
            public int Code { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan EntryTime { get; set; }
            public TimeSpan ExitTime { get; set; }
        }
    }
}
