using System;

namespace RCPSolution.Models {
    public class DzienPracy {
        public int KodPracownika { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan GodzinaWejscia { get; set; }
        public TimeSpan GodzinaWyjscia { get; set; }
    }
}
