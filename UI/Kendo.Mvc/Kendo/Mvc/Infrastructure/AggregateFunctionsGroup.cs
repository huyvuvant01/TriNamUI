// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.AggregateFunctionsGroup
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;


#nullable enable
namespace Kendo.Mvc.Infrastructure
{
  [KnownType(typeof (AggregateFunctionsGroup))]
  public class AggregateFunctionsGroup : Group
  {
    [JsonIgnore]
    public 
    #nullable disable
    object AggregateFunctionsProjection { get; set; }

    public IDictionary<string, object> Aggregates => this.AggregateFunctionsProjection != null ? (IDictionary<string, object>) AggregateFunctionsGroup.ExtractPropertyValues(this.AggregateFunctionsProjection).GroupBy<KeyValuePair<string, object>, string>((Func<KeyValuePair<string, object>, string>) (entry =>
    {
      int num = entry.Key.IndexOf('_');
      return entry.Key.Substring(num + 1);
    })).ToDictionary<IGrouping<string, KeyValuePair<string, object>>, string, object>((Func<IGrouping<string, KeyValuePair<string, object>>, string>) (g => g.Key), (Func<IGrouping<string, KeyValuePair<string, object>>, object>) (g => (object) g.ToDictionary<KeyValuePair<string, object>, string, object>((Func<KeyValuePair<string, object>, string>) (entry => ((IEnumerable<string>) entry.Key.Split('_')).First<string>()), (Func<KeyValuePair<string, object>, object>) (entry => entry.Value)))) : (IDictionary<string, object>) new Dictionary<string, object>();

    public AggregateResultCollection GetAggregateResults(
      IEnumerable<AggregateFunction> functions)
    {
      if (functions == null)
        throw new ArgumentNullException(nameof (functions));
      AggregateResultCollection instance = new AggregateResultCollection();
      if (this.AggregateFunctionsProjection == null)
        return instance;
      IDictionary<string, object> propertyValues = AggregateFunctionsGroup.ExtractPropertyValues(this.AggregateFunctionsProjection);
      IEnumerable<AggregateResult> forPropertyValues = AggregateFunctionsGroup.CreateAggregateResultsForPropertyValues(functions, propertyValues);
      instance.AddRange<AggregateResult>(forPropertyValues);
      return instance;
    }

    private static IEnumerable<AggregateResult> CreateAggregateResultsForPropertyValues(
      IEnumerable<AggregateFunction> functions,
      IDictionary<string, object> propertyValues)
    {
      foreach (AggregateFunction function in functions)
      {
        string functionName = function.FunctionName;
        if (propertyValues.ContainsKey(functionName))
          yield return new AggregateResult(propertyValues[functionName], function);
      }
    }

    private static IDictionary<string, object> ExtractPropertyValues(object obj) => (IDictionary<string, object>) ((IEnumerable<PropertyInfo>) obj.GetType().GetProperties()).Select(p => new
    {
      p = p,
      value = p.GetValue(obj, (object[]) null)
    }).Select(_param1 => new
    {
      Key = _param1.p.Name,
      Value = _param1.value
    }).ToDictionary(pair => pair.Key, pair => pair.Value);
  }
}
