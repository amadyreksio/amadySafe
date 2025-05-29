using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public class AesEncryptionWithPassword
{
    private readonly byte[] key;
    private readonly byte[] iv;

    public AesEncryptionWithPassword(string password, byte[] salt, int iterations = 100_000)
    {
        if (salt.Length < 8)
            throw new ArgumentException("Salt must be at least 8 bytes long.");

        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256);
        key = pbkdf2.GetBytes(32); // AES-256 key
        iv = pbkdf2.GetBytes(16);  // AES block size is 16 bytes
    }

    public byte[] Encrypt(byte[] plainBytes)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            MemoryStream ms = new MemoryStream();
            using (ICryptoTransform encryptor = aes.CreateEncryptor())
            using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            {
                cs.Write(plainBytes, 0, plainBytes.Length);
                cs.FlushFinalBlock();
            }
            return ms.ToArray();
        }
    }

    public byte[] Decrypt(byte[] cipherBytes)
    {
        try { 
        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.IV = iv;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            MemoryStream ms = new MemoryStream();
            using (ICryptoTransform decryptor = aes.CreateDecryptor())
            using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
            {
                cs.Write(cipherBytes, 0, cipherBytes.Length);
                cs.FlushFinalBlock();
            }
            return ms.ToArray();
        }
        }
        catch {
            
        }
        return null;
    }
}
