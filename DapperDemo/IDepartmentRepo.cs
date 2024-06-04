using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public interface IDepartmentRepo
    {
        public IEnumerable<Department> GetAllDepartments();

        public void InsertDepartment(string newDepartmentName);
    }
}
