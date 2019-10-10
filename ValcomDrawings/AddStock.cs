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
        //public List<DrawingLine> drawingLineItems;
        public Drawing drawing;

        private void AddStock_Load(object sender, EventArgs e)
        {
            // Sets Form Title
            this.Text = $"Add Stock for {drawing.BOMDescription}";

            // Fresh call to the database to get updated line Items.
            drawingLineBindingSource.DataSource = DrawingLineDB.GetDrawingLines(drawing.DrawingID);
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
            // Sets Error to empty.
            drawingLineDataGridView.Rows[e.RowIndex].ErrorText = "";

            // Gets Name of Header for validation.
            string headerText = drawingLineDataGridView.Columns[e.ColumnIndex].HeaderText;
            
            // Abort valication if cell is not in the Stock column.
            if (!headerText.Equals("Stock")) return;

            // Might need to set so it checks for negitive value.. 
            if (!double.TryParse(e.FormattedValue.ToString(), out double newDouble))
            {
                // Place the error right in the datagridview.
                drawingLineDataGridView.Rows[e.RowIndex].ErrorText = "The value must be a numeric in stock column!";
                e.Cancel = true;
            }
        }

        private void btnCalculateBOMs_Click(object sender, EventArgs e)
        {
            // Creates a new List with the stock added to the list.
            List<LineItemStock> lineItemsWithStock = new List<LineItemStock>();

            // Loop through rows to create new line items with stock added.
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

                lineItemsWithStock.Add(item);
            }

            // Get Quantity of job from user.
            QuantityOfJob quantityOfJob = new QuantityOfJob();

            DialogResult result = quantityOfJob.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Opens newly create job with quantity and stock items and does the math (ready for print)
                CreateJob createJob = new CreateJob();
                createJob.quantity = quantityOfJob.amount;
                createJob.lineItemStock = lineItemsWithStock;
                createJob.drawing = drawing;
                createJob.ShowDialog();
            }
        }
    }
}
