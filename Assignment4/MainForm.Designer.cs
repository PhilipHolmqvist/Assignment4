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
            dealerButton = new RadioButton();
            scoreLabel1 = new Label();
            scoreLabel2 = new Label();
            scoreLabel3 = new Label();
            scoreLabel4 = new Label();
            scoreLabel5 = new Label();
            scoreLabel6 = new Label();
            scoreLabel7 = new Label();
            clearHandsButton = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dealerScoreLabel
            // 
            dealerScoreLabel.AutoSize = true;
            dealerScoreLabel.BackColor = Color.Transparent;
            dealerScoreLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dealerScoreLabel.Location = new Point(434, 35);
            dealerScoreLabel.Name = "dealerScoreLabel";
            dealerScoreLabel.Size = new Size(139, 30);
            dealerScoreLabel.TabIndex = 8;
            dealerScoreLabel.Text = "Dealer score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 35);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 9;
            label2.Text = "Number of decks in play:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 69);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 10;
            label3.Text = "Number of players:";
            // 
            // addNewPlayerButton
            // 
            addNewPlayerButton.Location = new Point(42, 57);
            addNewPlayerButton.Margin = new Padding(3, 4, 3, 4);
            addNewPlayerButton.Name = "addNewPlayerButton";
            addNewPlayerButton.Size = new Size(138, 51);
            addNewPlayerButton.TabIndex = 11;
            addNewPlayerButton.Text = "Add player";
            addNewPlayerButton.UseVisualStyleBackColor = true;
            addNewPlayerButton.Click += addNewPlayerButton_Click;
            // 
            // playerHitButton
            // 
            playerHitButton.Location = new Point(42, 212);
            playerHitButton.Margin = new Padding(3, 4, 3, 4);
            playerHitButton.Name = "playerHitButton";
            playerHitButton.Size = new Size(138, 51);
            playerHitButton.TabIndex = 12;
            playerHitButton.Text = "Hit";
            playerHitButton.UseVisualStyleBackColor = true;
            playerHitButton.Click += playerHitButton_Click;
            // 
            // playerStandButton
            // 
            playerStandButton.Location = new Point(42, 289);
            playerStandButton.Margin = new Padding(3, 4, 3, 4);
            playerStandButton.Name = "playerStandButton";
            playerStandButton.Size = new Size(138, 51);
            playerStandButton.TabIndex = 13;
            playerStandButton.Text = "Stand";
            playerStandButton.UseVisualStyleBackColor = true;
            playerStandButton.Click += playerStandButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(clearHandsButton);
            groupBox2.Controls.Add(removePlayerButton);
            groupBox2.Controls.Add(nextRoundButton);
            groupBox2.Controls.Add(addNewPlayerButton);
            groupBox2.Controls.Add(playerHitButton);
            groupBox2.Controls.Add(playerStandButton);
            groupBox2.Location = new Point(992, 401);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(229, 519);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Player Actions";
            // 
            // removePlayerButton
            // 
            removePlayerButton.Location = new Point(43, 135);
            removePlayerButton.Margin = new Padding(3, 4, 3, 4);
            removePlayerButton.Name = "removePlayerButton";
            removePlayerButton.Size = new Size(138, 51);
            removePlayerButton.TabIndex = 15;
            removePlayerButton.Text = "Remove Player";
            removePlayerButton.UseVisualStyleBackColor = true;
            removePlayerButton.Click += removePlayerButton_Click;
            // 
            // nextRoundButton
            // 
            nextRoundButton.Location = new Point(43, 367);
            nextRoundButton.Margin = new Padding(3, 4, 3, 4);
            nextRoundButton.Name = "nextRoundButton";
            nextRoundButton.Size = new Size(137, 51);
            nextRoundButton.TabIndex = 14;
            nextRoundButton.Text = "Next Round";
            nextRoundButton.UseVisualStyleBackColor = true;
            nextRoundButton.Click += nextRoundButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(934, 760);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(881, 655);
            radioButton7.Margin = new Padding(3, 4, 3, 4);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(17, 16);
            radioButton7.TabIndex = 21;
            radioButton7.TabStop = true;
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(753, 708);
            radioButton6.Margin = new Padding(3, 4, 3, 4);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(17, 16);
            radioButton6.TabIndex = 22;
            radioButton6.TabStop = true;
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(615, 735);
            radioButton5.Margin = new Padding(3, 4, 3, 4);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(17, 16);
            radioButton5.TabIndex = 23;
            radioButton5.TabStop = true;
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(481, 749);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(17, 16);
            radioButton4.TabIndex = 24;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(346, 735);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(17, 16);
            radioButton3.TabIndex = 25;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(218, 708);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(17, 16);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(87, 655);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // playerControll1
            // 
            playerControll1.Location = new Point(979, 128);
            playerControll1.Margin = new Padding(3, 5, 3, 5);
            playerControll1.Name = "playerControll1";
            playerControll1.Size = new Size(362, 296);
            playerControll1.TabIndex = 28;
            // 
            // dealerButton
            // 
            dealerButton.AutoSize = true;
            dealerButton.Location = new Point(378, 347);
            dealerButton.Margin = new Padding(3, 4, 3, 4);
            dealerButton.Name = "dealerButton";
            dealerButton.Size = new Size(17, 16);
            dealerButton.TabIndex = 29;
            dealerButton.TabStop = true;
            dealerButton.UseVisualStyleBackColor = true;
            dealerButton.Visible = false;
            // 
            // scoreLabel1
            // 
            scoreLabel1.AutoSize = true;
            scoreLabel1.Location = new Point(71, 679);
            scoreLabel1.Name = "scoreLabel1";
            scoreLabel1.Size = new Size(54, 20);
            scoreLabel1.TabIndex = 30;
            scoreLabel1.Text = "Score1";
            // 
            // scoreLabel2
            // 
            scoreLabel2.AutoSize = true;
            scoreLabel2.Location = new Point(205, 732);
            scoreLabel2.Name = "scoreLabel2";
            scoreLabel2.Size = new Size(54, 20);
            scoreLabel2.TabIndex = 31;
            scoreLabel2.Text = "Score2";
            // 
            // scoreLabel3
            // 
            scoreLabel3.AutoSize = true;
            scoreLabel3.Location = new Point(334, 760);
            scoreLabel3.Name = "scoreLabel3";
            scoreLabel3.Size = new Size(54, 20);
            scoreLabel3.TabIndex = 32;
            scoreLabel3.Text = "Score3";
            // 
            // scoreLabel4
            // 
            scoreLabel4.AutoSize = true;
            scoreLabel4.Location = new Point(465, 771);
            scoreLabel4.Name = "scoreLabel4";
            scoreLabel4.Size = new Size(54, 20);
            scoreLabel4.TabIndex = 33;
            scoreLabel4.Text = "Score4";
            // 
            // scoreLabel5
            // 
            scoreLabel5.AutoSize = true;
            scoreLabel5.Location = new Point(600, 760);
            scoreLabel5.Name = "scoreLabel5";
            scoreLabel5.Size = new Size(54, 20);
            scoreLabel5.TabIndex = 34;
            scoreLabel5.Text = "Score5";
            // 
            // scoreLabel6
            // 
            scoreLabel6.AutoSize = true;
            scoreLabel6.Location = new Point(739, 735);
            scoreLabel6.Name = "scoreLabel6";
            scoreLabel6.Size = new Size(54, 20);
            scoreLabel6.TabIndex = 35;
            scoreLabel6.Text = "Score6";
            // 
            // scoreLabel7
            // 
            scoreLabel7.AutoSize = true;
            scoreLabel7.Location = new Point(866, 679);
            scoreLabel7.Name = "scoreLabel7";
            scoreLabel7.Size = new Size(54, 20);
            scoreLabel7.TabIndex = 36;
            scoreLabel7.Text = "Score7";
            // 
            // clearHandsButton
            // 
            clearHandsButton.Location = new Point(42, 439);
            clearHandsButton.Name = "clearHandsButton";
            clearHandsButton.Size = new Size(137, 48);
            clearHandsButton.TabIndex = 16;
            clearHandsButton.Text = "Clear Hands";
            clearHandsButton.UseVisualStyleBackColor = true;
            clearHandsButton.Click += clearHandsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 933);
            Controls.Add(scoreLabel7);
            Controls.Add(scoreLabel6);
            Controls.Add(scoreLabel5);
            Controls.Add(scoreLabel4);
            Controls.Add(scoreLabel3);
            Controls.Add(scoreLabel2);
            Controls.Add(scoreLabel1);
            Controls.Add(dealerButton);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private RadioButton dealerButton;
        private Label scoreLabel1;
        private Label scoreLabel2;
        private Label scoreLabel3;
        private Label scoreLabel4;
        private Label scoreLabel5;
        private Label scoreLabel6;
        private Label scoreLabel7;
        private Button clearHandsButton;
    }
}