// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridFilterableMessages
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class GridFilterableMessages : JsonObject
  {
    private const string DefaultInfo = "Show items with value that:";
    private const string DefaultTitle = "Show items with value that:";
    private const string DefaultIsTrue = "is true";
    private const string DefaultIsFalse = "is false";
    private const string DefaultFilter = "Filter";
    private const string DefaultClear = "Clear";
    private const string DefaultAnd = "And";
    private const string DefaultOr = "Or";
    private const string DefaultSelectValue = "-Select value-";
    private const string DefaultOperator = "Operator";
    private const string DefaultAdditionalOperator = "Additional operator";
    private const string DefaultValue = "Value";
    private const string DefaultAdditionalValue = "Additional value";
    private const string DefaultCheckAll = "Select All";
    private const string DefaultSearch = "Search";
    private const string DefaultSelectedItemsFormat = "{0} items selected";
    private const string DefaultLogic = "Filters logic";
    private const string DefaultButtonTitle = "{0} edit column settings";

    public GridFilterableMessages()
    {
      this.Info = Messages.Filter_Info;
      this.Title = Messages.Filter_Title;
      this.IsTrue = Messages.Filter_IsTrue;
      this.IsFalse = Messages.Filter_IsFalse;
      this.Filter = Messages.Filter_Filter;
      this.Clear = Messages.Filter_Clear;
      this.And = Messages.Filter_And;
      this.Or = Messages.Filter_Or;
      this.SelectValue = Messages.Filter_SelectValue;
      this.Operator = Messages.Filter_Operator;
      this.AdditionalOperator = Messages.Filter_AdditionalOperator;
      this.Value = Messages.Filter_Value;
      this.AdditionalValue = Messages.Filter_AdditionalValue;
      this.CheckAll = Messages.Grid_CheckAll;
      this.Search = Messages.Filter_Search;
      this.SelectedItemsFormat = Messages.Filter_SelectedItemsFormat;
      this.Logic = Messages.Filter_Logic;
      this.ButtonTitle = Messages.Filter_ButtonTitle;
    }

    public string Info { get; set; }

    public string Title { get; set; }

    public string IsTrue { get; set; }

    public string IsFalse { get; set; }

    public string Filter { get; set; }

    public string Clear { get; set; }

    public string And { get; set; }

    public string Or { get; set; }

    public string SelectValue { get; set; }

    public string Operator { get; set; }

    public string AdditionalOperator { get; set; }

    public string Value { get; set; }

    public string AdditionalValue { get; set; }

    public string Search { get; set; }

    public string CheckAll { get; set; }

    public string SelectedItemsFormat { get; set; }

    public string Logic { get; set; }

    public string ButtonTitle { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      if (this.Info != "Show items with value that:")
        json["info"] = (object) this.Info;
      if (this.Title != "Show items with value that:")
        json["title"] = (object) this.Title;
      if (this.IsTrue != "is true")
        json["isTrue"] = (object) this.IsTrue;
      if (this.IsFalse != "is false")
        json["isFalse"] = (object) this.IsFalse;
      if (this.Filter != "Filter")
        json["filter"] = (object) this.Filter;
      if (this.Clear != "Clear")
        json["clear"] = (object) this.Clear;
      if (this.And != "And")
        json["and"] = (object) this.And;
      if (this.Or != "Or")
        json["or"] = (object) this.Or;
      if (this.SelectValue != "-Select value-")
        json["selectValue"] = (object) this.SelectValue;
      if (this.Operator != "Operator")
        json["operator"] = (object) this.Operator;
      if (this.AdditionalOperator != "Additional operator")
        json["additionalOperator"] = (object) this.AdditionalOperator;
      if (this.Value != "Value")
        json["value"] = (object) this.Value;
      if (this.AdditionalValue != "Additional value")
        json["additionalValue"] = (object) this.AdditionalValue;
      if (this.CheckAll != "Select All")
        json["checkAll"] = (object) this.CheckAll;
      if (this.Search != "Search")
        json["search"] = (object) this.Search;
      if (this.SelectedItemsFormat != "{0} items selected")
        json["selectedItemsFormat"] = (object) this.SelectedItemsFormat;
      if (this.Logic != "Filters logic")
        json["logic"] = (object) this.Logic;
      if (!(this.ButtonTitle != "{0} edit column settings"))
        return;
      json["buttonTitle"] = (object) this.ButtonTitle;
    }
  }
}
