
namespace GAME2048
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.rtbRecords = new System.Windows.Forms.RichTextBox();
            this.lrecords = new System.Windows.Forms.Label();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbRecords
            // 
            this.rtbRecords.BackColor = System.Drawing.Color.LavenderBlush;
            this.rtbRecords.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbRecords.Location = new System.Drawing.Point(70, 56);
            this.rtbRecords.Name = "rtbRecords";
            this.rtbRecords.ReadOnly = true;
            this.rtbRecords.Size = new System.Drawing.Size(508, 257);
            this.rtbRecords.TabIndex = 0;
            this.rtbRecords.Text = "";
            // 
            // lrecords
            // 
            this.lrecords.AutoSize = true;
            this.lrecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lrecords.Location = new System.Drawing.Point(197, 27);
            this.lrecords.Name = "lrecords";
            this.lrecords.Size = new System.Drawing.Size(243, 26);
            this.lrecords.TabIndex = 1;
            this.lrecords.Text = "Збережені результати:";
            // 
            // btnClearTable
            // 
            this.btnClearTable.Cursor = System.Windows.Forms.Cursors.No;
            this.btnClearTable.Location = new System.Drawing.Point(327, 319);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(251, 23);
            this.btnClearTable.TabIndex = 2;
            this.btnClearTable.Text = "Очистити таблицю рекордів!";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(70, 319);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(251, 23);
            this.btnBackToMenu.TabIndex = 3;
            this.btnBackToMenu.Text = "Повернутись до головного меню!";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GAME2048.Properties.Resources.fongame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 355);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.lrecords);
            this.Controls.Add(this.rtbRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Records";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRecords;
        private System.Windows.Forms.Label lrecords;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}