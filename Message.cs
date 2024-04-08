using System;
using System.Collections.Generic;

namespace MailBox01
{
    public class Message
    {
        public string From { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public List<Attachment> Attachments { get; set; }

        // Example method to get a summary of the message
        public string GetMessageSummary()
        {
            return $"From: {From}, Subject: {Subject}, Body: {Body}";
        }
    }

    public class Attachment
    {
        public string AttachmentID { get; set; }
        public string AttachmentName { get; set; }

        // Example method to get a summary of the attachment
        public string GetAttachmentSummary()
        {
            return $"Attachment ID: {AttachmentID}, Attachment Name: {AttachmentName}";
        }
    }
}

