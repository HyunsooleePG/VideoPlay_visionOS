# VOSVC_Unbounded_SimpleFlatVideo

- Using the Vision OS Video Component
- To use the Vision OS Video Component need to Mesh Renderer object
- There are limitations to using the Vision OS Video Component
  - [VisionOSVideoComponent Documentation](https://docs.unity3d.com/Packages/com.unity.polyspatial.visionos@2.2/manual/VideoComponent.html#visionosvideocomponent)
  - The video asset has to be placed in two places
  - One, Source video asset placed somewhere under the Assets; This asset will be set to the Vision OS Video Component
  - Two, copied video asset under the `Assets/StreamingAssets/VisionOSVideoClips/`
  - e.g. `Assets/Video/A.mp4`, `Assets/StreamingAssets/VisionOSVideoClips/A.mp4`
- The Vision OS Video Component will not work with debugging tools like PlayToDevice
- The following are the steps for implementing the "Screen" object in this scene
  - Add a Quad mesh to the scene
  - Add Vision OS Video Component to the GameObject
    - Set the Mesh Renderer and the Video Clip
