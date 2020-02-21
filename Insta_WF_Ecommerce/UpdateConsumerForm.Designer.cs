namespace Insta_WF_Ecommerce
{
    partial class UpdateConsumerForm
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
            this.uLastname = new System.Windows.Forms.TextBox();
            this.uDelivery = new System.Windows.Forms.TextBox();
            this.uBillingAddress = new System.Windows.Forms.TextBox();
            this.uFirstname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uLastname
            // 
            this.uLastname.Location = new System.Drawing.Point(304, 109);
            this.uLastname.Name = "uLastname";
            this.uLastname.Size = new System.Drawing.Size(178, 20);
            this.uLastname.TabIndex = 0;
            // 
            // uDelivery
            // 
            this.uDelivery.Location = new System.Drawing.Point(304, 203);
            this.uDelivery.Name = "uDelivery";
            this.uDelivery.Size = new System.Drawing.Size(178, 20);
            this.uDelivery.TabIndex = 1;
            // 
            // uBillingAddress
            // 
            this.uBillingAddress.Location = new System.Drawing.Point(304, 255);
            this.uBillingAddress.Name = "uBillingAddress";
            this.uBillingAddress.Size = new System.Drawing.Size(178, 20);
            this.uBillingAddress.TabIndex = 2;
            // 
            // uFirstname
            // 
            this.uFirstname.Location = new System.Drawing.Point(304, 155);
            this.uFirstname.Name = "uFirstname";
            this.uFirstname.Size = new System.Drawing.Size(178, 20);
            this.uFirstname.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delivery Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Billing Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lastname";
            // 
            // UpdateConsumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uFirstname);
            this.Controls.Add(this.uBillingAddress);
            this.Controls.Add(this.uDelivery);
            this.Controls.Add(this.uLastname);
            this.Name = "UpdateConsumerForm";
            this.Text = "UpdateConsumerForm";
            this.Load += new System.EventHandler(this.UpdateConsumerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uLastname;
        private System.Windows.Forms.TextBox uDelivery;
        private System.Windows.Forms.TextBox uBillingAddress;
        private System.Windows.Forms.TextBox uFirstname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}