// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridToolBarCancelCommand
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridToolBarCancelCommand : GridActionCommandBase
  {
    private GridToolBarSaveCommand parent;

    public GridToolBarCancelCommand(GridToolBarSaveCommand parent)
    {
      this.parent = parent;
      this.HtmlAttributes = parent.HtmlAttributes;
    }

    public override string Text
    {
      get => this.parent.CancelText;
      set => this.parent.CancelText = value;
    }

    public override string Name => "cancel";

    public override IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Add<string>("attr", this.HtmlAttributes.ToAttributeString(), new Func<bool>(((Enumerable) this.HtmlAttributes).Any<KeyValuePair<string, object>>)).Add<string>("text", this.Text, new Func<bool>(((StringExtensions) this.Text).HasValue)).Add("name", (object) this.Name);
      return (IDictionary<string, object>) instance;
    }
  }
}
