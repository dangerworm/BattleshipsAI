using System;

namespace BattleshipsAI.Helpers
{
    public static class GridHelper
    {
        public static int GetXValueFromColumnLetter(string columnLetter)
        {
            return Convert.ToInt32(columnLetter) - 65;
        }

        public static int GetYValueFromRowNumber(string rowNumber)
        {
            return Convert.ToInt32(rowNumber) - 1;
        }

        public static string GetColumnLetterFromXValue(int x)
        {
            return Convert.ToChar(x + 65).ToString();
        }

        public static int GetRowNumberFromYValue(int y)
        {
            return y + 1;
        }

        public static string GetGridReferenceFromXAndY(int x, int y)
        {
            return $"{GetColumnLetterFromXValue(x)}{GetRowNumberFromYValue(y)}";
        }

        public static int[] GetXAndYFromGridReference(string gridReference)
        {
            return new[]
            {
                GetXValueFromColumnLetter(gridReference[0].ToString()),
                GetYValueFromRowNumber(gridReference.Substring(1))
            };
        }
    }
}