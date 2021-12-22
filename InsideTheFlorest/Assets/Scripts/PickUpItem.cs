using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{
    public HUDScript hud;

    public string itemNome;
    public GameObject itemSprite;
    public GameObject item3d;

    public Transform coletavel;
    public float groundDistance;
    public LayerMask ItemMask;

    public bool dentro;

    private void Start()
    {
        groundDistance = 3f;
    }

    void Update()
    {

        dentro = Physics.CheckSphere(coletavel.position, groundDistance, ItemMask);

        if (dentro)
        {
            hud.OpenMessagePanel("(E) pegar " + itemNome);
        } else
        {
            hud.CloseMessagePanel();
        }

        if (dentro && Input.GetKeyUp(KeyCode.E))
        {
            // Ativa o item no inventário           
            itemSprite.SetActive(true);
            //if (!item3d.Equals(null))
                item3d.SetActive(true);

            // Atualiza o HUD
            hud.setScore(hud.GetScore() + 1);
            hud.CloseMessagePanel();

            // Desativa o item no cenário
            this.gameObject.SetActive(false);
        } 
    }
}
