namespace HakatonApp.Services
{
    using System;
    using System.Text;

    using static HakatonApp.Common.GlobalConstants;

    public class RandomGenerator : IRandomGenerator
    {
        public string GetRandomString()
        {
            var rnd = new Random();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < NumOfRandomStringChars; i++)
            {
                builder.Append((char)rnd.Next(33, 120));
            }

            return builder.ToString();
        }
    }
}
