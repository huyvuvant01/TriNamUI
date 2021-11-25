// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.WizardStep
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class WizardStep
  {
    public Kendo.Mvc.UI.Form<object> Form { get; set; }

    public string Icon { get; set; }

    public string IconTemplate { get; set; }

    public string IconTemplateId { get; set; }

    public virtual Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Form != null)
        dictionary["form"] = (object) this.Form.Serialize();
      if (!string.IsNullOrEmpty(this.Icon))
        dictionary["icon"] = (object) this.Icon;
      if (this.IconTemplateId.HasValue())
        dictionary["iconTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('#{0}').html()", (object) this.IconTemplateId)
        };
      else if (this.IconTemplate.HasValue())
        dictionary["iconTemplate"] = (object) this.IconTemplate;
      return dictionary;
    }

    public List<WizardStepButton> Buttons { get; set; } = new List<WizardStepButton>();

    public string Content { get; set; }

    public string ContentId { get; set; }

    public string ContentUrl { get; set; }

    public string ClassName { get; set; }

    public bool? Enabled { get; set; }

    public bool? Pager { get; set; }

    public string Title { get; set; }

    public Wizard Wizard { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      IEnumerable<Dictionary<string, object>> source = this.Buttons.Select<WizardStepButton, Dictionary<string, object>>((Func<WizardStepButton, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["buttons"] = (object) source;
      string content = this.Content;
      if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["content"] = (object) this.Content;
      string contentId = this.ContentId;
      if ((contentId != null ? (contentId.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentId"] = (object) this.ContentId;
      string contentUrl = this.ContentUrl;
      if ((contentUrl != null ? (contentUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentUrl"] = (object) this.ContentUrl;
      string className = this.ClassName;
      if ((className != null ? (className.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["className"] = (object) this.ClassName;
      bool? nullable = this.Enabled;
      if (nullable.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      nullable = this.Pager;
      if (nullable.HasValue)
        dictionary["pager"] = (object) this.Pager;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      return dictionary;
    }
  }
}
