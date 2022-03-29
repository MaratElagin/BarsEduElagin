using System.Threading.Channels;

namespace Generic;

public class LocalFileLogger<T> : ILogger
{
    private string _filePath { get; set; }
    private string _type = typeof(T).Name;

    public LocalFileLogger(string filePath)
    {
        if (!File.Exists(filePath))
            File.Create(filePath).Dispose();
        _filePath = filePath;
    }

    private async void WriteToLogFileAsync(string parameter, string message, string exceptionMessage = "")
    {
        using (StreamWriter writer = new StreamWriter(_filePath, true))
        {
            await writer.WriteLineAsync($"[{parameter}]:[{_type}]:{message}.{exceptionMessage}");
        }
    }

    public void LogInfo(string message) =>
        WriteToLogFileAsync("Info", message);

    public async void LogWarning(string message) =>
        WriteToLogFileAsync("Warning", message);

    public async void LogError(string message, Exception ex) =>
        WriteToLogFileAsync("Error", message, ex.Message);
}