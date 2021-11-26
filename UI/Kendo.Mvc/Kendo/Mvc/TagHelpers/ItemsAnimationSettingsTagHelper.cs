﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ItemsAnimationSettingsTagHelper
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
  [SuppressTagRendering]
  public class ItemsAnimationSettingsTagHelper : TagHelperChildBase
  {
    public bool? Enabled { get; set; }

    public 
    #nullable disable
    ItemsAnimationCollapseSettingsTagHelper Collapse { get; set; }

    public ItemsAnimationExpandSettingsTagHelper Expand { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ItemsCollectionTagHelperBase);
      foreach (object obj in (IEnumerable<object>) context.Items.Values)
      {
        if (type.IsAssignableFrom(obj.GetType()))
          (context.Items[(object) obj.GetType()] as ItemsCollectionTagHelperBase).Animation = this;
      }
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Collapse != null)
      {
        Dictionary<string, object> source = this.Collapse.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["collapse"] = (object) source;
      }
      if (this.Expand != null)
      {
        Dictionary<string, object> source = this.Expand.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["expand"] = (object) source;
      }
      return dictionary;
    }
  }
}