using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballon : MonoBehaviour
{
    Animator anim;
    public LancerBallon lb;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lancer(string force)
    {
        anim.SetTrigger(force);
    }

    public void pretAlancer()
    {
        lb.pretAlancer();
    }

    public void finLancerFaible()
    {
        StartCoroutine(tempFin());
    }

    public void finLancerFort()
    {
        StartCoroutine(tempFin());
    }

    public void finLancerNormal()
    {
        StartCoroutine(tempFin());
    }

    
    IEnumerator tempFin()
    {
        anim.SetTrigger("fin");
        yield return new WaitForSeconds(0.5f);
        lb.spawnNewBallon();
        Destroy(this.gameObject);
    }



}