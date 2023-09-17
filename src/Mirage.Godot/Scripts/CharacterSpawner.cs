﻿using Godot;
using Mirage;

namespace MirageGodot
{
    public partial class CharacterSpawner : Node
    {
        [Export] private NetworkManager _networkManager;
        [Export] private bool _spawnOnConnect;

        public override void _Ready()
        {
            _networkManager.Server.Connected += Server_Connected;
        }

        private void Server_Connected(INetworkPlayer obj)
        {
            if (_spawnOnConnect)
            {

            }
        }

        public void SpawnCharacter()
        {
            // todo create character, and add to player
            //_networkManager.Server.Spawn();
        }
    }
}