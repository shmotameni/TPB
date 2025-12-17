
namespace Transparent_Picture_Background
{
    partial class frmConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConvert));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brows:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(73, 12);
            this.txtSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(321, 25);
            this.txtSource.TabIndex = 2;
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(400, 11);
            this.btnSourceBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(82, 28);
            this.btnSourceBrowse.TabIndex = 3;
            this.btnSourceBrowse.Text = "Upload";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(400, 43);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(82, 27);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 78);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSourceBrowse);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Nazanin", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConvert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Convert Picture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnConvert;
    }
}

