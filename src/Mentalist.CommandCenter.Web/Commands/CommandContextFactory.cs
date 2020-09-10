namespace Mentalist.CommandCenter.Web.Commands
{
    public class CommandContextFactory: ICommandContextFactory
    {
        public ICommandContext Create(ICommandContextParameters parameters)
        {
            return new CommandContext();
        }
    }
}
