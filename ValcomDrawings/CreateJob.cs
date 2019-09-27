using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValcomData;

namespace ValcomDrawings
{
    public partial class CreateJob : Form
    {
        public CreateJob()
        {
            InitializeComponent();
        }
        public int quantity;
        public Drawing drawing;
        //public DrawingLine drawingLine;
        //public List<DrawingLine> drawingLineItemsList;
        public List<LineItemStock> lineItemStock;
        private List<TempJob> tempDrawingLines;


        private void CreateJob_Load(object sender, EventArgs e)
        {
            this.Text = $"Created Job for {drawing.BOMDescription}";
            CreateNewJob();
        }

        private void CreateNewJob()
        {
            tempDrawingLines = new List<TempJob>();
            List<string> partIdList = new List<string>();


            foreach (var item in lineItemStock)
            {
                var value1 = item.QTYU * item.IndentFactor * quantity - item.Stock;
                // Check if value is less then 0, if yes then set order amount to 0
                if (value1 < 0)
                    value1 = 0;
                var newQTYU = item.QTYU;
                if (partIdList.Contains(item.PartID))
                {
                    var location = partIdList.IndexOf(item.PartID);
                    tempDrawingLines[location].AmountNeed += value1;
                    tempDrawingLines[location].QTYU += newQTYU;
                }
                else
                {
                    TempJob tempJob = new TempJob();

                    tempJob.ID = item.ID;
                    tempJob.DLDrawingID = item.DLDrawingID;
                    tempJob.LineNumber = item.LineNumber;
                    tempJob.ProductionCode = item.ProductionCode;
                    tempJob.PartID = item.PartID;
                    tempJob.DWGNO = item.DWGNO;
                    tempJob.PartDescription = item.PartDescription;
                    tempJob.QTYU = item.QTYU;
                    tempJob.Units = item.Units;
                    tempJob.IndentFactor = item.IndentFactor;
                    tempJob.QANote = item.QANote;
                    tempJob.Comment = item.Comment;
                    tempJob.AmountNeed = value1;
                    partIdList.Add(item.PartID);
                    tempDrawingLines.Add(tempJob);
                }
            }
            drawingLineDataGridView.DataSource = tempDrawingLines;
            for (int i = 0; i < tempDrawingLines.Count; i++)
            {
                drawingLineDataGridView.Rows[i].Cells[12].Value = tempDrawingLines[i].AmountNeed;
            }
        }

        private void toolMenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{AboutandHelp.About()}", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolMenuPrint_Click(object sender, EventArgs e)
        {
            PrintingJobAmounts printing = new PrintingJobAmounts();
            printing.drawing = drawing;
            printing.quantity = quantity;
            printing.tempDrawingLines = tempDrawingLines;
            printing.ShowDialog();
        }

        private void PrintManufacturingOnly_Click(object sender, EventArgs e)
        {
            Printing("M");
        }


        private void PrintPurchasingOnly_Click(object sender, EventArgs e)
        {
            Printing("P");
        }

        private void Printing(string printCode)
        {
            List<TempJob> manufacturingOrPurchasing = new List<TempJob>();
            switch (printCode)
            {
                case "M":
                    foreach (var item in tempDrawingLines)
                    {
                        if (item.ProductionCode == "M")
                        {
                            TempJob tempJob = new TempJob();

                            tempJob.ID = item.ID;
                            tempJob.DLDrawingID = item.DLDrawingID;
                            tempJob.LineNumber = item.LineNumber;
                            tempJob.ProductionCode = item.ProductionCode;
                            tempJob.PartID = item.PartID;
                            tempJob.DWGNO = item.DWGNO;
                            tempJob.PartDescription = item.PartDescription;
                            tempJob.QTYU = item.QTYU;
                            tempJob.Units = item.Units;
                            tempJob.IndentFactor = item.IndentFactor;
                            tempJob.QANote = item.QANote;
                            tempJob.Comment = item.Comment;
                            tempJob.AmountNeed = item.AmountNeed;
                            manufacturingOrPurchasing.Add(tempJob);
                        }

                    }
                    break;
                case "P":
                    foreach (var item in tempDrawingLines)
                    {
                        if (item.ProductionCode == "P")
                        {
                            TempJob tempJob = new TempJob();

                            tempJob.ID = item.ID;
                            tempJob.DLDrawingID = item.DLDrawingID;
                            tempJob.LineNumber = item.LineNumber;
                            tempJob.ProductionCode = item.ProductionCode;
                            tempJob.PartID = item.PartID;
                            tempJob.DWGNO = item.DWGNO;
                            tempJob.PartDescription = item.PartDescription;
                            tempJob.QTYU = item.QTYU;
                            tempJob.Units = item.Units;
                            tempJob.IndentFactor = item.IndentFactor;
                            tempJob.QANote = item.QANote;
                            tempJob.Comment = item.Comment;
                            tempJob.AmountNeed = item.AmountNeed;
                            manufacturingOrPurchasing.Add(tempJob);
                        }

                    }
                    break;
                default:
                    break;
            }

            PrintingJobAmounts printing = new PrintingJobAmounts();
            printing.drawing = drawing;
            printing.quantity = quantity;
            printing.tempDrawingLines = manufacturingOrPurchasing;
            printing.ShowDialog();

        }
    }
}
