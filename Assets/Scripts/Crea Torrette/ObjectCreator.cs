using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject oggettoPrefab; // Prefab dell'oggetto da creare
    public GameObject oggettoPrefab1;
    public GameObject oggettoPrefab2;

    // private GameObject oggettoSelezionato; // Oggetto selezionato

    [SerializeField] private Transform spot1;
    [SerializeField] private Transform spot2;
    [SerializeField] private Transform spot3;

   public static bool click_dt;
   public static bool click_st;
   public static bool click_bf;
    

    private void Update()
    {


    }




    private void OnMouseDown()
    {

        
        if (click_st == true)
        {
            var lol = Instantiate(oggettoPrefab);

            lol.transform.position = spot1.transform.position;
            lol.transform.rotation = Quaternion.identity;

            click_st = false;
            
        }

        if (click_dt == true)
        {
            var sos = Instantiate(oggettoPrefab1);

            sos.transform.position = spot2.transform.position;
            sos.transform.rotation = Quaternion.identity;

            click_dt = false;
            
        }

        if (click_bf == true)
        {
            var sos = Instantiate(oggettoPrefab2);

            sos.transform.position = spot3.transform.position;
            sos.transform.rotation = Quaternion.identity;

            StartCoroutine(TimerCoroutine());
            

            click_bf = false;

        }


    }
         private IEnumerator TimerCoroutine()
         {
            Debug.Log("Inizio del timer");

             Turret.attackRange += 10f;

             yield return new WaitForSeconds(3f);

            Debug.Log("Timer completato!");

             Turret.attackRange -= 10f;

       
        
         }

}
