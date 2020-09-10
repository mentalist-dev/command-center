namespace Mentalist.CommandCenter
{
    public interface ICommandContextFactory
    {
        ICommandContext Create(ICommandContextParameters parameters);
    }
}
