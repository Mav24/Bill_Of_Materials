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
    public partial class ChangeNotes : Form
    {
        public ChangeNotes()
        {
            InitializeComponent();
        }
        

        public Drawing drawing;

        private void ChangeNotes_Load(object sender, EventArgs e)
        {
            txtChangeList.Text = drawing.Changes;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                if (!string.IsNullOrWhiteSpace(txtChangeList.Text))
                {
                    string changeNotes = $"{DateTime.Now} {txtAddChanges.Text}";
                    Drawing newDrawing = new Drawing();
                    newDrawing.Changes = txtChangeList.Text += Environment.NewLine + changeNotes + Environment.NewLine;
                    newDrawing.AddedBy = drawing.AddedBy;
                    newDrawing.BOMDescription = drawing.BOMDescription;
                    newDrawing.DateCreated = drawing.DateCreated;
                    newDrawing.DateModifedNotNull = DateTime.Now;
                    newDrawing.NSN = drawing.NSN;

                    DrawingDB.UpdateDrawing(drawing, newDrawing);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    string changeNotes = $"{DateTime.Now} {txtAddChanges.Text}";
                    Drawing newDrawing = new Drawing();
                    newDrawing.Changes = txtChangeList.Text = changeNotes + Environment.NewLine;
                    newDrawing.AddedBy = drawing.AddedBy;
                    newDrawing.BOMDescription = drawing.BOMDescription;
                    newDrawing.DateCreated = drawing.DateCreated;
                    newDrawing.DateModifedNotNull = DateTime.Now;
                    newDrawing.NSN = drawing.NSN;
                    newDrawing.ID = drawing.ID;

                    DrawingDB.UpdateDrawing(drawing, newDrawing);
                    this.DialogResult = DialogResult.OK;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private bool IsValidate()
        {
            return
            Validator.IsPresent(txtAddChanges);
        }
    }
}
