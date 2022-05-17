namespace Simple_Slots
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_deposit = new System.Windows.Forms.GroupBox();
            this.despositNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.groupBox_Money = new System.Windows.Forms.GroupBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameTextLabel = new System.Windows.Forms.Label();
            this.slotView = new System.Windows.Forms.ListBox();
            this.spinSlotsButton = new System.Windows.Forms.Button();
            this.wagerGroupBox = new System.Windows.Forms.GroupBox();
            this.wagerNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.spinTextLabel = new System.Windows.Forms.Label();
            this.groupBox_deposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.despositNumberBox)).BeginInit();
            this.groupBox_Money.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.wagerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wagerNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_deposit
            // 
            this.groupBox_deposit.Controls.Add(this.despositNumberBox);
            this.groupBox_deposit.Controls.Add(this.label1);
            this.groupBox_deposit.Controls.Add(this.depositButton);
            this.groupBox_deposit.Location = new System.Drawing.Point(156, 163);
            this.groupBox_deposit.Name = "groupBox_deposit";
            this.groupBox_deposit.Size = new System.Drawing.Size(143, 86);
            this.groupBox_deposit.TabIndex = 0;
            this.groupBox_deposit.TabStop = false;
            this.groupBox_deposit.Text = "Deposit";
            // 
            // despositNumberBox
            // 
            this.despositNumberBox.Location = new System.Drawing.Point(22, 24);
            this.despositNumberBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.despositNumberBox.Name = "despositNumberBox";
            this.despositNumberBox.Size = new System.Drawing.Size(115, 23);
            this.despositNumberBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "£";
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(62, 53);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // groupBox_Money
            // 
            this.groupBox_Money.Controls.Add(this.moneyLabel);
            this.groupBox_Money.Location = new System.Drawing.Point(156, 108);
            this.groupBox_Money.Name = "groupBox_Money";
            this.groupBox_Money.Size = new System.Drawing.Size(143, 49);
            this.groupBox_Money.TabIndex = 1;
            this.groupBox_Money.TabStop = false;
            this.groupBox_Money.Text = "Money";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(6, 26);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(19, 15);
            this.moneyLabel.TabIndex = 0;
            this.moneyLabel.Text = "£0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 58);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gameTextLabel
            // 
            this.gameTextLabel.AutoSize = true;
            this.gameTextLabel.Location = new System.Drawing.Point(12, 76);
            this.gameTextLabel.Name = "gameTextLabel";
            this.gameTextLabel.Size = new System.Drawing.Size(224, 15);
            this.gameTextLabel.TabIndex = 3;
            this.gameTextLabel.Text = "Please make a desposit to start the game!";
            // 
            // slotView
            // 
            this.slotView.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slotView.FormattingEnabled = true;
            this.slotView.ItemHeight = 32;
            this.slotView.Location = new System.Drawing.Point(12, 108);
            this.slotView.Name = "slotView";
            this.slotView.Size = new System.Drawing.Size(134, 132);
            this.slotView.TabIndex = 4;
            // 
            // spinSlotsButton
            // 
            this.spinSlotsButton.Enabled = false;
            this.spinSlotsButton.Location = new System.Drawing.Point(12, 255);
            this.spinSlotsButton.Name = "spinSlotsButton";
            this.spinSlotsButton.Size = new System.Drawing.Size(134, 57);
            this.spinSlotsButton.TabIndex = 5;
            this.spinSlotsButton.Text = "SPIN!";
            this.spinSlotsButton.UseVisualStyleBackColor = true;
            this.spinSlotsButton.Click += new System.EventHandler(this.spinSlotsButton_Click);
            // 
            // wagerGroupBox
            // 
            this.wagerGroupBox.Controls.Add(this.wagerNumberBox);
            this.wagerGroupBox.Controls.Add(this.label3);
            this.wagerGroupBox.Location = new System.Drawing.Point(156, 255);
            this.wagerGroupBox.Name = "wagerGroupBox";
            this.wagerGroupBox.Size = new System.Drawing.Size(143, 57);
            this.wagerGroupBox.TabIndex = 6;
            this.wagerGroupBox.TabStop = false;
            this.wagerGroupBox.Text = "Wager";
            // 
            // wagerNumberBox
            // 
            this.wagerNumberBox.Location = new System.Drawing.Point(20, 22);
            this.wagerNumberBox.Name = "wagerNumberBox";
            this.wagerNumberBox.Size = new System.Drawing.Size(108, 23);
            this.wagerNumberBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "£";
            // 
            // spinTextLabel
            // 
            this.spinTextLabel.AutoSize = true;
            this.spinTextLabel.Location = new System.Drawing.Point(12, 318);
            this.spinTextLabel.Name = "spinTextLabel";
            this.spinTextLabel.Size = new System.Drawing.Size(77, 15);
            this.spinTextLabel.TabIndex = 7;
            this.spinTextLabel.Text = "Try your luck!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 344);
            this.Controls.Add(this.spinTextLabel);
            this.Controls.Add(this.wagerGroupBox);
            this.Controls.Add(this.spinSlotsButton);
            this.Controls.Add(this.slotView);
            this.Controls.Add(this.gameTextLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_Money);
            this.Controls.Add(this.groupBox_deposit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quick Slots";
            this.groupBox_deposit.ResumeLayout(false);
            this.groupBox_deposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.despositNumberBox)).EndInit();
            this.groupBox_Money.ResumeLayout(false);
            this.groupBox_Money.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.wagerGroupBox.ResumeLayout(false);
            this.wagerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wagerNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox_deposit;
        private Label label1;
        private Button depositButton;
        private GroupBox groupBox_Money;
        private Label moneyLabel;
        private PictureBox pictureBox1;
        private NumericUpDown despositNumberBox;
        private Label gameTextLabel;
        private ListBox slotView;
        private Button spinSlotsButton;
        private GroupBox wagerGroupBox;
        private NumericUpDown wagerNumberBox;
        private Label label3;
        private Label spinTextLabel;
    }
}