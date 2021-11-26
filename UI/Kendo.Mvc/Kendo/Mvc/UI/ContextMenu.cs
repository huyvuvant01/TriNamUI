// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ContextMenu
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
  public class ContextMenu : 
    WidgetBase,
    INavigationItemComponent<ContextMenuItem>,
    INavigationItemContainer<ContextMenuItem>
  {
    internal bool isPathHighlighted;

    public ContextMenu(ViewContext viewContext)
      : base(viewContext)
    {
      this.Animation = new PopupAnimation();
      this.Items = (IList<ContextMenuItem>) new List<ContextMenuItem>();
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.Schema.Model = (ModelDescriptor) new TreeListModelDescriptor(typeof (object), this.ModelMetadataProvider);
      this.CloseOnClick = new bool?(true);
      this.HighlightPath = new bool?(true);
    }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public string Direction { get; set; }

    public PopupAnimation Animation { get; private set; }

    public bool? OpenOnClick { get; set; }

    public bool? HighlightPath { get; set; }

    public Action<ContextMenuItem> ItemAction { get; set; }

    public IList<ContextMenuItem> Items { get; private set; }

    protected override void WriteHtml(TextWriter writer)
    {
      if (this.Items.Any<ContextMenuItem>())
      {
        if (this.HighlightPath.Value)
          this.Items.Each<ContextMenuItem>(new Action<ContextMenuItem>(this.HighlightSelectedItem));
        INavigationComponentHtmlBuilder<ContextMenuItem> builder = (INavigationComponentHtmlBuilder<ContextMenuItem>) new ContextMenuHtmlBuilder(this);
        IHtmlNode menuTag = builder.Build();
        this.Items.Each<ContextMenuItem>((Action<ContextMenuItem>) (item => item.WriteItem<ContextMenu, ContextMenuItem>(this, menuTag, builder)));
        menuTag.WriteTo(writer, this.HtmlEncoder);
      }
      else if (this.DataSource != null)
        new ContextMenuHtmlBuilder(this).Build().WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    private void HighlightSelectedItem(ContextMenuItem item)
    {
      if (item.IsCurrent(this.ViewContext, this.UrlGenerator))
      {
        this.isPathHighlighted = true;
        item.Selected = item.Parent != null;
        do
        {
          if (!item.Selected)
            item.HtmlAttributes.AppendInValue("class", " ", (object) "k-state-highlight");
          item = item.Parent;
        }
        while (item != null);
      }
      else
        item.Items.Each<ContextMenuItem>(new Action<ContextMenuItem>(this.HighlightSelectedItem));
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Keys.Any<string>())
        dictionary1["animation"] = json["animation"];
      if (this.DataSourceId.HasValue())
      {
        dictionary1["dataSourceId"] = (object) this.DataSourceId;
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
              dictionary1["dataSource"] = (object) this.DataSource.Data;
              goto label_9;
            }
            else
              goto label_9;
          }
        }
        dictionary1["dataSource"] = (object) this.DataSource.ToJson();
      }
label_9:
      bool? nullable = this.AlignToAnchor;
      if (nullable.HasValue)
      {
        nullable = this.AlignToAnchor;
        if (nullable.Value)
          dictionary1["alignToAnchor"] = (object) true;
      }
      ContextMenuOrientation? orientation = this.Orientation;
      if (orientation.HasValue)
      {
        orientation = this.Orientation;
        ContextMenuOrientation contextMenuOrientation = ContextMenuOrientation.Vertical;
        if (!(orientation.GetValueOrDefault() == contextMenuOrientation & orientation.HasValue))
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          orientation = this.Orientation;
          ref ContextMenuOrientation? local = ref orientation;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["orientation"] = (object) str;
        }
      }
      if (this.Direction.HasValue())
        dictionary1["direction"] = (object) this.Direction;
      nullable = this.OpenOnClick;
      if (nullable.HasValue)
      {
        nullable = this.OpenOnClick;
        if (nullable.Value)
          dictionary1["openOnClick"] = (object) true;
      }
      nullable = this.CloseOnClick;
      if (nullable.HasValue)
      {
        nullable = this.CloseOnClick;
        if (!nullable.Value)
          dictionary1["closeOnClick"] = (object) false;
      }
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ContextMenu), (IDictionary<string, object>) dictionary1));
    }

    public bool? AlignToAnchor { get; set; }

    public string AppendTo { get; set; }

    public bool? CloseOnClick { get; set; }

    public bool? CopyAnchorStyles { get; set; }

    public string DataTextField { get; set; }

    public string DataUrlField { get; set; }

    public string DataSpriteCssClassField { get; set; }

    public string DataImageUrlField { get; set; }

    public string DataContentField { get; set; }

    public string Filter { get; set; }

    public double? HoverDelay { get; set; }

    public ContextMenuScrollableSettings Scrollable { get; } = new ContextMenuScrollableSettings();

    public string ShowOn { get; set; }

    public string Target { get; set; }

    public ContextMenuOrientation? Orientation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      string appendTo = this.AppendTo;
      if ((appendTo != null ? (appendTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["appendTo"] = (object) this.AppendTo;
      bool? nullable = this.CopyAnchorStyles;
      if (nullable.HasValue)
        dictionary["copyAnchorStyles"] = (object) this.CopyAnchorStyles;
      string dataTextField = this.DataTextField;
      if ((dataTextField != null ? (dataTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataTextField"] = (object) this.DataTextField;
      string dataUrlField = this.DataUrlField;
      if ((dataUrlField != null ? (dataUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataUrlField"] = (object) this.DataUrlField;
      string spriteCssClassField = this.DataSpriteCssClassField;
      if ((spriteCssClassField != null ? (spriteCssClassField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataSpriteCssClassField"] = (object) this.DataSpriteCssClassField;
      string dataImageUrlField = this.DataImageUrlField;
      if ((dataImageUrlField != null ? (dataImageUrlField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataImageUrlField"] = (object) this.DataImageUrlField;
      string dataContentField = this.DataContentField;
      if ((dataContentField != null ? (dataContentField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["dataContentField"] = (object) this.DataContentField;
      string filter = this.Filter;
      if ((filter != null ? (filter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["filter"] = (object) this.Filter;
      if (this.HoverDelay.HasValue)
        dictionary["hoverDelay"] = (object) this.HoverDelay;
      Dictionary<string, object> source = this.Scrollable.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
      {
        dictionary["scrollable"] = (object) source;
      }
      else
      {
        nullable = this.Scrollable.Enabled;
        if (nullable.HasValue)
          dictionary["scrollable"] = (object) this.Scrollable.Enabled;
      }
      string showOn = this.ShowOn;
      if ((showOn != null ? (showOn.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["showOn"] = (object) this.ShowOn;
      string target = this.Target;
      if ((target != null ? (target.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["target"] = (object) this.Target;
      return dictionary;
    }
  }
}
