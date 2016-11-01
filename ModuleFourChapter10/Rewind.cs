using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourChapter10
{
    public class Rewind
    {
        public void onprocessComplete(object vid, VideoEventArgs e)
        {
            Console.WriteLine("Rewind the tape {0} runtime {1}", e.video.Title, e.video.videoRuntime );
            
        }
    }
}
