// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PageableMessages
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class PageableMessages : JsonObject
  {
    private const string DefaultDisplay = "{0} - {1} of {2} items";
    private const string DefaultEmpty = "No items to display";
    private const string DefaultPage = "Page";
    private const string DefaultOf = "of {0}";
    private const string DefaultItemsPerPage = "items per page";
    private const string DefaultFirst = "Go to the first page";
    private const string DefaultPrevious = "Go to the previous page";
    private const string DefaultNext = "Go to the next page";
    private const string DefaultLast = "Go to the last page";
    private const string DefaultRefresh = "Refresh";
    private const string DefaultMorePages = "More pages";
    private const string DefaultPageButtonLabel = "Page {0}";

    public PageableMessages()
    {
      this.Display = Messages.Pager_Display;
      this.Empty = Messages.Pager_Empty;
      this.Page = Messages.Pager_Page;
      this.Of = Messages.Pager_Of;
      this.ItemsPerPage = Messages.Pager_ItemsPerPage;
      this.First = Messages.Pager_First;
      this.Previous = Messages.Pager_Previous;
      this.Next = Messages.Pager_Next;
      this.Last = Messages.Pager_Last;
      this.Refresh = Messages.Pager_Refresh;
      this.MorePages = Messages.Pager_MorePages;
      this.PageButtonLabel = Messages.Pager_PageButtonLabel;
    }

    public string Display { get; set; }

    public string Empty { get; set; }

    public string Page { get; set; }

    public string Of { get; set; }

    public string ItemsPerPage { get; set; }

    public string First { get; set; }

    public string Previous { get; set; }

    public string Next { get; set; }

    public string Last { get; set; }

    public string Refresh { get; set; }

    public string MorePages { get; set; }

    public string PageButtonLabel { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Display != "{0} - {1} of {2} items")
        json["display"] = (object) this.Display;
      if (this.Empty != "No items to display")
        json["empty"] = (object) this.Empty;
      if (this.Page != "Page")
        json["page"] = (object) this.Page;
      if (this.Of != "of {0}")
        json["of"] = (object) this.Of;
      if (this.ItemsPerPage != "items per page")
        json["itemsPerPage"] = (object) this.ItemsPerPage;
      if (this.First != "Go to the first page")
        json["first"] = (object) this.First;
      if (this.Previous != "Go to the previous page")
        json["previous"] = (object) this.Previous;
      if (this.Next != "Go to the next page")
        json["next"] = (object) this.Next;
      if (this.Last != "Go to the last page")
        json["last"] = (object) this.Last;
      if (this.Refresh != "Refresh")
        json["refresh"] = (object) this.Refresh;
      if (this.MorePages != "More pages")
        json["morePages"] = (object) this.MorePages;
      if (!(this.PageButtonLabel != "Page {0}"))
        return;
      json["pageButtonLabel"] = (object) this.PageButtonLabel;
    }
  }
}
