﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ScrollViewPageableSettingsTagHelper
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
  [HtmlTargetElement("pageable", ParentTag = "kendo-scrollview", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ScrollViewPageableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ScrollViewTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ScrollViewTagHelper).Pageable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public string ARIATemplate { get; set; }

    public string ARIATemplateId { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.ARIATemplateId.HasValue())
        dictionary["ARIATemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ARIATemplateId)
        };
      else if (this.ARIATemplate.HasValue())
        dictionary["ARIATemplate"] = (object) this.ARIATemplate;
      return dictionary;
    }
  }
}