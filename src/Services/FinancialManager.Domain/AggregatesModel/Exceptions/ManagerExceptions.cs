using System;

namespace FM.Domain.AggregatesModel.Exceptions
{
    class ManagerExceptions : Exception
    {
        public ManagerExceptions()
        { }

        public ManagerExceptions(string message)
            : base(message)
        { }

        public ManagerExceptions(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
