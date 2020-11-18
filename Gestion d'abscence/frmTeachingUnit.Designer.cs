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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvUt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denomination,
            this.numbersOfPeriodes,
            this.startOn,
            this.endOn,
            this.Decisive,
            this.Teacher});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUt.Location = new System.Drawing.Point(28, 158);
            this.dgvUt.Name = "dgvUt";
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
            this.lblNotFound.Location = new System.Drawing.Point(537, 136);
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
            this.txbFindById.Location = new System.Drawing.Point(12, 7);
            this.txbFindById.MaxLength = 20;
            this.txbFindById.Name = "txbFindById";
            this.txbFindById.Size = new System.Drawing.Size(215, 22);
            this.txbFindById.TabIndex = 1;
            this.txbFindById.TextChanged += new System.EventHandler(this.txbFindById_TextChanged_1);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlLogin.Controls.Add(this.txbFindById);
            this.pnlLogin.Location = new System.Drawing.Point(540, 96);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(230, 37);
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
            this.btnModifierUt.Text = "Modifier";
            this.btnModifierUt.UseVisualStyleBackColor = false;
            this.btnModifierUt.Visible = false;
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
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Visible = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblCrudMessage
            // 
            this.lblCrudMessage.AutoSize = true;
            this.lblCrudMessage.ForeColor = System.Drawing.Color.Red;
            this.lblCrudMessage.Location = new System.Drawing.Point(246, 106);
            this.lblCrudMessage.Name = "lblCrudMessage";
            this.lblCrudMessage.Size = new System.Drawing.Size(73, 13);
            this.lblCrudMessage.TabIndex = 11;
            this.lblCrudMessage.Text = "crud message";
            this.lblCrudMessage.Visible = false;
            // 
            // frmTeachingUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}