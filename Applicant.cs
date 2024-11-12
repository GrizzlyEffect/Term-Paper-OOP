using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Paper
{
    public abstract class Applicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CertificateSeries { get; set; }
        public string UniversityName { get; set; }
        public double NumberOfSpecialty { get; set; }
        public bool EducationForm { get; set; }    // true - FullTime, false - Correspondence
        public double AverageGrade { get; set; }
        public bool HasContract { get; set; }
        public string Status { get; set; }

        public string EducationFormDisplay
        {
            get { return EducationForm ? "FullTime" : "Correspondence"; }
        }

        public string HasContractDisplay
        {
            get { return HasContract ? "Yes" : "No"; }
        }


        public Applicant(string firstName, string lastName, string certificateSeries, string universityName,
            double numberofSpecialty, bool educationForm, double averageGrade, bool hasContract, string status)
        {
            FirstName = firstName;
            LastName = lastName;
            CertificateSeries = certificateSeries;
            UniversityName = universityName;
            NumberOfSpecialty = numberofSpecialty;
            EducationForm = educationForm;
            AverageGrade = averageGrade;
            HasContract = hasContract;
            Status = "In Process";
        }



        public class NewApplicant : Applicant
        {
            public NewApplicant() : base("", "", "", "", 0, false, 0.0, false, "")
            {
            }
            public NewApplicant(string firstName, string lastName, string certificateSeries, string universityName,
                double numberofSpecialty, bool educationForm, double averageGrade, bool hasContract, string status)
                : base(firstName, lastName, certificateSeries, universityName, numberofSpecialty, educationForm, averageGrade, hasContract, status)
            {
            }
        }
    }
}