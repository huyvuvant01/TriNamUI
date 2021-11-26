// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SplitterTagHelper
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
  [HtmlTargetElement("kendo-splitter")]
  [RestrictChildren("pane", new string[] {})]
  [OutputElementHint("div")]
  public class SplitterTagHelper : TagHelperBase
  {
    public SplitterTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public SplitterOrientation? Orientation { get; set; }

    public List<SplitterPaneTagHelper> Panes { get; set; } = new List<SplitterPaneTagHelper>();

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
      IEnumerable<Dictionary<string, object>> source = this.Panes.Select<SplitterPaneTagHelper, Dictionary<string, object>>((Func<SplitterPaneTagHelper, Dictionary<string, object>>) (i => i.SerializeSettings()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["panes"] = (object) source;
      if (this.Orientation.HasValue)
        dictionary["orientation"] = (object) this.Orientation;
      return this.Initializer.Initialize(this.Selector, "Splitter", (IDictionary<string, object>) dictionary);
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      SplitterTagHelper splitterTagHelper = this;
      if (!context.Items.ContainsKey((object) typeof (SplitterTagHelper)))
        context.Items.Add((object) typeof (SplitterTagHelper), (object) new List<SplitterTagHelper>());
      List<SplitterTagHelper> parents = context.Items[(object) typeof (SplitterTagHelper)] as List<SplitterTagHelper>;
      parents.Add(splitterTagHelper);
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      parents.Remove(splitterTagHelper);
      // ISSUE: reference to a compiler-generated method
      splitterTagHelper.\u003C\u003En__0(context, output);
      parents = (List<SplitterTagHelper>) null;
    }

    public string OnCollapse { get; set; }

    public string OnContentLoad { get; set; }

    public string OnError { get; set; }

    public string OnExpand { get; set; }

    public string OnLayoutChange { get; set; }

    public string OnResize { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onCollapse = this.OnCollapse;
      if ((onCollapse != null ? (onCollapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapse"] = (object) this.CreateHandler(this.OnCollapse);
      string onContentLoad = this.OnContentLoad;
      if ((onContentLoad != null ? (onContentLoad.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentLoad"] = (object) this.CreateHandler(this.OnContentLoad);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      string onExpand = this.OnExpand;
      if ((onExpand != null ? (onExpand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expand"] = (object) this.CreateHandler(this.OnExpand);
      string onLayoutChange = this.OnLayoutChange;
      if ((onLayoutChange != null ? (onLayoutChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["layoutChange"] = (object) this.CreateHandler(this.OnLayoutChange);
      string onResize = this.OnResize;
      if ((onResize != null ? (onResize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["resize"] = (object) this.CreateHandler(this.OnResize);
      return dictionary;
    }

    protected override Dictionary<string, object> SerializeSettings() => base.SerializeSettings();
  }
}
