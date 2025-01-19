namespace NAudio.Wasapi.CoreAudioApi
{
    /// <summary>
    /// MmThreadCharacteristics
    /// 
    /// Associates the calling thread with the specified task.
    /// For more details, see <see href="https://learn.microsoft.com/en-us/windows/win32/api/avrt/nf-avrt-avsetmmthreadcharacteristicsw">this</see> page.
    /// </summary>
    public enum MmThreadCharacteristics
    {
        /// <summary>
        /// Audio
        /// </summary>
        Audio,

        /// <summary>
        /// Capture
        /// </summary>
        Capture,

        /// <summary>
        /// DisplayPostProcess
        /// </summary>
        DisplayPostProcess,

        /// <summary>
        /// Distribution
        /// </summary>
        Distribution,

        /// <summary>
        /// Games
        /// </summary>
        Games,

        /// <summary>
        /// Playback
        /// </summary>
        Playback,
        
        /// <summary>
        /// Pro Audio
        /// </summary>
        ProAudio,

        /// <summary>
        /// Window Manager
        /// </summary>
        WindowManager
    }
}
