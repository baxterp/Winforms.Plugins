namespace Winforms.Plugins.Host
{
    partial class HostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostForm));
            this.btnLoadPlugins = new System.Windows.Forms.Button();
            this.menuStripHost = new System.Windows.Forms.MenuStrip();
            this.hostTabControl = new System.Windows.Forms.TabControl();
            this.btnEmptyContainer = new System.Windows.Forms.Button();
            this.btnLoadContainer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadPlugins
            // 
            this.btnLoadPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPlugins.Location = new System.Drawing.Point(205, 31);
            this.btnLoadPlugins.Name = "btnLoadPlugins";
            this.btnLoadPlugins.Size = new System.Drawing.Size(115, 48);
            this.btnLoadPlugins.TabIndex = 0;
            this.btnLoadPlugins.Text = "Load Plugins into Form";
            this.btnLoadPlugins.UseVisualStyleBackColor = true;
            this.btnLoadPlugins.Click += new System.EventHandler(this.btnLoadPlugins_Click);
            // 
            // menuStripHost
            // 
            this.menuStripHost.Location = new System.Drawing.Point(0, 0);
            this.menuStripHost.Name = "menuStripHost";
            this.menuStripHost.Size = new System.Drawing.Size(804, 24);
            this.menuStripHost.TabIndex = 2;
            this.menuStripHost.Text = "menuStrip1";
            // 
            // hostTabControl
            // 
            this.hostTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostTabControl.Location = new System.Drawing.Point(12, 37);
            this.hostTabControl.Name = "hostTabControl";
            this.hostTabControl.SelectedIndex = 0;
            this.hostTabControl.Size = new System.Drawing.Size(767, 437);
            this.hostTabControl.TabIndex = 3;
            // 
            // btnEmptyContainer
            // 
            this.btnEmptyContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmptyContainer.Location = new System.Drawing.Point(344, 31);
            this.btnEmptyContainer.Name = "btnEmptyContainer";
            this.btnEmptyContainer.Size = new System.Drawing.Size(124, 48);
            this.btnEmptyContainer.TabIndex = 4;
            this.btnEmptyContainer.Text = "Empty Container";
            this.btnEmptyContainer.UseVisualStyleBackColor = true;
            this.btnEmptyContainer.Click += new System.EventHandler(this.btnEmptyContainer_Click);
            // 
            // btnLoadContainer
            // 
            this.btnLoadContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadContainer.Location = new System.Drawing.Point(52, 31);
            this.btnLoadContainer.Name = "btnLoadContainer";
            this.btnLoadContainer.Size = new System.Drawing.Size(129, 48);
            this.btnLoadContainer.TabIndex = 5;
            this.btnLoadContainer.Text = "Instanciate Plugins onto Container";
            this.btnLoadContainer.UseVisualStyleBackColor = true;
            this.btnLoadContainer.Click += new System.EventHandler(this.btnLoadContainer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadContainer);
            this.groupBox1.Controls.Add(this.btnEmptyContainer);
            this.groupBox1.Controls.Add(this.btnLoadPlugins);
            this.groupBox1.Location = new System.Drawing.Point(12, 480);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plugin Operations";
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hostTabControl);
            this.Controls.Add(this.menuStripHost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripHost;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostForm";
            this.Load += new System.EventHandler(this.HostForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPlugins;
        private System.Windows.Forms.MenuStrip menuStripHost;
        private System.Windows.Forms.TabControl hostTabControl;
        private System.Windows.Forms.Button btnEmptyContainer;
        private System.Windows.Forms.Button btnLoadContainer;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}