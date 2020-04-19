using System;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Exceptions
{
    public class CountryNotFoundException : Exception
    {
        public CountryNotFoundException(int countryId) : base($"No country found with id {countryId}")
        {
        }
        public CountryNotFoundException(System.Runtime.Serialization.SerializationInfo info
            , System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
        public CountryNotFoundException(string message) : base(message)
        {
        }
        public CountryNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
