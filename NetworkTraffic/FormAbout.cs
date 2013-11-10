using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BjutNetworkMoniter
{
    public partial class FormAbout : Form
    {
        public FormAbout(Point pos)
        {
            InitializeComponent();
            this.Location = pos;
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            labelVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
