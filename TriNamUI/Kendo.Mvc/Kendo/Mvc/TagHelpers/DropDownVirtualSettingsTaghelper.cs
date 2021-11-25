// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropDownVirtualSettingsTaghelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [SuppressTagRendering]
  public class DropDownVirtualSettingsTaghelper : TagHelperChildBase
  {
    public bool? Enabled { get; set; }

    public double? ItemHeight { get; set; }

    public 
    #nullable disable
    string MapValueTo { get; set; }

    public string ValueMapper { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DropDownBaseTagHelper);
      foreach (object obj in (IEnumerable<object>) context.Items.Values)
      {
        if (type.IsAssignableFrom(obj.GetType()))
          (context.Items[(object) obj.GetType()] as DropDownBaseTagHelper).Virtual = this;
      }
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.ItemHeight.HasValue)
        dictionary["itemHeight"] = (object) this.ItemHeight;
      string mapValueTo = this.MapValueTo;
      if ((mapValueTo != null ? (mapValueTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mapValueTo"] = (object) this.MapValueTo;
      string valueMapper = this.ValueMapper;
      if ((valueMapper != null ? (valueMapper.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["valueMapper"] = (object) this.CreateHandler(this.ValueMapper);
      return dictionary;
    }
  }
}
