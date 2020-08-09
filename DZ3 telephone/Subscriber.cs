using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DZ3_telephone
{
    public class Subscriber
    {
        private PictureBox photo;

        private string name;
        private string phone;
        private string work;
        private string address;
        private string category;

        public Subscriber() { }

        public Subscriber(PictureBox picture, string name, string phone, string work, string address)
        {
            Photo = picture;
            this.Name = name;
            this.Phone = phone;
            this.Work = work;
            this.Address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Work { get => work; set => work = value; }
        public string Address { get => address; set => address = value; }
        public PictureBox Photo { get => photo; set => photo = value; }
        public string Category { get => category; set => category = value; }
    }
}
