﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PopoverAnimationSettingsTagHelper
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
  [HtmlTargetElement("animation", ParentTag = "kendo-popover", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("close", new string[] {"open"})]
  [SuppressTagRendering]
  public class PopoverAnimationSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PopoverTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PopoverTagHelper).Animation = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    [HtmlAttributeNotBound]
    public PopoverAnimationCloseSettingsTagHelper Close { get; set; }

    [HtmlAttributeNotBound]
    public PopoverAnimationOpenSettingsTagHelper Open { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Close != null)
      {
        Dictionary<string, object> source = this.Close.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["close"] = (object) source;
      }
      if (this.Open != null)
      {
        Dictionary<string, object> source = this.Open.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["open"] = (object) source;
      }
      return dictionary;
    }
  }
}