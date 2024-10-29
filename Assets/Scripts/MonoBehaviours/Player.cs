using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Player : Character
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CanBePickedUp"))
        {
            Item hitObject = collision.gameObject.GetComponent<Consumable>().item;
            if (hitObject != null)
            {
                print("Nombre: " + hitObject.objectName);


                switch (hitObject.itemType)
                {
                    case Item.ItemType.COIN:
                        break;
                    case Item.ItemType.HEALTH:
                        AdjustHitPoints(hitObject.quantity);
                        break;
                    default:
                        break;

                }

                collision.gameObject.SetActive(false);
            }
        }

    }

    public void AdjustHitPoints(int amount)
    {
        hitPoints = hitPoints + amount;
        print("Ajustando Puntos: " + amount + ". Nuevo Valor: " + hitPoints);
    }

}
