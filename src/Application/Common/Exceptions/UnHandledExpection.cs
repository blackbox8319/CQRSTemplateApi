using System;

namespace Application.Common.Exceptions
{
    public class UnHandledExpection : Exception
    {
        public UnHandledExpection(): base()
        {

        }

        public UnHandledExpection(string message)
            : base(message)
        {
        }

        public UnHandledExpection(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public UnHandledExpection(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }
    }
}
