using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetLibrary
{
    public partial class MainView : Form
    {
        private MainMenu returnVal;
        private string enterTextPrompt = "Enter Name";
        private DotNetClass _controller;

        public MainMenu ReturnCode
        {
            get { return returnVal; }
        }

        public MainView(DotNetClass controller)
        {
            InitializeComponent();
            returnVal = MainMenu.NULL;
            _controller = controller;

            // Form controls
            addPlayerTextBox.Text = enterTextPrompt;            
        }

        private void addPlayerButtonClick(object sender, EventArgs e)
        {
            if(addPlayerTextBox.Text != enterTextPrompt && addPlayerTextBox.Text != "")
            {
                // add to list
                _controller.players.Add(addPlayerTextBox.Text);
                playerList.Items.Clear();
                playerList.Items.AddRange(_controller.players.ToArray());

                // clear the text box
                addPlayerTextBox.Text = "";
            }
        }

        private void addPlayerTextBox_Enter(object sender, EventArgs e)
        {
            if(addPlayerTextBox.Text == enterTextPrompt)
            {
                addPlayerTextBox.Text = "";
                addPlayerTextBox.Font = new Font(addPlayerTextBox.Font, FontStyle.Regular);
            }
        }

        private void addPlayerTextBox_Leave(object sender, EventArgs e)
        {
            if(addPlayerTextBox.Text == "")
            {
                addPlayerTextBox.Text = enterTextPrompt;
                addPlayerTextBox.Font = new Font(addPlayerTextBox.Font, FontStyle.Italic);
            }
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            int index = playerList.SelectedIndex;
            if(index >= 0)
            {
                if (index < _controller.players.Count)
                {
                    _controller.players.RemoveAt(index);
                    playerList.Items.Clear();
                    playerList.Items.AddRange(_controller.players.ToArray());
                }
            }
        }

        private void addPlayerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addPlayerButtonClick(sender, e);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            returnVal = MainMenu.START_GAME;
            this.Close();
        }
    }
}
