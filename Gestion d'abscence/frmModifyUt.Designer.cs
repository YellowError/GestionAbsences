namespace Gestion_d_abscence
{
    partial class frmModifyUt
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
            this.pnlDenomination = new System.Windows.Forms.Panel();
            this.txbDenomination = new System.Windows.Forms.TextBox();
            this.pnlNumberOfPeriode = new System.Windows.Forms.Panel();
            this.txbNumberOfPeriode = new System.Windows.Forms.TextBox();
            this.pnlTeacher = new System.Windows.Forms.Panel();
            this.txbTeacher = new System.Windows.Forms.TextBox();
            this.lblDenomination = new System.Windows.Forms.Label();
            this.lblNumberOfPeriods = new System.Windows.Forms.Label();
            this.lblStartOn = new System.Windows.Forms.Label();
            this.lblEndOn = new System.Windows.Forms.Label();
            this.lblDecisive = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chbDecisive = new System.Windows.Forms.CheckBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dtpStartOn = new System.Windows.Forms.DateTimePicker();
            this.dtpEndOn = new System.Windows.Forms.DateTimePicker();
            this.pnlDenomination.SuspendLayout();
            this.pnlNumberOfPeriode.SuspendLayout();
            this.pnlTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDenomination
            // 
            this.pnlDenomination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlDenomination.Controls.Add(this.txbDenomination);
            this.pnlDenomination.Location = new System.Drawing.Point(189, 126);
            this.pnlDenomination.Name = "pnlDenomination";
            this.pnlDenomination.Size = new System.Drawing.Size(230, 37);
            this.pnlDenomination.TabIndex = 9;
            // 
            // txbDenomination
            // 
            this.txbDenomination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txbDenomination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDenomination.ForeColor = System.Drawing.Color.Snow;
            this.txbDenomination.Location = new System.Drawing.Point(12, 7);
            this.txbDenomination.MaxLength = 20;
            this.txbDenomination.Name = "txbDenomination";
            this.txbDenomination.Size = new System.Drawing.Size(215, 22);
            this.txbDenomination.TabIndex = 1;
            this.txbDenomination.TextChanged += new System.EventHandler(this.txbDenomination_TextChanged);
            // 
            // pnlNumberOfPeriode
            // 
            this.pnlNumberOfPeriode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlNumberOfPeriode.Controls.Add(this.txbNumberOfPeriode);
            this.pnlNumberOfPeriode.Location = new System.Drawing.Point(189, 169);
            this.pnlNumberOfPeriode.Name = "pnlNumberOfPeriode";
            this.pnlNumberOfPeriode.Size = new System.Drawing.Size(230, 37);
            this.pnlNumberOfPeriode.TabIndex = 9;
            // 
            // txbNumberOfPeriode
            // 
            this.txbNumberOfPeriode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txbNumberOfPeriode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNumberOfPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumberOfPeriode.ForeColor = System.Drawing.Color.Snow;
            this.txbNumberOfPeriode.Location = new System.Drawing.Point(12, 7);
            this.txbNumberOfPeriode.MaxLength = 20;
            this.txbNumberOfPeriode.Name = "txbNumberOfPeriode";
            this.txbNumberOfPeriode.Size = new System.Drawing.Size(215, 22);
            this.txbNumberOfPeriode.TabIndex = 1;
            this.txbNumberOfPeriode.TextChanged += new System.EventHandler(this.txbNumberOfPeriode_TextChanged);
            // 
            // pnlTeacher
            // 
            this.pnlTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlTeacher.Controls.Add(this.txbTeacher);
            this.pnlTeacher.Location = new System.Drawing.Point(189, 341);
            this.pnlTeacher.Name = "pnlTeacher";
            this.pnlTeacher.Size = new System.Drawing.Size(230, 37);
            this.pnlTeacher.TabIndex = 9;
            // 
            // txbTeacher
            // 
            this.txbTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txbTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTeacher.ForeColor = System.Drawing.Color.Snow;
            this.txbTeacher.Location = new System.Drawing.Point(12, 7);
            this.txbTeacher.MaxLength = 20;
            this.txbTeacher.Name = "txbTeacher";
            this.txbTeacher.Size = new System.Drawing.Size(215, 22);
            this.txbTeacher.TabIndex = 1;
            this.txbTeacher.TextChanged += new System.EventHandler(this.txbTeacher_TextChanged);
            // 
            // lblDenomination
            // 
            this.lblDenomination.AutoSize = true;
            this.lblDenomination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenomination.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDenomination.Location = new System.Drawing.Point(62, 133);
            this.lblDenomination.Name = "lblDenomination";
            this.lblDenomination.Size = new System.Drawing.Size(108, 20);
            this.lblDenomination.TabIndex = 10;
            this.lblDenomination.Text = "Denomination";
            // 
            // lblNumberOfPeriods
            // 
            this.lblNumberOfPeriods.AutoSize = true;
            this.lblNumberOfPeriods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPeriods.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumberOfPeriods.Location = new System.Drawing.Point(62, 179);
            this.lblNumberOfPeriods.Name = "lblNumberOfPeriods";
            this.lblNumberOfPeriods.Size = new System.Drawing.Size(103, 20);
            this.lblNumberOfPeriods.TabIndex = 11;
            this.lblNumberOfPeriods.Text = "Nb of periods";
            // 
            // lblStartOn
            // 
            this.lblStartOn.AutoSize = true;
            this.lblStartOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartOn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStartOn.Location = new System.Drawing.Point(62, 222);
            this.lblStartOn.Name = "lblStartOn";
            this.lblStartOn.Size = new System.Drawing.Size(66, 20);
            this.lblStartOn.TabIndex = 12;
            this.lblStartOn.Text = "Start on";
            // 
            // lblEndOn
            // 
            this.lblEndOn.AutoSize = true;
            this.lblEndOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndOn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndOn.Location = new System.Drawing.Point(62, 265);
            this.lblEndOn.Name = "lblEndOn";
            this.lblEndOn.Size = new System.Drawing.Size(60, 20);
            this.lblEndOn.TabIndex = 13;
            this.lblEndOn.Text = "End on";
            // 
            // lblDecisive
            // 
            this.lblDecisive.AutoSize = true;
            this.lblDecisive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecisive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDecisive.Location = new System.Drawing.Point(62, 308);
            this.lblDecisive.Name = "lblDecisive";
            this.lblDecisive.Size = new System.Drawing.Size(68, 20);
            this.lblDecisive.TabIndex = 14;
            this.lblDecisive.Text = "Decisive";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTeacher.Location = new System.Drawing.Point(62, 351);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(67, 20);
            this.lblTeacher.TabIndex = 15;
            this.lblTeacher.Text = "Teacher";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModify.Location = new System.Drawing.Point(313, 410);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(103, 33);
            this.btnModify.TabIndex = 16;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(232, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 20);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "title of ut";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbDecisive
            // 
            this.chbDecisive.AutoSize = true;
            this.chbDecisive.Location = new System.Drawing.Point(201, 313);
            this.chbDecisive.Name = "chbDecisive";
            this.chbDecisive.Size = new System.Drawing.Size(15, 14);
            this.chbDecisive.TabIndex = 18;
            this.chbDecisive.UseVisualStyleBackColor = true;
            this.chbDecisive.CheckedChanged += new System.EventHandler(this.chbDecisive_CheckedChanged);
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
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "<";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpStartOn
            // 
            this.dtpStartOn.Location = new System.Drawing.Point(189, 221);
            this.dtpStartOn.Name = "dtpStartOn";
            this.dtpStartOn.Size = new System.Drawing.Size(230, 20);
            this.dtpStartOn.TabIndex = 20;
            this.dtpStartOn.ValueChanged += new System.EventHandler(this.dtpStartOn_ValueChanged);
            // 
            // dtpEndOn
            // 
            this.dtpEndOn.Location = new System.Drawing.Point(189, 265);
            this.dtpEndOn.Name = "dtpEndOn";
            this.dtpEndOn.Size = new System.Drawing.Size(230, 20);
            this.dtpEndOn.TabIndex = 21;
            this.dtpEndOn.ValueChanged += new System.EventHandler(this.dtpEndOn_ValueChanged);
            // 
            // frmModifyUt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(547, 569);
            this.Controls.Add(this.dtpEndOn);
            this.Controls.Add(this.dtpStartOn);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.chbDecisive);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblDecisive);
            this.Controls.Add(this.lblEndOn);
            this.Controls.Add(this.lblStartOn);
            this.Controls.Add(this.lblNumberOfPeriods);
            this.Controls.Add(this.lblDenomination);
            this.Controls.Add(this.pnlTeacher);
            this.Controls.Add(this.pnlNumberOfPeriode);
            this.Controls.Add(this.pnlDenomination);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModifyUt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifyUt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModifyUt_FormClosed);
            this.Load += new System.EventHandler(this.frmModifyUt_Load);
            this.pnlDenomination.ResumeLayout(false);
            this.pnlDenomination.PerformLayout();
            this.pnlNumberOfPeriode.ResumeLayout(false);
            this.pnlNumberOfPeriode.PerformLayout();
            this.pnlTeacher.ResumeLayout(false);
            this.pnlTeacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDenomination;
        private System.Windows.Forms.TextBox txbDenomination;
        private System.Windows.Forms.Panel pnlNumberOfPeriode;
        private System.Windows.Forms.TextBox txbNumberOfPeriode;
        private System.Windows.Forms.Panel pnlTeacher;
        private System.Windows.Forms.TextBox txbTeacher;
        private System.Windows.Forms.Label lblDenomination;
        private System.Windows.Forms.Label lblNumberOfPeriods;
        private System.Windows.Forms.Label lblStartOn;
        private System.Windows.Forms.Label lblEndOn;
        private System.Windows.Forms.Label lblDecisive;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chbDecisive;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dtpStartOn;
        private System.Windows.Forms.DateTimePicker dtpEndOn;
    }
}