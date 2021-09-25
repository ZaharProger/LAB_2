
namespace LAB_2
{
    partial class mainMenu
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
            this.task2Button = new System.Windows.Forms.Button();
            this.task3Button = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.task1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(250, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для выбора задания нажмите на соответствующую кнопку";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // task2Button
            // 
            this.task2Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.task2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.task2Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.task2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.task2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.task2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task2Button.Location = new System.Drawing.Point(419, 200);
            this.task2Button.Name = "task2Button";
            this.task2Button.Size = new System.Drawing.Size(150, 61);
            this.task2Button.TabIndex = 2;
            this.task2Button.Text = "Задание на for";
            this.task2Button.UseVisualStyleBackColor = false;
            // 
            // task3Button
            // 
            this.task3Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.task3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.task3Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.task3Button.FlatAppearance.BorderSize = 2;
            this.task3Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.task3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.task3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task3Button.Location = new System.Drawing.Point(719, 200);
            this.task3Button.Name = "task3Button";
            this.task3Button.Size = new System.Drawing.Size(150, 61);
            this.task3Button.TabIndex = 3;
            this.task3Button.Text = "Задание на строки";
            this.task3Button.UseVisualStyleBackColor = false;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.infoButton.FlatAppearance.BorderSize = 2;
            this.infoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Location = new System.Drawing.Point(808, 399);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(150, 50);
            this.infoButton.TabIndex = 4;
            this.infoButton.Text = "О программе";
            this.infoButton.UseVisualStyleBackColor = false;
            // 
            // task1Button
            // 
            this.task1Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.task1Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.task1Button.FlatAppearance.BorderSize = 2;
            this.task1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.task1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.task1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task1Button.Location = new System.Drawing.Point(119, 200);
            this.task1Button.Name = "task1Button";
            this.task1Button.Size = new System.Drawing.Size(150, 61);
            this.task1Button.TabIndex = 5;
            this.task1Button.Text = "Задание на if";
            this.task1Button.UseVisualStyleBackColor = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.task1Button);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.task3Button);
            this.Controls.Add(this.task2Button);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "mainMenu";
            this.Text = "Лабораторная работа 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button task2Button;
        private System.Windows.Forms.Button task3Button;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button task1Button;
    }
}

