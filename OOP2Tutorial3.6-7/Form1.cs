using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Tutorial3._5_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stringList.OnItemAdd += StringListOnItemAdd;
            stringList.OnRemoveAt += StringListOnRemoveAt;
        }

        private void StringListOnRemoveAt(int itemindex)
        {
            ItemsListBox.Items.RemoveAt(itemindex);
        }

        private void StringListOnItemAdd(int itemindex, string item)
        {
            ItemsListBox.Items.Insert(itemindex, item);
        }

        ObservableList<string> stringList = new ObservableList<string>();

        private void AddItem_Click(object sender, EventArgs e)
        {
            stringList.Add(ItemTextBox.Text);
        }


        private void RemoveItem_Click(object sender, EventArgs e)
        {
            stringList.RemoveAt(ItemsListBox.SelectedIndex);
        }
    }
}