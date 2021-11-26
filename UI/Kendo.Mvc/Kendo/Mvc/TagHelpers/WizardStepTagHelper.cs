// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.WizardStepTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("wizard-step", ParentTag = "wizard-steps", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("wizard-step-buttons", new string[] {"wizard-step-content", "wizard-step-form"})]
  [SuppressTagRendering]
  public class WizardStepTagHelper : TagHelperCollectionItemBase
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    WizardStepContentTagHelper Content { get; set; }

    [HtmlAttributeNotBound]
    public Dictionary<string, object> Form { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (WizardStepsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as WizardStepsTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Content != null && !string.IsNullOrEmpty(this.Content.Content))
        dictionary["content"] = (object) this.Content.Content.Replace("\r\n", string.Empty);
      if (this.Form != null)
        dictionary["form"] = (object) this.Form;
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public WizardStepButtonsTagHelper Buttons { get; set; }

    public string ContentId { get; set; }

    public string ContentUrl { get; set; }

    public string ClassName { get; set; }

    public bool? Enabled { get; set; }

    public string Icon { get; set; }

    public string IconTemplate { get; set; }

    public string IconTemplateId { get; set; }

    public bool? Pager { get; set; }

    public string Title { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Buttons != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Buttons.Select<WizardStepButtonTagHelper, Dictionary<string, object>>((Func<WizardStepButtonTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["buttons"] = (object) source;
      }
      string contentId = this.ContentId;
      if ((contentId != null ? (contentId.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentId"] = (object) this.ContentId;
      string contentUrl = this.ContentUrl;
      if ((contentUrl != null ? (contentUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentUrl"] = (object) this.ContentUrl;
      string className = this.ClassName;
      if ((className != null ? (className.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["className"] = (object) this.ClassName;
      if (this.Enabled.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      string icon = this.Icon;
      if ((icon != null ? (icon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["icon"] = (object) this.Icon;
      if (this.IconTemplateId.HasValue())
        dictionary["iconTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.IconTemplateId)
        };
      else if (this.IconTemplate.HasValue())
        dictionary["iconTemplate"] = (object) this.IconTemplate;
      if (this.Pager.HasValue)
        dictionary["pager"] = (object) this.Pager;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      return dictionary;
    }
  }
}
