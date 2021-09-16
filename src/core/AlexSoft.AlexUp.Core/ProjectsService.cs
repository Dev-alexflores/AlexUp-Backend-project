namespace AlexSoft.AlexUp.Core
{
    using System;
    using AlexSoft.AlexUp.CoreInterfaces;
    using AlexSoft.AlexUp.DALInterfaces;

    public class ProjectsService : IProjectsService
    {
        private readonly IRepository repository;

        public ProjectsService(IRepository irepository)
        {
            this.repository = irepository;
        }

        public string GetAll(string value)
        {
            return $"Hi {value} welcome to my app";
        }

        public string GetHealth()
        {
            return this.repository.GetHealth();
        }
    }
}
