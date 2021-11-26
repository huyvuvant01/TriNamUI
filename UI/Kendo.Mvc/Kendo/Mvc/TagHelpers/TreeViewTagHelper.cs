// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TreeViewTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-treeview")]
  [RestrictChildren("animation", new string[] {"checkboxes", "messages", "items", "hierarchical-datasource"})]
  [OutputElementHint("div")]
  public class TreeViewTagHelper : ItemsCollectionTagHelperBase
  {
    [HtmlAttributeName("dataimageurlfield")]
    public 
    #nullable disable
    string DataImageUrlField { get; set; }

    [HtmlAttributeName("dataspritecssclassfield")]
    public string DataSpriteCssClassField { get; set; }

    [HtmlAttributeName("datatextfield")]
    public string DataTextField { get; set; }

    [HtmlAttributeName("dataurlfield")]
    public string DataUrlField { get; set; }

    [HtmlAttributeName("bind-to")]
    public IEnumerable<TreeViewItemBase> BindTo { get; set; }

    [HtmlAttributeNotBound]
    public TreeViewItemsTagHelper Items { get; set; }

    public TreeViewTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TreeViewTagHelper treeViewTagHelper = this;
      context.Items[(object) treeViewTagHelper.GetType()] = (object) treeViewTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await treeViewTagHelper.\u003C\u003En__0(context, output);
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
      if (this.DataSourceId.HasValue())
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      else if (this.Datasource != null)
        dictionary["dataSource"] = (object) this.Datasource.Serialize();
      string dataImageUrlField = this.DataImageUrlField;
      if ((dataImageUrlField != null ? (dataImageUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataImageUrlField"] = (object) this.DataImageUrlField;
      string spriteCssClassField = this.DataSpriteCssClassField;
      if ((spriteCssClassField != null ? (spriteCssClassField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataSpriteCssClassField"] = (object) this.DataSpriteCssClassField;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataUrlField = this.DataUrlField;
      if ((dataUrlField != null ? (dataUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataUrlField"] = (object) this.DataUrlField;
      if (this.BindTo != null)
      {
        IEnumerable<Dictionary<string, object>> dictionaries = this.BindTo.Select<TreeViewItemBase, Dictionary<string, object>>((Func<TreeViewItemBase, Dictionary<string, object>>) (i => i.Serialize()));
        if (this.BindTo.Any<TreeViewItemBase>())
          dictionary["dataSource"] = (object) dictionaries;
      }
      if (this.Items != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Items.Select<TreeViewItemTagHelper, Dictionary<string, object>>((Func<TreeViewItemTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["dataSource"] = (object) source;
      }
      return this.Initializer.Initialize(this.Selector, "TreeView", (IDictionary<string, object>) dictionary);
    }

    public string OnChange { get; set; }

    public string OnCheck { get; set; }

    public string OnCollapse { get; set; }

    public string OnDataBound { get; set; }

    public string OnDrag { get; set; }

    public string OnDragend { get; set; }

    public string OnDragstart { get; set; }

    public string OnDrop { get; set; }

    public string OnExpand { get; set; }

    public string OnKendoKeydown { get; set; }

    public string OnNavigate { get; set; }

    public string OnSelect { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      string onCheck = this.OnCheck;
      if ((onCheck != null ? (onCheck.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["check"] = (object) this.CreateHandler(this.OnCheck);
      string onCollapse = this.OnCollapse;
      if ((onCollapse != null ? (onCollapse.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["collapse"] = (object) this.CreateHandler(this.OnCollapse);
      string onDataBound = this.OnDataBound;
      if ((onDataBound != null ? (onDataBound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataBound"] = (object) this.CreateHandler(this.OnDataBound);
      string onDrag = this.OnDrag;
      if ((onDrag != null ? (onDrag.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["drag"] = (object) this.CreateHandler(this.OnDrag);
      string onDragend = this.OnDragend;
      if ((onDragend != null ? (onDragend.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragend"] = (object) this.CreateHandler(this.OnDragend);
      string onDragstart = this.OnDragstart;
      if ((onDragstart != null ? (onDragstart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dragstart"] = (object) this.CreateHandler(this.OnDragstart);
      string onDrop = this.OnDrop;
      if ((onDrop != null ? (onDrop.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["drop"] = (object) this.CreateHandler(this.OnDrop);
      string onExpand = this.OnExpand;
      if ((onExpand != null ? (onExpand.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["expand"] = (object) this.CreateHandler(this.OnExpand);
      string onKendoKeydown = this.OnKendoKeydown;
      if ((onKendoKeydown != null ? (onKendoKeydown.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["kendoKeydown"] = (object) this.CreateHandler(this.OnKendoKeydown);
      string onNavigate = this.OnNavigate;
      if ((onNavigate != null ? (onNavigate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["navigate"] = (object) this.CreateHandler(this.OnNavigate);
      string onSelect = this.OnSelect;
      if ((onSelect != null ? (onSelect.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["select"] = (object) this.CreateHandler(this.OnSelect);
      return dictionary;
    }

    public bool? AutoBind { get; set; }

    public bool? AutoScroll { get; set; }

    [HtmlAttributeNotBound]
    public TreeViewCheckboxesSettingsTagHelper Checkboxes { get; set; }

    public bool? DragAndDrop { get; set; }

    public bool? LoadOnDemand { get; set; }

    [HtmlAttributeNotBound]
    public TreeViewMessagesSettingsTagHelper Messages { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.AutoScroll.HasValue)
        dictionary["autoScroll"] = (object) this.AutoScroll;
      if (this.Checkboxes != null)
      {
        Dictionary<string, object> source = this.Checkboxes.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Checkboxes.Enabled.HasValue || this.Checkboxes.Enabled.Value))
          dictionary["checkboxes"] = (object) source;
        else if (this.Checkboxes.Enabled.HasValue && this.Checkboxes.Enabled.Value)
          dictionary["checkboxes"] = (object) this.Checkboxes.Enabled;
      }
      if (this.DragAndDrop.HasValue)
        dictionary["dragAndDrop"] = (object) this.DragAndDrop;
      if (this.LoadOnDemand.HasValue)
        dictionary["loadOnDemand"] = (object) this.LoadOnDemand;
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
