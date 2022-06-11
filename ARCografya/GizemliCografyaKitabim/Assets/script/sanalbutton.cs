using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class sanalbutton : MonoBehaviour , IVirtualButtonEventHandler
{
    string vbName;

    public bool donsun = false;
    public bool oynasin = true;

    public GameObject ilk, ikinciic, ikincidis, geri, oynatıcı, durdurucu;
    public GameObject buzmodel, dalgamodel, erozyonmodel, gelgitmodel, heyelanmodel, karstikmodel, ruzgarmodel, tasmodel, akarsumodel;
    public GameObject epimodel, oromodel, volkmodel, depremmodel;
    public GameObject buzvideo, dalgavideo, erozyonvideo, gelgitvideo, heyelanvideo, karstikvideo, ruzgarvideo, tasvideo, akarsuvideo;
    public GameObject epivideo, orovideo, volkvideo, depremvideo;

    VirtualButtonBehaviour[] virtualButtonBehaviours;

    // Start is called before the first frame update
    void Start()
    {

        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);


        ilk.SetActive(true);

        ikincidis.SetActive(false);
        ikinciic.SetActive(false);
        geri.SetActive(false);

        

        buzmodel.SetActive(false);
        dalgamodel.SetActive(false);
        erozyonmodel.SetActive(false);
        gelgitmodel.SetActive(false);
        heyelanmodel.SetActive(false);
        karstikmodel.SetActive(false);
        ruzgarmodel.SetActive(false);
        tasmodel.SetActive(false);
        akarsumodel.SetActive(false);

        epimodel.SetActive(false);
        oromodel.SetActive(false);
        volkmodel.SetActive(false);
        depremmodel.SetActive(false);

        buzvideo.SetActive(false);
        dalgavideo.SetActive(false);
        erozyonvideo.SetActive(false);
        gelgitvideo.SetActive(false);
        heyelanvideo.SetActive(false);
        karstikvideo.SetActive(false);
        ruzgarvideo.SetActive(false);
        tasvideo.SetActive(false);
        akarsuvideo.SetActive(false);

        epivideo.SetActive(false);
        orovideo.SetActive(false);
        volkvideo.SetActive(false);
        depremvideo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        if (ilk.activeInHierarchy)
        {
            if(vbName=="dis")
            {

                ikincidis.SetActive(true);
                ilk.SetActive(false);
                geri.SetActive(false);

            }

            else if (vbName=="ic")
            {

                ikinciic.SetActive(true);
                ilk.SetActive(false);
                geri.SetActive(false);

            }
        }
        else if (ikincidis.activeInHierarchy)
        {
          

            Debug.Log(vbName);

            if (vbName=="buz")
            {
                buzmodel.SetActive(true);
                buzvideo.SetActive(true);
                ikincidis.SetActive(false);
                geri.SetActive(true);
            }

            else if (vbName == "dalga")
            {
                dalgamodel.SetActive(true);
                dalgamodel.SetActive(true);
                ikincidis.SetActive(false);
                geri.SetActive(true);
            }

            else if (vbName == "erozyon")
            {
                erozyonmodel.SetActive(true);
                erozyonvideo.SetActive(true);
                ikincidis.SetActive(false);
                geri.SetActive(true);
            }

            else if (vbName == "gelgit")
            {
                gelgitmodel.SetActive(true);
                gelgitvideo.SetActive(true);
                ikincidis.SetActive(false);
                geri.SetActive(true);
            }

            else if (vbName == "heyelan")
            {
                heyelanmodel.SetActive(true);
                heyelanvideo.SetActive(true);
                ikincidis.SetActive(false);
                geri.SetActive(true);
            }

            else if (vbName == "karstik")
            {
                karstikmodel.SetActive(true);
                karstikvideo.SetActive(true);
                ikincidis.SetActive(false);
                geri.SetActive(true);
            }
            
            else if (vbName == "ruzgar")
            {
                ruzgarmodel.SetActive(true);
                ruzgarvideo.SetActive(true);
                ikincidis.SetActive(false);
                geri.SetActive(true);
            }

            else if (vbName == "tas")
            {
                tasmodel.SetActive(true);
                tasvideo.SetActive(true);
                ikincidis.SetActive(false);
                geri.SetActive(true);
            }

            else if (vbName == "akarsu")
            {
                akarsumodel.SetActive(true);
                akarsuvideo.SetActive(true);
                ikincidis.SetActive(false);
                geri.SetActive(true);
            }
            
        }
        else if (ikinciic.activeInHierarchy)
        {
            

            Debug.Log(vbName);


            if (vbName == "deprem")
            {
                depremmodel.SetActive(true);
                depremvideo.SetActive(true);
                ikinciic.SetActive(false);
                geri.SetActive(true);
            }

            else if (vbName == "epirojenez")
            {
                epimodel.SetActive(true);
                epivideo.SetActive(true);
                ikinciic.SetActive(false);
                geri.SetActive(true);
            }

            else if (vbName == "orojenez")
            {
                oromodel.SetActive(true);
                orovideo.SetActive(true);
                ikinciic.SetActive(false);
                geri.SetActive(true);
            }

            else if (vbName == "volkanizma")
            {
                volkmodel.SetActive(true);
                volkmodel.SetActive(true);
                ikinciic.SetActive(false);
                geri.SetActive(true);
            }
        }
        else if (vbName == "geri")
        {
            ilk.SetActive(true);

            ikincidis.SetActive(false);
            ikinciic.SetActive(false);
            geri.SetActive(false);

            buzmodel.SetActive(false);
            dalgamodel.SetActive(false);
            erozyonmodel.SetActive(false);
            gelgitmodel.SetActive(false);
            heyelanmodel.SetActive(false);
            karstikmodel.SetActive(false);
            ruzgarmodel.SetActive(false);
            tasmodel.SetActive(false);
            akarsumodel.SetActive(false);

            epimodel.SetActive(false);
            oromodel.SetActive(false);
            volkmodel.SetActive(false);
            depremmodel.SetActive(false);

            buzvideo.SetActive(false);
            dalgavideo.SetActive(false);
            erozyonvideo.SetActive(false);
            gelgitvideo.SetActive(false);
            heyelanvideo.SetActive(false);
            karstikvideo.SetActive(false);
            ruzgarvideo.SetActive(false);
            tasvideo.SetActive(false);
            akarsuvideo.SetActive(false);

            epivideo.SetActive(false);
            orovideo.SetActive(false);
            volkvideo.SetActive(false);
            depremvideo.SetActive(false);
        }

        else if (vbName=="dondur")
        {
            donsun = true;
        }

        else if (vbName=="oynat")
        {
            oynasin = true;
            durdurucu.SetActive(false);
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        donsun = false;
    }

}
