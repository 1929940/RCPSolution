namespace RCPSolution.Logic {
    public class LineReaderProvider {

        public ILineReader GetLineReader(string line) {
            var lineArr = line.Split(';');
            if (lineArr.Length == 5)
                return new LineReaderCompany1();
            if (lineArr.Length == 4)
                return new LineReaderCompany2();
            return null;
        }
    }
}
