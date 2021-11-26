// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeMapTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-treemap")]
  [RestrictChildren("hierarchical-datasource", new string[] {})]
  public class TreeMapTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  HierarchicalDataSourceTagHelper>
  {
    public TreeMapTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TreeMapTagHelper treeMapTagHelper = this;
      context.Items[(object) treeMapTagHelper.GetType()] = (object) treeMapTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await treeMapTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      object[] colors = this.Colors;
      if ((colors != null ? (((IEnumerable<object>) colors).Any<object>() ? 1 : 0) : 0) != 0)
        dictionary["colors"] = (object) this.Colors;
      if (this.DataSourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      return this.Initializer.Initialize(this.Selector, "TreeMap", (IDictionary<string, object>) dictionary);
    }

    public object[] Colors { get; set; }

    [HtmlAttributeName("datasource-id")]
    public string DataSourceId { get; set; }

    public HierarchicalDataSourceTagHelper Datasource { get; set; }

    public string OnItemCreated { get; set; }

    public string OnDataBound { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onItemCreated = this.OnItemCreated;
      if ((onItemCreated != null ? (onItemCreated.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["itemCreated"] = (object) this.CreateHandler(this.OnItemCreated);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      return dictionary;
    }

    public bool? AutoBind { get; set; }

    public string Theme { get; set; }

    public string ValueField { get; set; }

    public string ColorField { get; set; }

    public string TextField { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public TreeMapType? Type { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      string theme = this.Theme;
      if ((theme != null ? (theme.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["theme"] = (object) this.Theme;
      string valueField = this.ValueField;
      if ((valueField != null ? (valueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["valueField"] = (object) this.ValueField;
      string colorField = this.ColorField;
      if ((colorField != null ? (colorField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["colorField"] = (object) this.ColorField;
      string textField = this.TextField;
      if ((textField != null ? (textField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["textField"] = (object) this.TextField;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        TreeMapType? type = this.Type;
        ref TreeMapType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
