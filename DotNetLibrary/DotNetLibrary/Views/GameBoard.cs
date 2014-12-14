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
using DotNetLibrary.Models;
using System.Threading;

namespace DotNetLibrary.Views
{
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface GameBoardEvents
    {
        [DispId(1)]
        void StockButtonClicked(object sender, EventArgs e);
        [DispId(2)]
        void RollEnded(object sender, EventArgs roll);
        [DispId(3)]
        void MoveEnded(object sender, EventArgs args);
        [DispId(4)]
        void SkippedTurnMoveEnded(object sender, EventArgs args);
        [DispId(5)]
        void RetiredUserMoveEnd(object sender, EventArgs args);
    }    

    [ClassInterface(ClassInterfaceType.AutoDual),
        ComSourceInterfaces(typeof(GameBoardEvents))]
    public partial class GameBoard : Form
    {
        // event
        public event EventHandler StockButtonClicked;
        public event EventHandler RollEnded;
        public event EventHandler MoveEnded;
        public event EventHandler SkippedTurnMoveEnded;
        public event EventHandler RetiredUserMoveEnd;
        // image vars
        const int NUMBER_OF_FRAMES = 28;
        const int HEIGHT = 400;
        const int WIDTH = 350;
        private Image[] sprites = new Image[NUMBER_OF_FRAMES];
        int currentImage;
        private static int[] frameToRoll = { 
                                        4, 4,
                                        3, 3, 3, 
                                        2, 2, 2, 
                                        1, 1, 1, 
                                        10, 10, 10, 
                                        9, 9, 9, 
                                        8, 8, 8, 
                                        7, 7, 
                                        6, 6, 6, 
                                        5, 5, 5 };

        // timer vars
        System.Windows.Forms.Timer timer;
        int randomSpinDuration;
        Random RNGesus;

        // Constants
        const int COST_OF_STOCK = 50000;

        // Properties
        public bool StockEnabled
        {
            get { return stockButton.Enabled; }
            set { stockButton.Enabled = value; }
        }

        public bool TurnEnabled { get; private set; }
        public int Roll { get; private set; }

        public GameBoard()
        {
            InitializeComponent();

            // Set up timer for spinning
            timer = new System.Windows.Forms.Timer();
            timer.Tick += timer_Tick;
            RNGesus = new Random();

            // Set up the frames
            Bitmap image = Properties.Resources.SpinnerStrip;

            for (int i = 0; i < NUMBER_OF_FRAMES; ++i)            
            {
                sprites[i] = new Bitmap(WIDTH, HEIGHT);
                using (Graphics g = Graphics.FromImage(sprites[i]))
                {
                    g.DrawImage(image, new Rectangle(0, 0, WIDTH, HEIGHT), new Rectangle(i * WIDTH, 0, WIDTH, HEIGHT), GraphicsUnit.Pixel);
                }
            }

            // Set initial frame
            currentImage = 0;
            spinnerImage.Image = sprites[currentImage];

            drivingGif.Enabled = false;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            // Change the frame
            currentImage++;
            currentImage = currentImage % NUMBER_OF_FRAMES;
            spinnerImage.Image = sprites[currentImage];

            // Decrement the count
            --randomSpinDuration;
            if (randomSpinDuration <= 50)
            {
                timer.Interval += 1;

                if (randomSpinDuration <= 25)
                    timer.Interval += 2;

                if (randomSpinDuration <= 7)
                    timer.Interval += 3;

                if (randomSpinDuration <= 0)
                {
                    timer.Stop();
                    setRoll(frameToRoll[currentImage]);
                    if (null != RollEnded)
                    {
                        this.Roll = frameToRoll[currentImage];
                        RollEnded(this, e);
                    }
                }
            }
        }

        private void setRoll(int roll)
        {
            spinOutput.Text = roll.ToString();
        }

        public void setUser(Models.User user)
        {

            if(user.MissNextTurn)
            {
                user.MissNextTurn = false;
                updateUI(user);
               
                MessageBox.Show("Sorry, " + user.Name + ", but you miss this turn.", "Missed Turn", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                SkippedTurnMoveEnded(this, new EventArgs());
                return;
            }

            updateUI(user);

            this.TurnEnabled = true;

            this.moveUserUpdate(user, null, user.CurrentTile, null, this.Roll, false, user.Money);
        }

        public void setStock(Stock stock)
        {
            switch (stock)
            {
                case Stock.ONE:
                    stockButton.Image = Properties.Resources.stock_one;
                    break;
                case Stock.TWO:
                    stockButton.Image = Properties.Resources.stock_two;
                    break;
                case Stock.THREE:
                    stockButton.Image = Properties.Resources.stock_three;
                    break;
                case Stock.FOUR:
                    stockButton.Image = Properties.Resources.stock_four;
                    break;
                case Stock.FIVE:
                    stockButton.Image = Properties.Resources.stock_five;
                    break;
                case Stock.SIX:
                    stockButton.Image = Properties.Resources.stock_six;
                    break;
                case Stock.SEVEN:
                    stockButton.Image = Properties.Resources.stock_seven;
                    break;
                case Stock.EIGHT:
                    stockButton.Image = Properties.Resources.stock_eight;
                    break;
                case Stock.NINE:
                    stockButton.Image = Properties.Resources.stock_nine;
                    break;
                default:
                    stockButton.Image = Properties.Resources.stock_none;
                    break;
            }
        }

        private void spinnerImage_Click(object sender, EventArgs e)
        {
            if(this.TurnEnabled)
            {
                this.TurnEnabled = false;
                StockEnabled = false;
            }
            else
            {
                return;
            }

            if(timer.Enabled == false)
            {
                randomSpinDuration = RNGesus.Next(100, 300);
                timer.Interval = 5;
                timer.Start();

                spinOutput.Text = "";
            }            
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            if (null != StockButtonClicked) StockButtonClicked(this, e);
        }

        public void updateCurrentTile(Tile currentTile)
        {
            lblCurrentTileName.Text = currentTile.Name;
            lblCurrentTileType.Text = currentTile.Description;
        }

        public void updateNextTile(Tile nextTile)
        {
            lblNextTileOneName.Text = nextTile.Name;
            lblNextTileOneType.Text = nextTile.Description;
        }

        public void updateNextNextTile(Tile nextNextTile)
        {
            lblNextTileTwoName.Text = nextNextTile.Name;
            lblNextTileTwoType.Text = nextNextTile.Description;
        }

        public int getStartingRoll()
        {
            return frameToRoll[currentImage];
        }

        public void updateUI(User user)
        {
            controlBox.Text = user.Name;
            profilePicture.Image = user.Image;
            moneyOutput.Text = String.Format("{0:C}", user.Money);
            spinOutput.Text = "";
            this.Roll = 0;

            switch (user.Gender)
            {
                case Gender.ALIEN:
                    drivingGif.Image = Properties.Resources.alienGiphy;
                    break;

                case Gender.FEMALE:
                    drivingGif.Image = Properties.Resources.girlGiphy;
                    break;

                case Gender.MALE:
                    drivingGif.Image = Properties.Resources.giphy;
                    break;
            }

            if (user.Job != null)
            {
                careerOutput.Text = user.Job.Name;
            }
            else
            {
                careerOutput.Text = "";
            }

            // set up conditionals
            if (user.Money >= COST_OF_STOCK)
            {
                StockEnabled = true;
            }

            setStock(user.Stock);
        }

        public void moveUserUpdate(User currentUser, User nextUser, Tile currentTile, Tile lastTile, int roll,
            bool alternatePath, double userMoneyVisual, bool rollStart = true)
        {
            if (currentTile.Name == "RETIRE")
            {
                //update Current Tile
                this.updateCurrentTile(currentTile);
                this.updateNextTile(currentTile.Neighbours.GetAt(0));
                this.updateNextNextTile(currentTile.Neighbours.GetAt(1));

                MessageBox.Show("Welcome To Retirement! Here is your pension!", "Retired!", MessageBoxButtons.OK, MessageBoxIcon.None);
                currentUser.addMoney(currentUser.Salary.Wage * .5);

                if (RetiredUserMoveEnd != null) RetiredUserMoveEnd(this, new EventArgs());
                return;
            }
               
            //sync money output
            moneyOutput.Text = userMoneyVisual.ToString("C");

            if(roll > 0)
                drivingGif.Enabled = true;

            setStock(currentUser.Stock);

            Tile nextTile;

            //if there is a second option and alternate Path is chosen next tile is that tile
            if (currentTile.Neighbours.size() > 1 && alternatePath)
                nextTile = (Tile) currentTile.Neighbours.GetAt(1);
            else
                nextTile = (Tile)currentTile.Neighbours.GetAt(0);

            spinOutput.Text = roll.ToString();

            //update Current Tile
            this.updateCurrentTile(currentTile);
            this.updateNextTile(nextTile);
            this.updateNextNextTile(nextTile.Neighbours.GetAt(0));

            if (lastTile != null && currentTile != lastTile)
            {
                ThreadPool.QueueUserWorkItem(delegate
                {
                    if (currentTile.Name == "Pay Day" && !rollStart)
                    {
                        userMoneyVisual += currentUser.Salary.Wage;
                        moneyOutput.Text = userMoneyVisual.ToString("C");
                    }
                    Thread.Sleep(750);
                    Invoke(new Action(delegate { this.moveUserUpdate(currentUser, nextUser, nextTile, lastTile, --roll, alternatePath, userMoneyVisual, false);}));
                });
            }
            else if (lastTile != null && currentTile == lastTile)
            {
                ThreadPool.QueueUserWorkItem(delegate
                {
                    Thread.Sleep(1500);
                    if (nextUser != null)
                    {
                        //this.setUser(nextUser);
                        drivingGif.Enabled = false;
                        if (MoveEnded != null) MoveEnded(this, new EventArgs());
                    }
                });                
            }
        }
    }
}
