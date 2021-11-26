// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.MemberAccessTokenizer
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;


#nullable enable
namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal static class MemberAccessTokenizer
  {
    public static 
    #nullable disable
    IEnumerable<IMemberAccessToken> GetTokens(string memberPath)
    {
      string[] strArray = memberPath.Split(new char[2]
      {
        '.',
        '['
      }, StringSplitOptions.RemoveEmptyEntries);
      for (int index = 0; index < strArray.Length; ++index)
      {
        string str = strArray[index];
        IndexerToken token;
        if (MemberAccessTokenizer.TryParseIndexerToken(str, out token))
          yield return (IMemberAccessToken) token;
        else
          yield return (IMemberAccessToken) new PropertyToken(str);
      }
      strArray = (string[]) null;
    }

    private static bool TryParseIndexerToken(string member, out IndexerToken token)
    {
      token = (IndexerToken) null;
      if (!MemberAccessTokenizer.IsValidIndexer(member))
        return false;
      List<object> objectList = new List<object>();
      objectList.AddRange(MemberAccessTokenizer.ExtractIndexerArguments(member).Select<string, object>((Func<string, object>) (a => MemberAccessTokenizer.ConvertIndexerArgument(a))));
      token = new IndexerToken((IEnumerable<object>) objectList);
      return true;
    }

    private static bool IsValidIndexer(string member) => member.EndsWith("]", StringComparison.Ordinal);

    private static IEnumerable<string> ExtractIndexerArguments(string member)
    {
      string[] strArray = member.TrimEnd(']').Split(',');
      for (int index = 0; index < strArray.Length; ++index)
        yield return strArray[index];
      strArray = (string[]) null;
    }

    private static object ConvertIndexerArgument(string argument)
    {
      int result;
      if (int.TryParse(argument, out result))
        return (object) result;
      if (argument.StartsWith("\"", StringComparison.Ordinal))
        return (object) argument.Trim('"');
      if (!argument.StartsWith("'", StringComparison.Ordinal))
        return (object) argument;
      string str = argument.Trim('\'');
      return str.Length == 1 ? (object) str[0] : (object) str;
    }
  }
}
