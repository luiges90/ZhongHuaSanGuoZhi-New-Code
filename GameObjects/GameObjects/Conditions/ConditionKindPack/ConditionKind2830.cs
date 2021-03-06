﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind2830 : ConditionKind
    {
        private int number = 0;

        public override bool CheckConditionKind(Architecture a)
        {
            foreach (Person p in a.Feiziliebiao)
            {
                if (p.ID == number)
                {
                    return true;
                }
            }
            return false;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.number = int.Parse(parameter);
            }
            catch
            {
            }
        }

    }
}

