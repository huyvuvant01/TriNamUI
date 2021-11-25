// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DependencyTypeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class DependencyTypeExtensions
  {
    internal static string Serialize(this DependencyType value)
    {
      switch (value)
      {
        case DependencyType.FinishFinish:
          return "finishFinish";
        case DependencyType.FinishStart:
          return "finishStart";
        case DependencyType.StartFinish:
          return "startFinish";
        case DependencyType.StartStart:
          return "startStart";
        default:
          return value.ToString();
      }
    }
  }
}
