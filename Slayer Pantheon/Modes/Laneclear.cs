﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK.Rendering;
using SharpDX;

namespace Slayer_Pantheon.Modes
{
    class Laneclear
    {
        public static void Init()
        {
            var Minions = EntityManager.MinionsAndMonsters.GetLaneMinions(EntityManager.UnitTeam.Enemy, Player.Instance.Position, Pantheon.Q.Range);

            foreach (var Minion in Minions)
            {
                if (PantheonMenu.CheckBox(PantheonMenu.Laneclear, "Q"))
                {
                    if (Minion.IsValidTarget(Pantheon.Q.Range))
                    {
                        if(Pantheon.Q.IsReady())
                        {
                            Pantheon.Q.Cast(Minion);
                        }
                    }
                }

                if (PantheonMenu.CheckBox(PantheonMenu.Laneclear, "E"))
                {
                    if (Minion.IsValidTarget(Pantheon.E.Range))
                    {
                        if (Pantheon.E.IsReady())
                        {
                            Pantheon.E.Cast(Minion);
                        }
                    }
                }
            }
        }
    }
}
