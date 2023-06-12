namespace TrackerUI
{
    partial class TournamentViewerForm
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
            TournamentLabel = new Label();
            TournamentNameLabel = new Label();
            RoundLabel = new Label();
            ComboBoxLabel = new ComboBox();
            unplayedCheckboxLabel = new CheckBox();
            MatchupListbox = new ListBox();
            TeamOneLabel = new Label();
            TeamOneScoreLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            TeamTwoScoreLabel = new Label();
            TeamTwoLabel = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // TournamentLabel
            // 
            TournamentLabel.AutoSize = true;
            TournamentLabel.Font = new Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentLabel.ForeColor = Color.FromArgb(55, 153, 255);
            TournamentLabel.Location = new Point(33, 18);
            TournamentLabel.Name = "TournamentLabel";
            TournamentLabel.Size = new Size(220, 54);
            TournamentLabel.TabIndex = 0;
            TournamentLabel.Text = "Tournament";
            TournamentLabel.Click += label1_Click;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentNameLabel.ForeColor = Color.FromArgb(55, 153, 255);
            TournamentNameLabel.Location = new Point(241, 18);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(159, 54);
            TournamentNameLabel.TabIndex = 1;
            TournamentNameLabel.Text = "<none>";
            TournamentNameLabel.Click += label2_Click;
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            RoundLabel.ForeColor = Color.FromArgb(55, 153, 255);
            RoundLabel.Location = new Point(33, 88);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(80, 31);
            RoundLabel.TabIndex = 2;
            RoundLabel.Text = "Round";
            // 
            // ComboBoxLabel
            // 
            ComboBoxLabel.FormattingEnabled = true;
            ComboBoxLabel.Location = new Point(119, 88);
            ComboBoxLabel.Name = "ComboBoxLabel";
            ComboBoxLabel.Size = new Size(151, 28);
            ComboBoxLabel.TabIndex = 3;
            // 
            // unplayedCheckboxLabel
            // 
            unplayedCheckboxLabel.AutoSize = true;
            unplayedCheckboxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedCheckboxLabel.ForeColor = Color.FromArgb(55, 153, 255);
            unplayedCheckboxLabel.Location = new Point(119, 122);
            unplayedCheckboxLabel.Name = "unplayedCheckboxLabel";
            unplayedCheckboxLabel.Size = new Size(159, 32);
            unplayedCheckboxLabel.TabIndex = 4;
            unplayedCheckboxLabel.Text = "UnplayedOnly";
            unplayedCheckboxLabel.UseVisualStyleBackColor = true;
            // 
            // MatchupListbox
            // 
            MatchupListbox.FormattingEnabled = true;
            MatchupListbox.ItemHeight = 20;
            MatchupListbox.Location = new Point(33, 160);
            MatchupListbox.Name = "MatchupListbox";
            MatchupListbox.Size = new Size(296, 244);
            MatchupListbox.TabIndex = 5;
            // 
            // TeamOneLabel
            // 
            TeamOneLabel.AutoSize = true;
            TeamOneLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TeamOneLabel.ForeColor = Color.FromArgb(55, 153, 255);
            TeamOneLabel.Location = new Point(360, 160);
            TeamOneLabel.Name = "TeamOneLabel";
            TeamOneLabel.Size = new Size(172, 38);
            TeamOneLabel.TabIndex = 6;
            TeamOneLabel.Text = "<team one>";
            // 
            // TeamOneScoreLabel
            // 
            TeamOneScoreLabel.AutoSize = true;
            TeamOneScoreLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TeamOneScoreLabel.ForeColor = Color.FromArgb(55, 153, 255);
            TeamOneScoreLabel.Location = new Point(360, 198);
            TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            TeamOneScoreLabel.Size = new Size(86, 38);
            TeamOneScoreLabel.TabIndex = 7;
            TeamOneScoreLabel.Text = "Score";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(456, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(456, 379);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            TeamTwoScoreLabel.AutoSize = true;
            TeamTwoScoreLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TeamTwoScoreLabel.ForeColor = Color.FromArgb(55, 153, 255);
            TeamTwoScoreLabel.Location = new Point(360, 368);
            TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            TeamTwoScoreLabel.Size = new Size(86, 38);
            TeamTwoScoreLabel.TabIndex = 10;
            TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoLabel
            // 
            TeamTwoLabel.AutoSize = true;
            TeamTwoLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            TeamTwoLabel.ForeColor = Color.FromArgb(55, 153, 255);
            TeamTwoLabel.Location = new Point(360, 330);
            TeamTwoLabel.Name = "TeamTwoLabel";
            TeamTwoLabel.Size = new Size(170, 38);
            TeamTwoLabel.TabIndex = 9;
            TeamTwoLabel.Text = "<team two>";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(55, 153, 255);
            label5.Location = new Point(360, 265);
            label5.Name = "label5";
            label5.Size = new Size(71, 38);
            label5.TabIndex = 12;
            label5.Text = "-VS-";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(55, 153, 255);
            button1.Location = new Point(596, 277);
            button1.Name = "button1";
            button1.Size = new Size(151, 43);
            button1.TabIndex = 13;
            button1.Text = "Score";
            button1.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(TeamTwoScoreLabel);
            Controls.Add(TeamTwoLabel);
            Controls.Add(textBox1);
            Controls.Add(TeamOneScoreLabel);
            Controls.Add(TeamOneLabel);
            Controls.Add(MatchupListbox);
            Controls.Add(unplayedCheckboxLabel);
            Controls.Add(ComboBoxLabel);
            Controls.Add(RoundLabel);
            Controls.Add(TournamentNameLabel);
            Controls.Add(TournamentLabel);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentLabel;
        private Label TournamentNameLabel;
        private Label RoundLabel;
        private ComboBox ComboBoxLabel;
        private CheckBox unplayedCheckboxLabel;
        private ListBox MatchupListbox;
        private Label TeamOneLabel;
        private Label TeamOneScoreLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label TeamTwoScoreLabel;
        private Label TeamTwoLabel;
        private Label label5;
        private Button button1;
    }
}