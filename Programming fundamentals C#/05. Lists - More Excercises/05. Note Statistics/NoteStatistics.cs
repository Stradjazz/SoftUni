using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  In music, certain frequencies correspond to certain musical notes (example: A -> 440hz, C# -> 554.37hz). 
You will be given frequencies as real numbers on the first line of the input (space-separated). 
Your task is to convert the numbers to their musical note representation, then separate them into naturals (C, B, F and etc.) 
and sharp notes (C#, F#, A#, etc.). After that, print both lists in the console in the format described in the examples. 
After you print them, sum each list’s frequencies and print it on the console, rounded to the second decimal place. */

namespace _05.Note_Statistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            List<double> inputFreqs = Console.ReadLine().Split(' ').Select(double.Parse).ToList();// input frequencies
            Dictionary<string, double> noteFreqs = new Dictionary<string, double>
            { { "C", 261.63 }, { "C#", 277.18 }, { "D", 293.66 }, { "D#", 311.13 }, { "E", 329.63 }, { "F", 349.23 },{ "F#", 369.99 },
            { "G", 392.00 }, { "G#", 415.30 }, { "A", 440.00 }, { "A#", 466.16 }, { "B", 493.88 }};//note-frequency dictionary

            List<string> listedNotes = new List<string>();
            //getting the names of the listed frequencies from the input
            foreach (var frequency in inputFreqs)
            {
                foreach (var kvp in noteFreqs)
                {
                    var noteName = kvp.Key;
                    var freqNum = kvp.Value;
                    if (frequency == freqNum)
                    {
                        listedNotes.Add(noteName);
                    }
                }
            }
            Console.WriteLine($"Notes: {string.Join(" ", listedNotes)}");
            //getting sharps and naturals
            List<string> sharps = new List<string>();
            List<string> naturals = new List<string>();

            foreach (var note in listedNotes)
            {
                if (note.Contains("#"))
                {
                    sharps.Add(note);
                }
                else
                {
                    naturals.Add(note);
                }
            }

            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");

            double naturalsSum = 0.0;
            foreach (var note in naturals)
            {
                foreach (var kvp in noteFreqs)
                {
                    var noteName = kvp.Key;
                    var freqNum = kvp.Value;
                    if (note == noteName)
                    {
                        naturalsSum += freqNum;
                    }
                }
            }
            
            Console.WriteLine($"Naturals sum: {naturalsSum}");

            double sharpsSum = 0.0;
            foreach (var note in sharps)
            {
                foreach (var kvp in noteFreqs)
                {
                    var noteName = kvp.Key;
                    var freqNum = kvp.Value;
                    if (note == noteName)
                    {
                        sharpsSum += freqNum;
                    }
                }
            }
            Console.WriteLine($"Sharps sum: {sharpsSum}");
     
        }
    }
}
