using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactorig
{
    public enum ProcessType
    {
        Finance,
        Service,
        Crm
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ProcessCalculation(ProcessType.Crm);        
            DoServiceProcess();
            Console.WriteLine("Finish Application");
        }
        public static void DoServiceProcess()
        {
            Process process = new Process("SendMailStaj", "BackMailStaj");
            process.ProcessCalculation();

            //Process process = new Process("CallFinance", "BackFinance");
            //Process process = new Process("CallVbtStaj", "BackVbtStaj");
            //process.ProcessCalculation();
            //Process process = new Process("CallService", "BackService");           
            /*
            Process process2 = new Process("CallCrm", "BackCrm");          
            process2.ProcessCalculation();*/

            //Process process = new Process("CallBilmok", "BackBilmok");
            //process.ProcessCalculation();
        }
        #region Old Codes
        public static void ProcessCalculation(ProcessType type)
        {            
            try
            {
 /*
                .
                .
                ....ToDoSomething()
 */
                if (type == ProcessType.Crm)
                {
                    CallCrm();
                }
                else if (type == ProcessType.Finance)
                {
                    CallFinance();
                }
                else if (type == ProcessType.Service)
                {
                    CallService();
                }
            }
            catch
            {
                if (type == ProcessType.Crm)
                {
                   BackCrm();
                }
                else if (type == ProcessType.Finance)
                {
                    BackFinance();
                }
                else if (type == ProcessType.Service)
                {
                    BackService();
                }
            }
        }
        public static void CallCrm() { }
        public static void CallFinance() { }
        public static void CallService() { }
        public static void BackCrm() { }
        public static void BackFinance() { }
        public static void BackService() { }
        #endregion
    }
}
