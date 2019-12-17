using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Testing of creating connection xml file
            //string connection = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n " +
            //    "<Connection>data source=SHELDONHP\\SQLEXPRESSTEST;initial catalog=ValcomPos;integrated security=True </Connection> ";
            //string path = "csValcom.xml";
            //if (!File.Exists(path))
            //{
            //    MessageBox.Show("File doesn't exist but will be created!");
            //    using (StreamWriter file = new StreamWriter("csValcom.xml"))
            //    {

            //        file.WriteLine(connection);
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("File Exist");
            //    Process.Start("notepad.exe", path);
            //}
            #endregion

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
                drawingLineDataGridView.DataSource = DrawingLineDB.GetDrawingLines(drawing.DrawingID);
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
                // Sets list of drawings to combobox datasource.
                drawingIDComboBox.DataSource = DrawingDB.GetListofDrawings();
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
                
            }
            else if (result != DialogResult.Cancel)
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
            DialogResult result = addLineItems.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetDrawings();
                drawing = addLineItems.drawing;
                drawingIDComboBox.SelectedItem = drawing.DrawingID;
                drawingBindingSource.Clear();
                drawingBindingSource.Add(drawing);
            }
        }

        private void toolMnuOpenParts_Click(object sender, EventArgs e)
        {
            PartsPage partsPage = new PartsPage();
            partsPage.ShowDialog();
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            // Opens page for user to add stock before creating BOM.
            AddStock addStock = new AddStock();
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
            printing.ShowDialog();
            
        }

        // Sets Combobox to upper case when typing
        private void drawingIDComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void suppliersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SuppliersPage suppliersPage = new SuppliersPage();
            suppliersPage.ShowDialog();
        }
    }
}
