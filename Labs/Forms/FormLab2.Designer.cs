
namespace Labs
{
    partial class FormLab2
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
            this.dataGridViewSetsRelations = new System.Windows.Forms.DataGridView();
            this.labelA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetsRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSetsRelations
            // 
            this.dataGridViewSetsRelations.AllowUserToAddRows = false;
            this.dataGridViewSetsRelations.AllowUserToDeleteRows = false;
            this.dataGridViewSetsRelations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSetsRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSetsRelations.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSetsRelations.Name = "dataGridViewSetsRelations";
            this.dataGridViewSetsRelations.ReadOnly = true;
            this.dataGridViewSetsRelations.RowTemplate.Height = 25;
            this.dataGridViewSetsRelations.Size = new System.Drawing.Size(400, 400);
            this.dataGridViewSetsRelations.TabIndex = 0;
            // 
            // labelA
            // 
            this.labelA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelA.Location = new System.Drawing.Point(418, 12);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(74, 37);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "A = {";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(747, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "}";
            // 
            // textBoxA
            // 
            this.textBoxA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxA.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxA.Location = new System.Drawing.Point(488, 12);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(262, 43);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            this.textBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxB.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxB.Location = new System.Drawing.Point(488, 61);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(262, 43);
            this.textBoxB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(747, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "}";
            // 
            // labelB
            // 
            this.labelB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelB.Location = new System.Drawing.Point(418, 61);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(72, 37);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "B = {";
            // 
            // FormLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.dataGridViewSetsRelations);
            this.Name = "FormLab2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2 by Ovseiukov Yehor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLab2_FormClosed);
            this.Load += new System.EventHandler(this.FormLab2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSetsRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSetsRelations;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelB;
    }
}