// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ModelFieldDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI
{
  public class ModelFieldDescriptor
  {
    public ModelFieldDescriptor()
    {
      this.IsEditable = true;
      this.Parse = new ClientHandlerDescriptor();
    }

    public Type MemberType { get; set; }

    public bool IsEditable { get; set; }

    public object DefaultValue { get; set; }

    public string Member { get; set; }

    public string From { get; set; }

    public bool? IsNullable { get; set; }

    public ClientHandlerDescriptor Parse { get; set; }
  }
}
