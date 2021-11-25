// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridFilterableOperators
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridFilterableOperators : JsonObject
  {
    public GridFilterableOperators()
    {
      this.Strings = new StringOperators();
      this.Numbers = new NumberOperators();
      this.Dates = new DateOperators();
      this.Enums = new EnumOperators();
    }

    public StringOperators Strings { get; private set; }

    public NumberOperators Numbers { get; private set; }

    public DateOperators Dates { get; private set; }

    public EnumOperators Enums { get; private set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      IDictionary<string, object> json1 = this.Strings.ToJson();
      if (json1.Any<KeyValuePair<string, object>>())
        json["string"] = (object) json1;
      IDictionary<string, object> json2 = this.Numbers.ToJson();
      if (json2.Any<KeyValuePair<string, object>>())
        json["number"] = (object) json2;
      IDictionary<string, object> json3 = this.Dates.ToJson();
      if (json3.Any<KeyValuePair<string, object>>())
        json["date"] = (object) json3;
      IDictionary<string, object> json4 = this.Enums.ToJson();
      if (!json4.Any<KeyValuePair<string, object>>())
        return;
      json["enums"] = (object) json4;
    }

    internal GridFilterableOperators Clone() => new GridFilterableOperators()
    {
      Strings = this.Strings.Clone<StringOperators>(),
      Numbers = this.Numbers.Clone<NumberOperators>(),
      Dates = this.Dates.Clone<DateOperators>(),
      Enums = this.Enums.Clone<EnumOperators>()
    };

    public override bool Equals(object obj) => obj is GridFilterableOperators other && this.Equals(other);

    public virtual bool Equals(GridFilterableOperators other)
    {
      if (other == null)
        return false;
      if (this == other)
        return true;
      return this.Strings.Operators.SequenceEqual<KeyValuePair<string, string>>((IEnumerable<KeyValuePair<string, string>>) other.Strings.Operators) && this.Numbers.Operators.SequenceEqual<KeyValuePair<string, string>>((IEnumerable<KeyValuePair<string, string>>) other.Numbers.Operators) && this.Dates.Operators.SequenceEqual<KeyValuePair<string, string>>((IEnumerable<KeyValuePair<string, string>>) other.Dates.Operators) && this.Enums.Operators.SequenceEqual<KeyValuePair<string, string>>((IEnumerable<KeyValuePair<string, string>>) other.Enums.Operators);
    }

    public override int GetHashCode() => ((this.Strings.Operators.GetHashCode() * 397 ^ this.Numbers.GetHashCode()) * 397 ^ this.Dates.GetHashCode()) * 397 ^ this.Enums.GetHashCode();
  }
}
