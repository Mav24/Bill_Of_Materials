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
        public PrintingMainForm()
        {
            InitializeComponent();
        }
        public List<DrawingLine> drawingLineItems;
        public Drawing drawing;

        private void PrintingMainForm_Load(object sender, EventArgs e)
        {
            DataTable1BindingSource.DataSource = drawingLineItems;
            this.reportViewer1.RefreshReport();
        }
    }
}
