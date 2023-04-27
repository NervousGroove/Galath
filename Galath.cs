using UnityEngine.Vulkan;

public class GraphicsConfig : MonoBehaviour
{
    void Start()
    {
        // Get the user's hardware information
        var graphicsMemorySize = SystemInfo.graphicsMemorySize;
        var graphicsDeviceName = SystemInfo.graphicsDeviceName;

        // Set default graphics quality to low
        QualitySettings.SetQualityLevel(0);

        // Check if the graphics memory size is greater than or equal to 4096 MB
        if (graphicsMemorySize >= 4096)
        {
            // Set graphics quality to ultra
            QualitySettings.SetQualityLevel(5);
        }
        // Check if the graphics memory size is greater than or equal to 2048 MB
        else if (graphicsMemorySize >= 2048)
        {
            // Set graphics quality to high
            QualitySettings.SetQualityLevel(4);
        }
        // Check if the graphics memory size is greater than or equal to 1024 MB
        else if (graphicsMemorySize >= 1024)
        {
            // Set graphics quality to medium
            QualitySettings.SetQualityLevel(3);
        }
        // Otherwise, set graphics quality to low
        else
        {
            QualitySettings.SetQualityLevel(0);
        }

        // Enable Vulkan graphics
        GraphicsDeviceType[] api = new GraphicsDeviceType[] { GraphicsDeviceType.Vulkan };
        PlayerSettings.SetGraphicsAPIs(BuildTarget.StandaloneWindows, api);
    }
}