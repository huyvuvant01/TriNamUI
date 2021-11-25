// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.OrgChartTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-orgchart")]
  [RestrictChildren("editable", new string[] {"messages", "orgchart-datasource"})]
  public class OrgChartTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  OrgChartDataSourceTagHelper>
  {
    public OrgChartTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      OrgChartTagHelper orgChartTagHelper = this;
      context.Items[(object) orgChartTagHelper.GetType()] = (object) orgChartTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await orgChartTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    public string[] CardsColors { get; set; }

    public string DatasourceId { get; set; }

    public OrgChartDataSourceTagHelper Datasource { get; set; }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.CardsColors != null)
        dictionary["cardsColors"] = (object) this.CardsColors;
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      return this.Initializer.Initialize(this.Selector, "OrgChart", (IDictionary<string, object>) dictionary);
    }

    public string OnCancel { get; set; }

    public string OnChange { get; set; }

    public string OnCollapse { get; set; }

    public string OnCreate { get; set; }

    public string OnDataBinding { get; set; }

    public string OnDataBound { get; set; }

    public string OnDelete { get; set; }

    public string OnEdit { get; set; }

    public string OnExpand { get; set; }

    public string OnSave { get; set; }

    public string OnSelect { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onCancel = this.OnCancel;
      if ((onCancel != null ? (onCancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.CreateHandler(this.OnCancel);
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onCollapse = this.OnCollapse;
      if ((onCollapse != null ? (onCollapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapse"] = (object) this.CreateHandler(this.OnCollapse);
      string onCreate = this.OnCreate;
      if ((onCreate != null ? (onCreate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["create"] = (object) this.CreateHandler(this.OnCreate);
      string onDataBinding = this.OnDataBinding;
      if ((onDataBinding != null ? (onDataBinding.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBinding"] = (object) this.CreateHandler(this.OnDataBinding);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onDelete = this.OnDelete;
      if ((onDelete != null ? (onDelete.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["delete"] = (object) this.CreateHandler(this.OnDelete);
      string onEdit = this.OnEdit;
      if ((onEdit != null ? (onEdit.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["edit"] = (object) this.CreateHandler(this.OnEdit);
      string onExpand = this.OnExpand;
      if ((onExpand != null ? (onExpand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expand"] = (object) this.CreateHandler(this.OnExpand);
      string onSave = this.OnSave;
      if ((onSave != null ? (onSave.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["save"] = (object) this.CreateHandler(this.OnSave);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public OrgChartEditableSettingsTagHelper Editable { get; set; }

    public string GroupField { get; set; }

    public string GroupHeaderTemplate { get; set; }

    public string GroupHeaderTemplateId { get; set; }

    [HtmlAttributeNotBound]
    public OrgChartMessagesSettingsTagHelper Messages { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Editable != null)
      {
        Dictionary<string, object> source = this.Editable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Editable.Enabled.HasValue || this.Editable.Enabled.Value))
          dictionary["editable"] = (object) source;
        else if (this.Editable.Enabled.HasValue && !this.Editable.Enabled.Value)
          dictionary["editable"] = (object) this.Editable.Enabled;
      }
      string groupField = this.GroupField;
      if ((groupField != null ? (groupField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["groupField"] = (object) this.GroupField;
      if (this.GroupHeaderTemplateId.HasValue())
        dictionary["groupHeaderTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.GroupHeaderTemplateId)
        };
      else if (this.GroupHeaderTemplate.HasValue())
        dictionary["groupHeaderTemplate"] = (object) this.GroupHeaderTemplate;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      return dictionary;
    }
  }
}
