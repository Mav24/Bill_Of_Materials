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
        private List<Parts> parts;

        private void AddLineItems_Load(object sender, EventArgs e)
        {
            // Sets form title.
            this.Text = $"Add Line Items To: {drawing.BOMDescription} ";
            
            // Puts DrawingID in to text box
            txtDrawingID.Text = drawing.DrawingID;
            
            // Loads the Part list and binds it to the parts combobox
            parts = PartsDB.GetPartsList();
            cboBoxParts.DataSource = parts;
            cboPartsDescription.DataSource = parts;
            cboPartsDescription.SelectedIndex = -1;
            cboBoxParts.SelectedIndex = -1;

            // Fills datagrid with current line Items for current drawing ID.
            //drawingLineDataGridView.DataSource = drawingLineItemsList;
            drawingLineDataGridView.DataSource = DrawingLineDB.GetDrawingLines(drawing.DrawingID);
            
            // Calculates the next line Item number.            
            FindLastLineItemNumber();

        }

        // Finds the last number in Line Items and set it + 1
        private void FindLastLineItemNumber()
        {
            if (drawingLineDataGridView.Rows.Count > 0)
            {
                int rowIndex = drawingLineDataGridView.Rows.Count - 1;
                int value = (int)drawingLineDataGridView.Rows[rowIndex].Cells[2].Value + 1;
                #region Scrolls to the selected row Marked for delete Sept 27 2019
                // Seclects last row in datagridview
                //drawingLineDataGridView.Rows[rowIndex].Selected = true;


                // Scrolls to the last row
                //drawingLineDataGridView.FirstDisplayedScrollingRowIndex = rowIndex;
                #endregion

                // Set focus on last row in datagridview.
                drawingLineDataGridView.Rows[rowIndex].Cells[2].Selected = true;
                txtLineNumber.Text = value.ToString();
            }
            else
            {
                txtLineNumber.Text = "1";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                // Gets info of newly entered line item.
                GetLineItem();

                // Creates new Part item
                Parts newParts = new Parts()
                {
                    PartID = cboBoxParts.Text.ToUpper(),
                    PartDescription = cboPartsDescription.Text.ToUpper(),
                    DefaultSupplier = "N/A",
                    Stock = "0",
                    QANote = ""
                };

                // Adds new part to parts database. If it exist then it will not add.
                PartsDB.AddPart(newParts);
                // Adds new line item to the drawing line items database
                DrawingLineDB.AddLineItem(drawing, newDrawingLine);

                ClearTextBoxes();

                // Updates all data sources
                UpdateDataSources();
                // Finds and set new line item.
                FindLastLineItemNumber();


            }

        }

        private void GetLineItem()
        {
            newDrawingLine = new DrawingLine();
            newDrawingLine.LineNumber = int.Parse(txtLineNumber.Text);
            newDrawingLine.ProductionCode = cboProductionCode.Text;
            newDrawingLine.IndentFactor = int.Parse(txtIndentFactor.Text);
            newDrawingLine.Units = txtUnits.Text;
            newDrawingLine.QTYU = double.Parse(txtQTYU.Text);
            newDrawingLine.DWGNO = txtDWGNO.Text;
            newDrawingLine.PartID = cboBoxParts.Text.ToUpper();
            newDrawingLine.PartDescription = cboPartsDescription.Text.ToUpper();
            newDrawingLine.QANote = txtQANotes.Text;
            newDrawingLine.Comment = txtComments.Text;
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
            cboProductionCode.SelectedIndex = -1;
            cboBoxParts.SelectedIndex = -1;
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
                // Gets Line Item number
                var lineItemNumber = drawingLineDataGridView.CurrentRow.Cells[2].Value;

                if (MessageBox.Show($"Are you sure you want to delete line item {lineItemNumber}? from the list of line items?", 
                    "Confirm delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Get row id of the line item 
                    int rowId = (int)drawingLineDataGridView.CurrentRow.Cells[0].Value;
                    
                    // Sends Id to the delete method.
                    DrawingLineDB.DeleteLineItems(rowId);

                    // refresh DataGridView
                    UpdateDataSources();
                    // find last line item number
                    FindLastLineItemNumber();
                }
            }
        }

        private void UpdateDataSources()
        {
            parts = PartsDB.GetPartsList();
            cboBoxParts.DataSource = parts;
            cboPartsDescription.DataSource = parts;
            cboPartsDescription.SelectedIndex = -1;
            cboBoxParts.SelectedIndex = -1;
            drawingLineDataGridView.DataSource = DrawingLineDB.GetDrawingLines(drawing.DrawingID);
        }

        // Editing button in the datagridview
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
                    UpdateDataSources();
                    //Keeps selected row after edit, needs loop so it can select the line by the id of the line
                    foreach (DataGridViewRow row in drawingLineDataGridView.Rows)
                    {
                        if (row.Cells[0].Value.Equals(editLineItem.newDrawingLine.ID))
                        {
                            row.Cells[2].Selected = true;
                        }
                    }
                    int rowIndex = drawingLineDataGridView.Rows.Count - 1;
                    int value = (int)drawingLineDataGridView.Rows[rowIndex].Cells[2].Value + 1;
                    txtLineNumber.Text = value.ToString();

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

        // Seems to work now that i have it >= 0.. keep eye on this 
        private void cboPartsDescription_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboPartsDescription.SelectedIndex >= 0)
            {
                cboBoxParts.SelectedValue = cboProductionCode.SelectedValue;
            }
        }

        private void cboboxesToUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
