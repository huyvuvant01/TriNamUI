// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CrudOperation
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
  public class CrudOperation : JsonObject, INavigatable
  {
    private string routeName;
    private string controllerName;
    private string actionName;

    public CrudOperation()
    {
      this.RouteValues = new RouteValueDictionary();
      this.Data = new ClientHandlerDescriptor();
      this.Cache = true;
      this.Headers = (IDictionary<string, string>) new Dictionary<string, string>();
    }

    private string Encode(string value)
    {
      value = Regex.Replace(value, "(%20)*%23%3D(%20)*", "#=", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%23(%20)*", "#", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%24%7B(%20)*", "${", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);
      value = Regex.Replace(value, "(%20)*%7B0(%20)*", "{0", RegexOptions.IgnoreCase);
      return value;
    }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Url == null)
        return;
      json["url"] = (object) this.Encode(this.Url);
      if (this.DataType.HasValue())
        json["dataType"] = (object) this.DataType;
      if (this.Data.HasValue())
        json["data"] = (object) this.Data;
      if (this.Type.HasValue())
        json["type"] = (object) this.Type;
      if (!string.IsNullOrEmpty(this.ContentType))
        json["contentType"] = (object) this.ContentType;
      if (!this.Cache)
        json["cache"] = (object) this.Cache;
      if (!this.Headers.Any<KeyValuePair<string, string>>())
        return;
      json["headers"] = (object) this.Headers;
    }

    public string DataType { get; set; }

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

    public ClientHandlerDescriptor Data { get; set; }

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

    public string Type { get; set; }

    public string ContentType { get; set; }

    public bool Cache { get; set; }

    public IDictionary<string, string> Headers { get; set; }
  }
}
