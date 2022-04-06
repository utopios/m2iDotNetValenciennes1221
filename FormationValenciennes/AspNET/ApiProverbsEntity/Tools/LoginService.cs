using ApiProverbsEntity.Interfaces;
using ApiProverbsEntity.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Linq;
using System.Text;
using System;

namespace ApiProverbsEntity.Tools
{
    public class LoginService : ILoginService
    {
        private DataDbContext _data;

        public LoginService(DataDbContext data)
        {
            _data = data;
        }

        public string LogIn(string username, string password)
        {
            User user = _data.Users.SingleOrDefault(x => x.UserName == username && x.Password == password);
            
            if (user == null)
                return null;

            // 1 - Objet pour créer un JWT
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            // 2 - Création d'un clé => Convertir la chaine de cryptage en byte
            byte[] key = Encoding.ASCII.GetBytes("je suis une chaine secrete");

            // 3 - Création d'une variable descriptor pour le contenu du JWT
            SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor();
            descriptor.Audience = "mettre l'audience";
            descriptor.Issuer = "mettre l'issuer";
            descriptor.Subject = new ClaimsIdentity(new Claim[]
            {
                // Contenu du JWT => Création des elements transitant dans le JWT
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),               
                new Claim(ClaimTypes.Role, "admin")                
            });

            // 4 - Date Expiration du Token
            //descriptor.Expires = DateTime.Now.AddDays(1);
            descriptor.Expires = DateTime.Now.AddHours(1);
            //descriptor.Expires = DateTime.Now.AddMinutes(1);
            
            // 5 - Signature pour le JWT
            descriptor.SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);

            // 6 - Création du Token
            SecurityToken token = tokenHandler.CreateToken(descriptor);

            // 7 - Convertir le token en chaine de caractères
            user.Token = tokenHandler.WriteToken(token);

            // 8 - Sauvegarde du token de l'utilisateur dans la BDD
            _data.SaveChanges();

            // 9 - Retourne le token
            return user.Token;       



        }
    }
}
