using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    //PAINEIS
    public GameObject painelDasInteracoes;
    public Text textoDasInteracoes;
    public GameObject painelDasDicas;
    public Text textoDasDicas;

    //SCREEN
    public GameObject fimDeJogo;
    public GameObject cameraRec;
    public GameObject sprites;

    //SCORE
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
    }
    public void OpenMessagePanel(string elemento)
    {
        painelDasInteracoes.SetActive(true);
        textoDasInteracoes.text = elemento;

    }

    public void CloseMessagePanel()
    {
        painelDasInteracoes.SetActive(false);
    }

    public void OpenTipPanel(string mensagem)
    {
        painelDasDicas.SetActive(true);
        textoDasDicas.text = mensagem;

    }

    public void CloseTipPanel()
    {
        painelDasDicas.SetActive(false);

    }

    public void FimDeJogo()
    {
        cameraRec.SetActive(false);
        painelDasInteracoes.SetActive(false);
        sprites.SetActive(false);

        fimDeJogo.SetActive(true);
    }

    public float GetScore()
    {
        return score;
    }

    public void setScore(float valor)
    {
        score = valor;
    }
}
