using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetLibrary.Views
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public partial class Choose : Form
    {
        public Options SelectedValue
        {
            get;
            private set;
        }

        public enum Options
        {
            OPTION_ONE = 0,
            OPTION_TWO,
            OPTION_THREE
        }

        public Choose() 
        {
            InitializeComponent();
        }

        public void setOptions(string opt1, string opt2, string opt3)
        {
            
            op1.Text = opt1;
            op2.Text = opt2;
            op3.Text = opt3;
        }

        public void setParameters(string name, string choice)
        {
            nameLabel.Text = name;
            thingLabel.Text = choice;
        }

        private void jb1_Click(object sender, EventArgs e)
        {
            this.SelectedValue = Options.OPTION_ONE;
            this.Close();
        }

        private void jb2_Click(object sender, EventArgs e)
        {
            this.SelectedValue = Options.OPTION_TWO;
            this.Close();
        }

        private void jb3_Click(object sender, EventArgs e)
        {
            this.SelectedValue = Options.OPTION_THREE;
            this.Close();
        }
    }
}
