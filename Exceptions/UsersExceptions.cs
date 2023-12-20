using System;

namespace Exceptions
{
    /// <summary>
    /// Contains custom exceptions related to user operations.
    /// </summary>
    public class UsersExceptions
    {
        /// <summary>
        /// Exception thrown when attempting to insert a user that already exists.
        /// </summary>
        public class UserAlreadyExistException : Exception
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="UserAlreadyExistException"/> class.
            /// </summary>
            public UserAlreadyExistException() { }

            /// <summary>
            /// Initializes a new instance of the <see cref="UserAlreadyExistException"/> class with a specified error message.
            /// </summary>
            /// <param name="message">The message that describes the error.</param>
            public UserAlreadyExistException(string message) : base(message) { }
        }

        /// <summary>
        /// Exception thrown when a requested user is not found.
        /// </summary>
        public class UserNotFoundException : Exception
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="UserNotFoundException"/> class.
            /// </summary>
            public UserNotFoundException() { }

            /// <summary>
            /// Initializes a new instance of the <see cref="UserNotFoundException"/> class with a specified error message.
            /// </summary>
            /// <param name="message">The message that describes the error.</param>
            public UserNotFoundException(string message) : base(message) { }
        }
    }
}
