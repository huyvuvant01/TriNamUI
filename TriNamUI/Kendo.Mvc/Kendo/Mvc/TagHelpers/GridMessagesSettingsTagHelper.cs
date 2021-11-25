// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridMessagesSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("messages", ParentTag = "kendo-grid", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("commands", new string[] {})]
  [SuppressTagRendering]
  public class GridMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public GridMessagesCommandsSettingsTagHelper Commands { get; set; }

    public string NoRecords { get; set; }

    public string ExpandCollapseColumnHeader { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Commands != null)
      {
        Dictionary<string, object> source = this.Commands.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["commands"] = (object) source;
      }
      string noRecords = this.NoRecords;
      if ((noRecords != null ? (noRecords.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["noRecords"] = (object) this.NoRecords;
      string collapseColumnHeader = this.ExpandCollapseColumnHeader;
      if ((collapseColumnHeader != null ? (collapseColumnHeader.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expandCollapseColumnHeader"] = (object) this.ExpandCollapseColumnHeader;
      return dictionary;
    }
  }
}
