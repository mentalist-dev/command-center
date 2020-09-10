namespace Mentalist.CommandCenter.Web.Commands
{
    internal class CommandContextState: ICommandContextState
    {
        public bool IsFailed { get; set; }
        public bool IsRejected { get; set; }
    }
}