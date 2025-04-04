using UnityEngine;

public class enableMeshRenderers : MonoBehaviour
{
    // This will be called when the script runs
    [ContextMenu("Enable All Mesh Renderers")]
    void EnableAllMeshRenderers()
    {
        // Find all MeshRenderer components in the scene (use FindObjectsByType for better performance)
        MeshRenderer[] meshRenderers = UnityEngine.Object.FindObjectsByType<MeshRenderer>(UnityEngine.FindObjectsSortMode.None);

        // Loop through each MeshRenderer and enable it
        foreach (MeshRenderer renderer in meshRenderers)
        {
            renderer.enabled = true;
        }

        Debug.Log("All MeshRenderers have been enabled!");
    }
}
