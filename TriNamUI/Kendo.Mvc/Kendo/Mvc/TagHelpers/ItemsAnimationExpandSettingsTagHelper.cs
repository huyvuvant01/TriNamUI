// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ItemsAnimationExpandSettingsTagHelper
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
  [HtmlTargetElement("expand", ParentTag = "animation", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ItemsAnimationExpandSettingsTagHelper : TagHelperChildBase
  {
    public double? Duration { get; set; }

    public 
    #nullable disable
    string Effects { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ItemsAnimationSettingsTagHelper);
      foreach (object obj in (IEnumerable<object>) context.Items.Values)
      {
        if (type.IsAssignableFrom(obj.GetType()))
          (context.Items[(object) obj.GetType()] as ItemsAnimationSettingsTagHelper).Expand = this;
      }
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Duration.HasValue)
        dictionary["duration"] = (object) this.Duration;
      string effects = this.Effects;
      if ((effects != null ? (effects.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["effects"] = (object) this.Effects;
      return dictionary;
    }
  }
}
