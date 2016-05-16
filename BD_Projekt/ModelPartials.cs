
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
}