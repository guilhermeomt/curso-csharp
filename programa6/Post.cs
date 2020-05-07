using System;
using System.Collections.Generic;

namespace programa6
{
    public class Post
    {
         public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();


        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            this.Moment = moment;
            this.Title = title;
            this.Content = content;
            this.Likes = likes;
        }

        

    }
}