using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace SlotMachine
{
    public partial class GameForm : Form
    {
        //Multipliers of bet
        private static double five = 1.0;
        private static double four_or_fullhouse = 0.7;
        private static double three = 0.5;
        private static double two_of_two = 0.3;
        //Player class
        Player player;
        //Music player
        private WaveOut waveOut;
        private WaveStream audioFile;


        public GameForm(string user, int money)
        {
            InitializeComponent();
            if(money == 0)
            {
                player = new Player(user, 100);
            }
            else
            {
                player = new Player(user, money);
            }
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.total.Text = player.get_money().ToString();
            //music
            MemoryStream stream = new MemoryStream(Properties.Resources.backgroundmusic);
            audioFile = new Mp3FileReader(stream);
            waveOut = new WaveOut();
            waveOut.Init(audioFile);
            waveOut.PlaybackStopped += WaveOut_PlaybackStopped;
            waveOut.Volume = 0.1f;
            waveOut.Play();
        }
        //restart the music
        private void WaveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            audioFile.Position = 0;
            waveOut.Volume = 0.1f;
            waveOut.Play();
        }
        //dispose audio
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            waveOut.Stop();
            audioFile.Dispose();
            waveOut.Dispose();
        }

        //Spin or Stop
        private void materialButton1_Click(object sender, EventArgs e)
        {
            int bet = Int32.Parse(this.bet.Text);
            if (bet == 0)
            {
                return;
            }

            if (Spin.Text == "Spin")
            {
                //update text
                prev_total.Text = "Your Total Was: " + player.get_money().ToString() + "$";
                won.Text = "You Won: ...$";
                bet_info.Text = "Your Bet: " + bet.ToString() + "$";
                //Update total
                player.lose_money(bet);
                this.total.Text = player.get_money().ToString();
                //Start Spinning
                timer1.Start();
                this.Spin.Text = "Stop";
            }
            else
            {
                //Buttons
                prev_total.Visible = true;
                bet_info.Visible = true;
                won.Visible = true;
                //get result int
                timer1.Stop();
                int[] result = generate_pictures();
                //calculate the bet
                Dictionary<string, int> comb = get_combinations(result);
                double mult = get_multiplier(comb);
                //update player and text
                prev_total.Text = "Your Total Was: " + (player.get_money() + bet).ToString() + "$";
                //Adding the bet
                if (mult != 0)
                {
                    player.add_money(Convert.ToInt32(2 * bet + bet * mult));
                    won.Text = "You Won: " + (Convert.ToInt32(bet + bet * mult)).ToString() + "$";
                }
                else
                {
                    won.Text = "You Lost! Try again";
                }
                bet_info.Text = "Your Bet: " + bet.ToString() + "$";
                //update bet to 0 and total money to new won
                this.bet.Text = "0";
                this.Spin.Text = "Spin";
                this.total.Text = player.get_money().ToString();
                //close app if money is 0
                if (player.get_money() == 0)
                {
                    //make sure for the next login, the player will get 100$
                    if (MessageBox.Show("YOU LOST ALL OF YOUR MONEY! Try again later", "Loser!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
    == DialogResult.OK)
                    {

                        login form2 = new login();
                        form2.save(player.get_user(), 100);
                        this.Close();
                    }
                }
                
                if (player.get_money() > 10000)
                {
                    this.total.Size = new Size(125, 45);
                }
                else
                {
                    this.total.Size = new Size(95, 45);
                }
            }
        }
        //change pictures
        private void timer1_Tick(object sender, EventArgs e)
        {
            generate_pictures();
        }
        private int[] generate_pictures()
        {
            Random rnd = new Random();
            int[] rnd_nums = { rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6) };
            for (int i = 1; i <= 5; i++)
            {
                PictureBox pictureBox = this.Controls["pictureBox" + i] as PictureBox;

                if (rnd_nums[i - 1] == 1)
                {
                    pictureBox.Image = Properties.Resources.seven;
                }
                else if (rnd_nums[i - 1] == 2)
                {
                    pictureBox.Image = Properties.Resources.apple;
                }
                else if (rnd_nums[i - 1] == 3)
                {
                    pictureBox.Image = Properties.Resources.lemon;
                }
                else if (rnd_nums[i - 1] == 4)
                {
                    pictureBox.Image = Properties.Resources.watermelon;
                }
                else if (rnd_nums[i - 1] == 5)
                {
                    pictureBox.Image = Properties.Resources.peach;
                }
            }
            return rnd_nums;
        }
        private Dictionary<string, int> get_combinations(int[] nums)
        {
            Dictionary<string, int> combinations = new Dictionary<string, int>()
            {{"seven",0 },{"apple",0 },{"lemon",0 },{"watermelon",0 },{"peach",0 } };
            foreach (int num in nums) 
            {
                if(num == 1)
                {
                    combinations["seven"] += 1;
                }
                else if(num == 2)
                {
                    combinations["apple"] += 1;
                }
                else if (num == 3)
                {
                    combinations["lemon"] += 1;
                }
                else if (num == 4)
                {
                    combinations["watermelon"] += 1;
                }
                else if (num == 5)
                {
                    combinations["peach"] += 1;
                }
            }
           
            return combinations;
        }
        //return the multiplier of the bet
        private double get_multiplier(Dictionary<string, int> comb) 
        {
            
            int[] combination_readings = new int[4];
            //[double,triple,four,five]
            foreach (KeyValuePair<string, int> el in comb)
            {
                if (el.Value == 2)
                {
                    combination_readings[0] += 1;
                }else if(el.Value == 3)
                {
                    combination_readings[1] += 1;
                }
                else if (el.Value == 4)
                {
                    combination_readings[2] += 1;
                }
                else if (el.Value == 5)
                {
                    combination_readings[3] += 1;
                }
            }
            if (combination_readings[3] == 1)
            {
                return five;
            }else if (combination_readings[2] == 1 || (combination_readings[1] == 1 && combination_readings[0] == 1))
            {
                return four_or_fullhouse;
            }
            else if (combination_readings[1] == 1)
            {
                return three;
            }
            else if (combination_readings[0] == 2)
            {
                return two_of_two;
            }
            return 0;
        }
        //+100
        private void button2_Click(object sender, EventArgs e)
        {
            if(Spin.Text == "Stop")
            {
                return;
            }
            int new_bet = Int32.Parse(this.bet.Text) + 100;
            int new_total = Int32.Parse(this.total.Text) - 100;
            if (player.get_money() >= new_bet)
            {
                this.bet.Text = new_bet.ToString();
                this.total.Text = (new_total).ToString();
            }
        }
        //+10
        private void button3_Click(object sender, EventArgs e)
        {
            if (Spin.Text == "Stop")
            {
                return;
            }
            int new_bet = Int32.Parse(this.bet.Text) + 10;
            int new_total = Int32.Parse(this.total.Text) - 10;
            if (player.get_money() >= new_bet)
            {
                this.bet.Text = new_bet.ToString();
                this.total.Text = (new_total).ToString();
            }
        }
        //+1
        private void button4_Click(object sender, EventArgs e)
        {
            if (Spin.Text == "Stop")
            {
                return;
            }
            int new_bet = Int32.Parse(this.bet.Text) + 1;
            int new_total = Int32.Parse(this.total.Text) - 1;
            if (player.get_money() >= new_bet)
            {
                this.bet.Text = new_bet.ToString();
                this.total.Text = (new_total).ToString();
            }
        }
        //-100
        private void button5_Click(object sender, EventArgs e)
        {
            if (Spin.Text == "Stop")
            {
                return;
            }
            int new_bet = Int32.Parse(this.bet.Text) - 100;
            int new_total = Int32.Parse(this.total.Text) + 100;
            if (new_bet >= 0)
            {
                this.bet.Text = new_bet.ToString();
                this.total.Text = (new_total).ToString();
            }
        }
        //-10
        private void button6_Click(object sender, EventArgs e)
        {
            if (Spin.Text == "Stop")
            {
                return;
            }
            int new_bet = Int32.Parse(this.bet.Text) - 10;
            int new_total = Int32.Parse(this.total.Text) + 10;
            if (new_bet >= 0)
            {
                this.bet.Text = new_bet.ToString();
                this.total.Text = (new_total).ToString();
            }
        }
        //-1
        private void button7_Click(object sender, EventArgs e)
        {
            if (Spin.Text == "Stop")
            {
                return;
            }
            int new_bet = Int32.Parse(this.bet.Text) - 1;
            int new_total = Int32.Parse(this.total.Text) + 1;
            if (new_bet >= 0)
            {
                this.bet.Text = new_bet.ToString();
                this.total.Text = (new_total).ToString();
            }
        }
        //exit
        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the game?", "Please don't!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
== DialogResult.OK)
            {

                login form2 = new login();
                form2.save(player.get_user(),player.get_money());
                this.Close();

            }
        }

        //+1000
        private void add_bet_Click(object sender, EventArgs e)
        {
            if (Spin.Text == "Stop")
            {
                return;
            }
            if (player.get_money() >= 1000)
            {
                int new_bet = Int32.Parse(this.bet.Text) + 1000;
                int new_total = Int32.Parse(this.total.Text) - 1000;
                if (player.get_money() >= new_bet)
                {
                    this.bet.Text = new_bet.ToString();
                    this.total.Text = (new_total).ToString();
                }
            }
        }

        private void AllIn_Click(object sender, EventArgs e)
        {
            if (Spin.Text == "Stop")
            {
                return;
            }
            if (player.get_money() >= 0)
            {
                int new_bet = Int32.Parse(this.bet.Text) + Int32.Parse(this.total.Text);
                this.bet.Text = new_bet.ToString();
                this.total.Text = "0";
                
            }
        }
        //-1000
        private void down_bet_Click(object sender, EventArgs e)
        {
            if (Spin.Text == "Stop")
            {
                return;
            }
            int bet = Int32.Parse(this.bet.Text);
            if(bet >= 1000)
            {
                int new_bet = bet - 1000;
                int new_total = Int32.Parse(this.total.Text) + 1000;
                this.bet.Text = new_bet.ToString();
                this.total.Text = (new_total).ToString();
               
            }
        }

    }
}