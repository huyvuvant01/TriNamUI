// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PageableSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PageableSettings : JsonObject
  {
    public PageableSettings()
    {
      this.Messages = new PageableMessages();
      this.Numeric = true;
      this.Info = true;
      this.PreviousNext = true;
      this.ButtonCount = new int?(10);
    }

    public bool AutoBind { get; set; }

    public string ARIATemplate { get; set; }

    public string ARIATemplateId { get; set; }

    public PageableMessages Messages { get; private set; }

    public bool? Navigatable { get; set; }

    public bool Numeric { get; set; }

    public bool Info { get; set; }

    public bool Input { get; set; }

    public bool PreviousNext { get; set; }

    public bool Enabled { get; set; }

    public bool Refresh { get; set; }

    public bool? Responsive { get; set; }

    public IEnumerable PageSizes { get; set; }

    public int? ButtonCount { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (!this.AutoBind)
        json["autoBind"] = (object) this.AutoBind;
      if (this.Input)
        json["input"] = (object) this.Input;
      if (!this.Numeric)
        json["numeric"] = (object) this.Numeric;
      if (!this.Info)
        json["info"] = (object) this.Info;
      if (!this.PreviousNext)
        json["previousNext"] = (object) this.PreviousNext;
      if (this.Refresh)
        json["refresh"] = (object) this.Refresh;
      bool? nullable = this.Responsive;
      if (nullable.HasValue)
        json["responsive"] = (object) this.Responsive;
      if (this.PageSizes != null && this.PageSizes.GetEnumerator().MoveNext())
        json["pageSizes"] = (object) this.PageSizes;
      if (this.ButtonCount.HasValue)
        json["buttonCount"] = (object) this.ButtonCount;
      IDictionary<string, object> json1 = this.Messages.ToJson();
      if (json1.Keys.Any<string>())
        json["messages"] = (object) json1;
      if (!string.IsNullOrEmpty(this.ARIATemplateId))
        json["ARIATemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) "#", (object) this.ARIATemplateId)
        };
      else if (!string.IsNullOrEmpty(this.ARIATemplate))
        json["ARIATemplate"] = (object) this.ARIATemplate;
      nullable = this.Navigatable;
      if (!nullable.HasValue)
        return;
      json["navigatable"] = (object) this.Navigatable;
    }
  }
}
