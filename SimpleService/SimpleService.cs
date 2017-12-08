using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Models;

namespace SimpleService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleService" in both code and config file together.
    public class SimpleService : ISimpleService
    {
        
        public string GetUserName()
        {
            Console.WriteLine("Is authenticated: " + ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated.ToString());
            Console.WriteLine("Authentication type: " + ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType);
            Console.WriteLine("Name: " + ServiceSecurityContext.Current.PrimaryIdentity.Name);

            return "Authenticated " + ServiceSecurityContext.Current.PrimaryIdentity.Name;
        }

        public BusinessResult GetWindowsUserName()
        {
            var businessResult = new BusinessResult();
             businessResult.IsOK = true;
             businessResult.Result= ServiceSecurityContext.Current.PrimaryIdentity.Name;
             //businessResult.Messages[0] = "Is authenticated: " + ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated.ToString();
             //businessResult.Messages[1] = "Authentication type: " + ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType;
             // businessResult.Messages[2] = "Name: " + ServiceSecurityContext.Current.PrimaryIdentity.Name;

            return businessResult;
        }
    }
}
