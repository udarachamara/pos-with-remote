namespace Pos.ui.tasks
{
    partial class FormHome
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
            this.dueSalesPanel = new System.Windows.Forms.Panel();
            this.dueSalesDataGrid = new System.Windows.Forms.DataGridView();
            this.dueSalesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dueSalesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dueSalesPanel
            // 
            this.dueSalesPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dueSalesPanel.Controls.Add(this.dueSalesDataGrid);
            this.dueSalesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dueSalesPanel.Location = new System.Drawing.Point(0, 0);
            this.dueSalesPanel.Margin = new System.Windows.Forms.Padding(10);
            this.dueSalesPanel.Name = "dueSalesPanel";
            this.dueSalesPanel.Padding = new System.Windows.Forms.Padding(5);
            this.dueSalesPanel.Size = new System.Drawing.Size(200, 424);
            this.dueSalesPanel.TabIndex = 0;
            // 
            // dueSalesDataGrid
            // 
            this.dueSalesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dueSalesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dueSalesDataGrid.Location = new System.Drawing.Point(5, 5);
            this.dueSalesDataGrid.Margin = new System.Windows.Forms.Padding(10);
            this.dueSalesDataGrid.Name = "dueSalesDataGrid";
            this.dueSalesDataGrid.Size = new System.Drawing.Size(190, 414);
            this.dueSalesDataGrid.TabIndex = 0;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(810, 424);
            this.Controls.Add(this.dueSalesPanel);
            this.Name = "FormHome";
            this.Text = "home";
            this.dueSalesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dueSalesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dueSalesPanel;
        private System.Windows.Forms.DataGridView dueSalesDataGrid;
    }
}