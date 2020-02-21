namespace Insta_WF_Ecommerce
{
    partial class SupplierForm
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
            this.tNumber = new System.Windows.Forms.TextBox();
            this.tSocialR = new System.Windows.Forms.TextBox();
            this.tSiretN = new System.Windows.Forms.TextBox();
            this.tRcsNumber = new System.Windows.Forms.TextBox();
            this.tAddress = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txTSupplierName = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tNumber
            // 
            this.tNumber.Location = new System.Drawing.Point(323, 234);
            this.tNumber.Name = "tNumber";
            this.tNumber.Size = new System.Drawing.Size(215, 20);
            this.tNumber.TabIndex = 2;
            // 
            // tSocialR
            // 
            this.tSocialR.Location = new System.Drawing.Point(323, 323);
            this.tSocialR.Name = "tSocialR";
            this.tSocialR.Size = new System.Drawing.Size(215, 20);
            this.tSocialR.TabIndex = 3;
            // 
            // tSiretN
            // 
            this.tSiretN.Location = new System.Drawing.Point(323, 366);
            this.tSiretN.Name = "tSiretN";
            this.tSiretN.Size = new System.Drawing.Size(215, 20);
            this.tSiretN.TabIndex = 4;
            // 
            // tRcsNumber
            // 
            this.tRcsNumber.Location = new System.Drawing.Point(323, 405);
            this.tRcsNumber.Name = "tRcsNumber";
            this.tRcsNumber.Size = new System.Drawing.Size(215, 20);
            this.tRcsNumber.TabIndex = 5;
            // 
            // tAddress
            // 
            this.tAddress.Location = new System.Drawing.Point(323, 182);
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(215, 20);
            this.tAddress.TabIndex = 7;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(323, 280);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(215, 20);
            this.tEmail.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddSupplier);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "RCS Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Siret Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tel Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Social Reason";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "Supplier Form";
            // 
            // txTSupplierName
            // 
            this.txTSupplierName.AutoSize = true;
            this.txTSupplierName.Location = new System.Drawing.Point(231, 127);
            this.txTSupplierName.Name = "txTSupplierName";
            this.txTSupplierName.Size = new System.Drawing.Size(35, 13);
            this.txTSupplierName.TabIndex = 11;
            this.txTSupplierName.Text = "Name";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(323, 124);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(215, 20);
            this.tName.TabIndex = 0;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txTSupplierName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tAddress);
            this.Controls.Add(this.tRcsNumber);
            this.Controls.Add(this.tSiretN);
            this.Controls.Add(this.tSocialR);
            this.Controls.Add(this.tNumber);
            this.Controls.Add(this.tName);
            this.Name = "SupplierForm";
            this.Text = "Supplier Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tNumber;
        private System.Windows.Forms.TextBox tSocialR;
        private System.Windows.Forms.TextBox tSiretN;
        private System.Windows.Forms.TextBox tRcsNumber;
        private System.Windows.Forms.TextBox tAddress;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txTSupplierName;
        private System.Windows.Forms.TextBox tName;
    }
}