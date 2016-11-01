using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourChapter10
{
    class Program
    {
        static void Main(string[] args)
        {
            Video newVid = new Video() { Title = "Back to the future", videoRuntime = 1.56 };

            List<Video> add = new List<Video>();
            add.Add(new Video { Title = "Back to the future", videoRuntime = 1.56 });
            add.Add(new Video { Title = "host", videoRuntime = 1.20 });
            add.Add(new Video { Title = "world war z", videoRuntime = 0.9 });

            VideoEncoder decode = new VideoEncoder();           
            Rewind rewind = new Rewind();
            Run runt = new Run();

            decode.videoComplete += runt.onRuntime;
            decode.videoComplete+= rewind.onprocessComplete;

            decode.Encode(newVid);
            decode.videoComplete -= rewind.onprocessComplete;
            decode.Encode(newVid);
        

            ////////////////////
            Console.Write("end");
            ///////////////////////
            Console.ReadKey();
        }
        
    }
}
