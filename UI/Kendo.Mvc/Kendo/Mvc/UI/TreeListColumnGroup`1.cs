// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeListColumnGroup`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TreeListColumnGroup<T> : TreeListColumn<T>, ITreeListColumnGroup<T>
    where T : class
  {
    public TreeListColumnGroup() => this.Columns = new List<TreeListColumn<T>>();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      IEnumerable<Dictionary<string, object>> source = this.Columns.OfType<TreeListColumn<T>>().Select<TreeListColumn<T>, Dictionary<string, object>>((Func<TreeListColumn<T>, Dictionary<string, object>>) (c => c.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["columns"] = (object) source;
      return dictionary;
    }

    public List<TreeListColumn<T>> Columns { get; private set; }
  }
}
