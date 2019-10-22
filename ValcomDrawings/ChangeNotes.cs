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
                    string changeNotes = $"{DateTime.Now.ToShortDateString()}{Environment.NewLine}User: {Environment.UserName.ToUpper()}{Environment.NewLine}Note: {txtAddChanges.Text}";
                    Drawing newDrawing = new Drawing
                    {
                        Changes = txtChangeList.Text += Environment.NewLine + changeNotes + Environment.NewLine,
                        AddedBy = drawing.AddedBy,
                        BOMDescription = drawing.BOMDescription,
                        DateCreated = drawing.DateCreated,
                        DateModifedNotNull = DateTime.Now,
                        NSN = drawing.NSN
                    };

                    DrawingDB.UpdateDrawing(drawing, newDrawing);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    string changeNotes = $"{DateTime.Now.ToShortDateString()}{Environment.NewLine}User: {Environment.UserName.ToUpper()}{Environment.NewLine}Note: {txtAddChanges.Text}";
                    Drawing newDrawing = new Drawing
                    {
                        Changes = txtChangeList.Text = changeNotes + Environment.NewLine,
                        AddedBy = drawing.AddedBy,
                        BOMDescription = drawing.BOMDescription,
                        DateCreated = drawing.DateCreated,
                        DateModifedNotNull = DateTime.Now,
                        NSN = drawing.NSN,
                        ID = drawing.ID
                    };

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
