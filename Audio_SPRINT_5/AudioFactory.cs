﻿using System;
using Microsoft.Xna.Framework.Audio;
using Sprint2_Attempt3;

namespace Sprint2_Attempt3
{
    public enum SoundEnum
    {
        SwordSlash, SwordShoot, Arrow, Boomerang, Shield, UseBomb, BombExplode, Candle,
        EnemyDamaged, EnemyDeath, LinkDamaged, LinkDeath, LowHealth,
        NewItem, GetItem, GetHeart, GetKey, GetRupee,
        Aquamentus, Gleeok, Ganon, Dodongo, Gohma, Manhandla, Digdogger, Patra,
        MagicalRod, Flute, Refill, TextAppear, TextAppearSlow, KeyAppear, UnlockDoor,
        Stairs, Shore, Secret, Note1, Note2, Note3, Note4, Note5, Note6, Owl
    }
    public class AudioFactory
    {
        private readonly SoundLoader soundLoader;

        //public SoundFactory(Game1 game) => soundLoader = new SoundLoader(game);

        public static object Instance { get; internal set; }

        //public BackgroundMusic MakeBackgroundMusic()
        // => new BackgroundMusic(soundLoader.GetMusic());



        public SoundManager MakeSoundEffect(SoundEnum soundEffectType)
        {
            SoundEffect soundEffect = soundLoader.GetSoundEffect(soundEffectType);
            return soundEffectType switch
            {
                SoundEnum.SwordSlash => new SwordSlashSoundEffect(soundEffect),
               /*
                SoundEnum.SwordShoot => new SwordShootSoundEffect(soundEffect),
                SoundEnum.Arrow => new ArrowSoundEffect(soundEffect),
                SoundEnum.Boomerang => new BoomerangSoundEffect(soundEffect),
                SoundEnum.Shield => new ShieldSoundEffect(soundEffect),
                SoundEnum.UseBomb => new UseBombSoundEffect(soundEffect),
                SoundEnum.BombExplode => new BombExplodeSoundEffect(soundEffect),
                SoundEnum.Candle => new CandleSoundEffect(soundEffect),
                SoundEnum.EnemyDamaged => new EnemyDamagedSoundEffect(soundEffect),
                SoundEnum.EnemyDeath => new EnemyDeathSoundEffect(soundEffect),
                SoundEnum.LinkDamaged => new LinkDamagedSoundEffect(soundEffect),
                SoundEnum.LinkDeath => new LinkDeathSoundEffect(soundEffect),
                SoundEnum.LowHealth => new LowHealthSoundEffect(soundEffect),
                SoundEnum.NewItem => new NewItemSoundEffect(soundEffect),
                SoundEnum.GetItem => new GetItemSoundEffect(soundEffect),
                SoundEnum.GetHeart => new GetHeartSoundEffect(soundEffect),
                SoundEnum.GetKey => new GetKeySoundEffect(soundEffect),
                SoundEnum.GetRupee => new GetRupeeSoundEffect(soundEffect),
                SoundEnum.Aquamentus => new AquamentusSoundEffect(soundEffect), */
                _ => throw new ArgumentException("Invalid sound effect! " + soundEffectType.ToString() + " Sound factory failed."),
            };
        }
    }
}