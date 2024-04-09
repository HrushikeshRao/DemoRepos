using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Graph;
using Azure.Identity;
using Microsoft.Graph.Drives.Item.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval;
using System.Linq.Expressions;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IdentityModel;
using Microsoft.Extensions.Configuration;
using WindowsForm;
using Microsoft.Graph.Models;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Message
    {
        public string From { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public List<Attachment> Attachments { get; set; }
    }

    public class Attachment
    {
        public string AttachmentID { get; set; }
        public string AttachmentName { get; set; }
    }


public partial class MainForm : Form
    {
        private DataColumn _clnFrom;
        private DataColumn _clnSubject;
        private DataColumn _clnBody;
        private DataColumn _clnAttachments;

        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
       {
            if (txtMailID.Text == "Please Enter Mail ID.")
            {
                txtMailID.Text = "";
            }
        }


        public async void btnGetEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMailID.Text))
            {
                MessageBox.Show("Please enter your Email ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true)
                /*.AddUserSecrets<ClientSecretCredential>()*/ // Uncomment if using user secrets
                .Build();

            ClientSecretCredential credentials = new ClientSecretCredential(
                   config["AzureAd:TenantId"],
                config["AzureAd:ClientId"],
                config["AzureAd:ClientSecret"],
                    new TokenCredentialOptions { AuthorityHost = AzureAuthorityHosts.AzurePublicCloud });

            GraphServiceClient _graphServiceClient = new GraphServiceClient(credentials);

            var messageRequest = await _graphServiceClient.Users[txtMailID.Text].Messages.GetAsync();
                var Messages = messageRequest.Value;

                if (Messages == messageRequest.Value)
                {
                    clnFrom.Equals(_clnFrom);
                    clnSubject.Equals(_clnSubject);
                    clnBody.Equals(_clnBody);
                    clnAttachments.Equals(_clnAttachments);
                }

                DataTable table = new DataTable();
                _clnFrom = table.Columns.Add("From", typeof(string));
                _clnSubject = table.Columns.Add("Subject", typeof(string));
                _clnBody = table.Columns.Add("Body", typeof(string));
                _clnAttachments = table.Columns.Add("Attachments", typeof(string));

            foreach (var message in Messages)
                {
                    var bodyContent = await _graphServiceClient.Users[txtMailID.Text].Messages[message.Id].GetAsync();

                    var row = table.NewRow();
                    row["From"] = message.From.EmailAddress.Address;
                    row["Subject"] = message.Subject;
                    row["Body"] = bodyContent.Body.Content;
                    row["Attachments"] = message.HasAttachments.ToString();

                    table.Rows.Add(row);
                }

                emailsDataGridView.DataSource = table;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error", "001", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtMailID.Text = "Enter Email ID";
              
                if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    MessageBox.Show("No network connection is available. Please check your internet connection.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
    }
}

