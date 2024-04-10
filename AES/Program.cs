using System;
using System.Security.Cryptography;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string originalText = "Hello, AES encryption!";
        string key = "0123456789abcdef0123456789abcdef"; // 256-bit key (32 bytes)

        byte[] encryptedBytes = EncryptAES(originalText, key);
        string encryptedText = Convert.ToBase64String(encryptedBytes);
        Console.WriteLine("Encrypted: " + encryptedText);

        string decryptedText = DecryptAES(encryptedBytes, key);
        Console.WriteLine("Decrypted: " + decryptedText);
    }

    public static byte[] EncryptAES(string text, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(key);
            aesAlg.Mode = CipherMode.CBC;
            aesAlg.Padding = PaddingMode.PKCS7;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            byte[] encrypted;

            using (var msEncrypt = new System.IO.MemoryStream())
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(text);
                }
                encrypted = msEncrypt.ToArray();
            }

            byte[] result = new byte[aesAlg.IV.Length + encrypted.Length];
            Array.Copy(aesAlg.IV, result, aesAlg.IV.Length);
            Array.Copy(encrypted, 0, result, aesAlg.IV.Length, encrypted.Length);

            return result;
        }
    }

    public static string DecryptAES(byte[] cipherText, string key)
    {
        string plaintext = null;

        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(key);
            aesAlg.Mode = CipherMode.CBC;
            aesAlg.Padding = PaddingMode.PKCS7;

            byte[] iv = new byte[aesAlg.BlockSize / 8];
            byte[] cipher = new byte[cipherText.Length - aesAlg.BlockSize / 8];
            Array.Copy(cipherText, iv, iv.Length);
            Array.Copy(cipherText, iv.Length, cipher, 0, cipher.Length);

            aesAlg.IV = iv;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (var msDecrypt = new System.IO.MemoryStream(cipher))
            {
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    plaintext = srDecrypt.ReadToEnd();
                }
            }
        }

        return plaintext;
    }
}
