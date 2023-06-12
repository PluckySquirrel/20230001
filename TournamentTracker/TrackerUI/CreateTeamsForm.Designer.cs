namespace TrackerUI
{
    partial class CreateTeamsForm
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
            CreateTeamLabel = new Label();
            TeamNameLabel = new Label();
            TeamNameValue = new TextBox();
            SelectTeamLabel = new Label();
            comboBox1 = new ComboBox();
            AddMemberButton = new Button();
            AddMemberListBox = new GroupBox();
            textBox1 = new TextBox();
            FirstNameLabel = new Label();
            LastNameText = new TextBox();
            LastNameLabel = new Label();
            EmailText = new TextBox();
            label1 = new Label();
            CellPhoneText = new TextBox();
            label2 = new Label();
            CreateMemberButton = new Button();
            TeamMemberListBox = new ListBox();
            DeleteMemberButton = new Button();
            CreateTeamButton = new Button();
            AddMemberListBox.SuspendLayout();
            SuspendLayout();
            // 
            // CreateTeamLabel
            // 
            CreateTeamLabel.AutoSize = true;
            CreateTeamLabel.Font = new Font("Segoe UI Semilight", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTeamLabel.ForeColor = Color.FromArgb(55, 153, 255);
            CreateTeamLabel.Location = new Point(40, 32);
            CreateTeamLabel.Name = "CreateTeamLabel";
            CreateTeamLabel.Size = new Size(221, 50);
            CreateTeamLabel.TabIndex = 7;
            CreateTeamLabel.Text = "Create Team";
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TeamNameLabel.ForeColor = Color.FromArgb(55, 153, 255);
            TeamNameLabel.Location = new Point(40, 94);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(135, 31);
            TeamNameLabel.TabIndex = 8;
            TeamNameLabel.Text = "Team Name";
            // 
            // TeamNameValue
            // 
            TeamNameValue.Location = new Point(45, 128);
            TeamNameValue.Name = "TeamNameValue";
            TeamNameValue.Size = new Size(261, 27);
            TeamNameValue.TabIndex = 9;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTeamLabel.ForeColor = Color.FromArgb(55, 153, 255);
            SelectTeamLabel.Location = new Point(40, 170);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(135, 31);
            SelectTeamLabel.TabIndex = 10;
            SelectTeamLabel.Text = "Select Team";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(40, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 28);
            comboBox1.TabIndex = 11;
            // 
            // AddMemberButton
            // 
            AddMemberButton.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            AddMemberButton.FlatStyle = FlatStyle.Flat;
            AddMemberButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddMemberButton.ForeColor = Color.FromArgb(55, 153, 255);
            AddMemberButton.Location = new Point(93, 238);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(151, 47);
            AddMemberButton.TabIndex = 15;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            AddMemberButton.Click += AddMemberButton_Click;
            // 
            // AddMemberListBox
            // 
            AddMemberListBox.Controls.Add(CreateMemberButton);
            AddMemberListBox.Controls.Add(CellPhoneText);
            AddMemberListBox.Controls.Add(label2);
            AddMemberListBox.Controls.Add(EmailText);
            AddMemberListBox.Controls.Add(label1);
            AddMemberListBox.Controls.Add(LastNameText);
            AddMemberListBox.Controls.Add(LastNameLabel);
            AddMemberListBox.Controls.Add(textBox1);
            AddMemberListBox.Controls.Add(FirstNameLabel);
            AddMemberListBox.ForeColor = Color.FromArgb(55, 153, 255);
            AddMemberListBox.Location = new Point(40, 300);
            AddMemberListBox.Name = "AddMemberListBox";
            AddMemberListBox.Size = new Size(310, 251);
            AddMemberListBox.TabIndex = 16;
            AddMemberListBox.TabStop = false;
            AddMemberListBox.Text = "Add New Member";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 27);
            textBox1.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = Color.FromArgb(55, 153, 255);
            FirstNameLabel.Location = new Point(6, 23);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(130, 31);
            FirstNameLabel.TabIndex = 9;
            FirstNameLabel.Text = " First Name";
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(141, 67);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(146, 27);
            LastNameText.TabIndex = 18;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.ForeColor = Color.FromArgb(55, 153, 255);
            LastNameLabel.Location = new Point(13, 63);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(122, 31);
            LastNameLabel.TabIndex = 17;
            LastNameLabel.Text = "Last Name";
            // 
            // EmailText
            // 
            EmailText.Location = new Point(89, 108);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(198, 27);
            EmailText.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(55, 153, 255);
            label1.Location = new Point(13, 104);
            label1.Name = "label1";
            label1.Size = new Size(70, 31);
            label1.TabIndex = 19;
            label1.Text = "Email";
            // 
            // CellPhoneText
            // 
            CellPhoneText.Location = new Point(131, 152);
            CellPhoneText.Name = "CellPhoneText";
            CellPhoneText.Size = new Size(156, 27);
            CellPhoneText.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(55, 153, 255);
            label2.Location = new Point(13, 148);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 21;
            label2.Text = "Cellphone";
            // 
            // CreateMemberButton
            // 
            CreateMemberButton.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            CreateMemberButton.FlatStyle = FlatStyle.Flat;
            CreateMemberButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateMemberButton.ForeColor = Color.FromArgb(55, 153, 255);
            CreateMemberButton.Location = new Point(76, 196);
            CreateMemberButton.Name = "CreateMemberButton";
            CreateMemberButton.Size = new Size(128, 40);
            CreateMemberButton.TabIndex = 17;
            CreateMemberButton.Text = "Create Member";
            CreateMemberButton.UseVisualStyleBackColor = true;
            // 
            // TeamMemberListBox
            // 
            TeamMemberListBox.FormattingEnabled = true;
            TeamMemberListBox.ItemHeight = 20;
            TeamMemberListBox.Location = new Point(382, 107);
            TeamMemberListBox.Name = "TeamMemberListBox";
            TeamMemberListBox.Size = new Size(261, 444);
            TeamMemberListBox.TabIndex = 17;
            // 
            // DeleteMemberButton
            // 
            DeleteMemberButton.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            DeleteMemberButton.FlatStyle = FlatStyle.Flat;
            DeleteMemberButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteMemberButton.ForeColor = Color.FromArgb(55, 153, 255);
            DeleteMemberButton.Location = new Point(660, 300);
            DeleteMemberButton.Name = "DeleteMemberButton";
            DeleteMemberButton.Size = new Size(128, 40);
            DeleteMemberButton.TabIndex = 23;
            DeleteMemberButton.Text = "Delete Selected";
            DeleteMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            CreateTeamButton.FlatStyle = FlatStyle.Flat;
            CreateTeamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTeamButton.ForeColor = Color.FromArgb(55, 153, 255);
            CreateTeamButton.Location = new Point(300, 570);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.RightToLeft = RightToLeft.Yes;
            CreateTeamButton.Size = new Size(172, 51);
            CreateTeamButton.TabIndex = 24;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 633);
            Controls.Add(CreateTeamButton);
            Controls.Add(DeleteMemberButton);
            Controls.Add(TeamMemberListBox);
            Controls.Add(AddMemberListBox);
            Controls.Add(AddMemberButton);
            Controls.Add(comboBox1);
            Controls.Add(SelectTeamLabel);
            Controls.Add(TeamNameValue);
            Controls.Add(TeamNameLabel);
            Controls.Add(CreateTeamLabel);
            Name = "CreateTeamsForm";
            Text = "Create Team";
            AddMemberListBox.ResumeLayout(false);
            AddMemberListBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTeamLabel;
        private Label TeamNameLabel;
        private TextBox TeamNameValue;
        private Label SelectTeamLabel;
        private ComboBox comboBox1;
        private Button AddMemberButton;
        private GroupBox AddMemberListBox;
        private TextBox CellPhoneText;
        private Label label2;
        private TextBox EmailText;
        private Label label1;
        private TextBox LastNameText;
        private Label LastNameLabel;
        private TextBox textBox1;
        private Label FirstNameLabel;
        private Button CreateMemberButton;
        private ListBox TeamMemberListBox;
        private Button DeleteMemberButton;
        private Button CreateTeamButton;
    }
}