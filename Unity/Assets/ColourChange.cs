using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    private MeshRenderer renderer;

    float timeLeft;
    Color color;

    private void Start()
    {
        renderer = this.gameObject.GetComponent<MeshRenderer>();
    }


    void Update()
    {
        if (timeLeft <= Time.deltaTime)
        {
            renderer.material.color = color;

            // start a new transition
            color = new Color(Random.value, Random.value, Random.value);
            timeLeft = 1.0f;
        }
        else
        {

            renderer.material.color = Color.Lerp(renderer.material.color, color, Time.deltaTime / timeLeft);

            timeLeft -= Time.deltaTime;
        }
    }

}
