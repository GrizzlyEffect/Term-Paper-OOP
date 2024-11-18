using System;
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
            this.Load += fApplicant_Load;

            rbtnForeignYes.CheckedChanged += rbtnForeignYes_CheckedChanged;
            rbtnForeignNo.CheckedChanged += rbtnForeignYes_CheckedChanged;

            txtCountry.Enabled = false;
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

            if (rbtnForeignYes.Checked)
            {
                if (NewApplicant is ForeignApplicant foreignApplicant)
                {
                    if (string.IsNullOrWhiteSpace(txtCountry.Text))
                    {
                        MessageBox.Show("Please enter the country of origin for foreign applicants.", "Validation Error");
                        return;
                    }
                    foreignApplicant.CountryOfOrigin = txtCountry.Text;
                }
                else
                {
                    NewApplicant = new ForeignApplicant(
                        NewApplicant.FirstName,
                        NewApplicant.LastName,
                        NewApplicant.CertificateSeries,
                        NewApplicant.UniversityName,
                        NewApplicant.NumberOfSpecialty,
                        NewApplicant.EducationForm,
                        NewApplicant.AverageGrade,
                        NewApplicant.HasContract,
                        NewApplicant.Status,
                        txtCountry.Text
                    );
                }
            }
            else
            {
                if (NewApplicant is ForeignApplicant foreignApplicant)
                {
                    NewApplicant = new NewApplicant(
                        foreignApplicant.FirstName,
                        foreignApplicant.LastName,
                        foreignApplicant.CertificateSeries,
                        foreignApplicant.UniversityName,
                        foreignApplicant.NumberOfSpecialty,
                        foreignApplicant.EducationForm,
                        foreignApplicant.AverageGrade,
                        foreignApplicant.HasContract,
                        foreignApplicant.Status,
                        "Ukraine"
                    );
                }
            }

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
                cbHasContract.SelectedIndex = NewApplicant.HasContract ? 0 : 1;
                cbEducationForm.SelectedIndex = NewApplicant.EducationForm ? 0 : 1;

                if (NewApplicant is ForeignApplicant foreignApplicant)
                {
                    rbtnForeignYes.Checked = true;
                    txtCountry.Enabled = true;
                    txtCountry.Text = foreignApplicant.CountryOfOrigin;
                }
                else
                {
                    rbtnForeignNo.Checked = true;
                    txtCountry.Enabled = false;
                    txtCountry.Text = "Ukraine";
                }
            }
        }


        private void rbtnForeignYes_CheckedChanged(object sender, EventArgs e)
        {
            txtCountry.Enabled = rbtnForeignYes.Checked;
            if (!rbtnForeignYes.Checked)
            {
                txtCountry.Text = "Ukraine";
            }
        }
    }
}
