using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WW
{
    public partial class PickerCreator : UserControl
    {
        public delegate void UserSelectedHandler(String key, String value);

        public event UserSelectedHandler OK_pressed;

        private PickerCreatorHandler handler;
        public PickerCreator()
        {
            InitializeComponent();
            handler = new PickerCreatorHandler();
            handler.Add("test", "banan");
            handler.Add("finsk", "pinne");
            initFields();
        }

        private void initFields()
        {
            listBox.Items.Clear();
            
            listBox.Items.AddRange(handler.GetAllKeys());            
        }

        private void searchTextChanged(object sender, EventArgs e)
        {
            String[] results = handler.Get(searchTextField.Text);
            listBox.Items.Clear();
            listBox.Items.AddRange(results);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (OK_pressed != null)
            {
                string selected = (string)listBox.SelectedItem;
                OK_pressed(selected, handler.GetValue(selected));
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            NewItemDialog newDialog = new NewItemDialog(this);
            newDialog.Show();
        }

        internal Boolean saveNewValue(string key, string value)
        {
            if (handler.contains(key))
            {
                return false;
            }

            handler.Add(key, value);
            listBox.Items.Add(key);

            return true;
        }

        private void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            handler.Remove((string)listBox.SelectedItem);
            listBox.Items.Remove(listBox.SelectedItem);
        }
    }
}
