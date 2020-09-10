namespace Mentalist.CommandCenter
{
    public interface ICommandContextState
    {
        bool IsFailed { get; }
        bool IsRejected { get; }
    }
}