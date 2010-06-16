using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WW
{
    public partial class NewItemDialog : Form
    {
        private PickerCreator pickerInstance;

        public NewItemDialog(PickerCreator pickerInstance)
        {
            this.pickerInstance = pickerInstance;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!keyTextBox.Text.Equals("") && !valueTextBox.Text.Equals(""))
            {
                Boolean retVal = pickerInstance.saveNewValue(keyTextBox.Text, valueTextBox.Text);
                if (!retVal)
                {
                    errorProvider1.SetError(button1, "This value already exists");
                }
                else
                {
                    errorProvider1.SetError(button1, "");
                }
            }
            else
            {
                errorProvider1.SetError(button1, "Both fields must contain a valid content");
            }
        }
    }
}
