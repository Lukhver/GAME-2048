
namespace GAME2048
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.rtbWinsNumbers = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rtbInvizWinNumber = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbWinsNumbers
            // 
            this.rtbWinsNumbers.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbWinsNumbers.Location = new System.Drawing.Point(41, 29);
            this.rtbWinsNumbers.Name = "rtbWinsNumbers";
            this.rtbWinsNumbers.Size = new System.Drawing.Size(328, 66);
            this.rtbWinsNumbers.TabIndex = 0;
            this.rtbWinsNumbers.Text = "";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(41, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Повернутись до меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.No;
            this.button2.Location = new System.Drawing.Point(211, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обнулити перемоги";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtbInvizWinNumber
            // 
            this.rtbInvizWinNumber.Location = new System.Drawing.Point(383, 12);
            this.rtbInvizWinNumber.Name = "rtbInvizWinNumber";
            this.rtbInvizWinNumber.ReadOnly = true;
            this.rtbInvizWinNumber.Size = new System.Drawing.Size(22, 19);
            this.rtbInvizWinNumber.TabIndex = 3;
            this.rtbInvizWinNumber.Text = "0";
            this.rtbInvizWinNumber.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GAME2048.Properties.Resources.fongame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(417, 146);
            this.Controls.Add(this.rtbInvizWinNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbWinsNumbers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Number of wins!";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbWinsNumbers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtbInvizWinNumber;
    }
}