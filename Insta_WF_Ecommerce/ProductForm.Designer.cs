namespace Insta_WF_Ecommerce
{
    partial class FormProduct
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cBSupplier = new System.Windows.Forms.ComboBox();
            this.cBTyreType = new System.Windows.Forms.ComboBox();
            this.cBDrawingType = new System.Windows.Forms.ComboBox();
            this.cBBrand = new System.Windows.Forms.ComboBox();
            this.txTQuantity = new System.Windows.Forms.TextBox();
            this.txTUVPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txTUAPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txTReference = new System.Windows.Forms.TextBox();
            this.cBSeason = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier";
            // 
            // cBSupplier
            // 
            this.cBSupplier.FormattingEnabled = true;
            this.cBSupplier.Location = new System.Drawing.Point(363, 110);
            this.cBSupplier.Name = "cBSupplier";
            this.cBSupplier.Size = new System.Drawing.Size(186, 21);
            this.cBSupplier.TabIndex = 1;
            this.cBSupplier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBSupplier_MouseClick);
            // 
            // cBTyreType
            // 
            this.cBTyreType.FormattingEnabled = true;
            this.cBTyreType.Items.AddRange(new object[] {
            "All season",
            "Summer",
            "Budget",
            "Run flat",
            "Energy Saving",
            "High Performance"});
            this.cBTyreType.Location = new System.Drawing.Point(363, 237);
            this.cBTyreType.Name = "cBTyreType";
            this.cBTyreType.Size = new System.Drawing.Size(186, 21);
            this.cBTyreType.TabIndex = 2;
            // 
            // cBDrawingType
            // 
            this.cBDrawingType.FormattingEnabled = true;
            this.cBDrawingType.Items.AddRange(new object[] {
            "Standard symmetrical",
            "Directional",
            "Asymmetric",
            "Directional asymmetric"});
            this.cBDrawingType.Location = new System.Drawing.Point(363, 286);
            this.cBDrawingType.Name = "cBDrawingType";
            this.cBDrawingType.Size = new System.Drawing.Size(186, 21);
            this.cBDrawingType.TabIndex = 3;
            // 
            // cBBrand
            // 
            this.cBBrand.FormattingEnabled = true;
            this.cBBrand.Location = new System.Drawing.Point(363, 147);
            this.cBBrand.Name = "cBBrand";
            this.cBBrand.Size = new System.Drawing.Size(186, 21);
            this.cBBrand.TabIndex = 4;
            this.cBBrand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBBrand_MouseClick);
            // 
            // txTQuantity
            // 
            this.txTQuantity.Location = new System.Drawing.Point(363, 373);
            this.txTQuantity.Name = "txTQuantity";
            this.txTQuantity.Size = new System.Drawing.Size(182, 20);
            this.txTQuantity.TabIndex = 6;
            // 
            // txTUVPrice
            // 
            this.txTUVPrice.Location = new System.Drawing.Point(363, 452);
            this.txTUVPrice.Name = "txTUVPrice";
            this.txTUVPrice.Size = new System.Drawing.Size(182, 20);
            this.txTUVPrice.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type Of Drawing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Reference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tyre Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Season";
            // 
            // txTUAPrice
            // 
            this.txTUAPrice.Location = new System.Drawing.Point(363, 411);
            this.txTUAPrice.Name = "txTUAPrice";
            this.txTUAPrice.Size = new System.Drawing.Size(182, 20);
            this.txTUAPrice.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "U.A Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "U.V Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txTReference
            // 
            this.txTReference.Location = new System.Drawing.Point(363, 191);
            this.txTReference.Name = "txTReference";
            this.txTReference.Size = new System.Drawing.Size(186, 20);
            this.txTReference.TabIndex = 22;
            // 
            // cBSeason
            // 
            this.cBSeason.FormattingEnabled = true;
            this.cBSeason.Items.AddRange(new object[] {
            "Summer",
            "Autumn",
            "Winter",
            "Spring"});
            this.cBSeason.Location = new System.Drawing.Point(363, 331);
            this.cBSeason.Name = "cBSeason";
            this.cBSeason.Size = new System.Drawing.Size(182, 21);
            this.cBSeason.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(322, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 31);
            this.label11.TabIndex = 25;
            this.label11.Text = "Product Form";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cBSeason);
            this.Controls.Add(this.txTReference);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txTUAPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txTUVPrice);
            this.Controls.Add(this.txTQuantity);
            this.Controls.Add(this.cBBrand);
            this.Controls.Add(this.cBDrawingType);
            this.Controls.Add(this.cBTyreType);
            this.Controls.Add(this.cBSupplier);
            this.Controls.Add(this.label1);
            this.Name = "FormProduct";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBSupplier;
        private System.Windows.Forms.ComboBox cBTyreType;
        private System.Windows.Forms.ComboBox cBDrawingType;
        private System.Windows.Forms.ComboBox cBBrand;
        private System.Windows.Forms.TextBox txTQuantity;
        private System.Windows.Forms.TextBox txTUVPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txTUAPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txTReference;
        private System.Windows.Forms.ComboBox cBSeason;
        private System.Windows.Forms.Label label11;
    }
}

