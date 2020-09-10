namespace Mentalist.CommandCenter.Web.Commands
{
    internal class CommandContext: ICommandContext
    {
        public bool IsCompleted { get; private set; }

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