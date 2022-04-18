// ///////////////////////////////////////////////////////////
// Company:............. Sheasta Development
// Website:............. http://www.sheasta.com
// Solution:............ Progress Bar Test 30
// Project:............. ProgressBar
// File:................ Extensions.cs
// Last Code Cleanup:... 01/18/2021 @ 1:25 PM Using ReSharper
// Review Comment:...... // ✓✓ 01/18/2021 - Review Comment:
// ///////////////////////////////////////////////////////////

namespace ProgressBar
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