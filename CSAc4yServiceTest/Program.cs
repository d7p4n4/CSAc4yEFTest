
using CSAc4yObjectService.Class;
using CSAc4yPersistentServiceTestLibrary;
using CSAc4yService.Class;
using d7p4n4.Final.Class;
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
                string baseName = "Ac4yDb";
                PersistentService cSAc4YPersistentServiceTestLibrary = new PersistentService(baseName);

                Ac4yIdentificationBase ac4YIdentificationBase = new Ac4yIdentificationBase();
                ac4YIdentificationBase.CreatedAt = DateTime.Now;

                cSAc4YPersistentServiceTestLibrary.Save(ac4YIdentificationBase);
                var result = cSAc4YPersistentServiceTestLibrary.GetFirstByTemplate(1);
            } catch (Exception exception)
            {
                log.Error(exception.Message);
            }
        }
    }
}

