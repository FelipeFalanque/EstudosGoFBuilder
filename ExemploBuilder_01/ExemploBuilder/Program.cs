using System;

namespace ExemploBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Padrão Builder -  Fluent Interface");

            var emailBuilder = new EmailBuilder();

            var email =
                emailBuilder.To("macoratti@yahoo.com")
                .From("teste@email.com")
                .Subject("Assunto do Email")
                .Body("Teste de envio de email")
                .Build();

            Console.WriteLine($"{email.From} \n {email.To} \n {email.Subject} \n {email.Body} ");

            Console.ReadLine();
        }
    }

    public class Email
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class EmailBuilder
    {
        private readonly Email _email;
        public EmailBuilder()
        {
            _email = new Email();
        }

        public EmailBuilder Body(string content)
        {
            _email.Body = content;
            return this;
        }
        public EmailBuilder From(string address)
        {
            _email.From = address;
            return this;
        }
        public Email Build()
        {
            return _email;
        }
        public EmailBuilder Subject(string title)
        {
            _email.Subject = title;
            return this;
        }
        public EmailBuilder To(string address)
        {
            _email.To = address;
            return this;
        }
    }
}
