﻿using GameServerCore.Content;
using GameServerCore.Domain.GameObjects.Spell;
using LeagueSandbox.GameServer.Content;

namespace GameServerCore.Domain
{
    public interface IPackage
    {
        string PackageName { get; }
        string PackagePath { get; }
        void LoadPackage(string packageName);
        bool LoadScripts();
        IContentFile GetContentFileFromJson(string contentType, string itemName);
        INavigationGrid GetNavigationGrid(int mapId);
        ISpellData GetSpellData(string spellName);
        ICharData GetCharData(string characterName);
    }
}
