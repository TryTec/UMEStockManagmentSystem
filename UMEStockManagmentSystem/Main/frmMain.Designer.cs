namespace UMEStockManagmentSystem.Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiMainEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiMainProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSupplyer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiProductUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiMainStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockAdjustment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockDispatch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockPurchaseReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockAdjustmentReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockDispatchReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComputerConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApplicationLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInterfaceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloseChild = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainEmployee,
            this.tmsiMainProduct,
            this.tmsiMainStock,
            this.tsmiMainReport,
            this.tsmiMainSetting,
            this.tsmiCloseChild});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiMainEmployee
            // 
            this.tsmiMainEmployee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployee,
            this.tsmiEmployeeCategory});
            this.tsmiMainEmployee.Name = "tsmiMainEmployee";
            this.tsmiMainEmployee.Size = new System.Drawing.Size(62, 28);
            this.tsmiMainEmployee.Text = "បុគ្គលិក";
            // 
            // tmsiMainProduct
            // 
            this.tmsiMainProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSupplyer,
            this.tsmiProduct,
            this.tsmiProductCategory,
            this.tmsiProductUnit});
            this.tmsiMainProduct.Name = "tmsiMainProduct";
            this.tmsiMainProduct.Size = new System.Drawing.Size(75, 28);
            this.tmsiMainProduct.Text = "ផលិតផល";
            // 
            // tsmiSupplyer
            // 
            this.tsmiSupplyer.Name = "tsmiSupplyer";
            this.tsmiSupplyer.Size = new System.Drawing.Size(180, 28);
            this.tsmiSupplyer.Text = "អ្នកផ្គត់ផ្គង់";
            this.tsmiSupplyer.Click += new System.EventHandler(this.tsmiSupplyer_Click);
            // 
            // tsmiProduct
            // 
            this.tsmiProduct.Name = "tsmiProduct";
            this.tsmiProduct.Size = new System.Drawing.Size(180, 28);
            this.tsmiProduct.Text = "ព័ត៌មានផលិតផល";
            // 
            // tsmiProductCategory
            // 
            this.tsmiProductCategory.Name = "tsmiProductCategory";
            this.tsmiProductCategory.Size = new System.Drawing.Size(180, 28);
            this.tsmiProductCategory.Text = "ប្រភេទផលិតផល";
            // 
            // tmsiProductUnit
            // 
            this.tmsiProductUnit.Name = "tmsiProductUnit";
            this.tmsiProductUnit.Size = new System.Drawing.Size(180, 28);
            this.tmsiProductUnit.Text = "ខ្នាតផលិតផល";
            // 
            // tmsiMainStock
            // 
            this.tmsiMainStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStockPurchase,
            this.tsmiStockAdjustment,
            this.tsmiStockDispatch});
            this.tmsiMainStock.Name = "tmsiMainStock";
            this.tmsiMainStock.Size = new System.Drawing.Size(44, 28);
            this.tmsiMainStock.Text = "ស្ដុក";
            // 
            // tsmiStockPurchase
            // 
            this.tsmiStockPurchase.Name = "tsmiStockPurchase";
            this.tsmiStockPurchase.Size = new System.Drawing.Size(181, 28);
            this.tsmiStockPurchase.Text = "ទិញផលិតផល";
            // 
            // tsmiStockAdjustment
            // 
            this.tsmiStockAdjustment.Name = "tsmiStockAdjustment";
            this.tsmiStockAdjustment.Size = new System.Drawing.Size(181, 28);
            this.tsmiStockAdjustment.Text = "សមតុល្យផលិតផល";
            // 
            // tsmiStockDispatch
            // 
            this.tsmiStockDispatch.Name = "tsmiStockDispatch";
            this.tsmiStockDispatch.Size = new System.Drawing.Size(181, 28);
            this.tsmiStockDispatch.Text = "ដាក់ផលិតផលលក់";
            // 
            // tsmiMainReport
            // 
            this.tsmiMainReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStockPurchaseReport,
            this.tsmiStockAdjustmentReport,
            this.tsmiStockDispatchReport});
            this.tsmiMainReport.Name = "tsmiMainReport";
            this.tsmiMainReport.Size = new System.Drawing.Size(87, 28);
            this.tsmiMainReport.Text = "របាយការណ៍";
            // 
            // tsmiStockPurchaseReport
            // 
            this.tsmiStockPurchaseReport.Name = "tsmiStockPurchaseReport";
            this.tsmiStockPurchaseReport.Size = new System.Drawing.Size(193, 28);
            this.tsmiStockPurchaseReport.Text = "របាយការណ៍ទិញចូល";
            // 
            // tsmiStockAdjustmentReport
            // 
            this.tsmiStockAdjustmentReport.Name = "tsmiStockAdjustmentReport";
            this.tsmiStockAdjustmentReport.Size = new System.Drawing.Size(193, 28);
            this.tsmiStockAdjustmentReport.Text = "របាយការណ៍សមតុល្យ";
            // 
            // tsmiStockDispatchReport
            // 
            this.tsmiStockDispatchReport.Name = "tsmiStockDispatchReport";
            this.tsmiStockDispatchReport.Size = new System.Drawing.Size(193, 28);
            this.tsmiStockDispatchReport.Text = "របាយការណ៍ដាក់លក់";
            // 
            // tsmiMainSetting
            // 
            this.tsmiMainSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiComputer,
            this.tsmiComputerConfiguration,
            this.tsmiApplicationLogin,
            this.tsmiProfile,
            this.tsmiInterface,
            this.tsmiInterfaceDetail});
            this.tsmiMainSetting.Name = "tsmiMainSetting";
            this.tsmiMainSetting.Size = new System.Drawing.Size(75, 28);
            this.tsmiMainSetting.Text = "ការកំណត់";
            // 
            // tsmiComputer
            // 
            this.tsmiComputer.Name = "tsmiComputer";
            this.tsmiComputer.Size = new System.Drawing.Size(189, 28);
            this.tsmiComputer.Text = "កុំព្យូទ័រ";
            // 
            // tsmiComputerConfiguration
            // 
            this.tsmiComputerConfiguration.Name = "tsmiComputerConfiguration";
            this.tsmiComputerConfiguration.Size = new System.Drawing.Size(189, 28);
            this.tsmiComputerConfiguration.Text = "កំណត់ប្រភេទកុំព្យូទ័រ";
            // 
            // tsmiApplicationLogin
            // 
            this.tsmiApplicationLogin.Name = "tsmiApplicationLogin";
            this.tsmiApplicationLogin.Size = new System.Drawing.Size(189, 28);
            this.tsmiApplicationLogin.Text = "គ្រប់គ្រងអ្នកប្រើប្រាស់";
            // 
            // tsmiProfile
            // 
            this.tsmiProfile.Name = "tsmiProfile";
            this.tsmiProfile.Size = new System.Drawing.Size(189, 28);
            this.tsmiProfile.Text = "សិទ្ធប្រើប្រាស់";
            // 
            // tsmiInterface
            // 
            this.tsmiInterface.Name = "tsmiInterface";
            this.tsmiInterface.Size = new System.Drawing.Size(189, 28);
            this.tsmiInterface.Text = "កម្មវិធី";
            // 
            // tsmiInterfaceDetail
            // 
            this.tsmiInterfaceDetail.Name = "tsmiInterfaceDetail";
            this.tsmiInterfaceDetail.Size = new System.Drawing.Size(189, 28);
            this.tsmiInterfaceDetail.Text = "សិទ្ធចូលប្រើកម្មវិធី";
            // 
            // tsmiCloseChild
            // 
            this.tsmiCloseChild.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiCloseChild.Name = "tsmiCloseChild";
            this.tsmiCloseChild.Size = new System.Drawing.Size(31, 28);
            this.tsmiCloseChild.Text = "X";
            this.tsmiCloseChild.Click += new System.EventHandler(this.tsmiCloseChild_Click);
            // 
            // tsmiEmployee
            // 
            this.tsmiEmployee.Image = global::UMEStockManagmentSystem.Properties.Resources.employee32;
            this.tsmiEmployee.Name = "tsmiEmployee";
            this.tsmiEmployee.Size = new System.Drawing.Size(180, 28);
            this.tsmiEmployee.Text = "ព័ត៌មាន&បុគ្គលិក";
            this.tsmiEmployee.Click += new System.EventHandler(this.tsmiEmployee_Click);
            // 
            // tsmiEmployeeCategory
            // 
            this.tsmiEmployeeCategory.Image = global::UMEStockManagmentSystem.Properties.Resources.employee_category32;
            this.tsmiEmployeeCategory.Name = "tsmiEmployeeCategory";
            this.tsmiEmployeeCategory.Size = new System.Drawing.Size(180, 28);
            this.tsmiEmployeeCategory.Text = "&ប្រភេទបុគ្គលិក";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmMain";
            this.Text = "UME Stock Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeCategory;
        private System.Windows.Forms.ToolStripMenuItem tmsiMainProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiSupplyer;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductCategory;
        private System.Windows.Forms.ToolStripMenuItem tmsiProductUnit;
        private System.Windows.Forms.ToolStripMenuItem tmsiMainStock;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockPurchase;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockAdjustment;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockDispatch;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockPurchaseReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockAdjustmentReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockDispatchReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiComputer;
        private System.Windows.Forms.ToolStripMenuItem tsmiComputerConfiguration;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplicationLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmiInterface;
        private System.Windows.Forms.ToolStripMenuItem tsmiInterfaceDetail;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseChild;
    }
}