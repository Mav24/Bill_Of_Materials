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
    public partial class PartsPage : Form
    {
        public PartsPage()
        {
            InitializeComponent();
        }
        private List<Parts> allparts;
        private Parts part;

        private void PartsPage_Load(object sender, EventArgs e)
        {
            GetAllParts();

        }

        private void GetAllParts()
        {
            allparts = PartsDB.GetPartsList();
            partsDataGridView.DataSource = allparts;
        }

        private void partsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                part = new Parts();
                part.ID = (int)partsDataGridView.SelectedCells[0].Value;
                part.PartID = partsDataGridView.SelectedCells[1].Value.ToString();
                part.PartDescription = partsDataGridView.SelectedCells[2].Value.ToString();
                part.DefaultSupplier = partsDataGridView.SelectedCells[3].Value.ToString();
                part.Stock = partsDataGridView.SelectedCells[4].Value.ToString();
                part.QANote = partsDataGridView.SelectedCells[5].Value.ToString();
                AddModifyParts modifyParts = new AddModifyParts();
                modifyParts.part = part;
                modifyParts.addPart = false;
                DialogResult result = modifyParts.ShowDialog();
                if (result == DialogResult.OK)
                {
                    GetAllParts();
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddModifyParts addModifyParts = new AddModifyParts();
            addModifyParts.addPart = true;
            addModifyParts.part = part;
            DialogResult result = addModifyParts.ShowDialog();
            if (result == DialogResult.OK)
            {
                GetAllParts();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.ToUpper();
            
            List<Parts> searchedParts = new List<Parts>();
            if (IsValidate())
            {
                if (rdoPartId.Checked)
                {
                    searchedParts = allparts.Where(x => x.PartID.Contains(searchValue)).ToList();
                    var count = searchedParts.Count;
                    if (count > 0)
                    {
                        partsDataGridView.DataSource = searchedParts;
                    }
                    else
                    {
                        MessageBox.Show($"Sorry {searchValue} was not found in the list of parts!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearch.Focus();
                    }
                }
                else
                {
                    searchedParts = allparts.Where(x => x.PartDescription.Contains(searchValue)).ToList();
                    var count = searchedParts.Count;
                    if (count > 0)
                    {
                        partsDataGridView.DataSource = searchedParts;
                    }
                    else
                    {
                        MessageBox.Show($"Sorry {searchValue} was not found in the list of parts!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearch.Focus();
                    }
                }
                
                
            }
            
           
        }

        private bool IsValidate()
        {
            return
                Validator.IsPresent(txtSearch);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (partsDataGridView.SelectedRows.Count > 0)
            {
                
                if (MessageBox.Show("Are you sure you want to delete the selected row(s) from the database?", 
                    "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in partsDataGridView.SelectedRows)
                    {
                        int Id = (int)row.Cells[0].Value;
                        if (!PartsDB.DeletePart(Id))
                        {
                            MessageBox.Show("Sorry that part has already been deleted by another user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    GetAllParts();

                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, new EventArgs());
            }
        }

        private void btnGetAllParts_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            GetAllParts();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
