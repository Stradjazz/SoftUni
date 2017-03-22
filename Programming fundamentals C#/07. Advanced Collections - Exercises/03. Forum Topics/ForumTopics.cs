using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Forum_Topics
{
    /*  You have been tasked to store a few forum topics, and filter them by several given tags.
        You will be given several input lines, containing data about topics in the following format:
        {topic} -> {tag1, tag2, tag3. . .}
        The topic and tags will be strings. They will NOT contain spaces or ‘-’, ‘>’ symbols.
        If you receive an existent topic, you must add the new tags to it. There should be NO duplicate tags. 
        When you receive the command “filter”, you must end the input sequence. On the next line (after “filter”), you will receive a 
        sequence of tags, separated by a comma and a space. You must print ONLY those topics, which CONTAIN ALL tags in the given sequence.
        The topics must be printed in the following format:
        {topic} | {#tag1, #tag2, #tag3. . .}
        NOTE: The tags have a hashtag (‘#’) as a prefix. */
    class ForumTopics
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> topics = new Dictionary<string, List<string>>();
            string inputline = Console.ReadLine();

            while (inputline != "filter" )
            {
                var inputData = inputline.Split(new[] { '-', '>', ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
                var currentKey = inputData[0];
                
                if (!topics.ContainsKey(currentKey))
                {
                    topics[currentKey] = new List<string>();
                }
                for (int i = 1; i < inputData.Length; i++)
                {
                    topics[currentKey].Add(inputData[i]);
                }
                inputline = Console.ReadLine();
            }
            var tagSequence = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var keysToInclude = new List<string>();

            foreach (var topic in topics)
            {
                var currentKey = topic.Key;
                var currentTagList = topic.Value;
                var tagCounter = 0;
                foreach (var tag in tagSequence)
                {
                    if (currentTagList.Contains(tag))
                    {
                        tagCounter++;
                    }
                    if (tagSequence.Count == tagCounter)
                    {
                        keysToInclude.Add(currentKey);
                    }
                }
                var keysToRemove = topics.Keys.Except(keysToInclude).ToList();
                foreach (var keyEntry in keysToRemove)
                {
                    topics.Remove(keyEntry);
                }
            }
            foreach (var entry in topics)
            {
                Console.WriteLine($"{entry.Key} | #{string.Join(", #", entry.Value)}");
            }           
        }
    }
}
