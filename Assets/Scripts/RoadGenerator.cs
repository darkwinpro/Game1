using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject _roadPrefab;
    [SerializeField]
    private float _maxSpeedPlayer = 30;
    [SerializeField]
    private float _speedPlayer;
    [SerializeField]
    private byte _maxRoadCount = 3;

    [SerializeField]
    private MainManager _mainManager;

    private List<GameObject> roads = new List<GameObject>();

    private void CreateNextRoad()
    {
        Vector3 positionRoad = Vector3.zero;
        if (roads.Count > 0)
        {
            positionRoad = roads[roads.Count - 1].transform.position + new Vector3(0, 0, 40);
        }
        GameObject go = Instantiate(_roadPrefab, positionRoad, Quaternion.identity);
        go.transform.SetParent(transform);
        roads.Add(go);
        

    }

    private void StartLevel()
    {
        _speedPlayer = _maxSpeedPlayer;
        _mainManager.StartGame();
    }

    private void ObjectCleaner()
    {
        Destroy(roads[0]);          //удаляем сам обьект
        roads.RemoveAt(0);      //удаляем из списка
    }

    private void ResetLevel()
    {
        _speedPlayer = 0;
        while (roads.Count > 0)
        {
            ObjectCleaner();
        }

        for (int i = 0; i < _maxRoadCount; i++)
        {
            CreateNextRoad();
        }
    }
    void Start()
    {
        ResetLevel();
        //StartLevel();         //автозапуск
    }

    void Update()
    {
        if (_speedPlayer == 0) 
            return;
        foreach (GameObject road in roads)
        {
            road.transform.position -= new Vector3(0, 0, _speedPlayer * Time.deltaTime);
        }

        if (roads[0].transform.position.z < -50)
        {
            ObjectCleaner();
            CreateNextRoad();
        }
    }
}
