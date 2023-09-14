namespace MarcusHighYieldSavingAccountCalculator
{
    partial class HighYieldSavingCalculatorMainForm
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
            this.descrpitionLabel = new System.Windows.Forms.Label();
            this.apyDescriptionLabel = new System.Windows.Forms.Label();
            this.referralAmountComboBox = new System.Windows.Forms.ComboBox();
            this.goalAmountTextBox = new System.Windows.Forms.TextBox();
            this.goalAmountLabel = new System.Windows.Forms.Label();
            this.referralCheckBox = new System.Windows.Forms.CheckBox();
            this.initialAmountTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.referralAmountLabel = new System.Windows.Forms.Label();
            this.referralLabel = new System.Windows.Forms.Label();
            this.initialAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descrpitionLabel
            // 
            this.descrpitionLabel.Location = new System.Drawing.Point(31, 12);
            this.descrpitionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.descrpitionLabel.Name = "descrpitionLabel";
            this.descrpitionLabel.Size = new System.Drawing.Size(718, 58);
            this.descrpitionLabel.TabIndex = 2;
            this.descrpitionLabel.Text = "This application will calculate how long it would take for your High Yields Onlin" +
    "e Savings Account to reach your set goal ";
            this.descrpitionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // apyDescriptionLabel
            // 
            this.apyDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apyDescriptionLabel.Location = new System.Drawing.Point(52, 66);
            this.apyDescriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.apyDescriptionLabel.Name = "apyDescriptionLabel";
            this.apyDescriptionLabel.Size = new System.Drawing.Size(666, 54);
            this.apyDescriptionLabel.TabIndex = 14;
            this.apyDescriptionLabel.Text = "The APY is set at 4.3% by default, but for every referal you have your APY is inc" +
    "reased to 5.3% for 3 months";
            this.apyDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // referralAmountComboBox
            // 
            this.referralAmountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.referralAmountComboBox.FormattingEnabled = true;
            this.referralAmountComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.referralAmountComboBox.Location = new System.Drawing.Point(568, 169);
            this.referralAmountComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.referralAmountComboBox.Name = "referralAmountComboBox";
            this.referralAmountComboBox.Size = new System.Drawing.Size(64, 33);
            this.referralAmountComboBox.TabIndex = 23;
            this.referralAmountComboBox.Visible = false;
            // 
            // goalAmountTextBox
            // 
            this.goalAmountTextBox.Location = new System.Drawing.Point(328, 213);
            this.goalAmountTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.goalAmountTextBox.Name = "goalAmountTextBox";
            this.goalAmountTextBox.Size = new System.Drawing.Size(302, 31);
            this.goalAmountTextBox.TabIndex = 22;
            this.goalAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goalAmountTextBox_KeyPress);
            // 
            // goalAmountLabel
            // 
            this.goalAmountLabel.AutoSize = true;
            this.goalAmountLabel.Location = new System.Drawing.Point(178, 221);
            this.goalAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.goalAmountLabel.Name = "goalAmountLabel";
            this.goalAmountLabel.Size = new System.Drawing.Size(142, 25);
            this.goalAmountLabel.TabIndex = 21;
            this.goalAmountLabel.Text = "Goal Amount:";
            // 
            // referralCheckBox
            // 
            this.referralCheckBox.AutoSize = true;
            this.referralCheckBox.Location = new System.Drawing.Point(328, 178);
            this.referralCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.referralCheckBox.Name = "referralCheckBox";
            this.referralCheckBox.Size = new System.Drawing.Size(28, 27);
            this.referralCheckBox.TabIndex = 20;
            this.referralCheckBox.UseVisualStyleBackColor = true;
            this.referralCheckBox.CheckedChanged += new System.EventHandler(this.referralCheckBox_CheckedChanged);
            // 
            // initialAmountTextBox
            // 
            this.initialAmountTextBox.Location = new System.Drawing.Point(328, 126);
            this.initialAmountTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.initialAmountTextBox.Name = "initialAmountTextBox";
            this.initialAmountTextBox.Size = new System.Drawing.Size(302, 31);
            this.initialAmountTextBox.TabIndex = 19;
            this.initialAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.initialAmountTextBox_KeyPress);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(156, 265);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(6);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(478, 44);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // referralAmountLabel
            // 
            this.referralAmountLabel.AutoSize = true;
            this.referralAmountLabel.Location = new System.Drawing.Point(358, 176);
            this.referralAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.referralAmountLabel.Name = "referralAmountLabel";
            this.referralAmountLabel.Size = new System.Drawing.Size(215, 25);
            this.referralAmountLabel.TabIndex = 17;
            this.referralAmountLabel.Text = "How many referrals?:";
            this.referralAmountLabel.Visible = false;
            // 
            // referralLabel
            // 
            this.referralLabel.AutoSize = true;
            this.referralLabel.Location = new System.Drawing.Point(214, 176);
            this.referralLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.referralLabel.Name = "referralLabel";
            this.referralLabel.Size = new System.Drawing.Size(106, 25);
            this.referralLabel.TabIndex = 16;
            this.referralLabel.Text = "Referral?:";
            // 
            // initialAmountLabel
            // 
            this.initialAmountLabel.AutoSize = true;
            this.initialAmountLabel.Location = new System.Drawing.Point(173, 130);
            this.initialAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.initialAmountLabel.Name = "initialAmountLabel";
            this.initialAmountLabel.Size = new System.Drawing.Size(147, 25);
            this.initialAmountLabel.TabIndex = 15;
            this.initialAmountLabel.Text = "Initial Amount:";
            // 
            // HighYieldSavingCalculatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 334);
            this.Controls.Add(this.referralAmountComboBox);
            this.Controls.Add(this.goalAmountTextBox);
            this.Controls.Add(this.goalAmountLabel);
            this.Controls.Add(this.referralCheckBox);
            this.Controls.Add(this.initialAmountTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.referralAmountLabel);
            this.Controls.Add(this.referralLabel);
            this.Controls.Add(this.initialAmountLabel);
            this.Controls.Add(this.apyDescriptionLabel);
            this.Controls.Add(this.descrpitionLabel);
            this.Name = "HighYieldSavingCalculatorMainForm";
            this.Text = "Marcus High Yield Saving Account Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descrpitionLabel;
        private System.Windows.Forms.Label apyDescriptionLabel;
        private System.Windows.Forms.ComboBox referralAmountComboBox;
        private System.Windows.Forms.TextBox goalAmountTextBox;
        private System.Windows.Forms.Label goalAmountLabel;
        private System.Windows.Forms.CheckBox referralCheckBox;
        private System.Windows.Forms.TextBox initialAmountTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label referralAmountLabel;
        private System.Windows.Forms.Label referralLabel;
        private System.Windows.Forms.Label initialAmountLabel;
    }
}

