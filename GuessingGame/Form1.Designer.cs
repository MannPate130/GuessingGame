
namespace GuessingGame
{
    partial class guessingGame
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
            this.title = new System.Windows.Forms.Label();
            this.enterNumber = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(256, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(277, 40);
            this.title.TabIndex = 0;
            this.title.Text = "Guessing Game";
            // 
            // enterNumber
            // 
            this.enterNumber.AutoSize = true;
            this.enterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNumber.ForeColor = System.Drawing.Color.White;
            this.enterNumber.Location = new System.Drawing.Point(201, 141);
            this.enterNumber.Name = "enterNumber";
            this.enterNumber.Size = new System.Drawing.Size(393, 29);
            this.enterNumber.TabIndex = 1;
            this.enterNumber.Text = "Enter a Number Between 1 and 100";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(347, 215);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 26);
            this.textBox.TabIndex = 2;
            // 
            // guessButton
            // 
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.Location = new System.Drawing.Point(356, 265);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(91, 39);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(350, 362);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 32);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.enterNumber);
            this.Controls.Add(this.title);
            this.Name = "guessingGame";
            this.Text = "GuessingGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label enterNumber;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

