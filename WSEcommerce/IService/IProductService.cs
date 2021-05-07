using WSEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEcommerce.IService
{
    public interface IProductService
    {
        ProjectRequest Save(ProjectRequest oProjectRequest);
        ProjectRequest GetSavedProject();
    }
}
