using System;

namespace InterfaceSeg
{
    interface IService
    {
        Boolean CheckToken();
        String GetUserId();
     /* String GetMobileDeviceId();
        Boolean CheckMobileVersion();
        String GetMobilePlatform(); */
    }
    interface IMobileService :IService
    {      
        String GetMobileDeviceId();
        Boolean CheckMobileVersion();
        String GetMobilePlatform();
    } 

    public class WebService : IService
    {
        public bool CheckToken()
        {
            return true;
        }
        public string GetUserId()
        {
            return "123456";
        }
        /* public bool CheckMobileVersion()
        {
            throw new NotImplementedException();
        } */        
        /* public string GetMobileDeviceId()
        {
            throw new NotImplementedException();
        }

        public string GetMobilePlatform()
        {
            throw new NotImplementedException();
        } */        
    }

    public class MobileService : IMobileService
    {
        public bool CheckToken()
        {
            return false;
        }        
        public string GetUserId()
        {
            throw new NotImplementedException();
        }
        public string GetMobileDeviceId()
        {
            return "352698276144152";
        }
        public string GetMobilePlatform()
        {
            return "ios";
        }
        public bool CheckMobileVersion()
        {
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WebService service = new WebService();
            MobileService mobileService = new MobileService();
            Console.WriteLine($"UserID: {service.GetUserId()}");            
            Console.WriteLine($"MobileDeviceID: {mobileService.GetMobileDeviceId()}");
            Console.ReadLine();
        }
    }
}
