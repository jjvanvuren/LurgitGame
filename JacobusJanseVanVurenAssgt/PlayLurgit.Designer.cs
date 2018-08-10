namespace JacobusJanseVanVurenAssgt
{
    partial class PlayLurgit
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
            this.picbxDice1 = new System.Windows.Forms.PictureBox();
            this.picbxDice2 = new System.Windows.Forms.PictureBox();
            this.picbxDice3 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnKeepDie1 = new System.Windows.Forms.Button();
            this.btnKeepDie2 = new System.Windows.Forms.Button();
            this.btnKeepDie3 = new System.Windows.Forms.Button();
            this.lblDieStatus1 = new System.Windows.Forms.Label();
            this.lblDieStatus2 = new System.Windows.Forms.Label();
            this.lblDieStatus3 = new System.Windows.Forms.Label();
            this.lblPlayer1GameScore = new System.Windows.Forms.Label();
            this.txbxPlayer1GameScore = new System.Windows.Forms.TextBox();
            this.lblCurrentRound = new System.Windows.Forms.Label();
            this.lblPlayer2GameScore = new System.Windows.Forms.Label();
            this.txbxPlayer2GameScore = new System.Windows.Forms.TextBox();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.btnPlayComputer = new System.Windows.Forms.Button();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.btnP1EndRound = new System.Windows.Forms.Button();
            this.btnP2EndRound = new System.Windows.Forms.Button();
            this.grpbxLurgit = new System.Windows.Forms.GroupBox();
            this.lblComputerProgress = new System.Windows.Forms.Label();
            this.pbrComputerRound = new System.Windows.Forms.ProgressBar();
            this.txbxDisplayMessage = new System.Windows.Forms.TextBox();
            this.grpbxPlayer2 = new System.Windows.Forms.GroupBox();
            this.txbxBonusScoreP2 = new System.Windows.Forms.TextBox();
            this.lblBonusScoreP2 = new System.Windows.Forms.Label();
            this.grpbxPlayer1 = new System.Windows.Forms.GroupBox();
            this.txbxBonusScoreP1 = new System.Windows.Forms.TextBox();
            this.lblBonusScoreP1 = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.grpbxGameMode = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGameRules = new System.Windows.Forms.Button();
            this.grpbxGameOptions = new System.Windows.Forms.GroupBox();
            this.btnEndSession = new System.Windows.Forms.Button();
            this.lblBonusMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice3)).BeginInit();
            this.grpbxLurgit.SuspendLayout();
            this.grpbxPlayer2.SuspendLayout();
            this.grpbxPlayer1.SuspendLayout();
            this.grpbxGameMode.SuspendLayout();
            this.grpbxGameOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbxDice1
            // 
            this.picbxDice1.BackColor = System.Drawing.Color.Black;
            this.picbxDice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbxDice1.Location = new System.Drawing.Point(364, 165);
            this.picbxDice1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbxDice1.Name = "picbxDice1";
            this.picbxDice1.Size = new System.Drawing.Size(149, 151);
            this.picbxDice1.TabIndex = 0;
            this.picbxDice1.TabStop = false;
            // 
            // picbxDice2
            // 
            this.picbxDice2.BackColor = System.Drawing.Color.Black;
            this.picbxDice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbxDice2.Location = new System.Drawing.Point(552, 165);
            this.picbxDice2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbxDice2.Name = "picbxDice2";
            this.picbxDice2.Size = new System.Drawing.Size(149, 151);
            this.picbxDice2.TabIndex = 1;
            this.picbxDice2.TabStop = false;
            // 
            // picbxDice3
            // 
            this.picbxDice3.BackColor = System.Drawing.Color.Black;
            this.picbxDice3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbxDice3.Location = new System.Drawing.Point(738, 165);
            this.picbxDice3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbxDice3.Name = "picbxDice3";
            this.picbxDice3.Size = new System.Drawing.Size(149, 151);
            this.picbxDice3.TabIndex = 2;
            this.picbxDice3.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(364, 432);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(150, 40);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Roll Die";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnKeepDie1
            // 
            this.btnKeepDie1.Enabled = false;
            this.btnKeepDie1.Location = new System.Drawing.Point(364, 325);
            this.btnKeepDie1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKeepDie1.Name = "btnKeepDie1";
            this.btnKeepDie1.Size = new System.Drawing.Size(150, 40);
            this.btnKeepDie1.TabIndex = 5;
            this.btnKeepDie1.Text = "Keep";
            this.btnKeepDie1.UseVisualStyleBackColor = true;
            this.btnKeepDie1.Click += new System.EventHandler(this.btnKeepDie1_Click);
            // 
            // btnKeepDie2
            // 
            this.btnKeepDie2.Enabled = false;
            this.btnKeepDie2.Location = new System.Drawing.Point(552, 325);
            this.btnKeepDie2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKeepDie2.Name = "btnKeepDie2";
            this.btnKeepDie2.Size = new System.Drawing.Size(150, 40);
            this.btnKeepDie2.TabIndex = 6;
            this.btnKeepDie2.Text = "Keep";
            this.btnKeepDie2.UseVisualStyleBackColor = true;
            this.btnKeepDie2.Click += new System.EventHandler(this.btnKeepDie2_Click);
            // 
            // btnKeepDie3
            // 
            this.btnKeepDie3.Enabled = false;
            this.btnKeepDie3.Location = new System.Drawing.Point(738, 325);
            this.btnKeepDie3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKeepDie3.Name = "btnKeepDie3";
            this.btnKeepDie3.Size = new System.Drawing.Size(150, 40);
            this.btnKeepDie3.TabIndex = 7;
            this.btnKeepDie3.Text = "Keep";
            this.btnKeepDie3.UseVisualStyleBackColor = true;
            this.btnKeepDie3.Click += new System.EventHandler(this.btnKeepDice3_Click);
            // 
            // lblDieStatus1
            // 
            this.lblDieStatus1.AutoSize = true;
            this.lblDieStatus1.Location = new System.Drawing.Point(406, 138);
            this.lblDieStatus1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDieStatus1.Name = "lblDieStatus1";
            this.lblDieStatus1.Size = new System.Drawing.Size(69, 20);
            this.lblDieStatus1.TabIndex = 11;
            this.lblDieStatus1.Text = "Rolling   ";
            // 
            // lblDieStatus2
            // 
            this.lblDieStatus2.AutoSize = true;
            this.lblDieStatus2.Location = new System.Drawing.Point(594, 138);
            this.lblDieStatus2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDieStatus2.Name = "lblDieStatus2";
            this.lblDieStatus2.Size = new System.Drawing.Size(69, 20);
            this.lblDieStatus2.TabIndex = 12;
            this.lblDieStatus2.Text = "Rolling   ";
            // 
            // lblDieStatus3
            // 
            this.lblDieStatus3.AutoSize = true;
            this.lblDieStatus3.Location = new System.Drawing.Point(784, 138);
            this.lblDieStatus3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDieStatus3.Name = "lblDieStatus3";
            this.lblDieStatus3.Size = new System.Drawing.Size(69, 20);
            this.lblDieStatus3.TabIndex = 13;
            this.lblDieStatus3.Text = "Rolling   ";
            // 
            // lblPlayer1GameScore
            // 
            this.lblPlayer1GameScore.AutoSize = true;
            this.lblPlayer1GameScore.Location = new System.Drawing.Point(10, 49);
            this.lblPlayer1GameScore.Name = "lblPlayer1GameScore";
            this.lblPlayer1GameScore.Size = new System.Drawing.Size(103, 20);
            this.lblPlayer1GameScore.TabIndex = 16;
            this.lblPlayer1GameScore.Text = "Round Score";
            // 
            // txbxPlayer1GameScore
            // 
            this.txbxPlayer1GameScore.BackColor = System.Drawing.Color.White;
            this.txbxPlayer1GameScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxPlayer1GameScore.Location = new System.Drawing.Point(14, 72);
            this.txbxPlayer1GameScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbxPlayer1GameScore.Name = "txbxPlayer1GameScore";
            this.txbxPlayer1GameScore.ReadOnly = true;
            this.txbxPlayer1GameScore.Size = new System.Drawing.Size(158, 26);
            this.txbxPlayer1GameScore.TabIndex = 17;
            // 
            // lblCurrentRound
            // 
            this.lblCurrentRound.AutoSize = true;
            this.lblCurrentRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRound.Location = new System.Drawing.Point(364, 49);
            this.lblCurrentRound.Name = "lblCurrentRound";
            this.lblCurrentRound.Size = new System.Drawing.Size(108, 26);
            this.lblCurrentRound.TabIndex = 18;
            this.lblCurrentRound.Text = "Round: 1";
            // 
            // lblPlayer2GameScore
            // 
            this.lblPlayer2GameScore.AutoSize = true;
            this.lblPlayer2GameScore.Location = new System.Drawing.Point(10, 52);
            this.lblPlayer2GameScore.Name = "lblPlayer2GameScore";
            this.lblPlayer2GameScore.Size = new System.Drawing.Size(111, 20);
            this.lblPlayer2GameScore.TabIndex = 19;
            this.lblPlayer2GameScore.Text = "Player 2 Score";
            // 
            // txbxPlayer2GameScore
            // 
            this.txbxPlayer2GameScore.BackColor = System.Drawing.Color.White;
            this.txbxPlayer2GameScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxPlayer2GameScore.Location = new System.Drawing.Point(12, 78);
            this.txbxPlayer2GameScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbxPlayer2GameScore.Name = "txbxPlayer2GameScore";
            this.txbxPlayer2GameScore.ReadOnly = true;
            this.txbxPlayer2GameScore.Size = new System.Drawing.Size(158, 26);
            this.txbxPlayer2GameScore.TabIndex = 20;
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.Location = new System.Drawing.Point(8, 40);
            this.btnSinglePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(129, 40);
            this.btnSinglePlayer.TabIndex = 21;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = true;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.Location = new System.Drawing.Point(144, 40);
            this.btnTwoPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(129, 40);
            this.btnTwoPlayer.TabIndex = 22;
            this.btnTwoPlayer.Text = "Two Player";
            this.btnTwoPlayer.UseVisualStyleBackColor = true;
            this.btnTwoPlayer.Click += new System.EventHandler(this.btnTwoPlayer_Click);
            // 
            // btnPlayComputer
            // 
            this.btnPlayComputer.Location = new System.Drawing.Point(280, 40);
            this.btnPlayComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayComputer.Name = "btnPlayComputer";
            this.btnPlayComputer.Size = new System.Drawing.Size(129, 40);
            this.btnPlayComputer.TabIndex = 23;
            this.btnPlayComputer.Text = "Play Computer";
            this.btnPlayComputer.UseVisualStyleBackColor = true;
            this.btnPlayComputer.Click += new System.EventHandler(this.btnPlayComputer_Click);
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(10, 12);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(73, 20);
            this.lblPlayer1Name.TabIndex = 25;
            this.lblPlayer1Name.Text = "Player 1: ";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(8, 12);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(73, 20);
            this.lblPlayer2Name.TabIndex = 26;
            this.lblPlayer2Name.Text = "Player 2: ";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.Location = new System.Drawing.Point(364, 25);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(173, 26);
            this.lblCurrentPlayer.TabIndex = 27;
            this.lblCurrentPlayer.Text = "Current Player:";
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTurn.Location = new System.Drawing.Point(364, 75);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(86, 26);
            this.lblCurrentTurn.TabIndex = 28;
            this.lblCurrentTurn.Text = "Turn: 1";
            // 
            // btnP1EndRound
            // 
            this.btnP1EndRound.Enabled = false;
            this.btnP1EndRound.Location = new System.Drawing.Point(14, 173);
            this.btnP1EndRound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnP1EndRound.Name = "btnP1EndRound";
            this.btnP1EndRound.Size = new System.Drawing.Size(159, 40);
            this.btnP1EndRound.TabIndex = 29;
            this.btnP1EndRound.Text = "End Round";
            this.btnP1EndRound.UseVisualStyleBackColor = true;
            this.btnP1EndRound.Click += new System.EventHandler(this.btnP1EndRound_Click);
            // 
            // btnP2EndRound
            // 
            this.btnP2EndRound.Enabled = false;
            this.btnP2EndRound.Location = new System.Drawing.Point(12, 177);
            this.btnP2EndRound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnP2EndRound.Name = "btnP2EndRound";
            this.btnP2EndRound.Size = new System.Drawing.Size(159, 40);
            this.btnP2EndRound.TabIndex = 30;
            this.btnP2EndRound.Text = "End Round";
            this.btnP2EndRound.UseVisualStyleBackColor = true;
            this.btnP2EndRound.Click += new System.EventHandler(this.btnP2EndRound_Click);
            // 
            // grpbxLurgit
            // 
            this.grpbxLurgit.Controls.Add(this.lblBonusMessage);
            this.grpbxLurgit.Controls.Add(this.lblComputerProgress);
            this.grpbxLurgit.Controls.Add(this.pbrComputerRound);
            this.grpbxLurgit.Controls.Add(this.txbxDisplayMessage);
            this.grpbxLurgit.Controls.Add(this.grpbxPlayer2);
            this.grpbxLurgit.Controls.Add(this.grpbxPlayer1);
            this.grpbxLurgit.Controls.Add(this.lblCurrentTurn);
            this.grpbxLurgit.Controls.Add(this.lblCurrentPlayer);
            this.grpbxLurgit.Controls.Add(this.lblCurrentRound);
            this.grpbxLurgit.Controls.Add(this.lblDieStatus3);
            this.grpbxLurgit.Controls.Add(this.lblDieStatus2);
            this.grpbxLurgit.Controls.Add(this.lblDieStatus1);
            this.grpbxLurgit.Controls.Add(this.btnKeepDie3);
            this.grpbxLurgit.Controls.Add(this.btnKeepDie2);
            this.grpbxLurgit.Controls.Add(this.btnKeepDie1);
            this.grpbxLurgit.Controls.Add(this.btnRoll);
            this.grpbxLurgit.Controls.Add(this.picbxDice3);
            this.grpbxLurgit.Controls.Add(this.picbxDice2);
            this.grpbxLurgit.Controls.Add(this.picbxDice1);
            this.grpbxLurgit.Enabled = false;
            this.grpbxLurgit.Location = new System.Drawing.Point(22, 115);
            this.grpbxLurgit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLurgit.Name = "grpbxLurgit";
            this.grpbxLurgit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLurgit.Size = new System.Drawing.Size(932, 845);
            this.grpbxLurgit.TabIndex = 31;
            this.grpbxLurgit.TabStop = false;
            this.grpbxLurgit.Visible = false;
            // 
            // lblComputerProgress
            // 
            this.lblComputerProgress.AutoSize = true;
            this.lblComputerProgress.Location = new System.Drawing.Point(552, 406);
            this.lblComputerProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputerProgress.Name = "lblComputerProgress";
            this.lblComputerProgress.Size = new System.Drawing.Size(314, 20);
            this.lblComputerProgress.TabIndex = 35;
            this.lblComputerProgress.Text = "Computer Round Progress:  Taking turn 1   ";
            this.lblComputerProgress.Visible = false;
            // 
            // pbrComputerRound
            // 
            this.pbrComputerRound.Location = new System.Drawing.Point(552, 432);
            this.pbrComputerRound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbrComputerRound.Maximum = 4;
            this.pbrComputerRound.Name = "pbrComputerRound";
            this.pbrComputerRound.Size = new System.Drawing.Size(336, 40);
            this.pbrComputerRound.Step = 1;
            this.pbrComputerRound.TabIndex = 34;
            this.pbrComputerRound.Visible = false;
            // 
            // txbxDisplayMessage
            // 
            this.txbxDisplayMessage.BackColor = System.Drawing.Color.Black;
            this.txbxDisplayMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxDisplayMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxDisplayMessage.ForeColor = System.Drawing.Color.White;
            this.txbxDisplayMessage.Location = new System.Drawing.Point(12, 485);
            this.txbxDisplayMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbxDisplayMessage.Multiline = true;
            this.txbxDisplayMessage.Name = "txbxDisplayMessage";
            this.txbxDisplayMessage.ReadOnly = true;
            this.txbxDisplayMessage.Size = new System.Drawing.Size(310, 346);
            this.txbxDisplayMessage.TabIndex = 33;
            this.txbxDisplayMessage.Text = "Game Start! Player 1 it\'s your turn!";
            // 
            // grpbxPlayer2
            // 
            this.grpbxPlayer2.Controls.Add(this.txbxBonusScoreP2);
            this.grpbxPlayer2.Controls.Add(this.btnP2EndRound);
            this.grpbxPlayer2.Controls.Add(this.lblBonusScoreP2);
            this.grpbxPlayer2.Controls.Add(this.lblPlayer2Name);
            this.grpbxPlayer2.Controls.Add(this.txbxPlayer2GameScore);
            this.grpbxPlayer2.Controls.Add(this.lblPlayer2GameScore);
            this.grpbxPlayer2.Location = new System.Drawing.Point(12, 242);
            this.grpbxPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxPlayer2.Name = "grpbxPlayer2";
            this.grpbxPlayer2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxPlayer2.Size = new System.Drawing.Size(310, 231);
            this.grpbxPlayer2.TabIndex = 32;
            this.grpbxPlayer2.TabStop = false;
            // 
            // txbxBonusScoreP2
            // 
            this.txbxBonusScoreP2.BackColor = System.Drawing.Color.White;
            this.txbxBonusScoreP2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxBonusScoreP2.Location = new System.Drawing.Point(12, 137);
            this.txbxBonusScoreP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbxBonusScoreP2.Name = "txbxBonusScoreP2";
            this.txbxBonusScoreP2.ReadOnly = true;
            this.txbxBonusScoreP2.Size = new System.Drawing.Size(158, 26);
            this.txbxBonusScoreP2.TabIndex = 37;
            // 
            // lblBonusScoreP2
            // 
            this.lblBonusScoreP2.AutoSize = true;
            this.lblBonusScoreP2.Location = new System.Drawing.Point(8, 114);
            this.lblBonusScoreP2.Name = "lblBonusScoreP2";
            this.lblBonusScoreP2.Size = new System.Drawing.Size(55, 20);
            this.lblBonusScoreP2.TabIndex = 36;
            this.lblBonusScoreP2.Text = "Bonus";
            // 
            // grpbxPlayer1
            // 
            this.grpbxPlayer1.Controls.Add(this.txbxBonusScoreP1);
            this.grpbxPlayer1.Controls.Add(this.lblBonusScoreP1);
            this.grpbxPlayer1.Controls.Add(this.btnP1EndRound);
            this.grpbxPlayer1.Controls.Add(this.lblPlayer1Name);
            this.grpbxPlayer1.Controls.Add(this.txbxPlayer1GameScore);
            this.grpbxPlayer1.Controls.Add(this.lblPlayer1GameScore);
            this.grpbxPlayer1.Location = new System.Drawing.Point(12, 12);
            this.grpbxPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxPlayer1.Name = "grpbxPlayer1";
            this.grpbxPlayer1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxPlayer1.Size = new System.Drawing.Size(310, 231);
            this.grpbxPlayer1.TabIndex = 31;
            this.grpbxPlayer1.TabStop = false;
            // 
            // txbxBonusScoreP1
            // 
            this.txbxBonusScoreP1.BackColor = System.Drawing.Color.White;
            this.txbxBonusScoreP1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxBonusScoreP1.Location = new System.Drawing.Point(14, 133);
            this.txbxBonusScoreP1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbxBonusScoreP1.Name = "txbxBonusScoreP1";
            this.txbxBonusScoreP1.ReadOnly = true;
            this.txbxBonusScoreP1.Size = new System.Drawing.Size(158, 26);
            this.txbxBonusScoreP1.TabIndex = 31;
            // 
            // lblBonusScoreP1
            // 
            this.lblBonusScoreP1.AutoSize = true;
            this.lblBonusScoreP1.Location = new System.Drawing.Point(10, 109);
            this.lblBonusScoreP1.Name = "lblBonusScoreP1";
            this.lblBonusScoreP1.Size = new System.Drawing.Size(55, 20);
            this.lblBonusScoreP1.TabIndex = 30;
            this.lblBonusScoreP1.Text = "Bonus";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(8, 40);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(112, 40);
            this.btnPlayAgain.TabIndex = 34;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // grpbxGameMode
            // 
            this.grpbxGameMode.Controls.Add(this.btnPlayComputer);
            this.grpbxGameMode.Controls.Add(this.btnTwoPlayer);
            this.grpbxGameMode.Controls.Add(this.btnSinglePlayer);
            this.grpbxGameMode.Location = new System.Drawing.Point(22, 25);
            this.grpbxGameMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxGameMode.Name = "grpbxGameMode";
            this.grpbxGameMode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxGameMode.Size = new System.Drawing.Size(417, 89);
            this.grpbxGameMode.TabIndex = 32;
            this.grpbxGameMode.TabStop = false;
            this.grpbxGameMode.Text = "Game Mode";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(382, 40);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 40);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGameRules
            // 
            this.btnGameRules.Location = new System.Drawing.Point(264, 40);
            this.btnGameRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGameRules.Name = "btnGameRules";
            this.btnGameRules.Size = new System.Drawing.Size(112, 40);
            this.btnGameRules.TabIndex = 37;
            this.btnGameRules.Text = "Game Rules";
            this.btnGameRules.UseVisualStyleBackColor = true;
            this.btnGameRules.Click += new System.EventHandler(this.btnGameRules_Click);
            // 
            // grpbxGameOptions
            // 
            this.grpbxGameOptions.Controls.Add(this.btnEndSession);
            this.grpbxGameOptions.Controls.Add(this.btnGameRules);
            this.grpbxGameOptions.Controls.Add(this.btnPlayAgain);
            this.grpbxGameOptions.Controls.Add(this.btnExit);
            this.grpbxGameOptions.Location = new System.Drawing.Point(450, 25);
            this.grpbxGameOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxGameOptions.Name = "grpbxGameOptions";
            this.grpbxGameOptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxGameOptions.Size = new System.Drawing.Size(504, 89);
            this.grpbxGameOptions.TabIndex = 38;
            this.grpbxGameOptions.TabStop = false;
            this.grpbxGameOptions.Text = "Game Options";
            // 
            // btnEndSession
            // 
            this.btnEndSession.Location = new System.Drawing.Point(127, 40);
            this.btnEndSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(129, 40);
            this.btnEndSession.TabIndex = 38;
            this.btnEndSession.Text = "End Session";
            this.btnEndSession.UseVisualStyleBackColor = true;
            this.btnEndSession.Visible = false;
            this.btnEndSession.Click += new System.EventHandler(this.btnEndSession_Click);
            // 
            // lblBonusMessage
            // 
            this.lblBonusMessage.AutoSize = true;
            this.lblBonusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonusMessage.Location = new System.Drawing.Point(366, 543);
            this.lblBonusMessage.Name = "lblBonusMessage";
            this.lblBonusMessage.Size = new System.Drawing.Size(0, 26);
            this.lblBonusMessage.TabIndex = 36;
            // 
            // PlayLurgit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 982);
            this.Controls.Add(this.grpbxGameOptions);
            this.Controls.Add(this.grpbxGameMode);
            this.Controls.Add(this.grpbxLurgit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlayLurgit";
            this.Text = "Lurgit Dice Game";
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice3)).EndInit();
            this.grpbxLurgit.ResumeLayout(false);
            this.grpbxLurgit.PerformLayout();
            this.grpbxPlayer2.ResumeLayout(false);
            this.grpbxPlayer2.PerformLayout();
            this.grpbxPlayer1.ResumeLayout(false);
            this.grpbxPlayer1.PerformLayout();
            this.grpbxGameMode.ResumeLayout(false);
            this.grpbxGameOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnKeepDie1;
        private System.Windows.Forms.Button btnKeepDie2;
        private System.Windows.Forms.Button btnKeepDie3;
        private System.Windows.Forms.Label lblDieStatus1;
        private System.Windows.Forms.Label lblDieStatus2;
        private System.Windows.Forms.Label lblDieStatus3;
        private System.Windows.Forms.Label lblPlayer1GameScore;
        private System.Windows.Forms.TextBox txbxPlayer1GameScore;
        private System.Windows.Forms.Label lblCurrentRound;
        private System.Windows.Forms.Label lblPlayer2GameScore;
        private System.Windows.Forms.TextBox txbxPlayer2GameScore;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.Button btnPlayComputer;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.Button btnP1EndRound;
        private System.Windows.Forms.Button btnP2EndRound;
        private System.Windows.Forms.GroupBox grpbxLurgit;
        private System.Windows.Forms.GroupBox grpbxPlayer2;
        private System.Windows.Forms.GroupBox grpbxPlayer1;
        private System.Windows.Forms.GroupBox grpbxGameMode;
        private System.Windows.Forms.TextBox txbxDisplayMessage;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picbxDice2;
        private System.Windows.Forms.PictureBox picbxDice3;
        private System.Windows.Forms.PictureBox picbxDice1;
        private System.Windows.Forms.Label lblComputerProgress;
        private System.Windows.Forms.ProgressBar pbrComputerRound;
        private System.Windows.Forms.Button btnGameRules;
        private System.Windows.Forms.GroupBox grpbxGameOptions;
        private System.Windows.Forms.TextBox txbxBonusScoreP2;
        private System.Windows.Forms.Label lblBonusScoreP2;
        private System.Windows.Forms.TextBox txbxBonusScoreP1;
        private System.Windows.Forms.Label lblBonusScoreP1;
        private System.Windows.Forms.Button btnEndSession;
        private System.Windows.Forms.Label lblBonusMessage;
    }
}

