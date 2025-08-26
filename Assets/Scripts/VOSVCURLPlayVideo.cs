using Unity.PolySpatial;
using UnityEngine;

public class VOSVCURLPlayVideo : MonoBehaviour
{
    [SerializeField]
    VisionOSVideoComponent visionOSVideoComponent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        visionOSVideoComponent.Url = "file://" + Application.streamingAssetsPath + "/TempTemp.mp4";
        Debug.Log("URL:" + visionOSVideoComponent.Url);
    }
}
