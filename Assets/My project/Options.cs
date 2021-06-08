using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Options
{
    static string myCar= "car1";

    public static void setCar(string car)
    {
        myCar = car;
    }

    public static string getCar()
    {
        return myCar;
    }
}
