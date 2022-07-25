using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Zombie_Game
{
    public class Sound
    {
        private SoundPlayer _soundplayer;

        public Sound()
        {
            var soundfile = System.IO.Directory.GetCurrentDirectory() + "\\sounds\\gamebackground.wav";
            _soundplayer = new SoundPlayer(soundfile);

        }


        public void PlayBackgroundSound()
        {
            try
            {
                //_soundplayer.Play();
                _soundplayer.PlayLooping();
            }
            catch (Exception ex)
            {

               //logs
            }
           
        }

        public void StopBackgroundSound()
        {
            _soundplayer.Stop();
        }
    }
}
