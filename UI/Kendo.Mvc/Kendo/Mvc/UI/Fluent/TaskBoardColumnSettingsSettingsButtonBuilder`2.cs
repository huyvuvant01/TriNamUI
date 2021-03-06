// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardColumnSettingsSettingsButtonBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardColumnSettingsSettingsButtonBuilder<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardColumnSettingsSettingsButtonBuilder(
      TaskBoardColumnSettingsSettingsButton<TCard, TColumn> container)
    {
      this.Container = container;
    }

    protected TaskBoardColumnSettingsSettingsButton<TCard, TColumn> Container { get; private set; }

    public TaskBoardColumnSettingsSettingsButtonBuilder<TCard, TColumn> Name(
      string value)
    {
      this.Container.Name = value;
      return this;
    }

    public TaskBoardColumnSettingsSettingsButtonBuilder<TCard, TColumn> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public TaskBoardColumnSettingsSettingsButtonBuilder<TCard, TColumn> Icon(
      string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public TaskBoardColumnSettingsSettingsButtonBuilder<TCard, TColumn> SpriteCssClass(
      string value)
    {
      this.Container.SpriteCssClass = value;
      return this;
    }

    public TaskBoardColumnSettingsSettingsButtonBuilder<TCard, TColumn> Command(
      string value)
    {
      this.Container.Command = value;
      return this;
    }

    public TaskBoardColumnSettingsSettingsButtonBuilder<TCard, TColumn> Options(
      string value)
    {
      this.Container.Options = value;
      return this;
    }
  }
}
