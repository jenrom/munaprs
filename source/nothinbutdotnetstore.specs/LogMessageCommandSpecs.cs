using developwithpassion.specifications.extensions;
using developwithpassion.specifications.moq;

using Machine.Specifications;

using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.specs
{
    public class LogMessageCommandSpecs
    {
        public class when_run : Observes<IEncapsulateApplicationSpecificFunctionality, LogMessageCommand>
        {
            private Establish context = () =>
                                            {
                                                logger = depends.on<ILogMessage>();
                                                request = fake.an<IContainRequestDetails>();
                                                command = depends.on<IEncapsulateApplicationSpecificFunctionality>();
                                            };

            private Because of = () =>
                                     {
                                         sut.process(request);

                                     };

            private It should_log_the_information = () => logger.received(x => x.Information());

            private It should_forward_the_request_to_its_destination_command = () =>
                                                                                   {
                                                                                       command.received((x) => x.process(request));
                                                                                   };
            private static ILogMessage logger;
            private static IEncapsulateApplicationSpecificFunctionality command;
            private static IContainRequestDetails request;
        }
    }
}