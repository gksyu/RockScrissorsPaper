using System;
using System.Security.Cryptography;

namespace RockScrissorsPaper
{
    class Key
    {
        public static string RandKeyGenerator()
        {
            RandomNumberGenerator generator = RandomNumberGenerator.Create();
            byte[] randomKey = new byte[32];
            generator.GetBytes(randomKey);
            string key = BitConverter.ToString(randomKey).Replace("-", string.Empty);
            return key;
        }
    }
}
