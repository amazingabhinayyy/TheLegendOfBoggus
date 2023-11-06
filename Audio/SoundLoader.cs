using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using Sprint2_Attempt3;

namespace Sprint2_Attempt3
{
    public class SoundLoader
    {

        private readonly Dictionary<SoundEnum, SoundEffect> soundEffects;

        public SoundLoader(Game1 game)
        {
            /*songs = new List<Song>();
            for (int i = 1; i <= numSongs; i++)
                songs.Add(game.Content.Load<Song>("Sound/music" + i));*/

            game.Content.Load<SoundEffect>("Sound/Underworld_BGM");

            soundEffects = new Dictionary<SoundEnum, SoundEffect>
            {
                { SoundEnum.SwordSlash, game.Content.Load<SoundEffect>("Sound/Sword_Slash") },
                /*
                { SoundEnum.SwordShoot, game.Content.Load<SoundEffect>("Sound/Sword_Shoot") },
                { SoundEnum.Arrow, game.Content.Load<SoundEffect>("Sound/Arrow_Boomerang") },
                { SoundEnum.Boomerang, game.Content.Load<SoundEffect>("Sound/Arrow_Boomerang") },
                { SoundEnum.Shield, game.Content.Load<SoundEffect>("Sound/Shield") },
                { SoundEnum.UseBomb, game.Content.Load<SoundEffect>("Sound/Bomb_Drop") },
                { SoundEnum.BombExplode, game.Content.Load<SoundEffect>("Sound/Bomb_Blow") },
                { SoundEnum.Candle, game.Content.Load<SoundEffect>("Sound/Candle") },
                { SoundEnum.MagicalRod, game.Content.Load<SoundEffect>("Sound/MagicalRod") },
                { SoundEnum.Flute, game.Content.Load<SoundEffect>("Sound/Recorder") },
                { SoundEnum.EnemyDamaged, game.Content.Load<SoundEffect>("Sound/Enemy_Hit") },
                { SoundEnum.EnemyDeath, game.Content.Load<SoundEffect>("Sound/Enemy_Die") },
                { SoundEnum.LinkDamaged, game.Content.Load<SoundEffect>("Sound/Link_Hurt") },
                { SoundEnum.LinkDeath, game.Content.Load<SoundEffect>("Sound/Link_Die") },
                { SoundEnum.LowHealth, game.Content.Load<SoundEffect>("Sound/LowHealth") },
                { SoundEnum.NewItem, game.Content.Load<SoundEffect>("Sound/Fanfare") },
                { SoundEnum.GetItem, game.Content.Load<SoundEffect>("Sound/Get_Item") },
                { SoundEnum.GetHeart, game.Content.Load<SoundEffect>("Sound/Get_Heart") },
                { SoundEnum.GetKey, game.Content.Load<SoundEffect>("Sound/Get_Heart") },
                { SoundEnum.GetRupee, game.Content.Load<SoundEffect>("Sound/Get_Rupee") },
                { SoundEnum.Refill, game.Content.Load<SoundEffect>("Sound/Refill_Loop") },
                { SoundEnum.TextAppear, game.Content.Load<SoundEffect>("Sound/Text") },
                { SoundEnum.TextAppearSlow, game.Content.Load<SoundEffect>("Sound/Text_Slow") },
                { SoundEnum.KeyAppear, game.Content.Load<SoundEffect>("Sound/Key_Appear") },
                { SoundEnum.UnlockDoor, game.Content.Load<SoundEffect>("Sound/Door_Unlock") },
                { SoundEnum.Aquamentus, game.Content.Load<SoundEffect>("Sound/Boss_Scream1") }, */

            };

        }


        public SoundEffect GetSoundEffect(SoundEnum soundEffectType)
        {
            return soundEffects[soundEffectType];
        }
    }
}