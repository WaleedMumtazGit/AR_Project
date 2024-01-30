using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;

    public Transform pos;
    public GameObject prefab;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            SpawnObject(pos, prefab);
        }
    }

    public void SpawnObject(Transform pos, GameObject prefab)
    {
        GameObject obj = Instantiate(prefab, pos.position, Quaternion.identity);
    }
}
