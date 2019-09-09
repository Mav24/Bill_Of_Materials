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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }
        public List<DrawingLine> drawingLineItems;
        public Drawing drawing;

        private void AddStock_Load(object sender, EventArgs e)
        {
            this.Text = $"Add Stock for {drawing.BOMDescription}";
            drawingLineBindingSource.DataSource = drawingLineItems;
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            List<LineItemStock> stock = new List<LineItemStock>();

            foreach (DataGridViewRow row in drawingLineDataGridView.Rows)
            {
                LineItemStock item = new LineItemStock();
                item.ID = Convert.ToInt32(row.Cells[0].Value);
                item.DLDrawingID = row.Cells[1].Value.ToString();
                item.LineNumber = Convert.ToInt32(row.Cells[2].Value);
                item.ProductionCode = row.Cells[3].Value.ToString();
                item.PartID = row.Cells[4].Value.ToString();
                item.DWGNO = row.Cells[5].Value.ToString();
                item.PartDescription = row.Cells[6].Value.ToString();
                item.QTYU = Convert.ToDouble(row.Cells[7].Value);
                item.Units = row.Cells[8].Value.ToString();
                item.IndentFactor = Convert.ToInt32(row.Cells[9].Value);
                item.QANote = row.Cells[10].Value.ToString();
                item.Comment = row.Cells[11].Value.ToString();
                item.Stock = Convert.ToDouble(row.Cells[12].Value);
                
                stock.Add(item);

                #region Might need this later. Mark for delete Sept. 6th 2019
                //foreach (DataGridViewCell dc in row.Cells)
                //{
                //    item.ID = Convert.ToInt32(dc.Value);
                //    item.DLDrawingID = 
                //    //item.LineNumber = Convert.ToInt32(dc.Cells[2]);
                //    //item.ProductionCode = dc.Cells[3].ToString();
                //    //item.PartID = dc.Cells[4].ToString();
                //    //item.DWGNO = dc.Cells[5].ToString();
                //    //item.PartDescription = dc.Cells[6].ToString();
                //    //item.QTYU = Convert.ToDouble(dc.Cells[7]);
                //    //item.Units = dc.Cells[8].ToString();
                //    //item.IndentFactor = Convert.ToInt32(dc.Cells[9]);
                //    //item.QANote = dc.Cells[10].ToString();
                //    //item.Comment = dc.Cells[11].ToString();
                //    //item.Stock = Convert.ToInt32(dc.Cells[12]);
                //    stock.Add(item);
                //}
                #endregion
            }

            QuantityOfJob quantityOfJob = new QuantityOfJob();

            DialogResult result = quantityOfJob.ShowDialog();
            if (result == DialogResult.OK)
            {
                CreateJob createJob = new CreateJob();
                createJob.jobAmount = quantityOfJob.amount;
                createJob.lineItemStock = stock;
                createJob.drawing = drawing;
                createJob.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{AboutandHelp.About()}", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void drawingLineDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            drawingLineDataGridView.Rows[e.RowIndex].ErrorText = "";
            double newDouble;

            if (drawingLineDataGridView.Rows[e.RowIndex].IsNewRow) { return; }

            // Might need to set an or so it checks for negitive value.. 
            if (!double.TryParse(e.FormattedValue.ToString(), out newDouble))
            {
                e.Cancel = true;
                // Use this if you want to place the error right in the datagridview
                drawingLineDataGridView.Rows[e.RowIndex].ErrorText = "The value must be a numeric in stock column!";
            }
        }
    }
}
