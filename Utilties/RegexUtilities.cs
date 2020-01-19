using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace SamsSimpleSupportRequest.Utilties
{
    /// <summary>
    /// Common Regex functions.
    /// </summary>
    public static class RegexUtilities
    {
        /// <summary>
        /// Assesses a string and determines if it follows an email pattern.
        /// </summary>
        /// <param name="address">String representing an email address.</param>
        /// <returns>Bool confirming email validity.</returns>
        public static bool IsValidEmail(string address)
        {
            if (string.IsNullOrWhiteSpace(address)) { return false; }

            try
            {
                address = Regex.Replace(address, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch(RegexMatchTimeoutException ex)
            {
                return false;
            }
            catch(ArgumentException ex)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(address, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
