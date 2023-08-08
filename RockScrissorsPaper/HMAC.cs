using System;
using System.Text;
using Org.BouncyCastle.Crypto.Digests;

namespace RockScrissorsPaper
{
    class HMAC
    {
        public static string CalculateHMAC(string prehmac)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(prehmac);
            Sha3Digest sha3 = new Sha3Digest(256);
            byte[] hash2 = new byte[sha3.GetDigestSize()];
            sha3.BlockUpdate(byteArray, 0, byteArray.Length);
            sha3.DoFinal(hash2, 0);
            return BitConverter.ToString(hash2).Replace("-", "");
        }
    }
}
