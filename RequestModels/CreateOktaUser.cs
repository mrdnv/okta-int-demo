using okta_integration_demo.Dtos.User;

namespace okta_integration_demo.RequestModels
{ 
    /// <summary>
    /// 
    /// </summary>
    public class CreateOktaUser
    {
        /// <summary>
        /// Gets or sets the profile.
        /// </summary>
        /// <value>
        /// The profile.
        /// </value>
        public OktaUserDto Profile { get; set; }

        /// <summary>
        /// Gets or sets the group ids.
        /// </summary>
        /// <value>
        /// The group ids.
        /// </value>
        public string[] GroupIds { get; set; }
    }
}
