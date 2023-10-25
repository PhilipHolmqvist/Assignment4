namespace Assignment4
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            seatButton1 = new RoundButton();
            seatButton2 = new RoundButton();
            seatButton3 = new RoundButton();
            seatButton4 = new RoundButton();
            seatButton5 = new RoundButton();
            seatButton6 = new RoundButton();
            seatButton7 = new RoundButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addNewPlayerButton = new Button();
            playerHitButton = new Button();
            playerStandButton = new Button();
            player1RadioButton = new RadioButton();
            player2RadioButton = new RadioButton();
            player3RadioButton = new RadioButton();
            player4RadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(892, 551);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;      
            // 
            // seatButton1
            // 
            seatButton1.Location = new Point(62, 502);
            seatButton1.Name = "seatButton1";
            seatButton1.Size = new Size(50, 50);
            seatButton1.TabIndex = 1;
            seatButton1.Text = "roundButton1";
            seatButton1.UseVisualStyleBackColor = true;
            seatButton1.Click += seatButton1_Click;
            // 
            // seatButton2
            // 
            seatButton2.Location = new Point(184, 535);
            seatButton2.Name = "seatButton2";
            seatButton2.Size = new Size(51, 51);
            seatButton2.TabIndex = 2;
            seatButton2.Text = "roundButton2";
            seatButton2.UseVisualStyleBackColor = true;
            seatButton2.Click += seatButton2_Click;
            // 
            // seatButton3
            // 
            seatButton3.Location = new Point(313, 558);
            seatButton3.Name = "seatButton3";
            seatButton3.Size = new Size(51, 51);
            seatButton3.TabIndex = 3;
            seatButton3.Text = "roundButton3";
            seatButton3.UseVisualStyleBackColor = true;
            seatButton3.Click += seatButton3_Click;
            // 
            // seatButton4
            // 
            seatButton4.Location = new Point(442, 567);
            seatButton4.Name = "seatButton4";
            seatButton4.Size = new Size(51, 51);
            seatButton4.TabIndex = 4;
            seatButton4.Text = "roundButton4";
            seatButton4.UseVisualStyleBackColor = true;
            seatButton4.Click += seatButton4_Click;
            // 
            // seatButton5
            // 
            seatButton5.Location = new Point(572, 558);
            seatButton5.Name = "seatButton5";
            seatButton5.Size = new Size(51, 51);
            seatButton5.TabIndex = 5;
            seatButton5.Text = "roundButton5";
            seatButton5.UseVisualStyleBackColor = true;
            seatButton5.Click += seatButton5_Click;
            // 
            // seatButton6
            // 
            seatButton6.Location = new Point(698, 544);
            seatButton6.Name = "seatButton6";
            seatButton6.Size = new Size(51, 51);
            seatButton6.TabIndex = 6;
            seatButton6.Text = "roundButton6";
            seatButton6.UseVisualStyleBackColor = true;
            seatButton6.Click += seatButton6_Click;
            // 
            // seatButton7
            // 
            seatButton7.Location = new Point(823, 502);
            seatButton7.Name = "seatButton7";
            seatButton7.Size = new Size(51, 51);
            seatButton7.TabIndex = 7;
            seatButton7.Text = "roundButton7";
            seatButton7.UseVisualStyleBackColor = true;
            seatButton7.Click += seatButton7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(380, 26);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 8;
            label1.Text = "Dealer score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 26);
            label2.Name = "label2";
            label2.Size = new Size(173, 20);
            label2.TabIndex = 9;
            label2.Text = "Number of decks in play:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 52);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 10;
            label3.Text = "Number of players:";
            // 
            // addNewPlayerButton
            // 
            addNewPlayerButton.Location = new Point(38, 39);
            addNewPlayerButton.Name = "addNewPlayerButton";
            addNewPlayerButton.Size = new Size(121, 38);
            addNewPlayerButton.TabIndex = 11;
            addNewPlayerButton.Text = "Add player";
            addNewPlayerButton.UseVisualStyleBackColor = true;
            // 
            // playerHitButton
            // 
            playerHitButton.Location = new Point(38, 92);
            playerHitButton.Name = "playerHitButton";
            playerHitButton.Size = new Size(121, 38);
            playerHitButton.TabIndex = 12;
            playerHitButton.Text = "Hit";
            playerHitButton.UseVisualStyleBackColor = true;
            // 
            // playerStandButton
            // 
            playerStandButton.Location = new Point(38, 148);
            playerStandButton.Name = "playerStandButton";
            playerStandButton.Size = new Size(121, 38);
            playerStandButton.TabIndex = 13;
            playerStandButton.Text = "Stand";
            playerStandButton.UseVisualStyleBackColor = true;
            // 
            // player1RadioButton
            // 
            player1RadioButton.AutoSize = true;
            player1RadioButton.Location = new Point(47, 35);
            player1RadioButton.Name = "player1RadioButton";
            player1RadioButton.Size = new Size(66, 19);
            player1RadioButton.TabIndex = 14;
            player1RadioButton.TabStop = true;
            player1RadioButton.Text = "Player 1";
            player1RadioButton.UseVisualStyleBackColor = true;
            // 
            // player2RadioButton
            // 
            player2RadioButton.AutoSize = true;
            player2RadioButton.Location = new Point(47, 77);
            player2RadioButton.Name = "player2RadioButton";
            player2RadioButton.Size = new Size(66, 19);
            player2RadioButton.TabIndex = 15;
            player2RadioButton.TabStop = true;
            player2RadioButton.Text = "Player 2";
            player2RadioButton.UseVisualStyleBackColor = true;
            // 
            // player3RadioButton
            // 
            player3RadioButton.AutoSize = true;
            player3RadioButton.Location = new Point(47, 124);
            player3RadioButton.Name = "player3RadioButton";
            player3RadioButton.Size = new Size(66, 19);
            player3RadioButton.TabIndex = 16;
            player3RadioButton.TabStop = true;
            player3RadioButton.Text = "Player 3";
            player3RadioButton.UseVisualStyleBackColor = true;
            // 
            // player4RadioButton
            // 
            player4RadioButton.AutoSize = true;
            player4RadioButton.Location = new Point(47, 166);
            player4RadioButton.Name = "player4RadioButton";
            player4RadioButton.Size = new Size(66, 19);
            player4RadioButton.TabIndex = 17;
            player4RadioButton.TabStop = true;
            player4RadioButton.Text = "Player 4";
            player4RadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(player1RadioButton);
            groupBox1.Controls.Add(player4RadioButton);
            groupBox1.Controls.Add(player2RadioButton);
            groupBox1.Controls.Add(player3RadioButton);
            groupBox1.Location = new Point(942, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 208);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select player";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(addNewPlayerButton);
            groupBox2.Controls.Add(playerHitButton);
            groupBox2.Controls.Add(playerStandButton);
            groupBox2.Location = new Point(942, 357);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 261);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Player Actions";
            // 
            // button1
            // 
            button1.Location = new Point(38, 201);
            button1.Name = "button1";
            button1.Size = new Size(120, 38);
            button1.TabIndex = 14;
            button1.Text = "Next Round";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 834);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(seatButton7);
            Controls.Add(seatButton6);
            Controls.Add(seatButton5);
            Controls.Add(seatButton4);
            Controls.Add(seatButton3);
            Controls.Add(seatButton2);
            Controls.Add(seatButton1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Assignment 4 Blackjack by Philip Holmqvist";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RoundButton seatButton1;
        private RoundButton seatButton2;
        private RoundButton seatButton3;
        private RoundButton seatButton4;
        private RoundButton seatButton5;
        private RoundButton seatButton6;
        private RoundButton seatButton7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addNewPlayerButton;
        private Button playerHitButton;
        private Button playerStandButton;
        private RadioButton player1RadioButton;
        private RadioButton player2RadioButton;
        private RadioButton player3RadioButton;
        private RadioButton player4RadioButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
    }
}