namespace Gestion_d_abscence
{
    partial class frmTeachingUnit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeachingUnit));
            this.lblAllTeachingUnit = new System.Windows.Forms.Label();
            this.dgvUt = new System.Windows.Forms.DataGridView();
            this.Denomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersOfPeriodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decisive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNotFound = new System.Windows.Forms.Label();
            this.txbFindById = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnModifierUt = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblCrudMessage = new System.Windows.Forms.Label();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.btnTogglePasswordView = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUt)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAllTeachingUnit
            // 
            this.lblAllTeachingUnit.AutoSize = true;
            this.lblAllTeachingUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTeachingUnit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAllTeachingUnit.Location = new System.Drawing.Point(275, 30);
            this.lblAllTeachingUnit.Name = "lblAllTeachingUnit";
            this.lblAllTeachingUnit.Size = new System.Drawing.Size(237, 20);
            this.lblAllTeachingUnit.TabIndex = 1;
            this.lblAllTeachingUnit.Text = "2020-2021 TEACHING UNIT";
            // 
            // dgvUt
            // 
            this.dgvUt.AllowUserToAddRows = false;
            this.dgvUt.AllowUserToDeleteRows = false;
            this.dgvUt.AllowUserToResizeColumns = false;
            this.dgvUt.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvUt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denomination,
            this.numbersOfPeriodes,
            this.startOn,
            this.endOn,
            this.Decisive,
            this.Teacher});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUt.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUt.Location = new System.Drawing.Point(28, 158);
            this.dgvUt.Name = "dgvUt";
            this.dgvUt.ReadOnly = true;
            this.dgvUt.Size = new System.Drawing.Size(742, 261);
            this.dgvUt.TabIndex = 2;
            this.dgvUt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUt_CellContentClick);
            this.dgvUt.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUt_CellMouseClick);
            // 
            // Denomination
            // 
            this.Denomination.HeaderText = "Denomination";
            this.Denomination.Name = "Denomination";
            this.Denomination.ReadOnly = true;
            // 
            // numbersOfPeriodes
            // 
            this.numbersOfPeriodes.HeaderText = "Numbers of periodes";
            this.numbersOfPeriodes.Name = "numbersOfPeriodes";
            this.numbersOfPeriodes.ReadOnly = true;
            // 
            // startOn
            // 
            this.startOn.HeaderText = "Start on";
            this.startOn.Name = "startOn";
            this.startOn.ReadOnly = true;
            // 
            // endOn
            // 
            this.endOn.HeaderText = "End on";
            this.endOn.Name = "endOn";
            this.endOn.ReadOnly = true;
            // 
            // Decisive
            // 
            this.Decisive.HeaderText = "Decisive";
            this.Decisive.Name = "Decisive";
            this.Decisive.ReadOnly = true;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Teacher";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            // 
            // lblNotFound
            // 
            this.lblNotFound.AutoSize = true;
            this.lblNotFound.ForeColor = System.Drawing.Color.Red;
            this.lblNotFound.Location = new System.Drawing.Point(630, 136);
            this.lblNotFound.Name = "lblNotFound";
            this.lblNotFound.Size = new System.Drawing.Size(57, 13);
            this.lblNotFound.TabIndex = 4;
            this.lblNotFound.Text = "Not Match";
            this.lblNotFound.Visible = false;
            // 
            // txbFindById
            // 
            this.txbFindById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txbFindById.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFindById.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFindById.ForeColor = System.Drawing.Color.Snow;
            this.txbFindById.Location = new System.Drawing.Point(51, 7);
            this.txbFindById.MaxLength = 20;
            this.txbFindById.Name = "txbFindById";
            this.txbFindById.Size = new System.Drawing.Size(215, 22);
            this.txbFindById.TabIndex = 1;
            this.txbFindById.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbFindById_MouseClick_1);
            this.txbFindById.TextChanged += new System.EventHandler(this.txbFindById_TextChanged_1);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlLogin.Controls.Add(this.txbFindById);
            this.pnlLogin.Location = new System.Drawing.Point(493, 92);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(277, 37);
            this.pnlLogin.TabIndex = 8;
            // 
            // btnModifierUt
            // 
            this.btnModifierUt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnModifierUt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnModifierUt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnModifierUt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnModifierUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierUt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModifierUt.Location = new System.Drawing.Point(28, 96);
            this.btnModifierUt.Name = "btnModifierUt";
            this.btnModifierUt.Size = new System.Drawing.Size(103, 33);
            this.btnModifierUt.TabIndex = 9;
            this.btnModifierUt.Text = "Modify";
            this.btnModifierUt.UseVisualStyleBackColor = false;
            this.btnModifierUt.Visible = false;
            this.btnModifierUt.Click += new System.EventHandler(this.btnModifierUt_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSupprimer.Location = new System.Drawing.Point(137, 96);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(103, 33);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Delete";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Visible = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblCrudMessage
            // 
            this.lblCrudMessage.AutoSize = true;
            this.lblCrudMessage.ForeColor = System.Drawing.Color.Red;
            this.lblCrudMessage.Location = new System.Drawing.Point(370, 136);
            this.lblCrudMessage.Name = "lblCrudMessage";
            this.lblCrudMessage.Size = new System.Drawing.Size(73, 13);
            this.lblCrudMessage.TabIndex = 11;
            this.lblCrudMessage.Text = "crud message";
            this.lblCrudMessage.Visible = false;
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnShowStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnShowStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnShowStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnShowStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStudents.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowStudents.Location = new System.Drawing.Point(246, 96);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(103, 33);
            this.btnShowStudents.TabIndex = 12;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = false;
            this.btnShowStudents.Visible = false;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddUnit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAddUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddUnit.Location = new System.Drawing.Point(667, 30);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(103, 33);
            this.btnAddUnit.TabIndex = 13;
            this.btnAddUnit.Text = "Add Unit";
            this.btnAddUnit.UseVisualStyleBackColor = false;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // btnTogglePasswordView
            // 
            this.btnTogglePasswordView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnTogglePasswordView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTogglePasswordView.BackgroundImage")));
            this.btnTogglePasswordView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTogglePasswordView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTogglePasswordView.FlatAppearance.BorderSize = 0;
            this.btnTogglePasswordView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnTogglePasswordView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnTogglePasswordView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePasswordView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTogglePasswordView.Location = new System.Drawing.Point(498, 96);
            this.btnTogglePasswordView.Name = "btnTogglePasswordView";
            this.btnTogglePasswordView.Padding = new System.Windows.Forms.Padding(5);
            this.btnTogglePasswordView.Size = new System.Drawing.Size(31, 28);
            this.btnTogglePasswordView.TabIndex = 14;
            this.btnTogglePasswordView.UseVisualStyleBackColor = false;
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
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmTeachingUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTogglePasswordView);
            this.Controls.Add(this.btnAddUnit);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.lblCrudMessage);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifierUt);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.lblNotFound);
            this.Controls.Add(this.dgvUt);
            this.Controls.Add(this.lblAllTeachingUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTeachingUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEACHING UNIT";
            this.Load += new System.EventHandler(this.frmTeachingUnit_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmTeachingUnit_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUt)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAllTeachingUnit;
        private System.Windows.Forms.DataGridView dgvUt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersOfPeriodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn startOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decisive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.Label lblNotFound;
        private System.Windows.Forms.TextBox txbFindById;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnModifierUt;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblCrudMessage;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.Button btnTogglePasswordView;
        private System.Windows.Forms.Button btnBack;
    }
}