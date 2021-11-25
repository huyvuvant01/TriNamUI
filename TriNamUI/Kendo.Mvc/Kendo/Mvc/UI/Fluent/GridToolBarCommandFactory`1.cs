// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridToolBarCommandFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridToolBarCommandFactory<T> : IHideObjectMembers where T : class
  {
    private readonly GridToolBarSettings settings;
    private readonly Grid<T> grid;

    public GridToolBarCommandFactory(GridToolBarSettings settings, Grid<T> grid)
    {
      this.settings = settings;
      this.grid = grid;
    }

    public GridToolBarCommandBuilder Create()
    {
      GridToolBarCreateCommand barCreateCommand = new GridToolBarCreateCommand();
      this.settings.Commands.Add((GridActionCommandBase) barCreateCommand);
      this.grid.Editable.Enabled = true;
      return new GridToolBarCommandBuilder((GridActionCommandBase) barCreateCommand);
    }

    public GridToolBarCommandBuilder Excel()
    {
      GridToolBarExcelCommand toolBarExcelCommand = new GridToolBarExcelCommand();
      this.settings.Commands.Add((GridActionCommandBase) toolBarExcelCommand);
      return new GridToolBarCommandBuilder((GridActionCommandBase) toolBarExcelCommand);
    }

    public GridToolBarCommandBuilder Pdf()
    {
      GridToolBarPdfCommand toolBarPdfCommand = new GridToolBarPdfCommand();
      this.settings.Commands.Add((GridActionCommandBase) toolBarPdfCommand);
      return new GridToolBarCommandBuilder((GridActionCommandBase) toolBarPdfCommand);
    }

    public GridToolBarSaveCommandBuilder Save()
    {
      GridToolBarSaveCommand toolBarSaveCommand = new GridToolBarSaveCommand();
      this.settings.Commands.Add((GridActionCommandBase) toolBarSaveCommand);
      this.settings.Commands.Add((GridActionCommandBase) new GridToolBarCancelCommand(toolBarSaveCommand));
      this.grid.Editable.Enabled = true;
      return new GridToolBarSaveCommandBuilder(toolBarSaveCommand);
    }

    public GridToolBarCustomCommandBuilder Custom()
    {
      GridToolBarCustomCommand command = new GridToolBarCustomCommand();
      this.settings.Commands.Add((GridActionCommandBase) command);
      return new GridToolBarCustomCommandBuilder(command);
    }

    public GridToolBarSearchCommandBuilder Search()
    {
      GridToolBarSearchCommand command = new GridToolBarSearchCommand();
      command.Name = nameof (Search);
      this.settings.Commands.Add((GridActionCommandBase) command);
      return new GridToolBarSearchCommandBuilder(command);
    }

    public void ClientTemplate(string template) => this.settings.ClientTemplate = template;

    public void ClientTemplateId(string template) => this.settings.ClientTemplateId = template;

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
