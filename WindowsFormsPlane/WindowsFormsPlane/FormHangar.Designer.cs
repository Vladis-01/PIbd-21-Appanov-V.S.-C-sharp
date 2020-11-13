namespace WindowsFormsPlane
{
    partial class FormHangar
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
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.buttonSetBomberPlane = new System.Windows.Forms.Button();
            this.buttonSetPlane = new System.Windows.Forms.Button();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.buttonPickUpPlane = new System.Windows.Forms.Button();
            this.maskedTextBoxHangar = new System.Windows.Forms.MaskedTextBox();
            this.labelParking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHangar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // buttonSetBomberPlane
            // 
            this.buttonSetBomberPlane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetBomberPlane.Location = new System.Drawing.Point(891, 64);
            this.buttonSetBomberPlane.Name = "buttonSetBomberPlane";
            this.buttonSetBomberPlane.Size = new System.Drawing.Size(105, 57);
            this.buttonSetBomberPlane.TabIndex = 1;
            this.buttonSetBomberPlane.Text = "Припарковать бомбардировщик";
            this.buttonSetBomberPlane.UseVisualStyleBackColor = true;
            this.buttonSetBomberPlane.Click += new System.EventHandler(this.buttonSetBomberPlane_Click);
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Location = new System.Drawing.Point(891, 12);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(104, 43);
            this.buttonSetPlane.TabIndex = 2;
            this.buttonSetPlane.Text = "Припарковать самолет";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Controls.Add(this.buttonPickUpPlane);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxHangar);
            this.groupBoxParking.Controls.Add(this.labelParking);
            this.groupBoxParking.Location = new System.Drawing.Point(893, 128);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(103, 124);
            this.groupBoxParking.TabIndex = 3;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать самолет";
            // 
            // buttonPickUpPlane
            // 
            this.buttonPickUpPlane.Location = new System.Drawing.Point(12, 63);
            this.buttonPickUpPlane.Name = "buttonPickUpPlane";
            this.buttonPickUpPlane.Size = new System.Drawing.Size(75, 28);
            this.buttonPickUpPlane.TabIndex = 2;
            this.buttonPickUpPlane.Text = "Забрать";
            this.buttonPickUpPlane.UseVisualStyleBackColor = true;
            this.buttonPickUpPlane.Click += new System.EventHandler(this.buttonPickUpPlane_Click);
            // 
            // maskedTextBoxHangar
            // 
            this.maskedTextBoxHangar.Location = new System.Drawing.Point(55, 32);
            this.maskedTextBoxHangar.Name = "maskedTextBoxHangar";
            this.maskedTextBoxHangar.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBoxHangar.TabIndex = 1;
            // 
            // labelParking
            // 
            this.labelParking.AutoSize = true;
            this.labelParking.Location = new System.Drawing.Point(7, 35);
            this.labelParking.Name = "labelParking";
            this.labelParking.Size = new System.Drawing.Size(42, 13);
            this.labelParking.TabIndex = 0;
            this.labelParking.Text = "Место:";
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 461);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.buttonSetBomberPlane);
            this.Controls.Add(this.pictureBoxHangar);
            this.Name = "FormHangar";
            this.Text = "FormHangar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.Button buttonSetBomberPlane;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button buttonPickUpPlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHangar;
        private System.Windows.Forms.Label labelParking;
    }
}