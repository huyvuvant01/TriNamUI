// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WindowActionsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class WindowActionsBuilder
  {
    private readonly IWindowButtonsContainer container;

    public WindowActionsBuilder(IWindowButtonsContainer container) => this.container = container;

    public WindowActionsBuilder Close() => this.AddButton(nameof (Close), "k-i-close");

    public WindowActionsBuilder Maximize() => this.AddButton(nameof (Maximize), "k-i-maximize");

    public WindowActionsBuilder Minimize() => this.AddButton(nameof (Minimize), "k-i-minimize");

    public WindowActionsBuilder Refresh() => this.AddButton(nameof (Refresh), "k-i-refresh");

    public WindowActionsBuilder Pin() => this.AddButton(nameof (Pin), "k-i-pin");

    public WindowActionsBuilder Custom(string actionName) => this.AddButton(actionName, "k-i-custom");

    public WindowActionsBuilder Clear() => this.ClearButtons();

    private WindowActionsBuilder AddButton(string name, string cssClass)
    {
      this.container.Container.Add((IWindowButton) new HeaderButton()
      {
        Name = name,
        CssClass = cssClass
      });
      return this;
    }

    private WindowActionsBuilder ClearButtons()
    {
      this.container.Container.Clear();
      return this;
    }
  }
}
