// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ScrollViewItemBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Reflection;

namespace Kendo.Mvc.TagHelpers
{
  public class ScrollViewItemBase
  {
    public string Content { get; set; }

    public object ContentHtmlAttributes { get; set; }

    public IEnumerable<ScrollViewItemBase> Items { get; set; }

    public ScrollViewItemTagHelper ConvertToTagHelper()
    {
      ScrollViewItemTagHelper viewItemTagHelper = new ScrollViewItemTagHelper();
      foreach (PropertyInfo property in typeof (ScrollViewItemBase).GetProperties())
        typeof (ScrollViewItemTagHelper).GetProperty(property.Name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public).SetValue((object) viewItemTagHelper, property.GetValue((object) this));
      return viewItemTagHelper;
    }
  }
}
