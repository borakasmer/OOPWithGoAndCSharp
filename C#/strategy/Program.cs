using System;
namespace strategy
{
    /* public enum MailType

    {

        HumanResource,

        IT,

        Manager,

        Worker

    } */

    public interface IMail
    {
        void SendMail(string body, string cc);
    }
    class HumanResource : IMail
    {
        public void SendMail(string body, string cc)
        {
            Console.WriteLine($"HumanResource Mail Send : {body}");
        }
    }
    class IT : IMail
    {
        public void SendMail(string body, string cc)
        {
            Console.WriteLine($"IT Mail Send : {body}");
        }
    }
    class Manager : IMail
    {
        public void SendMail(string body, string cc)
        {
            Console.WriteLine($"Manager Mail Send : {body}");
        }
    }
    class Worker : IMail
    {
        public void SendMail(string body, string cc)
        {
            Console.WriteLine($"Worker Mail Send : {body}");
        }
    }

    class VbtStaj : IMail
    {
        public void SendMail(string body, string cc)
        {
            Console.WriteLine($"VbtStaj Mail Send : {body}");
        }
    }

    class VbtSecondStaj : IMail
    {
        public void SendMail(string body, string cc)
        {
            Console.WriteLine($"VbtSecondStaj Mail Send : {body}");
        }
    }

    public class Postman
    {
        IMail _mail = null;
        public Postman(IMail mail) => _mail = mail;
        public void SendMail(string body, string cc)
        {
            _mail.SendMail(body, cc);
        }
    }

    class Program

    {

        static void Main(string[] args)
        {
            //Postman postman = new Postman(new IT());
            //Postman postman = new Postman(new VbtStaj());
            Postman postman = new Postman(new VbtSecondStaj());
            postman.SendMail("Publish Yapalım", "bora@borakasmer.com");

            #region Old Codes
            /*  void SendMail(MailType type, string body, string cc)
             {
                 switch (type)
                 {
                     case MailType.HumanResource:
                         {
                             Console.WriteLine($"HumanResource Mail Send : {body}");
                             break;
                         }
                     case MailType.IT:
                         {
                             Console.WriteLine($"IT Mail Send : {body}");
                             break;
                         }
                     case MailType.Manager:
                         {
                             Console.WriteLine($"Manager Mail Send : {body}");
                             break;
                         }
                     case MailType.Worker:
                         {
                             Console.WriteLine($"Worker Mail Send : {body}");
                             break;
                         }
                 }
             }
             SendMail(MailType.IT, "Publish Yapalım", "bora@borakasmer.com"); */
            #endregion
            Console.ReadLine();

        }
        
    }

}