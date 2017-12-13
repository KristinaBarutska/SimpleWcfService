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
        
        public BusinessResult CheckUserName()
        {
            var businessResult = new BusinessResult();
            businessResult.IsOK = true;
            businessResult.Result = "Kris";
            return businessResult;
        }
       

        public BusinessResult GetMessage()
        {
            var businessResult = new BusinessResult();
            businessResult.IsOK = true;
            businessResult.Result = "Last message- test";            
            return businessResult;
        }
    }
}
