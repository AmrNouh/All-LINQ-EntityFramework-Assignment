using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstPostsCRUD.CustomControl
{
    public partial class PostControl : UserControl
    {
        public PostControl()
        {
            InitializeComponent();
        }

        private string _image;
        private string _title;
        private string _body;
        private string _date;
        private string _time;




        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        public string Body { get => _body; set { _body = value; lblPostBody.Text = value; } }

        public string Date
        {
            get { return _date; }
            set { _date = value; lblDate.Text = value.ToString(); }
        }

        public string Time { get => _time; set { _time = value; lblTime.Text = value.ToString(); } }

        public string Image { get => _image; set { _image = value; PicPostImage.Image = System.Drawing.Image.FromFile(value); } }

    }
}
