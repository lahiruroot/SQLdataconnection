namespace WindowsFormsApp1
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncls = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnsub = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbldate = new MaterialSkin.Controls.MaterialLabel();
            this.lbltime = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtemail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtmob = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.connectionDataSet = new WindowsFormsApp1.connectionDataSet();
            this.pubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pubTableAdapter = new WindowsFormsApp1.connectionDataSetTableAdapters.pubTableAdapter();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 138);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1075, 455);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btncls);
            this.tabPage1.Controls.Add(this.btnsub);
            this.tabPage1.Controls.Add(this.lbldate);
            this.tabPage1.Controls.Add(this.lbltime);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1067, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fourm";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientidDataGridViewTextBoxColumn,
            this.clientnameDataGridViewTextBoxColumn,
            this.mobilenumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pubBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(453, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 210);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btncls
            // 
            this.btncls.Depth = 0;
            this.btncls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncls.Location = new System.Drawing.Point(749, 371);
            this.btncls.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncls.Name = "btncls";
            this.btncls.Primary = true;
            this.btncls.Size = new System.Drawing.Size(153, 36);
            this.btncls.TabIndex = 3;
            this.btncls.Text = "CLEAR";
            this.btncls.UseVisualStyleBackColor = true;
            // 
            // btnsub
            // 
            this.btnsub.Depth = 0;
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(908, 371);
            this.btnsub.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsub.Name = "btnsub";
            this.btnsub.Primary = true;
            this.btnsub.Size = new System.Drawing.Size(153, 36);
            this.btnsub.TabIndex = 3;
            this.btnsub.Text = "SUBMIT";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Depth = 0;
            this.lbldate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbldate.Location = new System.Drawing.Point(802, 25);
            this.lbldate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(48, 24);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Depth = 0;
            this.lbltime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbltime.Location = new System.Drawing.Point(800, 60);
            this.lbltime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(53, 24);
            this.lbltime.TabIndex = 2;
            this.lbltime.Text = "Time";
            this.lbltime.Click += new System.EventHandler(this.lbltime_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtemail);
            this.groupBox4.Location = new System.Drawing.Point(25, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 69);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "E-mail address";
            // 
            // txtemail
            // 
            this.txtemail.Depth = 0;
            this.txtemail.Hint = "Enter Email";
            this.txtemail.Location = new System.Drawing.Point(98, 21);
            this.txtemail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.Size = new System.Drawing.Size(301, 28);
            this.txtemail.TabIndex = 3;
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtmob);
            this.groupBox3.Location = new System.Drawing.Point(25, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 69);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mobile Number";
            // 
            // txtmob
            // 
            this.txtmob.Depth = 0;
            this.txtmob.Hint = "Enter Mobile Number";
            this.txtmob.Location = new System.Drawing.Point(98, 21);
            this.txtmob.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtmob.Name = "txtmob";
            this.txtmob.PasswordChar = '\0';
            this.txtmob.SelectedText = "";
            this.txtmob.SelectionLength = 0;
            this.txtmob.SelectionStart = 0;
            this.txtmob.Size = new System.Drawing.Size(301, 28);
            this.txtmob.TabIndex = 2;
            this.txtmob.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Location = new System.Drawing.Point(25, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 69);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Name";
            // 
            // txtname
            // 
            this.txtname.Depth = 0;
            this.txtname.Hint = "Enter Client Name";
            this.txtname.Location = new System.Drawing.Point(98, 21);
            this.txtname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.Size = new System.Drawing.Size(301, 28);
            this.txtname.TabIndex = 1;
            this.txtname.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client ID";
            // 
            // txtid
            // 
            this.txtid.Depth = 0;
            this.txtid.Hint = "Enter Client Id";
            this.txtid.Location = new System.Drawing.Point(98, 21);
            this.txtid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.Size = new System.Drawing.Size(301, 28);
            this.txtid.TabIndex = 0;
            this.txtid.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1067, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data Set";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-8, 86);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1098, 46);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // connectionDataSet
            // 
            this.connectionDataSet.DataSetName = "connectionDataSet";
            this.connectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pubBindingSource
            // 
            this.pubBindingSource.DataMember = "pub";
            this.pubBindingSource.DataSource = this.connectionDataSet;
            // 
            // pubTableAdapter
            // 
            this.pubTableAdapter.ClearBeforeFill = true;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientnameDataGridViewTextBoxColumn
            // 
            this.clientnameDataGridViewTextBoxColumn.DataPropertyName = "client_name";
            this.clientnameDataGridViewTextBoxColumn.HeaderText = "client_name";
            this.clientnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientnameDataGridViewTextBoxColumn.Name = "clientnameDataGridViewTextBoxColumn";
            this.clientnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // mobilenumberDataGridViewTextBoxColumn
            // 
            this.mobilenumberDataGridViewTextBoxColumn.DataPropertyName = "mobilenumber";
            this.mobilenumberDataGridViewTextBoxColumn.HeaderText = "mobilenumber";
            this.mobilenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobilenumberDataGridViewTextBoxColumn.Name = "mobilenumberDataGridViewTextBoxColumn";
            this.mobilenumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 605);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pubBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtemail;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtmob;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtname;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtid;
        private MaterialSkin.Controls.MaterialLabel lbldate;
        private MaterialSkin.Controls.MaterialLabel lbltime;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialRaisedButton btncls;
        private MaterialSkin.Controls.MaterialRaisedButton btnsub;
        private System.Windows.Forms.DataGridView dataGridView1;
        private connectionDataSet connectionDataSet;
        private System.Windows.Forms.BindingSource pubBindingSource;
        private connectionDataSetTableAdapters.pubTableAdapter pubTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}