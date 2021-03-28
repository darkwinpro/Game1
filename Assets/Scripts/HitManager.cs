using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitManager : MonoBehaviour
{
    [SerializeField] 
    private Text _scoreLabel;

    [SerializeField]
    private MainManager _mainManager;

    private int _scoreCollectedCoin;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "COIN")
        {
            Destroy(collision.collider.gameObject);
            _scoreCollectedCoin++;
            _scoreLabel.text = _scoreCollectedCoin.ToString();
        }
        else if (collision.collider.tag == "Cubes")
        {
            _mainManager.GameOver();
        }
    }
}
