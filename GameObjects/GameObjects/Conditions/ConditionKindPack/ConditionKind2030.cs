﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind2030 : ConditionKind
    {
        private int cnt = 0;
        private int val = 0;

        public override bool CheckConditionKind(Architecture a)
        {
            return CheckConditionKind(a.BelongedFaction);
        }

        public override bool CheckConditionKind(Faction a)
        {
            int i = 0;
            foreach (Person p in a.Persons)
            {
                if (p.Politics >= val)
                {
                    i++;
                    if (i >= cnt)
                        return true;
                }
            }
            return false;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.cnt = int.Parse(parameter);
            }
            catch
            {
            }
        }

        public override void InitializeParameter2(string parameter)
        {
            try
            {
                this.val = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

