using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgress : MonoBehaviour
{

    public HUDScript hud;
    public string mensagem = "";
    public bool dentro;
    public float scoreAlvo;

    //CHARACTERS
    public GameObject monster;

    private void Start()
    {
        scoreAlvo = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (oScoreBateu())
        {
            monster.SetActive(true);
        }
        if (dentro && oScoreBateu() && Input.GetKeyUp(KeyCode.E))
        {
            hud.FimDeJogo();
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (oScoreBateu())
        {
            hud.OpenMessagePanel("(E) Consertar Carro");
        } else
        {
            hud.OpenTipPanel(mensagem);
        }

        dentro = true;
    }
    private void OnTriggerExit(Collider other)
    {
        hud.CloseTipPanel();
        hud.CloseMessagePanel();
        dentro = false;
    }

    private bool oScoreBateu()
    {
        return hud.GetScore() >= scoreAlvo;
    }
}
