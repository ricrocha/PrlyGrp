using System;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Exceptions
{
    public class StateProvinceNotFoundException: Exception
    {
        public StateProvinceNotFoundException(int stateProvinceId) : base($"No state/province found with id {stateProvinceId}")
        {
        }
        public StateProvinceNotFoundException(System.Runtime.Serialization.SerializationInfo info
            , System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
        public StateProvinceNotFoundException(string message) : base(message)
        {
        }
        public StateProvinceNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
