// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DraggableTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("body", Attributes = "kendo-draggable")]
  [HtmlTargetElement("div", Attributes = "kendo-draggable")]
  [HtmlTargetElement("form", Attributes = "kendo-draggable")]
  [HtmlTargetElement("ul", Attributes = "kendo-draggable")]
  [HtmlTargetElement("ol", Attributes = "kendo-draggable")]
  [HtmlTargetElement("p", Attributes = "kendo-draggable")]
  [HtmlTargetElement("a", Attributes = "kendo-draggable")]
  [HtmlTargetElement("table", Attributes = "kendo-draggable")]
  [HtmlTargetElement("nav", Attributes = "kendo-draggable")]
  public class DraggableTagHelper : TagHelperBase
  {
    public DraggableTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    [HtmlAttributeName("kendo-draggable")]
    public bool? IsEnabled { get; set; }

    [HtmlAttributeName("kendo-container")]
    public string Container { get; set; }

    [HtmlAttributeName("kendo-hint")]
    public string Hint { get; set; }

    [HtmlAttributeName("kendo-cursor-offset-top")]
    public double? CursorOffsetTop { get; set; }

    [HtmlAttributeName("kendo-cursor-offset-left")]
    public double? CursorOffsetLeft { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DraggableTagHelper draggableTagHelper = this;
      if (draggableTagHelper.IsEnabled.HasValue && !draggableTagHelper.IsEnabled.Value)
        return;
      context.Items[(object) draggableTagHelper.GetType()] = (object) draggableTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await draggableTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.MergeAttributes(tag);
      if (!(output.TagName == "kendo-draggable"))
        return;
      output.TagName = (string) null;
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string container = this.Container;
      if ((container != null ? (container.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["container"] = (object) this.Container;
      string hint = this.Hint;
      if ((hint != null ? (hint.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hint"] = (object) this.CreateHandler(this.Hint);
      double? nullable = this.CursorOffsetTop;
      if (nullable.HasValue)
      {
        nullable = this.CursorOffsetLeft;
        if (nullable.HasValue)
        {
          dictionary["cursorOffset"] = (object) new Dictionary<string, object>()
          {
            {
              "top",
              (object) this.CursorOffsetTop
            },
            {
              "left",
              (object) this.CursorOffsetLeft
            }
          };
          goto label_11;
        }
      }
      nullable = this.CursorOffsetTop;
      if (nullable.HasValue)
      {
        dictionary["cursorOffset"] = (object) new Dictionary<string, object>()
        {
          {
            "top",
            (object) this.CursorOffsetTop
          }
        };
      }
      else
      {
        nullable = this.CursorOffsetLeft;
        if (nullable.HasValue)
          dictionary["cursorOffset"] = (object) new Dictionary<string, object>()
          {
            {
              "left",
              (object) this.CursorOffsetLeft
            }
          };
      }
label_11:
      return this.Initializer.Initialize(this.Selector, "Draggable", (IDictionary<string, object>) dictionary);
    }

    [HtmlAttributeName("on-kendo-drag")]
    public string OnDrag { get; set; }

    [HtmlAttributeName("on-kendo-dragcancel")]
    public string OnDragcancel { get; set; }

    [HtmlAttributeName("on-kendo-dragend")]
    public string OnDragend { get; set; }

    [HtmlAttributeName("on-kendo-dragstart")]
    public string OnDragstart { get; set; }

    [HtmlAttributeName("on-kendo-hold")]
    public string OnHold { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onDrag = this.OnDrag;
      if ((onDrag != null ? (onDrag.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["drag"] = (object) this.CreateHandler(this.OnDrag);
      string onDragcancel = this.OnDragcancel;
      if ((onDragcancel != null ? (onDragcancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragcancel"] = (object) this.CreateHandler(this.OnDragcancel);
      string onDragend = this.OnDragend;
      if ((onDragend != null ? (onDragend.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragend"] = (object) this.CreateHandler(this.OnDragend);
      string onDragstart = this.OnDragstart;
      if ((onDragstart != null ? (onDragstart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragstart"] = (object) this.CreateHandler(this.OnDragstart);
      string onHold = this.OnHold;
      if ((onHold != null ? (onHold.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hold"] = (object) this.CreateHandler(this.OnHold);
      return dictionary;
    }

    [HtmlAttributeName("kendo-auto-scroll")]
    public bool? AutoScroll { get; set; }

    [HtmlAttributeName("kendo-distance")]
    public double? Distance { get; set; }

    [HtmlAttributeName("kendo-group")]
    public string Group { get; set; }

    [HtmlAttributeName("kendo-hold-to-drag")]
    public bool? HoldToDrag { get; set; }

    [HtmlAttributeName("kendo-axis")]
    public DraggableAxis? Axis { get; set; }

    [HtmlAttributeName("kendo-filter")]
    public string Filter { get; set; }

    [HtmlAttributeName("kendo-ignore")]
    public string Ignore { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoScroll.HasValue)
        dictionary1["autoScroll"] = (object) this.AutoScroll;
      if (this.Distance.HasValue)
        dictionary1["distance"] = (object) this.Distance;
      string group = this.Group;
      if ((group != null ? (group.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["group"] = (object) this.Group;
      if (this.HoldToDrag.HasValue)
        dictionary1["holdToDrag"] = (object) this.HoldToDrag;
      if (this.Axis.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        DraggableAxis? axis = this.Axis;
        ref DraggableAxis? local = ref axis;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["axis"] = (object) str;
      }
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["filter"] = (object) this.Filter;
      string ignore = this.Ignore;
      if ((ignore != null ? (ignore.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["ignore"] = (object) this.Ignore;
      return dictionary1;
    }
  }
}
