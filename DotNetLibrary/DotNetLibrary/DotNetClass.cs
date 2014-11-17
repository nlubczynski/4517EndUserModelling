using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections;

namespace DotNetLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class DotNetClass
    {
        // Form variables
        private MainView mainView;
        public ArrayList players;

        public MainView MainView
        {
            get { return mainView; }
        }

        public DotNetClass()
        {
            mainView = new MainView(this);
            players = new ArrayList();
        }

        public MainMenu ShowMainMenu()
        {
            mainView.ShowDialog();
            return mainView.ReturnCode;
        }

        public string[] getPlayers()
        {
            return (string[]) players.ToArray(typeof(string));
        }
    }
}
