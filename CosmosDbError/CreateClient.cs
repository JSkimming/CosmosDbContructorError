using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.Documents.Client;

namespace CosmosDbError
{
    public static class CreateClient
    {
        [FunctionName("CreateClient")]
        public static void Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
            var connectionPolicy = new ConnectionPolicy
            {
                UserAgentSuffix = ".CosmosDbError",
            };

            var client = new DocumentClient(
                new Uri("https://localhost:8081/"),
                "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
                connectionPolicy);
        }
    }
}