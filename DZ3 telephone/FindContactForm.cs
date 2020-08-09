using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ3_telephone
{
    public partial class FindContactForm : Form
    {
        List<Subscriber> c;

        public FindContactForm(List<Subscriber> c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                foreach (var item in c)
                {
                    string findText = textBox1.Text;

                    if (comboBox1.SelectedIndex == 0)
                    {
                        if (item.Name == findText)
                        {
                            ViewForm addContactForm = new ViewForm(item);
                            addContactForm.Owner = this;

                            DialogResult res = addContactForm.ShowDialog();
                            break;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        if (item.Phone == findText)
                        {
                            ViewForm addContactForm = new ViewForm(item);
                            addContactForm.Owner = this;

                            DialogResult res = addContactForm.ShowDialog();
                            break;
                        }
                    }
                }
            }
        }
    }
}
