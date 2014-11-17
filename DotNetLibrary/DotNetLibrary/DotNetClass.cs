using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DotNetLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class DotNetClass
    {
        // Form variables
        private MainView mainView;
        public List<string> players;

        public MainView MainView
        {
            get { return mainView; }
        }

        public DotNetClass()
        {
            mainView = new MainView(this);
            players = new List<string>();
        }

        public MainMenu ShowMainMenu()
        {
            mainView.ShowDialog();
            return mainView.ReturnCode;
        }

        public VBA.Collection getPlayers()
        {
            VBA.Collection collection = new VBA.Collection();
            foreach (string player in players)
            {
                collection.Add(player);
            }

            return collection;
        }
    }
}
