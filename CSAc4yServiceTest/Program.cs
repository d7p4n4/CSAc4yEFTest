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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main(string[] args)
        {
            try
            {
                CSAc4yPersistentServiceTestLibrary.Class1 cSAc4YPersistentServiceTestLibrary = new CSAc4yPersistentServiceTestLibrary.Class1();

                cSAc4YPersistentServiceTestLibrary.Save();
                var result = cSAc4YPersistentServiceTestLibrary.GetFirstByTemplate(4);
            } catch (Exception exception)
            {
                log.Error(exception.Message);
            }
        }
    }
}

