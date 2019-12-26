namespace ResManaged3.UI.Elements
{
    partial class OrderPalette
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.pnlDiv1 = new System.Windows.Forms.Panel();
            this.lblBill = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDiv2 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAddPhn = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.pnlBottom2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 255);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(700, 1);
            this.pnlBottom.TabIndex = 0;
            // 
            // lblOrderID
            // 
            this.lblOrderID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrderID.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOrderID.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOrderID.Location = new System.Drawing.Point(0, 1);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(111, 254);
            this.lblOrderID.TabIndex = 2;
            this.lblOrderID.Text = "label1";
            this.lblOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBill);
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(111, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 33);
            this.panel1.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(158)))), ((int)(((byte)(251)))));
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(440, 0);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(149, 33);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(61)))));
            this.btnReject.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(269, 0);
            this.btnReject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(154, 33);
            this.btnReject.TabIndex = 6;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.BtnReject_Click);
            // 
            // pnlDiv1
            // 
            this.pnlDiv1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDiv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDiv1.Location = new System.Drawing.Point(111, 221);
            this.pnlDiv1.Name = "pnlDiv1";
            this.pnlDiv1.Size = new System.Drawing.Size(589, 1);
            this.pnlDiv1.TabIndex = 5;
            // 
            // lblBill
            // 
            this.lblBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBill.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBill.Location = new System.Drawing.Point(0, 0);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(269, 33);
            this.lblBill.TabIndex = 7;
            this.lblBill.Text = "label2";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAddPhn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(111, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 69);
            this.panel2.TabIndex = 6;
            // 
            // pnlDiv2
            // 
            this.pnlDiv2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDiv2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDiv2.Location = new System.Drawing.Point(111, 151);
            this.pnlDiv2.Name = "pnlDiv2";
            this.pnlDiv2.Size = new System.Drawing.Size(589, 1);
            this.pnlDiv2.TabIndex = 7;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(700, 1);
            this.pnlTop.TabIndex = 9;
            // 
            // lblAddPhn
            // 
            this.lblAddPhn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddPhn.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPhn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddPhn.Location = new System.Drawing.Point(0, 0);
            this.lblAddPhn.Name = "lblAddPhn";
            this.lblAddPhn.Size = new System.Drawing.Size(589, 69);
            this.lblAddPhn.TabIndex = 11;
            this.lblAddPhn.Text = "label4";
            // 
            // lblItems
            // 
            this.lblItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItems.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItems.Location = new System.Drawing.Point(111, 1);
            this.lblItems.Name = "lblItems";
            this.lblItems.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblItems.Size = new System.Drawing.Size(589, 150);
            this.lblItems.TabIndex = 12;
            this.lblItems.Text = "label3";
            // 
            // pnlBottom2
            // 
            this.pnlBottom2.BackColor = System.Drawing.Color.White;
            this.pnlBottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom2.Location = new System.Drawing.Point(0, 256);
            this.pnlBottom2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBottom2.Name = "pnlBottom2";
            this.pnlBottom2.Size = new System.Drawing.Size(700, 15);
            this.pnlBottom2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 33);
            this.label5.TabIndex = 8;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderPalette
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.pnlDiv2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDiv1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlBottom2);
            this.Controls.Add(this.pnlTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OrderPalette";
            this.Size = new System.Drawing.Size(700, 271);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Panel pnlDiv1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAddPhn;
        private System.Windows.Forms.Panel pnlDiv2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Panel pnlBottom2;
        private System.Windows.Forms.Label label5;
    }
}
