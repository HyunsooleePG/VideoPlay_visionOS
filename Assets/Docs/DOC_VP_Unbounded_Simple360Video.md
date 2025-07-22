# VP_Unbounded_Simple360Video

- MR(Unbounded), RealityKit
- Using Video Player Component
- There are limitations to using the Video Player Component within PolySpatial
  - Refer: [Unity Video Player Support](https://docs.unity3d.com/Packages/com.unity.polyspatial.visionos@2.2/manual/VideoComponent.html#unity-video-player-support)
- If gonna update a RenderTexture outside of a call to `Camera.Render` needs to be updated manually
  - [Manual Dirtying Documentation](https://docs.unity3d.com/Packages/com.unity.polyspatial.visionos@2.2/manual/RenderTextures.html#manual-dirtying)
- The following are the steps for implementing the "360Screen" object in this scene
  - Create `M_360Video` material (URP/Unlit)
    - The Render Face is set to 'Back' for rendering the video on the inside of the sphere
  - Add a Sphere mesh to the scene and use the `M_360Video` to the mesh material
  - Create `RT_1440pVideo` Render Texture
  - Set `RT_1440pVideo` as `M_360Video`'s Base Map
  - Add Video Player Component to GameObject
    - Set the Render Mode to Render Texture
    - Set the Video Clip and Target Texture (`RT_1440pVideo`)
  - Create `SetRenderTextureDirty` MonoBehaviour script for manual Render Texture updates
    - Set the `RT_1440pVideo` to `SetRenderTextureDirty`
