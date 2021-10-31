
namespace Labs
{
    partial class FormLab1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBoxAct = new System.Windows.Forms.ComboBox();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInput1 = new System.Windows.Forms.Label();
            this.labelInput2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVarNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(557, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 250);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // comboBoxAct
            // 
            this.comboBoxAct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAct.Location = new System.Drawing.Point(139, 112);
            this.comboBoxAct.Name = "comboBoxAct";
            this.comboBoxAct.Size = new System.Drawing.Size(128, 29);
            this.comboBoxAct.TabIndex = 1;
            this.comboBoxAct.SelectedIndexChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(12, 116);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(121, 23);
            this.textBoxInput1.TabIndex = 2;
            this.textBoxInput1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(273, 116);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(121, 23);
            this.textBoxInput2.TabIndex = 3;
            this.textBoxInput2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(431, 116);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(119, 23);
            this.textBoxResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(400, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // labelInput1
            // 
            this.labelInput1.AutoSize = true;
            this.labelInput1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInput1.Location = new System.Drawing.Point(57, 84);
            this.labelInput1.Name = "labelInput1";
            this.labelInput1.Size = new System.Drawing.Size(24, 25);
            this.labelInput1.TabIndex = 7;
            this.labelInput1.Text = "A";
            this.labelInput1.DoubleClick += new System.EventHandler(this.labelInput_DoubleClick);
            // 
            // labelInput2
            // 
            this.labelInput2.AutoSize = true;
            this.labelInput2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInput2.Location = new System.Drawing.Point(314, 84);
            this.labelInput2.Name = "labelInput2";
            this.labelInput2.Size = new System.Drawing.Size(23, 25);
            this.labelInput2.TabIndex = 8;
            this.labelInput2.Text = "B";
            this.labelInput2.DoubleClick += new System.EventHandler(this.labelInput_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(185, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "act";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(460, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "result";
            // 
            // textBoxVarNameInput
            // 
            this.textBoxVarNameInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVarNameInput.Location = new System.Drawing.Point(189, 12);
            this.textBoxVarNameInput.Name = "textBoxVarNameInput";
            this.textBoxVarNameInput.Size = new System.Drawing.Size(33, 33);
            this.textBoxVarNameInput.TabIndex = 11;
            this.textBoxVarNameInput.Visible = false;
            this.textBoxVarNameInput.TextChanged += new System.EventHandler(this.textBoxVarNameInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "* Double click on variable name to change it";
            // 
            // FormLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVarNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelInput2);
            this.Controls.Add(this.labelInput1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxInput2);
            this.Controls.Add(this.textBoxInput1);
            this.Controls.Add(this.comboBoxAct);
            this.Controls.Add(this.pictureBox);
            this.MaximumSize = new System.Drawing.Size(835, 310);
            this.MinimumSize = new System.Drawing.Size(835, 310);
            this.Name = "FormLab1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1 by Yehor Ovseiukov";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLab1_FormClosed);
            this.Load += new System.EventHandler(this.FormLab1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBoxAct;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInput1;
        private System.Windows.Forms.Label labelInput2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVarNameInput;
        private System.Windows.Forms.Label label3;
    }
}

