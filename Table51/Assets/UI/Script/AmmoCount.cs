using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AmmoCount : MonoBehaviour
{
    [SerializeField] int Ammo=0; //cephane
    [SerializeField] int Bullet=30; //silahýn içindeki mermi - max 30 gibi
    [SerializeField] Text ceptekiMermi;
    [SerializeField] Text silahtaMermi;
    [SerializeField] GameObject reloadicon;
    public int MaxCapacity;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            TakeAmmo(MaxCapacity);
        }
        else if (Input.GetKeyDown("r"))
        {
            Reload();
        }
        else if (Input.GetKeyDown("s"))
        {
            DecreaseAmmo();
        }

        
    }

    public void TakeAmmo(int bullet)
    {
        
        Ammo +=bullet;
        ceptekiMermi.text = Ammo.ToString();
    }
    public void DecreaseAmmo()
    {
        Bullet -= 1;
        if(Bullet <= 0)
        {
            Bullet = 0;
            Reload();
        }
        silahtaMermi.text = Bullet.ToString();
    }
    public void Reload()
    {
        if (Ammo == 0 || Bullet == MaxCapacity) { return; }
        StartCoroutine(ReloadDelay());
        reloadicon.SetActive(true);
    }
    IEnumerator ReloadDelay()
    {
        yield return new WaitForSeconds(2f);
        reloadicon.SetActive(false);
        int kapasite = MaxCapacity - Bullet;
        Bullet =MaxCapacity;
        Ammo -= kapasite;
        ceptekiMermi.text = Ammo.ToString();
        silahtaMermi.text = Bullet.ToString();
    }
}
