using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLessonScript : MonoBehaviour
{
    public int tamSayi = 1;
    [SerializeField] int tamSayi2 = 100;
    float ondalikSayi = 0.25f;
    float ondalikSayi2 = 5.3125f;
    bool dogru = true;
    bool yanlis2 = false;
    [SerializeField] private Vector3 ucFloat = new Vector3(1, 2, 3);
    //first lesson property
    //property sayesinde get ve set 'leri private yap�p eri�im 
    //k�s�tlamas� sa�layabiliriz
    //property i�erisinde yapt���n de�er atamalar� anl�k olarak ge�ebilir
    public float FloatProperty { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
