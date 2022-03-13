namespace Session_07
{
    partial class FormInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInterface));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProfessorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadUniversitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadStudentsToolStripMenuItem,
            this.loadProfessorsToolStripMenuItem,
            this.loadUniversitiesToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // loadStudentsToolStripMenuItem
            // 
            this.loadStudentsToolStripMenuItem.Name = "loadStudentsToolStripMenuItem";
            this.loadStudentsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadStudentsToolStripMenuItem.Text = "Load Students";
            this.loadStudentsToolStripMenuItem.Click += new System.EventHandler(this.loadStudentsToolStripMenuItem_Click);
            // 
            // loadProfessorsToolStripMenuItem
            // 
            this.loadProfessorsToolStripMenuItem.Name = "loadProfessorsToolStripMenuItem";
            this.loadProfessorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadProfessorsToolStripMenuItem.Text = "Load Professors";
            this.loadProfessorsToolStripMenuItem.Click += new System.EventHandler(this.loadProfessorsToolStripMenuItem_Click);
            // 
            // loadUniversitiesToolStripMenuItem
            // 
            this.loadUniversitiesToolStripMenuItem.Name = "loadUniversitiesToolStripMenuItem";
            this.loadUniversitiesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadUniversitiesToolStripMenuItem.Text = "Load Universities";
            this.loadUniversitiesToolStripMenuItem.Click += new System.EventHandler(this.loadUniversitiesToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.professorsToolStripMenuItem,
            this.universitiesToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // professorsToolStripMenuItem
            // 
            this.professorsToolStripMenuItem.Name = "professorsToolStripMenuItem";
            this.professorsToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.professorsToolStripMenuItem.Text = "Professors";
            this.professorsToolStripMenuItem.Click += new System.EventHandler(this.professorsToolStripMenuItem_Click);
            // 
            // universitiesToolStripMenuItem
            // 
            this.universitiesToolStripMenuItem.Name = "universitiesToolStripMenuItem";
            this.universitiesToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.universitiesToolStripMenuItem.Text = "Universities";
            this.universitiesToolStripMenuItem.Click += new System.EventHandler(this.universitiesToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 24);
            this.toolStripLabel1.Text = "Load";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // FormInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormInterface";
            this.Text = "FormInterface";
            this.Load += new System.EventHandler(this.FormInterface_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem loadStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProfessorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadUniversitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}