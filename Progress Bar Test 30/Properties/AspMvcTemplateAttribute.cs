﻿// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ AspMvcTemplateAttribute.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Properties
{
    using System;

    /// <summary>
    ///     ASP.NET MVC attribute. Indicates that the marked parameter is an MVC template.
    ///     Use this attribute for custom wrappers similar to
    ///     <c>System.ComponentModel.DataAnnotations.UIHintAttribute(System.String)</c>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class AspMvcTemplateAttribute : Attribute
    {
    }
}