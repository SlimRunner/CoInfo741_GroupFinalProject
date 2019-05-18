namespace Restaurant_Order_App
{
    partial class frmMain
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
            this.mnuStripMain = new System.Windows.Forms.MenuStrip();
            this.mnuProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.submHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.submAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.submExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.submAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lstMenuCarte = new System.Windows.Forms.ListBox();
            this.cmnuMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuCustomAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.picSelectedFood = new System.Windows.Forms.PictureBox();
            this.lblFoodInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCustomItem = new System.Windows.Forms.Button();
            this.lblCarteTitle = new System.Windows.Forms.Label();
            this.lblOrderTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lstOrderedItems = new System.Windows.Forms.ListBox();
            this.cmnuOrderOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuRemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDisplaySubtotal = new System.Windows.Forms.Label();
            this.submMainDishes = new ToolStripRadioButtonMenuItem();
            this.submSalads = new ToolStripRadioButtonMenuItem();
            this.submBeverages = new ToolStripRadioButtonMenuItem();
            this.submDesserts = new ToolStripRadioButtonMenuItem();
            this.mnuStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.cmnuMenuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedFood)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.cmnuOrderOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripMain
            // 
            this.mnuStripMain.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProgram,
            this.mnuOrder});
            this.mnuStripMain.Location = new System.Drawing.Point(0, 0);
            this.mnuStripMain.Name = "mnuStripMain";
            this.mnuStripMain.Size = new System.Drawing.Size(1144, 31);
            this.mnuStripMain.TabIndex = 0;
            this.mnuStripMain.Text = "menuStrip1";
            // 
            // mnuProgram
            // 
            this.mnuProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submHelp,
            this.submAbout,
            this.toolStripSeparator3,
            this.submExit});
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(80, 27);
            this.mnuProgram.Text = "&Program";
            // 
            // submHelp
            // 
            this.submHelp.Name = "submHelp";
            this.submHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.submHelp.Size = new System.Drawing.Size(193, 28);
            this.submHelp.Text = "&Help...";
            // 
            // submAbout
            // 
            this.submAbout.Name = "submAbout";
            this.submAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.submAbout.Size = new System.Drawing.Size(193, 28);
            this.submAbout.Text = "&About...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // submExit
            // 
            this.submExit.Name = "submExit";
            this.submExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.submExit.Size = new System.Drawing.Size(193, 28);
            this.submExit.Text = "E&xit";
            this.submExit.Click += new System.EventHandler(this.submExit_Click);
            // 
            // mnuOrder
            // 
            this.mnuOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submAddItem,
            this.submRemove,
            this.toolStripSeparator2,
            this.submMainDishes,
            this.submSalads,
            this.submBeverages,
            this.submDesserts,
            this.toolStripSeparator4,
            this.placeOrderToolStripMenuItem,
            this.clearOrderToolStripMenuItem});
            this.mnuOrder.Name = "mnuOrder";
            this.mnuOrder.Size = new System.Drawing.Size(62, 27);
            this.mnuOrder.Text = "&Order";
            // 
            // submAddItem
            // 
            this.submAddItem.Name = "submAddItem";
            this.submAddItem.ShortcutKeyDisplayString = "";
            this.submAddItem.Size = new System.Drawing.Size(203, 28);
            this.submAddItem.Text = "Add Item";
            this.submAddItem.Click += new System.EventHandler(this.cmdAddItems_GroupClick);
            // 
            // submRemove
            // 
            this.submRemove.Name = "submRemove";
            this.submRemove.ShortcutKeyDisplayString = "";
            this.submRemove.Size = new System.Drawing.Size(203, 28);
            this.submRemove.Text = "Remove Item";
            this.submRemove.Click += new System.EventHandler(this.cmdRemoveItems_GroupClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(203, 28);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            // 
            // clearOrderToolStripMenuItem
            // 
            this.clearOrderToolStripMenuItem.Name = "clearOrderToolStripMenuItem";
            this.clearOrderToolStripMenuItem.Size = new System.Drawing.Size(203, 28);
            this.clearOrderToolStripMenuItem.Text = "Clear Order";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(1144, 653);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCarteTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOrderTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1128, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.lstMenuCarte, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.picSelectedFood, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblFoodInfo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1128, 285);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lstMenuCarte
            // 
            this.lstMenuCarte.ContextMenuStrip = this.cmnuMenuOptions;
            this.lstMenuCarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMenuCarte.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMenuCarte.FormattingEnabled = true;
            this.lstMenuCarte.ItemHeight = 33;
            this.lstMenuCarte.Location = new System.Drawing.Point(3, 3);
            this.lstMenuCarte.Name = "lstMenuCarte";
            this.tableLayoutPanel2.SetRowSpan(this.lstMenuCarte, 2);
            this.lstMenuCarte.Size = new System.Drawing.Size(643, 279);
            this.lstMenuCarte.TabIndex = 0;
            this.lstMenuCarte.SelectedIndexChanged += new System.EventHandler(this.lstMenuCarte_SelectedIndexChanged);
            // 
            // cmnuMenuOptions
            // 
            this.cmnuMenuOptions.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnuMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuAddItem,
            this.cmnuCustomAdd});
            this.cmnuMenuOptions.Name = "cmnuOrderOptions";
            this.cmnuMenuOptions.Size = new System.Drawing.Size(220, 60);
            // 
            // cmnuAddItem
            // 
            this.cmnuAddItem.Name = "cmnuAddItem";
            this.cmnuAddItem.Size = new System.Drawing.Size(219, 28);
            this.cmnuAddItem.Text = "Add to Order";
            this.cmnuAddItem.Click += new System.EventHandler(this.cmdAddItems_GroupClick);
            // 
            // cmnuCustomAdd
            // 
            this.cmnuCustomAdd.Name = "cmnuCustomAdd";
            this.cmnuCustomAdd.Size = new System.Drawing.Size(219, 28);
            this.cmnuCustomAdd.Text = "Customize and Add...";
            this.cmnuCustomAdd.Click += new System.EventHandler(this.cmdCustomItems_GroupClick);
            // 
            // picSelectedFood
            // 
            this.picSelectedFood.BackColor = System.Drawing.Color.Black;
            this.picSelectedFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelectedFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSelectedFood.Location = new System.Drawing.Point(652, 3);
            this.picSelectedFood.Name = "picSelectedFood";
            this.tableLayoutPanel2.SetRowSpan(this.picSelectedFood, 2);
            this.picSelectedFood.Size = new System.Drawing.Size(272, 279);
            this.picSelectedFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelectedFood.TabIndex = 1;
            this.picSelectedFood.TabStop = false;
            // 
            // lblFoodInfo
            // 
            this.lblFoodInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFoodInfo.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodInfo.Location = new System.Drawing.Point(935, 8);
            this.lblFoodInfo.Margin = new System.Windows.Forms.Padding(8);
            this.lblFoodInfo.Name = "lblFoodInfo";
            this.lblFoodInfo.Size = new System.Drawing.Size(185, 149);
            this.lblFoodInfo.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveItem, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnAddItem, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCustomItem, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(927, 165);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(201, 120);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(8, 83);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(190, 34);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "&Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.cmdRemoveItems_GroupClick);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(8, 3);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(190, 34);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "&Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.cmdAddItems_GroupClick);
            // 
            // btnCustomItem
            // 
            this.btnCustomItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomItem.Enabled = false;
            this.btnCustomItem.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomItem.Location = new System.Drawing.Point(8, 43);
            this.btnCustomItem.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnCustomItem.Name = "btnCustomItem";
            this.btnCustomItem.Size = new System.Drawing.Size(190, 34);
            this.btnCustomItem.TabIndex = 1;
            this.btnCustomItem.Text = "Add &Custom...";
            this.btnCustomItem.UseVisualStyleBackColor = true;
            this.btnCustomItem.Click += new System.EventHandler(this.cmdCustomItems_GroupClick);
            // 
            // lblCarteTitle
            // 
            this.lblCarteTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCarteTitle.AutoSize = true;
            this.lblCarteTitle.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteTitle.ForeColor = System.Drawing.Color.Red;
            this.lblCarteTitle.Location = new System.Drawing.Point(3, 0);
            this.lblCarteTitle.Name = "lblCarteTitle";
            this.lblCarteTitle.Size = new System.Drawing.Size(298, 33);
            this.lblCarteTitle.TabIndex = 0;
            this.lblCarteTitle.Text = "Delicioso E-Ristorante &Menu:";
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderTitle.AutoSize = true;
            this.lblOrderTitle.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.lblOrderTitle.ForeColor = System.Drawing.Color.Red;
            this.lblOrderTitle.Location = new System.Drawing.Point(3, 318);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(164, 33);
            this.lblOrderTitle.TabIndex = 3;
            this.lblOrderTitle.Text = "Current Or&der:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.Controls.Add(this.lstOrderedItems, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblDisplaySubtotal, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 351);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1128, 286);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lstOrderedItems
            // 
            this.lstOrderedItems.ContextMenuStrip = this.cmnuOrderOptions;
            this.lstOrderedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOrderedItems.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.lstOrderedItems.FormattingEnabled = true;
            this.lstOrderedItems.ItemHeight = 33;
            this.lstOrderedItems.Location = new System.Drawing.Point(3, 3);
            this.lstOrderedItems.Name = "lstOrderedItems";
            this.tableLayoutPanel4.SetRowSpan(this.lstOrderedItems, 2);
            this.lstOrderedItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstOrderedItems.Size = new System.Drawing.Size(643, 280);
            this.lstOrderedItems.TabIndex = 0;
            // 
            // cmnuOrderOptions
            // 
            this.cmnuOrderOptions.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnuOrderOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuEditItem,
            this.toolStripSeparator5,
            this.cmnuRemoveItem});
            this.cmnuOrderOptions.Name = "cmnuOrderOptions";
            this.cmnuOrderOptions.Size = new System.Drawing.Size(213, 88);
            this.cmnuOrderOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cmnuOrderOptions_Opening);
            // 
            // cmnuEditItem
            // 
            this.cmnuEditItem.Name = "cmnuEditItem";
            this.cmnuEditItem.Size = new System.Drawing.Size(212, 28);
            this.cmnuEditItem.Tag = "edit";
            this.cmnuEditItem.Text = "Edit Item";
            this.cmnuEditItem.Click += new System.EventHandler(this.cmdCustomItems_GroupClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(209, 6);
            // 
            // cmnuRemoveItem
            // 
            this.cmnuRemoveItem.Name = "cmnuRemoveItem";
            this.cmnuRemoveItem.Size = new System.Drawing.Size(212, 28);
            this.cmnuRemoveItem.Text = "Remove from Order";
            this.cmnuRemoveItem.Click += new System.EventHandler(this.cmdRemoveItems_GroupClick);
            // 
            // lblDisplaySubtotal
            // 
            this.lblDisplaySubtotal.AutoSize = true;
            this.lblDisplaySubtotal.Location = new System.Drawing.Point(652, 0);
            this.lblDisplaySubtotal.Name = "lblDisplaySubtotal";
            this.lblDisplaySubtotal.Size = new System.Drawing.Size(51, 23);
            this.lblDisplaySubtotal.TabIndex = 1;
            this.lblDisplaySubtotal.Text = "label1";
            // 
            // submMainDishes
            // 
            this.submMainDishes.CheckOnClick = true;
            this.submMainDishes.Name = "submMainDishes";
            this.submMainDishes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.submMainDishes.Size = new System.Drawing.Size(203, 28);
            this.submMainDishes.Tag = "0";
            this.submMainDishes.Text = "Main Dishes";
            this.submMainDishes.Click += new System.EventHandler(this.submFoodCategory_GroupClick);
            // 
            // submSalads
            // 
            this.submSalads.CheckOnClick = true;
            this.submSalads.Name = "submSalads";
            this.submSalads.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.submSalads.Size = new System.Drawing.Size(203, 28);
            this.submSalads.Tag = "3";
            this.submSalads.Text = "Salads";
            this.submSalads.Click += new System.EventHandler(this.submFoodCategory_GroupClick);
            // 
            // submBeverages
            // 
            this.submBeverages.CheckOnClick = true;
            this.submBeverages.Name = "submBeverages";
            this.submBeverages.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.submBeverages.Size = new System.Drawing.Size(203, 28);
            this.submBeverages.Tag = "1";
            this.submBeverages.Text = "Beverages";
            this.submBeverages.Click += new System.EventHandler(this.submFoodCategory_GroupClick);
            // 
            // submDesserts
            // 
            this.submDesserts.CheckOnClick = true;
            this.submDesserts.Name = "submDesserts";
            this.submDesserts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.submDesserts.Size = new System.Drawing.Size(203, 28);
            this.submDesserts.Tag = "2";
            this.submDesserts.Text = "Desserts";
            this.submDesserts.Click += new System.EventHandler(this.submFoodCategory_GroupClick);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1144, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuStripMain);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmMain";
            this.Text = "Delicioso E-Ristorante";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuStripMain.ResumeLayout(false);
            this.mnuStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.cmnuMenuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSelectedFood)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.cmnuOrderOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mnuProgram;
        private System.Windows.Forms.ToolStripMenuItem submHelp;
        private System.Windows.Forms.ToolStripMenuItem submExit;
        private System.Windows.Forms.ToolStripMenuItem mnuOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem clearOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem submAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private ToolStripRadioButtonMenuItem submMainDishes;
        private ToolStripRadioButtonMenuItem submBeverages;
        private ToolStripRadioButtonMenuItem submDesserts;
        private System.Windows.Forms.ToolStripMenuItem submAddItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ListBox lstMenuCarte;
        private System.Windows.Forms.PictureBox picSelectedFood;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFoodInfo;
        private System.Windows.Forms.Button btnCustomItem;
        private System.Windows.Forms.Label lblCarteTitle;
        private ToolStripRadioButtonMenuItem submSalads;
        private System.Windows.Forms.ToolStripMenuItem submRemove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox lstOrderedItems;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ContextMenuStrip cmnuMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem cmnuAddItem;
        private System.Windows.Forms.ToolStripMenuItem cmnuCustomAdd;
        private System.Windows.Forms.ContextMenuStrip cmnuOrderOptions;
        private System.Windows.Forms.ToolStripMenuItem cmnuRemoveItem;
        private System.Windows.Forms.ToolStripMenuItem cmnuEditItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label lblDisplaySubtotal;
    }
}

