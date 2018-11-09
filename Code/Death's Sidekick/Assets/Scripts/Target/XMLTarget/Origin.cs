﻿using System.Collections.Generic;

namespace Assets.Scripts.Target.XMLTarget
{
    /// <summary>
    /// Class which contains all the informations of an origin
    /// </summary>
    public class Origin
    {
        //Variables
        string name;
        int nbr;

        //Objects
        public List<Area> lstArea = new List<Area>();

        //Constructor
        public Origin(string Name, int Nbr, List<Area> LstArea)
        {
            name = Name;
            nbr = Nbr;
            lstArea = LstArea;
        }
    }
}
