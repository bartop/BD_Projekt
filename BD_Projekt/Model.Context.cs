using System.Collections.Generic;
using System.Linq;

namespace BD_Projekt
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Validation;
    using System.Windows.Forms;

    public partial class DataModelContainer : DbContext
    {
        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            var result = new DbEntityValidationResult(entityEntry, new List<DbValidationError>());
            if(entityEntry.Entity is Skill)
            {
                var skill = entityEntry.Entity as Skill;
                int copies = SkillSet.Where(p => p.Name == skill.Name).Count();
                if ((entityEntry.State == EntityState.Added) && copies > 0)
                {
                    result.ValidationErrors.Add(new 
                        DbValidationError("Name", "Nazwy umiejętności muszą być unikalne!"));
                }
            }else if(entityEntry.Entity is Job)
            {
                var job = entityEntry.Entity as Job;
                int copies = JobSet.Where(p => p.Name == job.Name).Count();
                if ((entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified) 
                    && copies > 0)
                {
                    result.ValidationErrors.Add(new
                        DbValidationError("Name", "Nazwy stanowisk muszą być unikalne!"));
                }
            }else if(entityEntry.Entity is Application)
            {
                var application = entityEntry.Entity as Application;
                int copies = ApplicationSet
                    .Where(a => a.Job.Id == application.Job.Id 
                    && a.Recruited.Id == application.Recruited.Id
                    && a.Assistant.Id == application.Assistant.Id).Count();
                if ((entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified)
                    && copies > 0)
                {
                    result.ValidationErrors.Add(new
                        DbValidationError("Name", "Aplikacje muszą być unikalne!"));
                }
            }else if(entityEntry.Entity is Posesses)
            {
                var skillGrade = entityEntry.Entity as Posesses;
                int copies = PosessesSet.Where(p => p.Recruited.Id == skillGrade.Recruited.Id
                    && p.Skills.Id == skillGrade.Skills.Id).Count();
                if ((entityEntry.State == EntityState.Added || entityEntry.State == EntityState.Modified)
                     && copies > 0)
                {
                    result.ValidationErrors.Add(new
                        DbValidationError("Name", "Nie można dodać dwóch ocen tej samej umiejętności!"));
                }
            }

            if (result.ValidationErrors.Count > 0) return result;
            else return base.ValidateEntity(entityEntry, items);
        }

        public static void handleValidationException(DbEntityValidationException exception)
        {
            foreach (var validationErrors in exception.EntityValidationErrors)
            {
                foreach (var validationError in validationErrors.ValidationErrors)
                {
                    MessageBox.Show(validationError.ErrorMessage);
                }
            }
        }
    }
}
