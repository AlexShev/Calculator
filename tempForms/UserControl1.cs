using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tempForms
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Gray;
        }

        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = System.Drawing.SystemColors.ActiveBorder;
        }
    }
}
