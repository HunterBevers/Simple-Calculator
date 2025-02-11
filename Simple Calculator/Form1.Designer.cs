namespace Simple_Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            First_Result = new TextBox();
            Second_Result = new TextBox();
            Third_Result = new TextBox();
            Enter_Button = new Button();
            AC_Button = new Button();
            Exit_Button = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Subtract_Button = new Button();
            Multiply = new Button();
            Divide = new Button();
            Calculation_Count_Label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Magneto", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(551, 157);
            label1.Name = "label1";
            label1.Size = new Size(235, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Your First Number:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Magneto", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(128, 255, 255);
            label2.Location = new Point(530, 216);
            label2.Name = "label2";
            label2.Size = new Size(256, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Second Number:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Magneto", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(128, 255, 255);
            label3.Location = new Point(913, 187);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 0;
            label3.Text = "Equals =";
            // 
            // First_Result
            // 
            First_Result.BackColor = Color.White;
            First_Result.Location = new Point(792, 154);
            First_Result.Name = "First_Result";
            First_Result.Size = new Size(100, 23);
            First_Result.TabIndex = 2;
            First_Result.TextChanged += First_Result_TextChanged;
            // 
            // Second_Result
            // 
            Second_Result.BackColor = Color.White;
            Second_Result.Location = new Point(792, 213);
            Second_Result.Name = "Second_Result";
            Second_Result.Size = new Size(100, 23);
            Second_Result.TabIndex = 3;
            // 
            // Third_Result
            // 
            Third_Result.BackColor = Color.White;
            Third_Result.Location = new Point(1001, 187);
            Third_Result.Name = "Third_Result";
            Third_Result.Size = new Size(100, 23);
            Third_Result.TabIndex = 5;
            // 
            // Enter_Button
            // 
            Enter_Button.BackColor = Color.Lime;
            Enter_Button.Cursor = Cursors.Hand;
            Enter_Button.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Enter_Button.ForeColor = Color.Black;
            Enter_Button.Location = new Point(627, 264);
            Enter_Button.Name = "Enter_Button";
            Enter_Button.Size = new Size(141, 41);
            Enter_Button.TabIndex = 6;
            Enter_Button.Text = "Add";
            Enter_Button.UseVisualStyleBackColor = false;
            Enter_Button.Click += Enter_Button_Click;
            // 
            // AC_Button
            // 
            AC_Button.BackColor = Color.DeepSkyBlue;
            AC_Button.Cursor = Cursors.Hand;
            AC_Button.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            AC_Button.ForeColor = Color.Black;
            AC_Button.Location = new Point(774, 264);
            AC_Button.Name = "AC_Button";
            AC_Button.Size = new Size(65, 41);
            AC_Button.TabIndex = 8;
            AC_Button.Text = "AC";
            AC_Button.UseVisualStyleBackColor = false;
            AC_Button.Click += AC_Button_Click;
            // 
            // Exit_Button
            // 
            Exit_Button.BackColor = Color.Red;
            Exit_Button.Cursor = Cursors.Hand;
            Exit_Button.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Exit_Button.ForeColor = Color.Black;
            Exit_Button.Location = new Point(845, 264);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(141, 41);
            Exit_Button.TabIndex = 9;
            Exit_Button.Text = "Exit";
            Exit_Button.UseVisualStyleBackColor = false;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // Subtract_Button
            // 
            Subtract_Button.BackColor = Color.Lime;
            Subtract_Button.Cursor = Cursors.Hand;
            Subtract_Button.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Subtract_Button.ForeColor = Color.Black;
            Subtract_Button.Location = new Point(627, 311);
            Subtract_Button.Name = "Subtract_Button";
            Subtract_Button.Size = new Size(141, 41);
            Subtract_Button.TabIndex = 10;
            Subtract_Button.Text = "Subtract";
            Subtract_Button.UseVisualStyleBackColor = false;
            Subtract_Button.Click += Subtract_Button_Click;
            // 
            // Multiply
            // 
            Multiply.BackColor = Color.Lime;
            Multiply.Cursor = Cursors.Hand;
            Multiply.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Multiply.ForeColor = Color.Black;
            Multiply.Location = new Point(627, 358);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(141, 41);
            Multiply.TabIndex = 11;
            Multiply.Text = "Multiply";
            Multiply.UseVisualStyleBackColor = false;
            Multiply.Click += Multiply_Button_Click;
            // 
            // Divide
            // 
            Divide.BackColor = Color.Lime;
            Divide.Cursor = Cursors.Hand;
            Divide.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Divide.ForeColor = Color.Black;
            Divide.Location = new Point(627, 405);
            Divide.Name = "Divide";
            Divide.Size = new Size(141, 41);
            Divide.TabIndex = 12;
            Divide.Text = "Divide";
            Divide.UseVisualStyleBackColor = false;
            Divide.Click += Divide_Button_Click;
            // 
            // Calculation_Count_Label
            // 
            Calculation_Count_Label.AutoSize = true;
            Calculation_Count_Label.BackColor = Color.Magenta;
            Calculation_Count_Label.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            Calculation_Count_Label.ForeColor = Color.Black;
            Calculation_Count_Label.Location = new Point(654, 79);
            Calculation_Count_Label.Name = "Calculation_Count_Label";
            Calculation_Count_Label.Size = new Size(341, 26);
            Calculation_Count_Label.TabIndex = 13;
            Calculation_Count_Label.Text = "\"Calculations performed: 0\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(2994, 1181);
            Controls.Add(Calculation_Count_Label);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Subtract_Button);
            Controls.Add(Exit_Button);
            Controls.Add(AC_Button);
            Controls.Add(Enter_Button);
            Controls.Add(Third_Result);
            Controls.Add(Second_Result);
            Controls.Add(First_Result);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Simple Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox First_Result;
        private TextBox Second_Result;
        private TextBox Third_Result;
        private Button Add_Button;
        private Button AC_Button;
        private Button Exit_Button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Subtract_Button;
        private Button Enter_Button;
        private Button Multiply;
        private Button Divide;
        private Label Calculation_Count_Label;
    }
}
