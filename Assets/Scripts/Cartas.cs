using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cartas : MonoBehaviour
{
    [SerializeField]

    private Text count_1;

    private int par = 0;
    
    public bool faceUp, locked;
    public static bool coroutineAllowed;

    private Cartas firstInPair, secondInPair;
    private string firstInPairName, secondInPairName;

    public static Queue<Cartas> sequence;

    public static int pairsFound;
    

    public static GameObject winText;
    public static GameObject animJump;
    public static GameObject animDance;
    public static GameObject animSaludo;





    // Start is called before the first frame update
    void Start()
    {
        faceUp = false;
        coroutineAllowed = true;
        locked = false;
        sequence = new Queue<Cartas>();
        pairsFound = 0;

        if(winText == null)
        {
            //Escondemos el texto de Win
            winText = GameObject.Find("WinText");
            winText.SetActive(false);
            //Activamos animacion de saludo
            animSaludo = GameObject.Find("Manuel_Saludo");
            animSaludo.SetActive(true);
            //Escondemos animacion dance
            animDance = GameObject.Find("Manuel_Dance");
            animDance.SetActive(false);
            //escondemos animacion jump
            animJump = GameObject.Find("Manuel_Jumping");
            animJump.SetActive(false);
            
            
        }
    }

    private void OnMouseDown()
    {
        cambioAnimSaludo();

        if( !locked && coroutineAllowed)
        {
            StartCoroutine(RotateCard());
        }
    }

    public IEnumerator RotateCard()
    {
        
        coroutineAllowed = false;

        if (!faceUp)
        {
            sequence.Enqueue(this);

            for(float i = 0f; i <= 180f; i += 15)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                yield return new WaitForSeconds(0.02f);
            }
        }else if (faceUp)
        {
            for(float i = 180f; i >= 0f; i -= 20) {

                transform.rotation = Quaternion.Euler(0f, i, 0f);
                yield return new WaitForSeconds(0.02f);
                sequence.Clear();
            }
        }

        coroutineAllowed = true;

        faceUp = !faceUp;

        if(sequence.Count == 2)
        {
            CheckResults();
        }
    }

    private void CheckResults()
    {
        firstInPair = sequence.Dequeue();
        secondInPair = sequence.Dequeue();

        firstInPairName = firstInPair.name.Substring(0, firstInPair.name.Length - 1);
        secondInPairName = secondInPair.name.Substring(0, secondInPair.name.Length - 1);

        if(firstInPairName == secondInPairName)
        {
            firstInPair.locked = true;
            secondInPair.locked = true;
            pairsFound += 1;
            par = pairsFound;
            actualizarC(par);
            cambioAnimSal();
            
        }
        else
        {
            firstInPair.StartCoroutine("RotateBack");
            secondInPair.StartCoroutine("RotateBack");
            cambioAnimSaludo();
        }

         if(pairsFound == 3) // Numero de cartas / 3
        {
            winText.SetActive(true);
            cambioAnimDan();
            
        }
        

    }

    public IEnumerator RotateBack()
    {
        coroutineAllowed = false;
        yield return new WaitForSeconds(0.2f);

        for(float i = 180f; i >= 0f; i -= 15)
        {
            transform.rotation = Quaternion.Euler(0f, i, 0f);

            yield return new WaitForSeconds(0.02f);
            sequence.Clear();
        }
        faceUp = false;
        coroutineAllowed = true;
    }

    public void actualizarC(int par){
        count_1.text = this.par.ToString();   
    }

    public void cambioAnimSal()
    {
        animSaludo.SetActive(false);
        animJump.SetActive(true);
    }

      public void cambioAnimDan()
    {
        animSaludo.SetActive(false); 
        animJump.SetActive(false);       
        animDance.SetActive(true);
    }

      public void cambioAnimSaludo()
    {
        animSaludo.SetActive(true);
        animJump.SetActive(false);
    }

    
}
