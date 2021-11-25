// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.ReaderWriterLockSlimExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Threading;

namespace Kendo.Mvc.Extensions
{
  public static class ReaderWriterLockSlimExtensions
  {
    public static IDisposable ReadAndWrite(this ReaderWriterLockSlim instance)
    {
      instance.EnterUpgradeableReadLock();
      return (IDisposable) new ReaderWriterLockSlimExtensions.DisposableCodeBlock(new Action(instance.ExitUpgradeableReadLock));
    }

    public static IDisposable Read(this ReaderWriterLockSlim instance)
    {
      instance.EnterReadLock();
      return (IDisposable) new ReaderWriterLockSlimExtensions.DisposableCodeBlock(new Action(instance.ExitReadLock));
    }

    public static IDisposable Write(this ReaderWriterLockSlim instance)
    {
      instance.EnterWriteLock();
      return (IDisposable) new ReaderWriterLockSlimExtensions.DisposableCodeBlock(new Action(instance.ExitWriteLock));
    }

    private sealed class DisposableCodeBlock : IDisposable
    {
      private readonly Action action;

      public DisposableCodeBlock(Action action) => this.action = action;

      public void Dispose() => this.action();
    }
  }
}
