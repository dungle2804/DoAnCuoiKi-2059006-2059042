﻿
namespace SoanDeThi_ChamDiem
{
    partial class SoanDe
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
            this.lbQuestion = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoCauHoi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbUserAnswer = new System.Windows.Forms.ListBox();
            this.lbViewQuestion = new System.Windows.Forms.ListBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.FormattingEnabled = true;
            this.lbQuestion.Location = new System.Drawing.Point(-1, 331);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(670, 368);
            this.lbQuestion.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(212, 230);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 39);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Tạo đề thi";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(203, 101);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(100, 57);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Tạo ngẫu nhiên";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập vào số câu hỏi muốn tạo";
            // 
            // txtSoCauHoi
            // 
            this.txtSoCauHoi.Location = new System.Drawing.Point(203, 52);
            this.txtSoCauHoi.Name = "txtSoCauHoi";
            this.txtSoCauHoi.Size = new System.Drawing.Size(100, 20);
            this.txtSoCauHoi.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoCauHoi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRandom);
            this.groupBox1.Location = new System.Drawing.Point(22, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 269);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbViewQuestion);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Location = new System.Drawing.Point(365, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lbUserAnswer
            // 
            this.lbUserAnswer.FormattingEnabled = true;
            this.lbUserAnswer.Location = new System.Drawing.Point(908, 435);
            this.lbUserAnswer.Name = "lbUserAnswer";
            this.lbUserAnswer.Size = new System.Drawing.Size(280, 264);
            this.lbUserAnswer.TabIndex = 2;
            // 
            // lbViewQuestion
            // 
            this.lbViewQuestion.FormattingEnabled = true;
            this.lbViewQuestion.Location = new System.Drawing.Point(0, 5);
            this.lbViewQuestion.Name = "lbViewQuestion";
            this.lbViewQuestion.Size = new System.Drawing.Size(216, 264);
            this.lbViewQuestion.TabIndex = 2;
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(1194, 676);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGrade.TabIndex = 8;
            this.btnGrade.Text = "Chấm điểm";
            this.btnGrade.UseVisualStyleBackColor = true;
            // 
            // SoanDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 839);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.lbUserAnswer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbQuestion);
            this.Name = "SoanDe";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbQuestion;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoCauHoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbUserAnswer;
        private System.Windows.Forms.ListBox lbViewQuestion;
        private System.Windows.Forms.Button btnGrade;
    }
}
