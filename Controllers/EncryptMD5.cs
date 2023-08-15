using Appoiment_API.Data.Models;
using Appoiment_API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace Appoiment_API.Controllers
{
    public class EncryptMD5
    {
        private readonly IConfiguration _config;

        public EncryptMD5(IConfiguration config)
        {
            _config = config;
        }

        public string Encrypt (string msg)
        {
            string hash = _config["MD5:hash"];
            byte[] data = UTF8Encoding.UTF8.GetBytes(msg);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }

        public string Decryp (string msgEncript)
        {
            string hash = _config["MD5:hash"];
            byte[] data = Convert.FromBase64String(msgEncript);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();
            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);
        }

    }
}
