using NAudio.Wasapi.CoreAudioApi;

namespace NAudio.CoreAudioApi
{
    /// <summary>
    /// AvrtThreadPriority
    /// 
    /// Adjusts the thread priority of the calling thread relative to other threads performing the same task.
    /// For more details, see <see href="https://learn.microsoft.com/en-us/windows/win32/api/avrt/nf-avrt-avsetmmthreadpriority">this</see> page.
    /// </summary>
    public enum AvrtThreadPriority
    {
        /// <summary>
        /// Lowest priority.
        /// </summary>
        Low = NativeMethods.AVRT_PRIORITY_LOW,

        /// <summary>
        /// Normal priority (default).
        /// </summary>
        Normal = NativeMethods.AVRT_PRIORITY_NORMAL,

        /// <summary>
        /// High priority.
        /// </summary>
        High = NativeMethods.AVRT_PRIORITY_HIGH,

        /// <summary>
        /// Critical priority.
        /// </summary>
        Critical = NativeMethods.AVRT_PRIORITY_CRITICAL
    }
}
