using System;
using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetstore
{
    public class CommandRegistry : ICanFindCommandsThatCanProcessRequests
    {
        private readonly IEnumerable<ICanProcessOneUniqueRequest> allCommands;

        public CommandRegistry(IEnumerable<ICanProcessOneUniqueRequest> all_commands)
        {
            allCommands = all_commands;
        }

        public ICanProcessOneUniqueRequest get_the_command_that_can_handle(IContainRequestDetails request)
        {
            return allCommands.First(x => x.can_process(request));
        }
    }
}