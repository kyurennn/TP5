using System;
using TP_MODUL5_103022400056;

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Muhammad Daffa Arifin");

        DataGeneric<string> data = new DataGeneric<string>("103022400056");
        data.PrintData();
    }
}