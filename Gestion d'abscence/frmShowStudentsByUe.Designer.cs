namespace Gestion_d_abscence
{
    partial class frmShowStudentsByUe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudentsByUt = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersOfPeriodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddStudentByUe = new System.Windows.Forms.Button();
            this.btnDeleteStudentByUe = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cbAddStudentInUt = new System.Windows.Forms.ComboBox();
            this.lblStudentAddList = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsByUt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentsByUt
            // 
            this.dgvStudentsByUt.AllowUserToAddRows = false;
            this.dgvStudentsByUt.AllowUserToDeleteRows = false;
            this.dgvStudentsByUt.AllowUserToResizeColumns = false;
            this.dgvStudentsByUt.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudentsByUt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStudentsByUt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentsByUt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvStudentsByUt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentsByUt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsByUt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStudentsByUt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsByUt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Denomination,
            this.numbersOfPeriodes,
            this.startOn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentsByUt.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStudentsByUt.Location = new System.Drawing.Point(39, 192);
            this.dgvStudentsByUt.Name = "dgvStudentsByUt";
            this.dgvStudentsByUt.Size = new System.Drawing.Size(395, 335);
            this.dgvStudentsByUt.TabIndex = 3;
            this.dgvStudentsByUt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentsByUt_CellContentClick);
            this.dgvStudentsByUt.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudentsByUt_CellMouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Denomination
            // 
            this.Denomination.HeaderText = "FirstName";
            this.Denomination.Name = "Denomination";
            this.Denomination.ReadOnly = true;
            // 
            // numbersOfPeriodes
            // 
            this.numbersOfPeriodes.HeaderText = "LastName";
            this.numbersOfPeriodes.Name = "numbersOfPeriodes";
            this.numbersOfPeriodes.ReadOnly = true;
            // 
            // startOn
            // 
            this.startOn.HeaderText = "Number of absence";
            this.startOn.Name = "startOn";
            this.startOn.ReadOnly = true;
            // 
            // btnAddStudentByUe
            // 
            this.btnAddStudentByUe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddStudentByUe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddStudentByUe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddStudentByUe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddStudentByUe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudentByUe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStudentByUe.Location = new System.Drawing.Point(39, 142);
            this.btnAddStudentByUe.Name = "btnAddStudentByUe";
            this.btnAddStudentByUe.Size = new System.Drawing.Size(103, 33);
            this.btnAddStudentByUe.TabIndex = 10;
            this.btnAddStudentByUe.Text = "Add Student";
            this.btnAddStudentByUe.UseVisualStyleBackColor = false;
            this.btnAddStudentByUe.Visible = false;
            this.btnAddStudentByUe.Click += new System.EventHandler(this.btnAddStudentByUe_Click);
            // 
            // btnDeleteStudentByUe
            // 
            this.btnDeleteStudentByUe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDeleteStudentByUe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDeleteStudentByUe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDeleteStudentByUe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteStudentByUe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudentByUe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteStudentByUe.Location = new System.Drawing.Point(332, 142);
            this.btnDeleteStudentByUe.Name = "btnDeleteStudentByUe";
            this.btnDeleteStudentByUe.Size = new System.Drawing.Size(103, 33);
            this.btnDeleteStudentByUe.TabIndex = 11;
            this.btnDeleteStudentByUe.Text = "Delete";
            this.btnDeleteStudentByUe.UseVisualStyleBackColor = false;
            this.btnDeleteStudentByUe.Visible = false;
            this.btnDeleteStudentByUe.Click += new System.EventHandler(this.btnDeleteStudentByUe_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(103, 33);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "<";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cbAddStudentInUt
            // 
            this.cbAddStudentInUt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAddStudentInUt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAddStudentInUt.FormattingEnabled = true;
            this.cbAddStudentInUt.Location = new System.Drawing.Point(148, 149);
            this.cbAddStudentInUt.Name = "cbAddStudentInUt";
            this.cbAddStudentInUt.Size = new System.Drawing.Size(178, 21);
            this.cbAddStudentInUt.TabIndex = 21;
            this.cbAddStudentInUt.SelectedIndexChanged += new System.EventHandler(this.cbAddStudentInUt_SelectedIndexChanged);
            this.cbAddStudentInUt.SelectedValueChanged += new System.EventHandler(this.cbAddStudentInUt_SelectedValueChanged);
            this.cbAddStudentInUt.TextChanged += new System.EventHandler(this.cbAddStudentInUt_TextChanged);
            this.cbAddStudentInUt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbAddStudentInUt_MouseClick);
            // 
            // lblStudentAddList
            // 
            this.lblStudentAddList.AutoSize = true;
            this.lblStudentAddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentAddList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStudentAddList.Location = new System.Drawing.Point(184, 129);
            this.lblStudentAddList.Name = "lblStudentAddList";
            this.lblStudentAddList.Size = new System.Drawing.Size(106, 17);
            this.lblStudentAddList.TabIndex = 22;
            this.lblStudentAddList.Text = "Student add list";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(212, 49);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 20);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Name of Ut";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmShowStudentsByUe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(541, 607);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStudentAddList);
            this.Controls.Add(this.cbAddStudentInUt);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteStudentByUe);
            this.Controls.Add(this.btnAddStudentByUe);
            this.Controls.Add(this.dgvStudentsByUt);
            this.Name = "frmShowStudentsByUe";
            this.Text = "frmShowStudentsByUe";
            this.Load += new System.EventHandler(this.frmShowStudentsByUe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsByUt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentsByUt;
        private System.Windows.Forms.Button btnAddStudentByUe;
        private System.Windows.Forms.Button btnDeleteStudentByUe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersOfPeriodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn startOn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cbAddStudentInUt;
        private System.Windows.Forms.Label lblStudentAddList;
        private System.Windows.Forms.Label lblTitle;
    }
}