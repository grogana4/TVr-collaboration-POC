using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyNote : MonoBehaviour
{
    public Canvas keyboard;
    public bool SpawnOnce;
    public Rigidbody note;
    public Transform noteTransform;
    // Update is called once per frame

    void Start()
    {
        SpawnOnce = false;
        keyboard.enabled = false;
    }


   public void Dupe()
    {
        if (note.position == noteTransform.position && !SpawnOnce)
        {
            Rigidbody noteInstance;
            noteInstance = Instantiate(note, noteTransform.position, noteTransform.rotation) as Rigidbody;
            SpawnOnce = true;
        }
    
    }

    public void KeyboardSwitch()
    {
        if (keyboard.enabled)
        {
            keyboard.enabled = false;

        }
        else
        {
            keyboard.enabled = true;
        }
    }
}
