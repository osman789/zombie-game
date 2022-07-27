using System;
using NAudio.Wave;

namespace Zombie_Game
{
    public class Sound
    {
        private WaveStream _soundplayerBgStream;
        private WaveOut _soundplayerBgOut;
        private WaveStream _soundShotgunplayerStream;
        private WaveOut _soundShotgunplayerOut;
        private WaveStream _soundSplatplayerStream;
        private WaveOut _soundSplatplayerOut;

        public Sound()
        {
            var soundBgFile = System.IO.Directory.GetCurrentDirectory() + "\\sounds\\gamebackground.wav";
            var soundShotgunFile = System.IO.Directory.GetCurrentDirectory() + "\\sounds\\shotgun.wav";
            var soundSplatFile = System.IO.Directory.GetCurrentDirectory() + "\\sounds\\splat.wav";

            //instiate Background sound
            _soundplayerBgStream = new AudioFileReader(soundBgFile);
            _soundplayerBgOut = new WaveOut();
            _soundplayerBgOut.Init(_soundplayerBgStream);

            //initiate the shuthug
            _soundSplatplayerStream = new AudioFileReader(soundSplatFile);
            _soundSplatplayerOut = new WaveOut();
            _soundSplatplayerOut.Init(_soundSplatplayerStream);


            //instiate Background sound
            _soundplayerBgStream = new AudioFileReader(soundBgFile);
            _soundplayerBgOut = new WaveOut();
            _soundplayerBgOut.Init(_soundplayerBgStream);

            //initialize the shuthug
            _soundShotgunplayerStream = new AudioFileReader(soundShotgunFile);
            _soundShotgunplayerOut = new WaveOut();
            _soundShotgunplayerOut.Init(_soundShotgunplayerStream);


            //start the sound
            _soundplayerBgOut.Play();


        }


        public void PlayShotgunSound()
        {
            if (_soundplayerBgOut.PlaybackState is PlaybackState.Playing) _soundplayerBgOut.Stop();
            if (_soundShotgunplayerOut.PlaybackState is PlaybackState.Playing) _soundShotgunplayerOut.Stop();

            _soundplayerBgStream.CurrentTime = new TimeSpan(0L);
            _soundShotgunplayerStream.CurrentTime = new TimeSpan(0L);
            _soundShotgunplayerOut.Play();
            _soundplayerBgOut.Play();


        }


        public void PlaySplatSound()
        {
            if (_soundplayerBgOut.PlaybackState is PlaybackState.Playing) _soundplayerBgOut.Stop();
            if (_soundSplatplayerOut.PlaybackState is PlaybackState.Playing) _soundSplatplayerOut.Stop();

            _soundplayerBgStream.CurrentTime = new TimeSpan(0L);
            _soundSplatplayerStream.CurrentTime = new TimeSpan(0L);
            _soundSplatplayerOut.Play();
            _soundplayerBgOut.Play();








    }   } 
}
