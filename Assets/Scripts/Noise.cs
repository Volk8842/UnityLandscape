using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Noise {
    public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale)
    {
        float[,] noiseMap = new float[mapWidth, mapHeight];
        
        if (scale <= 0)
        {
            scale = 0.0001f;
        }

        for (int j = 0; j < mapHeight; ++j)
        {
            float sampleY = j / scale;
            for (int i = 0; i < mapWidth; ++i)
            {
                float sampleX = i / scale;
                
                noiseMap[i, j] = Mathf.PerlinNoise(sampleX, sampleY);
            }
        }

        return noiseMap;
    }
}
