using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class PlayVideo : MonoBehaviour {
    public MeshRenderer renderer;
    public VideoPlayer player;
    public Material defaultMat, meme;
    public RawImage image;

    // Use this for initialization
    void Start()
    {

        player.Play();
        image.gameObject.SetActive(true);
    }
}