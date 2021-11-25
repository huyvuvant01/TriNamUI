// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeView
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TreeView : 
    WidgetBase,
    INavigationItemComponent<TreeViewItem>,
    INavigationItemContainer<TreeViewItem>
  {
    internal bool isPathHighlighted;

    public TreeView(ViewContext viewContext)
      : base(viewContext)
    {
      this.Items = (IList<TreeViewItem>) new LinkedObjectCollection<TreeViewItem>((TreeViewItem) null);
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.Schema.Model = new ModelDescriptor(typeof (object), this.ModelMetadataProvider);
      this.LoadOnDemand = new bool?(true);
      this.AutoBind = new bool?(true);
    }

    public IList<TreeViewItem> Items { get; private set; }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public Action<TreeViewItem> ItemAction { get; set; }

    public INavigationItemAuthorization Authorization { get; private set; }

    public SecurityTrimming SecurityTrimming { get; set; }

    public int SelectedIndex { get; set; } = -1;

    public bool HighlightPath { get; set; }

    public bool ExpandAll { get; set; }

    public ExpandableAnimation Animation { get; private set; } = new ExpandableAnimation();

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DataSourceId.HasValue())
      {
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      }
      else
      {
        if (this.Items.Any<TreeViewItem>())
        {
          this.DataSource.Data = this.SerializeItems(this.Items);
          this.LoadOnDemand = new bool?(false);
        }
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.DataSource.Data != null)
            {
              dictionary["dataSource"] = (object) this.DataSource.Data;
              goto label_9;
            }
            else
              goto label_9;
          }
        }
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      }
label_9:
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Keys.Any<string>())
        dictionary["animation"] = json["animation"];
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (TreeView), (IDictionary<string, object>) dictionary));
    }

    private IEnumerable SerializeItems(IList<TreeViewItem> items)
    {
      IUrlHelper urlHelper = this.ViewContext.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>().GetUrlHelper((ActionContext) this.ViewContext);
      return (IEnumerable) items.Select<TreeViewItem, IDictionary<string, object>>((Func<TreeViewItem, IDictionary<string, object>>) (item => item.Serialize(urlHelper)));
    }

    internal bool UsesTemplates() => !string.IsNullOrEmpty(this.TemplateId) || !string.IsNullOrEmpty(this.Template) || this.Checkboxes.Template != "<input type='checkbox' name='#= treeview.checkboxes.name #' #= item.checked ? 'checked' : '' # value='#= item.id #' />";

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    private void HighlightSelectedItem(TreeViewItem item)
    {
      if (item.IsCurrent(this.ViewContext, this.UrlGenerator))
      {
        item.Selected = true;
        this.isPathHighlighted = true;
        for (TreeViewItem parent = item.Parent; parent != null; parent = parent.Parent)
          parent.Expanded = true;
      }
      item.Items.Each<TreeViewItem>(new Action<TreeViewItem>(this.HighlightSelectedItem));
    }

    private void ExpandAllChildrens(TreeViewItem treeViewItem)
    {
      treeViewItem.Expanded = true;
      foreach (TreeViewItem treeViewItem1 in (IEnumerable<TreeViewItem>) treeViewItem.Items)
        this.ExpandAllChildrens(treeViewItem1);
    }

    public bool? AutoBind { get; set; }

    public bool? AutoScroll { get; set; }

    public TreeViewCheckboxesSettings Checkboxes { get; } = new TreeViewCheckboxesSettings();

    public string DataImageUrlField { get; set; }

    public string DataSpriteCssClassField { get; set; }

    public string[] DataTextField { get; set; }

    public string DataUrlField { get; set; }

    public bool? DragAndDrop { get; set; }

    public bool? LoadOnDemand { get; set; }

    public TreeViewMessagesSettings Messages { get; } = new TreeViewMessagesSettings();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary["autoBind"] = (object) this.AutoBind;
      if (this.AutoScroll.HasValue)
        dictionary["autoScroll"] = (object) this.AutoScroll;
      Dictionary<string, object> source1 = this.Checkboxes.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["checkboxes"] = (object) source1;
      else if (this.Checkboxes.Enabled.HasValue)
        dictionary["checkboxes"] = (object) this.Checkboxes.Enabled;
      string dataImageUrlField = this.DataImageUrlField;
      if ((dataImageUrlField != null ? (dataImageUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataImageUrlField"] = (object) this.DataImageUrlField;
      string spriteCssClassField = this.DataSpriteCssClassField;
      if ((spriteCssClassField != null ? (spriteCssClassField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataSpriteCssClassField"] = (object) this.DataSpriteCssClassField;
      string[] dataTextField = this.DataTextField;
      if ((dataTextField != null ? (((IEnumerable<string>) dataTextField).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataUrlField = this.DataUrlField;
      if ((dataUrlField != null ? (dataUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataUrlField"] = (object) this.DataUrlField;
      if (this.DragAndDrop.HasValue)
        dictionary["dragAndDrop"] = (object) this.DragAndDrop;
      if (this.LoadOnDemand.HasValue)
        dictionary["loadOnDemand"] = (object) this.LoadOnDemand;
      Dictionary<string, object> source2 = this.Messages.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source2;
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
