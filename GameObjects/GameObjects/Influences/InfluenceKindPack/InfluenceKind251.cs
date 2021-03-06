﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind251 : InfluenceKind
    {
        private int increment = 0;

        public override void ApplyInfluenceKind(Troop troop)
        {
            if (troop != null)
            {
                troop.IncrementOfMovability += this.increment;
            }
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

        public override void PurifyInfluenceKind(Troop troop)
        {
            if (troop != null)
            {
                troop.IncrementOfMovability -= this.increment;
            }
        }
    }
}

