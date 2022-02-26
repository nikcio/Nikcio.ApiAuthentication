namespace Nikcio.ApiAuthentication.Tokens.Models {
    /// <summary>
    /// A token generated for a api key
    /// </summary>
    public class ApiToken {
        /// <summary>
        /// The access token
        /// </summary>
        public string? Token { get; set; }
        /// <summary>
        /// The refresh token
        /// </summary>
        /// <remarks>This is not implemented yet</remarks>
        public string? RefreshToken { get; set; }
        /// <summary>
        /// When the access token expires
        /// </summary>
        public DateTime TokenExpiresOn { get; set; }
        /// <summary>
        /// Milliseconds to access token expires
        /// </summary>
        public double TokenExpiresIn { get; set; }
        /// <summary>
        /// When the refresh token expires
        /// </summary>
        public DateTime RefreshTokenExpriesOn { get; set; }
        /// <summary>
        /// Milliseconds to refresh token expires
        /// </summary>
        public double RefreshTokenExpriesIn { get; set; }
    }
}
