
namespace Labs.Forms
{
    partial class FormLab3
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
            this.pictureBoxAction = new System.Windows.Forms.PictureBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelEquals = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAction)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAction
            // 
            this.pictureBoxAction.Image = global::Labs.Properties.Resources.orderedDistribution;
            this.pictureBoxAction.Location = new System.Drawing.Point(23, 41);
            this.pictureBoxAction.Name = "pictureBoxAction";
            this.pictureBoxAction.Size = new System.Drawing.Size(45, 50);
            this.pictureBoxAction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAction.TabIndex = 0;
            this.pictureBoxAction.TabStop = false;
            // 
            // textBoxM
            // 
            this.textBoxM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxM.Location = new System.Drawing.Point(74, 41);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(28, 22);
            this.textBoxM.TabIndex = 1;
            this.textBoxM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxM.TextChanged += new System.EventHandler(this.textBoxM_TextChanged);
            // 
            // textBoxN
            // 
            this.textBoxN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxN.Location = new System.Drawing.Point(74, 69);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(28, 22);
            this.textBoxN.TabIndex = 2;
            this.textBoxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxM_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxResult.Location = new System.Drawing.Point(135, 55);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(56, 22);
            this.textBoxResult.TabIndex = 3;
            // 
            // labelEquals
            // 
            this.labelEquals.AutoSize = true;
            this.labelEquals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEquals.Location = new System.Drawing.Point(108, 55);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(21, 21);
            this.labelEquals.TabIndex = 4;
            this.labelEquals.Text = "=";
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Location = new System.Drawing.Point(23, 12);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAction.TabIndex = 5;
            this.comboBoxAction.SelectedIndexChanged += new System.EventHandler(this.comboBoxAction_SelectedIndexChanged);
            // 
            // FormLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 110);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.labelEquals);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.pictureBoxAction);
            this.Name = "FormLab3";
            this.Text = "FormLab3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLab3_FormClosed);
            this.Load += new System.EventHandler(this.FormLab3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAction;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelEquals;
        private System.Windows.Forms.ComboBox comboBoxAction;
    }
}