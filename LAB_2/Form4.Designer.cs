﻿
namespace LAB_2
{
    partial class Task2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupSizeField = new System.Windows.Forms.TextBox();
            this.NumsField = new System.Windows.Forms.TextBox();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данная программа определяет первое вхождение идущих подряд одинаковых чисел";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(2, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Размер группы идущих подряд чисел:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите числа через пробел:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupSizeField
            // 
            this.GroupSizeField.Location = new System.Drawing.Point(327, 212);
            this.GroupSizeField.Name = "GroupSizeField";
            this.GroupSizeField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.GroupSizeField.Size = new System.Drawing.Size(383, 29);
            this.GroupSizeField.TabIndex = 3;
            // 
            // NumsField
            // 
            this.NumsField.Location = new System.Drawing.Point(254, 292);
            this.NumsField.Name = "NumsField";
            this.NumsField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NumsField.Size = new System.Drawing.Size(456, 29);
            this.NumsField.TabIndex = 4;
            // 
            // CalculationButton
            // 
            this.CalculationButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CalculationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CalculationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CalculationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CalculationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculationButton.Location = new System.Drawing.Point(325, 380);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(150, 50);
            this.CalculationButton.TabIndex = 5;
            this.CalculationButton.Text = "Определить";
            this.CalculationButton.UseVisualStyleBackColor = false;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.NumsField);
            this.Controls.Add(this.GroupSizeField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Task2";
            this.Text = "Задание на for";
            this.FormClosed += Task2_FormClosed;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GroupSizeField;
        private System.Windows.Forms.TextBox NumsField;
        private System.Windows.Forms.Button CalculationButton;
    }
}