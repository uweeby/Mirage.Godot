using System.Collections.Generic;
using Mirage.Collections;

namespace Mirage
{
    /// <summary>
    /// Extension and static methods, mostly used by weaver 
    /// </summary>
    public static class NetworkNodeExtensinos
    {
        // todo decide which of these should be extension methods vs static only
        public static bool IsServerMethod(this INetworkNode node) => node.Identity.IsServer;
        public static bool IsClientMethod(this INetworkNode node) => node.Identity.IsClient;
        public static bool HasAuthorityMethod(this INetworkNode node) => node.Identity.HasAuthority;
        public static bool IsMainCharacterMethod(this INetworkNode node) => node.Identity.IsMainCharacter;

        public static NetworkServer ServerMethod(this INetworkNode node) => node.Identity.Server;
        public static NetworkClient ClientMethod(this INetworkNode node) => node.Identity.Client;

        public static NetworkPlayer GetClientPlayer(INetworkNode node) => node.Identity.Client.Player;
        public static NetworkPlayer GetServerLocalPlayer(INetworkNode node) => node.Identity.Server.LocalPlayer;

        public static void InitSyncObject(NetworkBehaviour behaviour, ISyncObject syncObject) => behaviour.NetworkNodeSyncVars.InitSyncObject(syncObject);
        public static void SetDeserializeMask(NetworkBehaviour behaviour, ulong dirtyBit, int offset) => behaviour.NetworkNodeSyncVars.SetDeserializeMask(dirtyBit, offset);
        public static ulong SyncVarDirtyBits(NetworkBehaviour behaviour) => behaviour.NetworkNodeSyncVars._syncVarDirtyBits;
        public static void SetDirtyBit(NetworkBehaviour behaviour, ulong bitMask) => behaviour.NetworkNodeSyncVars.SetDirtyBit(bitMask);
        public static bool GetSyncVarHookGuard(NetworkBehaviour behaviour, ulong bitMask) => behaviour.NetworkNodeSyncVars.GetSyncVarHookGuard(bitMask);
        public static void SetSyncVarHookGuard(NetworkBehaviour behaviour, ulong bitMask, bool value) => behaviour.NetworkNodeSyncVars.SetSyncVarHookGuard(bitMask, value);
        public static bool SyncVarEqual<T>(T value, T fieldValue) => EqualityComparer<T>.Default.Equals(value, fieldValue);
    }
}
