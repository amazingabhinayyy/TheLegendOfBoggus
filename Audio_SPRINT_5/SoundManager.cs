using System;
using Microsoft.Xna.Framework.Audio;

namespace Sprint2_Attempt3
{
    public abstract class SoundManager
    {
        private static bool isMuted = false;
        public SoundEffectInstance SoundEffectInstance { get; }

        public SoundManager(SoundEffect soundEffect)
        {
            SoundEffectInstance = soundEffect.CreateInstance();
            SoundEffectInstance.IsLooped = false;
            Play();
        }

        public void Play()
        {
            if (!isMuted && SoundEffectInstance.State != SoundState.Playing)
                SoundEffectInstance.Play();
        }

        public void Stop()
        {
            if (SoundEffectInstance.State == SoundState.Playing)
                SoundEffectInstance.Stop();
        }

        private void CheckMuted()
        {
            if (isMuted)
                Stop();
        }

        public bool IsDone()
        {
            CheckMuted();
            return SoundEffectInstance.State != SoundState.Playing;
        }

        public static void ToggleMute() => isMuted = !isMuted;
    }
}