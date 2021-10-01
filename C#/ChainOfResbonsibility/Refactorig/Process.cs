using System;
using System.Reflection;

namespace Refactorig
{
    interface IProcess
    {
        string nextMethodName { get; set; }
        string backMethodName { get; set; }
        void NextMethod();
        void BackMethod();
    }
    public class Process : IProcess
    {
        public string nextMethodName { get; set; }
        public string backMethodName { get; set; }
        public Process(string _nextMethodName, string _backMethodName)
        {
            this.nextMethodName = _nextMethodName;
            this.backMethodName = _backMethodName;
        }
        public void NextMethod()
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(this.nextMethodName);
            theMethod.Invoke(this, null);
        }
        public void BackMethod()
        {
            Type thisType = this.GetType();
            MethodInfo theMethod = thisType.GetMethod(this.backMethodName);
            theMethod.Invoke(this, null);
        }
        public void ProcessCalculation()
        {
            try
            {
                /*
                               .
                               .
                               ....ToDoSomething()
                */
                NextMethod();

            }
            catch
            {
                BackMethod();
            }
        }

        public void CallCrm() { Console.WriteLine("Call Crm"); }
        public void CallFinance() { Console.WriteLine("Call Finance"); throw new Exception("This Error is Custom Finance Error"); }
        public void CallService() { Console.WriteLine("Call Service"); }
        public void BackCrm() { Console.WriteLine("Back Crm"); }
        public void BackFinance() { Console.WriteLine("Back Finance"); }
        public void BackService() { Console.WriteLine("Back Service"); }       

        public void CallBilmok() { Console.WriteLine("Seminer Harika Gidiyor!"); throw new OverflowException("Bir aksilik oldu"); }
        public void BackBilmok() { Console.WriteLine("Seminer Sonlandi!");}

        public void CallVbtStaj() { Console.WriteLine("Call Vbt Staj"); throw new Exception("This Error is Custom Finance Error"); }
        public void BackVbtStaj() { Console.WriteLine("Back Vbt Staj"); }

        public void SendMailStaj() { Console.WriteLine("Call SendMail Staj");throw new Exception("you get error!"); }
        public void BackMailStaj() { Console.WriteLine("Call BackMail Staj"); }
    }    
}
