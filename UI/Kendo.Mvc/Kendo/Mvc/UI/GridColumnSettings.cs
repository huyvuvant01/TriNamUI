// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridColumnSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Net;

namespace Kendo.Mvc.UI
{
  public class GridColumnSettings
  {
    private string member;
    private string clientTemplate;

    public GridColumnSettings()
    {
      this.Sortable = true;
      this.Encoded = true;
      this.Filterable = true;
      this.Groupable = true;
      this.Visible = true;
      this.IncludeInMenu = true;
      this.Lockable = true;
      this.HeaderHtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.HtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.FooterHtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
    }

    public string ClientHeaderTemplate { get; set; }

    public string ClientTemplate
    {
      get => this.clientTemplate;
      set => this.clientTemplate = WebUtility.HtmlDecode(value);
    }

    public string ClientTemplateId { get; set; }

    public string ClientGroupHeaderTemplate { get; set; }

    public string ClientGroupHeaderColumnTemplate { get; set; }

    public string ClientGroupFooterTemplate { get; set; }

    public string ClientFooterTemplate { get; set; }

    public bool Encoded { get; set; }

    public bool Locked { get; set; }

    public bool Lockable { get; set; }

    public bool Sticky { get; set; }

    public bool Stickable { get; set; }

    public bool Filterable { get; set; }

    public string Format { get; set; }

    public bool Groupable { get; set; }

    public IDictionary<string, object> HeaderHtmlAttributes { get; private set; }

    public IDictionary<string, object> FooterHtmlAttributes { get; private set; }

    public bool Hidden { get; set; }

    public bool IncludeInMenu { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; private set; }

    public string Member
    {
      get => this.member;
      set
      {
        this.member = value;
        if (this.Title.HasValue())
          return;
        this.Title = this.member.AsTitle();
      }
    }

    public Type MemberType { get; set; }

    public bool ReadOnly { get; set; }

    public bool Sortable { get; set; }

    public string Title { get; set; }

    public bool Visible { get; set; }

    public string Width { get; set; }

    public string Media { get; set; }

    public int MinScreenWidth { get; set; }

    public int MinResizableWidth { get; set; }

    public GridFilterUIRole FilterUIRole { get; set; }
  }
}
