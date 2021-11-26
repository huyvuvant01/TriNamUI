// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridActionCommandBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public abstract class GridActionCommandBase : IGridActionCommand
  {
    public virtual string Name { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public virtual string Text { get; set; }

    public virtual string IconClass { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; set; }

    public ClientHandlerDescriptor Visible { get; set; }

    public GridActionCommandBase()
    {
      this.HtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.Visible = new ClientHandlerDescriptor();
    }

    public virtual IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Add<string>("attr", this.HtmlAttributes.ToAttributeString(), new Func<bool>(((Enumerable) this.HtmlAttributes).Any<KeyValuePair<string, object>>)).Add<string>("text", this.Text, new Func<bool>(((StringExtensions) this.Text).HasValue)).Add<ClientHandlerDescriptor>("visible", this.Visible, new Func<bool>(this.Visible.HasValue)).Add("name", (object) this.Name);
      if (this.IconClass != null)
        instance.Add("iconClass", (object) this.IconClass);
      if (!string.IsNullOrEmpty(this.TemplateId))
        instance["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('#{0}').html()", (object) this.TemplateId)
        };
      else if (!string.IsNullOrEmpty(this.Template))
        instance["template"] = (object) this.Template;
      return (IDictionary<string, object>) instance;
    }
  }
}
