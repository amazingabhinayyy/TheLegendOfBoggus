using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Media;

namespace Sprint2_Attempt3
{
    public class BackgroundMusic
    {
        //private readonly List<Song> songs;
        public string currSong;

        public BackgroundMusic()
        {
            /*this.songs = songs;
            currSong = 0;*/
            currSong = "Underworld_BGM";
            Play();
        }

        public void Toggle()
        {
            if (MediaPlayer.State.Equals(MediaState.Playing))
                Stop();
            else
                Play();
        }

        public void SkipSong() => MediaPlayer.Stop();

        public void Update()
        {
            if (MediaPlayer.State.Equals(MediaState.Stopped))
                Play();
        }

        private void Play()
        {
            /*if (MediaPlayer.State.Equals(MediaState.Paused))
                MediaPlayer.Resume();
            else if (MediaPlayer.State.Equals(MediaState.Stopped))
            {*/
            //MediaPlayer.Play(currSong);
            //currSong = (currSong + 1) % songs.Count;
            //}
            //MediaPlayer.Play(currSong);
        }

        private void Stop() => MediaPlayer.Pause();
    }
}