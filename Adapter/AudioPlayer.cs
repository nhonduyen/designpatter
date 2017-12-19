using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Play mp3: {0}", fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase) || audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Format does not support");
            }
        }
    }
}
