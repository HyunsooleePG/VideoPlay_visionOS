using UnityEngine;

public class SetRenderTextureDirty : MonoBehaviour
{
    [SerializeField]
    private RenderTexture renderTexture;
    
    void Update()
    {
        Unity.PolySpatial.PolySpatialObjectUtils.MarkDirty(renderTexture);
    }
}