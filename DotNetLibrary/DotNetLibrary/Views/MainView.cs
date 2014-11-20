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
        private Controller _controller;

        public MainMenu ReturnCode
        {
            get { return returnVal; }
        }

        public MainView(Controller controller)
        {
            InitializeComponent();
            returnVal = MainMenu.NULL;
            _controller = controller;
        }

        private void addPlayerButtonClick(object sender, EventArgs e)
        {
            if (isUserComplete())
            {
                // Add the new user
                _controller.players.Add( new Models
                    .User()
                    .setName( nameTextBox.Text )
                    .setGender( maleRadioButton.Checked ? Gender.MALE : femaleRadioButton.Checked ? Gender.FEMALE : Gender.ALIEN)
                    .setImage( profilePicture.Image ) 
                );

                // Reset the list
                playerList.Items.Clear();
                playerList.Items.AddRange(_controller.getPlayers().Select(val => val.Name).ToArray());

                // Clear input
                nameTextBox.Text = "";
                maleRadioButton.Checked = true;
                profilePicture.Image = Properties.Resources.defaultMale;

                femaleRadioButton.Checked = false;
                alienRadioButton.Checked = false;
            }

            if(_controller.players.Count > 0)
            {
                startButton.Enabled = true;
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
                    playerList.Items.AddRange(_controller.getPlayers().Select(val => val.Name).ToArray());
                }
            }

            // Disable this button
            removePlayerButton.Enabled = false;


            // Check if we can start the game
            if (_controller.players.Count <= 0)
            {
                startButton.Enabled = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            returnVal = MainMenu.START_GAME;
            this.Close();
        }

        private void playerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(playerList.SelectedIndex >= 0)
            {
                removePlayerButton.Enabled = true;
            }
            else
            {
                removePlayerButton.Enabled = false;
            }
        }

        private bool isUserComplete()
        {
            if(nameTextBox.Text != "" && (maleRadioButton.Checked || femaleRadioButton.Checked || alienRadioButton.Checked))
            {
                return true;
            }

            return false;
        }

        private void addUserControlChanged(object sender, EventArgs e)
        {
            addPlayerButton.Enabled = isUserComplete();

            if(sender.GetType() == maleRadioButton.GetType())
            {
                if(alienRadioButton.Checked)
                {
                    profilePicture.Image = Properties.Resources.defaultAlien;
                }
                else if(femaleRadioButton.Checked)
                {
                    profilePicture.Image = Properties.Resources.defaultFemale;
                }
                else
                {
                    profilePicture.Image = Properties.Resources.defaultMale;
                }
            }
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image Files (.jpg, .png, .jpeg)| *.jpg;.*ping;*.jpeg";
            dialog.Multiselect = false;

           bool userClickedOk = dialog.ShowDialog() == DialogResult.OK;

            if(userClickedOk)
            {
                try
                {
                    profilePicture.Image = Image.FromFile(dialog.FileName);
                }
                catch
                {
                    //gulp
                }
            }            
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if(isUserComplete())
                {
                    addPlayerButtonClick(sender, e);
                }
            }
        }
          
    }
}
