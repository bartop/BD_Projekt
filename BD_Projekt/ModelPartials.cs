
using System.ComponentModel.DataAnnotations;

namespace BD_Projekt
{
    [MetadataType(typeof(RecruitedMetaData))]
    public partial class Recruited
    {
    }
    public partial class RecruitedMetaData
    {
        [RegularExpression(@"(\p{Lu}\p{Ll}+[ |\-|']{0,1})+", ErrorMessage = "Podaj poprawne imię!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Podaj poprawne imię!")]
        public System.DateTime DateOfBirth { get; set; }

        [RegularExpression("^[A-Za-z0-9](([_\\.\\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\\.\\-]?[a-zA-Z0-9]+)*)\\.([A-Za-z]{2,})$", 
            ErrorMessage = "Podaj poprawny adres email!")]
        public string Email { get; set; }

        [RegularExpression(@"\+{0,1}\d{3,12}",
            ErrorMessage = "Podaj poprawny numer telefonu! Tylko cyfry, opcjonalnie + na początku.")]
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }

        [RegularExpression(@"(\p{Lu}\p{Ll}+[ |\-|']{0,1})+", ErrorMessage = "Podaj poprawne nazwisko!")]
        public string Surname { get; set; }

    }

    [MetadataType(typeof(WorkerMetaData))]
    public partial class Worker
    {
    }
    public partial class WorkerMetaData
    {
        [Required(ErrorMessage = "Login jest wymagany!"), StringLength(64, MinimumLength = 1, ErrorMessage = "Zła długość loginu!")]
        public string Login { get; set; }

        [RegularExpression(@"(\p{Lu}\p{Ll}+[ |\-|']{0,1})+", ErrorMessage = "Podaj poprawne imię!")]
        public string Name { get; set; }

        [RegularExpression(@"(\p{Lu}\p{Ll}+[ |\-|']{0,1})+", ErrorMessage = "Podaj poprawne nazwisko!")]
        public string Surname { get; set; }

    }
    public partial class Job
    {
        public override bool Equals(object obj)
        {
            if(obj is Job)
            {
                var job = obj as Job;
                return job.Id == Id && job.Name == Name;
            }
            else return base.Equals(obj);
        }
    }

    public partial class Decision
    {
        public override string ToString()
        {
            string representation;
            if (Accepted)
            {
                representation = "Przyjęty";
            } else
            {
                representation = "Odrzucony";
            }

            return representation;
        }
    }

    public partial class Approval
    {
        public override string ToString()
        {
            if (Approved)
            {
                return "Zaakceptowana";
            } else
            {
                return "Niezaakceptowana";
            }
        }
    }

    public partial class Stage
    {
        public override string ToString()
        {
            return Name;
        }
    }

    public partial class Role
    {
        public const int Administrator = 0;
        public const int Asistant = 1;
        public const int Recruiter = 2;
        public const int Supervisor = 3;
    }
}