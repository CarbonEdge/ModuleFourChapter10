using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourChapter10
{
    class Run
    {
        public void onRuntime(object vid, VideoEventArgs e)
        {
            Console.WriteLine("The video is playing: {0}", e.video.Title);

        }
    }
}
