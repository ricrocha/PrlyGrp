using System;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Exceptions
{
    public class EavEntityNotFoundException : Exception
    {
        public EavEntityNotFoundException(int eavEntityId) : base($"No eavEntityId found with id {eavEntityId}")
        {
        }
        public EavEntityNotFoundException(System.Runtime.Serialization.SerializationInfo info
            , System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
        public EavEntityNotFoundException(string message) : base(message)
        {
        }
        public EavEntityNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
