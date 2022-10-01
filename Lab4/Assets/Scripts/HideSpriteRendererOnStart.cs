using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSpriteRendererOnStart : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
}