using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Paper
{
    public interface IComparableApplicant
    {
        int CompareTo(Applicant other);
    }

    public abstract class Applicant : IComparableApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CertificateSeries { get; set; }
        public string UniversityName { get; set; }
        public double NumberOfSpecialty { get; set; }
        public bool EducationForm { get; set; }
        public double AverageGrade { get; set; }
        public bool HasContract { get; set; }
        public string Status { get; set; }

        // Використання захищеного доступу
        protected string EducationFormDisplay => EducationForm ? "FullTime" : "Correspondence";
        protected string HasContractDisplay => HasContract ? "Yes" : "No";

        // Конструктор без аргументів
        public Applicant()
        {
            FirstName = "";
            LastName = "";
            CertificateSeries = "";
            UniversityName = "";
            NumberOfSpecialty = 0;
            EducationForm = false;
            AverageGrade = 0.0;
            HasContract = false;
            Status = "In Process";
        }

        // Порівняння за середнім балом для реалізації IComparable
        public int CompareTo(Applicant other)
        {
            if (other == null) return 1;
            return this.AverageGrade.CompareTo(other.AverageGrade);
        }

        // Конструктор з параметрами
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
            Status = status;
        }
    }

    public class NewApplicant : Applicant
    {
        // Використання делегування конструктора
        public NewApplicant() : base()
        {
        }

        public NewApplicant(string firstName, string lastName, string certificateSeries, string universityName,
            double numberofSpecialty, bool educationForm, double averageGrade, bool hasContract, string status)
            : base(firstName, lastName, certificateSeries, universityName, numberofSpecialty, educationForm, averageGrade, hasContract, status)
        {
        }
    }
}