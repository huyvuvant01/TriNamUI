// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorFileBrowserOperation
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
  public class EditorFileBrowserOperation : INavigatable
  {
    private string routeName;
    private string controllerName;
    private string actionName;

    public EditorFileBrowserOperation()
    {
      this.RouteValues = new RouteValueDictionary();
      this.Data = new ClientHandlerDescriptor();
    }

    private string Encode(string value)
    {
      value = Regex.Replace(value, "(%20)*%23%3D(%20)*", "#=", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%23(%20)*", "#", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%24%7B(%20)*", "${", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);
      return value;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Url != null)
        dictionary["url"] = (object) this.Encode(this.Url);
      if (this.Data.HasValue())
        dictionary["data"] = (object) this.Data;
      return dictionary;
    }

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

    public ClientHandlerDescriptor Data { get; set; }
  }
}
