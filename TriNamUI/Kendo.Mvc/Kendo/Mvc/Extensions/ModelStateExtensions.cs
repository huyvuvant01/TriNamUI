// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.ModelStateExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.Extensions
{
  public static class ModelStateExtensions
  {
    public static object ToDataSourceResult(this ModelStateDictionary modelState) => !modelState.IsValid ? (object) new
    {
      Errors = modelState.SerializeErrors()
    } : new object();

    public static object SerializeErrors(this ModelStateDictionary modelState) => (object) modelState.Where<KeyValuePair<string, ModelStateEntry>>((Func<KeyValuePair<string, ModelStateEntry>, bool>) (entry => entry.Value.Errors.Any<ModelError>())).ToDictionary<KeyValuePair<string, ModelStateEntry>, string, Dictionary<string, object>>((Func<KeyValuePair<string, ModelStateEntry>, string>) (entry => entry.Key), (Func<KeyValuePair<string, ModelStateEntry>, Dictionary<string, object>>) (entry => ModelStateExtensions.SerializeModelState(entry.Value)));

    private static Dictionary<string, object> SerializeModelState(
      ModelStateEntry modelState)
    {
      return new Dictionary<string, object>()
      {
        ["errors"] = (object) modelState.Errors.Select<ModelError, string>((Func<ModelError, string>) (error => ModelStateExtensions.GetErrorMessage(error, modelState))).ToArray<string>()
      };
    }

    private static string GetErrorMessage(ModelError error, ModelStateEntry modelState)
    {
      if (error.ErrorMessage.HasValue() || modelState.RawValue == null)
        return error.ErrorMessage;
      return Exceptions.ValueNotValidForProperty.FormatWith((object) modelState.AttemptedValue);
    }
  }
}
