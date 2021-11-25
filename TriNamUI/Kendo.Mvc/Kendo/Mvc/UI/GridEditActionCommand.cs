// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridEditActionCommand
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class GridEditActionCommand : GridActionCommandBase
  {
    private const string DefaultUpdateText = "Update";
    private const string DefaultEditText = "Edit";
    private const string DefaultCancelText = "Cancel";

    public GridEditActionCommand()
    {
      this.UpdateText = Messages.Grid_Update;
      this.Text = Messages.Grid_Edit;
      this.CancelText = Messages.Grid_Cancel;
    }

    public string UpdateText { get; set; }

    public string CancelText { get; set; }

    public string UpdateIconClass { get; set; }

    public string CancelIconClass { get; set; }

    public override string Name => "edit";

    public override IDictionary<string, object> Serialize()
    {
      IDictionary<string, object> dictionary1 = base.Serialize();
      Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
      Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
      dictionary2.Add<string>("cancel", this.CancelText, (Func<bool>) (() => this.CancelText.HasValue() && this.CancelText != "Cancel")).Add<string>("update", this.UpdateText, (Func<bool>) (() => this.UpdateText.HasValue() && this.UpdateText != "Update")).Add<string>("edit", this.Text, (Func<bool>) (() => this.Text.HasValue() && this.Text != "Edit"));
      if (dictionary2.Any<KeyValuePair<string, object>>())
        dictionary1["text"] = (object) dictionary2;
      dictionary3.Add<string>("cancel", this.CancelIconClass, (Func<bool>) (() => this.CancelIconClass.HasValue())).Add<string>("update", this.UpdateIconClass, (Func<bool>) (() => this.UpdateIconClass.HasValue())).Add<string>("edit", this.IconClass, (Func<bool>) (() => this.IconClass.HasValue()));
      if (dictionary3.Any<KeyValuePair<string, object>>())
        dictionary1["iconClass"] = (object) dictionary3;
      return dictionary1;
    }
  }
}
