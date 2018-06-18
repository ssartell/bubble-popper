using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnBubbles : MonoBehaviour
{
    public GameObject BubblePrefab;

    private List<GameObject> _bubbles;

    // Use this for initialization
    void Start()
    {
        
        this._bubbles = Enumerable.Range(0, 10)
            .Select(x => Instantiate(BubblePrefab, this.RandomPosition(), Quaternion.identity))
            .ToList();
    }

    // Update is called once per frame
    void Update()
    {

    }

    Vector3 RandomPosition()
    {
        var screenPosition = new Vector2(Random.Range(0, Screen.width), 0f);
        var ray = Camera.main.ScreenPointToRay(screenPosition);
        var point = ray.GetPoint(Random.Range(0.5f, 1f));
        return point - new Vector3(0f, .1f, 0f);
    }
}
