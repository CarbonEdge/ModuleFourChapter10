using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ModuleFourChapter10
{
    public class VideoEventArgs: EventArgs
    {
        public Video video { get; set; }
    }
    public class VideoEncoder
    {
        //public delegate void encoder(object vid, VideoEventArgs e); redundant
        public event EventHandler<VideoEventArgs> videoComplete;
        public void Encode(Video vid)
        {
            Console.WriteLine("start video "+ vid.Title);
            Thread.Sleep(300);
            onprocessComplete(vid);
        }

        public virtual void onprocessComplete(Video vid)
        {
            if(videoComplete!=null)
            {
                videoComplete(this, new VideoEventArgs() { video = vid});
            }
        }
    }
}
