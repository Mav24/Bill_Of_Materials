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
    public partial class PrintingMainForm : Form
    {
        public Drawing drawing;

        public PrintingMainForm()
        {
            InitializeComponent();
        }
              

        private void PrintingMainForm_Load(object sender, EventArgs e)
        {
            LoadInfo();   
        }

        private void LoadInfo()
        {
            try
            {
                this.Text = $"Drawing Printout for {drawing.BOMDescription}";
                ReportParameter[] rParams = new ReportParameter[]
                {
                new ReportParameter("Description", drawing.BOMDescription),
                new ReportParameter("PrintDate", DateTime.Now.ToLongDateString())
                };
                reportViewer1.LocalReport.SetParameters(rParams);
                DataTable1BindingSource.DataSource = DrawingLineDB.GetDrawingLines(drawing.DrawingID);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                MessageBox.Show("Look like there was an issue trying to display the report for printing, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
