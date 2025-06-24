using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerManager : MonoBehaviour
{
    [SerializeField]
    private Material skyboxMaterial;
    
    [SerializeField]
    private VideoPlayer player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RenderSettings.skybox = skyboxMaterial;
        player.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
