using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetLibrary.Views
{
    public partial class GameBoard : Form
    {
        // image vars
        static private int NUMBER_OF_FRAMES = 28;
        static private int HEIGHT = 350;
        static private int WIDTH = 350;
        private Image[] sprites = new Image[NUMBER_OF_FRAMES];
        int currentImage;

        // timer vars
        Timer timer;
        int randomSpinDuration;
        Random RNGesus;

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
                    timer.Stop();
            }
        }

        private void spinnerImage_Click(object sender, EventArgs e)
        {
            if(timer.Enabled == false)
            {
                randomSpinDuration = RNGesus.Next(100, 300);
                timer.Interval = 5;
                timer.Start();
            }
        }
    }
}
