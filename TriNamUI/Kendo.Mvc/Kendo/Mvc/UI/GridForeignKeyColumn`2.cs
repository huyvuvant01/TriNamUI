// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GridForeignKeyColumn`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure.Implementation.Expressions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI
{
  public class GridForeignKeyColumn<TModel, TValue> : 
    GridBoundColumn<TModel, TValue>,
    IGridForeignKeyColumn,
    IGridBoundColumn,
    IGridColumn
    where TModel : class
  {
    public GridForeignKeyColumn(
      Grid<TModel> grid,
      Expression<Func<TModel, TValue>> expression,
      SelectList data)
      : base(grid, expression)
    {
      this.EditorTemplateName = "GridForeignKey";
      this.Data = data;
    }

    public GridForeignKeyColumn(Grid<TModel> grid, Expression<Func<TModel, TValue>> expression)
      : base(grid, expression)
    {
      this.DataSource = new DataSource(this.Grid.ModelMetadataProvider);
      this.DataSource.Transport.SerializeEmptyPrefix = false;
      this.DataSource.Schema.Data = "";
      this.DataSource.Schema.Total = "";
      this.DataSource.Schema.Errors = "";
    }

    public SelectList Data { get; set; }

    public string DataValueField { get; set; }

    public string DataTextField { get; set; }

    public DataSource DataSource { get; set; }

    public bool UseServerEditor { get; set; }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      if (this.DataSource != null)
      {
        if (string.IsNullOrEmpty(this.DataSource.Transport.Read.Url))
        {
          DataSourceType? type = this.DataSource.Type;
          DataSourceType dataSourceType = DataSourceType.Custom;
          if (!(type.GetValueOrDefault() == dataSourceType & type.HasValue) || this.DataSource.CustomTransport == null)
            goto label_4;
        }
        json["dataSource"] = (object) this.DataSource.ToJson();
      }
label_4:
      if (!string.IsNullOrEmpty(this.DataValueField))
        json["dataValueField"] = (object) this.DataValueField;
      if (!string.IsNullOrEmpty(this.DataValueField))
        json["dataTextField"] = (object) this.DataTextField;
      if (this.Data == null)
        return;
      json["values"] = (object) this.Data.Select(i => new
      {
        text = i.Text,
        value = i.Value
      });
    }

    protected override void AppendAdditionalViewData(
      IDictionary<string, object> viewData,
      object dataItem)
    {
      if (this.DataSource != null || this.Data == null)
        return;
      object selectedValue = this.Data.Any<SelectListItem>((Func<SelectListItem, bool>) (i => i.Selected)) ? this.Data.SelectedValue : (object) ((Expression<Func<TModel, TValue>>) Expression.Lambda(typeof (Func<TModel, TValue>), ExpressionFactory.LiftMemberAccessToNull(this.Expression.Body), (IEnumerable<ParameterExpression>) this.Expression.Parameters)).Compile()((TModel) dataItem);
      viewData[this.Member + "_Data"] = (object) new SelectList(this.Data.Items, this.Data.DataValueField, this.Data.DataTextField, selectedValue);
    }

    public Action<IDictionary<string, object>, object> SerializeSelectList => new Action<IDictionary<string, object>, object>(((GridBoundColumn<TModel, TValue>) this).AppendAdditionalViewData);
  }
}
