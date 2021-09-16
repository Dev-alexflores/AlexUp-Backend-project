namespace AlexSoft.AlexUp.ApiUnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AlexSoft.AlexUp.Models;

    public class StubProject
    {
        public static Project GetStubProject()
        {
            Project stubProject = new Project
            {
                Id = new Guid("5a7939fd-59de-44bd-a092-f5d8434584df"),
                Name = "TeamUp",
                Contact = new Contact()
                {
                    Name = "Jose Ecos",
                    IdResume = "123"
                },
                Description = "Centralize resumes and project",
                Logo = "https://www.example.com/images/dinosaur.jpg",
                MemberList = new List<Contact>
        {
                        new Contact
                        {
                            Name = "Paola Quintanilla",
                            IdResume = "123"
                        }
        },
                State = true,
                TextInvitation = "You are invited to be part of TeamUp",
                CreationDate = DateTime.Today.AddDays(-10),
            };
            return stubProject;
        }
    }
}
