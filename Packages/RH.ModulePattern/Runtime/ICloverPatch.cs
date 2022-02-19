//(C) RenderHeads PTY LTD 2021
//Author: Ross Borchers

namespace RenderHeads.Tooling.Core.CloverPatchPattern
{
	/// <summary>
	/// Base interface for all cloverpatchs, ICloverPatchFactory requires cloverpatchs inherit from this.
	/// General cloverpatch usage pattern is:
	/// RAII. All initialization is done through the constructor. After a constructor is run the cloverpatch should be fully usable.
	/// UpdateCloverPatchs should be called at regular intervals. The order of cloverpatch updates should be controlled by the caller to ensure all dependencies have already been updated.
	/// Pass in dependencies through the constructor IOC like.
	/// </summary>
	public interface ICloverPatch
	{
		/// <summary>
		/// Should be called at a regular interval. The order of cloverpatch updates should be controlled by the caller to ensure all dependencies have already been updated.
		/// </summary>
		void UpdateCloverPatch();
	}
}
