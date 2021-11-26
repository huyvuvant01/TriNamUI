// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Window
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Window : WidgetBase
  {
    private readonly IList<IWindowButton> defaultButtons = (IList<IWindowButton>) new HeaderButton[1]
    {
      new HeaderButton()
      {
        Name = "Close",
        CssClass = "k-i-close"
      }
    };
    private string loadContentFromUrl;

    public Window(ViewContext viewContext)
      : base(viewContext)
    {
      this.defaultButtons.Each<IWindowButton>((Action<IWindowButton>) (button => this.Actions.Container.Add(button)));
      this.ContentHtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.Scrollable = new bool?(true);
      this.Modal = false;
    }

    public string AppendTo { get; set; }

    public object Title { get; set; }

    public WindowTitleSettings TitleSettings { get; } = new WindowTitleSettings();

    public bool Draggable { get; set; }

    public WindowDraggableSettings DraggableSettings { get; } = new WindowDraggableSettings();

    public bool Modal { get; set; }

    public WindowModalSettings ModalSettings { get; } = new WindowModalSettings();

    public string Height { get; set; }

    public string MaxHeight { get; set; }

    public string MaxWidth { get; set; }

    public string MinHeight { get; set; }

    public string MinWidth { get; set; }

    public string Width { get; set; }

    public WindowPositionSettings Position { get; } = new WindowPositionSettings();

    public string ContentUrl
    {
      get => this.loadContentFromUrl;
      set
      {
        this.loadContentFromUrl = value;
        this.ContentHtmlAttributes.Clear();
        this.Content = (Func<object, object>) null;
      }
    }

    public string Html { get; set; }

    public Func<object, object> Content { get; set; }

    public Action ContentAction { get; set; }

    public IDictionary<string, object> ContentHtmlAttributes { get; private set; }

    public WindowButtons Actions { get; } = new WindowButtons();

    public PopupAnimation Animation { get; } = new PopupAnimation();

    public WindowResizingSettings ResizingSettings { get; } = new WindowResizingSettings();

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
      if (!this.Visible.GetValueOrDefault(true))
        tag.MergeAttribute("style", "display:none");
      tag.TagRenderMode = TagRenderMode.StartTag;
      tag.WriteTo(writer, this.HtmlEncoder);
      if (this.Html.HasValue())
        writer.Write(this.Html);
      else if (this.Content != null)
        writer.WriteContent<object>(this.Content, this.HtmlEncoder);
      else if (this.ContentAction != null)
        this.ContentAction();
      tag.TagRenderMode = TagRenderMode.EndTag;
      tag.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (Window), (IDictionary<string, object>) this.Serialize()));

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      IDictionary<string, object> json1 = this.Animation.ToJson();
      if (json1.Any<KeyValuePair<string, object>>())
        dictionary["animation"] = !(json1["animation"] is bool) ? json1["animation"] : (object) false;
      dictionary.Add("content", (object) this.ContentUrl);
      if (!this.Draggable)
        dictionary["draggable"] = (object) this.Draggable;
      Dictionary<string, object> source1 = this.DraggableSettings.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["draggable"] = (object) source1;
      else if (this.DraggableSettings.Enabled.HasValue)
        dictionary["draggable"] = (object) this.DraggableSettings.Enabled;
      if (!string.IsNullOrEmpty(this.AppendTo))
        dictionary.Add("appendTo", (object) this.AppendTo);
      dictionary.Add("actions", (object) this.Actions.Container.Select<IWindowButton, string>((Func<IWindowButton, string>) (item => item.Name)));
      if (this.ResizingSettings.Enabled)
      {
        if (!string.IsNullOrEmpty(this.ResizingSettings.MinHeight))
          dictionary.Add("minHeight", (object) this.ResizingSettings.MinHeight);
        if (!string.IsNullOrEmpty(this.ResizingSettings.MinWidth))
          dictionary.Add("minWidth", (object) this.ResizingSettings.MinWidth);
        if (!string.IsNullOrEmpty(this.ResizingSettings.MaxHeight))
          dictionary.Add("maxHeight", (object) this.ResizingSettings.MaxHeight);
        if (!string.IsNullOrEmpty(this.ResizingSettings.MaxWidth))
          dictionary.Add("maxWidth", (object) this.ResizingSettings.MaxWidth);
      }
      else
        dictionary.Add("resizable", (object) this.ResizingSettings.Enabled);
      IDictionary<string, object> json2 = this.TitleSettings.ToJson();
      if (this.Title != null)
        dictionary["title"] = this.Title;
      else if (json2.Any<KeyValuePair<string, object>>())
        dictionary["title"] = (object) json2;
      if (this.Modal)
        dictionary["modal"] = (object) this.Modal;
      else if (this.ModalSettings != null)
      {
        Dictionary<string, object> source2 = this.ModalSettings.Serialize();
        if (source2.Any<KeyValuePair<string, object>>())
          dictionary["modal"] = (object) source2;
      }
      if (!string.IsNullOrEmpty(this.Height))
        dictionary["height"] = (object) this.Height;
      if (!string.IsNullOrEmpty(this.MaxHeight))
        dictionary["maxHeight"] = (object) this.MaxHeight;
      if (!string.IsNullOrEmpty(this.MaxWidth))
        dictionary["maxWidth"] = (object) this.MaxWidth;
      if (!string.IsNullOrEmpty(this.MinHeight))
        dictionary["minHeight"] = (object) this.MinHeight;
      if (!string.IsNullOrEmpty(this.MinWidth))
        dictionary["minWidth"] = (object) this.MinWidth;
      if (!string.IsNullOrEmpty(this.Width))
        dictionary["width"] = (object) this.Width;
      Dictionary<string, object> source3 = this.Position.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["position"] = (object) source3;
      return dictionary;
    }

    public bool? AutoFocus { get; set; }

    public bool? Iframe { get; set; }

    public bool? Pinned { get; set; }

    public bool? Scrollable { get; set; }

    public bool? Visible { get; set; }

    public string Size { get; set; }

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
      return dictionary;
    }
  }
}
