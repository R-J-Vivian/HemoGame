using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransiSVT : MonoBehaviour
{

    Animator anim;

    public bool isOut;

    [SerializeField]
    GameManagerSVT GM;

    //bool transiDone = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        //anim.SetTrigger("idle");
        StartCoroutine(lireTexte());

        isOut = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator lireTexte()
    {
        yield return new WaitForSeconds(3);

        anim.SetTrigger("ouverture");
    }

    public void triggerOut()
    {
        anim.SetTrigger("out");
        isOut = true;
    }

    public void triggerDialogue()
    {
        //diag.startDialogue();
        //this.gameObject.SetActive(false);
        //lb.spawnNewBallon();
        GM.dialogDebut();
    }


    public void triggerFermeture()
    {
        anim.SetTrigger("fermeture");

        //StartCoroutine(loadScene());
    }

    public void finFermeture()
    {
        //transiDone = true;
        SceneManager.LoadScene(3);
    }
}
