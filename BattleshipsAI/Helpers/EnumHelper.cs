using System;

namespace BattleshipsAI.Helpers
{
    public static class EnumHelper
    {
        public static string GetString<T>(this T value)
        {
            return Enum.GetName(typeof(T), value);
        }
    }
}