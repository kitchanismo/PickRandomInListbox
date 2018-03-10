using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using kitchanismo_display_random_item;
namespace displayrandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// instantiate a class in kitchanismo dll
        /// </summary>
        betsayda kitchan = new betsayda();

        private void button1_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// call a string function in a class
            /// </summary>

            string string_random = kitchan.GetRandomItemInListbox(listBox1);
            MessageBox.Show(string_random);
        }

    }
}
