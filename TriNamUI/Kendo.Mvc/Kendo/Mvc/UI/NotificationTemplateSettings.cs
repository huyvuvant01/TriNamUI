// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.NotificationTemplateSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class NotificationTemplateSettings
  {
    public string Type { get; set; }

    public string ClientTemplateID { get; set; }

    public string ClientTemplate { get; set; }

    internal IDictionary<string, object> Serialize()
    {
      if (string.IsNullOrEmpty(this.Type))
        throw new InvalidOperationException("Template Type cannot be null or an empty string.");
      return (IDictionary<string, object>) new Dictionary<string, object>()
      {
        ["type"] = (object) this.Type,
        ["templateId"] = (object) (this.ClientTemplateID ?? ""),
        ["template"] = (object) (this.ClientTemplate ?? "")
      };
    }
  }
}
