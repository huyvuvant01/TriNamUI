// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WidgetFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class WidgetFactory<TModel>
  {
    private static readonly Regex StringFormatExpression = new Regex("(?<=\\{\\d:)(.)*(?=\\})", RegexOptions.Compiled);
    private const string MinimumValidator = "min";
    private const string MaximumValidator = "max";

    public virtual ActionSheetBuilder ActionSheet() => new ActionSheetBuilder(new Kendo.Mvc.UI.ActionSheet(this.HtmlHelper.ViewContext));

    public virtual AppBarBuilder AppBar() => new AppBarBuilder(new Kendo.Mvc.UI.AppBar(this.HtmlHelper.ViewContext));

    public virtual CircularGaugeBuilder CircularGauge() => new CircularGaugeBuilder(new Kendo.Mvc.UI.CircularGauge(this.HtmlHelper.ViewContext));

    public virtual AutoCompleteBuilder AutoComplete() => new AutoCompleteBuilder(new Kendo.Mvc.UI.AutoComplete(this.HtmlHelper.ViewContext));

    public virtual AutoCompleteBuilder AutoCompleteFor<TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TProperty>(expression);
      object model = modelExplorer.Model;
      return this.AutoComplete().Expression(this.GetExpressionName<TProperty>(expression)).Explorer(modelExplorer).Value(this.GetValue<TProperty>(expression));
    }

    public virtual BadgeBuilder Badge() => new BadgeBuilder(new Kendo.Mvc.UI.Badge(this.HtmlHelper.ViewContext));

    public virtual BarcodeBuilder Barcode() => new BarcodeBuilder(new Kendo.Mvc.UI.Barcode(this.HtmlHelper.ViewContext));

    public virtual BottomNavigationBuilder BottomNavigation() => new BottomNavigationBuilder(new Kendo.Mvc.UI.BottomNavigation(this.HtmlHelper.ViewContext));

    public virtual BreadcrumbBuilder Breadcrumb() => new BreadcrumbBuilder(new Kendo.Mvc.UI.Breadcrumb(this.HtmlHelper.ViewContext));

    public virtual ButtonBuilder Button() => new ButtonBuilder(new Kendo.Mvc.UI.Button(this.HtmlHelper.ViewContext));

    public virtual ButtonGroupBuilder ButtonGroup() => new ButtonGroupBuilder(new Kendo.Mvc.UI.ButtonGroup(this.HtmlHelper.ViewContext));

    public virtual CalendarBuilder Calendar() => new CalendarBuilder(new Kendo.Mvc.UI.Calendar(this.HtmlHelper.ViewContext));

    public virtual CaptchaBuilder Captcha() => new CaptchaBuilder(new Kendo.Mvc.UI.Captcha(this.HtmlHelper.ViewContext));

    public virtual CaptchaBuilder CaptchaFor<TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TProperty>(expression);
      return this.Captcha().Expression(this.GetExpressionName<TProperty>(expression)).Explorer(modelExplorer);
    }

    public virtual ChartBuilder<object> Chart() => new ChartBuilder<object>(new Kendo.Mvc.UI.Chart<object>(this.HtmlHelper.ViewContext));

    public virtual ChartBuilder<T> Chart<T>() where T : class => new ChartBuilder<T>(new Kendo.Mvc.UI.Chart<T>(this.HtmlHelper.ViewContext));

    public virtual ChartBuilder<T> Chart<T>(IEnumerable<T> data) where T : class
    {
      ChartBuilder<T> chartBuilder = this.Chart<T>();
      chartBuilder.Component.Data = data;
      return chartBuilder;
    }

    public virtual ChartBuilder<T> Chart<T>(string dataSourceViewDataKey) where T : class
    {
      ChartBuilder<T> chartBuilder = this.Chart<T>();
      chartBuilder.Component.Data = this.HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<T>;
      return chartBuilder;
    }

    public virtual ChatBuilder Chat() => new ChatBuilder(new Kendo.Mvc.UI.Chat(this.HtmlHelper.ViewContext));

    public virtual CheckBoxBuilder CheckBox() => new CheckBoxBuilder(new Kendo.Mvc.UI.CheckBox(this.HtmlHelper.ViewContext));

    public virtual CheckBoxBuilder CheckBoxFor<TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TProperty>(expression);
      object model = modelExplorer.Model;
      bool flag = false;
      if (model != null && model.GetType().IsPredefinedType())
        flag = Convert.ToBoolean(model);
      return this.CheckBox().Name(this.GetExpressionName<TProperty>(expression)).Explorer(modelExplorer).Checked(flag);
    }

    public virtual CheckBoxGroupBuilder CheckBoxGroup() => new CheckBoxGroupBuilder(new Kendo.Mvc.UI.CheckBoxGroup(this.HtmlHelper.ViewContext));

    public virtual CheckBoxGroupBuilder CheckBoxGroupFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      object model = modelExplorer.Model;
      return this.CheckBoxGroup().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Value(model as IEnumerable<string>);
    }

    public virtual ArcGaugeBuilder ArcGauge() => new ArcGaugeBuilder(new Kendo.Mvc.UI.ArcGauge(this.HtmlHelper.ViewContext));

    public virtual ColorPaletteBuilder ColorPalette() => new ColorPaletteBuilder(new Kendo.Mvc.UI.ColorPalette(this.HtmlHelper.ViewContext));

    public virtual ColorPickerBuilder ColorPicker() => new ColorPickerBuilder(new Kendo.Mvc.UI.ColorPicker(this.HtmlHelper.ViewContext));

    public virtual ColorPickerBuilder ColorPickerFor(
      Expression<Func<TModel, string>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<string>(expression);
      return this.ColorPicker().Expression(this.GetExpressionName<string>(expression)).Explorer(modelExplorer).Value(modelExplorer.Model as string);
    }

    public virtual ComboBoxBuilder ComboBox() => new ComboBoxBuilder(new Kendo.Mvc.UI.ComboBox(this.HtmlHelper.ViewContext));

    public virtual ComboBoxBuilder ComboBoxFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      object model = modelExplorer.Model;
      return this.ComboBox().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Value(this.GetValueWithEnum<TValue>(expression));
    }

    public virtual ContextMenuBuilder ContextMenu() => new ContextMenuBuilder(new Kendo.Mvc.UI.ContextMenu(this.HtmlHelper.ViewContext));

    public WidgetFactory(IHtmlHelper<TModel> htmlHelper) => this.HtmlHelper = htmlHelper;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public IHtmlHelper<TModel> HtmlHelper { get; set; }

    protected ModelExplorer GetModelExplorer<TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      return ExpressionMetadataProvider.FromLambdaExpression<TModel, TProperty>(expression, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider) ?? throw new InvalidOperationException("No model metadata: " + this.GetExpressionName<TProperty>(expression));
    }

    protected string GetExpressionName<TProperty>(Expression<Func<TModel, TProperty>> expression) => ExpressionHelper.GetExpressionText((LambdaExpression) expression, (ConcurrentDictionary<LambdaExpression, string>) null);

    private TValue? GetRangeValidationParameter<TValue>(ModelExplorer explorer, string parameter) where TValue : struct => explorer.Metadata.ValidatorMetadata.Where<object>((Func<object, bool>) (attr => attr is RangeAttribute)).FirstOrDefault<object>() is RangeAttribute rangeAttribute ? new TValue?((TValue) Convert.ChangeType(parameter == "min" ? rangeAttribute.Minimum : rangeAttribute.Maximum, typeof (TValue))) : new TValue?();

    private string ExtractEditFormat(string format) => string.IsNullOrEmpty(format) ? string.Empty : WidgetFactory<TModel>.StringFormatExpression.Match(format).ToString();

    public virtual HtmlString DeferredScripts(bool renderScriptTags = true)
    {
      IDictionary<object, object> items = this.HtmlHelper.ViewContext.HttpContext.Items;
      return items.ContainsKey((object) WidgetBase.DeferredScriptsKey) ? this.DeferredScripts(((IEnumerable<KeyValuePair<string, string>>) items[(object) WidgetBase.DeferredScriptsKey]).Select<KeyValuePair<string, string>, string>((Func<KeyValuePair<string, string>, string>) (kv => kv.Value)), renderScriptTags) : HtmlString.Empty;
    }

    private HtmlString DeferredScripts(IEnumerable<string> scripts, bool renderScriptTags)
    {
      StringBuilder stringBuilder = new StringBuilder();
      if (renderScriptTags)
        stringBuilder.Append("<script>");
      foreach (string script in scripts)
        stringBuilder.Append(script);
      if (renderScriptTags)
        stringBuilder.Append("</script>");
      return new HtmlString(stringBuilder.ToString());
    }

    public virtual HtmlString DeferredScriptsFor(string name, bool renderScriptTags = true)
    {
      IDictionary<object, object> items = this.HtmlHelper.ViewContext.HttpContext.Items;
      if (items.ContainsKey((object) WidgetBase.DeferredScriptsKey))
      {
        List<KeyValuePair<string, string>> source = (List<KeyValuePair<string, string>>) items[(object) WidgetBase.DeferredScriptsKey];
        if (source.Any<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (kv => kv.Key == name)))
          return this.DeferredScripts((IEnumerable<string>) new string[1]
          {
            source.First<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (kv => kv.Key == name)).Value
          }, renderScriptTags);
      }
      return HtmlString.Empty;
    }

    private string GetValue<TValue>(Expression<Func<TModel, TValue>> expression)
    {
      object model = this.GetModelExplorer<TValue>(expression).Model;
      return model != null && (model.GetType().IsPredefinedType() || model.GetType().IsEnumType()) ? Convert.ToString(model) : (string) null;
    }

    private string GetValueWithEnum<TValue>(Expression<Func<TModel, TValue>> expression)
    {
      object model = this.GetModelExplorer<TValue>(expression).Model;
      if (model != null)
      {
        if (model.GetType().IsPredefinedType())
          return Convert.ToString(model);
        if (model.GetType().IsEnumType())
          return Convert.ToString(Convert.ToInt32(model));
      }
      return (string) null;
    }

    public virtual DataSourceWidgetBuilder<T> DataSource<T>() where T : class => new DataSourceWidgetBuilder<T>(new DataSourceWidget<T>(this.HtmlHelper.ViewContext));

    public virtual DateInputBuilder DateInput() => new DateInputBuilder(new Kendo.Mvc.UI.DateInput(this.HtmlHelper.ViewContext));

    public virtual DateInputBuilder DateInputFor(
      Expression<Func<TModel, DateTime>> expression)
    {
      return this.DateInputOfTValueFor<DateTime>(expression);
    }

    public virtual DateInputBuilder DateInputFor(
      Expression<Func<TModel, DateTime?>> expression)
    {
      return this.DateInputOfTValueFor<DateTime?>(expression);
    }

    private DateInputBuilder DateInputOfTValueFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      DateInputBuilder dateInputBuilder = this.DateInput().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Format(this.ExtractEditFormat(modelExplorer.Metadata.EditFormatString)).Value(modelExplorer.Model as DateTime?);
      DateTime? validationParameter1 = this.GetRangeValidationParameter<DateTime>(modelExplorer, "min");
      if (validationParameter1.HasValue)
        dateInputBuilder.Min(validationParameter1.Value);
      DateTime? validationParameter2 = this.GetRangeValidationParameter<DateTime>(modelExplorer, "max");
      if (validationParameter2.HasValue)
        dateInputBuilder.Max(validationParameter2.Value);
      return dateInputBuilder;
    }

    public virtual DatePickerBuilder DatePicker() => new DatePickerBuilder(new Kendo.Mvc.UI.DatePicker(this.HtmlHelper.ViewContext));

    public virtual DatePickerBuilder DatePickerFor(
      Expression<Func<TModel, DateTime>> expression)
    {
      return this.DatePickerOfTValueFor<DateTime>(expression);
    }

    public virtual DatePickerBuilder DatePickerFor(
      Expression<Func<TModel, DateTime?>> expression)
    {
      return this.DatePickerOfTValueFor<DateTime?>(expression);
    }

    private DatePickerBuilder DatePickerOfTValueFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      DatePickerBuilder datePickerBuilder = this.DatePicker().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Format(this.ExtractEditFormat(modelExplorer.Metadata.EditFormatString)).Value(modelExplorer.Model as DateTime?);
      DateTime? validationParameter1 = this.GetRangeValidationParameter<DateTime>(modelExplorer, "min");
      if (validationParameter1.HasValue)
        datePickerBuilder.Min(validationParameter1.Value);
      DateTime? validationParameter2 = this.GetRangeValidationParameter<DateTime>(modelExplorer, "max");
      if (validationParameter2.HasValue)
        datePickerBuilder.Max(validationParameter2.Value);
      return datePickerBuilder;
    }

    public virtual DateRangePickerBuilder DateRangePicker() => new DateRangePickerBuilder(new Kendo.Mvc.UI.DateRangePicker(this.HtmlHelper.ViewContext));

    public virtual DateRangePickerBuilder DateRangePickerFor(
      Expression<Func<TModel, DateTime>> startExpression,
      Expression<Func<TModel, DateTime>> endExpression)
    {
      return this.DateRangePickerOfTValueFor<DateTime>(startExpression, endExpression);
    }

    public virtual DateRangePickerBuilder DateRangePickerFor(
      Expression<Func<TModel, DateTime?>> startExpression,
      Expression<Func<TModel, DateTime?>> endExpression)
    {
      return this.DateRangePickerOfTValueFor<DateTime?>(startExpression, endExpression);
    }

    private DateRangePickerBuilder DateRangePickerOfTValueFor<TValue>(
      Expression<Func<TModel, TValue>> startExpression,
      Expression<Func<TModel, TValue>> endExpression)
    {
      ModelExplorer startExplorer = this.GetModelExplorer<TValue>(startExpression);
      ModelExplorer endExplorer = this.GetModelExplorer<TValue>(endExpression);
      DateRangePickerBuilder rangePickerBuilder = this.DateRangePicker();
      if (startExplorer != null)
      {
        rangePickerBuilder.Range((Action<DateRangePickerRangeSettingsBuilder>) (r => r.Start((DateTime?) startExplorer.Model)));
        rangePickerBuilder.StartField(startExplorer.Metadata.PropertyName);
      }
      if (endExplorer != null)
      {
        rangePickerBuilder.Range((Action<DateRangePickerRangeSettingsBuilder>) (r => r.End((DateTime?) endExplorer.Model)));
        rangePickerBuilder.EndField(endExplorer.Metadata.PropertyName);
      }
      return rangePickerBuilder;
    }

    public virtual DateTimePickerBuilder DateTimePicker() => new DateTimePickerBuilder(new Kendo.Mvc.UI.DateTimePicker(this.HtmlHelper.ViewContext));

    public virtual DateTimePickerBuilder DateTimePickerFor(
      Expression<Func<TModel, DateTime>> expression)
    {
      return this.DateTimePickerOfTValueFor<DateTime>(expression);
    }

    public virtual DateTimePickerBuilder DateTimePickerFor(
      Expression<Func<TModel, DateTime?>> expression)
    {
      return this.DateTimePickerOfTValueFor<DateTime?>(expression);
    }

    private DateTimePickerBuilder DateTimePickerOfTValueFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      DateTimePickerBuilder timePickerBuilder = this.DateTimePicker().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Format(this.ExtractEditFormat(modelExplorer.Metadata.EditFormatString)).Value(modelExplorer.Model as DateTime?);
      DateTime? validationParameter1 = this.GetRangeValidationParameter<DateTime>(modelExplorer, "min");
      if (validationParameter1.HasValue)
        timePickerBuilder.Min(validationParameter1.Value);
      DateTime? validationParameter2 = this.GetRangeValidationParameter<DateTime>(modelExplorer, "max");
      if (validationParameter2.HasValue)
        timePickerBuilder.Max(validationParameter2.Value);
      return timePickerBuilder;
    }

    public virtual DiagramBuilder<object, object> Diagram() => new DiagramBuilder<object, object>(new Kendo.Mvc.UI.Diagram<object, object>(this.HtmlHelper.ViewContext));

    public virtual DiagramBuilder<TShapeModel, TConnectionModel> Diagram<TShapeModel, TConnectionModel>()
      where TShapeModel : class
      where TConnectionModel : class
    {
      return new DiagramBuilder<TShapeModel, TConnectionModel>(new Kendo.Mvc.UI.Diagram<TShapeModel, TConnectionModel>(this.HtmlHelper.ViewContext));
    }

    public virtual DialogBuilder Dialog() => new DialogBuilder(new Kendo.Mvc.UI.Dialog(this.HtmlHelper.ViewContext));

    public virtual DrawerBuilder Drawer() => new DrawerBuilder(new Kendo.Mvc.UI.Drawer(this.HtmlHelper.ViewContext));

    public virtual DropDownListBuilder DropDownList() => new DropDownListBuilder(new Kendo.Mvc.UI.DropDownList(this.HtmlHelper.ViewContext));

    public virtual DropDownListBuilder DropDownListFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      object model = modelExplorer.Model;
      return this.DropDownList().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Value(this.GetValueWithEnum<TValue>(expression));
    }

    public virtual DropDownTreeBuilder DropDownTree() => new DropDownTreeBuilder(new Kendo.Mvc.UI.DropDownTree(this.HtmlHelper.ViewContext));

    public virtual DropDownTreeBuilder DropDownTreeFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      object model = modelExplorer.Model;
      return this.GetValueWithEnum<TValue>(expression) != null ? this.DropDownTree().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Value(this.GetValueWithEnum<TValue>(expression)) : this.DropDownTree().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Value(model as IEnumerable);
    }

    public virtual EditorBuilder Editor() => new EditorBuilder(new Kendo.Mvc.UI.Editor(this.HtmlHelper.ViewContext));

    public virtual EditorBuilder EditorFor(Expression<Func<TModel, string>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<string>(expression);
      return this.Editor().Expression(this.GetExpressionName<string>(expression)).Value((string) modelExplorer.Model);
    }

    public virtual ExpansionPanelBuilder ExpansionPanel() => new ExpansionPanelBuilder(new Kendo.Mvc.UI.ExpansionPanel(this.HtmlHelper.ViewContext));

    public virtual FileManagerBuilder FileManager() => new FileManagerBuilder(new Kendo.Mvc.UI.FileManager(this.HtmlHelper.ViewContext));

    public virtual FilterBuilder<T> Filter<T>() where T : class => new FilterBuilder<T>(new Kendo.Mvc.UI.Filter<T>(this.HtmlHelper.ViewContext));

    public virtual FlatColorPickerBuilder FlatColorPicker() => new FlatColorPickerBuilder(new Kendo.Mvc.UI.FlatColorPicker(this.HtmlHelper.ViewContext));

    public virtual FloatingActionButtonBuilder FloatingActionButton() => new FloatingActionButtonBuilder(new Kendo.Mvc.UI.FloatingActionButton(this.HtmlHelper.ViewContext));

    public virtual FormBuilder<T> Form<T>() where T : class => new FormBuilder<T>(new Kendo.Mvc.UI.Form<T>(this.HtmlHelper.ViewContext));

    public virtual FormBuilder<object> Form() => new FormBuilder<object>(new Kendo.Mvc.UI.Form<object>(this.HtmlHelper.ViewContext));

    public virtual GanttBuilder<TTaskModel, TDependenciesModel> Gantt<TTaskModel, TDependenciesModel>()
      where TTaskModel : class, IGanttTask
      where TDependenciesModel : class, IGanttDependency
    {
      return new GanttBuilder<TTaskModel, TDependenciesModel>(new Kendo.Mvc.UI.Gantt<TTaskModel, TDependenciesModel>(this.HtmlHelper.ViewContext));
    }

    public virtual GanttBuilder<TTaskModel, TDependenciesModel> Gantt<TTaskModel, TDependenciesModel>(
      IEnumerable<TTaskModel> dataSource,
      IEnumerable<TDependenciesModel> dependenciesDataSource = null)
      where TTaskModel : class, IGanttTask
      where TDependenciesModel : class, IGanttDependency
    {
      GanttBuilder<TTaskModel, TDependenciesModel> ganttBuilder = this.Gantt<TTaskModel, TDependenciesModel>();
      ganttBuilder.Component.DataSource.Data = (IEnumerable) dataSource;
      if (dependenciesDataSource != null)
        ganttBuilder.Component.DependenciesDataSource.Data = (IEnumerable) dependenciesDataSource;
      return ganttBuilder;
    }

    public virtual GanttBuilder<TTaskModel, TDependenciesModel> Gantt<TTaskModel, TDependenciesModel>(
      string dataSourceViewDataKey,
      string dependenciesDataSourceViewDataKey = null)
      where TTaskModel : class, IGanttTask
      where TDependenciesModel : class, IGanttDependency
    {
      GanttBuilder<TTaskModel, TDependenciesModel> ganttBuilder = this.Gantt<TTaskModel, TDependenciesModel>();
      ganttBuilder.Component.DataSource.Data = (IEnumerable) (this.HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<TTaskModel>);
      if (!string.IsNullOrWhiteSpace(dependenciesDataSourceViewDataKey))
        ganttBuilder.Component.DependenciesDataSource.Data = (IEnumerable) (this.HtmlHelper.ViewContext.ViewData.Eval(dependenciesDataSourceViewDataKey) as IEnumerable<TDependenciesModel>);
      return ganttBuilder;
    }

    public virtual GridBuilder<T> Grid<T>() where T : class => new GridBuilder<T>(new Kendo.Mvc.UI.Grid<T>(this.HtmlHelper.ViewContext));

    public virtual GridBuilder<T> Grid<T>(IEnumerable<T> dataSource) where T : class
    {
      GridBuilder<T> gridBuilder = this.Grid<T>();
      gridBuilder.Component.DataSource.Data = (IEnumerable) dataSource;
      return gridBuilder;
    }

    public virtual GridBuilder<T> Grid<T>(string dataSourceViewDataKey) where T : class
    {
      GridBuilder<T> gridBuilder = this.Grid<T>();
      gridBuilder.Component.DataSource.Data = (IEnumerable) (this.HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<T>);
      return gridBuilder;
    }

    public virtual ImageEditorBuilder ImageEditor() => new ImageEditorBuilder(new Kendo.Mvc.UI.ImageEditor(this.HtmlHelper.ViewContext));

    public virtual LinearGaugeBuilder LinearGauge() => new LinearGaugeBuilder(new Kendo.Mvc.UI.LinearGauge(this.HtmlHelper.ViewContext));

    public virtual LinearGaugeBuilder LinearGaugeFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer metadata = this.GetModelExplorer<TValue>(expression);
      return this.LinearGauge().Expression(this.GetExpressionName<TValue>(expression)).Pointer((Action<LinearGaugePointerBuilder>) (pointer => pointer.Value(Convert.ToDouble(metadata.Model))));
    }

    public virtual LinearGaugeBuilder LinearGaugeFor<TValue>(
      Expression<Func<TModel, TValue?>> expression)
      where TValue : struct, IComparable
    {
      ModelExplorer metadata = this.GetModelExplorer<TValue?>(expression);
      return this.LinearGauge().Expression(this.GetExpressionName<TValue?>(expression)).Pointer((Action<LinearGaugePointerBuilder>) (pointer => pointer.Value(Convert.ToDouble(metadata.Model))));
    }

    public virtual ListBoxBuilder ListBox() => new ListBoxBuilder(new Kendo.Mvc.UI.ListBox(this.HtmlHelper.ViewContext));

    public virtual ListBoxBuilder ListBox(IEnumerable dataSource)
    {
      ListBoxBuilder listBoxBuilder = this.ListBox();
      listBoxBuilder.Component.DataSource.Data = dataSource;
      return listBoxBuilder;
    }

    public virtual ListBoxBuilder ListBox(string dataSourceViewDataKey)
    {
      ListBoxBuilder listBoxBuilder = this.ListBox();
      listBoxBuilder.Component.DataSource.Data = this.HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable;
      return listBoxBuilder;
    }

    public virtual ListViewBuilder<T> ListView<T>() where T : class => new ListViewBuilder<T>(new Kendo.Mvc.UI.ListView<T>(this.HtmlHelper.ViewContext));

    public virtual ListViewBuilder<T> ListView<T>(IEnumerable<T> dataSource) where T : class
    {
      ListViewBuilder<T> listViewBuilder = this.ListView<T>();
      listViewBuilder.Component.DataSource.Data = (IEnumerable) dataSource;
      return listViewBuilder;
    }

    public virtual ListViewBuilder<T> ListView<T>(string dataSourceViewDataKey) where T : class
    {
      ListViewBuilder<T> listViewBuilder = this.ListView<T>();
      listViewBuilder.Component.DataSource.Data = (IEnumerable) (this.HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<T>);
      return listViewBuilder;
    }

    public virtual LoaderBuilder Loader() => new LoaderBuilder(new Kendo.Mvc.UI.Loader(this.HtmlHelper.ViewContext));

    public virtual MapBuilder Map() => new MapBuilder(new Kendo.Mvc.UI.Map(this.HtmlHelper.ViewContext));

    public virtual MaskedTextBoxBuilder MaskedTextBox() => new MaskedTextBoxBuilder(new Kendo.Mvc.UI.MaskedTextBox(this.HtmlHelper.ViewContext));

    public virtual MaskedTextBoxBuilder MaskedTextBoxFor<TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TProperty>(expression);
      object model = modelExplorer.Model;
      return this.MaskedTextBox().Expression(this.GetExpressionName<TProperty>(expression)).Explorer(modelExplorer).Value(this.GetValue<TProperty>(expression));
    }

    public virtual MediaPlayerBuilder MediaPlayer() => new MediaPlayerBuilder(new Kendo.Mvc.UI.MediaPlayer(this.HtmlHelper.ViewContext));

    public virtual MenuBuilder Menu() => new MenuBuilder(new Kendo.Mvc.UI.Menu(this.HtmlHelper.ViewContext));

    public virtual MultiColumnComboBoxBuilder MultiColumnComboBox() => new MultiColumnComboBoxBuilder(new Kendo.Mvc.UI.MultiColumnComboBox(this.HtmlHelper.ViewContext));

    public virtual MultiColumnComboBoxBuilder MultiColumnComboBoxFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      object model = modelExplorer.Model;
      return this.MultiColumnComboBox().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Value(this.GetValueWithEnum<TValue>(expression));
    }

    public virtual MultiSelectBuilder MultiSelect() => new MultiSelectBuilder(new Kendo.Mvc.UI.MultiSelect(this.HtmlHelper.ViewContext));

    public virtual MultiSelectBuilder MultiSelectFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      object model = modelExplorer.Model;
      return this.MultiSelect().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Value(model as IEnumerable);
    }

    public virtual MultiViewCalendarBuilder MultiViewCalendar() => new MultiViewCalendarBuilder(new Kendo.Mvc.UI.MultiViewCalendar(this.HtmlHelper.ViewContext));

    public virtual NotificationBuilder Notification() => new NotificationBuilder(new Kendo.Mvc.UI.Notification(this.HtmlHelper.ViewContext));

    public virtual NumericTextBoxBuilder<double> NumericTextBox() => new NumericTextBoxBuilder<double>(new Kendo.Mvc.UI.NumericTextBox<double>(this.HtmlHelper.ViewContext));

    public virtual NumericTextBoxBuilder<T> NumericTextBox<T>() where T : struct => new NumericTextBoxBuilder<T>(new Kendo.Mvc.UI.NumericTextBox<T>(this.HtmlHelper.ViewContext));

    public virtual NumericTextBoxBuilder<Decimal> CurrencyTextBox() => this.NumericTextBox<Decimal>().Format("c");

    public virtual NumericTextBoxBuilder<double> PercentTextBox() => this.NumericTextBox().Format("p");

    public virtual NumericTextBoxBuilder<int> IntegerTextBox() => this.NumericTextBox<int>().Format("n0").Decimals(0);

    public virtual NumericTextBoxBuilder<TValue> NumericTextBoxFor<TValue>(
      Expression<Func<TModel, TValue?>> expression)
      where TValue : struct
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue?>(expression);
      NumericTextBoxBuilder<TValue> numericTextBoxBuilder = this.NumericTextBox<TValue>().Expression(this.GetExpressionName<TValue?>(expression)).Explorer(modelExplorer).Format(this.ExtractEditFormat(modelExplorer.Metadata.EditFormatString)).Value((TValue?) modelExplorer.Model);
      TValue? validationParameter1 = this.GetRangeValidationParameter<TValue>(modelExplorer, "min");
      if (validationParameter1.HasValue)
        numericTextBoxBuilder.Min(new TValue?(validationParameter1.Value));
      TValue? validationParameter2 = this.GetRangeValidationParameter<TValue>(modelExplorer, "max");
      if (validationParameter2.HasValue)
        numericTextBoxBuilder.Max(new TValue?(validationParameter2.Value));
      return numericTextBoxBuilder;
    }

    public virtual NumericTextBoxBuilder<TValue> NumericTextBoxFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
      where TValue : struct
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      NumericTextBoxBuilder<TValue> numericTextBoxBuilder = this.NumericTextBox<TValue>().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Format(this.ExtractEditFormat(modelExplorer.Metadata.EditFormatString)).Value((TValue?) modelExplorer.Model);
      TValue? validationParameter1 = this.GetRangeValidationParameter<TValue>(modelExplorer, "min");
      if (validationParameter1.HasValue)
        numericTextBoxBuilder.Min(new TValue?(validationParameter1.Value));
      TValue? validationParameter2 = this.GetRangeValidationParameter<TValue>(modelExplorer, "max");
      if (validationParameter2.HasValue)
        numericTextBoxBuilder.Max(new TValue?(validationParameter2.Value));
      return numericTextBoxBuilder;
    }

    public virtual NumericTextBoxBuilder<int> IntegerTextBoxFor(
      Expression<Func<TModel, int?>> expression)
    {
      return this.NumericTextBoxFor<int>(expression).Format("n0").Decimals(0);
    }

    public virtual NumericTextBoxBuilder<short> IntegerTextBoxFor(
      Expression<Func<TModel, short?>> expression)
    {
      return this.NumericTextBoxFor<short>(expression).Format("n0").Decimals(0);
    }

    public virtual NumericTextBoxBuilder<long> IntegerTextBoxFor(
      Expression<Func<TModel, long?>> expression)
    {
      return this.NumericTextBoxFor<long>(expression).Format("n0").Decimals(0);
    }

    public virtual NumericTextBoxBuilder<int> IntegerTextBoxFor(
      Expression<Func<TModel, int>> expression)
    {
      return this.NumericTextBoxFor<int>(expression).Format("n0").Decimals(0);
    }

    public virtual NumericTextBoxBuilder<Decimal> CurrencyTextBoxFor(
      Expression<Func<TModel, Decimal?>> expression)
    {
      return this.NumericTextBoxFor<Decimal>(expression).Format("c");
    }

    public virtual NumericTextBoxBuilder<Decimal> CurrencyTextBoxFor(
      Expression<Func<TModel, Decimal>> expression)
    {
      return this.NumericTextBoxFor<Decimal>(expression).Format("c");
    }

    public virtual NumericTextBoxBuilder<double> PercentTextBoxFor(
      Expression<Func<TModel, double?>> expression)
    {
      return this.NumericTextBoxFor<double>(expression).Format("p");
    }

    public virtual NumericTextBoxBuilder<double> PercentTextBoxFor(
      Expression<Func<TModel, double>> expression)
    {
      return this.NumericTextBoxFor<double>(expression).Format("p");
    }

    public virtual OrgChartBuilder<T> OrgChart<T>() where T : class => new OrgChartBuilder<T>(new Kendo.Mvc.UI.OrgChart<T>(this.HtmlHelper.ViewContext));

    public virtual PagerBuilder Pager() => new PagerBuilder(new Kendo.Mvc.UI.Pager(this.HtmlHelper.ViewContext));

    public virtual PanelBarBuilder PanelBar() => new PanelBarBuilder(new Kendo.Mvc.UI.PanelBar(this.HtmlHelper.ViewContext));

    public virtual PDFViewerBuilder PDFViewer() => new PDFViewerBuilder(new Kendo.Mvc.UI.PDFViewer(this.HtmlHelper.ViewContext));

    public virtual PivotConfiguratorBuilder PivotConfigurator() => new PivotConfiguratorBuilder(new Kendo.Mvc.UI.PivotConfigurator(this.HtmlHelper.ViewContext));

    public virtual PivotGridBuilder<object> PivotGrid() => new PivotGridBuilder<object>(new Kendo.Mvc.UI.PivotGrid<object>(this.HtmlHelper.ViewContext));

    public virtual PivotGridBuilder<T> PivotGrid<T>() where T : class => new PivotGridBuilder<T>(new Kendo.Mvc.UI.PivotGrid<T>(this.HtmlHelper.ViewContext));

    public virtual PopoverBuilder Popover() => new PopoverBuilder(new Kendo.Mvc.UI.Popover(this.HtmlHelper.ViewContext));

    public virtual ProgressBarBuilder ProgressBar() => new ProgressBarBuilder(new Kendo.Mvc.UI.ProgressBar(this.HtmlHelper.ViewContext));

    public virtual QRCodeBuilder QRCode() => new QRCodeBuilder(new Kendo.Mvc.UI.QRCode(this.HtmlHelper.ViewContext));

    public virtual RadialGaugeBuilder RadialGauge() => new RadialGaugeBuilder(new Kendo.Mvc.UI.RadialGauge(this.HtmlHelper.ViewContext));

    public virtual RadialGaugeBuilder RadialGaugeFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer metadata = this.GetModelExplorer<TValue>(expression);
      return this.RadialGauge().Expression(this.GetExpressionName<TValue>(expression)).Pointer((Action<RadialGaugePointerBuilder>) (pointer => pointer.Value(Convert.ToDouble(metadata.Model))));
    }

    public virtual RadialGaugeBuilder RadialGaugeFor<TValue>(
      Expression<Func<TModel, TValue?>> expression)
      where TValue : struct, IComparable
    {
      ModelExplorer metadata = this.GetModelExplorer<TValue?>(expression);
      return this.RadialGauge().Expression(this.GetExpressionName<TValue?>(expression)).Pointer((Action<RadialGaugePointerBuilder>) (pointer => pointer.Value(Convert.ToDouble(metadata.Model))));
    }

    public virtual RadioButtonBuilder RadioButton() => new RadioButtonBuilder(new Kendo.Mvc.UI.RadioButton(this.HtmlHelper.ViewContext));

    public virtual RadioButtonBuilder RadioButtonFor<TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      return this.RadioButton().Name(this.GetExpressionName<TProperty>(expression));
    }

    public virtual RadioGroupBuilder RadioGroup() => new RadioGroupBuilder(new Kendo.Mvc.UI.RadioGroup(this.HtmlHelper.ViewContext));

    public virtual RadioGroupBuilder RadioGroupFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      return this.RadioGroup().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Value(this.GetValueWithEnum<TValue>(expression));
    }

    public virtual RangeSliderBuilder<T> RangeSlider<T>() where T : struct, IComparable => new RangeSliderBuilder<T>(new Kendo.Mvc.UI.RangeSlider<T>(this.HtmlHelper.ViewContext));

    public virtual RangeSliderBuilder<double> RangeSlider() => new RangeSliderBuilder<double>(new Kendo.Mvc.UI.RangeSlider<double>(this.HtmlHelper.ViewContext));

    public virtual RangeSliderBuilder<TValue> RangeSliderFor<TValue>(
      Expression<Func<TModel, TValue[]>> expression)
      where TValue : struct, IComparable
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue[]>(expression);
      TValue? validationParameter1 = this.GetRangeValidationParameter<TValue>(modelExplorer, "min");
      TValue? validationParameter2 = this.GetRangeValidationParameter<TValue>(modelExplorer, "max");
      RangeSliderBuilder<TValue> rangeSliderBuilder = this.RangeSlider<TValue>().Expression(this.GetExpressionName<TValue[]>(expression)).Values((TValue[]) modelExplorer.Model);
      if (validationParameter1.HasValue)
        rangeSliderBuilder.Min(new TValue?(validationParameter1.Value));
      if (validationParameter2.HasValue)
        rangeSliderBuilder.Max(new TValue?(validationParameter2.Value));
      return rangeSliderBuilder;
    }

    public virtual RangeSliderBuilder<double> RangeSliderFor(
      Expression<Func<TModel, double[]>> expression)
    {
      return this.RangeSliderFor<double>(expression);
    }

    public virtual RatingBuilder Rating() => new RatingBuilder(new Kendo.Mvc.UI.Rating(this.HtmlHelper.ViewContext));

    public virtual RatingBuilder RatingFor<TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TProperty>(expression);
      this.GetValue<TProperty>(expression);
      double result;
      bool flag = double.TryParse(this.GetValue<TProperty>(expression), out result);
      return this.Rating().Name(this.GetExpressionName<TProperty>(expression)).Explorer(modelExplorer).Value(flag ? new double?(result) : new double?());
    }

    public virtual RecurrenceEditorBuilder RecurrenceEditor() => new RecurrenceEditorBuilder(new Kendo.Mvc.UI.RecurrenceEditor(this.HtmlHelper.ViewContext));

    public virtual RecurrenceEditorBuilder RecurrenceEditorFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      object model = this.GetModelExplorer<TValue>(expression).Model;
      return this.RecurrenceEditor().Expression(this.GetExpressionName<TValue>(expression)).Value(this.GetValue<TValue>(expression));
    }

    public virtual ResponsivePanelBuilder ResponsivePanel() => new ResponsivePanelBuilder(new Kendo.Mvc.UI.ResponsivePanel(this.HtmlHelper.ViewContext));

    public virtual SchedulerBuilder<T> Scheduler<T>() where T : class, ISchedulerEvent => new SchedulerBuilder<T>(new Kendo.Mvc.UI.Scheduler<T>(this.HtmlHelper.ViewContext));

    public virtual ScrollViewBuilder ScrollView() => new ScrollViewBuilder(new Kendo.Mvc.UI.ScrollView(this.HtmlHelper.ViewContext));

    public virtual SkeletonContainerBuilder SkeletonContainer() => new SkeletonContainerBuilder(new Kendo.Mvc.UI.SkeletonContainer(this.HtmlHelper.ViewContext));

    public virtual SliderBuilder<T> Slider<T>() where T : struct, IComparable => new SliderBuilder<T>(new Kendo.Mvc.UI.Slider<T>(this.HtmlHelper.ViewContext));

    public virtual SliderBuilder<double> Slider() => new SliderBuilder<double>(new Kendo.Mvc.UI.Slider<double>(this.HtmlHelper.ViewContext));

    public virtual SliderBuilder<TValue> SliderFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
      where TValue : struct, IComparable
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      TValue? validationParameter1 = this.GetRangeValidationParameter<TValue>(modelExplorer, "min");
      TValue? validationParameter2 = this.GetRangeValidationParameter<TValue>(modelExplorer, "max");
      SliderBuilder<TValue> sliderBuilder = this.Slider<TValue>().Expression(this.GetExpressionName<TValue>(expression)).Explorer(modelExplorer).Value((TValue?) modelExplorer.Model);
      if (validationParameter1.HasValue)
        sliderBuilder.Min(new TValue?(validationParameter1.Value));
      if (validationParameter2.HasValue)
        sliderBuilder.Max(new TValue?(validationParameter2.Value));
      return sliderBuilder;
    }

    public virtual SliderBuilder<TValue> SliderFor<TValue>(
      Expression<Func<TModel, TValue?>> expression)
      where TValue : struct, IComparable
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue?>(expression);
      TValue? validationParameter1 = this.GetRangeValidationParameter<TValue>(modelExplorer, "min");
      TValue? validationParameter2 = this.GetRangeValidationParameter<TValue>(modelExplorer, "max");
      SliderBuilder<TValue> sliderBuilder = this.Slider<TValue>().Expression(this.GetExpressionName<TValue?>(expression)).Explorer(modelExplorer).Value((TValue?) modelExplorer.Model);
      if (validationParameter1.HasValue)
        sliderBuilder.Min(new TValue?(validationParameter1.Value));
      if (validationParameter2.HasValue)
        sliderBuilder.Max(new TValue?(validationParameter2.Value));
      return sliderBuilder;
    }

    public virtual SliderBuilder<double> SliderFor(
      Expression<Func<TModel, double>> expression)
    {
      return this.SliderFor<double>(expression);
    }

    public virtual SliderBuilder<double> SliderFor(
      Expression<Func<TModel, double?>> expression)
    {
      return this.SliderFor<double>(expression);
    }

    public virtual SortableBuilder Sortable() => new SortableBuilder(new Kendo.Mvc.UI.Sortable(this.HtmlHelper.ViewContext));

    public virtual SparklineBuilder<object> Sparkline() => this.Sparkline<object>();

    public virtual SparklineBuilder<T> Sparkline<T>() where T : class => new SparklineBuilder<T>(new Kendo.Mvc.UI.Sparkline<T>(this.HtmlHelper.ViewContext));

    public virtual SparklineBuilder<T> Sparkline<T>(IEnumerable<T> data) where T : class
    {
      SparklineBuilder<T> sparklineBuilder = this.Sparkline<T>();
      sparklineBuilder.Component.Data = data;
      return sparklineBuilder;
    }

    public virtual SparklineBuilder<T> Sparkline<T>(string dataSourceViewDataKey) where T : class
    {
      SparklineBuilder<T> sparklineBuilder = this.Sparkline<T>();
      sparklineBuilder.Component.Data = this.HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<T>;
      return sparklineBuilder;
    }

    public virtual SplitterBuilder Splitter() => new SplitterBuilder(new Kendo.Mvc.UI.Splitter(this.HtmlHelper.ViewContext));

    public virtual SpreadsheetBuilder Spreadsheet() => new SpreadsheetBuilder(new Kendo.Mvc.UI.Spreadsheet(this.HtmlHelper.ViewContext));

    public virtual StepperBuilder Stepper() => new StepperBuilder(new Kendo.Mvc.UI.Stepper(this.HtmlHelper.ViewContext));

    public virtual StockChartBuilder<object> StockChart() => this.StockChart<object>();

    public virtual StockChartBuilder<T> StockChart<T>() where T : class => new StockChartBuilder<T>(new Kendo.Mvc.UI.StockChart<T>(this.HtmlHelper.ViewContext));

    public virtual StockChartBuilder<T> StockChart<T>(IEnumerable<T> data) where T : class
    {
      StockChartBuilder<T> stockChartBuilder = this.StockChart<T>();
      stockChartBuilder.Component.Data = data;
      return stockChartBuilder;
    }

    public virtual ChartBuilder<T> StockChart<T>(string dataSourceViewDataKey) where T : class
    {
      ChartBuilder<T> chartBuilder = this.Chart<T>();
      chartBuilder.Component.Data = this.HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<T>;
      return chartBuilder;
    }

    public virtual SwitchBuilder Switch() => new SwitchBuilder(new Kendo.Mvc.UI.Switch(this.HtmlHelper.ViewContext));

    public virtual SwitchBuilder SwitchFor<TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TProperty>(expression);
      object model = modelExplorer.Model;
      bool flag = false;
      if (model != null && model.GetType().IsPredefinedType())
        flag = Convert.ToBoolean(model);
      return this.Switch().Name(this.GetExpressionName<TProperty>(expression)).Explorer(modelExplorer).Checked(flag);
    }

    public virtual TabStripBuilder TabStrip() => new TabStripBuilder(new Kendo.Mvc.UI.TabStrip(this.HtmlHelper.ViewContext));

    public virtual TaskBoardBuilder<object, object> TaskBoard() => new TaskBoardBuilder<object, object>(new Kendo.Mvc.UI.TaskBoard<object, object>(this.HtmlHelper.ViewContext));

    public virtual TaskBoardBuilder<TCard, object> TaskBoard<TCard>() where TCard : class => new TaskBoardBuilder<TCard, object>(new Kendo.Mvc.UI.TaskBoard<TCard, object>(this.HtmlHelper.ViewContext));

    public virtual TaskBoardBuilder<TCard, TColumn> TaskBoard<TCard, TColumn>()
      where TCard : class
      where TColumn : class
    {
      return new TaskBoardBuilder<TCard, TColumn>(new Kendo.Mvc.UI.TaskBoard<TCard, TColumn>(this.HtmlHelper.ViewContext));
    }

    public virtual TextAreaBuilder TextArea() => new TextAreaBuilder(new Kendo.Mvc.UI.TextArea(this.HtmlHelper.ViewContext));

    public virtual TextAreaBuilder TextAreaFor<TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TProperty>(expression);
      return this.TextArea().Expression(this.GetExpressionName<TProperty>(expression)).Explorer(modelExplorer).Value(modelExplorer.Model != null ? modelExplorer.Model.ToString() : (string) null);
    }

    public virtual TextBoxBuilder<string> TextBox() => new TextBoxBuilder<string>(new Kendo.Mvc.UI.TextBox<string>(this.HtmlHelper.ViewContext));

    public virtual TextBoxBuilder<T> TextBox<T>() => new TextBoxBuilder<T>(new Kendo.Mvc.UI.TextBox<T>(this.HtmlHelper.ViewContext));

    public virtual TextBoxBuilder<TProperty> TextBoxFor<TProperty>(
      Expression<Func<TModel, TProperty>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TProperty>(expression);
      return this.TextBox<TProperty>().Expression(this.GetExpressionName<TProperty>(expression)).Explorer(modelExplorer).Value(modelExplorer.Model != null ? modelExplorer.Model.ToString() : (string) null);
    }

    public virtual TileLayoutBuilder TileLayout() => new TileLayoutBuilder(new Kendo.Mvc.UI.TileLayout(this.HtmlHelper.ViewContext));

    public virtual TimelineBuilder<T> Timeline<T>() where T : class => new TimelineBuilder<T>(new Kendo.Mvc.UI.Timeline<T>(this.HtmlHelper.ViewContext));

    public virtual TimePickerBuilder TimePicker() => new TimePickerBuilder(new Kendo.Mvc.UI.TimePicker(this.HtmlHelper.ViewContext));

    public virtual TimePickerBuilder TimePickerFor(
      Expression<Func<TModel, TimeSpan?>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TimeSpan?>(expression);
      return this.TimePicker().Expression(this.GetExpressionName<TimeSpan?>(expression)).Explorer(modelExplorer).Format(this.ExtractEditFormat(modelExplorer.Metadata.EditFormatString)).Value(modelExplorer.Model as TimeSpan?);
    }

    public virtual TimePickerBuilder TimePickerFor(
      Expression<Func<TModel, DateTime>> expression)
    {
      return this.TimePickerOfTValueFor<DateTime>(expression);
    }

    public virtual TimePickerBuilder TimePickerFor(
      Expression<Func<TModel, DateTime?>> expression)
    {
      return this.TimePickerOfTValueFor<DateTime?>(expression);
    }

    private TimePickerBuilder TimePickerOfTValueFor<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TValue>(expression);
      TimePickerBuilder timePickerBuilder = this.TimePicker().Explorer(modelExplorer).Expression(this.GetExpressionName<TValue>(expression)).Format(this.ExtractEditFormat(modelExplorer.Metadata.EditFormatString)).Value(modelExplorer.Model as DateTime?);
      DateTime? validationParameter1 = this.GetRangeValidationParameter<DateTime>(modelExplorer, "min");
      if (validationParameter1.HasValue)
        timePickerBuilder.Min(validationParameter1.Value);
      DateTime? validationParameter2 = this.GetRangeValidationParameter<DateTime>(modelExplorer, "max");
      if (validationParameter2.HasValue)
        timePickerBuilder.Max(validationParameter2.Value);
      return timePickerBuilder;
    }

    public virtual TimePickerBuilder TimePickerFor(
      Expression<Func<TModel, TimeSpan>> expression)
    {
      ModelExplorer modelExplorer = this.GetModelExplorer<TimeSpan>(expression);
      TimePickerBuilder timePickerBuilder1 = this.TimePicker().Expression(this.GetExpressionName<TimeSpan>(expression)).Format(this.ExtractEditFormat(modelExplorer.Metadata.EditFormatString)).Value(modelExplorer.Model as TimeSpan?);
      TimeSpan? validationParameter1 = this.GetRangeValidationParameter<TimeSpan>(modelExplorer, "min");
      TimeSpan timeSpan;
      if (validationParameter1.HasValue)
      {
        TimePickerBuilder timePickerBuilder2 = timePickerBuilder1;
        timeSpan = validationParameter1.Value;
        DateTime dateTime = new DateTime(timeSpan.Ticks);
        timePickerBuilder2.Min(dateTime);
      }
      TimeSpan? validationParameter2 = this.GetRangeValidationParameter<TimeSpan>(modelExplorer, "max");
      if (validationParameter2.HasValue)
      {
        TimePickerBuilder timePickerBuilder3 = timePickerBuilder1;
        timeSpan = validationParameter2.Value;
        DateTime dateTime = new DateTime(timeSpan.Ticks);
        timePickerBuilder3.Max(dateTime);
      }
      return timePickerBuilder1;
    }

    public virtual ToolBarBuilder ToolBar() => new ToolBarBuilder(new Kendo.Mvc.UI.ToolBar(this.HtmlHelper.ViewContext));

    public virtual TooltipBuilder Tooltip() => new TooltipBuilder(new Kendo.Mvc.UI.Tooltip(this.HtmlHelper.ViewContext));

    public virtual TreeListBuilder<T> TreeList<T>() where T : class => new TreeListBuilder<T>(new Kendo.Mvc.UI.TreeList<T>(this.HtmlHelper.ViewContext));

    public virtual TreeMapBuilder TreeMap() => new TreeMapBuilder(new Kendo.Mvc.UI.TreeMap(this.HtmlHelper.ViewContext));

    public virtual TreeViewBuilder TreeView() => new TreeViewBuilder(new Kendo.Mvc.UI.TreeView(this.HtmlHelper.ViewContext));

    public virtual UploadBuilder Upload() => new UploadBuilder(new Kendo.Mvc.UI.Upload(this.HtmlHelper.ViewContext));

    public virtual WindowBuilder Window() => new WindowBuilder(new Kendo.Mvc.UI.Window(this.HtmlHelper.ViewContext));

    public virtual WizardBuilder Wizard() => new WizardBuilder(new Kendo.Mvc.UI.Wizard(this.HtmlHelper.ViewContext));
  }
}
