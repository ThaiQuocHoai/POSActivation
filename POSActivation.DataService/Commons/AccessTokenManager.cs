using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace POSActivation.DataService.Commons
{
    public class AccessTokenManager
    {
        public static string GenerateJwtToken(string username)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Constants.SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var permClaims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Name, username),
            };
            var token = new JwtSecurityToken(Constants.Issuer,
                Constants.Issuer,
                permClaims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
