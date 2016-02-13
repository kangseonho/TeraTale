﻿using System.Collections.Generic;
using TeraTaleNet;
using UnityEngine;

public class Tree : Enemy
{
    //protected override void PeriodicSync()
    //{ }

    public override float moveSpeed { get { return 0; } }

    protected override List<Item> itemsForDrop
    {
        get
        {
            List<Item> ret = new List<Item>();
            if (Random.Range(0, 2) == 0)
                ret.Add(new Apple());
            ret.Add(new Log());
            ret.Add(new Log());
            ret.Add(new Log());
            ret.Add(new Log());
            ret.Add(new Log());
            ret.Add(new Log());
            ret.Add(new Log());
            ret.Add(new Log());
            ret.Add(new Log());
            ret.Add(new Log());
            return ret;
        }
    }

    protected override float levelForDrop
    { get { return 10; } }

    protected override float CalculateDamage(Damage damage)
    {
        if (damage.weaponType != Weapon.Type.axe)
        {
            if (damage.sendedUser == userName)
                ChattingView.instance.PushGuideMessage("나무는 '도끼'로 벌목할 수 있습니다.");
            return 0;
        }
        return damage.amount;
    }
}