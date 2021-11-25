// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI
{
  public abstract class GridColumnBase<T> : JsonObject, IGridColumn where T : class
  {
    public string Format
    {
      get => this.Settings.Format;
      set => this.Settings.Format = value;
    }

    public string EditorHtml { get; set; }

    protected GridColumnBase(Kendo.Mvc.UI.Grid<T> grid)
    {
      this.Grid = grid;
      this.Settings = new GridColumnSettings();
      this.Visible = true;
      this.Exportable = new GridColumnExportableSettings();
    }

    public Kendo.Mvc.UI.Grid<T> Grid { get; }

    public string Member
    {
      get => this.Settings.Member;
      set => this.Settings.Member = value;
    }

    public GridColumnExportableSettings Exportable { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Title.HasValue())
        json["title"] = (object) this.Title;
      if (this.HtmlAttributes.Any<KeyValuePair<string, object>>())
        json["attributes"] = (object) this.EncodeAttributes(this.HtmlAttributes);
      if (this.HeaderHtmlAttributes.Any<KeyValuePair<string, object>>())
        json["headerAttributes"] = (object) this.EncodeAttributes(this.HeaderHtmlAttributes);
      if (this.FooterHtmlAttributes.Any<KeyValuePair<string, object>>())
        json["footerAttributes"] = (object) this.EncodeAttributes(this.FooterHtmlAttributes);
      if (this.Hidden)
        json["hidden"] = (object) true;
      if (!this.IncludeInMenu)
        json["menu"] = (object) false;
      if (this.Width.HasValue())
        json["width"] = (object) this.Width;
      if (this.Media.HasValue())
        json["media"] = (object) this.Media;
      if (this.MinScreenWidth != 0)
        json["minScreenWidth"] = (object) this.MinScreenWidth;
      if (this.MinResizableWidth != 0)
        json["minResizableWidth"] = (object) this.MinResizableWidth;
      if (this.ClientTemplate.HasValue())
        json["template"] = (object) WebUtility.UrlDecode(this.ClientTemplate);
      if (this.ClientTemplateId.HasValue())
      {
        string str = "#";
        if (this.Grid.IsInClientTemplate)
          str = "\\" + str;
        json["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = ("kendo.template(jQuery('" + str + this.ClientTemplateId + "').html())")
        };
      }
      if (this.ClientFooterTemplate.HasValue())
        json["footerTemplate"] = (object) WebUtility.UrlDecode(this.ClientFooterTemplate);
      if (this.ClientHeaderTemplate.HasValue())
        json["headerTemplate"] = (object) WebUtility.UrlDecode(this.ClientHeaderTemplate);
      if (this.ClientGroupFooterTemplate.HasValue())
        json["groupFooterTemplate"] = (object) this.ClientGroupFooterTemplate;
      if (!this.Encoded)
        json["encoded"] = (object) this.Encoded;
      if (this.Locked)
        json["locked"] = (object) this.Locked;
      if (!this.Lockable)
        json["lockable"] = (object) this.Lockable;
      if (this.Sticky)
        json["sticky"] = (object) this.Sticky;
      if (this.Stickable)
        json["stickable"] = (object) this.Stickable;
      if (!this.Exportable.Enabled)
      {
        json["exportable"] = (object) false;
      }
      else
      {
        if (this.Exportable.Pdf && this.Exportable.Excel)
          return;
        json["exportable"] = (object) this.Exportable.Serialize();
      }
    }

    private IDictionary<string, object> EncodeAttributes(
      IDictionary<string, object> htmlAttributes)
    {
      Dictionary<string, object> attributes = new Dictionary<string, object>();
      HtmlEncoder encoder = HtmlEncoder.Default;
      htmlAttributes.Each<KeyValuePair<string, object>>((Action<KeyValuePair<string, object>>) (attr =>
      {
        string str = encoder.Encode(attr.Value.ToString());
        attributes[encoder.Encode(attr.Key)] = (object) str;
      }));
      return (IDictionary<string, object>) attributes;
    }

    public virtual string Title
    {
      get => this.Settings.Title;
      set => this.Settings.Title = value;
    }

    public string Width
    {
      get => this.Settings.Width;
      set => this.Settings.Width = value;
    }

    public string Media
    {
      get => this.Settings.Media;
      set => this.Settings.Media = value;
    }

    public int MinScreenWidth
    {
      get => this.Settings.MinScreenWidth;
      set => this.Settings.MinScreenWidth = value;
    }

    public int MinResizableWidth
    {
      get => this.Settings.MinResizableWidth;
      set => this.Settings.MinResizableWidth = value;
    }

    public string ClientHeaderTemplate
    {
      get => this.Settings.ClientHeaderTemplate;
      set => this.Settings.ClientHeaderTemplate = value;
    }

    public string ClientTemplate
    {
      get => this.Settings.ClientTemplate;
      set => this.Settings.ClientTemplate = value;
    }

    public string ClientTemplateId
    {
      get => this.Settings.ClientTemplateId;
      set => this.Settings.ClientTemplateId = value;
    }

    public string ClientFooterTemplate
    {
      get => this.Settings.ClientFooterTemplate;
      set => this.Settings.ClientFooterTemplate = value;
    }

    public string ClientGroupFooterTemplate
    {
      get => this.Settings.ClientGroupFooterTemplate;
      set => this.Settings.ClientGroupFooterTemplate = value;
    }

    public virtual bool Hidden
    {
      get => this.Settings.Hidden || ((IEnumerable<IGridColumn>) this.Grid.Columns).ColumnParents((IGridColumn) this).Any<IGridColumn>((Func<IGridColumn, bool>) (c => c.Hidden));
      set => this.Settings.Hidden = value;
    }

    public virtual bool IncludeInMenu
    {
      get => this.Settings.IncludeInMenu;
      set => this.Settings.IncludeInMenu = value;
    }

    public virtual bool Locked
    {
      get => this.Settings.Locked;
      set => this.Settings.Locked = value;
    }

    public virtual bool Lockable
    {
      get => this.Settings.Lockable;
      set => this.Settings.Lockable = value;
    }

    public virtual bool Sticky
    {
      get => this.Settings.Sticky;
      set => this.Settings.Sticky = value;
    }

    public virtual bool Stickable
    {
      get => this.Settings.Stickable;
      set => this.Settings.Stickable = value;
    }

    public virtual bool Encoded
    {
      get => this.Settings.Encoded;
      set => this.Settings.Encoded = value;
    }

    public IDictionary<string, object> HeaderHtmlAttributes => this.Settings.HeaderHtmlAttributes;

    public IDictionary<string, object> FooterHtmlAttributes => this.Settings.FooterHtmlAttributes;

    public virtual bool Visible
    {
      get => this.Settings.Visible;
      set => this.Settings.Visible = value;
    }

    public IDictionary<string, object> HtmlAttributes => this.Settings.HtmlAttributes;

    public bool IsLast => this.Grid.VisibleColumns.Where<GridColumnBase<T>>((Func<GridColumnBase<T>, bool>) (c => !c.Hidden)).LastOrDefault<GridColumnBase<T>>() == this;

    internal GridColumnSettings Settings { get; set; }

    private int HeaderLevel => ((IEnumerable<IGridColumn>) this.Grid.Columns).ColumnLevel((IGridColumn) this);

    private int HeaderDataIndex => ((IEnumerable<IGridColumn>) this.Grid.Columns).LeafColumns().Where<IGridColumn>((Func<IGridColumn, bool>) (c => c.Visible)).OrderByDescending<IGridColumn, bool>((Func<IGridColumn, bool>) (c => c.Locked)).IndexOf((object) this);
  }
}
