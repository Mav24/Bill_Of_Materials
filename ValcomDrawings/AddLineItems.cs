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
    public partial class AddLineItems : Form
    {
        public AddLineItems()
        {
            InitializeComponent();
        }

        
        public Drawing drawing;
        public DrawingLine drawingLine;
        private DrawingLine newDrawingLine;
        public List<DrawingLine> drawingLineItemsList;
        private List<Parts> parts;



        private void AddLineItems_Load(object sender, EventArgs e)
        {
            this.Text = $"Add Line Items to Drawing: {drawing.DrawingID} ";
            // Puts DrawingID in to text box
            txtDrawingID.Text = drawing.DrawingID;

            // Loads the Part list and binds it to the parts combobox
            parts = PartsDB.GetPartsList();
            cboBoxParts.DataSource = parts;
            cboPartsDescription.DataSource = parts;
            cboPartsDescription.SelectedIndex = -1;
            cboBoxParts.SelectedIndex = -1;



            // Fills datagrid with current line Items for current drawing
            drawingLineDataGridView.DataSource = drawingLineItemsList;

            

            // Get Next Line Item number
            
            FindLastLineItemNumber();

        }

        // Finds the last number in Line Items and set it + 1
        private void FindLastLineItemNumber()
        {
            if (drawingLineDataGridView.Rows.Count > 0)
            {
                int rowIndex = drawingLineDataGridView.Rows.Count - 1;
                int value = (int)drawingLineDataGridView.Rows[rowIndex].Cells[2].Value + 1;
                txtLineNumber.Text = value.ToString();
            }
            else
            {
                txtLineNumber.Text = "1";
            }
        }
        #region Might need this if i move towards making this for allow edits
        //private void EnableControls(bool value)
        //{
        //    txtLineNumber.Enabled = value;
        //    txtQANotes.Enabled = value;
        //    txtDWGNO.Enabled = value;
        //    cboBoxParts.Enabled = value;
        //    txtIndentFactor.Enabled = value;
        //    txtUnits.Enabled = value;
        //    txtQTYU.Enabled = value;
        //    txtComments.Enabled = value;
        //}
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                newDrawingLine = new DrawingLine();
                newDrawingLine.LineNumber = int.Parse(txtLineNumber.Text);
                newDrawingLine.ProductionCode = cboProductionCode.Text;
                newDrawingLine.IndentFactor = int.Parse(txtIndentFactor.Text);
                newDrawingLine.Units = txtUnits.Text;
                newDrawingLine.QTYU = double.Parse(txtQTYU.Text);
                newDrawingLine.DWGNO = txtDWGNO.Text;
                newDrawingLine.PartID = cboBoxParts.Text;
                newDrawingLine.PartDescription = cboPartsDescription.Text;
                newDrawingLine.QANote = txtQANotes.Text;
                newDrawingLine.Comment = txtComments.Text;
                DrawingLineDB.AddLineItem(drawing, newDrawingLine);
                PopulateDataGridView();
                ClearTextBoxes();
                // find last line item number
                FindLastLineItemNumber();
                           
                
            }

        }

        private void SortDataGrid()
        {
            drawingLineDataGridView.DataSource = drawingLineItemsList.OrderBy(x => x.LineNumber).ToList();
        }

        // Clears all text boxes after entery.
        private void ClearTextBoxes()
        {
            txtLineNumber.Clear();
            txtQANotes.Clear();
            txtDWGNO.Clear();
            txtComments.Clear();
            txtQTYU.Clear();
            txtUnits.Clear();
            txtIndentFactor.Clear();
            cboBoxParts.SelectedValue = -1;
            cboPartsDescription.SelectedIndex = -1;
        }


        private bool IsValidate()
        {
            return
                Validator.IsPresent(txtDWGNO) &&
                Validator.IsPresent(txtIndentFactor) &&
                Validator.IsNumber(txtIndentFactor) &&
                Validator.IsPresent(txtLineNumber) &&
                Validator.IsNumber(txtLineNumber) &&
                Validator.IsPresent(txtQTYU) &&
                Validator.IsDecimal(txtQTYU) &&
                Validator.IsPresent(txtUnits) &&
                Validator.IsPresentCombo(cboProductionCode) &&
                Validator.IsPresentCombo(cboBoxParts) &&
                Validator.IsPresentCombo(cboPartsDescription);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Did you make any changes to the Drawing: {drawing.DrawingID}?", "Changes made?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ChangeNotes changeNotes = new ChangeNotes();
                changeNotes.drawing = drawing;
                DialogResult result = changeNotes.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void btnDeleteLineItem_Click(object sender, EventArgs e)
        {
            
            if (drawingLineDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this line item from the list of line items?", 
                    "Confirm delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int rowId = (int)drawingLineDataGridView.CurrentRow.Cells[0].Value;
                    DrawingLineDB.DeleteLineItems(rowId);
                    // refresh DataGridView
                    PopulateDataGridView();
                    // find last line item number
                    FindLastLineItemNumber();
                }
            }
        }

        private void PopulateDataGridView()
        {
            string drawingID = txtDrawingID.Text;
            drawingLineItemsList = DrawingLineDB.GetDrawingLines(drawingID);
            drawingLineDataGridView.DataSource = drawingLineItemsList;
        }

        private void drawingLineDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12)
            {
                drawingLine = new DrawingLine();
                drawingLine.ID = (int)drawingLineDataGridView.SelectedCells[0].Value;
                drawingLine.DLDrawingID = drawingLineDataGridView.SelectedCells[1].Value.ToString();
                drawingLine.LineNumber = (int)drawingLineDataGridView.SelectedCells[2].Value;
                drawingLine.ProductionCode = drawingLineDataGridView.SelectedCells[3].Value.ToString();
                drawingLine.PartID = drawingLineDataGridView.SelectedCells[4].Value.ToString();
                drawingLine.DWGNO = drawingLineDataGridView.SelectedCells[5].Value.ToString();
                drawingLine.PartDescription = drawingLineDataGridView.SelectedCells[6].Value.ToString();
                drawingLine.QTYU = (double)drawingLineDataGridView.SelectedCells[7].Value;
                drawingLine.Units = drawingLineDataGridView.SelectedCells[8].Value.ToString();
                drawingLine.IndentFactor = (int)drawingLineDataGridView.SelectedCells[9].Value;
                drawingLine.QANote = drawingLineDataGridView.SelectedCells[10].Value.ToString();
                drawingLine.Comment = drawingLineDataGridView.SelectedCells[11].Value.ToString();
                EditLineItem editLineItem = new EditLineItem();
                editLineItem.drawingLine = drawingLine;
                DialogResult result = editLineItem.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PopulateDataGridView();
                }
            }
        }

        private void cboBoxParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBoxParts.SelectedIndex > -1)
            {
                cboPartsDescription.SelectedValue = cboBoxParts.SelectedValue;
            }
        }

        // Marked for delete, Don't think i need this method, seems to work with out this
        private void cboPartsDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboPartsDescription.SelectedIndex > -1)
            //{
            //    //cboBoxParts.SelectedValue = cboProductionCode.SelectedValue;
            //}
        }
    }
}
