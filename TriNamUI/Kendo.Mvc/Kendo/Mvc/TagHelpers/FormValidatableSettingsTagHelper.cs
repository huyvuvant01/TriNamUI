﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.FormValidatableSettingsTagHelper
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
  [HtmlTargetElement("validatable", ParentTag = "kendo-form", TagStructure = TagStructure.WithoutEndTag)]
  [HtmlTargetElement("validatable", ParentTag = "wizard-step-form", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class FormValidatableSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (FormTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as FormTagHelper).Validatable = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? ValidateOnBlur { get; set; }

    public bool? ValidationSummary { get; set; }

    public string ErrorTemplate { get; set; }

    public string ErrorTemplateId { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.ValidateOnBlur.HasValue)
        dictionary["validateOnBlur"] = (object) this.ValidateOnBlur;
      if (this.ValidationSummary.HasValue)
        dictionary["validationSummary"] = (object) this.ValidationSummary;
      if (this.ErrorTemplateId.HasValue())
        dictionary["errorTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ErrorTemplateId)
        };
      else if (this.ErrorTemplate.HasValue())
        dictionary["errorTemplate"] = (object) this.ErrorTemplate;
      return dictionary;
    }
  }
}
