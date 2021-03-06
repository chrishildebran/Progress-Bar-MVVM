﻿// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ ValueProviderAttribute.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Properties
{
    using System;

    /// <summary>
    ///     Use this annotation to specify a type that contains static or const fields
    ///     with values for the annotated property/field/parameter.
    ///     The specified type will be used to improve completion suggestions.
    /// </summary>
    /// <example>
    ///     <code>
    /// namespace TestNamespace
    /// {
    ///   public class Constants
    ///   {
    ///     public static int INT_CONST = 1;
    ///     public const string STRING_CONST = "1";
    ///   }
    /// 
    ///   public class Class1
    ///   {
    ///     [ValueProvider("TestNamespace.Constants")] public int myField;
    ///     public void Foo([ValueProvider("TestNamespace.Constants")] string str) { }
    /// 
    ///     public void Test()
    ///     {
    ///       Foo(/*try completion here*/);//
    ///       myField = /*try completion here*/
    ///     }
    ///   }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public sealed class ValueProviderAttribute : Attribute
    {
        #region Constructors (All)

        public ValueProviderAttribute([NotNull] string name)
        {
            this.Name = name;
        }

        #endregion

        #region Properties (Non-Private)

        [NotNull]
        public string Name { get; }

        #endregion
    }
}