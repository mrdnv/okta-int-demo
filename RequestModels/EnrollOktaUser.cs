using okta_integration_demo.Dtos.User;

namespace okta_integration_demo.RequestModels
{
    /// <summary>
    /// 
    /// </summary>
    public class EnrollOktaUser
    {
        /// <summary>
        /// Gets or sets the type of the factor.
        /// </summary>
        /// <value>
        /// The type of the factor.
        /// </value>
        public string FactorType { get; set; }
        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public string Provider { get; set; }
        /// <summary>
        /// Gets or sets the profile.
        /// </summary>
        /// <value>
        /// The profile.
        /// </value>
        public OktaUserEnrollDto Profile { get; set; }
    }
}
