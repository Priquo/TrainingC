using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingC.classes
{
    [Serializable]
    public class CommandLineException : Exception
    {
        public CommandLineException()
            : base()
        {
        }

        public CommandLineException(string message)
            : base(message)
        {
        }

        public CommandLineException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected CommandLineException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}
