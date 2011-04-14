using System.Collections.Generic;

namespace nothinbutdotnetstore.web.application
{
    public interface IHaveDepartments
    {
        IEnumerable<MainDepartment> get_all_departments();
    }
}