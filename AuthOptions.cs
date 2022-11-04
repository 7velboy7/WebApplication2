using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WebApplication1
{
    public class AuthOptions // should deleted if not used, but it still needed for some postman tests
    {
        public const string ISSUER = "AlexsServer";
        public const string AUDIENCE = "DSSClients";
        const string KEY = "secret_key";
        public static SymmetricSecurityKey GetSymetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));

    }
}
