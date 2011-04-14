using System.Collections.Generic;

using nothinbutdotnetstore.web.application;

namespace nothinbutdotnetstore.web.core
{
    public interface ICanRespond
    {
        void respond_to<TypeOfResponseModel>(IContainRequestDetails the_request, TypeOfResponseModel response_model);
    }
}