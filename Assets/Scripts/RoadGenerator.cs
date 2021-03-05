using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject _roadPrefab;
    [SerializeField]
    private float _maxSpeedPlayer = 10;
    [SerializeField]
    private float _speedPlayer = 0;
    [SerializeField]
    private byte _maxRoadCount = 5;

    private List<GameObject> roads = new List<GameObject>();

    private void CreateNextRoad()
    {
        Vector3 positionRoad = Vector3.zero;
        if (roads.Count > 0)
        {
            positionRoad = roads[roads.Count - 1].transform.position + new Vector3(0, 0, 15);
        }
        GameObject go = Instantiate(_roadPrefab, Vector3.zero, Quaternion.identity);
        go.transform.SetParent(transform);
        roads.Add(go);
        
    }
    public void ResetLevel()
    {
        _speedPlayer = 0;
        while (roads.Count > 0)
        {
            Destroy(roads[0]);          //удаляем сам обьект
            roads.RemoveAt(0);      //удаляем из списка
        }

        for (int i = 0; i < _maxRoadCount; i++)
        {
            CreateNextRoad();
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (_speedPlayer == 0) 
            return;
        foreach (GameObject road in roads)
        {
            road.transform.position -= new Vector3(0, 0, _speedPlayer * Time.deltaTime);
        }
    }
}
