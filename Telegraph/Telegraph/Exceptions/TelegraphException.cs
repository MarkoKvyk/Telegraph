using System;

namespace Kvyk.Telegraph.Exceptions
{
    [Serializable]
    public class TelegraphException : Exception
    {
        public TelegraphException() { }
        public TelegraphException(string message) : base(message) { }
        public TelegraphException(string message, Exception inner) : base(message, inner) { }
        protected TelegraphException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
