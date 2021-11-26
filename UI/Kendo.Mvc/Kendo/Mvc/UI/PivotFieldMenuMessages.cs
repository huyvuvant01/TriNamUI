// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.PivotFieldMenuMessages
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class PivotFieldMenuMessages : JsonObject
  {
    private const string DefaultInfo = "Show items with value that:";
    private const string DefaultFilterFields = "Fields Filter";
    private const string DefaultFilter = "Filter";
    private const string DefaultInclude = "Include Fields...";
    private const string DefaultTitle = "Fields to include";
    private const string DefaultClear = "Clear";
    private const string DefaultOk = "Ok";
    private const string DefaultCancel = "Cancel";

    public PivotFieldMenuMessages()
    {
      this.Info = Messages.PivotFieldMenu_Info;
      this.FilterFields = Messages.PivotFieldMenu_FilterFields;
      this.Filter = Messages.PivotFieldMenu_Filter;
      this.Include = Messages.PivotFieldMenu_Include;
      this.Title = Messages.PivotFieldMenu_Title;
      this.Clear = Messages.PivotFieldMenu_Clear;
      this.Ok = Messages.PivotFieldMenu_Ok;
      this.Cancel = Messages.PivotFieldMenu_Cancel;
      this.Operators = new StringOperators();
    }

    public string Info { get; set; }

    public string FilterFields { get; set; }

    public string Filter { get; set; }

    public string Include { get; set; }

    public string Title { get; set; }

    public string Clear { get; set; }

    public string Ok { get; set; }

    public string Cancel { get; set; }

    public StringOperators Operators { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Info != "Show items with value that:")
        json["info"] = (object) this.Info;
      if (this.FilterFields != "Fields Filter")
        json["filterFields"] = (object) this.FilterFields;
      if (this.Filter != "Filter")
        json["filter"] = (object) this.Filter;
      if (this.Include != "Include Fields...")
        json["include"] = (object) this.Include;
      if (this.Title != "Fields to include")
        json["title"] = (object) this.Title;
      if (this.Clear != "Clear")
        json["clear"] = (object) this.Clear;
      if (this.Ok != "Ok")
        json["ok"] = (object) this.Ok;
      if (this.Cancel != "Cancel")
        json["cancel"] = (object) this.Cancel;
      IDictionary<string, object> json1 = this.Operators.ToJson();
      if (json1.Count <= 0)
        return;
      json["operators"] = (object) json1;
    }
  }
}
