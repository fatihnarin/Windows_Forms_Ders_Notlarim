namespace WF_Form_List
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yavruFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dortİslemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.listelerToolStripMenuItem,
            this.dortİslemToolStripMenuItem,
            this.topluToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalFormToolStripMenuItem,
            this.yavruFormToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            this.formToolStripMenuItem.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
            // 
            // normalFormToolStripMenuItem
            // 
            this.normalFormToolStripMenuItem.Name = "normalFormToolStripMenuItem";
            this.normalFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalFormToolStripMenuItem.Text = "Normal Form";
            this.normalFormToolStripMenuItem.Click += new System.EventHandler(this.normalFormToolStripMenuItem_Click);
            // 
            // yavruFormToolStripMenuItem
            // 
            this.yavruFormToolStripMenuItem.Name = "yavruFormToolStripMenuItem";
            this.yavruFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yavruFormToolStripMenuItem.Text = "Yavru Form";
            this.yavruFormToolStripMenuItem.Click += new System.EventHandler(this.yavruFormToolStripMenuItem_Click);
            // 
            // listelerToolStripMenuItem
            // 
            this.listelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listboxToolStripMenuItem});
            this.listelerToolStripMenuItem.Name = "listelerToolStripMenuItem";
            this.listelerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.listelerToolStripMenuItem.Text = "Listeler";
            // 
            // listboxToolStripMenuItem
            // 
            this.listboxToolStripMenuItem.Name = "listboxToolStripMenuItem";
            this.listboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listboxToolStripMenuItem.Text = "Listbox";
            this.listboxToolStripMenuItem.Click += new System.EventHandler(this.listboxToolStripMenuItem_Click);
            // 
            // dortİslemToolStripMenuItem
            // 
            this.dortİslemToolStripMenuItem.Name = "dortİslemToolStripMenuItem";
            this.dortİslemToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.dortİslemToolStripMenuItem.Text = "Dort İslem";
            this.dortİslemToolStripMenuItem.Click += new System.EventHandler(this.dortİslemToolStripMenuItem_Click);
            // 
            // topluToolStripMenuItem
            // 
            this.topluToolStripMenuItem.Name = "topluToolStripMenuItem";
            this.topluToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.topluToolStripMenuItem.Text = "Toplu";
            this.topluToolStripMenuItem.Click += new System.EventHandler(this.topluToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yavruFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dortİslemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topluToolStripMenuItem;
    }
}