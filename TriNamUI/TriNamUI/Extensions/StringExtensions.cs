using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace TriNamUI.Extensions
{
    /// <summary>
    /// Mở rộng phương thức cho string
    /// </summary>
    public static partial class StringExtensions
    {
        #region Contants

        /// <summary>
        /// NameExpression
        /// </summary>
        private static readonly Regex NameExpression = new("([A-Z]+(?=$|[A-Z][a-z])|[A-Z]?[a-z]+)", RegexOptions.Compiled);

        /// <summary>
        /// EntityExpression
        /// </summary>
        private static readonly Regex EntityExpression = new("(&amp;|&)#([0-9]+;)", RegexOptions.Compiled);

        #endregion

        #region Methods

        /// <summary>
        /// Định dạng chuỗi với CurrentCulture
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="args"></param>
        /// <returns>Chuỗi</returns>
        public static string FormatWith(this string instance, params object[] args)
        {
            return string.Format(CultureInfo.CurrentCulture, instance, args);
        }

        /// <summary>
        /// Replace các kí tự đặc biệt trong chuỗi html
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string EscapeHtmlEntities(this string html)
        {
            return EntityExpression.Replace(html, "$1\\\\#$2");
        }

        /// <summary>
        /// Kiểm tra chuỗi có giá trị (khác null & khác rỗng && tồn tại kí tự khác space)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool HasValue(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// So sánh giá trị 2 chuỗi
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="comparing"></param>
        /// <returns></returns>
        public static bool IsCaseSensitiveEqual(this string instance, string comparing)
        {
            return string.CompareOrdinal(instance, comparing) == 0;
        }

        /// <summary>
        /// Format chuỗi thành định dạng CamelCase (viết hoa kí tự đầu)
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static string ToCamelCase(this string instance)
        {
            return instance[0].ToString().ToLowerInvariant() + instance[1..];
        }

        /// <summary>
        /// Trích xuất chuỗi và lấy giá trị 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string AsTitle(this string value)
        {
            if (!value.HasValue())
            {
                return string.Empty;
            }
            const string dots = ".";
            int num = value.LastIndexOf(dots, StringComparison.Ordinal);
            value = num > -1 ? value[(num + 1)..] : value.SplitPascalCase();
            return value;
        }

        /// <summary>
        /// Convert chuỗi tới kiểu Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this string value, T defaultValue)
        {
            if (!value.HasValue())
            {
                return defaultValue;
            }
            try
            {
                return (T)Enum.Parse(typeof(T), value, ignoreCase: true);
            }
            catch (ArgumentException)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SplitPascalCase(this string value)
        {
            return NameExpression.Replace(value, " $1").Trim();
        }

        /// <summary>
        /// JavaScriptStringEncode
        /// </summary>
        /// <param name="value"></param>
        /// <param name="addDoubleQuotes"></param>
        /// <returns></returns>
        public static string JavaScriptStringEncode(this string value, bool addDoubleQuotes)
        {
            string text = value.JavaScriptStringEncode();
            return !addDoubleQuotes ? text : $"\"{text}\"";
        }

        /// <summary>
        /// JavaScriptStringEncode
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string JavaScriptStringEncode(this string value)
        {
            if (!value.HasValue())
            {
                return string.Empty;
            }
            StringBuilder stringBuilder = null;
            int startIndex = 0;
            int num = 0;
            for (int i = 0; i < value.Length; i++)
            {
                char c = value[i];
                if (CharRequiresJavaScriptEncoding(c))
                {
                    if (stringBuilder == null)
                    {
                        stringBuilder = new StringBuilder(value.Length + 5);
                    }
                    if (num > 0)
                    {
                        stringBuilder.Append(value, startIndex, num);
                    }
                    startIndex = i + 1;
                    num = 0;
                }
                switch (c)
                {
                    case '\b':
                        stringBuilder.Append("\\b");
                        continue;
                    case '\t':
                        stringBuilder.Append("\\t");
                        continue;
                    case '\n':
                        stringBuilder.Append("\\n");
                        continue;
                    case '\f':
                        stringBuilder.Append("\\f");
                        continue;
                    case '\r':
                        stringBuilder.Append("\\r");
                        continue;
                    case '"':
                        stringBuilder.Append("\\\"");
                        continue;
                    case '\\':
                        stringBuilder.Append("\\\\");
                        continue;
                }
                if (!CharRequiresJavaScriptEncoding(c))
                {
                    num++;
                }
                else
                {
                    AppendCharAsUnicodeJavaScript(stringBuilder, c);
                }
            }
            if (stringBuilder == null)
            {
                return value;
            }
            if (num > 0)
            {
                stringBuilder.Append(value, startIndex, num);
            }
            return stringBuilder.ToString();
        }

        private static bool CharRequiresJavaScriptEncoding(char c)
        {
            if (c < ' ' || c == '"' || c == '\\' || c == '\'' || c == '<' || c == '>' || c == '&' || c == '\u0085' || c == '\u2028')
            {
                return true;
            }
            return c == '\u2029';
        }

        private static void AppendCharAsUnicodeJavaScript(StringBuilder builder, char c)
        {
            builder.Append("\\u");
            int num = c;
            builder.Append(num.ToString("x4", CultureInfo.InvariantCulture));
        }

        #endregion
    }
}
