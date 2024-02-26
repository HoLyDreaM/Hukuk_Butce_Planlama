using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Degiskenler
{
    static string _SrmMrkzAdi;
    static string _SrmMrkzKodu;
    static decimal _ButceGelir;
    static decimal _ButceGider;
    static int _ButceYil;
    static int _ButceID;
    static int _DonemAraligi;
    static string _SorumlulukMerkezleri;
    static string _LinkSirketAdi;
    static string _RaporVeritabani;

    public static string LinkSirketAdi
    {
        get { return _LinkSirketAdi; }
        set { _LinkSirketAdi = value; }
    }

    public static string RaporVeritabani
    {
        get { return _RaporVeritabani; }
        set { _RaporVeritabani = value; }
    }

    public static string SorumlulukMerkezleri
    {
        get { return _SorumlulukMerkezleri; }
        set { _SorumlulukMerkezleri = value; }
    }

    public static string SrmMrkzAdi
    {
        get { return _SrmMrkzAdi; }
        set { _SrmMrkzAdi = value; }
    }

    public static string SrmMrkzKodu
    {
        get { return _SrmMrkzKodu; }
        set { _SrmMrkzKodu = value; }
    }

    public static decimal ButceGelir
    {
        get { return _ButceGelir; }
        set { _ButceGelir = value; }
    }

    public static decimal ButceGider
    {
        get { return _ButceGider; }
        set { _ButceGider = value; }
    }

    public static int ButceYil
    {
        get { return _ButceYil; }
        set { _ButceYil = value; }
    }

    public static int ButceID
    {
        get { return _ButceID; }
        set { _ButceID = value; }
    }

    public static int DonemAraligi
    {
        get { return _DonemAraligi; }
        set { _DonemAraligi = value; }
    }
}
