namespace IdentityBase.Configuration
{
    public static class ApplicationOptionsExtensions
    {
        /// <summary>
        /// Indicates if idbase API is enabled by checking individual endpoint
        /// options.
        /// </summary>
        /// <param name="options">Instance of <see cref="ApplicationOptions" />
        /// .</param>
        /// <returns>True if any of API endpoints is enabled.</returns>
        public static bool IsWebApiEnabled(this ApplicationOptions options)
        {
            return
                options.EnableInvitationGetEndpoint ||
                options.EnableInvitationCreateEndpoint ||
                options.EnableInvitationDeleteEndpoint; 
        }
    }
}
