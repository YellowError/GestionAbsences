namespace Gestion_d_abscence
{
    partial class frmAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersOfPeriodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endOn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTeachingUnit = new System.Windows.Forms.Label();
            this.dtpSelectDateOfPresence = new System.Windows.Forms.DateTimePicker();
            this.cbTeachingUnit = new System.Windows.Forms.ComboBox();
            this.btnFindAttendance = new System.Windows.Forms.Button();
            this.btnConfirmPresence = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeColumns = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Denomination,
            this.numbersOfPeriodes,
            this.endOn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents.Location = new System.Drawing.Point(50, 153);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(573, 261);
            this.dgvStudents.TabIndex = 14;
            this.dgvStudents.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvStudents_CellBeginEdit);
            this.dgvStudents.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudents_CellMouseClick);
            this.dgvStudents.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellValueChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
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
            this.endOn.HeaderText = "Present";
            this.endOn.Name = "endOn";
            this.endOn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endOn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblTeachingUnit
            // 
            this.lblTeachingUnit.AutoSize = true;
            this.lblTeachingUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachingUnit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTeachingUnit.Location = new System.Drawing.Point(46, 91);
            this.lblTeachingUnit.Name = "lblTeachingUnit";
            this.lblTeachingUnit.Size = new System.Drawing.Size(186, 20);
            this.lblTeachingUnit.TabIndex = 18;
            this.lblTeachingUnit.Text = "Select Teaching Unit :";
            this.lblTeachingUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpSelectDateOfPresence
            // 
            this.dtpSelectDateOfPresence.Location = new System.Drawing.Point(419, 94);
            this.dtpSelectDateOfPresence.Name = "dtpSelectDateOfPresence";
            this.dtpSelectDateOfPresence.Size = new System.Drawing.Size(204, 20);
            this.dtpSelectDateOfPresence.TabIndex = 25;
            // 
            // cbTeachingUnit
            // 
            this.cbTeachingUnit.FormattingEnabled = true;
            this.cbTeachingUnit.Location = new System.Drawing.Point(238, 93);
            this.cbTeachingUnit.Name = "cbTeachingUnit";
            this.cbTeachingUnit.Size = new System.Drawing.Size(175, 21);
            this.cbTeachingUnit.TabIndex = 26;
            this.cbTeachingUnit.SelectedIndexChanged += new System.EventHandler(this.cbTeachingUnit_SelectedIndexChanged);
            // 
            // btnFindAttendance
            // 
            this.btnFindAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnFindAttendance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnFindAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnFindAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnFindAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindAttendance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFindAttendance.Location = new System.Drawing.Point(629, 90);
            this.btnFindAttendance.Name = "btnFindAttendance";
            this.btnFindAttendance.Size = new System.Drawing.Size(103, 27);
            this.btnFindAttendance.TabIndex = 32;
            this.btnFindAttendance.Text = "Find";
            this.btnFindAttendance.UseVisualStyleBackColor = false;
            this.btnFindAttendance.Visible = false;
            this.btnFindAttendance.Click += new System.EventHandler(this.btnFindAttendance_Click);
            // 
            // btnConfirmPresence
            // 
            this.btnConfirmPresence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnConfirmPresence.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnConfirmPresence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnConfirmPresence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnConfirmPresence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPresence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPresence.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmPresence.Location = new System.Drawing.Point(629, 153);
            this.btnConfirmPresence.Name = "btnConfirmPresence";
            this.btnConfirmPresence.Size = new System.Drawing.Size(103, 27);
            this.btnConfirmPresence.TabIndex = 33;
            this.btnConfirmPresence.Text = "Confirm Presence";
            this.btnConfirmPresence.UseVisualStyleBackColor = false;
            this.btnConfirmPresence.Visible = false;
            this.btnConfirmPresence.Click += new System.EventHandler(this.btnConfirmPresence_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 27);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirmPresence);
            this.Controls.Add(this.btnFindAttendance);
            this.Controls.Add(this.cbTeachingUnit);
            this.Controls.Add(this.dtpSelectDateOfPresence);
            this.Controls.Add(this.lblTeachingUnit);
            this.Controls.Add(this.dgvStudents);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATTENDANCE MANAGER";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblTeachingUnit;
        private System.Windows.Forms.DateTimePicker dtpSelectDateOfPresence;
        private System.Windows.Forms.ComboBox cbTeachingUnit;
        private System.Windows.Forms.Button btnFindAttendance;
        private System.Windows.Forms.Button btnConfirmPresence;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersOfPeriodes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn endOn;
    }
}