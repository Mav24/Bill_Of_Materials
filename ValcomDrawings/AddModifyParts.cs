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
    public partial class AddModifyParts : Form
    {
        public AddModifyParts()
        {
            InitializeComponent();
        }

        public bool addPart;
        public Parts part;
        private Parts newPart;

        private void AddModifyParts_Load(object sender, EventArgs e)
        {
            if (addPart)
            {
                this.Text = "Add New part";
                btnUpdate.Text = "Add";
                newPart = new Parts();

            }
            else
            {
                this.Text = "Edit part";
                newPart = new Parts();
                FillFormWithInfo();
            }

            partsBindingSource.Add(newPart);
            

        }

        private void FillFormWithInfo()
        {
            newPart.PartID = part.PartID;
            newPart.PartDescription = part.PartDescription;
            newPart.DefaultSupplier = part.DefaultSupplier;
            newPart.Stock = part.Stock;
            newPart.QANote = part.QANote;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                if (addPart)
                {
                    try
                    {
                        if (PartsDB.AddPart(newPart))
                        {
                            part = newPart;
                            MessageBox.Show($"New Part {newPart.PartID} was added to database!", "Part Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show($"Sorry Part: {newPart.PartID} already exist in the database.", "Part Not added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    if (!PartsDB.UpdatePart(part, newPart))
                    {
                        MessageBox.Show($"Another user has updated/Deleted Part: {part.PartID} please try again,", "DataBase Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        part = newPart;
                        MessageBox.Show($"Part {part.PartID} updated!", "Update successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private bool IsValidate()
        {
            return
                Validator.IsPresent(txtpartID) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsPresent(txtSupplier) &&
                Validator.IsPresent(txtStock) &&
                Validator.IsNumber(txtStock);
        }
    }
}
