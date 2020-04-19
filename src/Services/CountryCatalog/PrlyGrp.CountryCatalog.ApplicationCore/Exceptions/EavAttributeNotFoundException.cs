using Ardalis.GuardClauses;
using PrlyGrp.CountryCatalog.ApplicationCore.Entities;
using System;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Exceptions
{
    public class EavAttributeNotFoundException : Exception
    {
        public EavAttributeNotFoundException(int eavAttributeId) : base($"No eavAttributeId found with id {eavAttributeId}")
        {
        }
        public EavAttributeNotFoundException(System.Runtime.Serialization.SerializationInfo info
            , System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
        public EavAttributeNotFoundException(string message) : base(message)
        {
        }
        public EavAttributeNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}