
namespace paint
{
    partial class Form1
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
            this.buttonRound1 = new customControl.ButtonRound();
            this.SuspendLayout();
            // 
            // buttonRound1
            // 
            this.buttonRound1.BorderColor = System.Drawing.Color.Silver;
            this.buttonRound1.ButtonColor = System.Drawing.Color.Red;
            this.buttonRound1.Location = new System.Drawing.Point(171, 92);
            this.buttonRound1.Name = "buttonRound1";
            this.buttonRound1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.buttonRound1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.buttonRound1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonRound1.Size = new System.Drawing.Size(471, 183);
            this.buttonRound1.TabIndex = 0;
            this.buttonRound1.Text = "buttonRound1";
            this.buttonRound1.TextColor = System.Drawing.Color.White;
            this.buttonRound1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRound1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private customControl.ButtonRound buttonRound1;
    }
}

