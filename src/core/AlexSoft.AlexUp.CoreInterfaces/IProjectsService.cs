namespace AlexSoft.AlexUp.CoreInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IProjectsService
    {
        string GetHealth();

        string GetAll(string value);
    }
}
