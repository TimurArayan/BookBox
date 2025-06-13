using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace BookBox.Services
{
    public class NullEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
            => Task.CompletedTask;
    }
}
