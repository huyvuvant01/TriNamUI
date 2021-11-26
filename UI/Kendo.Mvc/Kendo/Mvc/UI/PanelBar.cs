// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PanelBar
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PanelBar : 
    WidgetBase,
    INavigationItemComponent<PanelBarItem>,
    INavigationItemContainer<PanelBarItem>
  {
    internal bool isPathHighlighted;
    internal bool isExpanded;

    public PanelBar(ViewContext viewContext)
      : base(viewContext)
    {
      this.Animation = new ExpandableAnimation();
      this.ExpandMode = new PanelBarExpandMode?(PanelBarExpandMode.Multiple);
      this.Items = (IList<PanelBarItem>) new List<PanelBarItem>();
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.Schema.Model = (ModelDescriptor) new TreeListModelDescriptor(typeof (object), this.ModelMetadataProvider);
      this.LoadOnDemand = new bool?(true);
      this.AutoBind = new bool?(true);
      this.HighlightPath = true;
      this.SelectedIndex = -1;
    }

    public IList<PanelBarItem> Items { get; private set; }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public ExpandableAnimation Animation { get; private set; }

    public Action<PanelBarItem> ItemAction { get; set; }

    public bool HighlightPath { get; set; }

    public bool ExpandAll { get; set; }

    public int SelectedIndex { get; set; }

    public Effects Effects { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      if (this.Items.Any<PanelBarItem>())
      {
        if (this.SelectedIndex != -1 && this.Items.Count < this.SelectedIndex)
          throw new ArgumentOutOfRangeException(Exceptions.IndexOutOfRange);
        int itemIndex = 0;
        INavigationComponentHtmlBuilder<PanelBarItem> builder = (INavigationComponentHtmlBuilder<PanelBarItem>) new PanelBarHtmlBuilder(this);
        IHtmlNode panelbarTag = builder.Build();
        if (this.HighlightPath)
          this.Items.Each<PanelBarItem>(new Action<PanelBarItem>(this.HighlightSelectedItem));
        this.Items.Each<PanelBarItem>((Action<PanelBarItem>) (item =>
        {
          if (item.Enabled)
            this.PrepareItem(item, itemIndex);
          ++itemIndex;
          item.WriteItem<PanelBar, PanelBarItem>(this, panelbarTag, builder);
        }));
        panelbarTag.WriteTo(writer, this.HtmlEncoder);
      }
      else
        this.Generator.GenerateTag("ul", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    private void HighlightSelectedItem(PanelBarItem item)
    {
      if (!item.Enabled)
        return;
      if (item.IsCurrent(this.ViewContext, this.UrlGenerator))
      {
        item.Selected = true;
        this.isPathHighlighted = true;
        for (PanelBarItem parent = item.Parent; parent != null; parent = parent.Parent)
          parent.Expanded = true;
      }
      item.Items.Each<PanelBarItem>(new Action<PanelBarItem>(this.HighlightSelectedItem));
    }

    private void PrepareItem(PanelBarItem item, int itemIndex)
    {
      if (!this.isPathHighlighted && itemIndex == this.SelectedIndex)
      {
        item.Selected = true;
        if (item.Items.Any<PanelBarItem>() || item.Template.HasValue() || !string.IsNullOrEmpty(item.ContentUrl))
          item.Expanded = true;
      }
      PanelBarExpandMode? expandMode = this.ExpandMode;
      PanelBarExpandMode panelBarExpandMode = PanelBarExpandMode.Single;
      if (expandMode.GetValueOrDefault() == panelBarExpandMode & expandMode.HasValue)
      {
        if (item.Expanded && !this.isExpanded)
          this.isExpanded = true;
        else if (item.Parent != null && item.Parent.Expanded)
          item.Expanded = true;
        else
          item.Expanded = false;
      }
      else
      {
        if (!this.ExpandAll)
          return;
        item.Expanded = true;
      }
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.DataSourceId.HasValue())
      {
        dictionary["dataSourceId"] = (object) this.DataSourceId;
      }
      else
      {
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue))
          {
            if (this.DataSource.Data != null)
            {
              dictionary["dataSource"] = (object) this.DataSource.Data;
              goto label_7;
            }
            else
              goto label_7;
          }
        }
        dictionary["dataSource"] = (object) this.DataSource.ToJson();
      }
label_7:
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Keys.Any<string>())
        dictionary["animation"] = json["animation"];
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (PanelBar), (IDictionary<string, object>) dictionary));
    }

    public bool? AutoBind { get; set; }

    public string DataImageUrlField { get; set; }

    public string DataSpriteCssClassField { get; set; }

    public string[] DataTextField { get; set; }

    public string DataUrlField { get; set; }

    public bool? LoadOnDemand { get; set; }

    public PanelBarMessagesSettings Messages { get; } = new PanelBarMessagesSettings();

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public PanelBarExpandMode? ExpandMode { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.AutoBind.HasValue)
        dictionary1["autoBind"] = (object) this.AutoBind;
      string dataImageUrlField = this.DataImageUrlField;
      if ((dataImageUrlField != null ? (dataImageUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataImageUrlField"] = (object) this.DataImageUrlField;
      string spriteCssClassField = this.DataSpriteCssClassField;
      if ((spriteCssClassField != null ? (spriteCssClassField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataSpriteCssClassField"] = (object) this.DataSpriteCssClassField;
      string[] dataTextField = this.DataTextField;
      if ((dataTextField != null ? (((IEnumerable<string>) dataTextField).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary1["dataTextField"] = (object) this.DataTextField;
      string dataUrlField = this.DataUrlField;
      if ((dataUrlField != null ? (dataUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["dataUrlField"] = (object) this.DataUrlField;
      if (this.LoadOnDemand.HasValue)
        dictionary1["loadOnDemand"] = (object) this.LoadOnDemand;
      Dictionary<string, object> source = this.Messages.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["messages"] = (object) source;
      if (this.TemplateId.HasValue())
        dictionary1["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary1["template"] = (object) this.Template;
      if (this.ExpandMode.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        PanelBarExpandMode? expandMode = this.ExpandMode;
        ref PanelBarExpandMode? local = ref expandMode;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["expandMode"] = (object) str;
      }
      return dictionary1;
    }
  }
}
