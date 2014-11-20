﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections;

namespace DotNetLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Controller
    {
        // Form variables
        private MainView mainView;
        public ArrayList players;

        public MainView MainView
        {
            get { return mainView; }
        }

        public Controller()
        {
            mainView = new MainView(this);
            players = new ArrayList();
        }

        public MainMenu ShowMainMenu()
        {
            mainView.ShowDialog();
            return mainView.ReturnCode;
        }

        public Models.User[] getPlayers()
        {
            return players.ToArray(typeof(Models.User)) as Models.User[];
        }

        public Utility.Vector getPlayerVector()
        {
            Utility.Vector returnVal = new Utility.Vector(typeof(Models.User));

            foreach(Models.User user in players)
            {
                returnVal.AddObject(user);
            }

            return returnVal;
        }
    }
}