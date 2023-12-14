using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ClerkManagementApp.DAL.Interfaces;
using ClerkManagementApp.Model;

namespace ClerkManagementApp.DAL.Services
{
    public class ClerkService : Interfaces.IClerkService
    {
        private Interfaces.IClerkRepository _repository;

        public ClerkService(Interfaces.IClerkRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Add()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Update()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Delete()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ClerkModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}