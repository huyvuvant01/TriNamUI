// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Menu
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
  public class Menu : 
    WidgetBase,
    INavigationItemComponent<MenuItem>,
    INavigationItemContainer<MenuItem>
  {
    internal bool isPathHighlighted;

    public Menu(ViewContext viewContext)
      : base(viewContext)
    {
      this.Animation = new PopupAnimation();
      this.Items = (IList<MenuItem>) new List<MenuItem>();
      this.DataSource = new DataSource(this.ModelMetadataProvider);
      this.DataSource.Schema.Model = new ModelDescriptor(typeof (object), this.ModelMetadataProvider);
      this.HighlightPath = new bool?(true);
      this.Orientation = new MenuOrientation?(MenuOrientation.Horizontal);
    }

    public DataSource DataSource { get; private set; }

    public string DataSourceId { get; set; }

    public PopupAnimation Animation { get; private set; }

    public IList<MenuItem> Items { get; private set; }

    public Action<MenuItem> ItemAction { get; set; }

    public bool? HighlightPath { get; set; }

    public string Direction { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      if (this.Items.Any<MenuItem>())
      {
        if (this.HighlightPath.Value)
          this.Items.Each<MenuItem>(new Action<MenuItem>(this.HighlightSelectedItem));
        INavigationComponentHtmlBuilder<MenuItem> builder = (INavigationComponentHtmlBuilder<MenuItem>) new MenuHtmlBuilder(this);
        IHtmlNode menuTag = builder.Build();
        this.Items.Each<MenuItem>((Action<MenuItem>) (item => item.WriteItem<Menu, MenuItem>(this, menuTag, builder)));
        menuTag.WriteTo(writer, this.HtmlEncoder);
      }
      else if (this.DataSource != null)
        new MenuHtmlBuilder(this).Build().WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    private void HighlightSelectedItem(MenuItem item)
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
        item.Items.Each<MenuItem>(new Action<MenuItem>(this.HighlightSelectedItem));
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
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
              goto label_7;
            }
            else
              goto label_7;
          }
        }
        dictionary1["dataSource"] = (object) this.DataSource.ToJson();
      }
label_7:
      IDictionary<string, object> json = this.Animation.ToJson();
      if (json.Keys.Any<string>())
        dictionary1["animation"] = json["animation"];
      Dictionary<string, object> source = this.OpenOnClick.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary1["openOnClick"] = (object) source;
      else if (this.OpenOnClick.Enabled.HasValue)
        dictionary1["openOnClick"] = (object) this.OpenOnClick.Enabled;
      MenuOrientation? orientation = this.Orientation;
      if (orientation.HasValue)
      {
        orientation = this.Orientation;
        MenuOrientation menuOrientation = MenuOrientation.Horizontal;
        if (!(orientation.GetValueOrDefault() == menuOrientation & orientation.HasValue))
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          orientation = this.Orientation;
          ref MenuOrientation? local = ref orientation;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["orientation"] = (object) str;
        }
      }
      if (this.Direction.HasValue())
        dictionary1["direction"] = (object) this.Direction;
      if (this.CloseOnClick.HasValue)
        dictionary1["closeOnClick"] = (object) this.CloseOnClick;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Menu), (IDictionary<string, object>) dictionary1));
    }

    public bool? CloseOnClick { get; set; }

    public string DataTextField { get; set; }

    public string DataUrlField { get; set; }

    public string DataSpriteCssClassField { get; set; }

    public string DataImageUrlField { get; set; }

    public string DataContentField { get; set; }

    public double? HoverDelay { get; set; }

    public MenuOpenOnClickSettings OpenOnClick { get; } = new MenuOpenOnClickSettings();

    public MenuScrollableSettings Scrollable { get; } = new MenuScrollableSettings();

    public MenuOrientation? Orientation { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
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
      if (this.HoverDelay.HasValue)
        dictionary["hoverDelay"] = (object) this.HoverDelay;
      Dictionary<string, object> source = this.Scrollable.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["scrollable"] = (object) source;
      else if (this.Scrollable.Enabled.HasValue)
        dictionary["scrollable"] = (object) this.Scrollable.Enabled;
      return dictionary;
    }
  }
}
