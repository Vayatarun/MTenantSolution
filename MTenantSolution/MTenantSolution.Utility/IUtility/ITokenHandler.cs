using System.Security.Claims;

namespace MTenantSolution.Utility.IUtility
{
    public interface ITokenHandler
    {
        string GenerateJwtToken(List<Claim> claims);
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
        string GenerateRefreshToken();
        int GetRefreshTokenExpiryDays();
        int GetMaxRefreshTokenAttempts();
        string GetEmailFromToken(string token);
    }
}
