using System;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class ViewMainDepartmentsInTheStore : IEncapsulateApplicationSpecificFunctionality
    {
        private readonly ICanRespond responder;
        private readonly IHaveDepartments has_departments;

        public ViewMainDepartmentsInTheStore(ICanRespond responder, IHaveDepartments has_departments)
        {
            this.responder = responder;
            this.has_departments = has_departments;
        }

        public void process(IContainRequestDetails request)
        {
            responder.respond_to(request, has_departments.get_all_departments());
        }
    }
}