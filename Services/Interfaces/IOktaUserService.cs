using okta_integration_demo.Dtos;
using System.Threading.Tasks;

namespace okta_integration_demo.Services.Interfaces
{
    /// <summary>
    /// User Management in Okta
    /// </summary>
    public interface IOktaUserService
    {
        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="userDto">The user dto.</param>
        Task CreateUser(OktaUserDto userDto);
    }
}
