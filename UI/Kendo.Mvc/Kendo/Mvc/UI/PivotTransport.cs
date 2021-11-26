// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotTransport
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class PivotTransport : Transport
  {
    public PivotTransport()
    {
      this.Connection = new PivotTransportConnection();
      this.Discover = new CrudOperation();
      this.FunctionDiscover = new ClientHandlerDescriptor();
    }

    public CrudOperation Discover { get; private set; }

    public IDictionary<string, object> CustomDiscover { get; set; }

    public ClientHandlerDescriptor FunctionDiscover { get; set; }

    public PivotTransportConnection Connection { get; private set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      IDictionary<string, object> json1 = this.Connection.ToJson();
      if (json1.Keys.Any<string>())
        json["connection"] = (object) json1;
      if (this.CustomDiscover != null)
        json["discover"] = (object) this.CustomDiscover;
      else if (this.FunctionDiscover.HasValue())
      {
        json["discover"] = (object) this.FunctionDiscover;
      }
      else
      {
        IDictionary<string, object> json2 = this.Discover.ToJson();
        if (!json2.Keys.Any<string>())
          return;
        json["discover"] = (object) json2;
      }
    }
  }
}
