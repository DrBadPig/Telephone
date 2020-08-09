using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ3_telephone
{
    public partial class ViewForm : Form
    {
        Subscriber subscriber;
        public ViewForm(Subscriber sub)
        {
            InitializeComponent();

            subscriber = sub;

            contactPictureBox.Image = subscriber.Photo.Image;
            name_textBox.Text = subscriber.Name;
            work_textBox.Text = subscriber.Work;
            phone_textBox.Text = subscriber.Phone;
            address_textBox.Text = subscriber.Address;
            category_textBox.Text = subscriber.Category;
        }
    }
}
