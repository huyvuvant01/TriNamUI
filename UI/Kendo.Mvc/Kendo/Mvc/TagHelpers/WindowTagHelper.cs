// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.WindowTagHelper
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
  [HtmlTargetElement("kendo-window")]
  [RestrictChildren("popup-animation", new string[] {"content", "window-title", "draggable", "modal"})]
  [OutputElementHint("div")]
  public class WindowTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    WindowPopupAnimationSettingsTagHelper Animation { get; set; }

    [HtmlAttributeNotBound]
    public WindowTitleSettingsTagHelper TitleSettings { get; set; }

    public string Title { get; set; }

    public bool Draggable { get; set; }

    [HtmlAttributeNotBound]
    public WindowDraggableSettingsTagHelper DraggableSettings { get; set; }

    public bool Modal { get; set; }

    [HtmlAttributeNotBound]
    public WindowModalSettingsTagHelper ModalSettings { get; set; }

    public string ContentUrl { get; set; }

    public string[] Actions { get; set; }

    public string PositionTop { get; set; }

    public string PositionLeft { get; set; }

    public string Height { get; set; }

    public string MaxHeight { get; set; }

    public string MaxWidth { get; set; }

    public string MinHeight { get; set; }

    public string MinWidth { get; set; }

    public string Width { get; set; }

    public WindowTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      WindowTagHelper windowTagHelper = this;
      context.Items[(object) windowTagHelper.GetType()] = (object) windowTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await windowTagHelper.\u003C\u003En__0(context, output);
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
      if (!this.Draggable)
        dictionary["draggable"] = (object) this.Draggable;
      else if (this.DraggableSettings != null)
      {
        Dictionary<string, object> source = this.DraggableSettings.Serialize();
        if (this.DraggableSettings.Enabled.HasValue && !this.DraggableSettings.Enabled.Value)
          dictionary["draggable"] = (object) this.DraggableSettings.Enabled;
        else if (source.Any<KeyValuePair<string, object>>())
          dictionary["draggable"] = (object) source;
      }
      if (this.Title != null)
        dictionary["title"] = (object) this.Title;
      else if (this.TitleSettings != null)
      {
        Dictionary<string, object> source = this.TitleSettings.SerializeSettings();
        if (this.TitleSettings.Enabled.HasValue && !this.TitleSettings.Enabled.Value)
          dictionary["title"] = (object) this.TitleSettings.Enabled.Value;
        else if (source.Any<KeyValuePair<string, object>>())
          dictionary["title"] = (object) source;
      }
      if (this.ContentUrl.HasValue())
        dictionary["content"] = (object) this.ContentUrl;
      if (this.PositionTop.HasValue() && this.PositionLeft.HasValue())
        dictionary["position"] = (object) new Dictionary<string, object>()
        {
          {
            "top",
            (object) this.PositionTop
          },
          {
            "left",
            (object) this.PositionLeft
          }
        };
      else if (this.PositionTop.HasValue())
        dictionary["position"] = (object) new Dictionary<string, object>()
        {
          {
            "top",
            (object) this.PositionTop
          }
        };
      else if (this.PositionLeft.HasValue())
        dictionary["position"] = (object) new Dictionary<string, object>()
        {
          {
            "left",
            (object) this.PositionLeft
          }
        };
      if (this.Actions != null && this.Actions.Length != 0)
        dictionary["actions"] = (object) this.Actions;
      if (this.Modal)
        dictionary["modal"] = (object) true;
      else if (this.ModalSettings != null)
      {
        Dictionary<string, object> source = this.ModalSettings.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.ModalSettings.Enabled.HasValue || this.ModalSettings.Enabled.Value))
          dictionary["modal"] = (object) source;
        else if (this.ModalSettings.Enabled.HasValue && this.ModalSettings.Enabled.Value)
          dictionary["modal"] = (object) this.ModalSettings.Enabled.Value;
      }
      if (this.Height.HasValue())
        dictionary["height"] = (object) this.Height;
      if (this.MaxHeight.HasValue())
        dictionary["maxHeight"] = (object) this.MaxHeight;
      if (this.MaxWidth.HasValue())
        dictionary["maxWidth"] = (object) this.MaxWidth;
      if (this.MinHeight.HasValue())
        dictionary["minHeight"] = (object) this.MinHeight;
      if (this.MinWidth.HasValue())
        dictionary["minWidth"] = (object) this.MinWidth;
      if (this.Width.HasValue())
        dictionary["width"] = (object) this.Width;
      return this.Initializer.Initialize(this.Selector, "Window", (IDictionary<string, object>) dictionary);
    }

    public string OnActivate { get; set; }

    public string OnClose { get; set; }

    public string OnDeactivate { get; set; }

    public string OnDragend { get; set; }

    public string OnDragstart { get; set; }

    public string OnError { get; set; }

    public string OnMaximize { get; set; }

    public string OnMinimize { get; set; }

    public string OnOpen { get; set; }

    public string OnRefresh { get; set; }

    public string OnResize { get; set; }

    public string OnRestore { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onActivate = this.OnActivate;
      if ((onActivate != null ? (onActivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["activate"] = (object) this.CreateHandler(this.OnActivate);
      string onClose = this.OnClose;
      if ((onClose != null ? (onClose.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["close"] = (object) this.CreateHandler(this.OnClose);
      string onDeactivate = this.OnDeactivate;
      if ((onDeactivate != null ? (onDeactivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deactivate"] = (object) this.CreateHandler(this.OnDeactivate);
      string onDragend = this.OnDragend;
      if ((onDragend != null ? (onDragend.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragend"] = (object) this.CreateHandler(this.OnDragend);
      string onDragstart = this.OnDragstart;
      if ((onDragstart != null ? (onDragstart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragstart"] = (object) this.CreateHandler(this.OnDragstart);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      string onMaximize = this.OnMaximize;
      if ((onMaximize != null ? (onMaximize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["maximize"] = (object) this.CreateHandler(this.OnMaximize);
      string onMinimize = this.OnMinimize;
      if ((onMinimize != null ? (onMinimize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["minimize"] = (object) this.CreateHandler(this.OnMinimize);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      string onRefresh = this.OnRefresh;
      if ((onRefresh != null ? (onRefresh.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["refresh"] = (object) this.CreateHandler(this.OnRefresh);
      string onResize = this.OnResize;
      if ((onResize != null ? (onResize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resize"] = (object) this.CreateHandler(this.OnResize);
      string onRestore = this.OnRestore;
      if ((onRestore != null ? (onRestore.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["restore"] = (object) this.CreateHandler(this.OnRestore);
      return dictionary;
    }

    public bool? AutoFocus { get; set; }

    public bool? Iframe { get; set; }

    public bool? Pinned { get; set; }

    public bool? Scrollable { get; set; }

    public bool? Visible { get; set; }

    public string Size { get; set; }

    public bool? Resizable { get; set; }

    public string AppendTo { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoFocus.HasValue)
        dictionary["autoFocus"] = (object) this.AutoFocus;
      if (this.Iframe.HasValue)
        dictionary["iframe"] = (object) this.Iframe;
      if (this.Pinned.HasValue)
        dictionary["pinned"] = (object) this.Pinned;
      if (this.Scrollable.HasValue)
        dictionary["scrollable"] = (object) this.Scrollable;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      string size = this.Size;
      if ((size != null ? (size.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["size"] = (object) this.Size;
      if (this.Resizable.HasValue)
        dictionary["resizable"] = (object) this.Resizable;
      string appendTo = this.AppendTo;
      if ((appendTo != null ? (appendTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["appendTo"] = (object) this.AppendTo;
      return dictionary;
    }
  }
}
