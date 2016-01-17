using System;

namespace TelegramBot
{
    internal static class Utils
    {
        public static DateTime intToDtt(long intDtt)
        {
            return new DateTime(1970, 1, 1).AddSeconds(intDtt);
        }
    }
}