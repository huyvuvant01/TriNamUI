// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridToolBarSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridToolBarSettings : JsonObject
  {
    public GridToolBarSettings(WidgetBase grid)
    {
      this.Commands = (IList<GridActionCommandBase>) new List<GridActionCommandBase>();
      this.Component = grid;
    }

    public WidgetBase Component { get; }

    public bool Enabled => this.Commands.Any<GridActionCommandBase>() || this.ClientTemplate.HasValue() || this.ClientTemplateId.HasValue();

    public IList<GridActionCommandBase> Commands { get; private set; }

    public string ClientTemplate { get; set; }

    public string ClientTemplateId { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      List<IDictionary<string, object>> commands = new List<IDictionary<string, object>>();
      this.Commands.Each<GridActionCommandBase>((Action<GridActionCommandBase>) (command => commands.Add(command.Serialize())));
      if (commands.Any<IDictionary<string, object>>() && !this.ClientTemplate.HasValue())
        json["commands"] = (object) commands;
      if (this.ClientTemplate.HasValue())
        json["template"] = (object) this.ClientTemplate;
      if (!this.ClientTemplateId.HasValue())
        return;
      string str = "#";
      if (this.Component.IsInClientTemplate)
        str = "\\" + str;
      json["template"] = (object) new ClientHandlerDescriptor()
      {
        HandlerName = ("kendo.template(jQuery('" + str + this.ClientTemplateId + "').html())")
      };
    }
  }
}
