using okta_integration_demo.Dtos.User;
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

        /// <summary>
        /// Enrolls the specified user enroll dto.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task SendActivationEmail(string userId);
    }
}
