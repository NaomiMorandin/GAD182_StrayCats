using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultCharacter : MonoBehaviour
{
    public float lifetime = 1f;
    public float moveSpeed = 1f;

    public void OnEnable()
    {
        //This is where the Enemy should listen for an event telling it to be destroyed, activating the TriggerDestroy() script
    }

    public void Move()
    {
        transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
    }

    public void RandomColour()
    {

    }

    public void ChangeColor(Color c)
    {
        GetComponent<Renderer>().material.color = c;
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
        //Don't forget to remove the event listener here!
    }

    private IEnumerator DelayedDestroySelf()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
        //Don't forget to remove the event listener here!
    }
}
