// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.IHideObjectMembers
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.ComponentModel;

namespace Kendo.Mvc
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public interface IHideObjectMembers
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    bool Equals(object value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    int GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    Type GetType();

    [EditorBrowsable(EditorBrowsableState.Never)]
    string ToString();
  }
}
