﻿namespace GameObjects.ArchitectureDetail.EventEffect
{
    using GameObjects;
    using System;

    internal class EventEffect1010 : EventEffectKind
    {
        private int increment;

        public override void ApplyEffectKind(Architecture a, Event e)
        {
            a.IncreaseCommerce(increment);
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

