
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ac4yIdentificationDataAccess;

namespace Ac4yIdentificationDataAccess
{
    public class Ac4yIdentificationController : ApiController
    {

        public ResponseModel GetFirstByTemplate(Ac4yIdentificationBase id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = Ac4yIdentificationEntityMethods.findFirstByTemplate(id);

            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";
            
            return _objResponseModel;
        }

        public ResponseModel GetFirstById(Int32 id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = Ac4yIdentificationEntityMethods.findFirstById(id);

            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";
            
            return _objResponseModel;
        }

        public ResponseModel GetFirstByGUID(String id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = Ac4yIdentificationEntityMethods.findFirstByGUID(id);

            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";
            
            return _objResponseModel;
        }

        public ResponseModel GetFirstByHumanId(String id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = Ac4yIdentificationEntityMethods.findFirstByHumanId(id);

            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";
            
            return _objResponseModel;
        }

        public ResponseModel GetFirstByPublicHumanId(String id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = Ac4yIdentificationEntityMethods.findFirstByPublicHumanId(id);

            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";
            
            return _objResponseModel;
        }

        public ResponseModel GetFirstByCreatedAt(DateTime id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = Ac4yIdentificationEntityMethods.findFirstByCreatedAt(id);

            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";
            
            return _objResponseModel;
        }

        public ResponseModel GetFirstByUpdatedAt(String id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = Ac4yIdentificationEntityMethods.findFirstByUpdatedAt(id);

            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";
            
            return _objResponseModel;
        }


        public ResponseModel GetListByTemplate(Ac4yIdentificationBase id)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            List<Ac4yIdentification> _Ac4yIdentification = Ac4yIdentificationEntityMethods.findListByTemplate(id);

            _objResponseModel.Data = _Ac4yIdentification;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;
        }


        public ResponseModel GetListById(Int32 id)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            List<Ac4yIdentification> _Ac4yIdentification = Ac4yIdentificationEntityMethods.findListById(id);

            _objResponseModel.Data = _Ac4yIdentification;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;
        }


        public ResponseModel GetListByGUID(String id)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            List<Ac4yIdentification> _Ac4yIdentification = Ac4yIdentificationEntityMethods.findListByGUID(id);

            _objResponseModel.Data = _Ac4yIdentification;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;
        }


        public ResponseModel GetListByHumanId(String id)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            List<Ac4yIdentification> _Ac4yIdentification = Ac4yIdentificationEntityMethods.findListByHumanId(id);

            _objResponseModel.Data = _Ac4yIdentification;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;
        }


        public ResponseModel GetListByPublicHumanId(String id)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            List<Ac4yIdentification> _Ac4yIdentification = Ac4yIdentificationEntityMethods.findListByPublicHumanId(id);

            _objResponseModel.Data = _Ac4yIdentification;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;
        }


        public ResponseModel GetListByCreatedAt(DateTime id)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            List<Ac4yIdentification> _Ac4yIdentification = Ac4yIdentificationEntityMethods.findListByCreatedAt(id);

            _objResponseModel.Data = _Ac4yIdentification;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;
        }


        public ResponseModel GetListByUpdatedAt(String id)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            List<Ac4yIdentification> _Ac4yIdentification = Ac4yIdentificationEntityMethods.findListByUpdatedAt(id);

            _objResponseModel.Data = _Ac4yIdentification;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;
        }



        public void Post(Ac4yIdentification _Ac4yIdentification)
        {
            Ac4yIdentificationEntityMethods.addNewAc4yIdentification(_Ac4yIdentification);
        }

        public void Delete(int id)
        {
            Ac4yIdentificationEntityMethods.deleteById(id);
        }

        public void Update(Ac4yIdentification _Ac4yIdentification)
        {
            Ac4yIdentificationEntityMethods _entityMethods = new Ac4yIdentificationEntityMethods();

            _entityMethods.updateAc4yIdentification(_Ac4yIdentification);
        }
    }
}
