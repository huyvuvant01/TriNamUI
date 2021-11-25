// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TransportSignalR
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class TransportSignalR : JsonObject
  {
    public TransportSignalR()
    {
      this.Hub = new ClientHandlerDescriptor();
      this.Promise = new ClientHandlerDescriptor();
      this.Server = new Dictionary<string, object>();
      this.Client = new Dictionary<string, object>();
    }

    public ClientHandlerDescriptor Hub { get; set; }

    public ClientHandlerDescriptor Promise { get; set; }

    public Dictionary<string, object> Server { get; set; }

    public Dictionary<string, object> Client { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Hub.HasValue())
        json["hub"] = (object) this.Hub;
      if (this.Promise.HasValue())
        json["promise"] = (object) this.Promise;
      if (this.Server.Keys.Any<string>())
        json["server"] = (object) this.Server;
      if (!this.Client.Keys.Any<string>())
        return;
      json["client"] = (object) this.Client;
    }
  }
}
