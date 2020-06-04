namespace okta_integration_demo.Dtos
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateOktaUserDto
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
