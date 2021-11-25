// Decompiled with JetBrains decompiler
// Type: Microsoft.AspNetCore.Mvc.ViewFeatures.Resources
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
  public static class Resources
  {
    private static readonly ResourceManager _resourceManager = new ResourceManager("Microsoft.AspNetCore.Mvc.ViewFeatures.Resources", typeof (Microsoft.AspNetCore.Mvc.ViewFeatures.Resources).GetTypeInfo().Assembly);

    internal static string ViewComponent_AmbiguousTypeMatch => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_AmbiguousTypeMatch));

    internal static string FormatViewComponent_AmbiguousTypeMatch(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_AmbiguousTypeMatch"), p0, p1, p2);

    internal static string ViewComponent_AsyncMethod_ShouldReturnTask => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_AsyncMethod_ShouldReturnTask));

    internal static string FormatViewComponent_AsyncMethod_ShouldReturnTask(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_AsyncMethod_ShouldReturnTask"), p0, p1, p2);
    }

    internal static string ViewComponent_MustReturnValue => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_MustReturnValue));

    internal static string FormatViewComponent_MustReturnValue() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_MustReturnValue");

    internal static string ViewComponent_SyncMethod_ShouldReturnValue => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_SyncMethod_ShouldReturnValue));

    internal static string FormatViewComponent_SyncMethod_ShouldReturnValue(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_SyncMethod_ShouldReturnValue"), p0, p1);

    internal static string ViewComponent_CannotFindComponent => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_CannotFindComponent));

    internal static string FormatViewComponent_CannotFindComponent(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_CannotFindComponent"), p0, p1, p2, p3);
    }

    internal static string ViewComponent_IViewComponentFactory_ReturnedNull => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_IViewComponentFactory_ReturnedNull));

    internal static string FormatViewComponent_IViewComponentFactory_ReturnedNull(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_IViewComponentFactory_ReturnedNull"), p0);

    internal static string ViewComponent_CannotFindMethod => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_CannotFindMethod));

    internal static string FormatViewComponent_CannotFindMethod(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_CannotFindMethod"), p0, p1, p2);

    internal static string ViewComponent_InvalidReturnValue => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_InvalidReturnValue));

    internal static string FormatViewComponent_InvalidReturnValue(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_InvalidReturnValue"), p0, p1, p2);

    internal static string ArgumentCannotBeNullOrEmpty => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ArgumentCannotBeNullOrEmpty));

    internal static string FormatArgumentCannotBeNullOrEmpty() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ArgumentCannotBeNullOrEmpty");

    internal static string PropertyOfTypeCannotBeNull => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (PropertyOfTypeCannotBeNull));

    internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("PropertyOfTypeCannotBeNull"), p0, p1);

    internal static string TypeMethodMustReturnNotNullValue => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (TypeMethodMustReturnNotNullValue));

    internal static string FormatTypeMethodMustReturnNotNullValue(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("TypeMethodMustReturnNotNullValue"), p0, p1);

    internal static string ArgumentPropertyUnexpectedType => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ArgumentPropertyUnexpectedType));

    internal static string FormatArgumentPropertyUnexpectedType(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ArgumentPropertyUnexpectedType"), p0, p1, p2);

    internal static string Common_PartialViewNotFound => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (Common_PartialViewNotFound));

    internal static string FormatCommon_PartialViewNotFound(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("Common_PartialViewNotFound"), p0, p1);

    internal static string Common_TriState_False => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (Common_TriState_False));

    internal static string FormatCommon_TriState_False() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("Common_TriState_False");

    internal static string Common_TriState_NotSet => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (Common_TriState_NotSet));

    internal static string FormatCommon_TriState_NotSet() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("Common_TriState_NotSet");

    internal static string Common_TriState_True => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (Common_TriState_True));

    internal static string FormatCommon_TriState_True() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("Common_TriState_True");

    internal static string DynamicViewData_ViewDataNull => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (DynamicViewData_ViewDataNull));

    internal static string FormatDynamicViewData_ViewDataNull() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("DynamicViewData_ViewDataNull");

    internal static string ExpressionHelper_InvalidIndexerExpression => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ExpressionHelper_InvalidIndexerExpression));

    internal static string FormatExpressionHelper_InvalidIndexerExpression(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ExpressionHelper_InvalidIndexerExpression"), p0, p1);

    internal static string HtmlHelper_NullModelMetadata => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (HtmlHelper_NullModelMetadata));

    internal static string FormatHtmlHelper_NullModelMetadata(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("HtmlHelper_NullModelMetadata"), p0);

    internal static string HtmlHelper_NotContextualized => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (HtmlHelper_NotContextualized));

    internal static string FormatHtmlHelper_NotContextualized() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("HtmlHelper_NotContextualized");

    internal static string HtmlHelper_MissingSelectData => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (HtmlHelper_MissingSelectData));

    internal static string FormatHtmlHelper_MissingSelectData(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("HtmlHelper_MissingSelectData"), p0, p1);

    internal static string HtmlHelper_SelectExpressionNotEnumerable => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (HtmlHelper_SelectExpressionNotEnumerable));

    internal static string FormatHtmlHelper_SelectExpressionNotEnumerable(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("HtmlHelper_SelectExpressionNotEnumerable"), p0);

    internal static string HtmlHelper_TypeNotSupported_ForGetEnumSelectList => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (HtmlHelper_TypeNotSupported_ForGetEnumSelectList));

    internal static string FormatHtmlHelper_TypeNotSupported_ForGetEnumSelectList(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("HtmlHelper_TypeNotSupported_ForGetEnumSelectList"), p0, p1, p2);
    }

    internal static string HtmlHelper_WrongSelectDataType => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (HtmlHelper_WrongSelectDataType));

    internal static string FormatHtmlHelper_WrongSelectDataType(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("HtmlHelper_WrongSelectDataType"), p0, p1, p2);

    internal static string Templates_TypeMustImplementIEnumerable => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (Templates_TypeMustImplementIEnumerable));

    internal static string FormatTemplates_TypeMustImplementIEnumerable(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("Templates_TypeMustImplementIEnumerable"), p0, p1, p2);
    }

    internal static string TemplateHelpers_TemplateLimitations => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (TemplateHelpers_TemplateLimitations));

    internal static string FormatTemplateHelpers_TemplateLimitations() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("TemplateHelpers_TemplateLimitations");

    internal static string TemplateHelpers_NoTemplate => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (TemplateHelpers_NoTemplate));

    internal static string FormatTemplateHelpers_NoTemplate(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("TemplateHelpers_NoTemplate"), p0);

    internal static string ViewData_ModelCannotBeNull => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewData_ModelCannotBeNull));

    internal static string FormatViewData_ModelCannotBeNull(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewData_ModelCannotBeNull"), p0);

    internal static string ViewData_WrongTModelType => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewData_WrongTModelType));

    internal static string FormatViewData_WrongTModelType(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewData_WrongTModelType"), p0, p1);

    internal static string ViewEngine_PartialViewNotFound => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewEngine_PartialViewNotFound));

    internal static string FormatViewEngine_PartialViewNotFound(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewEngine_PartialViewNotFound"), p0, p1);

    internal static string ViewEngine_ViewNotFound => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewEngine_ViewNotFound));

    internal static string FormatViewEngine_ViewNotFound(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewEngine_ViewNotFound"), p0, p1);

    internal static string HtmlHelper_TextAreaParameterOutOfRange => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (HtmlHelper_TextAreaParameterOutOfRange));

    internal static string FormatHtmlHelper_TextAreaParameterOutOfRange() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("HtmlHelper_TextAreaParameterOutOfRange");

    internal static string UnobtrusiveJavascript_ValidationParameterCannotBeEmpty => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (UnobtrusiveJavascript_ValidationParameterCannotBeEmpty));

    internal static string FormatUnobtrusiveJavascript_ValidationParameterCannotBeEmpty(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("UnobtrusiveJavascript_ValidationParameterCannotBeEmpty"), p0);

    internal static string UnobtrusiveJavascript_ValidationParameterMustBeLegal => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (UnobtrusiveJavascript_ValidationParameterMustBeLegal));

    internal static string FormatUnobtrusiveJavascript_ValidationParameterMustBeLegal(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("UnobtrusiveJavascript_ValidationParameterMustBeLegal"), p0, p1);
    }

    internal static string UnobtrusiveJavascript_ValidationTypeCannotBeEmpty => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (UnobtrusiveJavascript_ValidationTypeCannotBeEmpty));

    internal static string FormatUnobtrusiveJavascript_ValidationTypeCannotBeEmpty(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("UnobtrusiveJavascript_ValidationTypeCannotBeEmpty"), p0);

    internal static string UnobtrusiveJavascript_ValidationTypeMustBeLegal => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (UnobtrusiveJavascript_ValidationTypeMustBeLegal));

    internal static string FormatUnobtrusiveJavascript_ValidationTypeMustBeLegal(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("UnobtrusiveJavascript_ValidationTypeMustBeLegal"), p0, p1);
    }

    internal static string UnobtrusiveJavascript_ValidationTypeMustBeUnique => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (UnobtrusiveJavascript_ValidationTypeMustBeUnique));

    internal static string FormatUnobtrusiveJavascript_ValidationTypeMustBeUnique(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("UnobtrusiveJavascript_ValidationTypeMustBeUnique"), p0);

    internal static string TypeMustDeriveFromType => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (TypeMustDeriveFromType));

    internal static string FormatTypeMustDeriveFromType(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("TypeMustDeriveFromType"), p0, p1);

    internal static string TemplatedViewLocationExpander_NoReplacementToken => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (TemplatedViewLocationExpander_NoReplacementToken));

    internal static string FormatTemplatedViewLocationExpander_NoReplacementToken(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("TemplatedViewLocationExpander_NoReplacementToken"), p0);

    internal static string TemplatedExpander_PopulateValuesMustBeInvokedFirst => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (TemplatedExpander_PopulateValuesMustBeInvokedFirst));

    internal static string FormatTemplatedExpander_PopulateValuesMustBeInvokedFirst(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("TemplatedExpander_PopulateValuesMustBeInvokedFirst"), p0, p1);
    }

    internal static string TemplatedExpander_ValueFactoryCannotReturnNull => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (TemplatedExpander_ValueFactoryCannotReturnNull));

    internal static string FormatTemplatedExpander_ValueFactoryCannotReturnNull() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("TemplatedExpander_ValueFactoryCannotReturnNull");

    internal static string ViewComponent_AmbiguousTypeMatch_Item => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_AmbiguousTypeMatch_Item));

    internal static string FormatViewComponent_AmbiguousTypeMatch_Item(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_AmbiguousTypeMatch_Item"), p0, p1);

    internal static string Common_PropertyNotFound => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (Common_PropertyNotFound));

    internal static string FormatCommon_PropertyNotFound(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("Common_PropertyNotFound"), p0, p1);

    internal static string RemoteAttribute_NoUrlFound => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (RemoteAttribute_NoUrlFound));

    internal static string FormatRemoteAttribute_NoUrlFound() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("RemoteAttribute_NoUrlFound");

    internal static string RemoteAttribute_RemoteValidationFailed => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (RemoteAttribute_RemoteValidationFailed));

    internal static string FormatRemoteAttribute_RemoteValidationFailed(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("RemoteAttribute_RemoteValidationFailed"), p0);

    internal static string HtmlGenerator_FieldNameCannotBeNullOrEmpty => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (HtmlGenerator_FieldNameCannotBeNullOrEmpty));

    internal static string FormatHtmlGenerator_FieldNameCannotBeNullOrEmpty(
      object p0,
      object p1,
      object p2,
      object p3,
      object p4)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("HtmlGenerator_FieldNameCannotBeNullOrEmpty"), p0, p1, p2, p3, p4);
    }

    internal static string ViewComponentResult_NameOrTypeMustBeSet => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponentResult_NameOrTypeMustBeSet));

    internal static string FormatViewComponentResult_NameOrTypeMustBeSet(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponentResult_NameOrTypeMustBeSet"), p0, p1);

    internal static string Dictionary_DuplicateKey => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (Dictionary_DuplicateKey));

    internal static string FormatDictionary_DuplicateKey(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("Dictionary_DuplicateKey"), p0);

    internal static string ViewComponent_SyncMethod_CannotReturnTask => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_SyncMethod_CannotReturnTask));

    internal static string FormatViewComponent_SyncMethod_CannotReturnTask(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_SyncMethod_CannotReturnTask"), p0, p1, p2);
    }

    internal static string ViewComponent_AmbiguousMethods => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewComponent_AmbiguousMethods));

    internal static string FormatViewComponent_AmbiguousMethods(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewComponent_AmbiguousMethods"), p0, p1, p2);

    internal static string ValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated));

    internal static string FormatValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated"), p0, p1);
    }

    internal static string CreateModelExpression_NullModelMetadata => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (CreateModelExpression_NullModelMetadata));

    internal static string FormatCreateModelExpression_NullModelMetadata(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("CreateModelExpression_NullModelMetadata"), p0, p1);

    internal static string ViewEnginesAreRequired => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (ViewEnginesAreRequired));

    internal static string FormatViewEnginesAreRequired(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("ViewEnginesAreRequired"), p0, p1, p2);

    internal static string TempDataProperties_PublicGetterSetter => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (TempDataProperties_PublicGetterSetter));

    internal static string FormatTempDataProperties_PublicGetterSetter(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("TempDataProperties_PublicGetterSetter"), p0, p1, p2);
    }

    internal static string TempDataProperties_InvalidType => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (TempDataProperties_InvalidType));

    internal static string FormatTempDataProperties_InvalidType(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("TempDataProperties_InvalidType"), p0, p1, p2, p3);
    }

    internal static string DeserializingTempData => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (DeserializingTempData));

    internal static string FormatDeserializingTempData() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("DeserializingTempData");

    internal static string SerializingTempData => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString(nameof (SerializingTempData));

    internal static string FormatSerializingTempData() => Microsoft.AspNetCore.Mvc.ViewFeatures.Resources.GetString("SerializingTempData");

    private static string GetString(string name, params string[] formatterNames)
    {
      string str = Microsoft.AspNetCore.Mvc.ViewFeatures.Resources._resourceManager.GetString(name);
      if (formatterNames != null)
      {
        for (int index = 0; index < formatterNames.Length; ++index)
          str = str.Replace("{" + formatterNames[index] + "}", "{" + index.ToString() + "}");
      }
      return str;
    }
  }
}
