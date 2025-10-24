using System.ComponentModel.DataAnnotations;

namespace session5demo.pl.ViewModels.AuthVm
{
    public class LoginVm
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
