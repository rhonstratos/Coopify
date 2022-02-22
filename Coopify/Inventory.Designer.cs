namespace Coopify
{
    partial class Inventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventoryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.inventoryMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // inventoryMenuStrip
            // 
            this.inventoryMenuStrip.AllowMerge = false;
            this.inventoryMenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryMenuStrip.AutoSize = false;
            this.inventoryMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.inventoryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItem,
            this.editItem,
            this.deleteItem});
            this.inventoryMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.inventoryMenuStrip.Name = "inventoryMenuStrip";
            this.inventoryMenuStrip.Size = new System.Drawing.Size(800, 66);
            this.inventoryMenuStrip.TabIndex = 1;
            // 
            // addItem
            // 
            this.addItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.addItem.AutoSize = false;
            this.addItem.Name = "addItem";
            this.addItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addItem.Size = new System.Drawing.Size(70, 62);
            this.addItem.Text = "Add";
            // 
            // editItem
            // 
            this.editItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.editItem.AutoSize = false;
            this.editItem.Name = "editItem";
            this.editItem.Size = new System.Drawing.Size(70, 62);
            this.editItem.Text = "Edit";
            // 
            // deleteItem
            // 
            this.deleteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.deleteItem.AutoSize = false;
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(70, 62);
            this.deleteItem.Text = "Delete";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inventoryMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.inventoryMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventory";
            this.ShowIcon = false;
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.inventoryMenuStrip.ResumeLayout(false);
            this.inventoryMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip inventoryMenuStrip;
        private ToolStripMenuItem addItem;
        private ToolStripMenuItem editItem;
        private ToolStripMenuItem deleteItem;
    }
}