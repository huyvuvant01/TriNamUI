// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridFilterableSettingsTagHelper
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
  [HtmlTargetElement("filterable", ParentTag = "kendo-grid", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("messages", new string[] {"operators"})]
  [SuppressTagRendering]
  public class GridFilterableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).Filterable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public bool? Extra { get; set; }

    public GridFilterableMessagesSettingsTagHelper Messages { get; set; }

    public string Mode { get; set; }

    public GridFilterableOperatorsSettingsTagHelper Operators { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Extra.HasValue)
        dictionary["extra"] = (object) this.Extra;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      string mode = this.Mode;
      if ((mode != null ? (mode.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mode"] = (object) this.Mode;
      if (this.Operators != null)
      {
        Dictionary<string, object> source = this.Operators.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["operators"] = (object) source;
      }
      return dictionary;
    }
  }
}
