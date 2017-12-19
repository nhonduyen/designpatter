using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MediaAdapter:MediaPlayer
    {
        AdvanceMediaPlayer advancedMusicPlayer;
        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }

        public void play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer.playVlc(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                advancedMusicPlayer.playMp4(fileName);
            }
        }
    }
}
