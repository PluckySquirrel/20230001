namespace TrackerUI
{
    partial class CreateTournamentForm
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
            CreateTourLabel = new Label();
            TourNameLabel = new Label();
            TournamentNameTextBox = new TextBox();
            EntryFeeLabel = new Label();
            EntryFeeTextBox = new TextBox();
            SelectTeamLabel = new Label();
            SelectTeamDropDown = new ComboBox();
            CreateNewTeamLinkLabel = new LinkLabel();
            AddTeamButton = new Button();
            CreatePrizeButton = new Button();
            TournamentPlayerListBox = new ListBox();
            TeamsPlayersLabel = new Label();
            DeleteSelectedPlayerButton = new Button();
            DeleteSelectedPrizeButton = new Button();
            label1 = new Label();
            PrizesListBox = new ListBox();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // CreateTourLabel
            // 
            CreateTourLabel.AutoSize = true;
            CreateTourLabel.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTourLabel.ForeColor = Color.FromArgb(55, 153, 255);
            CreateTourLabel.Location = new Point(37, 31);
            CreateTourLabel.Name = "CreateTourLabel";
            CreateTourLabel.Size = new Size(266, 41);
            CreateTourLabel.TabIndex = 1;
            CreateTourLabel.Text = "Create Tournament";
            CreateTourLabel.Click += TournamentLabel_Click;
            // 
            // TourNameLabel
            // 
            TourNameLabel.AutoSize = true;
            TourNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TourNameLabel.ForeColor = Color.FromArgb(55, 153, 255);
            TourNameLabel.Location = new Point(37, 88);
            TourNameLabel.Name = "TourNameLabel";
            TourNameLabel.Size = new Size(203, 31);
            TourNameLabel.TabIndex = 3;
            TourNameLabel.Text = "Tournament Name";
            // 
            // TournamentNameTextBox
            // 
            TournamentNameTextBox.Location = new Point(42, 122);
            TournamentNameTextBox.Name = "TournamentNameTextBox";
            TournamentNameTextBox.Size = new Size(261, 27);
            TournamentNameTextBox.TabIndex = 4;
            TournamentNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EntryFeeLabel.ForeColor = Color.FromArgb(55, 153, 255);
            EntryFeeLabel.Location = new Point(37, 163);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.Size = new Size(107, 31);
            EntryFeeLabel.TabIndex = 5;
            EntryFeeLabel.Text = "Entry Fee";
            EntryFeeLabel.Click += EntryFeeLabel_Click;
            // 
            // EntryFeeTextBox
            // 
            EntryFeeTextBox.Location = new Point(150, 167);
            EntryFeeTextBox.Name = "EntryFeeTextBox";
            EntryFeeTextBox.Size = new Size(75, 27);
            EntryFeeTextBox.TabIndex = 6;
            EntryFeeTextBox.Text = "0";
            EntryFeeTextBox.TextChanged += textBox2_TextChanged;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTeamLabel.ForeColor = Color.FromArgb(55, 153, 255);
            SelectTeamLabel.Location = new Point(37, 219);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(135, 31);
            SelectTeamLabel.TabIndex = 7;
            SelectTeamLabel.Text = "Select Team";
            SelectTeamLabel.Click += SelectTeamLabel_Click;
            // 
            // SelectTeamDropDown
            // 
            SelectTeamDropDown.FormattingEnabled = true;
            SelectTeamDropDown.Location = new Point(42, 253);
            SelectTeamDropDown.Name = "SelectTeamDropDown";
            SelectTeamDropDown.Size = new Size(261, 28);
            SelectTeamDropDown.TabIndex = 8;
            // 
            // CreateNewTeamLinkLabel
            // 
            CreateNewTeamLinkLabel.AutoSize = true;
            CreateNewTeamLinkLabel.Location = new Point(227, 230);
            CreateNewTeamLinkLabel.Name = "CreateNewTeamLinkLabel";
            CreateNewTeamLinkLabel.Size = new Size(81, 20);
            CreateNewTeamLinkLabel.TabIndex = 9;
            CreateNewTeamLinkLabel.TabStop = true;
            CreateNewTeamLinkLabel.Text = "create new";
            // 
            // AddTeamButton
            // 
            AddTeamButton.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            AddTeamButton.FlatStyle = FlatStyle.Flat;
            AddTeamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddTeamButton.ForeColor = Color.FromArgb(55, 153, 255);
            AddTeamButton.Location = new Point(89, 317);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(151, 31);
            AddTeamButton.TabIndex = 14;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreatePrizeButton.ForeColor = Color.FromArgb(55, 153, 255);
            CreatePrizeButton.Location = new Point(89, 374);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(151, 31);
            CreatePrizeButton.TabIndex = 15;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayerListBox
            // 
            TournamentPlayerListBox.FormattingEnabled = true;
            TournamentPlayerListBox.ItemHeight = 20;
            TournamentPlayerListBox.Location = new Point(362, 122);
            TournamentPlayerListBox.Name = "TournamentPlayerListBox";
            TournamentPlayerListBox.Size = new Size(237, 124);
            TournamentPlayerListBox.TabIndex = 16;
            // 
            // TeamsPlayersLabel
            // 
            TeamsPlayersLabel.AutoSize = true;
            TeamsPlayersLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TeamsPlayersLabel.ForeColor = Color.FromArgb(55, 153, 255);
            TeamsPlayersLabel.Location = new Point(362, 88);
            TeamsPlayersLabel.Name = "TeamsPlayersLabel";
            TeamsPlayersLabel.Size = new Size(171, 31);
            TeamsPlayersLabel.TabIndex = 17;
            TeamsPlayersLabel.Text = "Teams / Players";
            TeamsPlayersLabel.Click += label1_Click;
            // 
            // DeleteSelectedPlayerButton
            // 
            DeleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            DeleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteSelectedPlayerButton.ForeColor = Color.FromArgb(55, 153, 255);
            DeleteSelectedPlayerButton.Location = new Point(618, 167);
            DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            DeleteSelectedPlayerButton.Size = new Size(151, 43);
            DeleteSelectedPlayerButton.TabIndex = 18;
            DeleteSelectedPlayerButton.Text = "Delete Selected";
            DeleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            DeleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            DeleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteSelectedPrizeButton.ForeColor = Color.FromArgb(55, 153, 255);
            DeleteSelectedPrizeButton.Location = new Point(618, 338);
            DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            DeleteSelectedPrizeButton.Size = new Size(151, 43);
            DeleteSelectedPrizeButton.TabIndex = 21;
            DeleteSelectedPrizeButton.Text = "Delete Selected";
            DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(55, 153, 255);
            label1.Location = new Point(362, 259);
            label1.Name = "label1";
            label1.Size = new Size(171, 31);
            label1.TabIndex = 20;
            label1.Text = "Teams / Players";
            // 
            // PrizesListBox
            // 
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 20;
            PrizesListBox.Location = new Point(362, 293);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(237, 124);
            PrizesListBox.TabIndex = 19;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTournamentButton.ForeColor = Color.FromArgb(55, 153, 255);
            CreateTournamentButton.Location = new Point(227, 446);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(306, 78);
            CreateTournamentButton.TabIndex = 22;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 548);
            Controls.Add(CreateTournamentButton);
            Controls.Add(DeleteSelectedPrizeButton);
            Controls.Add(label1);
            Controls.Add(PrizesListBox);
            Controls.Add(DeleteSelectedPlayerButton);
            Controls.Add(TeamsPlayersLabel);
            Controls.Add(TournamentPlayerListBox);
            Controls.Add(CreatePrizeButton);
            Controls.Add(AddTeamButton);
            Controls.Add(CreateNewTeamLinkLabel);
            Controls.Add(SelectTeamDropDown);
            Controls.Add(SelectTeamLabel);
            Controls.Add(EntryFeeTextBox);
            Controls.Add(EntryFeeLabel);
            Controls.Add(TournamentNameTextBox);
            Controls.Add(TourNameLabel);
            Controls.Add(CreateTourLabel);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            Load += CreateTournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTourLabel;
        private Label TourNameLabel;
        private TextBox TournamentNameTextBox;
        private Label EntryFeeLabel;
        private TextBox EntryFeeTextBox;
        private Label SelectTeamLabel;
        private ComboBox SelectTeamDropDown;
        private LinkLabel CreateNewTeamLinkLabel;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private ListBox TournamentPlayerListBox;
        private Label TeamsPlayersLabel;
        private Button DeleteSelectedPlayerButton;
        private Button DeleteSelectedPrizeButton;
        private Label label1;
        private ListBox PrizesListBox;
        private Button CreateTournamentButton;
    }
}