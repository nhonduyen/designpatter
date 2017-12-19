using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class VlcPlayer:AdvanceMediaPlayer
    {
        public void playVlc(string fileName)
        {
            Console.WriteLine("Play vlc : {0}", fileName);
        }
        public void playMp4(string fileName)
        {
        }
    }
}
