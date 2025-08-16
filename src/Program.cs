using System.Reflection;
using Aivis;

if (args.Length < 1)
{
    Console.WriteLine("Usage: aivis {your_text}");
    Console.WriteLine("       aivis --version");
    return;
}

if (args[0] == "--version" || args[0] == "-v")
{
    var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown";
    var product = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyProductAttribute>()?.Product ?? "Aivis CLI";
    Console.WriteLine($"{product} version {version}");
    return;
}

string? apiKey = Environment.GetEnvironmentVariable("AIVIS_API_KEY");
string? modelId = Environment.GetEnvironmentVariable("AIVIS_MODEL_ID");

if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(modelId))
{
    Console.WriteLine("Please set the AIVIS_API_KEY and AIVIS_MODEL_ID environment variables.");
    return;
}

string text = string.Join(" ", args);


var options = new AivisClientOptions(apiKey);
var client = new AivisTTSClient(options);
using var audioStream = await client.SynthesizeStreamAsync(modelId, text);

// 音声を再生
Aivis.Speakers.MP3Speaker speaker = new Aivis.Speakers.MP3Speaker();
await speaker.PlayAsync(audioStream);
speaker.Dispose();