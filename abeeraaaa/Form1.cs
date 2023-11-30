using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace abeeraaaa
{
    
        public partial class Form1 : Form
        {
        private object txtlast;
        private string first;

        public object txtname { get; private set; }

        public Form1()
            {
                InitializeComponent();
            }

        

            private void button1_Click(object sender, EventArgs e)
            {
                string First = firstname.Text;
                string last = lastname.Text;
            firstname.Text = last ;
                lastname.Text = first;
            }

           

           

        private void lbl1_TextChanged(object sender, EventArgs e)
        {
            lbl1.Text = firstname.Text.Length.ToString();
        }

        private void lbl2_TextChanged(object sender, EventArgs e)
        {
            lbl2.Text = lastname.Text.Length.ToString();
        }
    }
    }
