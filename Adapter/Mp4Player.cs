using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Mp4Player:AdvanceMediaPlayer
    {
        public void playVlc(string fileName)
        {
            
        }
        public void playMp4(string fileName)
        {
            Console.WriteLine("Play mp4 : {0}", fileName);
        }
    }
}
