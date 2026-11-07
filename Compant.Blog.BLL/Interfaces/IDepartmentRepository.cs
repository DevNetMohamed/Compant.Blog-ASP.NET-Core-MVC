using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compant.Blog.DAL.Models;
namespace Compant.Blog.BLL.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department? Get(int id);
        int Add(Department department);
        
        int Update(Department department);
        int Delete(Department department);
    }
}
