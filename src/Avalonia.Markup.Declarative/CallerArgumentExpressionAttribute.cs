﻿#if !NET5_0 && !NET6_0
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
public sealed class CallerArgumentExpressionAttribute : Attribute
{
    public CallerArgumentExpressionAttribute(string parameterName) => this.ParameterName = parameterName;
    public string ParameterName { get; }
}
#endif