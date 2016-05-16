

namespace BD_Projekt
{
    public partial class Application
    {
        public override bool Equals(object obj)
        {
            if (obj is Application)
            {
                var appl = obj as Application;
                return this.Id == appl.Id && this.Approved == appl.Approved && this.Employed == appl.Employed
                    && this.Explenation == appl.Explenation && this.Resigned == appl.Resigned &&
                    this.YearsOfExpirience == appl.YearsOfExpirience;
            }
            else return base.Equals(obj);
        }

        static public bool operator ==(Application appl1, Application appl2)
        {
            return appl1.Equals(appl2);
        }

        static public bool operator !=(Application appl1, Application appl2)
        {
            return !appl1.Equals(appl2);
        }
    }

    public partial class Document
    {
        public override bool Equals(object obj)
        {
            if (obj is Document)
            {
                var doc = obj as Document;
                return this.Id == doc.Id && this.File == doc.File;
            }
            else return base.Equals(obj);
        }

        static public bool operator ==(Document doc1, Document doc2)
        {
            return doc1.Equals(doc2);
        }

        static public bool operator !=(Document doc1, Document doc2)
        {
            return !doc1.Equals(doc2);
        }
    }

    public partial class Job
    {
        public override bool Equals(object obj)
        {
            if(obj is Job)
            {
                var job = obj as Job;
                return this.Id == job.Id && this.Name == job.Name;
            }
            else return base.Equals(obj);
        }

        static public bool operator==(Job job1,Job job2)
        {
            return job1.Equals(job2);
        }

        static public bool operator!=(Job job1, Job job2)
        {
            return !job1.Equals(job2);
        }
    }

    public partial class Recruited
    {
        public override bool Equals(object obj)
        {
            if (obj is Recruited)
            {
                var recruited = obj as Recruited;
                return this.Id == recruited.Id && this.Name == recruited.Name && 
                    this.Nationality == recruited.Nationality && this.PhoneNumber == recruited.PhoneNumber &&
                    this.DateOfBirth == recruited.DateOfBirth && this.Education == recruited.Education &&
                    this.email == recruited.email && this.FathersName == recruited.FathersName;
            }
            else return base.Equals(obj);
        }

        static public bool operator ==(Recruited rec1, Recruited rec2)
        {
            return rec1.Equals(rec2);
        }

        static public bool operator !=(Recruited rec1, Recruited rec2)
        {
            return !rec1.Equals(rec2);
        }
    }

    public partial class Role
    {
        public override bool Equals(object obj)
        {
            if (obj is Role)
            {
                var role = obj as Role;
                return this.Id == role.Id && this.Name == role.Name;
            }
            else return base.Equals(obj);
        }

        static public bool operator ==(Role job1, Role role2)
        {
            return job1.Equals(role2);
        }

        static public bool operator !=(Role role1, Role role2)
        {
            return !role1.Equals(role2);
        }
    }

    public partial class Skill
    {
        public override bool Equals(object obj)
        {
            if (obj is Skill)
            {
                var skill = obj as Skill;
                return this.Id == skill.Id && this.Name == skill.Name;
            }
            else return base.Equals(obj);
        }

        static public bool operator ==(Skill skill1, Skill skill2)
        {
            return skill1.Equals(skill2);
        }

        static public bool operator !=(Skill skill1, Skill skill2)
        {
            return !skill1.Equals(skill2);
        }
    } 

    public partial class Stage
    {
        public override bool Equals(object obj)
        {
            if (obj is Stage)
            {
                var stage = obj as Stage;
                return this.Id == stage.Id && this.Name == stage.Name;
            }
            else return base.Equals(obj);
        }

        static public bool operator ==(Stage stage1, Stage stage2)
        {
            return stage1.Equals(stage2);
        }

        static public bool operator !=(Stage stage1, Stage stage2)
        {
            return !stage1.Equals(stage2);
        }
    }

    public partial class Worker
    {
        public override bool Equals(object obj)
        {
            if (obj is Worker)
            {
                var worker = obj as Worker;
                return this.Id == worker.Id && this.Name == worker.Name && 
                    this.PasswordHash == worker.PasswordHash;
            }
            else return base.Equals(obj);
        }

        static public bool operator ==(Worker worker1, Worker worker2)
        {
            return worker1.Equals(worker2);
        }

        static public bool operator !=(Worker worker1, Worker worker2)
        {
            return !worker1.Equals(worker2);
        }
    }
}