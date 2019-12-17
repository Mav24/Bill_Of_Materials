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
    public partial class SuppliersPage : Form
    {
        public SuppliersPage()
        {
            InitializeComponent();
        }

        private Supplier supplier;
        private void SuppliersPage_Load(object sender, EventArgs e)
        {
            GetSuppliers();
            GetSuppliersInfo();
        }

        private void GetSuppliersInfo()
        {
            try
            {
                string supplierName = cboSupplierName.Text;
                supplier = SupplierDB.GetSupplierInfo(supplierName);
                supplierBindingSource.Clear();
                supplierBindingSource.Add(supplier);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GetSuppliers()
        {

            try
            {
                cboSupplierName.DataSource = SupplierDB.GetSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
