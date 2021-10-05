
namespace LAB_2
{
    partial class Task1
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
            this.label4 = new System.Windows.Forms.Label();
            this.ArrivalHoursField = new System.Windows.Forms.TextBox();
            this.ArrivalMinutesField = new System.Windows.Forms.TextBox();
            this.DepartureHoursField = new System.Windows.Forms.TextBox();
            this.DepartureMinutesField = new System.Windows.Forms.TextBox();
            this.PassengerHoursField = new System.Windows.Forms.TextBox();
            this.PassengerMinutesField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 143);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данная программа определяет, стоит ли поезд на платформе.\r\n\r\nВ поля слева от двое" +
    "точия введите часы (от 0 до 24)\r\nВ поля справа от двоеточия введите минуты (от 0" +
    " до 59)\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(390, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(390, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(390, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArrivalHoursField
            // 
            this.ArrivalHoursField.BackColor = System.Drawing.SystemColors.Window;
            this.ArrivalHoursField.Location = new System.Drawing.Point(252, 189);
            this.ArrivalHoursField.Name = "ArrivalHoursField";
            this.ArrivalHoursField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ArrivalHoursField.Size = new System.Drawing.Size(131, 35);
            this.ArrivalHoursField.TabIndex = 4;
            this.ArrivalHoursField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArrivalHoursField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArrivalHoursField_KeyDown);
            // 
            // ArrivalMinutesField
            // 
            this.ArrivalMinutesField.Location = new System.Drawing.Point(415, 189);
            this.ArrivalMinutesField.Name = "ArrivalMinutesField";
            this.ArrivalMinutesField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ArrivalMinutesField.Size = new System.Drawing.Size(131, 35);
            this.ArrivalMinutesField.TabIndex = 5;
            this.ArrivalMinutesField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArrivalMinutesField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArrivalMinutesField_KeyDown);
            // 
            // DepartureHoursField
            // 
            this.DepartureHoursField.Location = new System.Drawing.Point(252, 269);
            this.DepartureHoursField.Name = "DepartureHoursField";
            this.DepartureHoursField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DepartureHoursField.Size = new System.Drawing.Size(131, 35);
            this.DepartureHoursField.TabIndex = 6;
            this.DepartureHoursField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepartureHoursField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepartureHoursField_KeyDown);
            // 
            // DepartureMinutesField
            // 
            this.DepartureMinutesField.Location = new System.Drawing.Point(415, 269);
            this.DepartureMinutesField.Name = "DepartureMinutesField";
            this.DepartureMinutesField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DepartureMinutesField.Size = new System.Drawing.Size(131, 35);
            this.DepartureMinutesField.TabIndex = 7;
            this.DepartureMinutesField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DepartureMinutesField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepartureMinutesField_KeyDown);
            // 
            // PassengerHoursField
            // 
            this.PassengerHoursField.Location = new System.Drawing.Point(252, 349);
            this.PassengerHoursField.Name = "PassengerHoursField";
            this.PassengerHoursField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PassengerHoursField.Size = new System.Drawing.Size(131, 35);
            this.PassengerHoursField.TabIndex = 8;
            this.PassengerHoursField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassengerHoursField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassengerHoursField_KeyDown);
            // 
            // PassengerMinutesField
            // 
            this.PassengerMinutesField.Location = new System.Drawing.Point(415, 349);
            this.PassengerMinutesField.Name = "PassengerMinutesField";
            this.PassengerMinutesField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PassengerMinutesField.Size = new System.Drawing.Size(131, 35);
            this.PassengerMinutesField.TabIndex = 9;
            this.PassengerMinutesField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassengerMinutesField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassengerMinutesField_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(284, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Прибытие поезда";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(284, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Отправление поезда";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(269, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Прибытие пассажира";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculationButton
            // 
            this.CalculationButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CalculationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CalculationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CalculationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CalculationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculationButton.Location = new System.Drawing.Point(325, 410);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(150, 50);
            this.CalculationButton.TabIndex = 13;
            this.CalculationButton.Text = "Определить";
            this.CalculationButton.UseVisualStyleBackColor = false;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            this.CalculationButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculationButton_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(195, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "часы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(195, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "часы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(195, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "часы";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(552, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "минуты";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(552, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 22);
            this.label12.TabIndex = 18;
            this.label12.Text = "минуты";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(552, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 22);
            this.label13.TabIndex = 19;
            this.label13.Text = "минуты";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(641, 389);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(131, 79);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Очистить ввод";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClearButton_KeyDown);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 480);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassengerMinutesField);
            this.Controls.Add(this.PassengerHoursField);
            this.Controls.Add(this.DepartureMinutesField);
            this.Controls.Add(this.DepartureHoursField);
            this.Controls.Add(this.ArrivalMinutesField);
            this.Controls.Add(this.ArrivalHoursField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание на if";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Task1_KeyDown);
            this.FormClosed += Task1_FormClosed;
            this.FormClosing += Task1_FormClosing;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ArrivalHoursField;
        private System.Windows.Forms.TextBox ArrivalMinutesField;
        private System.Windows.Forms.TextBox DepartureHoursField;
        private System.Windows.Forms.TextBox DepartureMinutesField;
        private System.Windows.Forms.TextBox PassengerHoursField;
        private System.Windows.Forms.TextBox PassengerMinutesField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ClearButton;
    }
}