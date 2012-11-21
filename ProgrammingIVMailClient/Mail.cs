using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingIVMailClient
{
    class Mail
    {
        private string to;
        private string from;
        private string cc;
        private string bcc;
        private string body;
        private string subject;

        public void saveMail(string from, string to, string cc, string bcc, string body, string subject)
        {
            this.from = from;
            this.to = to;
            this.cc = cc;
            this.bcc = bcc;
            this.body = body;
            this.subject = subject;
        }

        public string get_to()
        { return this.to; }
        public string get_from()
        { return this.from; }
        public string get_cc()
        { return this.cc; }
        public string get_bcc()
        { return this.bcc; }
        public string get_body()
        { return this.body; }
        public string get_subject()
        { return this.subject; }
        public Mail get_message()
        { return this; }
    }
}
