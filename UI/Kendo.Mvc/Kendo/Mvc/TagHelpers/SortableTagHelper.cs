// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SortableTagHelper
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
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-sortable")]
  [RestrictChildren("cursor-offset", new string[] {})]
  public class SortableTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    string Placeholder { get; set; }

    public string Hint { get; set; }

    public SortableTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      SortableTagHelper sortableTagHelper = this;
      context.Items[(object) sortableTagHelper.GetType()] = (object) sortableTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await sortableTagHelper.\u003C\u003En__0(context, output);
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
      string hint = this.Hint;
      if ((hint != null ? (hint.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hint"] = (object) this.CreateHandler(this.Hint);
      string placeholder = this.Placeholder;
      if ((placeholder != null ? (placeholder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["placeholder"] = (object) this.CreateHandler(this.Placeholder);
      return this.Initializer.Initialize(this.Selector, "Sortable", (IDictionary<string, object>) dictionary);
    }

    public string OnStart { get; set; }

    public string OnMove { get; set; }

    public string OnEnd { get; set; }

    public string OnChange { get; set; }

    public string OnCancel { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onStart = this.OnStart;
      if ((onStart != null ? (onStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["start"] = (object) this.CreateHandler(this.OnStart);
      string onMove = this.OnMove;
      if ((onMove != null ? (onMove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["move"] = (object) this.CreateHandler(this.OnMove);
      string onEnd = this.OnEnd;
      if ((onEnd != null ? (onEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["end"] = (object) this.CreateHandler(this.OnEnd);
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onCancel = this.OnCancel;
      if ((onCancel != null ? (onCancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.CreateHandler(this.OnCancel);
      return dictionary;
    }

    public SortableAxis? Axis { get; set; }

    public bool? AutoScroll { get; set; }

    public string Container { get; set; }

    public string ConnectWith { get; set; }

    public string Cursor { get; set; }

    [HtmlAttributeNotBound]
    public SortableCursorOffsetSettingsTagHelper CursorOffset { get; set; }

    public string Disabled { get; set; }

    public string Filter { get; set; }

    public string Handler { get; set; }

    public bool? HoldToDrag { get; set; }

    public string Ignore { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Axis.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        SortableAxis? axis = this.Axis;
        ref SortableAxis? local = ref axis;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["axis"] = (object) str;
      }
      if (this.AutoScroll.HasValue)
        dictionary1["autoScroll"] = (object) this.AutoScroll;
      string container = this.Container;
      if ((container != null ? (container.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["container"] = (object) this.Container;
      string connectWith = this.ConnectWith;
      if ((connectWith != null ? (connectWith.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["connectWith"] = (object) this.ConnectWith;
      string cursor = this.Cursor;
      if ((cursor != null ? (cursor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["cursor"] = (object) this.Cursor;
      if (this.CursorOffset != null)
      {
        Dictionary<string, object> source = this.CursorOffset.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["cursorOffset"] = (object) source;
      }
      string disabled = this.Disabled;
      if ((disabled != null ? (disabled.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["disabled"] = (object) this.Disabled;
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["filter"] = (object) this.Filter;
      string handler = this.Handler;
      if ((handler != null ? (handler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["handler"] = (object) this.Handler;
      if (this.HoldToDrag.HasValue)
        dictionary1["holdToDrag"] = (object) this.HoldToDrag;
      string ignore = this.Ignore;
      if ((ignore != null ? (ignore.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["ignore"] = (object) this.Ignore;
      return dictionary1;
    }
  }
}
