
namespace Labs
{
    partial class Menu
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
            this.buttonLab1 = new System.Windows.Forms.Button();
            this.buttonLab2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLab1
            // 
            this.buttonLab1.Location = new System.Drawing.Point(12, 12);
            this.buttonLab1.Name = "buttonLab1";
            this.buttonLab1.Size = new System.Drawing.Size(159, 43);
            this.buttonLab1.TabIndex = 0;
            this.buttonLab1.Text = "Lab1";
            this.buttonLab1.UseVisualStyleBackColor = true;
            this.buttonLab1.Click += new System.EventHandler(this.buttonLab1_Click);
            // 
            // buttonLab2
            // 
            this.buttonLab2.Location = new System.Drawing.Point(12, 61);
            this.buttonLab2.Name = "buttonLab2";
            this.buttonLab2.Size = new System.Drawing.Size(159, 43);
            this.buttonLab2.TabIndex = 1;
            this.buttonLab2.Text = "Lab2";
            this.buttonLab2.UseVisualStyleBackColor = true;
            this.buttonLab2.Click += new System.EventHandler(this.buttonLab2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 331);
            this.Controls.Add(this.buttonLab2);
            this.Controls.Add(this.buttonLab1);
            this.MaximumSize = new System.Drawing.Size(210, 370);
            this.MinimumSize = new System.Drawing.Size(210, 370);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLab1;
        private System.Windows.Forms.Button buttonLab2;
    }
}