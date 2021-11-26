// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.BreadcrumbMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class BreadcrumbMessagesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string RootTitle { get; set; }

    public Breadcrumb Breadcrumb { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string rootTitle = this.RootTitle;
      if ((rootTitle != null ? (rootTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["rootTitle"] = (object) this.RootTitle;
      return dictionary;
    }
  }
}
