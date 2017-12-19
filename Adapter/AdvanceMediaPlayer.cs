using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface AdvanceMediaPlayer
    {
        void playVlc(string fileName);
        void playMp4(string fileName);
    }
}
