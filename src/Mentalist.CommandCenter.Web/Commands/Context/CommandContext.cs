namespace Mentalist.CommandCenter.Web.Commands.Context
{
    internal class CommandContext: ICommandContext
    {
        public CommandContext(ICommandCenter commands)
        {
            Commands = commands;
        }

        public bool IsCompleted { get; private set; }

        public ICommandCenter Commands { get; }

        public void Dispose()
        {
            if (IsCompleted)
            {
                // commit?
            }
        }

        public void Complete()
        {
            IsCompleted = true;
        }
    }
}