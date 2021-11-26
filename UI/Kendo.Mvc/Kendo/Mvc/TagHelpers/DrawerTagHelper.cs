// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DrawerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-drawer")]
  [RestrictChildren("content", new string[] {"mini"})]
  public class DrawerTagHelper : TagHelperBase
  {
    public DrawerTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DrawerTagHelper drawerTagHelper = this;
      context.Items[(object) drawerTagHelper.GetType()] = (object) drawerTagHelper;
      (await output.GetChildContentAsync()).GetContent();
      // ISSUE: reference to a compiler-generated method
      await drawerTagHelper.\u003C\u003En__0(context, output);
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
      if (this.Mini != null)
      {
        Dictionary<string, object> source = this.Mini.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Mini.Enabled.HasValue || this.Mini.Enabled.Value))
          dictionary["mini"] = (object) source;
        else if (this.Mini.Enabled.HasValue && this.Mini.Enabled.Value)
          dictionary["mini"] = (object) this.Mini.Enabled;
      }
      return this.Initializer.Initialize(this.Selector, "Drawer", (IDictionary<string, object>) dictionary);
    }

    public string OnHide { get; set; }

    public string OnShow { get; set; }

    public string OnItemClick { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onHide = this.OnHide;
      if ((onHide != null ? (onHide.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hide"] = (object) this.CreateHandler(this.OnHide);
      string onShow = this.OnShow;
      if ((onShow != null ? (onShow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["show"] = (object) this.CreateHandler(this.OnShow);
      string onItemClick = this.OnItemClick;
      if ((onItemClick != null ? (onItemClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["itemClick"] = (object) this.CreateHandler(this.OnItemClick);
      return dictionary;
    }

    public bool? AutoCollapse { get; set; }

    public string Position { get; set; }

    public string Mode { get; set; }

    public bool? Navigatable { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public double? MinHeight { get; set; }

    [HtmlAttributeNotBound]
    public DrawerMiniSettingsTagHelper Mini { get; set; }

    public bool? SwipeToOpen { get; set; }

    public double? Width { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoCollapse.HasValue)
        dictionary["autoCollapse"] = (object) this.AutoCollapse;
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      string mode = this.Mode;
      if ((mode != null ? (mode.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mode"] = (object) this.Mode;
      if (this.Navigatable.HasValue)
        dictionary["navigatable"] = (object) this.Navigatable;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.MinHeight.HasValue)
        dictionary["minHeight"] = (object) this.MinHeight;
      if (this.Mini != null)
      {
        Dictionary<string, object> source = this.Mini.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Mini.Enabled.HasValue || this.Mini.Enabled.Value))
          dictionary["mini"] = (object) source;
        else if (this.Mini.Enabled.HasValue && !this.Mini.Enabled.Value)
          dictionary["mini"] = (object) this.Mini.Enabled;
      }
      if (this.SwipeToOpen.HasValue)
        dictionary["swipeToOpen"] = (object) this.SwipeToOpen;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
