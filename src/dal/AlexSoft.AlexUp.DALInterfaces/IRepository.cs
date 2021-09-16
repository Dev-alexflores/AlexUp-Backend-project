namespace AlexSoft.AlexUp.DALInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AlexSoft.AlexUp.Models;

    public interface IRepository
    {
        string GetHealth();

        List<Project> GetAllProjects();
    }
}
