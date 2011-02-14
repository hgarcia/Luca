namespace Luca.Core
{
    public static class StringExtensions
    {
        public static string Capitalize(this string value)
        {
            var tmp = string.Empty;
            if (value.Length > 0)
            {
                var words = value.Split('-');
                foreach (var word in words)
                {
                    var firstChar = word.Substring(0, 1).ToUpper();
                    tmp += firstChar + word.Substring(1).ToLower();
                }
            }
            return tmp;
        }
    }
}
