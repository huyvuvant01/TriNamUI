// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.HtmlAttributesContainerExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI;
using System;

namespace Kendo.Mvc.Extensions
{
  public static class HtmlAttributesContainerExtensions
  {
    public static void ThrowIfClassIsPresent(
      this IHtmlAttributesContainer container,
      string @class,
      string message)
    {
      object obj;
      if (container.HtmlAttributes.TryGetValue(nameof (@class), out obj) && obj != null && Array.IndexOf<string>(obj.ToString().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries), @class) > -1)
        throw new NotSupportedException(message.FormatWith((object) @class));
    }
  }
}
