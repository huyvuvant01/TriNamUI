// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SchedulerResourceTagHelper
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
  [HtmlTargetElement("resource", ParentTag = "resources", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("datasource", new string[] {})]
  [SuppressTagRendering]
  public class SchedulerResourceTagHelper : 
    TagHelperCollectionItemBase,
    IDataBoundWidget<
    #nullable disable
    DataSourceTagHelper>
  {
    [HtmlAttributeName("datacolorfield")]
    public string DataColorField { get; set; }

    [HtmlAttributeName("datatextfield")]
    public string DataTextField { get; set; }

    [HtmlAttributeName("datavaluefield")]
    public string DataValueField { get; set; }

    [HtmlAttributeName("dataparentvaluefield")]
    public string DataParentValueField { get; set; }

    [HtmlAttributeName("bind-to")]
    public IEnumerable<object> BindTo { get; set; }

    [HtmlAttributeNotBound]
    public DataSourceTagHelper Datasource { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SchedulerResourcesTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SchedulerResourcesTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string dataColorField = this.DataColorField;
      if ((dataColorField != null ? (dataColorField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataColorField"] = (object) this.DataColorField;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataValueField = this.DataValueField;
      if ((dataValueField != null ? (dataValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataValueField"] = (object) this.DataValueField;
      string parentValueField = this.DataParentValueField;
      if ((parentValueField != null ? (parentValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataParentValueField"] = (object) this.DataParentValueField;
      if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      if (this.BindTo != null)
        dictionary["dataSource"] = (object) this.BindTo;
      return dictionary;
    }

    public string Field { get; set; }

    public bool? Multiple { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public bool? ValuePrimitive { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["field"] = (object) this.Field;
      bool? nullable = this.Multiple;
      if (nullable.HasValue)
        dictionary["multiple"] = (object) this.Multiple;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      nullable = this.ValuePrimitive;
      if (nullable.HasValue)
        dictionary["valuePrimitive"] = (object) this.ValuePrimitive;
      return dictionary;
    }
  }
}
