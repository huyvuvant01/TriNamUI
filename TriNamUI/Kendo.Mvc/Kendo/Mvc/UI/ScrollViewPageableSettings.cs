// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ScrollViewPageableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ScrollViewPageableSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string ARIATemplate { get; set; }

    public string ARIATemplateId { get; set; }

    public bool? Enabled { get; set; }

    public ScrollView ScrollView { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.ARIATemplateId.HasValue())
        dictionary["ARIATemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.ScrollView.IdPrefix, (object) this.ARIATemplateId)
        };
      else if (this.ARIATemplate.HasValue())
        dictionary["ARIATemplate"] = (object) this.ARIATemplate;
      return dictionary;
    }
  }
}
