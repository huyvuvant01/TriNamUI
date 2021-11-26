// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridGroupableSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("groupable", ParentTag = "kendo-grid", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("messages", new string[] {"sort"})]
  [SuppressTagRendering]
  public class GridGroupableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).Groupable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public bool? ShowFooter { get; set; }

    [HtmlAttributeNotBound]
    public GridGroupableSortSettingsTagHelper Sort { get; set; }

    [HtmlAttributeNotBound]
    public GridGroupableMessagesSettingsTagHelper Messages { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Enabled.HasValue)
        dictionary["enabled"] = (object) this.Enabled;
      if (this.ShowFooter.HasValue)
        dictionary["showFooter"] = (object) this.ShowFooter;
      if (this.Sort != null)
      {
        Dictionary<string, object> source = this.Sort.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["sort"] = (object) source;
      }
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      return dictionary;
    }
  }
}
