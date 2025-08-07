namespace CRUDStoreProcedure
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
            this.lblcruds = new System.Windows.Forms.Label();
            this.lblempid = new System.Windows.Forms.Label();
            this.lbljoiningdate = new System.Windows.Forms.Label();
            this.lblempsex = new System.Windows.Forms.Label();
            this.lblempage = new System.Windows.Forms.Label();
            this.lblempcity = new System.Windows.Forms.Label();
            this.lblempname = new System.Windows.Forms.Label();
            this.lblempcontact = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtempage = new System.Windows.Forms.TextBox();
            this.txtempcontact = new System.Windows.Forms.TextBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.radioButtonsexmale = new System.Windows.Forms.RadioButton();
            this.radioButtonsexfemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btninsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxempcity = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcruds
            // 
            this.lblcruds.AutoSize = true;
            this.lblcruds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcruds.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcruds.Location = new System.Drawing.Point(201, 36);
            this.lblcruds.Name = "lblcruds";
            this.lblcruds.Size = new System.Drawing.Size(511, 36);
            this.lblcruds.TabIndex = 0;
            this.lblcruds.Text = "CRUD in c# Using store Procedure";
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblempid.Location = new System.Drawing.Point(119, 97);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(134, 25);
            this.lblempid.TabIndex = 1;
            this.lblempid.Text = "Employee ID";
            // 
            // lbljoiningdate
            // 
            this.lbljoiningdate.AutoSize = true;
            this.lbljoiningdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljoiningdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbljoiningdate.Location = new System.Drawing.Point(119, 381);
            this.lbljoiningdate.Name = "lbljoiningdate";
            this.lbljoiningdate.Size = new System.Drawing.Size(133, 25);
            this.lbljoiningdate.TabIndex = 6;
            this.lbljoiningdate.Text = "Joining Date";
            // 
            // lblempsex
            // 
            this.lblempsex.AutoSize = true;
            this.lblempsex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempsex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblempsex.Location = new System.Drawing.Point(122, 324);
            this.lblempsex.Name = "lblempsex";
            this.lblempsex.Size = new System.Drawing.Size(50, 25);
            this.lblempsex.TabIndex = 7;
            this.lblempsex.Text = "Sex";
            // 
            // lblempage
            // 
            this.lblempage.AutoSize = true;
            this.lblempage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblempage.Location = new System.Drawing.Point(122, 262);
            this.lblempage.Name = "lblempage";
            this.lblempage.Size = new System.Drawing.Size(152, 25);
            this.lblempage.TabIndex = 8;
            this.lblempage.Text = "Employee Age";
            // 
            // lblempcity
            // 
            this.lblempcity.AutoSize = true;
            this.lblempcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempcity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblempcity.Location = new System.Drawing.Point(122, 206);
            this.lblempcity.Name = "lblempcity";
            this.lblempcity.Size = new System.Drawing.Size(151, 25);
            this.lblempcity.TabIndex = 9;
            this.lblempcity.Text = "Employee City";
            // 
            // lblempname
            // 
            this.lblempname.AutoSize = true;
            this.lblempname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblempname.Location = new System.Drawing.Point(119, 150);
            this.lblempname.Name = "lblempname";
            this.lblempname.Size = new System.Drawing.Size(169, 25);
            this.lblempname.TabIndex = 10;
            this.lblempname.Text = "Employee Name";
            // 
            // lblempcontact
            // 
            this.lblempcontact.AutoSize = true;
            this.lblempcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempcontact.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblempcontact.Location = new System.Drawing.Point(122, 440);
            this.lblempcontact.Name = "lblempcontact";
            this.lblempcontact.Size = new System.Drawing.Size(87, 25);
            this.lblempcontact.TabIndex = 11;
            this.lblempcontact.Text = "Contact";
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(363, 101);
            this.txtempid.Multiline = true;
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(247, 22);
            this.txtempid.TabIndex = 12;
            // 
            // txtempage
            // 
            this.txtempage.Location = new System.Drawing.Point(363, 266);
            this.txtempage.Name = "txtempage";
            this.txtempage.Size = new System.Drawing.Size(247, 22);
            this.txtempage.TabIndex = 13;
            // 
            // txtempcontact
            // 
            this.txtempcontact.Location = new System.Drawing.Point(363, 444);
            this.txtempcontact.Name = "txtempcontact";
            this.txtempcontact.Size = new System.Drawing.Size(247, 22);
            this.txtempcontact.TabIndex = 17;
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(363, 153);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(247, 22);
            this.txtempname.TabIndex = 19;
            // 
            // radioButtonsexmale
            // 
            this.radioButtonsexmale.AutoSize = true;
            this.radioButtonsexmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonsexmale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonsexmale.Location = new System.Drawing.Point(363, 326);
            this.radioButtonsexmale.Name = "radioButtonsexmale";
            this.radioButtonsexmale.Size = new System.Drawing.Size(70, 24);
            this.radioButtonsexmale.TabIndex = 20;
            this.radioButtonsexmale.TabStop = true;
            this.radioButtonsexmale.Text = "Male";
            this.radioButtonsexmale.UseVisualStyleBackColor = true;
            // 
            // radioButtonsexfemale
            // 
            this.radioButtonsexfemale.AutoSize = true;
            this.radioButtonsexfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonsexfemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonsexfemale.Location = new System.Drawing.Point(483, 326);
            this.radioButtonsexfemale.Name = "radioButtonsexfemale";
            this.radioButtonsexfemale.Size = new System.Drawing.Size(91, 24);
            this.radioButtonsexfemale.TabIndex = 21;
            this.radioButtonsexfemale.TabStop = true;
            this.radioButtonsexfemale.Text = "Female";
            this.radioButtonsexfemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 380);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btninsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btninsert.Location = new System.Drawing.Point(363, 495);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(120, 43);
            this.btninsert.TabIndex = 23;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 559);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(835, 171);
            this.dataGridView1.TabIndex = 24;
            // 
            // comboBoxempcity
            // 
            this.comboBoxempcity.FormattingEnabled = true;
            this.comboBoxempcity.Items.AddRange(new object[] {
            "New York",
            "India",
            "UK"});
            this.comboBoxempcity.Location = new System.Drawing.Point(363, 206);
            this.comboBoxempcity.Name = "comboBoxempcity";
            this.comboBoxempcity.Size = new System.Drawing.Size(247, 24);
            this.comboBoxempcity.TabIndex = 25;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdate.Location = new System.Drawing.Point(490, 495);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(120, 43);
            this.btnupdate.TabIndex = 26;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndelete.Location = new System.Drawing.Point(616, 495);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 43);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(859, 742);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.comboBoxempcity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonsexfemale);
            this.Controls.Add(this.radioButtonsexmale);
            this.Controls.Add(this.txtempname);
            this.Controls.Add(this.txtempcontact);
            this.Controls.Add(this.txtempage);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.lblempcontact);
            this.Controls.Add(this.lblempname);
            this.Controls.Add(this.lblempcity);
            this.Controls.Add(this.lblempage);
            this.Controls.Add(this.lblempsex);
            this.Controls.Add(this.lbljoiningdate);
            this.Controls.Add(this.lblempid);
            this.Controls.Add(this.lblcruds);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcruds;
        private System.Windows.Forms.Label lblempid;
        private System.Windows.Forms.Label lbljoiningdate;
        private System.Windows.Forms.Label lblempsex;
        private System.Windows.Forms.Label lblempage;
        private System.Windows.Forms.Label lblempcity;
        private System.Windows.Forms.Label lblempname;
        private System.Windows.Forms.Label lblempcontact;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtempage;
        private System.Windows.Forms.TextBox txtempcontact;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.RadioButton radioButtonsexmale;
        private System.Windows.Forms.RadioButton radioButtonsexfemale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxempcity;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}

