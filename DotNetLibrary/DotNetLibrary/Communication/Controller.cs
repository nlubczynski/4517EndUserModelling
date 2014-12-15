using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections;
using DotNetLibrary.Models;
using DotNetLibrary.Utility;
using DotNetLibrary.Views;

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

        public Utility.VectorUser getPlayerVector()
        {
            Utility.VectorUser returnVal = new Utility.VectorUser();

            foreach(Models.User user in players)
            {
                returnVal.AddObject(user);
            }

            return returnVal;
        }

        public static void endGame(VectorUser users)
        {
            List<String> results = new List<String>();

            for (int i = 0; i < users.size(); i++)
            {
                User user = (User)users.GetAt(i);
                StringBuilder item = new StringBuilder();
                item.Append(user.Name);
                item.Append("  Cash: ");
                item.Append(user.Money.ToString("C"));
                item.Append("  Life Tiles: ");
                item.Append(getLifeTiles(user).ToString("C"));
                item.Append("  Networth: ");
                item.Append((getLifeTiles(user) + user.Money).ToString("C"));
                results.Add(item.ToString());

                Results resultView = new Results();
                resultView.bindData(results);

                resultView.Show();
            }
        }

        private static double getLifeTiles(User user)
        {
            double value = 0;

            for (int i = 0; i < user.LifeTiles.size(); i++)
            {
                value += user.LifeTiles.GetAt(i).Value;
            }

            return value;
        }
    }
}
