using System.Security.Cryptography;
using System.Text;

namespace Academy_2024.Services
{
    public static class titkositas
    {
        public static string HashSzovegMD5(string szoveg)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                // Szöveg kódolása UTF8-ban
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(szoveg));

                // Byte tömb átalakítása stringgé
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    builder.Append(data[i].ToString("x2")); // "x2" formátum: két karakteres hexadecimális formátum
                }
                return builder.ToString();
            }
        }
    }
}
