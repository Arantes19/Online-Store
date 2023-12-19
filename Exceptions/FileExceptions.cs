/*
*	<copyright file="FileExceptions" company="IPCA">
*	</copyright>
* 	<author>Francisco Arantes</author>
*	<contact>a23504@alunos.ipca.pt</contact>
*   <date>2023 19/12/2023</date>
*	<description></description>
**/

namespace Exceptions
{
    /// <summary>
    /// Contains exceptions related to file operations.
    /// </summary>
    public class FileExceptions
    {
        /// <summary>
        /// Exception for writing files.
        /// </summary>
        /// <seealso cref="System.Exception" />
        public class SaveFileException : Exception
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="SaveFileException"/> class.
            /// </summary>
            public SaveFileException() { }

            /// <summary>
            /// Initializes a new instance of the <see cref="SaveFileException"/> class with a specified error message.
            /// </summary>
            /// <param name="message">The error message that explains the reason for the exception.</param>
            public SaveFileException(string message) : base(message) { }
        }

        /// <summary>
        /// Exception for reading files.
        /// </summary>
        public class ReadFileException : Exception
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ReadFileException"/> class.
            /// </summary>
            public ReadFileException() { }

            /// <summary>
            /// Initializes a new instance of the <see cref="ReadFileException"/> class with a specified error message.
            /// </summary>
            /// <param name="message">The error message that explains the reason for the exception.</param>
            public ReadFileException(string message) : base(message) { }
        }
    }
}
