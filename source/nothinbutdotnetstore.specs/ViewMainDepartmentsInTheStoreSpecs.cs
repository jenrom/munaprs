using System.Collections.Generic;

using developwithpassion.specifications.extensions;
using developwithpassion.specifications.moq;
using Machine.Specifications;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;
using Arg = Moq.It;

namespace nothinbutdotnetstore.specs
{
    public class ViewMainDepartmentsInTheStoreSpecs
    {
        public abstract class concern : Observes<IEncapsulateApplicationSpecificFunctionality,
                                            ViewMainDepartmentsInTheStore>
        {
        }

        [Subject(typeof(ViewMainDepartmentsInTheStore))]
        public class when_calling_the_command : concern
        {
             public class When_executing_the_command : concern
             {
                 private Establish context = () =>
                                                 {
                                                     the_request = fake.an<IContainRequestDetails>();
                                                     the_responder = depends.on<ICanRespond>();
                                                     var has_the_departments = depends.on<IHaveDepartments>();
                                                     main_departments = new List<MainDepartment> { new MainDepartment() };
                                                     has_the_departments.setup(x=>x.get_all_departments()).Return(main_departments);
                                                 };

                 private Because of = () => sut.process(the_request);

                 private It Should_delegate_the_available_departments_to_the_response_creator = () =>
                     the_responder.received(x => x.respond_to(the_request, main_departments));
            
                 private static ICanRespond the_responder;
                 private static IContainRequestDetails the_request;
                 private static IEnumerable<MainDepartment> main_departments;
        }
        }
    }
}