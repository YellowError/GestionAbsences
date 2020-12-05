namespace Gestion_d_abscence
{
    partial class frmManageStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageStudents));
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnModifierStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.Denomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersOfPeriodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchBar = new System.Windows.Forms.Button();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.txbSearchBar = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblNotFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.pnlSearchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDeleteStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDeleteStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDeleteStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteStudent.Location = new System.Drawing.Point(136, 101);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(103, 33);
            this.btnDeleteStudent.TabIndex = 12;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Visible = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnModifierStudent
            // 
            this.btnModifierStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnModifierStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnModifierStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnModifierStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnModifierStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModifierStudent.Location = new System.Drawing.Point(27, 101);
            this.btnModifierStudent.Name = "btnModifierStudent";
            this.btnModifierStudent.Size = new System.Drawing.Size(103, 33);
            this.btnModifierStudent.TabIndex = 11;
            this.btnModifierStudent.Text = "Modify";
            this.btnModifierStudent.UseVisualStyleBackColor = false;
            this.btnModifierStudent.Visible = false;
            this.btnModifierStudent.Click += new System.EventHandler(this.btnModifierStudent_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeColumns = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denomination,
            this.numbersOfPeriodes,
            this.endOn,
            this.startOn});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvStudents.Location = new System.Drawing.Point(27, 140);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(517, 261);
            this.dgvStudents.TabIndex = 13;
            this.dgvStudents.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudents_CellMouseClick);
            // 
            // Denomination
            // 
            this.Denomination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Denomination.FillWeight = 154.5342F;
            this.Denomination.HeaderText = "First Name";
            this.Denomination.Name = "Denomination";
            this.Denomination.ReadOnly = true;
            // 
            // numbersOfPeriodes
            // 
            this.numbersOfPeriodes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numbersOfPeriodes.FillWeight = 154.5342F;
            this.numbersOfPeriodes.HeaderText = "Last Name";
            this.numbersOfPeriodes.Name = "numbersOfPeriodes";
            this.numbersOfPeriodes.ReadOnly = true;
            // 
            // endOn
            // 
            this.endOn.FillWeight = 42.6396F;
            this.endOn.HeaderText = "Total Absences";
            this.endOn.Name = "endOn";
            this.endOn.ReadOnly = true;
            // 
            // startOn
            // 
            this.startOn.FillWeight = 48.29195F;
            this.startOn.HeaderText = "Id";
            this.startOn.Name = "startOn";
            this.startOn.ReadOnly = true;
            // 
            // btnSearchBar
            // 
            this.btnSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSearchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchBar.BackgroundImage")));
            this.btnSearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBar.FlatAppearance.BorderSize = 0;
            this.btnSearchBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearchBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearchBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchBar.Location = new System.Drawing.Point(4, 4);
            this.btnSearchBar.Name = "btnSearchBar";
            this.btnSearchBar.Padding = new System.Windows.Forms.Padding(5);
            this.btnSearchBar.Size = new System.Drawing.Size(31, 28);
            this.btnSearchBar.TabIndex = 16;
            this.btnSearchBar.UseVisualStyleBackColor = false;
            // 
            // pnlSearchBar
            // 
            this.pnlSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlSearchBar.Controls.Add(this.btnSearchBar);
            this.pnlSearchBar.Controls.Add(this.txbSearchBar);
            this.pnlSearchBar.Location = new System.Drawing.Point(267, 97);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(277, 37);
            this.pnlSearchBar.TabIndex = 15;
            // 
            // txbSearchBar
            // 
            this.txbSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txbSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchBar.ForeColor = System.Drawing.Color.Snow;
            this.txbSearchBar.Location = new System.Drawing.Point(51, 7);
            this.txbSearchBar.MaxLength = 20;
            this.txbSearchBar.Name = "txbSearchBar";
            this.txbSearchBar.Size = new System.Drawing.Size(215, 22);
            this.txbSearchBar.TabIndex = 1;
            this.txbSearchBar.TextChanged += new System.EventHandler(this.txbSearchBar_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 33);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStudent.Location = new System.Drawing.Point(441, 47);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(103, 33);
            this.btnAddStudent.TabIndex = 17;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblNotFound.Location = new System.Drawing.Point(229, 254);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(73, 13);
            this.lblNotFound.TabIndex = 17;
            this.lblNotFound.Text = "crud message";
            this.lblNotFound.Visible = false;
            // 
            // frmManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlSearchBar);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnModifierStudent);
            this.Name = "frmManageStudents";
            this.Text = "frmManageStudents";
            this.Load += new System.EventHandler(this.frmManageStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnModifierStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersOfPeriodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn endOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startOn;
        private System.Windows.Forms.Button btnSearchBar;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.TextBox txbSearchBar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblNotFound;
    }
}