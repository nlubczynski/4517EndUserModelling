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
    public partial class ChooseTwoForm : Form
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
        }

        public ChooseTwoForm()
        {
            InitializeComponent();
        }

        public void setParams(string promptText, string titleText, string optionOneText, string optionTwoText)
        {
            lblPrompt.Text = promptText;
            this.Text = titleText;
            btnFirstOption.Text = optionOneText;
            btnSecondOption.Text = optionTwoText;
        }

        private void btnFirstOption_Click(object sender, EventArgs e)
        {
            this.SelectedValue = Options.OPTION_ONE;
            this.Close();
        }

        private void btnSecondOption_Click(object sender, EventArgs e)
        {
            this.SelectedValue = Options.OPTION_TWO;
            this.Close();
        }
    }
}
