// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.JsonObject
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc
{
  public abstract class JsonObject
  {
    public IDictionary<string, object> ToJson()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      this.Serialize((IDictionary<string, object>) dictionary);
      return (IDictionary<string, object>) dictionary;
    }

    protected abstract void Serialize(IDictionary<string, object> json);
  }
}
