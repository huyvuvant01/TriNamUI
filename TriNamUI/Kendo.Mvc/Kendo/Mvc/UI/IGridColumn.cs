// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.IGridColumn
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public interface IGridColumn
  {
    bool IsLast { get; }

    string ClientTemplate { get; set; }

    string ClientTemplateId { get; set; }

    string ClientFooterTemplate { get; set; }

    string ClientGroupFooterTemplate { get; set; }

    bool Encoded { get; set; }

    string ClientHeaderTemplate { get; set; }

    IDictionary<string, object> HeaderHtmlAttributes { get; }

    IDictionary<string, object> FooterHtmlAttributes { get; }

    bool Hidden { get; set; }

    bool Locked { get; set; }

    bool Lockable { get; set; }

    bool Sticky { get; set; }

    bool Stickable { get; set; }

    bool IncludeInMenu { get; set; }

    IDictionary<string, object> HtmlAttributes { get; }

    string Title { get; set; }

    bool Visible { get; set; }

    string Media { get; set; }

    int MinScreenWidth { get; set; }

    int MinResizableWidth { get; set; }

    string Width { get; set; }

    GridColumnExportableSettings Exportable { get; set; }
  }
}
