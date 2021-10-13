using System;

namespace SecretKeyGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumberGenerator = System.Security.Cryptography.RandomNumberGenerator.Create();
            var bytes = new byte[256 / 8];
            randomNumberGenerator.GetBytes(bytes);
            Console.WriteLine(Convert.ToBase64String(bytes));
        }
    }
}
