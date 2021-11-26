// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartXAxisNotesIconSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("chart-x-axis-notes-icon", ParentTag = "notes", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {})]
  [SuppressTagRendering]
  public class ChartXAxisNotesIconSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (ChartXAxisNotesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartXAxisNotesSettingsTagHelper).Icon = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    [HtmlAttributeNotBound]
    public ChartXAxisNotesIconBorderSettingsTagHelper Border { get; set; }

    public double? Size { get; set; }

    public string Type { get; set; }

    public bool? Visible { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["border"] = (object) source;
      }
      if (this.Size.HasValue)
        dictionary["size"] = (object) this.Size;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
