// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.ClassFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Kendo.Mvc.Infrastructure.Implementation
{
  public class ClassFactory
  {
    private int classCount;
    private readonly ReaderWriterLockSlim rwLock;
    private readonly ConcurrentDictionary<string, AssemblyMetadata> _metadataFileCache;
    private static string TO_STRING_METHOD_TEMPLATE = "public override string ToString() {var props = this.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public); var sb = new System.Text.StringBuilder();sb.Append(\"{\"); for (int i = 0; i < props.Length; i++) {     if (i > 0) sb.Append(\", \");     sb.Append(props[i].Name);     sb.Append(\"=\");    sb.Append(props[i].GetValue(this, null));} sb.Append(\"}\"); return sb.ToString(); }";

    public static ClassFactory Instance { get; private set; } = new ClassFactory();

    private ClassFactory()
    {
      this.rwLock = new ReaderWriterLockSlim();
      this._metadataFileCache = new ConcurrentDictionary<string, AssemblyMetadata>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    }

    public Type GetDynamicClass(IEnumerable<DynamicProperty> properties)
    {
      string typeName = "DynamicClass" + (this.classCount + 1).ToString();
      CSharpCompilation compilation = this.CreateCompilation(((SyntaxNode) this.DeclareCompilationUnit().AddMembers((MemberDeclarationSyntax) this.DeclareClass(typeName).AddMembers((MemberDeclarationSyntax[]) properties.Select<DynamicProperty, PropertyDeclarationSyntax>(new Func<DynamicProperty, PropertyDeclarationSyntax>(this.DeclareDynamicProperty)).ToArray<PropertyDeclarationSyntax>()).AddMembers(new MemberDeclarationSyntax[1]
      {
        (MemberDeclarationSyntax) this.DeclareToStringMethod()
      }))).SyntaxTree);
      this.IncrementClassCounter();
      return this.EmitType(typeName, compilation);
    }

    private Type EmitType(string typeName, CSharpCompilation compilation)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        if (!compilation.Emit((Stream) memoryStream).Success)
          throw new Exception("Unable to build type" + typeName);
        memoryStream.Seek(0L, SeekOrigin.Begin);
        return new FactoryLoadContext().Load((Stream) memoryStream).GetType(typeName);
      }
    }

    private void IncrementClassCounter()
    {
      this.rwLock.EnterWriteLock();
      try
      {
        ++this.classCount;
      }
      finally
      {
        this.rwLock.ExitWriteLock();
      }
    }

    private ClassDeclarationSyntax DeclareClass(string typeName) => SyntaxFactory.ClassDeclaration(typeName).AddModifiers(new SyntaxToken[1]
    {
      SyntaxFactory.Token(SyntaxKind.PublicKeyword)
    });

    private CompilationUnitSyntax DeclareCompilationUnit()
    {
      CompilationUnitSyntax compilationUnitSyntax = SyntaxFactory.CompilationUnit();
      compilationUnitSyntax.AddUsings(SyntaxFactory.UsingDirective((NameSyntax) SyntaxFactory.IdentifierName("System")));
      return compilationUnitSyntax;
    }

    private CSharpCompilation CreateCompilation(SyntaxTree syntaxTree)
    {
      string assemblyName = "DynamicClasses" + this.classCount.ToString();
      CSharpCompilationOptions compilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);
      SyntaxTree[] syntaxTreeArray = new SyntaxTree[1]
      {
        syntaxTree
      };
      IEnumerable<MetadataReference> references = this.GetReferences();
      CSharpCompilationOptions options = compilationOptions;
      return CSharpCompilation.Create(assemblyName, (IEnumerable<SyntaxTree>) syntaxTreeArray, references, options);
    }

    private IEnumerable<MetadataReference> GetReferences()
    {
      List<MetadataReference> metadataReferenceList = new List<MetadataReference>();
      metadataReferenceList.Add((MetadataReference) MetadataReference.CreateFromFile(typeof (object).GetTypeInfo().Assembly.Location));
      return metadataReferenceList.Count != 0 ? (IEnumerable<MetadataReference>) metadataReferenceList : throw new InvalidOperationException("Unable to create MetadataReference");
    }

    private PropertyDeclarationSyntax DeclareDynamicProperty(
      DynamicProperty property)
    {
      Type underlyingType = Nullable.GetUnderlyingType(property.Type);
      return SyntaxFactory.PropertyDeclaration(underlyingType == (Type) null ? SyntaxFactory.ParseTypeName(property.Type.FullName) : (TypeSyntax) SyntaxFactory.NullableType(SyntaxFactory.ParseTypeName(underlyingType.FullName)), property.Name).WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword))).WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List<AccessorDeclarationSyntax>((IEnumerable<AccessorDeclarationSyntax>) new AccessorDeclarationSyntax[2]
      {
        SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
        SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
      })));
    }

    private MethodDeclarationSyntax DeclareToStringMethod() => CSharpSyntaxTree.ParseText(ClassFactory.TO_STRING_METHOD_TEMPLATE).GetRoot().ChildNodes().First<SyntaxNode>() as MethodDeclarationSyntax;
  }
}
