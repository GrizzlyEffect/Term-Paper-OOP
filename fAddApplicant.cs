using Term_Paper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Term_Paper
{
    public partial class fAddApplicant : Form
    {
        public Applicant NewApplicant;
        public fAddApplicant(Applicant t)
        {
            NewApplicant = t;
            InitializeComponent();
            this.Load += new System.EventHandler(this.fApplicant_Load);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NewApplicant.FirstName = tbFirstName.Text.Trim();
            NewApplicant.LastName = tbLastName.Text.Trim();
            NewApplicant.CertificateSeries = tbCertificate.Text.Trim();
            NewApplicant.UniversityName = tbUniverName.Text.Trim();
            NewApplicant.NumberOfSpecialty = int.Parse(tbSpeciality.Text.Trim());
            NewApplicant.AverageGrade = double.Parse(tbAverGrade.Text.Trim());
            NewApplicant.HasContract = cbHasContract.SelectedIndex == 0;
            NewApplicant.EducationForm = cbEducationForm.SelectedIndex == 0;


            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fApplicant_Load(object sender, EventArgs e)
        {
            if (NewApplicant != null)
            {
                tbFirstName.Text = NewApplicant.FirstName;
                tbLastName.Text = NewApplicant.LastName;
                tbCertificate.Text = NewApplicant.CertificateSeries;
                tbUniverName.Text = NewApplicant.UniversityName;
                tbSpeciality.Text = NewApplicant.NumberOfSpecialty.ToString();
                tbAverGrade.Text = NewApplicant.AverageGrade.ToString("0.00");
                cbHasContract.SelectedIndex = NewApplicant.HasContract ? 0 : 1; // 0 - "Yes", 1 - "No"
                cbEducationForm.SelectedIndex = NewApplicant.EducationForm ? 0 : 1; // 0 - "FullTime", 1 - "Correspondence"

            }
        }
    }
}