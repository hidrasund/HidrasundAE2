using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public GameObject EntranceHall, GrandStaircase, ServantQuarters, IndoorCemetery, ArtRoom, ScientificLaboratory, AbandonedRoom, TheTrapdoor, StoreRoom; //Colliders on First Floor
    public GameObject BasementLanding, UndergroundCrypt, EngineeringLab, RitualChamber, MachineryRoom; //Colliders in Basement
    private bool EHall, GStaircase, SQuarters, ICemetery, ArRoom, SLaboratory, AbRoom, TTrapdoor, SRoom, BLanding, UCrypt, ELab, RChamber, MRoom; //Bools
    public GameObject JournalCanvas, JournalButtons, JournalBack, JournalEntry1, JournalEntry2, JournalEntry3, JournalEntry4, JournalEntry5, JournalEntry6, JournalEntry7,
        JournalEntry8, JournalEntry9, JournalEntry10, JournalEntry11, JournalEntry12, JournalEntry13, JournalEntry14;
    public GameObject EntryButton1, EntryButton2, EntryButton3, EntryButton4, EntryButton5, EntryButton6, EntryButton7, EntryButton8, EntryButton9, EntryButton10,
        EntryButton11, EntryButton12, EntryButton13, EntryButton14;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) //Open the Journal
        {
            JournalCanvas.SetActive(!JournalCanvas.activeInHierarchy);
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
        }
        

        if (EHall == true)
        {
            EntryButton1.SetActive(true);
        }
        if (GStaircase == true)
        {
            EntryButton2.SetActive(true);
        }
        if (SQuarters == true)
        {
            EntryButton3.SetActive(true);
        }
        if (ICemetery == true)
        {
            EntryButton4.SetActive(true);
        }
        if (ArRoom == true)
        {
            EntryButton5.SetActive(true);
        }
        if (SLaboratory == true)
        {
            EntryButton6.SetActive(true);
        }
        if (AbRoom == true)
        {
            EntryButton7.SetActive(true);
        }
        if (TTrapdoor == true)
        {
            EntryButton8.SetActive(true);
        }
        if (SRoom == true)
        {
            EntryButton9.SetActive(true);
        }
        if (BLanding == true)
        {
            EntryButton10.SetActive(true);
        }
        if (UCrypt == true)
        {
            EntryButton11.SetActive(true);
        }
        if (ELab == true)
        {
            EntryButton12.SetActive(true);
        }
        if (RChamber == true)
        {
            EntryButton13.SetActive(true);
        }
        if (MRoom == true)
        {
            EntryButton14.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider Collision)
    {
        if (Collision == EntranceHall.GetComponent<Collider>())
        {
            EHall = true;
            EntranceHall.SetActive(false);
        }
        if (Collision == GrandStaircase.GetComponent<Collider>())
        {
            GStaircase = true;
            GrandStaircase.SetActive(false);
        }
        if (Collision == ServantQuarters.GetComponent<Collider>())
        {
            SQuarters = true;
            ServantQuarters.SetActive(false);
        }
        if (Collision == IndoorCemetery.GetComponent<Collider>())
        {
            ICemetery = true;
            IndoorCemetery.SetActive(false);
        }
        if (Collision == ArtRoom.GetComponent<Collider>())
        {
            ArRoom = true;
            ArtRoom.SetActive(false);
        }
        if (Collision == ScientificLaboratory.GetComponent<Collider>())
        {
            SLaboratory = true;
            ScientificLaboratory.SetActive(false);
        }
        if (Collision == AbandonedRoom.GetComponent<Collider>())
        {
            AbRoom = true;
            AbandonedRoom.SetActive(false);
        }
        if (Collision == TheTrapdoor.GetComponent<Collider>())
        {
            TTrapdoor = true;
            TheTrapdoor.SetActive(false);
        }
        if (Collision == StoreRoom.GetComponent<Collider>())
        {
            SRoom = true;
            StoreRoom.SetActive(false);
        }
        if (Collision == BasementLanding.GetComponent<Collider>())
        {
            BLanding = true;
            BasementLanding.SetActive(false);
        }
        if (Collision == UndergroundCrypt.GetComponent<Collider>())
        {
            UCrypt = true;
            UndergroundCrypt.SetActive(false);
        }
        if (Collision == EngineeringLab.GetComponent<Collider>())
        {
            ELab = true;
            EngineeringLab.SetActive(false);
        }
        if (Collision == RitualChamber.GetComponent<Collider>())
        {
            RChamber = true;
            RitualChamber.SetActive(false);
        }
        if (Collision == MachineryRoom.GetComponent<Collider>())
        {
            MRoom = true;
            MachineryRoom.SetActive(false);
        }
    }

    public void Back()
    {
        JournalEntry1.SetActive(false); JournalEntry2.SetActive(false); JournalEntry3.SetActive(false); JournalEntry4.SetActive(false); JournalEntry5.SetActive(false);
            JournalEntry6.SetActive(false); JournalEntry7.SetActive(false); JournalEntry8.SetActive(false); JournalEntry9.SetActive(false); JournalEntry10.SetActive(false);
            JournalEntry11.SetActive(false); JournalEntry12.SetActive(false); JournalEntry13.SetActive(false); JournalEntry14.SetActive(false);
        JournalBack.SetActive(false);
        JournalButtons.SetActive(true);
    }
    public void Entry1()
    {
        JournalButtons.SetActive(false);
        JournalEntry1.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry2()
    {
        JournalButtons.SetActive(false);
        JournalEntry2.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry3()
    {
        JournalButtons.SetActive(false);
        JournalEntry3.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry4()
    {
        JournalButtons.SetActive(false);
        JournalEntry4.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry5()
    {
        JournalButtons.SetActive(false);
        JournalEntry5.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry6()
    {
        JournalButtons.SetActive(false);
        JournalEntry6.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry7()
    {
        JournalButtons.SetActive(false);
        JournalEntry7.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry8()
    {
        JournalButtons.SetActive(false);
        JournalEntry8.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry9()
    {
        JournalButtons.SetActive(false);
        JournalEntry9.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry10()
    {
        JournalButtons.SetActive(false);
        JournalEntry10.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry11()
    {
        JournalButtons.SetActive(false);
        JournalEntry11.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry12()
    {
        JournalButtons.SetActive(false);
        JournalEntry12.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry13()
    {
        JournalButtons.SetActive(false);
        JournalEntry13.SetActive(true);
        JournalBack.SetActive(true);
    }
    public void Entry14()
    {
        JournalButtons.SetActive(false);
        JournalEntry14.SetActive(true);
        JournalBack.SetActive(true);
    }
}