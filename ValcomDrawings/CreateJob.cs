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
        public int jobAmount;
        public Drawing drawing;
        public DrawingLine drawingLine;
        public List<DrawingLine> drawingLineItemsList;


        private void CreateJob_Load(object sender, EventArgs e)
        {
            this.Text = $"Create Job for {drawing.DrawingID}";
            CreateNewJob();
        }

        private void CreateNewJob()
        {
            List<TempJob> tempDrawingLines = new List<TempJob>();
            List<string> partIdList = new List<string>();


            foreach (var item in drawingLineItemsList)
            {
                var value1 = item.QTYU * item.IndentFactor * jobAmount;
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
    }
}
