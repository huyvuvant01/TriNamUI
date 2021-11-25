// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DropDownExtentions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  internal static class DropDownExtentions
  {
    internal static string SelectedValue(this IEnumerable<SelectListItem> source)
    {
      SelectListItem selectListItem = source.Where<SelectListItem>((Func<SelectListItem, bool>) (item => item.Selected)).FirstOrDefault<SelectListItem>();
      return selectListItem != null ? selectListItem.Value ?? selectListItem.Text : (string) null;
    }
  }
}
