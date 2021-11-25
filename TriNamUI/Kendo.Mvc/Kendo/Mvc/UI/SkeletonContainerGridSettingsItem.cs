// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SkeletonContainerGridSettingsItem
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class SkeletonContainerGridSettingsItem
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? ColStart { get; set; }

    public double? ColSpan { get; set; }

    public double? RowStart { get; set; }

    public double? RowSpan { get; set; }

    public SkeletonContainerItemShape? Shape { get; set; }

    public SkeletonContainer SkeletonContainer { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.ColStart.HasValue)
        dictionary1["colStart"] = (object) this.ColStart;
      if (this.ColSpan.HasValue)
        dictionary1["colSpan"] = (object) this.ColSpan;
      if (this.RowStart.HasValue)
        dictionary1["rowStart"] = (object) this.RowStart;
      if (this.RowSpan.HasValue)
        dictionary1["rowSpan"] = (object) this.RowSpan;
      if (this.Shape.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        SkeletonContainerItemShape? shape = this.Shape;
        ref SkeletonContainerItemShape? local = ref shape;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["shape"] = (object) str;
      }
      return dictionary1;
    }
  }
}
