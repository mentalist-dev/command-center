namespace Mentalist.CommandCenter
{
    public interface ICommandContextFactory
    {
        ICommandContext Create(ICommandCenter commands, ICommandContextParameters parameters);
    }
}
