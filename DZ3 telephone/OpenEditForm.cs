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
    public partial class OpenEditForm : Form
    {
        Subscriber subscriber;


        public OpenEditForm(Subscriber sub)
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

        private void contactPictureBox_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Application.StartupPath);
            builder.Append("\\Pictures\\");

            openImageFile.Title = "Load image";
            openImageFile.Filter = "PNG картинки|*.png|JPG картинки|*.jpg|JPEG картинки|*.jpeg";
            openImageFile.FilterIndex = 1;
            openImageFile.CheckFileExists = true;
            openImageFile.InitialDirectory = builder.ToString();

            if (openImageFile.ShowDialog() == DialogResult.OK)
            {
                string pictureName = String.Format(openImageFile.FileName);

                Bitmap image = new Bitmap(pictureName);
                image.SetResolution(200, 200);

                contactPictureBox.Size = new Size(200, 200);
                contactPictureBox.Image = image;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            contactPictureBox.Enabled = true;
            name_textBox.Enabled = true;
            work_textBox.Enabled = true;
            phone_textBox.Enabled = true;
            address_textBox.Enabled = true;
            category_textBox.Enabled = true;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (contactPictureBox.Enabled)
            {
                subscriber.Photo = contactPictureBox;

                subscriber.Name = name_textBox.Text;
                subscriber.Work = work_textBox.Text;
                subscriber.Address = address_textBox.Text;
                subscriber.Phone = phone_textBox.Text;
                subscriber.Category = category_textBox.Text;

                this.Close();

            }
            else
            {
                this.Close();
            }
        }

        private void phone_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 43)
            {
                e.Handled = true;
            }
        }
    }
}
