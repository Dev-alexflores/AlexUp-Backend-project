namespace AlexSoft.AlexUp.Projects.Controllers
{
    using System.Net;
    using AlexSoft.AlexUp.CoreInterfaces;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
    using Microsoft.OpenApi.Models;

    public class GetHealth
    {
        private readonly IProjectsService projectservice;

        public GetHealth(IProjectsService projectservice)
        {
            this.projectservice = projectservice;
        }

        [FunctionName("GetHealth")]
        [OpenApiOperation(operationId: "GetHealth", tags: new[] { "name" })]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "The OK response")]
        public IActionResult Health(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
        {
            var result = this.projectservice.GetHealth();
            return new OkObjectResult(result);
        }
    }
}
