namespace Session_11
{
    partial class FormPetReport
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
            DevExpress.XtraLayout.LayoutControlItem ctrlAnimalType;
            this.comboBoxAnimalType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridPetReport = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ctrlTotalSold = new System.Windows.Forms.TextBox();
            this.ctrlYear = new System.Windows.Forms.TextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Year = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.TotalPet = new DevExpress.XtraLayout.LayoutControlItem();
            this.Month = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsLedger = new System.Windows.Forms.BindingSource(this.components);
            ctrlAnimalType = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(ctrlAnimalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAnimalType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlAnimalType
            // 
            ctrlAnimalType.Control = this.comboBoxAnimalType;
            ctrlAnimalType.CustomizationFormText = "ctrlAnimalType";
            ctrlAnimalType.Location = new System.Drawing.Point(0, 55);
            ctrlAnimalType.Name = "ctrlAnimalType";
            ctrlAnimalType.Size = new System.Drawing.Size(229, 26);
            ctrlAnimalType.Text = "Animal Type";
            ctrlAnimalType.TextSize = new System.Drawing.Size(71, 16);
            // 
            // comboBoxAnimalType
            // 
            this.comboBoxAnimalType.Location = new System.Drawing.Point(95, 67);
            this.comboBoxAnimalType.Name = "comboBoxAnimalType";
            this.comboBoxAnimalType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxAnimalType.Size = new System.Drawing.Size(142, 22);
            this.comboBoxAnimalType.StyleController = this.layoutControl1;
            this.comboBoxAnimalType.TabIndex = 7;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridPetReport);
            this.layoutControl1.Controls.Add(this.comboBoxAnimalType);
            this.layoutControl1.Controls.Add(this.btnExit);
            this.layoutControl1.Controls.Add(this.btnEnter);
            this.layoutControl1.Controls.Add(this.comboBoxMonth);
            this.layoutControl1.Controls.Add(this.ctrlTotalSold);
            this.layoutControl1.Controls.Add(this.ctrlYear);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 451);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridLedger
            // 
            this.gridPetReport.Location = new System.Drawing.Point(12, 122);
            this.gridPetReport.MainView = this.gridView1;
            this.gridPetReport.Name = "gridLedger";
            this.gridPetReport.Size = new System.Drawing.Size(776, 241);
            this.gridPetReport.TabIndex = 8;
            this.gridPetReport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridPetReport;
            this.gridView1.Name = "gridView1";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(12, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(776, 29);
            this.btnExit.StyleController = this.layoutControl1;
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.Appearance.Options.UseFont = true;
            this.btnEnter.Location = new System.Drawing.Point(12, 367);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(776, 29);
            this.btnEnter.StyleController = this.layoutControl1;
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Location = new System.Drawing.Point(95, 41);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxMonth.Properties.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxMonth.Size = new System.Drawing.Size(62, 22);
            this.comboBoxMonth.StyleController = this.layoutControl1;
            this.comboBoxMonth.TabIndex = 2;
            // 
            // ctrlTotalSold
            // 
            this.ctrlTotalSold.Location = new System.Drawing.Point(95, 93);
            this.ctrlTotalSold.Name = "ctrlTotalSold";
            this.ctrlTotalSold.Size = new System.Drawing.Size(61, 25);
            this.ctrlTotalSold.TabIndex = 4;
            // 
            // ctrlYear
            // 
            this.ctrlYear.Location = new System.Drawing.Point(95, 12);
            this.ctrlYear.Name = "ctrlYear";
            this.ctrlYear.Size = new System.Drawing.Size(61, 25);
            this.ctrlYear.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Year,
            this.emptySpaceItem1,
            this.TotalPet,
            this.Month,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.emptySpaceItem7,
            this.emptySpaceItem8,
            this.emptySpaceItem9,
            this.emptySpaceItem10,
            this.emptySpaceItem11,
            this.emptySpaceItem12,
            this.layoutControlItem1,
            this.layoutControlItem2,
            ctrlAnimalType,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 451);
            this.Root.TextVisible = false;
            // 
            // Year
            // 
            this.Year.Control = this.ctrlYear;
            this.Year.Location = new System.Drawing.Point(0, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(148, 29);
            this.Year.TextSize = new System.Drawing.Size(71, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 421);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // TotalPet
            // 
            this.TotalPet.Control = this.ctrlTotalSold;
            this.TotalPet.Location = new System.Drawing.Point(0, 81);
            this.TotalPet.Name = "TotalPet";
            this.TotalPet.Size = new System.Drawing.Size(148, 29);
            this.TotalPet.Text = "Total Sold";
            this.TotalPet.TextSize = new System.Drawing.Size(71, 16);
            // 
            // Month
            // 
            this.Month.Control = this.comboBoxMonth;
            this.Month.Location = new System.Drawing.Point(0, 29);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(149, 26);
            this.Month.TextSize = new System.Drawing.Size(71, 16);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(390, 55);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(390, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(390, 29);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(390, 26);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(213, 29);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(177, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(390, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(390, 29);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(203, 0);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(187, 29);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(148, 0);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(55, 29);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(229, 55);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(161, 26);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(149, 29);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(64, 26);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(390, 81);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(390, 29);
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.Location = new System.Drawing.Point(199, 81);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(191, 29);
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem12
            // 
            this.emptySpaceItem12.AllowHotTrack = false;
            this.emptySpaceItem12.Location = new System.Drawing.Point(148, 81);
            this.emptySpaceItem12.Name = "emptySpaceItem12";
            this.emptySpaceItem12.Size = new System.Drawing.Size(51, 29);
            this.emptySpaceItem12.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnEnter;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 355);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 33);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnExit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 388);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(780, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridPetReport;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(780, 245);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // FormPetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormPetReport";
            this.Text = "FormPetReport";
            this.Load += new System.EventHandler(this.FormPetReport_Load);
            ((System.ComponentModel.ISupportInitialize)(ctrlAnimalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAnimalType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLedger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxMonth;
        private TextBox ctrlTotalSold;
        private TextBox ctrlYear;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem Year;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem TotalPet;
        private DevExpress.XtraLayout.LayoutControlItem Month;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxAnimalType;
        private DevExpress.XtraLayout.LayoutControlItem ctrlAnimalType;
        private BindingSource bsLedger;
        private DevExpress.XtraGrid.GridControl gridPetReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}