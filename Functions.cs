using System;

namespace Number
{
    public static class Functions
    {
        public static decimal FormatNumber(decimal Number, bool IgnoreDecimals)
        {
            // If set to not round decimals and preferences set
            if (IgnoreDecimals)
            {
                // return number
                return(Number);
            }
            // else return round number
            return(Math.Round(Number));
        }
        public static decimal FormatNumber(string Number, decimal Default, bool IgnoreDecimals)
        {
            string NewNumber = "";
            // Dash is not added yet and no digit is detected yet
            bool DashPossible = true;
            bool DotPossible = true;
            // Filter out all characters except "-" or digits
            foreach (char Character in Number.ToCharArray())
            {
                // If is dash and DashPossible
                if (DashPossible && Character == '-')
                {
                    // Add dash
                    NewNumber += "-";
                    // Makes sure the dash does not get added again
                    DashPossible = false;
                }
                // if is dot and dotpossible
                else if (DotPossible && Character == '.')
                {
                    // Add dot
                    NewNumber += ".";
                    // Makes sure the dash and dot does not get added again
                    DotPossible = false;
                    DashPossible = false;
                }
                // If is a digit
                else if (char.IsDigit(Character))
                {
                    // Makes sure the dash does not get added
                    DashPossible = false;
                    // Add digit
                    NewNumber += Character;
                }
            }
            // Set new formated number
            Number = NewNumber;
            // If can parse number
            if (decimal.TryParse(Number, out decimal ParsedNumber))
            {
                // Return parsed number
                return(FormatNumber(ParsedNumber, IgnoreDecimals));
            }
            // if cannot parse, return Default value
            return(Default);
        }
    }
}