﻿// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ RazorWriteMethodParameterAttribute.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar.Properties
{
    using System;

    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class RazorWriteMethodParameterAttribute : Attribute
    {
    }
}