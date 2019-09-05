using System;
namespace ValcomData
{
    public class Drawing
    {
        public int ID { get; set; }
        public string DrawingID { get; set; }
        public DateTime DateCreated { get; set; }
        public string BOMDescription { get; set; }
        public string NSN { get; set; }
        public string AddedBy { get; set; }
        public string DateModified { get; set; }
        public DateTime DateModifedNotNull { get; set; }
        public string Changes { get; set; }

    }
}
