namespace BankManagement.Utils
{
    public static class myString
    {
        //1 Standard: Trim and remove extra spaces
        public static string Standard(this string s)
        {
            try
            {
                s = s.Trim(); // Remove leading and trailing spaces
                while (s.Contains("  ")) // While there are double spaces
                    s = s.Replace("  ", " "); // Replace double spaces with single space
                return s;
            } 
            catch { return ""; } 
        }
        //2 Left: Get left n characters
        public static string Left(this string s, int n)
        {
            if (n < 0 || n > s.Length || s == null) return "";
            // return s[..n]; // C# 8.0 range operator
            return s.Substring(0, n);
        }
        //3 Right: Get right n characters
        public static string Right(this string s, int n)
        {
            if (n < 0 || n > s.Length || s == null) return "";
            // return s[^n..]; // C# 8.0 range operator
            return s.Substring(s.Length - n, n);
        }
        //4 Mid: Get n characters from index
        public static string Mid(this string s, int index, int n)
        {
            if (n < 0 || n > s.Length - index || index < 0 || index >= s.Length || s == null) return " ";
            return s.Substring(index, n);
        }
        //5 Proper: Capitalize first letter of each word
        public static string Proper(this string s)
        {
            try
            {
                s = s.Standard();
                s = s.ToLower(); // Convert all to lowercase
                string[] w = s.Split(" "); // Split by space
                for (int i = 0; i < w.Length; ++i)
                {
                    string st = w[i];
                    if (st.Length > 0)
                    {
                        w[i] = char.ToUpper(st[0]) + st.Substring(1); // Capitalize first letter
                    }
                }
                return string.Join(" ", w); // Join back to string
            }
            catch { return ""; }
        }
        //6 Name in Vietnamese: Ho Ten
        public static (string Ho, string Ten) TachHoTen(this string s)
        {
            try
            {
                s = s.Proper();
                int index = s.LastIndexOf(' '); // vị trí khoảng trắng cuối cùng

                string ho = s.Left(index).Trim();
                string ten = s.Right(s.Length - index).Trim();

                return (ho, ten);
            }
            catch
            {
                return (string.Empty, string.Empty);
            }
        }

        //7 Name in English: FirstName LastName
        public static (string FirstName, string LastName) SplitFullName(this string s)
        {
            try
            {
                s = s.Proper();
                int index = s.IndexOf(' '); // vị trí khoảng trắng đầu tiên

                string firstName = s.Left(index).Trim();
                string lastName = s.Right(s.Length - index).Trim();

                return (firstName, lastName);
            }
            catch
            {
                return (string.Empty, string.Empty);
            }
        }
    }
}
