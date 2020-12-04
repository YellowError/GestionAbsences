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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudentsByUt = new System.Windows.Forms.DataGridView();
            this.Denomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersOfPeriodes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddStudentByUe = new System.Windows.Forms.Button();
            this.btnDeleteStudentByUe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsByUt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentsByUt
            // 
            this.dgvStudentsByUt.AllowUserToAddRows = false;
            this.dgvStudentsByUt.AllowUserToDeleteRows = false;
            this.dgvStudentsByUt.AllowUserToResizeColumns = false;
            this.dgvStudentsByUt.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudentsByUt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudentsByUt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentsByUt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgvStudentsByUt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudentsByUt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsByUt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudentsByUt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsByUt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denomination,
            this.numbersOfPeriodes,
            this.startOn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentsByUt.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStudentsByUt.Location = new System.Drawing.Point(35, 76);
            this.dgvStudentsByUt.Name = "dgvStudentsByUt";
            this.dgvStudentsByUt.Size = new System.Drawing.Size(395, 486);
            this.dgvStudentsByUt.TabIndex = 3;
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
            // AddStudentByUe
            // 
            this.AddStudentByUe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.AddStudentByUe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.AddStudentByUe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.AddStudentByUe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.AddStudentByUe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentByUe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddStudentByUe.Location = new System.Drawing.Point(35, 26);
            this.AddStudentByUe.Name = "AddStudentByUe";
            this.AddStudentByUe.Size = new System.Drawing.Size(103, 33);
            this.AddStudentByUe.TabIndex = 10;
            this.AddStudentByUe.Text = "Add Student";
            this.AddStudentByUe.UseVisualStyleBackColor = false;
            this.AddStudentByUe.Visible = false;
            // 
            // btnDeleteStudentByUe
            // 
            this.btnDeleteStudentByUe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDeleteStudentByUe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDeleteStudentByUe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDeleteStudentByUe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteStudentByUe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudentByUe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteStudentByUe.Location = new System.Drawing.Point(154, 26);
            this.btnDeleteStudentByUe.Name = "btnDeleteStudentByUe";
            this.btnDeleteStudentByUe.Size = new System.Drawing.Size(103, 33);
            this.btnDeleteStudentByUe.TabIndex = 11;
            this.btnDeleteStudentByUe.Text = "Delete";
            this.btnDeleteStudentByUe.UseVisualStyleBackColor = false;
            this.btnDeleteStudentByUe.Visible = false;
            // 
            // frmShowStudentsByUe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(541, 607);
            this.Controls.Add(this.btnDeleteStudentByUe);
            this.Controls.Add(this.AddStudentByUe);
            this.Controls.Add(this.dgvStudentsByUt);
            this.Name = "frmShowStudentsByUe";
            this.Text = "frmShowStudentsByUe";
            this.Load += new System.EventHandler(this.frmShowStudentsByUe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsByUt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentsByUt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersOfPeriodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn startOn;
        private System.Windows.Forms.Button AddStudentByUe;
        private System.Windows.Forms.Button btnDeleteStudentByUe;
    }
}