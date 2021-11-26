// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.IGridForeignKeyColumn
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public interface IGridForeignKeyColumn : IGridBoundColumn, IGridColumn
  {
    SelectList Data { get; set; }

    Action<IDictionary<string, object>, object> SerializeSelectList { get; }

    string DataValueField { get; set; }

    string DataTextField { get; set; }

    DataSource DataSource { get; set; }

    bool UseServerEditor { get; set; }
  }
}
