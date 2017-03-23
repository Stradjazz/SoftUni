using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Social_Media_Posts
{
    /*  You have been tasked to create a Console Social Media Database.
You will receive several input lines in one of the following formats:
•	post {postName}
•	like {postName}
•	dislike {postName}
•	comment {postName} {commentatorName} {content}
If you receive the post command, you must create a post with the given name. If you receive the like command you must add a like to the given post.
If you receive the dislike command you must add a dislike to the given post.
If you receive the comment command, you must add a comment to the given post. The comment’s writer must be the given commentator name, 
and the content of the comment must be the given content. By default the posts have 0 likes, 0 dislikes and 0 comments, when created.
When you receive the command “drop the media” you must end the input sequence, and you must print every post with its likes, disliked and 
comments in the following format:
Post: {postName} | Likes: {likes} | Dislikes {dislikes}
Comments:
*  {commentator1}: {comment1}
*  {commentator2}: {comment2}
If a certain post does NOT have ANY comments, you should just print “None”.
The comments have a prefix of a single asterisk (‘*’) and 2 spaces. There is NO space between the commentator’s name and the colon. */
    class SocialMediaPosts
    {
        static void Main(string[] args)
        {
            var socialMedia = new Dictionary<string, Dictionary<string, List<string>>>();
            var input = Console.ReadLine();

            while (input != "drop the media")
            {
                var tokens = input.Split(' ').ToArray();
                var command = tokens[0];
                var postName = tokens[1];

                if (!socialMedia.ContainsKey(postName))
                {
                    socialMedia[postName] = new Dictionary<string, List<string>>();
                }
                if (command == "like")
                {
                    if (!socialMedia[postName].ContainsKey("Like"))
                    {
                        socialMedia[postName]["Like"] = new List<string>();
                    }

                    socialMedia[postName]["Like"].Add(command);
                }
                else if (command == "dislike")
                {
                    if (!socialMedia[postName].ContainsKey("Dislike"))
                    {
                        socialMedia[postName]["Dislike"] = new List<string>();
                    }

                    socialMedia[postName]["Dislike"].Add(command);
                }
                else if (command == "comment")
                {
                    var writer = tokens[2];
                    int length = command.Length + postName.Length + writer.Length + 3;
                    var comment = input.Substring(length);
                    if (!socialMedia[postName].ContainsKey(writer))
                    {
                        socialMedia[postName][writer] = new List<string>();
                    }

                    socialMedia[postName][writer].Add(comment);
                }

                input = Console.ReadLine();
            }

            foreach (var post in socialMedia)
            {
                var likes = 0;
                var dislikes = 0;
                var writers = post.Value;
                foreach (var item in post.Value)
                {
                    if (item.Key == "Like")
                    {
                        likes = item.Value.Count;
                    }
                    else if (item.Key == "Dislike")
                    {
                        dislikes = item.Value.Count;
                    }
                }
                Console.WriteLine($"Post: {post.Key} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");

                bool noComment = true;
                foreach (var comment in writers)
                {
                    if (comment.Key != "Like" && comment.Key != "Dislike")
                    {
                        noComment = false;
                        foreach (var com in comment.Value)
                        {
                            Console.WriteLine($"*  {comment.Key}: {com}");
                        }
                    }
                }

                if (noComment)
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}
