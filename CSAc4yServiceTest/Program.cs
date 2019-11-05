using CSAc4y.Class;
using CSAc4yObjectService.Class;
using CSAc4yService.Class;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAc4yServiceTest
{
    class Ac4yService
    {
        public static GetObjectResponse GetFirstByTemplate(int id)
        {
            var response = new GetObjectResponse();
            try
            {
                response.setObject(Ac4yIdentificationBaseEntityMethods.findFirstById(id));
                response.Result = new Ac4yProcessResult() { Code = "1" };
            }
            catch (Exception exception)
            {
                response.Result = (new Ac4yProcessResult() { Code = "-1", Message = exception.Message });
            }

            return response;
        }

        public static void Save()
        {
            Ac4yIdentificationBase ac4yIdentificationBase = new Ac4yIdentificationBase();
            ac4yIdentificationBase.CreatedAt = DateTime.Now;

            Ac4yIdentificationBaseEntityMethods.addNewAc4yIdentificationBase(ac4yIdentificationBase);
        }

        public static void Main(string[] args)
        {
            Save();
            var result = GetFirstByTemplate(4);
        }
    }
}

