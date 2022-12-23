namespace PersonList
{
    partial class FormDelete
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
            this.p_id = new System.Windows.Forms.Label();
            this.IdelBox = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.dgView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgView1)).BeginInit();
            this.SuspendLayout();
            // 
            // p_id
            // 
            this.p_id.AutoSize = true;
            this.p_id.Location = new System.Drawing.Point(34, 44);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(72, 17);
            this.p_id.TabIndex = 0;
            this.p_id.Text = "Person Id:";
            // 
            // IdelBox
            // 
            this.IdelBox.Location = new System.Drawing.Point(146, 44);
            this.IdelBox.Name = "IdelBox";
            this.IdelBox.Size = new System.Drawing.Size(170, 22);
            this.IdelBox.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(194, 106);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(122, 54);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(122, 317);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(194, 60);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Update list";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // dgView1
            // 
            this.dgView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView1.Location = new System.Drawing.Point(376, 33);
            this.dgView1.Name = "dgView1";
            this.dgView1.RowHeadersWidth = 51;
            this.dgView1.RowTemplate.Height = 24;
            this.dgView1.Size = new System.Drawing.Size(607, 383);
            this.dgView1.TabIndex = 5;
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.dgView1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.IdelBox);
            this.Controls.Add(this.p_id);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            ((System.ComponentModel.ISupportInitialize)(this.dgView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p_id;
        private System.Windows.Forms.TextBox IdelBox;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView dgView1;
    }
}