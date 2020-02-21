namespace Insta_WF_Ecommerce
{
    partial class ListConsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVConsumer = new System.Windows.Forms.DataGridView();
            this.cMSDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsumer)).BeginInit();
            this.cMSDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumer List";
            // 
            // dGVConsumer
            // 
            this.dGVConsumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVConsumer.ContextMenuStrip = this.cMSDataGrid;
            this.dGVConsumer.Location = new System.Drawing.Point(88, 85);
            this.dGVConsumer.Name = "dGVConsumer";
            this.dGVConsumer.Size = new System.Drawing.Size(598, 308);
            this.dGVConsumer.TabIndex = 1;
            this.dGVConsumer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVConsumer_CellContentClick);
            // 
            // cMSDataGrid
            // 
            this.cMSDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.cMSDataGrid.Name = "cMSDataGrid";
            this.cMSDataGrid.Size = new System.Drawing.Size(181, 70);
            this.cMSDataGrid.Opening += new System.ComponentModel.CancelEventHandler(this.cMSDataGrid_Opening);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // ListConsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVConsumer);
            this.Controls.Add(this.label1);
            this.Name = "ListConsForm";
            this.Text = "ListConsForm";
            this.Load += new System.EventHandler(this.ListConsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsumer)).EndInit();
            this.cMSDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVConsumer;
        private System.Windows.Forms.ContextMenuStrip cMSDataGrid;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}