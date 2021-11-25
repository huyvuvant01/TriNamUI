// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ExpansionPanel
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ExpansionPanel : WidgetBase
  {
    public ExpansionPanel(ViewContext viewContext)
      : base(viewContext)
    {
      this.Content = new HtmlTemplate();
    }

    public HtmlTemplate Content { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      IHtmlNode node = new HtmlElement("div").Attribute("id", this.Id).Attribute("name", this.Name).Attributes<string, object>(this.HtmlAttributes);
      this.Content.Apply(node);
      node.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ExpansionPanel), (IDictionary<string, object>) dictionary));
    }

    public ExpansionPanelAnimationSettings Animation { get; } = new ExpansionPanelAnimationSettings();

    public string CollapseIconClass { get; set; }

    public bool? Disabled { get; set; }

    public bool? Expanded { get; set; }

    public string ExpandIconClass { get; set; }

    public double? Height { get; set; }

    public string SubTitle { get; set; }

    public string Title { get; set; }

    public bool? Toggleable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      Dictionary<string, object> source = this.Animation.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["animation"] = (object) source;
      else if (this.Animation.Enabled.HasValue)
        dictionary["animation"] = (object) this.Animation.Enabled;
      string collapseIconClass = this.CollapseIconClass;
      if ((collapseIconClass != null ? (collapseIconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapseIconClass"] = (object) this.CollapseIconClass;
      bool? nullable = this.Disabled;
      if (nullable.HasValue)
        dictionary["disabled"] = (object) this.Disabled;
      nullable = this.Expanded;
      if (nullable.HasValue)
        dictionary["expanded"] = (object) this.Expanded;
      string expandIconClass = this.ExpandIconClass;
      if ((expandIconClass != null ? (expandIconClass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expandIconClass"] = (object) this.ExpandIconClass;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      string subTitle = this.SubTitle;
      if ((subTitle != null ? (subTitle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["subTitle"] = (object) this.SubTitle;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      nullable = this.Toggleable;
      if (nullable.HasValue)
        dictionary["toggleable"] = (object) this.Toggleable;
      return dictionary;
    }
  }
}
