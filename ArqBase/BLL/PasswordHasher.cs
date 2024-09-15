using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Servicios.BLL
{

    public static class PasswordHasher
    {
        // Método para hashear una contraseña con sal
        public static string HashPassword(string password)
        {
            // Genera una sal de 16 bytes
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Usa Rfc2898DeriveBytes para derivar una clave del password + salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Combina la sal y el hash en un solo array
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Convierte el array de bytes a una cadena base64 para almacenamiento
            return Convert.ToBase64String(hashBytes);
        }

        // Método para verificar que la contraseña proporcionada coincida con el hash almacenado
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Convierte el hash almacenado (base64) a un array de bytes
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            // Extrae la sal de los primeros 16 bytes
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Deriva la clave del password ingresado usando la misma sal
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            // Compara byte a byte el hash almacenado y el hash recién generado
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}