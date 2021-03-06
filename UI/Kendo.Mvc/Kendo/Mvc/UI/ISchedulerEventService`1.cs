// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ISchedulerEventService`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public interface ISchedulerEventService<T> where T : class, ISchedulerEvent
  {
    IQueryable<T> GetAll();

    void Insert(T appointment, ModelStateDictionary modelState);

    void Update(T appointment, ModelStateDictionary modelState);

    void Delete(T appointment, ModelStateDictionary modelState);
  }
}
