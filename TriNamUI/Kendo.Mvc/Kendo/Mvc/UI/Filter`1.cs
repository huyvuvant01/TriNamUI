// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Filter`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Filter<T> : WidgetBase where T : class
  {
    public Filter(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public FilterOperatorsSettings<T> Operators { get; } = new FilterOperatorsSettings<T>();

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Expression != null)
        dictionary["expression"] = (object) this.Expression.ToJson();
      if (this.DataSource.HasValue())
        dictionary["dataSourceId"] = (object) this.DataSource;
      Dictionary<string, object> source = this.Operators.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["operators"] = (object) source;
      dictionary["mainLogic"] = (object) this.MainLogic.ToString().ToLowerInvariant();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Filter<T>), (IDictionary<string, object>) dictionary));
    }

    public bool? ApplyButton { get; set; }

    public string DataSource { get; set; }

    public CompositeFilterDescriptor Expression { get; set; }

    public bool? ExpressionPreview { get; set; }

    public List<FilterField<T>> Fields { get; set; } = new List<FilterField<T>>();

    public FilterCompositionLogicalOperator MainLogic { get; set; }

    public FilterMessagesSettings<T> Messages { get; } = new FilterMessagesSettings<T>();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.ApplyButton.HasValue)
        dictionary["applyButton"] = (object) this.ApplyButton;
      if (this.ExpressionPreview.HasValue)
        dictionary["expressionPreview"] = (object) this.ExpressionPreview;
      IEnumerable<Dictionary<string, object>> source1 = this.Fields.Select<FilterField<T>, Dictionary<string, object>>((Func<FilterField<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source1.Any<Dictionary<string, object>>())
        dictionary["fields"] = (object) source1;
      Dictionary<string, object> source2 = this.Messages.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source2;
      return dictionary;
    }
  }
}
