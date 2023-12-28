﻿namespace MyResumeProjectMongoDB.DAL.Settings
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName{ get; set; }
        public string ContactInfoCollectionName { get; set; }
        public string EducationCollectionName { get; set; }
        public string ExperienceCollectionName { get; set; }
        public string MessageCollectionName { get; set; }
        public string ProfileCollectionName { get; set; }
        public string ServiceCollectionName { get; set; }
        public string SkillCollectionName { get; set; }
        public string TestimonialCollectionName { get; set; }
        public string ProjectDetailCollectionName { get; set; }
        public string AboutCollectionName { get; set; }
        public string MyProjectCollectionName { get; set; }
        
    }
}
