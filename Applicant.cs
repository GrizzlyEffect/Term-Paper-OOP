using System;

namespace Term_Paper
{
    public interface IComparableApplicant
    {
        int CompareTo(Applicant other);
    }

    public abstract class Applicant : IComparableApplicant
    {
        private string firstName;
        private string lastName;
        private string certificateSeries;
        private string universityName;
        private int numberOfSpecialty;
        private bool educationForm;
        private double averageGrade;
        private bool hasContract;
        protected string status;
        private string countryOfOrigin;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string CertificateSeries
        {
            get { return certificateSeries; }
            set { certificateSeries = value; }
        }

        public string UniversityName
        {
            get { return universityName; }
            set { universityName = value; }
        }

        public int NumberOfSpecialty
        {
            get { return numberOfSpecialty; }
            set { numberOfSpecialty = value; }
        }

        public bool EducationForm
        {
            get { return educationForm; }
            set { educationForm = value; }
        }

        public double AverageGrade
        {
            get { return averageGrade; }
            set { averageGrade = value; }
        }

        public bool HasContract
        {
            get { return hasContract; }
            set { hasContract = value; }
        }

        public string Status
        {
            get { return status; }
            protected set { status = value; }
        }

        public string GetStatus()
        {
            return Status;
        }

        public void SetStatus(string newStatus)
        {
            Status = newStatus;
        }

        public string CountryOfOrigin
        {
            get { return countryOfOrigin; }
            set { countryOfOrigin = value; }
        }

        public string EducationFormDisplay
        {
            get { return EducationForm ? "FullTime" : "Correspondence"; }
        }

        public string HasContractDisplay
        {
            get { return HasContract ? "Yes" : "No"; }
        }

        public Applicant() : this("", "", "", "", 0, false, 0.0, false, "In Process", "Ukraine") { }

        public Applicant(string firstName, string lastName, string certificateSeries, string universityName,
            int numberOfSpecialty, bool educationForm, double averageGrade, bool hasContract, string status, string countryOfOrigin)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.certificateSeries = certificateSeries;
            this.universityName = universityName;
            this.numberOfSpecialty = numberOfSpecialty;
            this.educationForm = educationForm;
            this.averageGrade = averageGrade;
            this.hasContract = hasContract;
            this.status = status;
            this.countryOfOrigin = countryOfOrigin;
        }

        public int CompareTo(Applicant other)
        {
            if (other == null) return 1;
            return AverageGrade.CompareTo(other.AverageGrade);
        }

        public virtual string DisplayInfo()
        {
            return $"{FirstName} {LastName}, University: {UniversityName}, Specialty: {NumberOfSpecialty}, Grade: {AverageGrade}, Status: {Status}, Country: {CountryOfOrigin}";
        }
    }

    public class NewApplicant : Applicant
    {
        public NewApplicant() : base() { }

        public NewApplicant(string firstName, string lastName, string certificateSeries, string universityName,
            int numberOfSpecialty, bool educationForm, double averageGrade, bool hasContract, string status, string countryofOrigin) :
            base(firstName, lastName, certificateSeries, universityName, numberOfSpecialty, educationForm, averageGrade, hasContract, status, countryofOrigin)
        { }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " (New Applicant)";
        }
    }


    public class ForeignApplicant : NewApplicant
    {
        private string countryOfOrigin;

        public string CountryOfOrigin
        {
            get { return countryOfOrigin; }
            set { countryOfOrigin = value; }
        }

        public ForeignApplicant() : this("Ukraine") { }

        public ForeignApplicant(string countryOfOrigin) : base()
        {
            this.countryOfOrigin = countryOfOrigin;
        }

        public ForeignApplicant(string firstName, string lastName, string certificateSeries, string universityName,
                                int numberOfSpecialty, bool educationForm, double averageGrade, bool hasContract,
                                string status, string countryOfOrigin)
            : base(firstName, lastName, certificateSeries, universityName, numberOfSpecialty, educationForm, averageGrade, hasContract, status, countryOfOrigin)
        {
            this.countryOfOrigin = countryOfOrigin;
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $", Country of Origin: {CountryOfOrigin}";
        }
    }

}