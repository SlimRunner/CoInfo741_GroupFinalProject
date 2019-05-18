namespace Restaurant_Order_App.GUI
{
    partial class frmCustomizeDialog
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
            this.panMain = new System.Windows.Forms.Panel();
            this.tlayMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlayButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkAdditions = new System.Windows.Forms.CheckedListBox();
            this.chkExtras = new System.Windows.Forms.CheckedListBox();
            this.lblAdditions = new System.Windows.Forms.Label();
            this.lblExtras = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lstOptions = new System.Windows.Forms.ComboBox();
            this.panMain.SuspendLayout();
            this.tlayMain.SuspendLayout();
            this.tlayButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.tlayMain);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Padding = new System.Windows.Forms.Padding(8);
            this.panMain.Size = new System.Drawing.Size(479, 298);
            this.panMain.TabIndex = 0;
            // 
            // tlayMain
            // 
            this.tlayMain.ColumnCount = 2;
            this.tlayMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tlayMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tlayMain.Controls.Add(this.lblOptions, 0, 0);
            this.tlayMain.Controls.Add(this.tlayButtons, 0, 3);
            this.tlayMain.Controls.Add(this.chkAdditions, 0, 2);
            this.tlayMain.Controls.Add(this.chkExtras, 1, 2);
            this.tlayMain.Controls.Add(this.lblAdditions, 0, 1);
            this.tlayMain.Controls.Add(this.lblExtras, 1, 1);
            this.tlayMain.Controls.Add(this.lstOptions, 1, 0);
            this.tlayMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlayMain.Location = new System.Drawing.Point(8, 8);
            this.tlayMain.Name = "tlayMain";
            this.tlayMain.RowCount = 4;
            this.tlayMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlayMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlayMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlayMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlayMain.Size = new System.Drawing.Size(463, 282);
            this.tlayMain.TabIndex = 0;
            // 
            // tlayButtons
            // 
            this.tlayButtons.ColumnCount = 3;
            this.tlayMain.SetColumnSpan(this.tlayButtons, 2);
            this.tlayButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlayButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlayButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlayButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tlayButtons.Controls.Add(this.btnAdd, 1, 0);
            this.tlayButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlayButtons.Location = new System.Drawing.Point(0, 242);
            this.tlayButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlayButtons.Name = "tlayButtons";
            this.tlayButtons.RowCount = 1;
            this.tlayButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlayButtons.Size = new System.Drawing.Size(463, 40);
            this.tlayButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(347, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(227, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkAdditions
            // 
            this.chkAdditions.CheckOnClick = true;
            this.chkAdditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAdditions.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdditions.FormattingEnabled = true;
            this.chkAdditions.Location = new System.Drawing.Point(3, 69);
            this.chkAdditions.Margin = new System.Windows.Forms.Padding(3, 3, 8, 4);
            this.chkAdditions.Name = "chkAdditions";
            this.chkAdditions.Size = new System.Drawing.Size(220, 169);
            this.chkAdditions.TabIndex = 1;
            // 
            // chkExtras
            // 
            this.chkExtras.CheckOnClick = true;
            this.chkExtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkExtras.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtras.FormattingEnabled = true;
            this.chkExtras.Location = new System.Drawing.Point(239, 69);
            this.chkExtras.Margin = new System.Windows.Forms.Padding(8, 3, 3, 4);
            this.chkExtras.Name = "chkExtras";
            this.chkExtras.Size = new System.Drawing.Size(221, 169);
            this.chkExtras.TabIndex = 2;
            // 
            // lblAdditions
            // 
            this.lblAdditions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdditions.AutoSize = true;
            this.lblAdditions.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditions.Location = new System.Drawing.Point(3, 40);
            this.lblAdditions.Name = "lblAdditions";
            this.lblAdditions.Size = new System.Drawing.Size(83, 26);
            this.lblAdditions.TabIndex = 3;
            this.lblAdditions.Text = "Additions";
            // 
            // lblExtras
            // 
            this.lblExtras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.Location = new System.Drawing.Point(234, 40);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(92, 26);
            this.lblExtras.TabIndex = 4;
            this.lblExtras.Text = "Add Extra";
            // 
            // lblOptions
            // 
            this.lblOptions.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(155, 7);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(73, 26);
            this.lblOptions.TabIndex = 5;
            this.lblOptions.Text = "Options:";
            // 
            // lstOptions
            // 
            this.lstOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOptions.FormattingEnabled = true;
            this.lstOptions.Location = new System.Drawing.Point(234, 3);
            this.lstOptions.Name = "lstOptions";
            this.lstOptions.Size = new System.Drawing.Size(226, 31);
            this.lstOptions.TabIndex = 6;
            // 
            // frmCustomizeDialog
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(479, 298);
            this.Controls.Add(this.panMain);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomizeDialog";
            this.Text = "Customize Order";
            this.panMain.ResumeLayout(false);
            this.tlayMain.ResumeLayout(false);
            this.tlayMain.PerformLayout();
            this.tlayButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.TableLayoutPanel tlayMain;
        private System.Windows.Forms.TableLayoutPanel tlayButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.CheckedListBox chkAdditions;
        private System.Windows.Forms.CheckedListBox chkExtras;
        private System.Windows.Forms.Label lblAdditions;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.ComboBox lstOptions;
    }
}