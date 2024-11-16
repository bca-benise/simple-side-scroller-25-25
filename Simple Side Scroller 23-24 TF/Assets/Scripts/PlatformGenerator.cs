using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    static float nextPlatform = 15;
    private System.Random _rand;
    [SerializeField]
    private GameObject _platformPrefab;

    private void Awake()
    {
        _rand = new System.Random();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerControl>() != null)
        {
            GameObject newPlatform = Instantiate<GameObject>(_platformPrefab);
            newPlatform.transform.Translate(new Vector3(nextPlatform, _rand.Next(-1, 2), 0));
            nextPlatform += (5.0f + (_rand.Next(0, 1) / 2.0f));
            Debug.Log(nextPlatform);
        }
    }
}
