﻿namespace CarShop.Service.Common.Providers.Mail.SendGrid
{
    public class EmailAttachment
    {
        public byte[] Content { get; set; }
        public string FileName { get; set; }
        public string MimeType { get; set; }
    }
}