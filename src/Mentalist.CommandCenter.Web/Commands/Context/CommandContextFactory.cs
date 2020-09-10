namespace Mentalist.CommandCenter.Web.Commands.Context
{
    public class CommandContextFactory: ICommandContextFactory
    {
        public ICommandContext Create(ICommandCenter commands, ICommandContextParameters parameters)
        {
            return new CommandContext(commands);
        }
    }
}
