using System;

namespace OpenClosedPrinciple
{
    //Single responsibility princiole
    //Open Closed principle
    class Email
    {
        public String Theme { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }
    class EmailSender
    {
        public void Send(Email email)
        {
            //sending
        }
    }
    interface EmailLogger
    {
        void WriteLog(Email email);
    }
    class ConsoleEmLogger:EmailLogger
    {
        public void WriteLog(Email email)
        {
            Console.WriteLine("Email from " + email.From + "to" + email.To + " was send");
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Email e1 = new Email()
            {
                From = "Me",
                To = "Vasya",
                Theme = "Who are you?"
            };
            Email e2 = new Email()
            {
                From = "Vasya",
                To = "Me",
                Theme = "vacuum cleaners!"
            };
            Email e3 = new Email()
            {
                From = "Kolya",
                To =
           "Vasya",
                Theme = "No! Thanks!"
            };
            Email e4 = new Email()
            {
                From = "Vasya",
                To = "Me",
                Theme = "washing machines!"
            };
            Email e5 = new Email()
            {
                From = "Me",
                To = "Vasya",
                Theme = "Yes"
            };
            Email e6 = new Email()
            {
                From = "Vasya",
                To =
           "Petya",
                Theme = "+2"
            };
            EmailLogger es = new ConsoleEmLogger();
            EmailSender sender = new EmailSender();
            sender.Send(e1);
            es.WriteLog(e1);
            sender.Send(e2);
            es.WriteLog(e2);
            sender.Send(e3);
            es.WriteLog(e3);
            sender.Send(e4);
            es.WriteLog(e4);
            sender.Send(e5);
            es.WriteLog(e5);
            sender.Send(e6);
            es.WriteLog(e6);
            Console.ReadKey();
        }
    }

}
