using System;
class Fordon {

    public Fordon(string tillverkare,string modell,int årsmodell) {
        Tillverkare=tillverkare;
        Modell=modell;
        Årsmodell=årsmodell;
    }
    public string Tillverkare{set; get;}

    public string Modell{set; get;}

    public int Årsmodell{set; get;}

    public override string ToString()
    {
        return (Tillverkare+" "+Modell+" "+Årsmodell);
    }
}