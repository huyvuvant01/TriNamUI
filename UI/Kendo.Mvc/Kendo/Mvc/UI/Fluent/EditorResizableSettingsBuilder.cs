// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorResizableSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorResizableSettingsBuilder
  {
    public EditorResizableSettingsBuilder(EditorResizableSettings container) => this.Container = container;

    protected EditorResizableSettings Container { get; private set; }

    public EditorResizableSettingsBuilder Content(bool value)
    {
      this.Container.Content = new bool?(value);
      return this;
    }

    public EditorResizableSettingsBuilder Min(double value)
    {
      this.Container.Min = new double?(value);
      return this;
    }

    public EditorResizableSettingsBuilder Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public EditorResizableSettingsBuilder Toolbar(bool value)
    {
      this.Container.Toolbar = new bool?(value);
      return this;
    }
  }
}
