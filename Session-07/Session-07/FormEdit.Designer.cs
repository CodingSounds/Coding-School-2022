namespace Session_07
{
    partial class FormEdit
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
            this.listOfObject = new DevExpress.XtraEditors.ListBoxControl();
            this.listOfCourses = new DevExpress.XtraEditors.ListBoxControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtAge = new DevExpress.XtraEditors.TextEdit();
            this.txtRegNumber = new DevExpress.XtraEditors.TextEdit();
            this.listOfStudents = new DevExpress.XtraEditors.ListBoxControl();
            this.listOfGrades = new DevExpress.XtraEditors.ListBoxControl();
            this.ListOfShedule = new DevExpress.XtraEditors.ListBoxControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listOfObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfShedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfObject
            // 
            this.listOfObject.Location = new System.Drawing.Point(72, 14);
            this.listOfObject.Margin = new System.Windows.Forms.Padding(5);
            this.listOfObject.Name = "listOfObject";
            this.listOfObject.Size = new System.Drawing.Size(256, 469);
            this.listOfObject.TabIndex = 0;
            this.listOfObject.SelectedIndexChanged += new System.EventHandler(this.listOfObject_SelectedIndexChanged);
            this.listOfObject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listOfObject_MouseClick);
            // 
            // listOfCourses
            // 
            this.listOfCourses.Location = new System.Drawing.Point(338, 128);
            this.listOfCourses.Margin = new System.Windows.Forms.Padding(5);
            this.listOfCourses.Name = "listOfCourses";
            this.listOfCourses.Size = new System.Drawing.Size(286, 149);
            this.listOfCourses.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(462, 14);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(286, 28);
            this.txtName.TabIndex = 3;
            this.txtName.EditValueChanged += new System.EventHandler(this.txtName_EditValueChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(462, 52);
            this.txtAge.Margin = new System.Windows.Forms.Padding(5);
            this.txtAge.Name = "txtAge";
            this.txtAge.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAge.Properties.Appearance.Options.UseFont = true;
            this.txtAge.Size = new System.Drawing.Size(286, 28);
            this.txtAge.TabIndex = 4;
            this.txtAge.EditValueChanged += new System.EventHandler(this.txtAge_EditValueChanged);
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(462, 90);
            this.txtRegNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtRegNumber.Properties.Appearance.Options.UseFont = true;
            this.txtRegNumber.Size = new System.Drawing.Size(286, 28);
            this.txtRegNumber.TabIndex = 5;
            // 
            // listOfStudents
            // 
            this.listOfStudents.Location = new System.Drawing.Point(338, 287);
            this.listOfStudents.Margin = new System.Windows.Forms.Padding(5);
            this.listOfStudents.Name = "listOfStudents";
            this.listOfStudents.Size = new System.Drawing.Size(286, 149);
            this.listOfStudents.TabIndex = 6;
            // 
            // listOfGrades
            // 
            this.listOfGrades.Location = new System.Drawing.Point(626, 128);
            this.listOfGrades.Margin = new System.Windows.Forms.Padding(5);
            this.listOfGrades.Name = "listOfGrades";
            this.listOfGrades.Size = new System.Drawing.Size(286, 149);
            this.listOfGrades.TabIndex = 7;
            this.listOfGrades.SelectedIndexChanged += new System.EventHandler(this.listOfGrades_SelectedIndexChanged);
            // 
            // ListOfShedule
            // 
            this.ListOfShedule.Location = new System.Drawing.Point(626, 287);
            this.ListOfShedule.Margin = new System.Windows.Forms.Padding(5);
            this.ListOfShedule.Name = "ListOfShedule";
            this.ListOfShedule.Size = new System.Drawing.Size(286, 149);
            this.ListOfShedule.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 12.8F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(508, 446);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 78);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 12.8F);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(370, 446);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 78);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 12.8F);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Location = new System.Drawing.Point(646, 446);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(128, 78);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 12.8F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(784, 446);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 78);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(UniversityLibrary.Student);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.bindingSource1;
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this.bindingSource1;
            // 
            // coursesBindingSource2
            // 
            this.coursesBindingSource2.DataMember = "Courses";
            this.coursesBindingSource2.DataSource = this.bindingSource1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(896, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Subject";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 590);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ListOfShedule);
            this.Controls.Add(this.listOfGrades);
            this.Controls.Add(this.listOfStudents);
            this.Controls.Add(this.txtRegNumber);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.listOfCourses);
            this.Controls.Add(this.listOfObject);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfShedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.ListBoxControl listOfObject;//ego
        private DevExpress.XtraEditors.ListBoxControl listOfCourses;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtAge;
        private DevExpress.XtraEditors.TextEdit txtRegNumber;
        private DevExpress.XtraEditors.ListBoxControl listOfStudents;
        private DevExpress.XtraEditors.ListBoxControl listOfGrades;
        private DevExpress.XtraEditors.ListBoxControl ListOfShedule;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private System.Windows.Forms.BindingSource coursesBindingSource2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}