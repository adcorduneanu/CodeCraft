using System.Collections.Generic;
using System.Text;

namespace CraftCode
{
    public class RomanNumberalConverter
    {
        private readonly Dictionary<int, string> romanMapping = new Dictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        public string Convert(int arrabicNumber)
        {
            if (arrabicNumber < 1)
                return null;
            
            if (romanMapping.ContainsKey(arrabicNumber))
                return romanMapping[arrabicNumber];

            StringBuilder convertedValue = new StringBuilder();
            foreach (var map in romanMapping)
            {
                while (arrabicNumber >= map.Key)
                {
                    convertedValue.Append(map.Value);
                    arrabicNumber -= map.Key;
                }
            }

            return convertedValue.ToString();
        }
    }
}
