using UnityEngine;

public class autoMaterial : MonoBehaviour
{
    public Material autoMatic;

    void Update()
    {
        MeshRenderer[] meshRenderers = GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer renderer in meshRenderers)
        {
            renderer.material = autoMatic;
        }
    }
}
