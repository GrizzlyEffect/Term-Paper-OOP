using Term_Paper;
using System;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static Term_Paper.Applicant;

namespace Term_Paper

{
    public partial class fMainPageApp : Form
    {

        private BindingList<Applicant> dataSource;
        private SaveFileDialog saveFileDialog;
        private const int PassingScore = 150;

        public fMainPageApp()
        {
            InitializeComponent();
            saveFileDialog = new SaveFileDialog();

        }


        private void btnADD_Click(object sender, EventArgs e)
        {
            NewApplicant data = new NewApplicant("", "", "", "", 0, true, 0.0, false, "");

            fAddApplicant fd = new fAddApplicant(data);
            if (fd.ShowDialog() == DialogResult.OK)
            {
                dataSource.Add(data);
            }

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (gvApplicants.CurrentRow != null)
            {
                Applicant selectedApplicant = (Applicant)gvApplicants.CurrentRow.DataBoundItem;

                fAddApplicant editForm = new fAddApplicant(selectedApplicant);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    gvApplicants.Refresh();
                }
            }
        }


        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (gvApplicants.CurrentRow != null)
            {
                if (MessageBox.Show("Delete current record?", "Delete record",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Applicant data = (Applicant)gvApplicants.CurrentRow.DataBoundItem;
                    dataSource.Remove(data);
                }
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the app?", "Exit the program",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void ApplyFilters()
        {
            string universityFilter = txtFilterUniversity.Text.Trim().ToLower();
            int minScore = (int)numEnrollmentCount.Value;

            var filteredData = dataSource.Where(applicant =>
                (string.IsNullOrEmpty(universityFilter) || applicant.UniversityName.ToLower() == universityFilter) &&
                applicant.AverageGrade >= minScore).ToList();

            gvApplicants.DataSource = null;
            gvApplicants.DataSource = new BindingList<Applicant>(filteredData);
        }




        private void BtnApplyFilters_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void BtnClearFilters_Click(object sender, EventArgs e)
        {
            txtFilterUniversity.Clear();
            numEnrollmentCount.Value = 0;

            gvApplicants.DataSource = null;
            gvApplicants.DataSource = dataSource;
        }

        private void SelectApplicantsForEnrollment(int count)
        {
            var topApplicants = dataSource
                .OrderByDescending(applicant => applicant.AverageGrade)
                .Take(count)
                .ToList();

            gvApplicants.DataSource = null;
            gvApplicants.DataSource = new BindingList<Applicant>(topApplicants);
        }

        private void PrepareInterviewList()
        {
            var interviewList = dataSource
                .Where(applicant => applicant.AverageGrade >= PassingScore && !applicant.HasContract)
                .ToList();

            gvApplicants.DataSource = null;
            gvApplicants.DataSource = new BindingList<Applicant>(interviewList);
        }
        private void btnPrepareInterviewList_Click(object sender, EventArgs e)
        {

            var interviewList = dataSource.Where(applicant =>
                applicant.AverageGrade >= PassingScore && !applicant.HasContract).ToList();

            foreach (var applicant in interviewList)
            {
                applicant.Status = "Interview";
            }

            foreach (var applicant in dataSource)
            {
                if (!interviewList.Contains(applicant))
                {
                    applicant.Status = "Not Enrolled";
                }
            }

            gvApplicants.DataSource = null;
            gvApplicants.DataSource = new BindingList<Applicant>(interviewList);
        }

        private void btnSelectForEnrollment_Click(object sender, EventArgs e)
        {
            var currentData = gvApplicants.DataSource as BindingList<Applicant>;

            if (currentData != null)
            {
                foreach (var applicant in currentData)
                {
                    applicant.Status = "Enrolled";
                }

                foreach (var applicant in dataSource)
                {
                    if (!currentData.Contains(applicant))
                    {
                        applicant.Status = "Not Enrolled";
                    }
                }

                gvApplicants.Refresh();
            }
            else
            {
                MessageBox.Show("No filtered data for enrollment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void fMain_Load(object sender, EventArgs e)
        {

            gvApplicants.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn column;

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FirstName";
            column.Name = "FirstName";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "LastName";
            column.Name = "LastName";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CertificateSeries";
            column.Name = "CertificateSeries";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "UniversityName";
            column.Name = "UniversityName";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "NumberOfSpecialty";
            column.Name = "NumberOfSpecialty";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "EducationFormDisplay";
            column.Name = "EducationForm";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "AverageGrade";
            column.Name = "AverageGrade";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasContractDisplay";
            column.Name = "HasContract";
            gvApplicants.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Status";
            column.Name = "Status";
            gvApplicants.Columns.Add(column);

            dataSource = new BindingList<Applicant>();

            dataSource.Add(new NewApplicant("Vlad", "Saiapin", "VN1234", "VNTU", 126, true, 156, true, "In Process"));
            dataSource.Add(new NewApplicant("Ivan", "Ivanov", "AV3334", "KNU", 014.021, false, 175, false, "In Process"));
            dataSource.Add(new NewApplicant("Petro", "Petrov", "MK5678", "LNTU", 022, true, 132, false, "In Process"));
            dataSource.Add(new NewApplicant("Taras", "Shevchenko", "AB1767", "VNU", 034, false, 200, true, "In Process"));
            dataSource.Add(new NewApplicant("Oleg", "Olegov", "ON1984", "KPI", 162, true, 148, true, "In Process"));
            dataSource.Add(new NewApplicant("Anna", "Krivonogova", "BT2345", "KNU", 056.072, true, 160, false, "In Process"));
            dataSource.Add(new NewApplicant("Dmytro", "Lyashenko", "ZA6789", "NULP", 121, false, 178, true, "In Process"));
            dataSource.Add(new NewApplicant("Maria", "Stepanova", "LM1238", "DniproU", 073, true, 142, false, "In Process"));
            dataSource.Add(new NewApplicant("Sergiy", "Lysak", "KV9182", "KHPI", 113, false, 189, true, "In Process"));
            dataSource.Add(new NewApplicant("Olha", "Bondarenko", "DS5521", "VNTU", 231, true, 149, true, "In Process"));


            gvApplicants.DataSource = dataSource;

            gvApplicants.AutoResizeColumns();

            EventArgs args = new EventArgs();
            OnResize(args);

        }


        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Data Files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Save data in text format";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (Applicant applicant in dataSource)
                    {
                        sw.Write(applicant.FirstName + "\t" + applicant.LastName + "\t" +
                            applicant.CertificateSeries + "\t" + applicant.UniversityName + "\t" + applicant.NumberOfSpecialty + "\t" + applicant.EducationForm + "\t"
                            + applicant.AverageGrade + "\t" +
                            applicant.HasContract + applicant.Status + "\t\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: \n{ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnOpenFromCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Data Files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = "Open data from text format";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataSource.Clear(); sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Applicant applicant = new NewApplicant(split[0], split[1], split[2], split[3],
                            double.Parse(split[4]), bool.Parse(split[5]), double.Parse(split[6]),
                            bool.Parse(split[7]), split[8]);
                        dataSource.Add(applicant);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: \n{ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        private void btnbtnInfo_Click(object sender, EventArgs e)
        {
            fInfo finfoPage = new fInfo();
            finfoPage.Show();

            this.Hide();
        }

    }
}