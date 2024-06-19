using Auth.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Auth.AppCode
{
    public class TokenManager
    {
        public record User(string Username, string Password, string Role, string[] Scopes);
        private readonly List<User> _users = new()
        {
            new("admin", "aDm1n", "Administrator", new[] {"shoes.read"}),
            new("user01", "u$3r01", "User", new[] {"shoes.read"})
        };

        public LoginResponse? GenerateAuthToken(LoginRequest loginModel)
        {
            var user = _users.FirstOrDefault(u => u.Username == loginModel.Username
                                               && u.Password == loginModel.Password);

            if (user is null)
            {
                return null;
            }
            
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtExtensions.SecurityKey));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var expirationTimeStamp = DateTime.Now.AddMinutes(5);

            var claims = new List<Claim>
        {
            new Claim("username", user.Username),
            new Claim("role", user.Role),
            new Claim("scope", string.Join(" ", user.Scopes))
        };

            var tokenOptions = new JwtSecurityToken(
                issuer: JwtExtensions.ValidIssuer,
                claims: claims,
                expires: expirationTimeStamp,
                signingCredentials: signingCredentials
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return new LoginResponse(tokenString, (int)expirationTimeStamp.Subtract(DateTime.Now).TotalSeconds);
        }
    }
}
