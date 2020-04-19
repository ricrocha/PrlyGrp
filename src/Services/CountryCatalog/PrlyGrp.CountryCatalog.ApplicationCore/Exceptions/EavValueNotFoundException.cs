using System;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Exceptions
{
    public class EavValueNotFoundException : Exception
    {
        public EavValueNotFoundException(int eavValueId) : base($"No eavValueId found with id {eavValueId}")
        {
        }
        public EavValueNotFoundException(System.Runtime.Serialization.SerializationInfo info
            , System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
        public EavValueNotFoundException(string message) : base(message)
        {
        }
        public EavValueNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
