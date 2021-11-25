// Decompiled with JetBrains decompiler
// Type: Microsoft.AspNetCore.Mvc.Core.Resources
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.AspNetCore.Mvc.Core
{
  internal static class Resources
  {
    private static readonly ResourceManager _resourceManager = new ResourceManager("Microsoft.AspNetCore.Mvc.Core.Resources", typeof (Microsoft.AspNetCore.Mvc.Core.Resources).GetTypeInfo().Assembly);

    internal static string MatchAllContentTypeIsNotAllowed => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (MatchAllContentTypeIsNotAllowed));

    internal static string FormatMatchAllContentTypeIsNotAllowed(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("MatchAllContentTypeIsNotAllowed"), p0);

    internal static string ObjectResult_MatchAllContentType => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ObjectResult_MatchAllContentType));

    internal static string FormatObjectResult_MatchAllContentType(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ObjectResult_MatchAllContentType"), p0, p1);

    internal static string ActionExecutor_WrappedTaskInstance => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ActionExecutor_WrappedTaskInstance));

    internal static string FormatActionExecutor_WrappedTaskInstance(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ActionExecutor_WrappedTaskInstance"), p0, p1, p2);
    }

    internal static string ActionExecutor_UnexpectedTaskInstance => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ActionExecutor_UnexpectedTaskInstance));

    internal static string FormatActionExecutor_UnexpectedTaskInstance(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ActionExecutor_UnexpectedTaskInstance"), p0, p1);

    internal static string ActionInvokerFactory_CouldNotCreateInvoker => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ActionInvokerFactory_CouldNotCreateInvoker));

    internal static string FormatActionInvokerFactory_CouldNotCreateInvoker(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ActionInvokerFactory_CouldNotCreateInvoker"), p0);

    internal static string ActionDescriptorMustBeBasedOnControllerAction => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ActionDescriptorMustBeBasedOnControllerAction));

    internal static string FormatActionDescriptorMustBeBasedOnControllerAction(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ActionDescriptorMustBeBasedOnControllerAction"), p0);

    internal static string ArgumentCannotBeNullOrEmpty => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ArgumentCannotBeNullOrEmpty));

    internal static string FormatArgumentCannotBeNullOrEmpty() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ArgumentCannotBeNullOrEmpty");

    internal static string PropertyOfTypeCannotBeNull => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (PropertyOfTypeCannotBeNull));

    internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("PropertyOfTypeCannotBeNull"), p0, p1);

    internal static string TypeMethodMustReturnNotNullValue => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (TypeMethodMustReturnNotNullValue));

    internal static string FormatTypeMethodMustReturnNotNullValue(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("TypeMethodMustReturnNotNullValue"), p0, p1);

    internal static string ModelBinding_NullValueNotValid => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelBinding_NullValueNotValid));

    internal static string FormatModelBinding_NullValueNotValid(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelBinding_NullValueNotValid"), p0);

    internal static string Invalid_IncludePropertyExpression => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (Invalid_IncludePropertyExpression));

    internal static string FormatInvalid_IncludePropertyExpression(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("Invalid_IncludePropertyExpression"), p0);

    internal static string NoRoutesMatched => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (NoRoutesMatched));

    internal static string FormatNoRoutesMatched() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("NoRoutesMatched");

    internal static string AsyncActionFilter_InvalidShortCircuit => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AsyncActionFilter_InvalidShortCircuit));

    internal static string FormatAsyncActionFilter_InvalidShortCircuit(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AsyncActionFilter_InvalidShortCircuit"), p0, p1, p2, p3);
    }

    internal static string AsyncResultFilter_InvalidShortCircuit => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AsyncResultFilter_InvalidShortCircuit));

    internal static string FormatAsyncResultFilter_InvalidShortCircuit(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AsyncResultFilter_InvalidShortCircuit"), p0, p1, p2, p3);
    }

    internal static string FilterFactoryAttribute_TypeMustImplementIFilter => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (FilterFactoryAttribute_TypeMustImplementIFilter));

    internal static string FormatFilterFactoryAttribute_TypeMustImplementIFilter(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("FilterFactoryAttribute_TypeMustImplementIFilter"), p0, p1);
    }

    internal static string ActionResult_ActionReturnValueCannotBeNull => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ActionResult_ActionReturnValueCannotBeNull));

    internal static string FormatActionResult_ActionReturnValueCannotBeNull(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ActionResult_ActionReturnValueCannotBeNull"), p0);

    internal static string TypeMustDeriveFromType => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (TypeMustDeriveFromType));

    internal static string FormatTypeMustDeriveFromType(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("TypeMustDeriveFromType"), p0, p1);

    internal static string InputFormatterNoEncoding => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (InputFormatterNoEncoding));

    internal static string FormatInputFormatterNoEncoding(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("InputFormatterNoEncoding"), p0);

    internal static string UnsupportedContentType => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (UnsupportedContentType));

    internal static string FormatUnsupportedContentType(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("UnsupportedContentType"), p0);

    internal static string OutputFormatterNoMediaType => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (OutputFormatterNoMediaType));

    internal static string FormatOutputFormatterNoMediaType(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("OutputFormatterNoMediaType"), p0);

    internal static string AttributeRoute_AggregateErrorMessage => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_AggregateErrorMessage));

    internal static string FormatAttributeRoute_AggregateErrorMessage(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_AggregateErrorMessage"), p0, p1);

    internal static string AttributeRoute_CannotContainParameter => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_CannotContainParameter));

    internal static string FormatAttributeRoute_CannotContainParameter(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_CannotContainParameter"), p0, p1, p2);
    }

    internal static string AttributeRoute_IndividualErrorMessage => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_IndividualErrorMessage));

    internal static string FormatAttributeRoute_IndividualErrorMessage(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_IndividualErrorMessage"), p0, p1, p2);
    }

    internal static string AttributeRoute_TokenReplacement_EmptyTokenNotAllowed => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_TokenReplacement_EmptyTokenNotAllowed));

    internal static string FormatAttributeRoute_TokenReplacement_EmptyTokenNotAllowed() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_TokenReplacement_EmptyTokenNotAllowed");

    internal static string AttributeRoute_TokenReplacement_ImbalancedSquareBrackets => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_TokenReplacement_ImbalancedSquareBrackets));

    internal static string FormatAttributeRoute_TokenReplacement_ImbalancedSquareBrackets() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_TokenReplacement_ImbalancedSquareBrackets");

    internal static string AttributeRoute_TokenReplacement_InvalidSyntax => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_TokenReplacement_InvalidSyntax));

    internal static string FormatAttributeRoute_TokenReplacement_InvalidSyntax(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_TokenReplacement_InvalidSyntax"), p0, p1);

    internal static string AttributeRoute_TokenReplacement_ReplacementValueNotFound => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_TokenReplacement_ReplacementValueNotFound));

    internal static string FormatAttributeRoute_TokenReplacement_ReplacementValueNotFound(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_TokenReplacement_ReplacementValueNotFound"), p0, p1, p2);
    }

    internal static string AttributeRoute_TokenReplacement_UnclosedToken => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_TokenReplacement_UnclosedToken));

    internal static string FormatAttributeRoute_TokenReplacement_UnclosedToken() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_TokenReplacement_UnclosedToken");

    internal static string AttributeRoute_TokenReplacement_UnescapedBraceInToken => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_TokenReplacement_UnescapedBraceInToken));

    internal static string FormatAttributeRoute_TokenReplacement_UnescapedBraceInToken() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_TokenReplacement_UnescapedBraceInToken");

    internal static string UnableToFindServices => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (UnableToFindServices));

    internal static string FormatUnableToFindServices(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("UnableToFindServices"), p0, p1, p2);

    internal static string AttributeRoute_DuplicateNames_Item => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_DuplicateNames_Item));

    internal static string FormatAttributeRoute_DuplicateNames_Item(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_DuplicateNames_Item"), p0, p1);

    internal static string AttributeRoute_DuplicateNames => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_DuplicateNames));

    internal static string FormatAttributeRoute_DuplicateNames(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_DuplicateNames"), p0, p1, p2);

    internal static string AttributeRoute_AggregateErrorMessage_ErrorNumber => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_AggregateErrorMessage_ErrorNumber));

    internal static string FormatAttributeRoute_AggregateErrorMessage_ErrorNumber(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_AggregateErrorMessage_ErrorNumber"), p0, p1, p2);
    }

    internal static string AttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod));

    internal static string FormatAttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod"), p0, p1, p2);
    }

    internal static string AttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod_Item => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod_Item));

    internal static string FormatAttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod_Item(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_MixedAttributeAndConventionallyRoutedActions_ForMethod_Item"), p0, p1, p2);
    }

    internal static string AttributeRoute_NullTemplateRepresentation => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AttributeRoute_NullTemplateRepresentation));

    internal static string FormatAttributeRoute_NullTemplateRepresentation() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AttributeRoute_NullTemplateRepresentation");

    internal static string DefaultActionSelector_AmbiguousActions => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (DefaultActionSelector_AmbiguousActions));

    internal static string FormatDefaultActionSelector_AmbiguousActions(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("DefaultActionSelector_AmbiguousActions"), p0, p1);

    internal static string FileResult_InvalidPath => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (FileResult_InvalidPath));

    internal static string FormatFileResult_InvalidPath(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("FileResult_InvalidPath"), p0);

    internal static string SerializableError_DefaultError => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (SerializableError_DefaultError));

    internal static string FormatSerializableError_DefaultError() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("SerializableError_DefaultError");

    internal static string AsyncResourceFilter_InvalidShortCircuit => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AsyncResourceFilter_InvalidShortCircuit));

    internal static string FormatAsyncResourceFilter_InvalidShortCircuit(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AsyncResourceFilter_InvalidShortCircuit"), p0, p1, p2, p3);
    }

    internal static string ResponseCache_SpecifyDuration => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ResponseCache_SpecifyDuration));

    internal static string FormatResponseCache_SpecifyDuration(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ResponseCache_SpecifyDuration"), p0, p1);

    internal static string ApiExplorer_UnsupportedAction => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiExplorer_UnsupportedAction));

    internal static string FormatApiExplorer_UnsupportedAction(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiExplorer_UnsupportedAction"), p0);

    internal static string FormatterMappings_NotValidMediaType => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (FormatterMappings_NotValidMediaType));

    internal static string FormatFormatterMappings_NotValidMediaType(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("FormatterMappings_NotValidMediaType"), p0);

    internal static string Format_NotValid => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (Format_NotValid));

    internal static string FormatFormat_NotValid(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("Format_NotValid"), p0);

    internal static string CacheProfileNotFound => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (CacheProfileNotFound));

    internal static string FormatCacheProfileNotFound(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("CacheProfileNotFound"), p0);

    internal static string ModelType_WrongType => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelType_WrongType));

    internal static string FormatModelType_WrongType(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelType_WrongType"), p0, p1);

    internal static string ValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated));

    internal static string FormatValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ValueInterfaceAbstractOrOpenGenericTypesCannotBeActivated"), p0, p1);
    }

    internal static string BinderType_MustBeIModelBinder => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (BinderType_MustBeIModelBinder));

    internal static string FormatBinderType_MustBeIModelBinder(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("BinderType_MustBeIModelBinder"), p0, p1);

    internal static string BindingSource_CannotBeComposite => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (BindingSource_CannotBeComposite));

    internal static string FormatBindingSource_CannotBeComposite(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("BindingSource_CannotBeComposite"), p0, p1);

    internal static string BindingSource_CannotBeGreedy => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (BindingSource_CannotBeGreedy));

    internal static string FormatBindingSource_CannotBeGreedy(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("BindingSource_CannotBeGreedy"), p0, p1);

    internal static string Common_PropertyNotFound => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (Common_PropertyNotFound));

    internal static string FormatCommon_PropertyNotFound(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("Common_PropertyNotFound"), p0, p1);

    internal static string JQueryFormValueProviderFactory_MissingClosingBracket => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (JQueryFormValueProviderFactory_MissingClosingBracket));

    internal static string FormatJQueryFormValueProviderFactory_MissingClosingBracket(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("JQueryFormValueProviderFactory_MissingClosingBracket"), p0);

    internal static string KeyValuePair_BothKeyAndValueMustBePresent => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (KeyValuePair_BothKeyAndValueMustBePresent));

    internal static string FormatKeyValuePair_BothKeyAndValueMustBePresent() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("KeyValuePair_BothKeyAndValueMustBePresent");

    internal static string ModelBinderUtil_ModelCannotBeNull => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelBinderUtil_ModelCannotBeNull));

    internal static string FormatModelBinderUtil_ModelCannotBeNull(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelBinderUtil_ModelCannotBeNull"), p0);

    internal static string ModelBinderUtil_ModelInstanceIsWrong => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelBinderUtil_ModelInstanceIsWrong));

    internal static string FormatModelBinderUtil_ModelInstanceIsWrong(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelBinderUtil_ModelInstanceIsWrong"), p0, p1);

    internal static string ModelBinderUtil_ModelMetadataCannotBeNull => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelBinderUtil_ModelMetadataCannotBeNull));

    internal static string FormatModelBinderUtil_ModelMetadataCannotBeNull() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelBinderUtil_ModelMetadataCannotBeNull");

    internal static string ModelBinding_MissingBindRequiredMember => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelBinding_MissingBindRequiredMember));

    internal static string FormatModelBinding_MissingBindRequiredMember(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelBinding_MissingBindRequiredMember"), p0);

    internal static string ModelBinding_MissingRequestBodyRequiredMember => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelBinding_MissingRequestBodyRequiredMember));

    internal static string FormatModelBinding_MissingRequestBodyRequiredMember() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelBinding_MissingRequestBodyRequiredMember");

    internal static string ValueProviderResult_NoConverterExists => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ValueProviderResult_NoConverterExists));

    internal static string FormatValueProviderResult_NoConverterExists(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ValueProviderResult_NoConverterExists"), p0, p1);

    internal static string FileResult_PathNotRooted => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (FileResult_PathNotRooted));

    internal static string FormatFileResult_PathNotRooted(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("FileResult_PathNotRooted"), p0);

    internal static string UrlNotLocal => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (UrlNotLocal));

    internal static string FormatUrlNotLocal() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("UrlNotLocal");

    internal static string FormatFormatterMappings_GetMediaTypeMappingForFormat_InvalidFormat => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (FormatFormatterMappings_GetMediaTypeMappingForFormat_InvalidFormat));

    internal static string FormatFormatFormatterMappings_GetMediaTypeMappingForFormat_InvalidFormat(
      object p0)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("FormatFormatterMappings_GetMediaTypeMappingForFormat_InvalidFormat"), p0);
    }

    internal static string AcceptHeaderParser_ParseAcceptHeader_InvalidValues => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AcceptHeaderParser_ParseAcceptHeader_InvalidValues));

    internal static string FormatAcceptHeaderParser_ParseAcceptHeader_InvalidValues(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AcceptHeaderParser_ParseAcceptHeader_InvalidValues"), p0);

    internal static string ModelState_AttemptedValueIsInvalid => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelState_AttemptedValueIsInvalid));

    internal static string FormatModelState_AttemptedValueIsInvalid(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelState_AttemptedValueIsInvalid"), p0, p1);

    internal static string ModelState_NonPropertyAttemptedValueIsInvalid => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelState_NonPropertyAttemptedValueIsInvalid));

    internal static string FormatModelState_NonPropertyAttemptedValueIsInvalid(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelState_NonPropertyAttemptedValueIsInvalid"), p0);

    internal static string ModelState_UnknownValueIsInvalid => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelState_UnknownValueIsInvalid));

    internal static string FormatModelState_UnknownValueIsInvalid(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelState_UnknownValueIsInvalid"), p0);

    internal static string ModelState_NonPropertyUnknownValueIsInvalid => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelState_NonPropertyUnknownValueIsInvalid));

    internal static string FormatModelState_NonPropertyUnknownValueIsInvalid() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelState_NonPropertyUnknownValueIsInvalid");

    internal static string HtmlGeneration_ValueIsInvalid => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (HtmlGeneration_ValueIsInvalid));

    internal static string FormatHtmlGeneration_ValueIsInvalid(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("HtmlGeneration_ValueIsInvalid"), p0);

    internal static string HtmlGeneration_ValueMustBeNumber => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (HtmlGeneration_ValueMustBeNumber));

    internal static string FormatHtmlGeneration_ValueMustBeNumber(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("HtmlGeneration_ValueMustBeNumber"), p0);

    internal static string HtmlGeneration_NonPropertyValueMustBeNumber => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (HtmlGeneration_NonPropertyValueMustBeNumber));

    internal static string FormatHtmlGeneration_NonPropertyValueMustBeNumber() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("HtmlGeneration_NonPropertyValueMustBeNumber");

    internal static string TextInputFormatter_SupportedEncodingsMustNotBeEmpty => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (TextInputFormatter_SupportedEncodingsMustNotBeEmpty));

    internal static string FormatTextInputFormatter_SupportedEncodingsMustNotBeEmpty(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("TextInputFormatter_SupportedEncodingsMustNotBeEmpty"), p0);

    internal static string TextOutputFormatter_SupportedEncodingsMustNotBeEmpty => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (TextOutputFormatter_SupportedEncodingsMustNotBeEmpty));

    internal static string FormatTextOutputFormatter_SupportedEncodingsMustNotBeEmpty(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("TextOutputFormatter_SupportedEncodingsMustNotBeEmpty"), p0);

    internal static string TextOutputFormatter_WriteResponseBodyAsyncNotSupported => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (TextOutputFormatter_WriteResponseBodyAsyncNotSupported));

    internal static string FormatTextOutputFormatter_WriteResponseBodyAsyncNotSupported(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("TextOutputFormatter_WriteResponseBodyAsyncNotSupported"), p0, p1, p2);
    }

    internal static string Formatter_NoMediaTypes => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (Formatter_NoMediaTypes));

    internal static string FormatFormatter_NoMediaTypes(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("Formatter_NoMediaTypes"), p0, p1);

    internal static string CouldNotCreateIModelBinder => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (CouldNotCreateIModelBinder));

    internal static string FormatCouldNotCreateIModelBinder(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("CouldNotCreateIModelBinder"), p0);

    internal static string InputFormattersAreRequired => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (InputFormattersAreRequired));

    internal static string FormatInputFormattersAreRequired(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("InputFormattersAreRequired"), p0, p1, p2);

    internal static string ModelBinderProvidersAreRequired => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelBinderProvidersAreRequired));

    internal static string FormatModelBinderProvidersAreRequired(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelBinderProvidersAreRequired"), p0, p1, p2);

    internal static string OutputFormattersAreRequired => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (OutputFormattersAreRequired));

    internal static string FormatOutputFormattersAreRequired(object p0, object p1, object p2) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("OutputFormattersAreRequired"), p0, p1, p2);

    internal static string MiddewareFilter_ConfigureMethodOverload => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (MiddewareFilter_ConfigureMethodOverload));

    internal static string FormatMiddewareFilter_ConfigureMethodOverload(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("MiddewareFilter_ConfigureMethodOverload"), p0);

    internal static string MiddewareFilter_NoConfigureMethod => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (MiddewareFilter_NoConfigureMethod));

    internal static string FormatMiddewareFilter_NoConfigureMethod(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("MiddewareFilter_NoConfigureMethod"), p0, p1);

    internal static string MiddlewareFilterBuilder_NoMiddlewareFeature => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (MiddlewareFilterBuilder_NoMiddlewareFeature));

    internal static string FormatMiddlewareFilterBuilder_NoMiddlewareFeature(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("MiddlewareFilterBuilder_NoMiddlewareFeature"), p0);

    internal static string MiddlewareFilterBuilder_NullApplicationBuilder => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (MiddlewareFilterBuilder_NullApplicationBuilder));

    internal static string FormatMiddlewareFilterBuilder_NullApplicationBuilder(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("MiddlewareFilterBuilder_NullApplicationBuilder"), p0);

    internal static string MiddlewareFilter_InvalidConfigureReturnType => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (MiddlewareFilter_InvalidConfigureReturnType));

    internal static string FormatMiddlewareFilter_InvalidConfigureReturnType(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("MiddlewareFilter_InvalidConfigureReturnType"), p0, p1, p2);
    }

    internal static string MiddlewareFilter_ServiceResolutionFail => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (MiddlewareFilter_ServiceResolutionFail));

    internal static string FormatMiddlewareFilter_ServiceResolutionFail(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("MiddlewareFilter_ServiceResolutionFail"), p0, p1, p2, p3);
    }

    internal static string AuthorizeFilter_AuthorizationPolicyCannotBeCreated => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (AuthorizeFilter_AuthorizationPolicyCannotBeCreated));

    internal static string FormatAuthorizeFilter_AuthorizationPolicyCannotBeCreated(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("AuthorizeFilter_AuthorizationPolicyCannotBeCreated"), p0, p1);
    }

    internal static string FormCollectionModelBinder_CannotBindToFormCollection => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (FormCollectionModelBinder_CannotBindToFormCollection));

    internal static string FormatFormCollectionModelBinder_CannotBindToFormCollection(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("FormCollectionModelBinder_CannotBindToFormCollection"), p0, p1, p2);
    }

    internal static string VaryByQueryKeys_Requires_ResponseCachingMiddleware => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (VaryByQueryKeys_Requires_ResponseCachingMiddleware));

    internal static string FormatVaryByQueryKeys_Requires_ResponseCachingMiddleware(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("VaryByQueryKeys_Requires_ResponseCachingMiddleware"), p0);

    internal static string CandidateResolver_DifferentCasedReference => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (CandidateResolver_DifferentCasedReference));

    internal static string FormatCandidateResolver_DifferentCasedReference(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("CandidateResolver_DifferentCasedReference"), p0);

    internal static string MiddlewareFilterConfigurationProvider_CreateConfigureDelegate_CannotCreateType => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (MiddlewareFilterConfigurationProvider_CreateConfigureDelegate_CannotCreateType));

    internal static string FormatMiddlewareFilterConfigurationProvider_CreateConfigureDelegate_CannotCreateType(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("MiddlewareFilterConfigurationProvider_CreateConfigureDelegate_CannotCreateType"), p0, p1);
    }

    internal static string Argument_InvalidOffsetLength => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (Argument_InvalidOffsetLength));

    internal static string FormatArgument_InvalidOffsetLength(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("Argument_InvalidOffsetLength"), p0, p1);

    internal static string ComplexTypeModelBinder_NoParameterlessConstructor_ForType => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ComplexTypeModelBinder_NoParameterlessConstructor_ForType));

    internal static string FormatComplexTypeModelBinder_NoParameterlessConstructor_ForType(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ComplexTypeModelBinder_NoParameterlessConstructor_ForType"), p0);

    internal static string ComplexTypeModelBinder_NoParameterlessConstructor_ForProperty => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ComplexTypeModelBinder_NoParameterlessConstructor_ForProperty));

    internal static string FormatComplexTypeModelBinder_NoParameterlessConstructor_ForProperty(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ComplexTypeModelBinder_NoParameterlessConstructor_ForProperty"), p0, p1, p2);
    }

    internal static string NoRoutesMatchedForPage => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (NoRoutesMatchedForPage));

    internal static string FormatNoRoutesMatchedForPage(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("NoRoutesMatchedForPage"), p0);

    internal static string UrlHelper_RelativePagePathIsNotSupported => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (UrlHelper_RelativePagePathIsNotSupported));

    internal static string FormatUrlHelper_RelativePagePathIsNotSupported(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("UrlHelper_RelativePagePathIsNotSupported"), p0, p1, p2);
    }

    internal static string ValidationProblemDescription_Title => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ValidationProblemDescription_Title));

    internal static string FormatValidationProblemDescription_Title() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ValidationProblemDescription_Title");

    internal static string ApiController_AttributeRouteRequired => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiController_AttributeRouteRequired));

    internal static string FormatApiController_AttributeRouteRequired(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiController_AttributeRouteRequired"), p0, p1);

    internal static string VirtualFileResultExecutor_NoFileProviderConfigured => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (VirtualFileResultExecutor_NoFileProviderConfigured));

    internal static string FormatVirtualFileResultExecutor_NoFileProviderConfigured() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("VirtualFileResultExecutor_NoFileProviderConfigured");

    internal static string ApplicationPartFactory_InvalidFactoryType => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApplicationPartFactory_InvalidFactoryType));

    internal static string FormatApplicationPartFactory_InvalidFactoryType(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApplicationPartFactory_InvalidFactoryType"), p0, p1, p2);
    }

    internal static string RelatedAssemblyAttribute_AssemblyCannotReferenceSelf => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (RelatedAssemblyAttribute_AssemblyCannotReferenceSelf));

    internal static string FormatRelatedAssemblyAttribute_AssemblyCannotReferenceSelf(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("RelatedAssemblyAttribute_AssemblyCannotReferenceSelf"), p0, p1);
    }

    internal static string RelatedAssemblyAttribute_CouldNotBeFound => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (RelatedAssemblyAttribute_CouldNotBeFound));

    internal static string FormatRelatedAssemblyAttribute_CouldNotBeFound(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("RelatedAssemblyAttribute_CouldNotBeFound"), p0, p1, p2);
    }

    internal static string ApplicationAssembliesProvider_DuplicateRelatedAssembly => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApplicationAssembliesProvider_DuplicateRelatedAssembly));

    internal static string FormatApplicationAssembliesProvider_DuplicateRelatedAssembly(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApplicationAssembliesProvider_DuplicateRelatedAssembly"), p0);

    internal static string ApplicationAssembliesProvider_RelatedAssemblyCannotDefineAdditional => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApplicationAssembliesProvider_RelatedAssemblyCannotDefineAdditional));

    internal static string FormatApplicationAssembliesProvider_RelatedAssemblyCannotDefineAdditional(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApplicationAssembliesProvider_RelatedAssemblyCannotDefineAdditional"), p0, p1);
    }

    internal static string ComplexTypeModelBinder_NoParameterlessConstructor_ForParameter => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ComplexTypeModelBinder_NoParameterlessConstructor_ForParameter));

    internal static string FormatComplexTypeModelBinder_NoParameterlessConstructor_ForParameter(
      object p0,
      object p1)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ComplexTypeModelBinder_NoParameterlessConstructor_ForParameter"), p0, p1);
    }

    internal static string ApiController_MultipleBodyParametersFound => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiController_MultipleBodyParametersFound));

    internal static string FormatApiController_MultipleBodyParametersFound(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiController_MultipleBodyParametersFound"), p0, p1, p2, p3);
    }

    internal static string ApiConventionMustBeStatic => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventionMustBeStatic));

    internal static string FormatApiConventionMustBeStatic(object p0) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventionMustBeStatic"), p0);

    internal static string InvalidTypeTForActionResultOfT => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (InvalidTypeTForActionResultOfT));

    internal static string FormatInvalidTypeTForActionResultOfT(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("InvalidTypeTForActionResultOfT"), p0, p1);

    internal static string ApiConvention_UnsupportedAttributesOnConvention => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConvention_UnsupportedAttributesOnConvention));

    internal static string FormatApiConvention_UnsupportedAttributesOnConvention(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConvention_UnsupportedAttributesOnConvention"), p0, p1, p2);
    }

    internal static string ApiConventionMethod_AmbiguousMethodName => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventionMethod_AmbiguousMethodName));

    internal static string FormatApiConventionMethod_AmbiguousMethodName(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventionMethod_AmbiguousMethodName"), p0, p1);

    internal static string ApiConventionMethod_NoMethodFound => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventionMethod_NoMethodFound));

    internal static string FormatApiConventionMethod_NoMethodFound(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventionMethod_NoMethodFound"), p0, p1);

    internal static string ValidationVisitor_ExceededMaxDepth => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ValidationVisitor_ExceededMaxDepth));

    internal static string FormatValidationVisitor_ExceededMaxDepth(
      object p0,
      object p1,
      object p2)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ValidationVisitor_ExceededMaxDepth"), p0, p1, p2);
    }

    internal static string ValidationVisitor_ExceededMaxDepthFix => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ValidationVisitor_ExceededMaxDepthFix));

    internal static string FormatValidationVisitor_ExceededMaxDepthFix(object p0, object p1) => string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ValidationVisitor_ExceededMaxDepthFix"), p0, p1);

    internal static string ValidationVisitor_ExceededMaxPropertyDepth => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ValidationVisitor_ExceededMaxPropertyDepth));

    internal static string FormatValidationVisitor_ExceededMaxPropertyDepth(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ValidationVisitor_ExceededMaxPropertyDepth"), p0, p1, p2, p3);
    }

    internal static string ApiConventions_Title_400 => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventions_Title_400));

    internal static string FormatApiConventions_Title_400() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventions_Title_400");

    internal static string ApiConventions_Title_401 => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventions_Title_401));

    internal static string FormatApiConventions_Title_401() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventions_Title_401");

    internal static string ApiConventions_Title_403 => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventions_Title_403));

    internal static string FormatApiConventions_Title_403() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventions_Title_403");

    internal static string ApiConventions_Title_404 => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventions_Title_404));

    internal static string FormatApiConventions_Title_404() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventions_Title_404");

    internal static string ApiConventions_Title_406 => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventions_Title_406));

    internal static string FormatApiConventions_Title_406() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventions_Title_406");

    internal static string ApiConventions_Title_409 => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventions_Title_409));

    internal static string FormatApiConventions_Title_409() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventions_Title_409");

    internal static string ApiConventions_Title_415 => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventions_Title_415));

    internal static string FormatApiConventions_Title_415() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventions_Title_415");

    internal static string ApiConventions_Title_422 => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ApiConventions_Title_422));

    internal static string FormatApiConventions_Title_422() => Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ApiConventions_Title_422");

    internal static string ReferenceToNewtonsoftJsonRequired => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ReferenceToNewtonsoftJsonRequired));

    internal static string FormatReferenceToNewtonsoftJsonRequired(
      object p0,
      object p1,
      object p2,
      object p3,
      object p4)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ReferenceToNewtonsoftJsonRequired"), p0, p1, p2, p3, p4);
    }

    internal static string ModelBinding_ExceededMaxModelBindingCollectionSize => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelBinding_ExceededMaxModelBindingCollectionSize));

    internal static string FormatModelBinding_ExceededMaxModelBindingCollectionSize(
      object p0,
      object p1,
      object p2,
      object p3,
      object p4)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelBinding_ExceededMaxModelBindingCollectionSize"), p0, p1, p2, p3, p4);
    }

    internal static string ModelBinding_ExceededMaxModelBindingRecursionDepth => Microsoft.AspNetCore.Mvc.Core.Resources.GetString(nameof (ModelBinding_ExceededMaxModelBindingRecursionDepth));

    internal static string FormatModelBinding_ExceededMaxModelBindingRecursionDepth(
      object p0,
      object p1,
      object p2,
      object p3)
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, Microsoft.AspNetCore.Mvc.Core.Resources.GetString("ModelBinding_ExceededMaxModelBindingRecursionDepth"), p0, p1, p2, p3);
    }

    private static string GetString(string name, params string[] formatterNames)
    {
      string str = Microsoft.AspNetCore.Mvc.Core.Resources._resourceManager.GetString(name);
      if (formatterNames != null)
      {
        for (int index = 0; index < formatterNames.Length; ++index)
          str = str.Replace("{" + formatterNames[index] + "}", "{" + index.ToString() + "}");
      }
      return str;
    }
  }
}
