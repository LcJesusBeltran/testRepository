using System;
using System.Text.RegularExpressions;
namespace InternalAPI.Content
{
    public class Utilities
    {
        public bool bError { get; set; }
        public string Descripcin { get; set; }

        public string CleanInput(string strIn)
        {
            try
            {
                return Regex.Replace(strIn, @"[^\w\.@-]", "",
                    RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                bError = true;
                Descripcin = "Timeout";
                return string.Empty;
            }
        }
    }
}
