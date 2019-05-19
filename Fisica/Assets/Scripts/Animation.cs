using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{
    public Texture2D[] gif;
    public int frames = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int indice = (int)(Time.time * frames) % gif.Length;
        GetComponent<RawImage>().texture = gif[indice];
    }
}
