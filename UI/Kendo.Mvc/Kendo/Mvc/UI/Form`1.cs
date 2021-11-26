// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Form`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Form<T> : WidgetBase
  {
    public Form(ViewContext viewContext)
      : base(viewContext)
    {
    }

    public string ButtonsTemplate { get; set; }

    public string ButtonsTemplateId { get; set; }

    public bool? FocusFirst { get; set; }

    public string Orientation { get; set; }

    public FormValidatableSettings<T> Validatable { get; set; } = new FormValidatableSettings<T>();

    public List<FormItem> Items { get; set; } = new List<FormItem>();

    public object FormData { get; set; }

    public FormGridSettings Grid { get; set; } = new FormGridSettings();

    public string Layout { get; set; }

    public ClientHandlerDescriptor FormatLabel { get; set; } = new ClientHandlerDescriptor();

    public FormMessagesSettings Messages { get; set; } = new FormMessagesSettings();

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.ButtonsTemplateId.HasValue())
        dictionary["buttonsTemplate"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.ButtonsTemplateId)
        };
      else if (this.ButtonsTemplate.HasValue())
        dictionary["buttonsTemplate"] = (object) this.ButtonsTemplate;
      if (this.FocusFirst.HasValue)
        dictionary["focusFirst"] = (object) this.FocusFirst;
      if (this.Orientation.HasValue())
        dictionary["orientation"] = (object) this.Orientation;
      Dictionary<string, object> source1 = this.Validatable.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["validatable"] = (object) source1;
      if (this.FormData != null)
      {
        dictionary["formData"] = this.FormData;
      }
      else
      {
        this.FormData = this.ViewContext.ViewData.Model;
        dictionary["formData"] = this.FormData;
      }
      if (this.Layout.HasValue())
        dictionary["layout"] = (object) this.Layout;
      Dictionary<string, object> source2 = this.Grid.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["grid"] = (object) source2;
      if (this.FormatLabel.HasValue())
        dictionary["formatLabel"] = (object) this.FormatLabel;
      Dictionary<string, object> source3 = this.Messages.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["messages"] = (object) source3;
      if (!this.Items.Any<FormItem>())
      {
        foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) this.FormData.ToDictionary())
          this.Items.Add(new FormItem()
          {
            Field = keyValuePair.Key,
            Items = new List<FormItem>()
          });
      }
      dictionary["serverErrors"] = (object) this.GetModelStateErrors();
      dictionary["items"] = (object) this.BuildItems((IList<FormItem>) this.Items);
      return dictionary;
    }

    private IDictionary<string, IList<string>> GetModelStateErrors()
    {
      Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
      foreach (KeyValuePair<string, ModelStateEntry> keyValuePair in this.ViewContext.ViewData.ModelState)
      {
        string key = keyValuePair.Key;
        ModelStateEntry modelStateEntry = keyValuePair.Value;
        dictionary.Add(key, (IList<string>) new List<string>());
        foreach (ModelError error in (Collection<ModelError>) modelStateEntry.Errors)
          dictionary[key].Add(error.ErrorMessage);
      }
      return (IDictionary<string, IList<string>>) dictionary;
    }

    private IDictionary<string, string> BuildValidationAttributes(FormItem item)
    {
      ModelStateDictionary modelState = this.ViewContext.ViewData.ModelState;
      AttributeDictionary attributes = this.Generator.GeneratePseudoBuilder(this.ViewContext, ExpressionMetadataProvider.FromStringExpression(item.Field, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider).GetExplorerForModel(this.FormData).GetExplorerForProperty(item.Field), item.Field).Attributes;
      if (modelState.Any<KeyValuePair<string, ModelStateEntry>>() && modelState[item.Field] != null && modelState[item.Field].Errors.Any<ModelError>())
      {
        IEnumerable<string> values = modelState[item.Field].Errors.Select<ModelError, string>((Func<ModelError, string>) (er => er.ErrorMessage));
        attributes["data-val-server"] = string.Join(Environment.NewLine, values);
      }
      return (IDictionary<string, string>) attributes;
    }

    private bool IsHidden(FormItem item)
    {
      ModelExplorer explorerForProperty = ExpressionMetadataProvider.FromStringExpression(item.Field, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider).GetExplorerForModel(this.FormData).GetExplorerForProperty(item.Field);
      return explorerForProperty != null && explorerForProperty.Metadata.TemplateHint == "HiddenInput";
    }

    private IList<IDictionary<string, object>> BuildItems(IList<FormItem> items)
    {
      List<IDictionary<string, object>> dictionaryList1 = new List<IDictionary<string, object>>();
      foreach (FormItem formItem1 in (IEnumerable<FormItem>) items)
      {
        Dictionary<string, object> dictionary1 = formItem1.Serialize();
        if (formItem1.Items.Any<FormItem>())
        {
          List<IDictionary<string, object>> dictionaryList2 = new List<IDictionary<string, object>>();
          foreach (FormItem formItem2 in formItem1.Items)
          {
            Dictionary<string, object> dictionary2 = formItem2.Serialize();
            int num = this.IsHidden(formItem2) ? 1 : 0;
            dictionary2["validation"] = (object) this.BuildValidationAttributes(formItem2);
            dictionary2["shouldRenderHidden"] = (object) this.ShouldRenderHidden(formItem2);
            if (num != 0)
              dictionary2["editor"] = (object) "hidden";
            dictionaryList2.Add((IDictionary<string, object>) dictionary2);
          }
          dictionary1[nameof (items)] = (object) dictionaryList2;
        }
        else
        {
          int num = this.IsHidden(formItem1) ? 1 : 0;
          dictionary1["validation"] = (object) this.BuildValidationAttributes(formItem1);
          dictionary1["shouldRenderHidden"] = (object) this.ShouldRenderHidden(formItem1);
          if (num != 0)
            dictionary1["editor"] = (object) "hidden";
        }
        dictionaryList1.Add((IDictionary<string, object>) dictionary1);
      }
      return (IList<IDictionary<string, object>>) dictionaryList1;
    }

    private bool ShouldRenderHidden(FormItem item) => this.FormData.ToDictionary().Select<KeyValuePair<string, object>, bool>((Func<KeyValuePair<string, object>, bool>) (i => i.Key == item.Field)).FirstOrDefault<bool>().GetType().Name == "Boolean" && (!item.Editor.HasValue() || item.Editor.Equals("Switch") || item.Editor.Equals("CheckBox"));

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("form", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Form<T>), (IDictionary<string, object>) dictionary));
    }
  }
}
