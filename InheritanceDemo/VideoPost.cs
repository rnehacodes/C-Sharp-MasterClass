using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class VideoPost : Post
    {
        protected string VideoURL { get; set; }
        protected int Length { get; set; }
        protected int CurrentDuration { get; set; }
        protected bool IsPlaying { get; set; }
        Timer timer;

        public VideoPost()
        {
            //
        }
        public VideoPost(string title, bool isPublic, string sendByUsername, string videoURL, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.Length = length;
        }
        public override string ToString()
        {
            if(this.IsPublic)
            {
                return String.Format("{0} - {1} - {2}, Length : {3} - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
            }
            else
            {
                return "This Post is restricted";
            }
        }
        public void Play()
        {
            if(!IsPlaying)
            {
                IsPlaying = true;
                Console.WriteLine("Video started");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }
        private void TimerCallback(object o)
        {
            if(CurrentDuration < Length)
            {
                CurrentDuration++;
                Console.WriteLine("Video is playing at {0}s", CurrentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if(IsPlaying)
            {
                IsPlaying = false;
                Console.WriteLine("\nVideo stopped at {0}", CurrentDuration);
                CurrentDuration = 0;
                timer.Dispose();
            }
        }
    }
}
