using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    public ParticleSystem ps;
    private Elemento elemento;
    public GameObject burnedFloor;

    

    public void OnParticleCollision(GameObject other)
    {
        Debug.Log("Apagando");
        var em = ps.emission;
        em.enabled = true;
        if (other.gameObject.GetComponent<Elemento>())
        {
            em.enabled = false;
            Destroy(ps.gameObject.GetComponent<BoxCollider>());
        }
       /* if (em.enabled == false)
        {
            StartCoroutine(PisoQuemado());
        }*/
    }

    /*public IEnumerator PisoQuemado()
    {
        yield return new WaitForSeconds(3);
        burnedFloor.SetActive(true);
    }*/
}
