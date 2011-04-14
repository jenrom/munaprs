using developwithpassion.specifications.moq;
using Machine.Specifications;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;
using Arg = Moq.It;

namespace nothinbutdotnetstore.specs
{
    public class ViewDepartmentsInDepartmentSpecs
    {
        public abstract class concern : Observes<IEncapsulateApplicationSpecificFunctionality,
                                            ViewTheDepartmentsInADepartment>
        {
        }

        [Subject(typeof(ViewTheDepartmentsInADepartment))]
        public class when_the_subdepartmens_of_a_department_with_a_given_id_are_requested : concern
        {
            private It should_delegate_the_displying_of_the_report_model_for_the_list_of_subdepartments = () => { };
        }
    }
}