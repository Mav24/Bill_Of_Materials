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
        public DrawingLine drawingLine;
        public List<DrawingLine> drawingLineItemsList;
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

            #region Marked for delete old method for calculating values and getting rid of duplicates
            //drawingLineDataGridView.DataSource = tempDrawingLines;

            //foreach (DataGridViewRow row in drawingLineDataGridView.Rows)
            //{
            //    double QTYU = (double)row.Cells[6].Value;
            //    int indentFactor = (int)row.Cells[9].Value;
            //    double total = QTYU * indentFactor * jobAmount;
            //    row.Cells[11].Value = total.ToString();

            //}

            //foreach (DataGridViewRow row in drawingLineDataGridView.Rows)
            //{
            //    string partId = row.Cells[4].Value.ToString();

            //    int rowCount = drawingLineDataGridView.RowCount;
            //    for (int i = 0; i < rowCount; i++)
            //    {

            //        if (i != row.Index && drawingLineDataGridView.Rows[i].Cells[4].Value.ToString() == partId)
            //        {

            //            var value1 = Convert.ToDouble(row.Cells[11].Value);
            //            var value2 = Convert.ToDouble(drawingLineDataGridView.Rows[i].Cells[11].Value);
            //            double total = value1 + value2;
            //            row.Cells[11].Value = total.ToString();
            //            drawingLineDataGridView.Rows.Remove(drawingLineDataGridView.Rows[i]);
            //        }
            //    }


            //}
            #endregion
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

        // This is a work in progress
        private void mPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LineItemStock> m = new List<LineItemStock>();
            List<TempJob> newMJobs = new List<TempJob>();

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
                    newMJobs.Add(tempJob);
                }
                
            }
        }
    }
}
