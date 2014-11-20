using DotNetLibrary;
using DotNetLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controller view = new Controller();
            //Application.Run(view.MainView);
            GameBoard board = new GameBoard();

            DotNetLibrary.Models.User user = new DotNetLibrary.Models.User();
            user.setName("Nik");
            board.setUser(user);

            Application.Run(board);

        }
    }
}
