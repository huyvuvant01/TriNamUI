// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WindowDraggableSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class WindowDraggableSettingsBuilder
  {
    public WindowDraggableSettingsBuilder(WindowDraggableSettings container) => this.Container = container;

    protected WindowDraggableSettings Container { get; private set; }

    public WindowDraggableSettingsBuilder Containment(string value)
    {
      this.Container.Containment = value;
      return this;
    }

    public WindowDraggableSettingsBuilder Axis(string value)
    {
      this.Container.Axis = value;
      return this;
    }

    public WindowDraggableSettingsBuilder DragHandle(string value)
    {
      this.Container.DragHandle = value;
      return this;
    }
  }
}
