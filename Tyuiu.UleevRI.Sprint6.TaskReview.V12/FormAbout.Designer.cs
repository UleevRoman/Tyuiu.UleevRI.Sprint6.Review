
namespace Tyuiu.UleevRI.Sprint6.TaskReview.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxInformation_URI = new System.Windows.Forms.PictureBox();
            this.textBoxIformation_URI = new System.Windows.Forms.TextBox();
            this.buttonOK_URI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation_URI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInformation_URI
            // 
            this.pictureBoxInformation_URI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInformation_URI.Image")));
            this.pictureBoxInformation_URI.Location = new System.Drawing.Point(12, 37);
            this.pictureBoxInformation_URI.Name = "pictureBoxInformation_URI";
            this.pictureBoxInformation_URI.Size = new System.Drawing.Size(229, 206);
            this.pictureBoxInformation_URI.TabIndex = 0;
            this.pictureBoxInformation_URI.TabStop = false;
            // 
            // textBoxIformation_URI
            // 
            this.textBoxIformation_URI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIformation_URI.Location = new System.Drawing.Point(267, 37);
            this.textBoxIformation_URI.Multiline = true;
            this.textBoxIformation_URI.Name = "textBoxIformation_URI";
            this.textBoxIformation_URI.ReadOnly = true;
            this.textBoxIformation_URI.Size = new System.Drawing.Size(469, 206);
            this.textBoxIformation_URI.TabIndex = 1;
            this.textBoxIformation_URI.Text = resources.GetString("textBoxIformation_URI.Text");
            // 
            // buttonOK_URI
            // 
            this.buttonOK_URI.Location = new System.Drawing.Point(695, 396);
            this.buttonOK_URI.Name = "buttonOK_URI";
            this.buttonOK_URI.Size = new System.Drawing.Size(81, 42);
            this.buttonOK_URI.TabIndex = 2;
            this.buttonOK_URI.Text = "OK";
            this.buttonOK_URI.UseVisualStyleBackColor = true;
            this.buttonOK_URI.Click += new System.EventHandler(this.buttonOK_URI_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK_URI);
            this.Controls.Add(this.textBoxIformation_URI);
            this.Controls.Add(this.pictureBoxInformation_URI);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation_URI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInformation_URI;
        private System.Windows.Forms.TextBox textBoxIformation_URI;
        private System.Windows.Forms.Button buttonOK_URI;
    }
}