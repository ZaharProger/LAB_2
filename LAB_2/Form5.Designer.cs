
namespace LAB_2
{
    partial class Task3
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
            this.StringField = new System.Windows.Forms.TextBox();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(175, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данная программа вычисляет сумму выражения, записанного в строку";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(673, 76);
            this.label2.TabIndex = 1;
            this.label2.Text = "Строка должна содержать последовательность вида a1+/-a2+/-a3+/-...+/-an, где:\r\n1." +
    " n > 1\r\n2. ai - число, в записи которого от 1 до 19 цифр\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите строку:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StringField
            // 
            this.StringField.Location = new System.Drawing.Point(148, 296);
            this.StringField.Name = "StringField";
            this.StringField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StringField.Size = new System.Drawing.Size(617, 29);
            this.StringField.TabIndex = 3;
            // 
            // CalculationButton
            // 
            this.CalculationButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CalculationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CalculationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CalculationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CalculationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculationButton.Location = new System.Drawing.Point(325, 370);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(150, 50);
            this.CalculationButton.TabIndex = 4;
            this.CalculationButton.Text = "Вычислить";
            this.CalculationButton.UseVisualStyleBackColor = false;
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.StringField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание на строки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StringField;
        private System.Windows.Forms.Button CalculationButton;
    }
}