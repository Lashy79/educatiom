using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thdhftj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    /*    Predok item = new Predok();
        Nasladnik item2 = new Nasladnik();
        Vsucan item3 = new Vsucan();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}




class Predok
{
    protected int pole3;
    public int pole;
    private int pole2;
    public int metod;
    private int metod2;
    public Predok()
    {
        Debug.Log("Predoc");
    }
}


class Nasladnik : Predok
{
    public int naslpole;
    private int MasPrIvPole;
    private void GetOldFrieds()
    {
        naslpole = 0;
        MasPrIvPole = 10;
        
    }
   public Nasladnik()
    {
        Debug.Log("Nasladnik");
    }
}
class Vsucan : Nasladnik
{
    public int chonib;
    public Vsucan()
        {
        Debug.Log("Vsucan");
        }
}
