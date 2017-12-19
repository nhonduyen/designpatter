using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.play("mp3", "test.mp3");
            audioPlayer.play("mp4", "test.mp4");
            audioPlayer.play("vlc", "test.vlc");
        }
    }
}
