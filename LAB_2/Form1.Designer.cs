﻿
namespace LAB_2
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.Task2Button = new System.Windows.Forms.Button();
            this.Task3Button = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.Task1Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(250, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для выбора задания нажмите на соответствующую кнопку";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Task2Button
            // 
            this.Task2Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Task2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Task2Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Task2Button.FlatAppearance.BorderSize = 2;
            this.Task2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Task2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Task2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task2Button.Location = new System.Drawing.Point(387, 200);
            this.Task2Button.Name = "Task2Button";
            this.Task2Button.Size = new System.Drawing.Size(182, 61);
            this.Task2Button.TabIndex = 2;
            this.Task2Button.Text = "Задание на for";
            this.Task2Button.UseVisualStyleBackColor = false;
            this.Task2Button.Click += new System.EventHandler(this.Task2Button_Click);
            this.Task2Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Task2Button_KeyDown);
            // 
            // Task3Button
            // 
            this.Task3Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Task3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Task3Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Task3Button.FlatAppearance.BorderSize = 2;
            this.Task3Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Task3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Task3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task3Button.Location = new System.Drawing.Point(651, 200);
            this.Task3Button.Name = "Task3Button";
            this.Task3Button.Size = new System.Drawing.Size(218, 61);
            this.Task3Button.TabIndex = 3;
            this.Task3Button.Text = "Задание на строки";
            this.Task3Button.UseVisualStyleBackColor = false;
            this.Task3Button.Click += new System.EventHandler(this.Task3Button_Click);
            this.Task3Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Task3Button_KeyDown);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InfoButton.FlatAppearance.BorderSize = 2;
            this.InfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Location = new System.Drawing.Point(772, 399);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(186, 50);
            this.InfoButton.TabIndex = 4;
            this.InfoButton.Text = "О программе";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            this.InfoButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InfoButton_KeyDown);
            // 
            // Task1Button
            // 
            this.Task1Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Task1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Task1Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Task1Button.FlatAppearance.BorderSize = 2;
            this.Task1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Task1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Task1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Task1Button.Location = new System.Drawing.Point(119, 200);
            this.Task1Button.Name = "Task1Button";
            this.Task1Button.Size = new System.Drawing.Size(177, 61);
            this.Task1Button.TabIndex = 5;
            this.Task1Button.Text = "Задание на if";
            this.Task1Button.UseVisualStyleBackColor = false;
            this.Task1Button.Click += new System.EventHandler(this.Task1Button_Click);
            this.Task1Button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Task1Button_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(257, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 112);
            this.label2.TabIndex = 6;
            this.label2.Text = "Для ознакомления с управлением программой перейдите в раздел О программе";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Task1Button);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.Task3Button);
            this.Controls.Add(this.Task2Button);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainMenu";
            this.Text = "Лабораторная работа 2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Task2Button;
        private System.Windows.Forms.Button Task3Button;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button Task1Button;
        private System.Windows.Forms.Label label2;
    }
}

