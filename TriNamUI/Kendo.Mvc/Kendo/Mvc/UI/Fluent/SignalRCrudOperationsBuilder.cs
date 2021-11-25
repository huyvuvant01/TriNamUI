// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SignalRCrudOperationsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SignalRCrudOperationsBuilder : 
    SignalRCrudOperationsBuilderBase<SignalRCrudOperationsBuilder>,
    IHideObjectMembers
  {
    public SignalRCrudOperationsBuilder(IDictionary<string, object> crudOperation)
      : base(crudOperation)
    {
    }

    public SignalRCrudOperationsBuilder Update(string method)
    {
      this.crudOperation.Add("update", (object) method);
      return this;
    }

    public SignalRCrudOperationsBuilder Create(string method)
    {
      this.crudOperation.Add("create", (object) method);
      return this;
    }

    public SignalRCrudOperationsBuilder Destroy(string method)
    {
      this.crudOperation.Add("destroy", (object) method);
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
