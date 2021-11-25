// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.NotificationTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-notification")]
  [RestrictChildren("position", new string[] {"templates", "popup-animation"})]
  [OutputElementHint("div")]
  public class NotificationTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    NotificationPopupAnimationSettingsTagHelper Animation { get; set; }

    public NotificationTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      NotificationTagHelper notificationTagHelper = this;
      context.Items[(object) notificationTagHelper.GetType()] = (object) notificationTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await notificationTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Animation.Enabled.HasValue || this.Animation.Enabled.Value))
          dictionary["animation"] = (object) source;
        else if (this.Animation.Enabled.HasValue && !this.Animation.Enabled.Value)
          dictionary["animation"] = (object) this.Animation.Enabled;
      }
      return this.Initializer.Initialize(this.Selector, "Notification", (IDictionary<string, object>) dictionary);
    }

    public string OnHide { get; set; }

    public string OnShow { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onHide = this.OnHide;
      if ((onHide != null ? (onHide.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hide"] = (object) this.CreateHandler(this.OnHide);
      string onShow = this.OnShow;
      if ((onShow != null ? (onShow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["show"] = (object) this.CreateHandler(this.OnShow);
      return dictionary;
    }

    public double? AllowHideAfter { get; set; }

    public string AppendTo { get; set; }

    public double? AutoHideAfter { get; set; }

    public bool? Button { get; set; }

    public double? Height { get; set; }

    public bool? HideOnClick { get; set; }

    [HtmlAttributeNotBound]
    public NotificationPositionSettingsTagHelper Position { get; set; }

    [HtmlAttributeNotBound]
    public NotificationTemplatesTagHelper Templates { get; set; }

    public string Title { get; set; }

    public double? Width { get; set; }

    public NotificationStackingSettings? Stacking { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AllowHideAfter.HasValue)
        dictionary1["allowHideAfter"] = (object) this.AllowHideAfter;
      string appendTo = this.AppendTo;
      if ((appendTo != null ? (appendTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["appendTo"] = (object) this.AppendTo;
      if (this.AutoHideAfter.HasValue)
        dictionary1["autoHideAfter"] = (object) this.AutoHideAfter;
      if (this.Button.HasValue)
        dictionary1["button"] = (object) this.Button;
      if (this.Height.HasValue)
        dictionary1["height"] = (object) this.Height;
      if (this.HideOnClick.HasValue)
        dictionary1["hideOnClick"] = (object) this.HideOnClick;
      if (this.Position != null)
      {
        Dictionary<string, object> source = this.Position.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["position"] = (object) source;
      }
      if (this.Templates != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Templates.Select<NotificationTemplateTagHelper, Dictionary<string, object>>((Func<NotificationTemplateTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["templates"] = (object) source;
      }
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["title"] = (object) this.Title;
      if (this.Width.HasValue)
        dictionary1["width"] = (object) this.Width;
      if (this.Stacking.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        NotificationStackingSettings? stacking = this.Stacking;
        ref NotificationStackingSettings? local = ref stacking;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["stacking"] = (object) str;
      }
      return dictionary1;
    }
  }
}
