namespace bai2
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lvstudent = new System.Windows.Forms.ListView();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(733, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 47);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lvstudent
            // 
            this.lvstudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvstudent.FullRowSelect = true;
            this.lvstudent.GridLines = true;
            this.lvstudent.HideSelection = false;
            this.lvstudent.Location = new System.Drawing.Point(12, 12);
            this.lvstudent.Name = "lvstudent";
            this.lvstudent.Size = new System.Drawing.Size(483, 264);
            this.lvstudent.TabIndex = 2;
            this.lvstudent.UseCompatibleStateImageBehavior = false;
            this.lvstudent.View = System.Windows.Forms.View.Details;
            this.lvstudent.SelectedIndexChanged += new System.EventHandler(this.lvstudent_SelectedIndexChanged);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(513, 34);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(129, 22);
            this.txtlastname.TabIndex = 3;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(513, 85);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(129, 22);
            this.txtfirstname.TabIndex = 3;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(513, 142);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(129, 22);
            this.txtphone.TabIndex = 3;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(43, 300);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(90, 37);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(216, 300);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 37);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(391, 300);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(90, 37);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "lastname";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "firstname";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "phone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 364);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.lvstudent);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView lvstudent;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

