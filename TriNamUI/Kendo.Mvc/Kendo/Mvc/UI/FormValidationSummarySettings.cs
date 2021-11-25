// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FormValidationSummarySettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FormValidationSummarySettings
  {
    public FormValidationSummarySettings() => this.Enabled = true;

    public bool Enabled { get; set; }

    public string Container { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (!string.IsNullOrEmpty(this.TemplateId))
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('#{0}').html()", (object) this.TemplateId)
        };
      else if (!string.IsNullOrEmpty(this.Template))
        dictionary["template"] = (object) this.Template;
      if (this.Container.HasValue())
        dictionary["container"] = (object) this.Container;
      return dictionary;
    }
  }
}
