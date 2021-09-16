namespace AlexSoft.AlexUp.DAL
{
    using System.Collections.Generic;
    using AlexSoft.AlexUp.DALInterfaces;
    using AlexSoft.AlexUp.Models;

    public class Repository : IRepository
    {
        private readonly Project projectsS = new Project();

        public List<Project> GetAllProjects()
        {
            throw new System.NotImplementedException();
        }

        public string GetHealth()
        {
            return "The CoteApp is alive  and running";
        }
    }
}
