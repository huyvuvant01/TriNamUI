// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MultiColumnComboBoxVirtualSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class MultiColumnComboBoxVirtualSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? ItemHeight { get; set; }

    public string MapValueTo { get; set; }

    public ClientHandlerDescriptor ValueMapper { get; set; }

    public bool? Enabled { get; set; }

    public MultiColumnComboBox MultiColumnComboBox { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.ItemHeight.HasValue)
        dictionary["itemHeight"] = (object) this.ItemHeight;
      string mapValueTo = this.MapValueTo;
      if ((mapValueTo != null ? (mapValueTo.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["mapValueTo"] = (object) this.MapValueTo;
      ClientHandlerDescriptor valueMapper = this.ValueMapper;
      if ((valueMapper != null ? (valueMapper.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["valueMapper"] = (object) this.ValueMapper;
      return dictionary;
    }
  }
}
