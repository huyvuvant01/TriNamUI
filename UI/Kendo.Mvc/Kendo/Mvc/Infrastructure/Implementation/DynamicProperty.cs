// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.DynamicProperty
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.Infrastructure.Implementation
{
  public class DynamicProperty
  {
    private string name;
    private Type type;

    public DynamicProperty(string name, Type type)
    {
      if (name == null)
        throw new ArgumentNullException(nameof (name));
      if (type == (Type) null)
        throw new ArgumentNullException(nameof (type));
      this.name = name;
      this.type = type;
    }

    public string Name => this.name;

    public Type Type => this.type;
  }
}
