# VP_Bounded_SimpleFlatVideo

- MR(Bounded), RealityKit
- Using Video Player Component
- There are limitations to using the Video Player Component within PolySpatial
  - Refer: [Unity Video Player Support](https://docs.unity3d.com/Packages/com.unity.polyspatial.visionos@2.2/manual/VideoComponent.html#unity-video-player-support)
- If gonna update a RenderTexture outside of a call to `Camera.Render` needs to be updated manually
  - [Manual Dirtying Documentation](https://docs.unity3d.com/Packages/com.unity.polyspatial.visionos@2.2/manual/RenderTextures.html#manual-dirtying)
- The following are the steps for implementing the "Screen" object in this scene
  - Create `M_FlatVideo` material (URP/Unlit)
  - Add a Quad mesh to the scene and use the `M_FlatVideo` to the mesh material
  - Create `RT_Video` Render Texture
  - Set `RT_Video` as `M_FlatVideo`'s Base Map
  - Add Video Player Component to GameObject
    - Set the Render Mode to Render Texture
    - Set the Video Clip and Target Texture (`RT_Video`)
  - Create `SetRenderTextureDirty` MonoBehaviour script for manual Render Texture updates
    - Set the `RT_Video` to `SetRenderTextureDirty`