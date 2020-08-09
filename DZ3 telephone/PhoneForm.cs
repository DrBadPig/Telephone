using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DZ3_telephone
{
    public partial class PhoneForm : Form
    {
        List<Subscriber> contacts;
        int current = 0;
        int currentGroup = 0;

        public PhoneForm()
        {
            InitializeComponent();
            contacts = new List<Subscriber>();

            listView1.Columns.Add("№", 30, HorizontalAlignment.Center);
            listView1.Columns.Add("Name", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Phone", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Address", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Work", 200, HorizontalAlignment.Right);

            string name = "Default";

            listView1.Groups.Add(Convert.ToString(currentGroup), name);
            currentGroup++;

            listToolStripMenuItem.DropDownItems.Add(name);
        }

        private void createContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm(this);
            addContactForm.Owner = this;

            DialogResult res = addContactForm.ShowDialog();
        }

        public void AddContact(Subscriber sub)
        {
            contacts.Add(sub);

            ListViewItem item = new ListViewItem(Convert.ToString(current));

            current++;

            item.SubItems.Add(sub.Name);
            item.SubItems.Add(sub.Phone);
            item.SubItems.Add(sub.Address);
            item.SubItems.Add(sub.Work);

            bool wehavethisgroup = false;
            int grIndex = 0;

            for (int i = 0; i < listView1.Groups.Count; i++)
            {
                if (listView1.Groups[i].Header == sub.Category)
                {
                    wehavethisgroup = true;
                    grIndex = i;
                    break;
                }
            }


            if (!wehavethisgroup)
            {
                listView1.Groups.Add(Convert.ToString(currentGroup), sub.Category);

                currentGroup++;

                listToolStripMenuItem.DropDownItems.Add(sub.Category);

                ListViewGroup group = listView1.Groups[listView1.Groups.Count - 1];

                item.Group = group;
            }
            else
            {
                ListViewGroup group = listView1.Groups[grIndex];

                item.Group = group;
            }

            listView1.Items.Add(item);
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            int i = listView1.FocusedItem.Index;
            OpenEditForm addContactForm = new OpenEditForm(contacts[i]);
            addContactForm.Owner = this;

            DialogResult res = addContactForm.ShowDialog();


            bool wehavethisgroup = false;
            int grIndex = 0;

            for (int k = 0; k < listView1.Groups.Count; k++)
            {
                if (listView1.Groups[k].Header == contacts[i].Category)
                {
                    wehavethisgroup = true;
                    grIndex = k;
                    break;
                }
            }


            if (!wehavethisgroup)
            {
                listView1.Groups.Add(Convert.ToString(currentGroup), contacts[i].Category);

                currentGroup++;

                listToolStripMenuItem.DropDownItems.Add(contacts[i].Category);

                ListViewGroup group = listView1.Groups[listView1.Groups.Count - 1];

                listView1.FocusedItem.Group = group;
            }
            else
            {
                ListViewGroup group = listView1.Groups[grIndex];

                listView1.FocusedItem.Group = group;
            }

            listView1.FocusedItem.SubItems[1].Text =
                contacts[i].Name;
            listView1.FocusedItem.SubItems[2].Text =
                contacts[i].Phone;
            listView1.FocusedItem.SubItems[3].Text =
                contacts[i].Address;
            listView1.FocusedItem.SubItems[4].Text =
                contacts[i].Work;
        }

        private void deleteSelectedContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int index = item.Index;

                contacts.RemoveAt(index);

                item.Remove();
            }

            current = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                item.SubItems[0].Text = Convert.ToString(current);
                current++;
            }
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter group name:", "Group name", "Group name", 0, 0);

            bool wehavethisgroup = false;

            for (int k = 0; k < listView1.Groups.Count; k++)
            {
                if (listView1.Groups[k].Header == name)
                {
                    wehavethisgroup = true;
                    break;
                }
            }

            if (!wehavethisgroup)
            {
                listView1.Groups.Add(Convert.ToString(currentGroup), name);

                currentGroup++;

                listToolStripMenuItem.DropDownItems.Add(name);
            }
            else
            {
                MessageBox.Show("You already have this category!", "Shit");
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{

            //}
        }

        private void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter group name:", "Group name", "Group name", 0, 0);

            if (name != "Default")
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Group.Header == name)
                    {
                        listView1.Items[i].Group = listView1.Groups[0];
                        contacts[i].Category = listView1.Groups[0].Header;
                    }
                }

                if (name != null)
                {
                    foreach (ListViewGroup item in listView1.Groups)
                    {
                        if (item.Header == name)
                        {
                            listView1.Groups.Remove(item);
                            break;
                        }
                    }
                }
            } else
            {
                MessageBox.Show("You can not delete Default category!", "Shit");
            }
        }

        private void saveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save contacts";
            saveFileDialog1.Filter = "XML файлы|*.xml";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveContacts(saveFileDialog1.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Load contacts";
            openFileDialog1.Filter = "XML файлы|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadContacts(openFileDialog1.FileName);
                UpdateListView();
            }
        }

        private void SaveContacts(string filename)
        {
            XmlWriter writer;

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineChars = "\r\n";
            settings.Encoding = Encoding.ASCII;
            settings.NewLineOnAttributes = false;

            writer = XmlWriter.Create(filename, settings);

            writer.WriteStartDocument();
            writer.WriteStartElement("Contacts");

            foreach (var item in contacts)
            {
                writer.WriteStartElement("Subscriber");
                writer.WriteElementString("Name", $"{item.Name}");
                writer.WriteElementString("Phone", $"{item.Phone}");
                writer.WriteElementString("Work", $"{item.Work}");
                writer.WriteElementString("Address", $"{item.Address}");
                //writer.WriteElementString("Photo", $"{item.Photo}");
                writer.WriteElementString("Category", $"{item.Category}");
                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
        }

        private void LoadContacts(string filename)
        {
            XmlReader reader = XmlReader.Create(filename);

            Subscriber s = new Subscriber();

            contacts.Clear();
            current = 0;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element || reader.NodeType == XmlNodeType.XmlDeclaration)
                {
                    if (reader.Name == "Name")
                    {
                        s.Name = reader.ReadElementContentAsString();
                    }
                    if (reader.Name == "Phone")
                    {
                        s.Phone = reader.ReadElementContentAsString();
                    }
                    if (reader.Name == "Work")
                    {
                        s.Work = reader.ReadElementContentAsString();
                    }
                    if (reader.Name == "Address")
                    {
                        s.Address = reader.ReadElementContentAsString();
                    }
                    if (reader.Name == "Category")
                    {
                        s.Category = reader.ReadElementContentAsString();

                        StringBuilder builder = new StringBuilder();
                        builder.Append(Application.StartupPath);
                        builder.Append("\\Pictures\\none.jpg");

                        PictureBox contactPictureBox = new PictureBox();

                        string pictureName = String.Format(builder.ToString());

                        Bitmap image = new Bitmap(pictureName);
                        image.SetResolution(200, 200);

                        contactPictureBox.Size = new Size(200, 200);
                        contactPictureBox.Image = image;

                        s.Photo = contactPictureBox;

                        contacts.Add(s);

                        s = new Subscriber();
                        current++;
                    }
                }
            }
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();
            listView1.Groups.Clear();
            listToolStripMenuItem.DropDownItems.Clear();
            currentGroup = 0;

            listView1.Groups.Add(new ListViewGroup($"{currentGroup}", "Default"));
            currentGroup++;

            listToolStripMenuItem.DropDownItems.Add("Default");

            foreach (var item in contacts)
            {
                bool wehavethisgroup = false;
                int grIndex = 0;

                for (int k = 0; k < listView1.Groups.Count; k++)
                {
                    if (listView1.Groups[k].Header == item.Category)
                    {
                        wehavethisgroup = true;
                        grIndex = k;
                        break;
                    }
                }


                ListViewItem item1 = new ListViewItem(Convert.ToString(current));

                current++;

                ListViewGroup gr;

                if (!wehavethisgroup)
                {
                    gr = listView1.Groups.Add(Convert.ToString(currentGroup), item.Category);

                    currentGroup++;

                    listToolStripMenuItem.DropDownItems.Add(item.Category);

                    item1.Group = gr;
                }
                else
                {
                    gr = listView1.Groups[grIndex];
                    item1.Group = gr; 
                }

                item1.SubItems.Add(item.Name);
                item1.SubItems.Add(item.Phone);
                item1.SubItems.Add(item.Address);
                item1.SubItems.Add(item.Work);

                listView1.Items.Add(item1);
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindContactForm findContactForm = new FindContactForm(contacts);
            findContactForm.Owner = this;

            DialogResult res = findContactForm.ShowDialog();
        }
    }
}
