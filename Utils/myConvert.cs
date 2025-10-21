using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace BankManagement.Utils
{
    public static class myConvert
    {
        // NOTE: These methods throw exceptions if conversion fails.
        // 1 String to Int
        public static int ToInt(this string s)
        {
            return int.Parse(s);
        }
        // 2 String to Double
        public static double ToDouble(this string s)
        {
            return double.Parse(s);
        }
        // 3 String to Float
        public static float ToFloat(this string s)
        {
            return float.Parse(s);
        }
        // 4 String to Decimal
        public static decimal ToDecimal(this string s)
        {
            return decimal.Parse(s);
        }
        // 5 String to DateTime (DD/MM/YYYY or DD-MM-YYYY)
        /// <summary>
        /// Chuyển chuỗi định dạng "dd/MM/yyyy" hoặc "dd-MM-yyyy thành DateTime với định dạng chung là "dd/MM/yyyy"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static DateTime ToDateMonthYear(this string s)
        {
            try
            {
                string[] format = { "dd-MM-yyyy", "dd/MM/yyyy" };
                return DateTime.ParseExact(s, format, CultureInfo.InvariantCulture, DateTimeStyles.None);
            }
            catch (Exception ex)
            {
                throw new FormatException($"{nameof(ToDateMonthYear)} failed: {ex.Message}", ex);
            }
        }
        // 6 String to DateTime (MM/DD/YYYY or MM-DD-YYYY)
        /// <summary>
        /// Chuyển chuỗi định dạng "MM/dd/yyyy" hoặc "MM-dd-yyyy" thành DateTime với định dạng chung là "MM/dd/yyyy"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static DateTime ToMonthDateYear(this string s)
        {
            try
            {
                string[] format = { "MM-dd-yyyy", "MM/dd/yyyy" };
                return DateTime.ParseExact(s, format, CultureInfo.InvariantCulture, DateTimeStyles.None);
            }
            catch (Exception ex)
            {
                throw new FormatException($"{nameof(ToMonthDateYear)} failed: {ex.Message}", ex);
            }
        }
        // 7 String to DateTime (YYYY/MM/DD or YYYY-MM-DD)
        /// <summary>
        /// Chuyển chuỗi định dạng "yyyy/MM/dd" hoặc "yyyy-MM-dd" thành DateTime với định dạng chung là "yyyy/MM/dd"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static DateTime ToYearMonthDate(this string s)
        {
            try
            {
                string[] format = { "yyyy-MM-dd", "yyyy/MM/dd" };
                return DateTime.ParseExact(s, format, CultureInfo.InvariantCulture, DateTimeStyles.None);
            }
            catch (Exception ex)
            {
                throw new FormatException($"{nameof(ToYearMonthDate)} failed: {ex.Message}", ex);
            }
        }
        // 8 List<> to CSV string
        public static string ListToCSV<T>(this List<T> data)
        {
            var s = new StringBuilder();
            // Add Header Row if data is not empty
            if (data.Count > 0)
            {
                var properties = typeof(T).GetProperties(); // Get properties of template T
                for(int i = 0; i < properties.Length; ++i)
                {
                    s.Append(properties[i].Name);
                    if (i < properties.Length - 1)
                        s.Append(","); // Add comma except last column
                }
                s.AppendLine(); // End of header row
            }
            // Add Data Rows
            foreach(var item in data)
            {
                var properties = typeof(T).GetProperties();
                for(int i = 0; i < properties.Length; i++)
                {
                    var value = properties[i].GetValue(item)?.ToString() ?? ""; // Get string value if the property value is not null, return empty string if null
                    // Handle Comma (,) or Quotation marks (") in property data
                    if(value.Contains(',') || value.Contains('"'))
                    {
                        value = value.Replace("\"", "\"\""); // Escape quotation marks by doubling them
                        value = $"\"{value}\""; // Enclose the entire field in quotation marks
                    }
                    s.Append(value); // Append the value in to the current CSV line
                    if (i < properties.Length - 1)
                        value += ","; // Add comma except last column
                }
                s.AppendLine(); // End of a data row
            }
            return s.ToString();
        }
        // 9 Save File to .csv format
        public static void SaveCSV<T>(this List<T> data, string? path = null)
        {
            // Nếu không truyền path thì lưu vào folder Data
            if (string.IsNullOrWhiteSpace(path))
            {
                string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string fileName = $"Export_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                path = Path.Combine(folder, fileName);
            }

            string csv = data.ListToCSV();
            File.WriteAllText(path, csv, Encoding.UTF8);
        }
        // 10 Load File from .csv
        public static List<T> LoadCSV<T>(string path) where T : new()
        {
            var result = new List<T>();

            if (!File.Exists(path))
                throw new FileNotFoundException($"❌ File not found: {path}");

            var lines = File.ReadAllLines(path, Encoding.UTF8);
            if (lines.Length < 2)
                return result; // No Data

            // First line is header
            var headers = lines[0].Split(',');

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                if (values.Length == 0 || string.IsNullOrWhiteSpace(values[0]))
                    continue;

                var obj = new T();
                var props = typeof(T).GetProperties();

                for (int j = 0; j < headers.Length && j < values.Length; j++)
                {
                    var prop = props.FirstOrDefault(p => p.Name == headers[j]);
                    if (prop != null && prop.CanWrite)
                    {
                        try
                        {
                            object? convertedValue = Convert.ChangeType(values[j], prop.PropertyType);
                            prop.SetValue(obj, convertedValue);
                        }
                        catch
                        {
                            // Skip
                        }
                    }
                }
                result.Add(obj);
            }
            return result;
        }

    }
}
