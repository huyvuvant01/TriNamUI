// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PopoverTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-popover")]
  [RestrictChildren("actions", new string[] {"animation"})]
  public class PopoverTagHelper : TagHelperBase
  {
    private 
    #nullable disable
    string container;

    public PopoverTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public string For
    {
      get => this.Id;
      set => this.Id = this.container = value;
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PopoverTagHelper popoverTagHelper = this;
      context.Items[(object) popoverTagHelper.GetType()] = (object) popoverTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await popoverTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output) => output.TagName = (string) null;

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filter"] = (object) this.Filter;
      return this.Initializer.InitializeFor(this.container, "Popover", (IDictionary<string, object>) dictionary);
    }

    public string OnShow { get; set; }

    public string OnHide { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onShow = this.OnShow;
      if ((onShow != null ? (onShow.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["show"] = (object) this.CreateHandler(this.OnShow);
      string onHide = this.OnHide;
      if ((onHide != null ? (onHide.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hide"] = (object) this.CreateHandler(this.OnHide);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public PopoverActionsTagHelper Actions { get; set; }

    public string ActionsLayout { get; set; }

    [HtmlAttributeNotBound]
    public PopoverAnimationSettingsTagHelper Animation { get; set; }

    public string Body { get; set; }

    public string BodyHandler { get; set; }

    public string Filter { get; set; }

    public string Header { get; set; }

    public string HeaderHandler { get; set; }

    public double? Height { get; set; }

    public bool? ToggleOnClick { get; set; }

    public double? Width { get; set; }

    public string Position { get; set; }

    public string ShowOn { get; set; }

    public double? Offset { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Actions != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Actions.Select<PopoverActionTagHelper, Dictionary<string, object>>((Func<PopoverActionTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["actions"] = (object) source;
      }
      string actionsLayout = this.ActionsLayout;
      if ((actionsLayout != null ? (actionsLayout.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["actionsLayout"] = (object) this.ActionsLayout;
      if (this.Animation != null)
      {
        Dictionary<string, object> source = this.Animation.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Animation.Enabled.HasValue || this.Animation.Enabled.Value))
          dictionary["animation"] = (object) source;
        else if (this.Animation.Enabled.HasValue && !this.Animation.Enabled.Value)
          dictionary["animation"] = (object) this.Animation.Enabled;
      }
      string bodyHandler = this.BodyHandler;
      if ((bodyHandler != null ? (bodyHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["body"] = (object) this.CreateHandler(this.BodyHandler);
      }
      else
      {
        string body = this.Body;
        if ((body != null ? (body.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["body"] = (object) this.Body;
      }
      string headerHandler = this.HeaderHandler;
      if ((headerHandler != null ? (headerHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["header"] = (object) this.CreateHandler(this.HeaderHandler);
      }
      else
      {
        string header = this.Header;
        if ((header != null ? (header.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["header"] = (object) this.Header;
      }
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      if (this.ToggleOnClick.HasValue)
        dictionary["toggleOnClick"] = (object) this.ToggleOnClick;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      string position = this.Position;
      if ((position != null ? (position.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["position"] = (object) this.Position;
      string showOn = this.ShowOn;
      if ((showOn != null ? (showOn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showOn"] = (object) this.ShowOn;
      if (this.Offset.HasValue)
        dictionary["offset"] = (object) this.Offset;
      return dictionary;
    }
  }
}
