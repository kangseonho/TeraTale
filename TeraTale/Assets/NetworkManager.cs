﻿using System;
using TeraTaleNet;

public class NetworkManager : UnityServer
{
    public PacketStream stream;
    Messenger _messenger = new Messenger();

    protected override void OnStart()
    {
        _messenger.Register("", stream);
        _messenger.Start();
    }

    protected override void OnEnd()
    {
        StopAllCoroutines();
        _messenger.Dispose();
    }

    protected override void OnUpdate()
    {
        if (Console.KeyAvailable)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                Stop();
        }
    }
}