using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_TextureScrolling : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float scrollX = 0.05f;
    public float scrollY = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        TextureScrolling();
    }

    private void TextureScrolling()
    {
        float offsetX = Time.time * scrollX;
        float offsetY = Time.time * scrollY;

        Debug.Log("offsetX: " + offsetX);
        Debug.Log("offsetY: " + offsetY);

        meshRenderer.material.mainTextureOffset = new Vector2(offsetX, offsetY);
    }
}
