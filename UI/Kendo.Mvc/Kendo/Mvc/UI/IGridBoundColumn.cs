// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.IGridBoundColumn
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.UI
{
  public interface IGridBoundColumn : IGridColumn
  {
    string Format { get; set; }

    bool Groupable { get; set; }

    GridBoundColumnGroupableSettings GroupableSettings { get; set; }

    bool Filterable { get; set; }

    GridBoundColumnFilterableSettings FilterableSettings { get; set; }

    GridBoundColumnSortableSettings SortableSettings { get; set; }

    bool Sortable { get; set; }

    string Member { get; set; }

    Type MemberType { get; set; }

    object AdditionalViewData { get; set; }

    string EditorHtml { get; set; }

    string EditorTemplateName { get; set; }

    string ClientGroupHeaderTemplate { get; set; }

    string ClientGroupHeaderColumnTemplate { get; set; }

    string GetEditor(IHtmlHelper helper, HtmlEncoder encoder);

    ClientHandlerDescriptor Editable { get; set; }
  }
}
