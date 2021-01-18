// ///////////////////////////////////////////////////////////
// Company:............. J.H. Kelly
// Department:.......... Virtual Design and Construction (VDC)
// Website:............. http://www.jhkelly.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBarTest30
// File:................ Extensions.cs
// Last Code Cleanup:... 08/28/2020 @ 3:02 PM Using ReSharper
// Review Comment:...... // ✓✓ 08/28/2020 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBarTest30
{
    using System;
    using System.ServiceModel.Dispatcher;
    using System.Threading.Tasks;

    public static class Extensions
    {
        #region Methods (Non-Private)

        public static async void FireAndForgetSafeAsync(this Task task, IErrorHandler handler = null)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                handler?.HandleError(ex);
            }
        }

        #endregion
    }
}