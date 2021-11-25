// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.EditorImmutablesSettingsTagHelper
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
  [HtmlTargetElement("immutables", ParentTag = "kendo-editor", TagStructure = TagStructure.WithoutEndTag)]
  [HtmlTargetElement("immutables", ParentTag = "richtexteditor-editor", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class EditorImmutablesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (EditorTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as EditorTagHelper).Immutables = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? Enabled { get; set; }

    public string Deserialization { get; set; }

    public string Serialization { get; set; }

    public string SerializationHandler { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string deserialization = this.Deserialization;
      if ((deserialization != null ? (deserialization.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["deserialization"] = (object) this.CreateHandler(this.Deserialization);
      string serializationHandler = this.SerializationHandler;
      if ((serializationHandler != null ? (serializationHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["serialization"] = (object) this.CreateHandler(this.SerializationHandler);
      }
      else
      {
        string serialization = this.Serialization;
        if ((serialization != null ? (serialization.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["serialization"] = (object) this.Serialization;
      }
      return dictionary;
    }
  }
}
