// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CalendarSelectionSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class CalendarSelectionSettings : INavigatable
  {
    private string routeName;
    private string controllerName;
    private string actionName;

    public CalendarSelectionSettings()
    {
      this.RouteValues = new RouteValueDictionary();
      this.Dates = (IList<DateTime>) new List<DateTime>();
    }

    public IList<DateTime> Dates { get; set; }

    public string ActionName
    {
      get => this.actionName;
      set
      {
        this.actionName = value;
        this.routeName = (string) null;
      }
    }

    public string ControllerName
    {
      get => this.controllerName;
      set
      {
        this.controllerName = value;
        this.routeName = (string) null;
      }
    }

    public RouteValueDictionary RouteValues { get; set; }

    public string RouteName
    {
      get => this.routeName;
      set
      {
        this.routeName = value;
        this.controllerName = this.actionName = (string) null;
      }
    }

    public string Url { get; set; }
  }
}
