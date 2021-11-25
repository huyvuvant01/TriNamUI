// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Diagram.Fluent.IDiagramConnection
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Diagram.Fluent
{
  internal interface IDiagramConnection
  {
    int From { get; set; }

    int To { get; set; }

    int FromX { get; set; }

    int FromY { get; set; }

    int ToY { get; set; }

    int ToX { get; set; }

    string Text { get; set; }

    string Type { get; set; }

    string FromConnector { get; set; }

    string ToConnector { get; set; }
  }
}
