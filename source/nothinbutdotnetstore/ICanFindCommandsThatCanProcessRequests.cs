namespace nothinbutdotnetstore
{
    public interface ICanFindCommandsThatCanProcessRequests
    {
        ICanProcessOneUniqueRequest get_the_command_that_can_handle(IContainRequestDetails request);
    }
}