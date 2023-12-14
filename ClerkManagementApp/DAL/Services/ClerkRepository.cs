using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ClerkManagementApp.DAL.Interfaces;

namespace ClerkManagementApp.DAL.Services
{
    public class ClerkRepository : Interfaces.IClerkRepository
    {
        private ClerkDbContext _context;

        public ClerkRepository(ClerkDbContext context)
        {
            _context = context;
        }

        public Model.ClerkModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
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
    }
}