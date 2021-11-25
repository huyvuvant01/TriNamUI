// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceCubeMeasureTagHelper
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
  [HtmlTargetElement("measure", ParentTag = "measures", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class PivotDataSourceCubeMeasureTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PivotDataSourceCubeMeasureTagHelper measureTagHelper = this;
      Type type = measureTagHelper.GetType();
      context.Items[(object) type] = (object) measureTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      measureTagHelper.AddSelfToParent(context);
      context.Items[(object) type] = (object) null;
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotDataSourceCubeMeasuresTagHelper);
      (context.Items[(object) type] as PivotDataSourceCubeMeasuresTagHelper).Add(this);
    }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string caption = this.Caption;
      if ((caption != null ? (caption.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["caption"] = (object) this.Caption;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      string format = this.Format;
      if ((format != null ? (format.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["format"] = (object) this.Format;
      string aggregate = this.Aggregate;
      if ((aggregate != null ? (aggregate.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["aggregate"] = (object) this.Aggregate;
      }
      else
      {
        string aggregateHandler = this.AggregateHandler;
        if ((aggregateHandler != null ? (aggregateHandler.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["aggregate"] = (object) new ClientHandlerDescriptor()
          {
            HandlerName = this.AggregateHandler
          };
      }
      string result = this.Result;
      if ((result != null ? (result.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["result"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = this.Result
        };
      return dictionary;
    }

    public string Caption { get; set; }

    public string Name { get; set; }

    public string Field { get; set; }

    public string Format { get; set; }

    public string Aggregate { get; set; }

    public string AggregateHandler { get; set; }

    public string Result { get; set; }
  }
}
