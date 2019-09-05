using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValcomDrawings
{
    public partial class QuantityOfJob : Form
    {
        public QuantityOfJob()
        {
            InitializeComponent();
        }
        public int amount;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            amount = int.Parse(txtAmount.Text);
            DialogResult = DialogResult.OK;
        }

        private bool IsValidate()
        {
            return
                Validator.IsPresent(txtAmount) &&
                Validator.IsNumber(txtAmount);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
