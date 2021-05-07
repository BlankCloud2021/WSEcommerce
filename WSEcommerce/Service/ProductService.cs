using WSEcommerce.Data;
using WSEcommerce.IService;
using WSEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEcommerce.Service
{
    public class ProductService : IProductService
    {
        private readonly WSEcommerceDbContext _context;
        public ProductService(WSEcommerceDbContext context)
        {
            _context = context;
        }
        public ProjectRequest GetSavedProject()
        {
            return _context.ProjectRequests.SingleOrDefault();
        }

        public ProjectRequest Save(ProjectRequest oProjectRequest)
        {
            _context.ProjectRequests.Add(oProjectRequest);
            _context.SaveChanges();
            return oProjectRequest;
        }
    }
}
