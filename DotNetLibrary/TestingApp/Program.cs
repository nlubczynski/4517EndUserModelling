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
           // Application.Run(view.MainView);

            //DotNetLibrary.Utility.Vector vec = view.getPlayerVector();

            GameBoard board = new GameBoard();

            DotNetLibrary.Models.User user = new DotNetLibrary.Models.User();

            DotNetLibrary.Models.Job job = new DotNetLibrary.Models.Job();
            job.Name = "Software Engineer";

            user.setName("Nik");
            user.addMoney(1000);
            user.setJob(job);
            board.setUser(user);
            board.setStock(Stock.NINE);
            board.StockEnabled = true;

            Application.Run(board);

        }
    }
}
