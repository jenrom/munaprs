using System;
using System.Web;

namespace nothinbutdotnetstore
{
    public class RawHandler : IHttpHandler
    {
        private readonly ICreateRequests requestCreator;
        private readonly IProcessIncomingWebRequests frontController;

        public RawHandler(ICreateRequests requestCreator, IProcessIncomingWebRequests frontController)
        {
            this.requestCreator = requestCreator;
            this.frontController = frontController;
        }

        public void ProcessRequest(HttpContext context)
        {
            frontController.process(requestCreator.create_request_from(context));   
        }

        public bool IsReusable
        {
            get { throw new NotImplementedException(); }
        }
    }
}