// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TaskBoardMessagesSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class TaskBoardMessagesSettingsBuilder<TCard, TColumn>
    where TCard : class
    where TColumn : class
  {
    public TaskBoardMessagesSettingsBuilder(
      TaskBoardMessagesSettings<TCard, TColumn> container)
    {
      this.Container = container;
    }

    protected TaskBoardMessagesSettings<TCard, TColumn> Container { get; private set; }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> Edit(
      string value)
    {
      this.Container.Edit = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> CreateNewCard(
      string value)
    {
      this.Container.CreateNewCard = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> Create(
      string value)
    {
      this.Container.Create = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> Search(
      string value)
    {
      this.Container.Search = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> PreviewCard(
      string value)
    {
      this.Container.PreviewCard = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> AddCard(
      string value)
    {
      this.Container.AddCard = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> EditCard(
      string value)
    {
      this.Container.EditCard = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> DeleteCard(
      string value)
    {
      this.Container.DeleteCard = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> AddColumn(
      string value)
    {
      this.Container.AddColumn = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> EditColumn(
      string value)
    {
      this.Container.EditColumn = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> DeleteColumn(
      string value)
    {
      this.Container.DeleteColumn = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> Close(
      string value)
    {
      this.Container.Close = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> Cancel(
      string value)
    {
      this.Container.Cancel = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> Delete(
      string value)
    {
      this.Container.Delete = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> SaveChanges(
      string value)
    {
      this.Container.SaveChanges = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> Description(
      string value)
    {
      this.Container.Description = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> NewColumn(
      string value)
    {
      this.Container.NewColumn = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> DeleteColumnConfirm(
      string value)
    {
      this.Container.DeleteColumnConfirm = value;
      return this;
    }

    public TaskBoardMessagesSettingsBuilder<TCard, TColumn> DeleteCardConfirm(
      string value)
    {
      this.Container.DeleteCardConfirm = value;
      return this;
    }
  }
}
