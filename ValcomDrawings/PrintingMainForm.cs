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
    public partial class PrintingMainForm : Form
    {
        public PrintingMainForm()
        {
            InitializeComponent();
        }

        private void PrintingMainForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
