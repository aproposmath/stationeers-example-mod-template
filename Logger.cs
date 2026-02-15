internal static class L
{
    private static BepInEx.Logging.ManualLogSource _logger;

    public static void SetLogger(BepInEx.Logging.ManualLogSource logger)
    {
        _logger = logger;
    }

    public static void Debug(string message)
    {
#if DEBUG
        _logger?.LogDebug(message);
#endif
    }

    public static void Info(string message)
    {
        _logger?.LogInfo(message);
    }

    public static void Error(string message)
    {
        _logger?.LogError(message);
    }

    public static void Warning(string message)
    {
        _logger?.LogWarning(message);
    }
}