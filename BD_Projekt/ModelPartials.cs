
namespace BD_Projekt
{
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