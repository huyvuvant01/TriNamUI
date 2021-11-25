// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.AggregateDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kendo.Mvc
{
  public class AggregateDescriptor : IDescriptor
  {
    private readonly IDictionary<string, Func<AggregateFunction>> aggregateFactories;

    public AggregateDescriptor()
    {
      this.Aggregates = (ICollection<AggregateFunction>) new List<AggregateFunction>();
      this.aggregateFactories = (IDictionary<string, Func<AggregateFunction>>) new Dictionary<string, Func<AggregateFunction>>()
      {
        {
          "sum",
          (Func<AggregateFunction>) (() =>
          {
            return (AggregateFunction) new SumFunction()
            {
              SourceField = this.Member
            };
          })
        },
        {
          "count",
          (Func<AggregateFunction>) (() =>
          {
            return (AggregateFunction) new CountFunction()
            {
              SourceField = this.Member
            };
          })
        },
        {
          "average",
          (Func<AggregateFunction>) (() =>
          {
            return (AggregateFunction) new AverageFunction()
            {
              SourceField = this.Member
            };
          })
        },
        {
          "min",
          (Func<AggregateFunction>) (() =>
          {
            return (AggregateFunction) new MinFunction()
            {
              SourceField = this.Member
            };
          })
        },
        {
          "max",
          (Func<AggregateFunction>) (() =>
          {
            return (AggregateFunction) new MaxFunction()
            {
              SourceField = this.Member
            };
          })
        }
      };
    }

    public ICollection<AggregateFunction> Aggregates { get; private set; }

    public string Member { get; set; }

    public void Deserialize(string source)
    {
      string[] strArray = source.Split('-');
      if (!((IEnumerable<string>) strArray).Any<string>())
        return;
      this.Member = strArray[0];
      for (int index = 1; index < strArray.Length; ++index)
        this.DeserializeAggregate(strArray[index]);
    }

    private void DeserializeAggregate(string aggregate)
    {
      Func<AggregateFunction> func;
      if (!this.aggregateFactories.TryGetValue(aggregate, out func))
        return;
      this.Aggregates.Add(func());
    }

    public string Serialize()
    {
      StringBuilder stringBuilder = new StringBuilder(this.Member);
      foreach (string str in this.Aggregates.Select<AggregateFunction, string>((Func<AggregateFunction, string>) (aggregate => aggregate.FunctionName.Split('_')[0].ToLowerInvariant())))
      {
        stringBuilder.Append("-");
        stringBuilder.Append(str);
      }
      return stringBuilder.ToString();
    }
  }
}
