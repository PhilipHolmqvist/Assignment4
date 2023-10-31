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
            dealerScoreLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            addNewPlayerButton = new Button();
            playerHitButton = new Button();
            playerStandButton = new Button();
            groupBox2 = new GroupBox();
            removePlayerButton = new Button();
            nextRoundButton = new Button();
            pictureBox1 = new PictureBox();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            playerControll1 = new PlayerControll();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dealerScoreLabel
            // 
            dealerScoreLabel.AutoSize = true;
            dealerScoreLabel.BackColor = Color.Transparent;
            dealerScoreLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dealerScoreLabel.Location = new Point(380, 26);
            dealerScoreLabel.Name = "dealerScoreLabel";
            dealerScoreLabel.Size = new Size(113, 25);
            dealerScoreLabel.TabIndex = 8;
            dealerScoreLabel.Text = "Dealer score:";
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
            addNewPlayerButton.Location = new Point(37, 43);
            addNewPlayerButton.Name = "addNewPlayerButton";
            addNewPlayerButton.Size = new Size(121, 38);
            addNewPlayerButton.TabIndex = 11;
            addNewPlayerButton.Text = "Add player";
            addNewPlayerButton.UseVisualStyleBackColor = true;
            addNewPlayerButton.Click += addNewPlayerButton_Click;
            // 
            // playerHitButton
            // 
            playerHitButton.Location = new Point(37, 159);
            playerHitButton.Name = "playerHitButton";
            playerHitButton.Size = new Size(121, 38);
            playerHitButton.TabIndex = 12;
            playerHitButton.Text = "Hit";
            playerHitButton.UseVisualStyleBackColor = true;
            playerHitButton.Click += playerHitButton_Click;
            // 
            // playerStandButton
            // 
            playerStandButton.Location = new Point(37, 217);
            playerStandButton.Name = "playerStandButton";
            playerStandButton.Size = new Size(121, 38);
            playerStandButton.TabIndex = 13;
            playerStandButton.Text = "Stand";
            playerStandButton.UseVisualStyleBackColor = true;
            playerStandButton.Click += playerStandButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(removePlayerButton);
            groupBox2.Controls.Add(nextRoundButton);
            groupBox2.Controls.Add(addNewPlayerButton);
            groupBox2.Controls.Add(playerHitButton);
            groupBox2.Controls.Add(playerStandButton);
            groupBox2.Location = new Point(869, 325);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 341);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Player Actions";
            // 
            // removePlayerButton
            // 
            removePlayerButton.Location = new Point(38, 101);
            removePlayerButton.Name = "removePlayerButton";
            removePlayerButton.Size = new Size(121, 38);
            removePlayerButton.TabIndex = 15;
            removePlayerButton.Text = "Remove Player";
            removePlayerButton.UseVisualStyleBackColor = true;
            // 
            // nextRoundButton
            // 
            nextRoundButton.Location = new Point(38, 275);
            nextRoundButton.Name = "nextRoundButton";
            nextRoundButton.Size = new Size(120, 38);
            nextRoundButton.TabIndex = 14;
            nextRoundButton.Text = "Next Round";
            nextRoundButton.UseVisualStyleBackColor = true;
            nextRoundButton.Click += nextRoundButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 96);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(817, 570);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Enabled = false;
            radioButton7.Location = new Point(771, 491);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(14, 13);
            radioButton7.TabIndex = 21;
            radioButton7.TabStop = true;
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(659, 531);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(14, 13);
            radioButton6.TabIndex = 22;
            radioButton6.TabStop = true;
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(538, 551);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(14, 13);
            radioButton5.TabIndex = 23;
            radioButton5.TabStop = true;
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(421, 562);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(14, 13);
            radioButton4.TabIndex = 24;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(303, 551);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 25;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(191, 531);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(76, 491);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // playerControll1
            // 
            playerControll1.Location = new Point(857, 96);
            playerControll1.Name = "playerControll1";
            playerControll1.Size = new Size(317, 222);
            playerControll1.TabIndex = 28;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 700);
            Controls.Add(playerControll1);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(radioButton5);
            Controls.Add(radioButton6);
            Controls.Add(radioButton7);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dealerScoreLabel);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Assignment 4 Blackjack by Philip Holmqvist";
            Load += MainForm_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label dealerScoreLabel;
        private Label label2;
        private Label label3;
        private Button addNewPlayerButton;
        private Button playerHitButton;
        private Button playerStandButton;
        private GroupBox groupBox2;
        private Button nextRoundButton;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private Button removePlayerButton;
        private PlayerControll playerControll1;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton86;
    }
}