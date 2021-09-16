namespace AlexSoft.AlexUp.Projects
{
    using System.IO;
    using System.Net;
    using AlexSoft.AlexUp.CoreInterfaces;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
    using Microsoft.OpenApi.Models;

    public class GetProjects
    {
        private readonly IProjectsService iprojectservice;

        public GetProjects(IProjectsService iprojectservice)
        {
            this.iprojectservice = iprojectservice;
        }

        [FunctionName("GetAll")]
        [OpenApiOperation(operationId: "GetAll", tags: new[] { "name" })]
        [OpenApiParameter(name: "name", In = ParameterLocation.Query, Required = true, Type = typeof(string), Description = "The **Name** parameter")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "The OK response")]
        public IActionResult GetAllInf(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
        {
            string name = req.Query["name"];
            var result = this.iprojectservice.GetAll(name);
            return new OkObjectResult(result);
        }
    }
}