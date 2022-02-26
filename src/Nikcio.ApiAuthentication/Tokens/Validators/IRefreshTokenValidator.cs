namespace Nikcio.ApiAuthentication.Tokens.Validators {
    /// <summary>
    /// A validator for refresh tokens
    /// </summary>
    /// <remarks>Not implemented yet</remarks>
    public interface IRefreshTokenValidator {
        /// <summary>
        /// Validates a refresh token
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <returns></returns>
        bool Validate(string refreshToken, string issuer, string audience);
    }
}