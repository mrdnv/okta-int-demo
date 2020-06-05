using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using okta_integration_demo.Dtos;
using okta_integration_demo.Dtos.User;
using okta_integration_demo.RequestModels;
using okta_integration_demo.Services.Interfaces;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace okta_integration_demo.Services
{
    /// <summary>
    /// User Service
    /// </summary>
    /// <seealso cref="okta_integration_demo.Services.ServiceBase" />
    /// <seealso cref="okta_integration_demo.Services.Interfaces.IOktaUserService" />
    public class OktaUserService : ServiceBase, IOktaUserService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OktaUserService"/> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        public OktaUserService(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        protected override string Url => "https://dev-812203.okta.com/api/v1/users";

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="userDto">The user dto.</param>
        public async Task CreateUser(OktaUserDto userDto)
        {
            var createUser = new CreateOktaUser
            {
                Profile = userDto,
                GroupIds = new string[] { }
            };

            var payload = JsonConvert.SerializeObject(createUser, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
            var url = $"{Url}?activate=false";
            var content = new StringContent(payload, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, content);
        }

        public async Task SendActivationEmail(string userId, bool sendEmail = true)
        {
            var url = $"{Url}/{userId}/lifecycle/activate?sendEmail=true";
            var response = await httpClient.PostAsync(url, null);
        }
    }
}
