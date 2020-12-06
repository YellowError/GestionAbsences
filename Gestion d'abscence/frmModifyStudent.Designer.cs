namespace Gestion_d_abscence
{
    partial class frmModifyStudent
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirsName = new System.Windows.Forms.Label();
            this.pnlNumberOfPeriode = new System.Windows.Forms.Panel();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.pnlDenomination = new System.Windows.Forms.Panel();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.lblTotalAbscense = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTotalAbsence = new System.Windows.Forms.TextBox();
            this.pnlNumberOfPeriode.SuspendLayout();
            this.pnlDenomination.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "<";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(192, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 20);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Name of student";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModify.Location = new System.Drawing.Point(311, 226);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(103, 33);
            this.btnModify.TabIndex = 31;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLastName.Location = new System.Drawing.Point(57, 183);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 20);
            this.lblLastName.TabIndex = 26;
            this.lblLastName.Text = "LastName";
            // 
            // lblFirsName
            // 
            this.lblFirsName.AutoSize = true;
            this.lblFirsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirsName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFirsName.Location = new System.Drawing.Point(57, 137);
            this.lblFirsName.Name = "lblFirsName";
            this.lblFirsName.Size = new System.Drawing.Size(82, 20);
            this.lblFirsName.TabIndex = 25;
            this.lblFirsName.Text = "FirstName";
            // 
            // pnlNumberOfPeriode
            // 
            this.pnlNumberOfPeriode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlNumberOfPeriode.Controls.Add(this.txbLastName);
            this.pnlNumberOfPeriode.Location = new System.Drawing.Point(184, 173);
            this.pnlNumberOfPeriode.Name = "pnlNumberOfPeriode";
            this.pnlNumberOfPeriode.Size = new System.Drawing.Size(230, 37);
            this.pnlNumberOfPeriode.TabIndex = 23;
            // 
            // txbLastName
            // 
            this.txbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLastName.ForeColor = System.Drawing.Color.Snow;
            this.txbLastName.Location = new System.Drawing.Point(12, 7);
            this.txbLastName.MaxLength = 20;
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(215, 22);
            this.txbLastName.TabIndex = 1;
            this.txbLastName.TextChanged += new System.EventHandler(this.txbLastName_TextChanged);
            // 
            // pnlDenomination
            // 
            this.pnlDenomination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlDenomination.Controls.Add(this.txbFirstName);
            this.pnlDenomination.Location = new System.Drawing.Point(184, 130);
            this.pnlDenomination.Name = "pnlDenomination";
            this.pnlDenomination.Size = new System.Drawing.Size(230, 37);
            this.pnlDenomination.TabIndex = 24;
            // 
            // txbFirstName
            // 
            this.txbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFirstName.ForeColor = System.Drawing.Color.Snow;
            this.txbFirstName.Location = new System.Drawing.Point(12, 7);
            this.txbFirstName.MaxLength = 20;
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(215, 22);
            this.txbFirstName.TabIndex = 1;
            this.txbFirstName.TextChanged += new System.EventHandler(this.txbFirstName_TextChanged);
            // 
            // lblTotalAbscense
            // 
            this.lblTotalAbscense.AutoSize = true;
            this.lblTotalAbscense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAbscense.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalAbscense.Location = new System.Drawing.Point(57, 226);
            this.lblTotalAbscense.Name = "lblTotalAbscense";
            this.lblTotalAbscense.Size = new System.Drawing.Size(111, 20);
            this.lblTotalAbscense.TabIndex = 36;
            this.lblTotalAbscense.Text = "Total Absence";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.txbTotalAbsence);
            this.panel1.Location = new System.Drawing.Point(184, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 37);
            this.panel1.TabIndex = 35;
            // 
            // txbTotalAbsence
            // 
            this.txbTotalAbsence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txbTotalAbsence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTotalAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalAbsence.ForeColor = System.Drawing.Color.Snow;
            this.txbTotalAbsence.Location = new System.Drawing.Point(12, 7);
            this.txbTotalAbsence.MaxLength = 20;
            this.txbTotalAbsence.Name = "txbTotalAbsence";
            this.txbTotalAbsence.Size = new System.Drawing.Size(50, 22);
            this.txbTotalAbsence.TabIndex = 1;
            this.txbTotalAbsence.TextChanged += new System.EventHandler(this.txbTotalAbsence_TextChanged);
            // 
            // frmModifyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.lblTotalAbscense);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirsName);
            this.Controls.Add(this.pnlNumberOfPeriode);
            this.Controls.Add(this.pnlDenomination);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifyStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifyStudent";
            this.Load += new System.EventHandler(this.frmModifyStudent_Load);
            this.pnlNumberOfPeriode.ResumeLayout(false);
            this.pnlNumberOfPeriode.PerformLayout();
            this.pnlDenomination.ResumeLayout(false);
            this.pnlDenomination.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirsName;
        private System.Windows.Forms.Panel pnlNumberOfPeriode;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Panel pnlDenomination;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label lblTotalAbscense;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTotalAbsence;
    }
}