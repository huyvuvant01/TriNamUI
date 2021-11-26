// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Rendering.KendoHtmlGenerator
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Kendo.Mvc.Rendering
{
  public class KendoHtmlGenerator : IKendoHtmlGenerator
  {
    private readonly IClientModelValidatorProvider _clientModelValidatorProvider;
    private readonly ClientValidatorCache _clientValidatorCache;
    private readonly IModelMetadataProvider _metadataProvider;
    private readonly IServiceProvider _requestServices;

    public KendoHtmlGenerator(
      IModelMetadataProvider metadataProvider,
      IServiceProvider requestServices,
      IOptions<MvcViewOptions> optionsAccessor,
      ClientValidatorCache clientValidatorCache)
    {
      this._clientModelValidatorProvider = (IClientModelValidatorProvider) new CompositeClientModelValidatorProvider((IEnumerable<IClientModelValidatorProvider>) optionsAccessor.Value.ClientModelValidatorProviders);
      this._clientValidatorCache = clientValidatorCache;
      this._metadataProvider = metadataProvider;
      this._requestServices = requestServices;
      this.IdAttributeDotReplacement = optionsAccessor.Value.HtmlHelperOptions.IdAttributeDotReplacement;
    }

    public string IdAttributeDotReplacement { get; }

    public TagBuilder GenerateInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      string type,
      IDictionary<string, object> htmlAttributes)
    {
      TagBuilder boundElement = this.GenerateBoundElement("input", viewContext, modelExplorer, id, name, value, format, type, htmlAttributes);
      boundElement.TagRenderMode = TagRenderMode.SelfClosing;
      return boundElement;
    }

    public TagBuilder GenerateBoundElement(
      string elementType,
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      string type,
      IDictionary<string, object> htmlAttributes)
    {
      TagBuilder tag = this.GenerateTag(elementType, viewContext, id, name, htmlAttributes);
      if (!string.IsNullOrEmpty(type))
        tag.MergeAttribute(nameof (type), type);
      modelExplorer = modelExplorer ?? ExpressionMetadataProvider.FromStringExpression(name, viewContext.ViewData, this._metadataProvider);
      string attribute = tag.Attributes[nameof (name)];
      string str1 = KendoHtmlGenerator.FormatValue(value, format);
      bool flag1 = true;
      bool flag2 = modelExplorer.Metadata == null && value == null;
      string str2 = (string) KendoHtmlGenerator.GetModelStateValue(viewContext, attribute, typeof (string));
      if (str2 == null)
      {
        flag1 = false;
        if (string.IsNullOrEmpty(str1) && htmlAttributes.ContainsKey(nameof (value)))
          str1 = htmlAttributes[nameof (value)].ToString();
        str2 = flag2 ? KendoHtmlGenerator.EvalString(viewContext, attribute, format) : str1;
      }
      if (type == InputType.CheckBox.ToString().ToLower())
      {
        if (flag1)
        {
          if (str2 != "false")
            tag.MergeAttribute("checked", "checked");
          tag.MergeAttribute(nameof (value), "true", true);
        }
        else
          tag.MergeAttribute(nameof (value), str2, true);
      }
      else
        tag.MergeAttribute(nameof (value), str2, true);
      ModelStateEntry modelStateEntry;
      if (viewContext.ViewData.ModelState.TryGetValue(attribute, out modelStateEntry) && modelStateEntry.Errors.Count > 0)
        tag.AddCssClass(HtmlHelper.ValidationInputCssClassName);
      this.AddValidationAttributes(viewContext, tag, modelExplorer, name);
      return tag;
    }

    public virtual TagBuilder GenerateHiddenForCheckbox(
      ViewContext viewContext,
      string name,
      IDictionary<string, object> htmlAttributes)
    {
      TagBuilder tag = this.GenerateTag("input", viewContext, string.Empty, name, htmlAttributes);
      tag.MergeAttribute("type", "hidden");
      tag.MergeAttribute("value", "false", true);
      tag.TagRenderMode = TagRenderMode.SelfClosing;
      tag.MergeAttribute(nameof (name), name);
      return tag;
    }

    private TagBuilder GenerateSelect(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      string multiple,
      IDictionary<string, object> htmlAttributes)
    {
      TagBuilder tag = this.GenerateTag("select", viewContext, id, name, htmlAttributes);
      tag.MergeAttribute(nameof (multiple), multiple);
      string attribute = tag.Attributes[nameof (name)];
      ModelStateEntry modelStateEntry;
      if (viewContext.ViewData.ModelState.TryGetValue(attribute, out modelStateEntry) && modelStateEntry.Errors.Count > 0)
        tag.AddCssClass(HtmlHelper.ValidationInputCssClassName);
      this.AddValidationAttributes(viewContext, tag, modelExplorer, name);
      return tag;
    }

    public virtual TagBuilder GenerateTextarea(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      IDictionary<string, object> htmlAttributes)
    {
      TagBuilder tag = this.GenerateTag("textarea", viewContext, id, name, htmlAttributes);
      string attribute = tag.Attributes[nameof (name)];
      ModelStateEntry modelStateEntry;
      if (viewContext.ViewData.ModelState.TryGetValue(attribute, out modelStateEntry) && modelStateEntry.Errors.Count > 0)
        tag.AddCssClass(HtmlHelper.ValidationInputCssClassName);
      this.AddValidationAttributes(viewContext, tag, modelExplorer, name);
      return tag;
    }

    public virtual TagBuilder GenerateColorInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      IDictionary<string, object> htmlAttributes)
    {
      return this.GenerateInput(viewContext, modelExplorer, id, name, value, (string) null, "color", htmlAttributes);
    }

    public virtual TagBuilder GenerateRangeInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      IDictionary<string, object> htmlAttributes)
    {
      return this.GenerateInput(viewContext, modelExplorer, id, name, value, (string) null, "range", htmlAttributes);
    }

    public virtual TagBuilder GenerateDateInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes)
    {
      return this.GenerateInput(viewContext, modelExplorer, id, name, value, format, "text", htmlAttributes);
    }

    public virtual TagBuilder GenerateDateTimeInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes)
    {
      return this.GenerateInput(viewContext, modelExplorer, id, name, value, format, "text", htmlAttributes);
    }

    public virtual TagBuilder GenerateTimeInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes)
    {
      return this.GenerateInput(viewContext, modelExplorer, id, name, value, format, "text", htmlAttributes);
    }

    public virtual TagBuilder GenerateNumericInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes)
    {
      return this.GenerateInput(viewContext, modelExplorer, id, name, value, format, "text", htmlAttributes);
    }

    public TagBuilder GenerateRadioInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes)
    {
      TagBuilder tag = this.GenerateTag("input", viewContext, id, name, htmlAttributes);
      string attribute = tag.Attributes[nameof (name)];
      string str = KendoHtmlGenerator.FormatValue(value, format);
      tag.TagRenderMode = TagRenderMode.SelfClosing;
      tag.MergeAttribute("type", "radio");
      modelExplorer = modelExplorer ?? ExpressionMetadataProvider.FromStringExpression(name, viewContext.ViewData, this._metadataProvider);
      if (string.IsNullOrEmpty(str) && htmlAttributes.ContainsKey(nameof (value)))
        str = htmlAttributes[nameof (value)].ToString();
      if (string.IsNullOrEmpty(str))
        str = "";
      tag.MergeAttribute(nameof (value), str, true);
      ModelStateEntry modelStateEntry;
      if (viewContext.ViewData.ModelState.TryGetValue(attribute, out modelStateEntry) && modelStateEntry.Errors.Count > 0)
        tag.AddCssClass(HtmlHelper.ValidationInputCssClassName);
      this.AddValidationAttributes(viewContext, tag, modelExplorer, name);
      return tag;
    }

    public virtual TagBuilder GenerateMultiSelect(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      IDictionary<string, object> htmlAttributes)
    {
      return this.GenerateSelect(viewContext, modelExplorer, id, name, "multiple", htmlAttributes);
    }

    public virtual TagBuilder GenerateTag(
      string tagName,
      IDictionary<string, object> htmlAttributes)
    {
      TagBuilder tagBuilder = new TagBuilder(tagName);
      tagBuilder.MergeAttributes<string, object>(htmlAttributes, true);
      return tagBuilder;
    }

    public virtual TagBuilder GenerateTag(
      string tagName,
      ViewContext viewContext,
      string id,
      string name,
      IDictionary<string, object> htmlAttributes)
    {
      string fullHtmlFieldName = viewContext.GetFullHtmlFieldName(name);
      if (string.IsNullOrEmpty(fullHtmlFieldName))
        throw new InvalidOperationException(Exceptions.NameCannotBeBlank);
      TagBuilder tagBuilder = new TagBuilder(tagName);
      tagBuilder.MergeAttribute(nameof (id), id);
      tagBuilder.MergeAttribute(nameof (name), fullHtmlFieldName);
      tagBuilder.MergeAttributes<string, object>(htmlAttributes, true);
      return tagBuilder;
    }

    protected virtual void AddValidationAttributes(
      ViewContext viewContext,
      TagBuilder tagBuilder,
      ModelExplorer modelExplorer,
      string expression)
    {
      if ((viewContext.ClientValidationEnabled ? viewContext.FormContext : (FormContext) null) == null)
        return;
      modelExplorer = modelExplorer ?? ExpressionMetadataProvider.FromStringExpression(expression, viewContext.ViewData, this._metadataProvider);
      IReadOnlyList<IClientModelValidator> validators = this._clientValidatorCache.GetValidators(modelExplorer.Metadata, this._clientModelValidatorProvider);
      if (validators.Count <= 0)
        return;
      ClientModelValidationContext context = new ClientModelValidationContext((ActionContext) viewContext, modelExplorer.Metadata, this._metadataProvider, (IDictionary<string, string>) tagBuilder.Attributes);
      for (int index = 0; index < validators.Count; ++index)
        validators[index].AddValidation(context);
    }

    internal static string GetFullHtmlFieldName(ViewContext viewContext, string expression) => viewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(expression);

    private static object GetModelStateValue(
      ViewContext viewContext,
      string key,
      Type destinationType)
    {
      ModelStateEntry modelStateEntry;
      return viewContext.ViewData.ModelState.TryGetValue(key, out modelStateEntry) && modelStateEntry.RawValue != null ? Convert.ChangeType(KendoHtmlGenerator.ConvertTo(modelStateEntry.RawValue, destinationType), destinationType) : (object) null;
    }

    private static object ConvertTo(object value, Type destinationType)
    {
      Array source = value as Array;
      return !TypeDescriptor.GetConverter(destinationType).CanConvertTo(value.GetType()) && source != null ? source.ElementAt(0) : value;
    }

    private static string EvalString(ViewContext viewContext, string key) => Convert.ToString(viewContext.ViewData.Eval(key), (IFormatProvider) CultureInfo.CurrentCulture);

    private static string EvalString(ViewContext viewContext, string key, string format) => Convert.ToString(viewContext.ViewData.Eval(key, format), (IFormatProvider) CultureInfo.CurrentCulture);

    private static string FormatValue(object value, string format) => value is DateTime && !string.IsNullOrEmpty(format) ? ((DateTime) value).ToString(format) : ViewDataDictionary.FormatValue(value, format);

    public TagBuilder GenerateTextInput(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string id,
      string name,
      object value,
      string format,
      IDictionary<string, object> htmlAttributes)
    {
      return this.GenerateInput(viewContext, modelExplorer, id, name, value, format, "text", htmlAttributes);
    }

    public TagBuilder GeneratePseudoBuilder(
      ViewContext viewContext,
      ModelExplorer modelExplorer,
      string name)
    {
      TagBuilder tagBuilder = new TagBuilder(name);
      this.AddValidationAttributes(viewContext, tagBuilder, modelExplorer, name);
      return tagBuilder;
    }

    private bool IsValidCharacter(char c) => c != '?' && c != '!' && c != '#' && c != '.' && c != '[' && c != ']';

    private void ReplaceInvalidCharacters(string part, StringBuilder builder)
    {
      for (int index = 0; index < part.Length; ++index)
      {
        char c = part[index];
        if (this.IsValidCharacter(c))
          builder.Append(c);
        else
          builder.Append(this.IdAttributeDotReplacement);
      }
    }

    public string SanitizeId(string id)
    {
      if (string.IsNullOrWhiteSpace(id))
        return string.Empty;
      StringBuilder builder = new StringBuilder(id.Length);
      int num1 = id.IndexOf("#");
      int num2 = id.LastIndexOf("#");
      if (num2 > num1)
      {
        this.ReplaceInvalidCharacters(id.Substring(0, num1), builder);
        builder.Append(id.Substring(num1, num2 - num1 + 1));
        this.ReplaceInvalidCharacters(id.Substring(num2 + 1), builder);
      }
      else
        this.ReplaceInvalidCharacters(id, builder);
      return builder.ToString();
    }
  }
}
