using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private int colorIndex = 0;

    [SerializeField] [Range(0f, 1f)] private float lerpTime;

    private float t = 0f;

    private void Start()
    {
        meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        

        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            colorIndex++;
            meshRenderer.material.color = new Color(colorIndex, colorIndex, colorIndex);
        }
    }

}
