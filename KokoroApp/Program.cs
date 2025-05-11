using System.IO;
using KokoroSharp;


// string longText = @"This is a very long text that goes on and on... You can even span multiple lines using the @ symbol like this.";

class Program
{
    static void Main()
    {
        var tts = KokoroTTS.LoadModel(); // Automatically downloads the model (~320MB)
        var voice = KokoroVoiceManager.GetVoice("af_heart");
        string text = File.ReadAllText("input.txt");
        tts.SpeakFast(text, voice);

        // Optional: keep the app running
        // Optional: keep the app running
        Console.WriteLine("Writing speech to a wav file. Press Ctrl + C to stop.");
        Console.WriteLine($"start time: {DateTime.Now:yyyyMMdd_HHmmssfff}");
        Console.ReadKey();
    }
}



