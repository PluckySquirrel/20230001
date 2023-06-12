namespace TrackerUI
{
    partial class CreatePrizeForm
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
            CreatePrizeLabel = new Label();
            PlaceTextValue = new TextBox();
            PlaceNumberLabel = new Label();
            PlaceNameValue = new TextBox();
            PlaceNameLabel = new Label();
            PrizeAmountValue = new TextBox();
            PrizeAmountLabel = new Label();
            PrizePercentageValue = new TextBox();
            PrizePercentageLabel = new Label();
            orLabel = new Label();
            CreatePrizeButton = new Button();
            SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            CreatePrizeLabel.AutoSize = true;
            CreatePrizeLabel.Font = new Font("Segoe UI Semilight", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            CreatePrizeLabel.ForeColor = Color.FromArgb(55, 153, 255);
            CreatePrizeLabel.Location = new Point(35, 26);
            CreatePrizeLabel.Name = "CreatePrizeLabel";
            CreatePrizeLabel.Size = new Size(214, 50);
            CreatePrizeLabel.TabIndex = 8;
            CreatePrizeLabel.Text = "Create Prize";
            // 
            // PlaceTextValue
            // 
            PlaceTextValue.Location = new Point(233, 99);
            PlaceTextValue.Name = "PlaceTextValue";
            PlaceTextValue.Size = new Size(145, 27);
            PlaceTextValue.TabIndex = 12;
            PlaceTextValue.TextChanged += textBox1_TextChanged;
            // 
            // PlaceNumberLabel
            // 
            PlaceNumberLabel.AutoSize = true;
            PlaceNumberLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceNumberLabel.ForeColor = Color.FromArgb(55, 153, 255);
            PlaceNumberLabel.Location = new Point(39, 95);
            PlaceNumberLabel.Name = "PlaceNumberLabel";
            PlaceNumberLabel.Size = new Size(158, 31);
            PlaceNumberLabel.TabIndex = 11;
            PlaceNumberLabel.Text = "Place Number";
            PlaceNumberLabel.Click += FirstNameLabel_Click;
            // 
            // PlaceNameValue
            // 
            PlaceNameValue.Location = new Point(233, 154);
            PlaceNameValue.Name = "PlaceNameValue";
            PlaceNameValue.Size = new Size(145, 27);
            PlaceNameValue.TabIndex = 14;
            // 
            // PlaceNameLabel
            // 
            PlaceNameLabel.AutoSize = true;
            PlaceNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceNameLabel.ForeColor = Color.FromArgb(55, 153, 255);
            PlaceNameLabel.Location = new Point(39, 150);
            PlaceNameLabel.Name = "PlaceNameLabel";
            PlaceNameLabel.Size = new Size(135, 31);
            PlaceNameLabel.TabIndex = 13;
            PlaceNameLabel.Text = "Place Name";
            // 
            // PrizeAmountValue
            // 
            PrizeAmountValue.Location = new Point(233, 209);
            PrizeAmountValue.Name = "PrizeAmountValue";
            PrizeAmountValue.Size = new Size(145, 27);
            PrizeAmountValue.TabIndex = 16;
            // 
            // PrizeAmountLabel
            // 
            PrizeAmountLabel.AutoSize = true;
            PrizeAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PrizeAmountLabel.ForeColor = Color.FromArgb(55, 153, 255);
            PrizeAmountLabel.Location = new Point(39, 205);
            PrizeAmountLabel.Name = "PrizeAmountLabel";
            PrizeAmountLabel.Size = new Size(156, 31);
            PrizeAmountLabel.TabIndex = 15;
            PrizeAmountLabel.Text = "Place Amount";
            // 
            // PrizePercentageValue
            // 
            PrizePercentageValue.Location = new Point(233, 322);
            PrizePercentageValue.Name = "PrizePercentageValue";
            PrizePercentageValue.Size = new Size(145, 27);
            PrizePercentageValue.TabIndex = 18;
            // 
            // PrizePercentageLabel
            // 
            PrizePercentageLabel.AutoSize = true;
            PrizePercentageLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PrizePercentageLabel.ForeColor = Color.FromArgb(55, 153, 255);
            PrizePercentageLabel.Location = new Point(39, 318);
            PrizePercentageLabel.Name = "PrizePercentageLabel";
            PrizePercentageLabel.Size = new Size(188, 31);
            PrizePercentageLabel.TabIndex = 17;
            PrizePercentageLabel.Text = "Place Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.FromArgb(55, 153, 255);
            orLabel.Location = new Point(196, 270);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(53, 31);
            orLabel.TabIndex = 19;
            orLabel.Text = "-or-";
            orLabel.Click += label1_Click;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.FromArgb(55, 153, 255);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreatePrizeButton.ForeColor = Color.FromArgb(55, 153, 255);
            CreatePrizeButton.Location = new Point(124, 374);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.RightToLeft = RightToLeft.Yes;
            CreatePrizeButton.Size = new Size(172, 51);
            CreatePrizeButton.TabIndex = 25;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 450);
            Controls.Add(CreatePrizeButton);
            Controls.Add(orLabel);
            Controls.Add(PrizePercentageValue);
            Controls.Add(PrizePercentageLabel);
            Controls.Add(PrizeAmountValue);
            Controls.Add(PrizeAmountLabel);
            Controls.Add(PlaceNameValue);
            Controls.Add(PlaceNameLabel);
            Controls.Add(PlaceTextValue);
            Controls.Add(PlaceNumberLabel);
            Controls.Add(CreatePrizeLabel);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePrizeLabel;
        private TextBox PlaceTextValue;
        private Label PlaceNumberLabel;
        private TextBox PlaceNameValue;
        private Label PlaceNameLabel;
        private TextBox PrizeAmountValue;
        private Label PrizeAmountLabel;
        private TextBox PrizePercentageValue;
        private Label PrizePercentageLabel;
        private Label orLabel;
        private Button CreatePrizeButton;
    }
}