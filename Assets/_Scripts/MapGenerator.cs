using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] private int mapWidth;
    [SerializeField] private int mapHeight;
    [SerializeField] private float noiseScale;

    public bool autoUpdate;

    public void GenerateMap()
    {
        if (mapWidth <= 0) mapWidth = 1;
        if (mapHeight <= 0) mapHeight = 1;

        float[,] noiseMap = Noise.GenerateNoiseMap(mapWidth, mapHeight, noiseScale);

        MapDisplay mapDisplay = GetComponent<MapDisplay>();
        mapDisplay.DrawNoiseMap(noiseMap);
    }
}
