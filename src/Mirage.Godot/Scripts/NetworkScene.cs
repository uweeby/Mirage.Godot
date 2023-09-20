using Godot;

namespace Mirage
{
    public partial class NetworkScene : Node
    {
        [Export] private NetworkIdentity[] SceneObjects;

        public void SpawnSceneObjects(NetworkServer server)
        {
            // todo add Spawn Many function
            foreach (var obj in SceneObjects)
            {
                server.Spawn(obj);
            }
        }

        public void PrepareSceneObjects(NetworkClient client)
        {
            foreach (var obj in SceneObjects)
            {
                obj.Prepare(false);
            }

            client.RegisterPrefabs(SceneObjects, false);
        }
    }
}
