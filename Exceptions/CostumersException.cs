using System;

namespace Exceptions
{
    /// <summary>
    /// Contains custom exceptions related to customer operations.
    /// </summary>
    public class CostumersException
    {
        /// <summary>
        /// Exception thrown when attempting to insert a customer that already exists.
        /// </summary>
        public class CostumerAlreadyExistsException : Exception
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="CostumerAlreadyExistsException"/> class.
            /// </summary>
            public CostumerAlreadyExistsException() { }

            /// <summary>
            /// Initializes a new instance of the <see cref="CostumerAlreadyExistsException"/> class with a specified error message.
            /// </summary>
            /// <param name="message">The message that describes the error.</param>
            public CostumerAlreadyExistsException(string message) : base(message) { }
        }

        /// <summary>
        /// Exception thrown when a requested customer is not found.
        /// </summary>
        public class CostumerNotFoundException : Exception
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="CostumerNotFoundException"/> class.
            /// </summary>
            public CostumerNotFoundException() { }

            /// <summary>
            /// Initializes a new instance of the <see cref="CostumerNotFoundException"/> class with a specified error message.
            /// </summary>
            /// <param name="message">The message that describes the error.</param>
            public CostumerNotFoundException(string message) : base(message) { }
        }
    }
}
