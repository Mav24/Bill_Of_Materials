using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValcomData
{
    public class LineItemStock
    {
        public int ID { get; set; }
        public string DLDrawingID { get; set; }
        public int LineNumber { get; set; }
        public string ProductionCode { get; set; }
        public string PartID { get; set; }
        public string DWGNO { get; set; }
        public string PartDescription { get; set; }
        public double QTYU { get; set; }
        public string Units { get; set; }
        public int IndentFactor { get; set; }
        public string QANote { get; set; }
        public string Comment { get; set; }
        public double Stock { get; set; }
    }
}
