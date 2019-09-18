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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Drawing drawing;
        private List<string> drawingsList;
        private List<DrawingLine> drawingLineItemsList;

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetDrawings();
            GetDrawingLineItems();
        }

        private void GetDrawingLineItems()
        {
            
            string drawingID = drawingIDComboBox.Text;
            try
            {
                // Get Drawing Object for the selected drawing
                // Bind the text boxes to the object
                drawing = DrawingDB.GetDrawingInfo(drawingID);
                drawingBindingSource.Clear();
                drawingBindingSource.Add(drawing);

                // Get the list of Drawing Line Items
                // Bind the data to the gridview
                drawingLineItemsList = DrawingLineDB.GetDrawingLines(drawingID);
                drawingLineDataGridView.DataSource = drawingLineItemsList;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetDrawings()
        {
            try
            {
                drawingsList = DrawingDB.GetListofDrawings();
                drawingIDComboBox.DataSource = drawingsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void drawingIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.GetDrawingLineItems();
        }

        private void btnAddDrawing_Click(object sender, EventArgs e)
        {
            AddModifyDrawing addNewDrawing = new AddModifyDrawing();
            addNewDrawing.addDrawing = true;
            DialogResult result = addNewDrawing.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetDrawings();
                drawing = addNewDrawing.drawing;
                drawingIDComboBox.SelectedItem = drawing.DrawingID;
                drawingBindingSource.Clear();
                drawingBindingSource.Add(drawing);
                drawingLineItemsList = new List<DrawingLine>();
                drawingLineDataGridView.DataSource = drawingLineItemsList;
                
            }
            else if (result == DialogResult.Cancel)
            {
            }
            else
            {
                GetDrawings();
            }

        }

        private void btnModifyDrawing_Click(object sender, EventArgs e)
        {
            AddModifyDrawing modifyDrawing = new AddModifyDrawing();
            modifyDrawing.addDrawing = false;
            modifyDrawing.drawing = drawing;
            DialogResult result = modifyDrawing.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetDrawings();
                drawing = modifyDrawing.drawing;
                drawingIDComboBox.SelectedItem = drawing.DrawingID;
                drawingBindingSource.Clear();
                drawingBindingSource.Add(drawing);
            }
            else
            {
                GetDrawings();
            }
        }
        
        private void btnAddLineItems_Click(object sender, EventArgs e)
        {
            AddLineItems addLineItems = new AddLineItems();
            addLineItems.drawing = drawing;
            addLineItems.drawingLineItemsList = drawingLineItemsList;
            DialogResult result = addLineItems.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetDrawings();
                drawing = addLineItems.drawing;
                drawingIDComboBox.SelectedItem = drawing.DrawingID;
                drawingBindingSource.Clear();
                drawingBindingSource.Add(drawing);
                drawingLineItemsList = addLineItems.drawingLineItemsList;
                drawingLineDataGridView.DataSource = drawingLineItemsList;
            }
        }

        private void toolMnuOpenParts_Click(object sender, EventArgs e)
        {
            PartsPage partsPage = new PartsPage();
            partsPage.ShowDialog();
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock();
            addStock.drawingLineItems = drawingLineItemsList;
            addStock.drawing = drawing;
            addStock.ShowDialog();
        }

        private void toolmnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{AboutandHelp.About()}", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingMainForm printing = new PrintingMainForm();
            printing.drawing = drawing;
            printing.drawingLineItems = drawingLineItemsList;
            printing.ShowDialog();
        }

        // Sets Combobox to upper case when typing
        private void drawingIDComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
