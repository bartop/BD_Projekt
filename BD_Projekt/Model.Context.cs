﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD_Projekt
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelContainer : DbContext
    {
        public ModelContainer()
            : base("name=ModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Recruited> RecruitedSet { get; set; }
        public virtual DbSet<Skill> SkillSet { get; set; }
        public virtual DbSet<Document> DocumentSet { get; set; }
        public virtual DbSet<Posesses> PosessesSet { get; set; }
        public virtual DbSet<Job> JobSet { get; set; }
        public virtual DbSet<Requires> RequiresSet { get; set; }
        public virtual DbSet<Application> ApplicationSet { get; set; }
        public virtual DbSet<Stage> StageSet { get; set; }
        public virtual DbSet<StageGrade> StageGradeSet { get; set; }
        public virtual DbSet<Worker> WorkerSet { get; set; }
        public virtual DbSet<Role> RoleSet { get; set; }
    }
}