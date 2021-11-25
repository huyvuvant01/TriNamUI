// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.StringExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.Extensions
{
  public static class StringExtensions
  {
    private static readonly Regex NameExpression = new Regex("([A-Z]+(?=$|[A-Z][a-z])|[A-Z]?[a-z]+)", RegexOptions.Compiled);
    private static readonly Regex EntityExpression = new Regex("(&amp;|&)#([0-9]+;)", RegexOptions.Compiled);

    public static string FormatWith(this string instance, params object[] args) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, instance, args);

    public static string EscapeHtmlEntities(this string html) => StringExtensions.EntityExpression.Replace(html, "$1\\\\#$2");

    public static bool HasValue(this string value) => !string.IsNullOrEmpty(value);

    public static bool IsCaseSensitiveEqual(this string instance, string comparing) => string.CompareOrdinal(instance, comparing) == 0;

    public static bool IsCaseInsensitiveEqual(this string instance, string comparing) => string.Compare(instance, comparing, StringComparison.OrdinalIgnoreCase) == 0;

    public static string ToCamelCase(this string instance) => instance[0].ToString().ToLowerInvariant() + instance.Substring(1);

    public static string AsTitle(this string value)
    {
      if (value == null)
        return string.Empty;
      int num = value.LastIndexOf(".", StringComparison.Ordinal);
      if (num > -1)
        value = value.Substring(num + 1);
      return value.SplitPascalCase();
    }

    public static T ToEnum<T>(this string value, T defaultValue)
    {
      if (!value.HasValue())
        return defaultValue;
      try
      {
        return (T) Enum.Parse(typeof (T), value, true);
      }
      catch (ArgumentException ex)
      {
        return defaultValue;
      }
    }

    public static string SplitPascalCase(this string value) => StringExtensions.NameExpression.Replace(value, " $1").Trim();

    public static string JavaScriptStringEncode(this string value, bool addDoubleQuotes)
    {
      string str = value.JavaScriptStringEncode();
      return !addDoubleQuotes ? str : "\"" + str + "\"";
    }

    public static string JavaScriptStringEncode(this string value)
    {
      if (string.IsNullOrEmpty(value))
        return string.Empty;
      StringBuilder builder = (StringBuilder) null;
      int startIndex = 0;
      int count = 0;
      for (int index = 0; index < value.Length; ++index)
      {
        char c = value[index];
        if (StringExtensions.CharRequiresJavaScriptEncoding(c))
        {
          if (builder == null)
            builder = new StringBuilder(value.Length + 5);
          if (count > 0)
            builder.Append(value, startIndex, count);
          startIndex = index + 1;
          count = 0;
        }
        switch (c)
        {
          case '\b':
            builder.Append("\\b");
            break;
          case '\t':
            builder.Append("\\t");
            break;
          case '\n':
            builder.Append("\\n");
            break;
          case '\f':
            builder.Append("\\f");
            break;
          case '\r':
            builder.Append("\\r");
            break;
          case '"':
            builder.Append("\\\"");
            break;
          case '\\':
            builder.Append("\\\\");
            break;
          default:
            if (!StringExtensions.CharRequiresJavaScriptEncoding(c))
            {
              ++count;
              break;
            }
            StringExtensions.AppendCharAsUnicodeJavaScript(builder, c);
            break;
        }
      }
      if (builder == null)
        return value;
      if (count > 0)
        builder.Append(value, startIndex, count);
      return builder.ToString();
    }

    private static bool CharRequiresJavaScriptEncoding(char c) => c < ' ' || c == '"' || c == '\\' || c == '\'' || c == '<' || c == '>' || c == '&' || c == '\u0085' || c == '\u2028' || c == '\u2029';

    private static void AppendCharAsUnicodeJavaScript(StringBuilder builder, char c)
    {
      builder.Append("\\u");
      int num = (int) c;
      builder.Append(num.ToString("x4", (IFormatProvider) CultureInfo.InvariantCulture));
    }
  }
}
