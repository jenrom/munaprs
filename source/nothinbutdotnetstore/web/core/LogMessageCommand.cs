using System;

using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.core
{
    public class LogMessageCommand : IEncapsulateApplicationSpecificFunctionality
    {
        private ILogMessage logMessage;
        private readonly IEncapsulateApplicationSpecificFunctionality wrappedCommand;

        public LogMessageCommand(IEncapsulateApplicationSpecificFunctionality wrappedCommand) : this(new StubLogMessage(), wrappedCommand)
        {
        }

        public LogMessageCommand(ILogMessage logMessage, IEncapsulateApplicationSpecificFunctionality wrapped_command)
        {
            this.logMessage = logMessage;
            wrappedCommand = wrapped_command;
        }

        public void process(IContainRequestDetails request)
        {
            logMessage.Information();
            wrappedCommand.process(request);
        }
    }
}