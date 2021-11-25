// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.AggregateResult
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Globalization;

namespace Kendo.Mvc.Infrastructure
{
  public class AggregateResult
  {
    private object aggregateValue;
    private int itemCount;
    private readonly AggregateFunction function;

    public AggregateResult(object value, int count, AggregateFunction function)
    {
      if (function == null)
        throw new ArgumentNullException(nameof (function));
      this.aggregateValue = value;
      this.itemCount = count;
      this.function = function;
    }

    public AggregateResult(AggregateFunction function)
      : this((object) null, function)
    {
    }

    public AggregateResult(object value, AggregateFunction function)
      : this(value, 0, function)
    {
    }

    public object Value
    {
      get => this.aggregateValue;
      internal set => this.aggregateValue = value;
    }

    public string Member => this.function.SourceField;

    public object FormattedValue => string.IsNullOrEmpty(this.function.ResultFormatString) ? this.aggregateValue : (object) string.Format((IFormatProvider) CultureInfo.CurrentCulture, this.function.ResultFormatString, this.aggregateValue);

    public int ItemCount
    {
      get => this.itemCount;
      set => this.itemCount = value;
    }

    public string Caption => this.function.Caption;

    public string FunctionName => this.function.FunctionName;

    public string AggregateMethodName => this.function.AggregateMethodName;

    public override string ToString() => this.Value != null ? this.Value.ToString() : base.ToString();

    public string Format(string format) => this.Value != null ? string.Format(format, this.Value) : this.ToString();
  }
}
