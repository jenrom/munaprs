using System;

namespace nothinbutdotnetstore
{
    public class FrontController : IProcessIncomingWebRequests
    {
        private readonly ICanFindCommandsThatCanProcessRequests _finder;

        public FrontController(ICanFindCommandsThatCanProcessRequests finder)
        {
            _finder = finder;
        }

        public void process(IContainRequestDetails the_request)
        {
            _finder.get_the_command_that_can_handle(the_request).run_using(the_request);
        }
    }
}