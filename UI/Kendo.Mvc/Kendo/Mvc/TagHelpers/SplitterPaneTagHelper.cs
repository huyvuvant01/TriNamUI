// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SplitterPaneTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("pane", ParentTag = "kendo-splitter")]
  [OutputElementHint("div")]
  public class SplitterPaneTagHelper : TagHelper
  {
    public SplitterPaneTagHelper() => this.TagName = "div";

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      output.TagName = !string.IsNullOrEmpty(this.TagName) ? this.TagName : (string) null;
      List<SplitterTagHelper> splitterTagHelperList = context.Items[(object) typeof (SplitterTagHelper)] as List<SplitterTagHelper>;
      if (splitterTagHelperList.Count <= 0)
        return;
      splitterTagHelperList[splitterTagHelperList.Count - 1].Panes.Add(this);
    }

    public string TagName { get; set; }

    public bool? Collapsed { get; set; }

    public string CollapsedSize { get; set; }

    public bool? Collapsible { get; set; }

    public bool? Resizable { get; set; }

    public bool? Scrollable { get; set; }

    public string Size { get; set; }

    public string MaxSize { get; set; }

    public string MinSize { get; set; }

    public string ContentUrl { get; set; }

    public string Label { get; set; }

    public string LabelId { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Collapsed.HasValue)
        dictionary["collapsed"] = (object) this.Collapsed;
      string collapsedSize = this.CollapsedSize;
      if ((collapsedSize != null ? (collapsedSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapsedSize"] = (object) this.CollapsedSize;
      if (this.Collapsible.HasValue)
        dictionary["collapsible"] = (object) this.Collapsible;
      if (this.Resizable.HasValue)
        dictionary["resizable"] = (object) this.Resizable;
      if (this.Scrollable.HasValue)
        dictionary["scrollable"] = (object) this.Scrollable;
      string size = this.Size;
      if ((size != null ? (size.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["size"] = (object) this.Size;
      string maxSize = this.MaxSize;
      if ((maxSize != null ? (maxSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["max"] = (object) this.MaxSize;
      string minSize = this.MinSize;
      if ((minSize != null ? (minSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["min"] = (object) this.MinSize;
      string contentUrl = this.ContentUrl;
      if ((contentUrl != null ? (contentUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contentUrl"] = (object) this.ContentUrl;
      string label = this.Label;
      if ((label != null ? (label.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["label"] = (object) this.Label;
      string labelId = this.LabelId;
      if ((labelId != null ? (labelId.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["labelId"] = (object) this.LabelId;
      return dictionary;
    }
  }
}
