using System.IO;
using KokoroSharp;


// string longText = @"This is a very long text that goes on and on... You can even span multiple lines using the @ symbol like this.";

class Program
{
    static void Main()
    {
        var tts = KokoroTTS.LoadModel(); // Automatically downloads the model (~320MB)
        var voice = KokoroVoiceManager.GetVoice("af_heart");
        string tenMinuteText = File.ReadAllText("input.txt");
        tts.SpeakFast(tenMinuteText, voice);

        // Optional: keep the app running
        Console.WriteLine("speaking the ten Minute Text. Press Ctrl + C to exit.");
        Console.ReadKey();
    }
}



