namespace SlotMachine
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.won = new System.Windows.Forms.Label();
            this.prev_total = new System.Windows.Forms.Label();
            this.bet_info = new System.Windows.Forms.Label();
            this.Spin = new MaterialSkin.Controls.MaterialButton();
            this.down_bet = new System.Windows.Forms.Button();
            this.add_bet = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bet = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.total = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AllIn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(695, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "+100$";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(775, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "+10$";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(851, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 35);
            this.button4.TabIndex = 12;
            this.button4.Text = "+1$";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(695, 529);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 35);
            this.button5.TabIndex = 13;
            this.button5.Text = "-100$";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(775, 529);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 35);
            this.button6.TabIndex = 14;
            this.button6.Text = "-10$";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(851, 529);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 35);
            this.button7.TabIndex = 15;
            this.button7.Text = "-1$";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(886, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "$";
            // 
            // won
            // 
            this.won.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.won.Location = new System.Drawing.Point(46, 390);
            this.won.Name = "won";
            this.won.Size = new System.Drawing.Size(276, 43);
            this.won.TabIndex = 17;
            this.won.Text = "You Won: ";
            this.won.Visible = false;
            // 
            // prev_total
            // 
            this.prev_total.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_total.Location = new System.Drawing.Point(46, 476);
            this.prev_total.Name = "prev_total";
            this.prev_total.Size = new System.Drawing.Size(290, 40);
            this.prev_total.TabIndex = 18;
            this.prev_total.Text = "Your total was:";
            this.prev_total.Visible = false;
            // 
            // bet_info
            // 
            this.bet_info.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet_info.Location = new System.Drawing.Point(46, 433);
            this.bet_info.Name = "bet_info";
            this.bet_info.Size = new System.Drawing.Size(208, 43);
            this.bet_info.TabIndex = 19;
            this.bet_info.Text = "Your Bet: ";
            this.bet_info.Visible = false;
            // 
            // Spin
            // 
            this.Spin.AutoSize = false;
            this.Spin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Spin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Spin.Depth = 0;
            this.Spin.HighEmphasis = true;
            this.Spin.Icon = null;
            this.Spin.Location = new System.Drawing.Point(409, 462);
            this.Spin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Spin.MouseState = MaterialSkin.MouseState.HOVER;
            this.Spin.Name = "Spin";
            this.Spin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Spin.Size = new System.Drawing.Size(224, 58);
            this.Spin.TabIndex = 22;
            this.Spin.Text = "Spin";
            this.Spin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Spin.UseAccentColor = true;
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // down_bet
            // 
            this.down_bet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down_bet.Image = global::SlotMachine.Properties.Resources.down;
            this.down_bet.Location = new System.Drawing.Point(942, 507);
            this.down_bet.Name = "down_bet";
            this.down_bet.Size = new System.Drawing.Size(64, 65);
            this.down_bet.TabIndex = 24;
            this.down_bet.UseVisualStyleBackColor = true;
            this.down_bet.Click += new System.EventHandler(this.down_bet_Click);
            // 
            // add_bet
            // 
            this.add_bet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_bet.Image = global::SlotMachine.Properties.Resources.up;
            this.add_bet.Location = new System.Drawing.Point(942, 390);
            this.add_bet.Name = "add_bet";
            this.add_bet.Size = new System.Drawing.Size(64, 65);
            this.add_bet.TabIndex = 23;
            this.add_bet.UseVisualStyleBackColor = true;
            this.add_bet.Click += new System.EventHandler(this.add_bet_Click);
            // 
            // exit
            // 
            this.exit.Image = global::SlotMachine.Properties.Resources.exit1;
            this.exit.Location = new System.Drawing.Point(978, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(54, 51);
            this.exit.TabIndex = 21;
            this.exit.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(824, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            // 
            // bet
            // 
            this.bet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bet.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet.Image = global::SlotMachine.Properties.Resources.bet;
            this.bet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bet.Location = new System.Drawing.Point(750, 402);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(130, 44);
            this.bet.TabIndex = 9;
            this.bet.Text = "0";
            this.bet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(832, 160);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(125, 138);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = global::SlotMachine.Properties.Resources.watermelon;
            this.pictureBox4.Location = new System.Drawing.Point(652, 160);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 138);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::SlotMachine.Properties.Resources.lemon;
            this.pictureBox3.Location = new System.Drawing.Point(454, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 138);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::SlotMachine.Properties.Resources.apple;
            this.pictureBox2.Location = new System.Drawing.Point(247, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 138);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Image = global::SlotMachine.Properties.Resources.dollar;
            this.total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.total.Location = new System.Drawing.Point(12, 17);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(123, 45);
            this.total.TabIndex = 4;
            this.total.Text = "100";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AllIn
            // 
            this.AllIn.AutoSize = false;
            this.AllIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AllIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AllIn.Depth = 0;
            this.AllIn.HighEmphasis = true;
            this.AllIn.Icon = null;
            this.AllIn.Location = new System.Drawing.Point(942, 462);
            this.AllIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AllIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllIn.Name = "AllIn";
            this.AllIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AllIn.Size = new System.Drawing.Size(61, 36);
            this.AllIn.TabIndex = 25;
            this.AllIn.Text = "All in";
            this.AllIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AllIn.UseAccentColor = true;
            this.AllIn.UseVisualStyleBackColor = true;
            this.AllIn.Click += new System.EventHandler(this.AllIn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1044, 618);
            this.ControlBox = false;
            this.Controls.Add(this.AllIn);
            this.Controls.Add(this.down_bet);
            this.Controls.Add(this.add_bet);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bet_info);
            this.Controls.Add(this.prev_total);
            this.Controls.Add(this.won);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label bet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label won;
        private System.Windows.Forms.Label prev_total;
        private System.Windows.Forms.Label bet_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
        private MaterialSkin.Controls.MaterialButton Spin;
        private System.Windows.Forms.Button add_bet;
        private System.Windows.Forms.Button down_bet;
        private MaterialSkin.Controls.MaterialButton AllIn;
        private System.Windows.Forms.Timer backgroundMusicTimer;
        private System.Windows.Forms.Timer spinSoundTimer;
    }
}

