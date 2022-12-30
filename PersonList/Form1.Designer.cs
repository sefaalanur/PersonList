
namespace PersonList
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgView1 = new System.Windows.Forms.DataGridView();
            this.currentweek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Person add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(21, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 56);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Person delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(21, 116);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 56);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Person edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgView1
            // 
            this.dgView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView1.Location = new System.Drawing.Point(378, 27);
            this.dgView1.Name = "dgView1";
            this.dgView1.RowHeadersWidth = 51;
            this.dgView1.RowTemplate.Height = 24;
            this.dgView1.Size = new System.Drawing.Size(607, 383);
            this.dgView1.TabIndex = 6;
            // 
            // currentweek
            // 
            this.currentweek.Location = new System.Drawing.Point(31, 354);
            this.currentweek.Name = "currentweek";
            this.currentweek.Size = new System.Drawing.Size(145, 56);
            this.currentweek.TabIndex = 7;
            this.currentweek.Text = "Birthday";
            this.currentweek.UseVisualStyleBackColor = true;
            this.currentweek.Click += new System.EventHandler(this.currentweek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.currentweek);
            this.Controls.Add(this.dgView1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgView1;
        private System.Windows.Forms.Button currentweek;
    }
}