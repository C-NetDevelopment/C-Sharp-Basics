using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EncryptionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //RSA
            //Public key
            //private key

            string originalData = "Hello  Capgemini";
            RSAParameters publicKey, privateKey;
            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "CapgeminiKey";
            using (var rsa = new RSACryptoServiceProvider(cspParams))
            {
                rsa.PersistKeyInCsp = true;
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);
                rsa.Clear();
            }

            byte[] encrypted = EncryptUsingRSA(originalData, publicKey);
            Console.ReadLine();
            string decrypted = DecryptUsingRSA(encrypted, privateKey);
            Console.WriteLine(decrypted);
            Console.Read();
        }

        private static string DecryptUsingRSA(byte[] encrypted, RSAParameters parameters)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(parameters);
                byte[] decryptedData = rsa.Decrypt(encrypted,true);
                string decryptedValue = Encoding.Default.GetString(decryptedData);
                rsa.Clear();
                return decryptedValue;
            }
        }

        static byte[] EncryptUsingRSA(string data, RSAParameters parameters)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(parameters);
                byte[] encodeData = Encoding.Default.GetBytes(data);
                byte[] encryptedData = rsa.Encrypt(encodeData, true);
                rsa.Clear();
                return encryptedData;
            }           
        }
    }
}
