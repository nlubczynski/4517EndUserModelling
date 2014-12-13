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

    [Guid("EAA4976A-45C3-4BC5-BC0B-E474F4C3C83F")]
    public interface ComClass1Interface
    {
    }

    [Guid("7BD20046-DF8C-44A6-8F6B-687FAA26FA71"),
        InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface ComClass1Events
    {
    }

    [Guid("0D53A3E8-E51A-49C7-944E-E72A2064F938"),
        ClassInterface(ClassInterfaceType.AutoDual),
        ComSourceInterfaces(typeof(ComClass1Events))]
    public partial class GameBoard : Form, ComClass1Interface
    {
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
        Timer timer;
        int randomSpinDuration;
        Random RNGesus;

        const int COST_OF_STOCK = 50000;

        public bool StockEnabled
        {
            get { return stockButton.Enabled; }
            set { stockButton.Enabled = value; }
        }

        public GameBoard()
        {
            InitializeComponent();

            // Set up timer for spinning
            timer = new Timer();
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
                }
            }
        }

        private void setRoll(int roll)
        {
            spinOutput.Text = roll.ToString();
        }

        public void setUser(Models.User user)
        {
            // set up values
            controlBox.Text = user.Name;
            profilePicture.Image = user.Image;
            moneyOutput.Text = String.Format("{0:C}", user.Money);
            spinOutput.Text = "";

            if (user.Job != null)
            {
                careerOutput.Text = user.Job.Name;
            }

            // set up conditionals
            if(user.Money >= COST_OF_STOCK)
            {
                StockEnabled = true;
            }
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
            if(timer.Enabled == false)
            {
                randomSpinDuration = RNGesus.Next(100, 300);
                timer.Interval = 5;
                timer.Start();

                spinOutput.Text = "";
            }            
        }

        public event EventHandler StockButtonClicked;

        private void stockButton_Click(object sender, EventArgs e)
        {
            EventHandler handler = StockButtonClicked;
            if (null != handler) handler(this, EventArgs.Empty);
        }
    }
}
