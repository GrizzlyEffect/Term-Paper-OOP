namespace Term_Paper
{
    partial class fMainPageApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainPageApp));
            toolStrip1 = new ToolStrip();
            btnEXIT = new ToolStripButton();
            btnMainPage = new ToolStripButton();
            btnInfo = new ToolStripButton();
            bindSrcApplicants = new BindingSource(components);
            gvApplicants = new DataGridView();
            btnADD = new Button();
            btnEDIT = new Button();
            btnDEL = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnPrepareInterviewList = new Button();
            btnOpenFromCSV = new Button();
            btnSelectForEnrollment = new Button();
            btnSaveAsBinary = new Button();
            groupBox3 = new GroupBox();
            txtFilterUniversity = new TextBox();
            numEnrollmentCount = new NumericUpDown();
            btnApplyFilters = new Button();
            btnClearFilters = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindSrcApplicants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvApplicants).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEnrollmentCount).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnEXIT, btnMainPage, btnInfo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1502, 30);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnEXIT
            // 
            btnEXIT.Alignment = ToolStripItemAlignment.Right;
            btnEXIT.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEXIT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEXIT.Image = (Image)resources.GetObject("btnEXIT.Image");
            btnEXIT.ImageTransparentColor = Color.Magenta;
            btnEXIT.Name = "btnEXIT";
            btnEXIT.Size = new Size(41, 27);
            btnEXIT.Text = "Exit";
            btnEXIT.Click += btnEXIT_Click;
            // 
            // btnMainPage
            // 
            btnMainPage.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnMainPage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnMainPage.Image = (Image)resources.GetObject("btnMainPage.Image");
            btnMainPage.ImageTransparentColor = Color.Magenta;
            btnMainPage.Margin = new Padding(10, 1, 10, 2);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(94, 27);
            btnMainPage.Text = "Main Page";
            // 
            // btnInfo
            // 
            btnInfo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnInfo.Image = (Image)resources.GetObject("btnInfo.Image");
            btnInfo.ImageTransparentColor = Color.Magenta;
            btnInfo.Margin = new Padding(10, 1, 10, 2);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(44, 27);
            btnInfo.Text = "Info";
            btnInfo.Click += btnbtnInfo_Click;
            // 
            // gvApplicants
            // 
            gvApplicants.AllowUserToAddRows = false;
            gvApplicants.AllowUserToDeleteRows = false;
            gvApplicants.AutoGenerateColumns = false;
            gvApplicants.BackgroundColor = SystemColors.Menu;
            gvApplicants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvApplicants.DataSource = bindSrcApplicants;
            gvApplicants.Location = new Point(0, 27);
            gvApplicants.Margin = new Padding(3, 4, 3, 4);
            gvApplicants.Name = "gvApplicants";
            gvApplicants.ReadOnly = true;
            gvApplicants.RowHeadersWidth = 51;
            gvApplicants.Size = new Size(1187, 390);
            gvApplicants.TabIndex = 1;
            // 
            // btnADD
            // 
            btnADD.AutoSize = true;
            btnADD.Location = new Point(6, 22);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(113, 30);
            btnADD.TabIndex = 2;
            btnADD.Text = "Add";
            btnADD.UseVisualStyleBackColor = true;
            btnADD.Click += btnADD_Click;
            // 
            // btnEDIT
            // 
            btnEDIT.AutoSize = true;
            btnEDIT.Location = new Point(150, 22);
            btnEDIT.Name = "btnEDIT";
            btnEDIT.Size = new Size(113, 30);
            btnEDIT.TabIndex = 3;
            btnEDIT.Text = "Edit";
            btnEDIT.UseVisualStyleBackColor = true;
            btnEDIT.Click += btnEDIT_Click;
            // 
            // btnDEL
            // 
            btnDEL.AutoSize = true;
            btnDEL.Location = new Point(80, 58);
            btnDEL.Name = "btnDEL";
            btnDEL.Size = new Size(113, 30);
            btnDEL.TabIndex = 4;
            btnDEL.Text = "Delete";
            btnDEL.UseVisualStyleBackColor = true;
            btnDEL.Click += btnDEL_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnADD);
            groupBox1.Controls.Add(btnDEL);
            groupBox1.Controls.Add(btnEDIT);
            groupBox1.Location = new Point(1215, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 99);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPrepareInterviewList);
            groupBox2.Controls.Add(btnOpenFromCSV);
            groupBox2.Controls.Add(btnSelectForEnrollment);
            groupBox2.Controls.Add(btnSaveAsBinary);
            groupBox2.Location = new Point(1215, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 151);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // btnPrepareInterviewList
            // 
            btnPrepareInterviewList.Location = new Point(53, 67);
            btnPrepareInterviewList.Name = "btnPrepareInterviewList";
            btnPrepareInterviewList.Size = new Size(177, 30);
            btnPrepareInterviewList.TabIndex = 1;
            btnPrepareInterviewList.Text = "Prepare Interview List";
            btnPrepareInterviewList.UseVisualStyleBackColor = true;
            btnPrepareInterviewList.Click += btnPrepareInterviewList_Click;
            // 
            // btnOpenFromCSV
            // 
            btnOpenFromCSV.Location = new Point(150, 26);
            btnOpenFromCSV.Name = "btnOpenFromCSV";
            btnOpenFromCSV.Size = new Size(113, 30);
            btnOpenFromCSV.TabIndex = 1;
            btnOpenFromCSV.Text = "Load";
            btnOpenFromCSV.UseVisualStyleBackColor = true;
            btnOpenFromCSV.Click += btnOpenFromCSV_Click;
            // 
            // btnSelectForEnrollment
            // 
            btnSelectForEnrollment.Location = new Point(53, 107);
            btnSelectForEnrollment.Name = "btnSelectForEnrollment";
            btnSelectForEnrollment.Size = new Size(177, 30);
            btnSelectForEnrollment.TabIndex = 0;
            btnSelectForEnrollment.Text = "Select For Enrollment";
            btnSelectForEnrollment.UseVisualStyleBackColor = true;
            btnSelectForEnrollment.Click += btnSelectForEnrollment_Click;
            // 
            // btnSaveAsBinary
            // 
            btnSaveAsBinary.Location = new Point(6, 26);
            btnSaveAsBinary.Name = "btnSaveAsBinary";
            btnSaveAsBinary.Size = new Size(113, 30);
            btnSaveAsBinary.TabIndex = 0;
            btnSaveAsBinary.Text = "Save";
            btnSaveAsBinary.UseVisualStyleBackColor = true;
            btnSaveAsBinary.Click += btnSaveAsCSV_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtFilterUniversity);
            groupBox3.Controls.Add(numEnrollmentCount);
            groupBox3.Controls.Add(btnApplyFilters);
            groupBox3.Controls.Add(btnClearFilters);
            groupBox3.Location = new Point(1215, 295);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(271, 122);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // txtFilterUniversity
            // 
            txtFilterUniversity.Location = new Point(19, 26);
            txtFilterUniversity.Name = "txtFilterUniversity";
            txtFilterUniversity.PlaceholderText = "University";
            txtFilterUniversity.Size = new Size(113, 27);
            txtFilterUniversity.TabIndex = 10;
            // 
            // numEnrollmentCount
            // 
            numEnrollmentCount.Location = new Point(150, 27);
            numEnrollmentCount.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numEnrollmentCount.Name = "numEnrollmentCount";
            numEnrollmentCount.Size = new Size(80, 27);
            numEnrollmentCount.TabIndex = 11;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Location = new Point(19, 70);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(100, 36);
            btnApplyFilters.TabIndex = 13;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.Click += BtnApplyFilters_Click;
            // 
            // btnClearFilters
            // 
            btnClearFilters.Location = new Point(150, 70);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(100, 36);
            btnClearFilters.TabIndex = 14;
            btnClearFilters.Text = "Clear Filters";
            btnClearFilters.Click += BtnClearFilters_Click;
            // 
            // fMainPageApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1502, 435);
            ControlBox = false;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gvApplicants);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fMainPageApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enrollment of applicants";
            Load += fMain_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindSrcApplicants).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvApplicants).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEnrollmentCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private BindingSource bindSrcApplicants;
        private DataGridView gvApplicants;
        private ToolStripButton btnEXIT;
        private ToolStripButton btnInfo;
        private Button btnADD;
        private Button btnEDIT;
        private Button btnDEL;
        private ToolStripButton btnMainPage;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnOpenFromCSV;
        private Button btnSaveAsBinary;
        private GroupBox groupBox3;
        private Button btnPrepareInterviewList;
        private Button btnSelectForEnrollment;
        private TextBox txtFilterUniversity;
        private NumericUpDown numEnrollmentCount;
        private Button btnApplyFilters;
        private Button btnClearFilters;
    }
}
