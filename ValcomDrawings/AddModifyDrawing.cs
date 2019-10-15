using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValcomData;

namespace ValcomDrawings
{
    public partial class AddModifyDrawing : Form
    {
        public AddModifyDrawing()
        {
            InitializeComponent();
        }

        public bool addDrawing;
        public Drawing drawing;
        private Drawing newDrawing;
        
        private void AddModifyDrawing_Load(object sender, EventArgs e)
        {

            if (addDrawing)
            {
                btnDelete.Visible = false;
                this.Text = "Add Drawing";
                txtDrawingID.Enabled = true;
                txtAddedBy.Enabled = true;
                newDrawing = new Drawing();
            }
            else
            {
                btnDelete.Visible = true;
                this.Text = "Modify Drawing";
                newDrawing = new Drawing();
                FillFormWithInfo();

            }

            drawingBindingSource.Add(newDrawing);
        }

        private void FillFormWithInfo()
        {
            newDrawing.DrawingID = drawing.DrawingID;
            newDrawing.DateModified = drawing.DateModified;
            newDrawing.BOMDescription = drawing.BOMDescription;
            newDrawing.NSN = drawing.NSN;
            newDrawing.AddedBy = drawing.AddedBy;
            newDrawing.Changes = drawing.Changes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                if (addDrawing)
                {
                    try
                    {
                        if (DrawingDB.AddDrawing(newDrawing))
                        {
                            drawing = newDrawing;
                            MessageBox.Show($"New Drawing {drawing.DrawingID} added to the database", "Drawing Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            
                        }
                        else
                        {
                            MessageBox.Show($"Sorry Drawing: {txtDrawingID.Text} already exist in the database.", "Drawing not added!");
                            ClearTextBoxes();

                        }

                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    try
                    {
                        if (!DrawingDB.UpdateDrawing(drawing, newDrawing))
                        {
                            
                            MessageBox.Show($"Another user has updated/deleted Drawing: {drawing.DrawingID} please try again", "DataBase Error!");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            drawing = newDrawing;
                            MessageBox.Show($"Drawing: {drawing.DrawingID} updated!", "Update successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }

        }

        private void ClearTextBoxes()
        {
            txtDrawingID.Clear();
            txtNSN.Clear();
            txtBOMDescription.Clear();
            txtAddedBy.Clear();
            txtDrawingID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are you sure you want to delete Drawing: {drawing.DrawingID}\n This will also delete all drawing line items", 
                "Confirm delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int drawingID = drawing.ID;
                    DrawingDB.DeleteDrawing(drawingID);
                    DrawingLineDB.DeleteMultipleLineItems(drawing.DrawingID);
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("A concurrency error occurred. " + "The row/rows were deleted.", "Concurrency Exeption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DataException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Sql server error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
                }

                this.Close();

            }


        }

        private bool IsValidate()
        {
            return
                Validator.IsPresent(txtDrawingID) &&
                Validator.IsPresent(txtBOMDescription) &&
                Validator.IsPresent(txtAddedBy);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (addDrawing)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        // only allows numbers and dash
        private void txtNSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
