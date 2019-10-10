using Microsoft.Reporting.WinForms;
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
    public partial class PrintingJobAmounts : Form
    {
        public PrintingJobAmounts()
        {
            InitializeComponent();
        }
        public Drawing drawing;
        public List<TempJob> tempDrawingLines;
        public int quantity;

        private void PrintingJobAmounts_Load(object sender, EventArgs e)
        {
            // Set form title.
            Text = $"Order Amount Printout for drawing {drawing.BOMDescription}";
            try
            {
                // Create array for parameters
                ReportParameter[] rParams = new ReportParameter[]
                {
                new ReportParameter("Description", drawing.BOMDescription),
                new ReportParameter("DateCreated", DateTime.Now.ToLongDateString()),
                new ReportParameter("Quanitity", quantity.ToString())
                };

                // Set Parameters
                reportViewer1.LocalReport.SetParameters(rParams);
                
                // Bind List to DataSource.
                DataTable2BindingSource.DataSource = tempDrawingLines;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                MessageBox.Show("Look like there was an issue trying to display the report for printing, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
