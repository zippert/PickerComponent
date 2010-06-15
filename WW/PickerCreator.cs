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
        private PickerCreatorHandler handler;
        public PickerCreator()
        {
            InitializeComponent();
            handler = new PickerCreatorHandler();
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

        public void addDebugData(String key, String value)
        {
            handler.Add(key, value);
        }
    }
}
