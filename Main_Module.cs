using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Graph;

namespace MailBoxEmpty01
{
    class Main_Module
    {

        static void Main(string[] args)
        {
           
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddUserSecrets<Main_Module>()
                .Build();

            var credentials = new ClientSecretCredential(
                config["GraphMail:5408a96d-412c-41f7-9f5c-958b28e7d8c5"],
                config["GraphMail:5458dad2-30f3-4734-9ef3-d5b6d1c5e0c1"],
                config["GraphMail:5bc414fd-6269-474e-9db0-1fa7c31dc05e"],
                new TokenCredentialOptions { AuthorityHost = AzureAuthorityHosts.AzurePublicCloud });

            // Define a new Microsoft Graph service client.            
            GraphServiceClient _graphServiceClient = new GraphServiceClient(credentials);

            // Get the e-mails for a specific user.
            var messages = _graphServiceClient.Users["tobias@yuccasolutions.net"].Messages.Request().GetAsync().Result;
            foreach (var message in messages)
            {
                Console.WriteLine($"{message.ReceivedDateTime?.ToString("yyyy-MM-dd HH:mm:ss")} from {message.From.EmailAddress.Address}");
                Console.WriteLine($"{message.Subject}");
                Console.WriteLine("---");
            }
        }
    }
}
