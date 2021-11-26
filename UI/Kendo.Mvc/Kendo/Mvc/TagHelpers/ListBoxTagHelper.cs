// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ListBoxTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-listbox")]
  [RestrictChildren("draggable", new string[] {"messages", "toolbar", "datasource"})]
  public class ListBoxTagHelper : TagHelperBase, IDataBoundWidget<
  #nullable disable
  DataSourceTagHelper>
  {
    public string DatasourceId { get; set; }

    public DataSourceTagHelper Datasource { get; set; }

    [HtmlAttributeName("datatextfield")]
    public string DataTextField { get; set; }

    [HtmlAttributeName("datavaluefield")]
    public string DataValueField { get; set; }

    public IEnumerable<object> BindTo { get; set; }

    internal IEnumerable Data { get; set; }

    public ListBoxTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ListBoxTagHelper listBoxTagHelper = this;
      if (listBoxTagHelper.BindTo != null && listBoxTagHelper.BindTo is IEnumerable<SelectListItem>)
      {
        if (string.IsNullOrEmpty(listBoxTagHelper.DataValueField) && string.IsNullOrEmpty(listBoxTagHelper.DataTextField))
        {
          listBoxTagHelper.DataValueField = "Value";
          listBoxTagHelper.DataTextField = "Text";
        }
        listBoxTagHelper.Data = (IEnumerable) ((IEnumerable<SelectListItem>) listBoxTagHelper.BindTo).Select(item => new
        {
          Text = item.Text,
          Value = item.Value ?? item.Text,
          Selected = item.Selected
        });
      }
      context.Items[(object) listBoxTagHelper.GetType()] = (object) listBoxTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await listBoxTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("select", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "select";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataValueField = this.DataValueField;
      if ((dataValueField != null ? (dataValueField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataValueField"] = (object) this.DataValueField;
      if (this.DatasourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DatasourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      else if (this.BindTo != null)
        dictionary["dataSource"] = (object) this.BindTo;
      return this.Initializer.Initialize(this.Selector, "ListBox", (IDictionary<string, object>) dictionary);
    }

    public string OnAdd { get; set; }

    public string OnChange { get; set; }

    public string OnDataBound { get; set; }

    public string OnDragstart { get; set; }

    public string OnDrag { get; set; }

    public string OnDrop { get; set; }

    public string OnDragend { get; set; }

    public string OnRemove { get; set; }

    public string OnReorder { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onAdd = this.OnAdd;
      if ((onAdd != null ? (onAdd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["add"] = (object) this.CreateHandler(this.OnAdd);
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onDragstart = this.OnDragstart;
      if ((onDragstart != null ? (onDragstart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragstart"] = (object) this.CreateHandler(this.OnDragstart);
      string onDrag = this.OnDrag;
      if ((onDrag != null ? (onDrag.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["drag"] = (object) this.CreateHandler(this.OnDrag);
      string onDrop = this.OnDrop;
      if ((onDrop != null ? (onDrop.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["drop"] = (object) this.CreateHandler(this.OnDrop);
      string onDragend = this.OnDragend;
      if ((onDragend != null ? (onDragend.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragend"] = (object) this.CreateHandler(this.OnDragend);
      string onRemove = this.OnRemove;
      if ((onRemove != null ? (onRemove.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["remove"] = (object) this.CreateHandler(this.OnRemove);
      string onReorder = this.OnReorder;
      if ((onReorder != null ? (onReorder.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["reorder"] = (object) this.CreateHandler(this.OnReorder);
      return dictionary;
    }

    public bool? AutoBind { get; set; }

    public string ConnectWith { get; set; }

    [HtmlAttributeNotBound]
    public ListBoxDraggableSettingsTagHelper Draggable { get; set; }

    public string[] DropSources { get; set; }

    public bool? Navigatable { get; set; }

    [HtmlAttributeNotBound]
    public ListBoxMessagesSettingsTagHelper Messages { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    [HtmlAttributeNotBound]
    public ListBoxToolbarSettingsTagHelper Toolbar { get; set; }

    public ListBoxSelectable? Selectable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      string connectWith = this.ConnectWith;
      if ((connectWith != null ? (connectWith.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["connectWith"] = (object) this.ConnectWith;
      if (this.Draggable != null)
      {
        Dictionary<string, object> source = this.Draggable.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Draggable.Enabled.HasValue || this.Draggable.Enabled.Value))
          dictionary1["draggable"] = (object) source;
        else if (this.Draggable.Enabled.HasValue && this.Draggable.Enabled.Value)
          dictionary1["draggable"] = (object) this.Draggable.Enabled;
      }
      string[] dropSources = this.DropSources;
      if ((dropSources != null ? (((IEnumerable<string>) dropSources).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary1["dropSources"] = (object) this.DropSources;
      if (this.Navigatable.HasValue)
        dictionary1["navigatable"] = (object) this.Navigatable;
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["messages"] = (object) source;
      }
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      if (this.Toolbar != null)
      {
        Dictionary<string, object> source = this.Toolbar.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["toolbar"] = (object) source;
      }
      if (this.Selectable.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ListBoxSelectable? selectable = this.Selectable;
        ref ListBoxSelectable? local = ref selectable;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["selectable"] = (object) str;
      }
      return dictionary1;
    }
  }
}
