using System;
using System.Runtime.Serialization;

namespace Mentalist.CommandCenter
{
    [Serializable]
    public class CommandNotRegisteredException : Exception
    {
        public Type CommandType { get; }

        public CommandNotRegisteredException(Type commandType) : base($"Command [{commandType}] is not registered!")
        {
            CommandType = commandType;
        }

        protected CommandNotRegisteredException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}