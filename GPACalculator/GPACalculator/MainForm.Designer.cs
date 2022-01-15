namespace GPACalculator
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNameMax = new System.Windows.Forms.TextBox();
            this.textNameMin = new System.Windows.Forms.TextBox();
            this.textScoreMax = new System.Windows.Forms.TextBox();
            this.textScoreMin = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textShowscore = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textGPA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(124, 85);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(363, 31);
            this.textName.TabIndex = 1;
            // 
            // textScore
            // 
            this.textScore.Location = new System.Drawing.Point(508, 85);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(167, 31);
            this.textScore.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "GPACalculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Min";
            // 
            // textNameMax
            // 
            this.textNameMax.Location = new System.Drawing.Point(124, 196);
            this.textNameMax.Name = "textNameMax";
            this.textNameMax.Size = new System.Drawing.Size(363, 31);
            this.textNameMax.TabIndex = 7;
            // 
            // textNameMin
            // 
            this.textNameMin.Location = new System.Drawing.Point(124, 249);
            this.textNameMin.Name = "textNameMin";
            this.textNameMin.Size = new System.Drawing.Size(363, 31);
            this.textNameMin.TabIndex = 8;
            // 
            // textScoreMax
            // 
            this.textScoreMax.Location = new System.Drawing.Point(508, 196);
            this.textScoreMax.Name = "textScoreMax";
            this.textScoreMax.Size = new System.Drawing.Size(167, 31);
            this.textScoreMax.TabIndex = 9;
            // 
            // textScoreMin
            // 
            this.textScoreMin.Location = new System.Drawing.Point(508, 249);
            this.textScoreMin.Name = "textScoreMin";
            this.textScoreMin.Size = new System.Drawing.Size(167, 31);
            this.textScoreMin.TabIndex = 10;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(695, 212);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(125, 30);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textShowscore
            // 
            this.textShowscore.Location = new System.Drawing.Point(44, 317);
            this.textShowscore.Multiline = true;
            this.textShowscore.Name = "textShowscore";
            this.textShowscore.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textShowscore.Size = new System.Drawing.Size(776, 243);
            this.textShowscore.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(695, 84);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 32);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "GPA";
            // 
            // textGPA
            // 
            this.textGPA.Location = new System.Drawing.Point(508, 141);
            this.textGPA.Name = "textGPA";
            this.textGPA.Size = new System.Drawing.Size(167, 31);
            this.textGPA.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 581);
            this.Controls.Add(this.textGPA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textShowscore);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textScoreMin);
            this.Controls.Add(this.textScoreMax);
            this.Controls.Add(this.textNameMin);
            this.Controls.Add(this.textNameMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.textName);
            this.Name = "MainForm";
            this.Text = "GPACalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textName;
        private TextBox textScore;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textNameMax;
        private TextBox textNameMin;
        private TextBox textScoreMax;
        private TextBox textScoreMin;
        private Button buttonClear;
        private TextBox textShowscore;
        private Button buttonAdd;
        private Label label4;
        private TextBox textGPA;
    }
}