namespace CarRacing
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            car1 = new PictureBox();
            car2 = new PictureBox();
            car3 = new PictureBox();
            finishLine = new Label();
            btnStart = new Button();
            lblResult = new Label();
            timerRace = new System.Windows.Forms.Timer(components);
            cmbCarSelection = new ComboBox();
            txtBetAmount = new TextBox();
            lblCredit = new Label();
            aa = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)car1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car3).BeginInit();
            SuspendLayout();
            // 
            // car1
            // 
            car1.Image = (Image)resources.GetObject("car1.Image");
            car1.Location = new Point(12, 72);
            car1.Name = "car1";
            car1.Size = new Size(160, 100);
            car1.SizeMode = PictureBoxSizeMode.StretchImage;
            car1.TabIndex = 0;
            car1.TabStop = false;
            // 
            // car2
            // 
            car2.Image = (Image)resources.GetObject("car2.Image");
            car2.Location = new Point(12, 234);
            car2.Name = "car2";
            car2.Size = new Size(160, 100);
            car2.SizeMode = PictureBoxSizeMode.StretchImage;
            car2.TabIndex = 1;
            car2.TabStop = false;
            // 
            // car3
            // 
            car3.Image = (Image)resources.GetObject("car3.Image");
            car3.Location = new Point(12, 398);
            car3.Name = "car3";
            car3.Size = new Size(160, 100);
            car3.SizeMode = PictureBoxSizeMode.StretchImage;
            car3.TabIndex = 2;
            car3.TabStop = false;
            // 
            // finishLine
            // 
            finishLine.BackColor = Color.White;
            finishLine.Location = new Point(914, 9);
            finishLine.Name = "finishLine";
            finishLine.Size = new Size(12, 579);
            finishLine.TabIndex = 3;
            finishLine.Text = " ";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(429, 538);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 50);
            btnStart.TabIndex = 4;
            btnStart.Text = "START RACE";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(644, 9);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(19, 30);
            lblResult.TabIndex = 5;
            lblResult.Text = " ";
            // 
            // timerRace
            // 
            timerRace.Interval = 50;
            // 
            // cmbCarSelection
            // 
            cmbCarSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarSelection.FormattingEnabled = true;
            cmbCarSelection.Items.AddRange(new object[] { "CAR 1", "CAR 2", "CAR 3" });
            cmbCarSelection.Location = new Point(560, 562);
            cmbCarSelection.Name = "cmbCarSelection";
            cmbCarSelection.Size = new Size(121, 23);
            cmbCarSelection.TabIndex = 6;
            // 
            // txtBetAmount
            // 
            txtBetAmount.Location = new Point(275, 562);
            txtBetAmount.Name = "txtBetAmount";
            txtBetAmount.Size = new Size(123, 23);
            txtBetAmount.TabIndex = 7;
            txtBetAmount.TextChanged += txtBetAmount_TextChanged;
            // 
            // lblCredit
            // 
            lblCredit.AutoSize = true;
            lblCredit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCredit.Location = new Point(156, 24);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(80, 20);
            lblCredit.TabIndex = 8;
            lblCredit.Text = "Credit: 100";
            // 
            // aa
            // 
            aa.BackColor = Color.White;
            aa.Location = new Point(569, 544);
            aa.Name = "aa";
            aa.Size = new Size(103, 15);
            aa.TabIndex = 9;
            aa.Text = "SELECT A CAR";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(285, 544);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 10;
            label1.Text = "ENTER YOUR BET";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(954, 597);
            Controls.Add(label1);
            Controls.Add(aa);
            Controls.Add(lblCredit);
            Controls.Add(txtBetAmount);
            Controls.Add(cmbCarSelection);
            Controls.Add(lblResult);
            Controls.Add(btnStart);
            Controls.Add(finishLine);
            Controls.Add(car3);
            Controls.Add(car2);
            Controls.Add(car1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)car1).EndInit();
            ((System.ComponentModel.ISupportInitialize)car2).EndInit();
            ((System.ComponentModel.ISupportInitialize)car3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox car1;
        private PictureBox car2;
        private PictureBox car3;
        private Label finishLine;
        private Button btnStart;
        private Label lblResult;
        private System.Windows.Forms.Timer timerRace;
        private ComboBox cmbCarSelection;
        private TextBox txtBetAmount;
        private Label lblCredit;
        private Label aa;
        private Label label1;
    }
}
