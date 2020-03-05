using System.Threading.Tasks;

namespace PrlyGrp.CountryCatalog.ApplicationCore.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }    
}
