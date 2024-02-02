using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

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

    }

    public void SpawnObject(Transform pos, GameObject prefab)
    {
        GameObject obj = Instantiate(prefab, pos.position, Quaternion.identity);
    }
}
