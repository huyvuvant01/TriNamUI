// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Effects
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Effects : JsonObject
  {
    public Effects(string name)
    {
      this.Name = name;
      this.Container = (IList<string>) new List<string>();
      this.Duration = 400;
    }

    protected string Name { get; set; }

    public IList<string> Container { get; private set; }

    public int Duration { get; set; }

    public bool Reverse { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Duration != 400)
        dictionary["duration"] = (object) this.Duration;
      if (this.Container.Any<string>())
        dictionary["effects"] = (object) string.Join(" ", (IEnumerable<string>) this.Container);
      if (this.Reverse)
        dictionary["reverse"] = (object) this.Reverse;
      if (!dictionary.Keys.Any<string>())
        return;
      json[this.Name] = (object) dictionary;
    }
  }
}
