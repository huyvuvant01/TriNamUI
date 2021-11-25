// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SkeletonContainerGridSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class SkeletonContainerGridSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? Columns { get; set; }

    public SkeletonContainerGridGapSettings Gap { get; } = new SkeletonContainerGridGapSettings();

    public List<SkeletonContainerGridSettingsItem> Items { get; set; } = new List<SkeletonContainerGridSettingsItem>();

    public double? Rows { get; set; }

    public SkeletonContainer SkeletonContainer { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Columns.HasValue)
        dictionary["columns"] = (object) this.Columns;
      Dictionary<string, object> source1 = this.Gap.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["gap"] = (object) source1;
      IEnumerable<Dictionary<string, object>> source2 = this.Items.Select<SkeletonContainerGridSettingsItem, Dictionary<string, object>>((Func<SkeletonContainerGridSettingsItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source2.Any<Dictionary<string, object>>())
        dictionary["items"] = (object) source2;
      if (this.Rows.HasValue)
        dictionary["rows"] = (object) this.Rows;
      return dictionary;
    }
  }
}
