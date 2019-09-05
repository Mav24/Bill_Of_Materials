using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValcomDrawings
{
    class Validator
    {

        /// <summary>
        /// Checks All Text box entries
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsPresent(TextBox textBox)
        {
            if(string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(textBox.Tag + " is a required field!", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsPresentCombo(ComboBox comboBox)
        {
            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {
                MessageBox.Show(comboBox.Tag + " is a required field!", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check to see if number
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsNumber(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int number))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{textBox.Tag} Is numeric entry only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }

        public static bool IsDecimal(TextBox textBox)
        {
            if (float.TryParse(textBox.Text, out float number))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{textBox.Tag} Is numeric entry only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }
    }
}
