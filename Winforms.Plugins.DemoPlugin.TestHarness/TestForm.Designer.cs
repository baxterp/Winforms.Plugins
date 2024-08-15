namespace Winforms.Plugins.DemoPlugin.TestHarness
{
    partial class TestForm
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
            this.dataGridViewUserControl1 = new Winforms.Plugins.DemoPlugin.DataGridViewUserControl();
            this.imageUserControl1 = new Winforms.Plugins.DemoPlugin2.ImageUserControl();
            this.SuspendLayout();
            // 
            // dataGridViewUserControl1
            // 
            this.dataGridViewUserControl1.Location = new System.Drawing.Point(1, -4);
            this.dataGridViewUserControl1.Name = "dataGridViewUserControl1";
            this.dataGridViewUserControl1.Size = new System.Drawing.Size(758, 454);
            this.dataGridViewUserControl1.TabIndex = 0;
            // 
            // imageUserControl1
            // 
            this.imageUserControl1.Location = new System.Drawing.Point(24, 23);
            this.imageUserControl1.Name = "imageUserControl1";
            this.imageUserControl1.Size = new System.Drawing.Size(735, 415);
            this.imageUserControl1.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 462);
            this.Controls.Add(this.imageUserControl1);
            this.Controls.Add(this.dataGridViewUserControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewUserControl dataGridViewUserControl1;
        private DemoPlugin2.ImageUserControl imageUserControl1;
    }
}