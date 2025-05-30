using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace BookBox.Pages.Profile
{
    public class ProfileModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IdentityUser CurrentUser { get; private set; }

        public async Task OnGetAsync()
        {
            CurrentUser = await _userManager.GetUserAsync(User);
        }

    }
}
