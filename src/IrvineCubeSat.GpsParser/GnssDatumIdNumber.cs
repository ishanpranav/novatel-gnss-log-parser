// GnssDatumIdNumber.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using CsvHelper.Configuration.Attributes;

namespace IrvineCubeSat.GpsParser
{
    public enum GnssDatumIdNumber
    {
        None,

        [Name("ARC50")]
        Arc50 = 2,

        [Name("AGD66")]
        Agd66 = 4,

        [Name("AGD84")]
        Agd84 = 5,

        [Name("BUKIT")]
        BukitRimpah = 6,

        [Name("ASTRO")]
        CampAreaAstro = 7,

        [Name("CHATM")]
        Chatham = 8,

        [Name("CARTH")]
        Carthage = 9,

        [Name("CAPE")]
        Cape = 10,

        [Name("DJAKA")]
        Jakarta = 11,

        [Name("EGYPT")]
        Egypt = 12,

        ED50 = 13,
        ED79 = 14,

        [Name("GUNSG")]
        GSegara = 15,

        [Name("GEO49")]
        Geo49 = 16,

        [Name("GUAM")]
        Guam = 18,

        [Name("HERAT")]
        Herat = 23,

        [Name("HJORS")]
        Hjorsey = 24,

        [Name("HONGK")]
        HongKong = 25,

        [Name("KERTA")]
        Kertau = 29,

        [Name("KANDA")]
        Kandawala = 30,

        [Name("LIBER")]
        Liberia = 31,

        [Name("MERCH")]
        Merchich = 34,

        [Name("NAD83")]
        Nad83 = 36,

        [Name("CANADA")]
        Canada = 37,

        [Name("ALASKA")]
        Alaska = 38,

        [Name("NAD27")]
        Nad27 = 39,

        [Name("MEXICO")]
        Mexico = 41,

        [Name("CAMER")]
        CentralAmerica = 42,

        [Name("MINNA")]
        Minna = 43,

        [Name("OMAN")]
        Oman = 44,

        [Name("PUERTO")]
        PuertoRico = 45,

        [Name("QORNO")]
        Qornoq = 46,

        [Name("ROME")]
        Rome = 47,

        [Name("CHUA")]
        Chua = 48,

        [Name("SAM56")]
        Sam56 = 49,

        [Name("SAM69")]
        Sam69 = 50,

        [Name("CAMPO")]
        CampInchauspe = 51,

        [Name("SACOR")]
        CorregoAlegre = 52,

        [Name("YACAR")]
        Yacare = 53,

        [Name("TANAN")]
        Antananarivo = 54,

        [Name("TRIST")]
        TristanDuCunha = 57,

        [Name("VITI")]
        VitiLevu = 58,

        [Name("WGS72")]
        Wgs72 = 60,

        [Name("WGS84")]
        Wgs84 = 61,

        [Name("ZANDE")]
        Zanderij = 62,

        [Name("USER")]
        UserDefined = 63,

        [Name("CSRS")]
        Csrs = 64,

        [Name("ADIM", "ADIND")]
        Adim = 65,

        [Name("ARSM", "ARC60")]
        Arc60 = 66,

        [Name("ENW", "WAK60")]
        WakeEniwetok = 67,

        [Name("HTN", "HUTZU")]
        HuTzuShan = 68,

        [Name("INDB")]
        Bangladesh = 69,

        [Name("INDI", "INDIA")]
        India = 70,

        [Name("IRL", "IRE65")]
        Ireland = 71,

        [Name("LUZA", "LUZON")]
        Luzon = 72,

        [Name("LUZB", "MINDA")]
        Mindanoa = 73,

        [Name("NAHC", "NAHR")]
        Nahrwan = 74,

        [Name("NASP", "CARIBB")]
        Caribbean = 75,

        [Name("OGBM", "GRB36")]
        GreatBritain = 76,

        [Name("OHAA", "HAWAII")]
        Hawaii = 77,

        [Name("OHAB", "KAWAI")]
        Kauai = 78,

        [Name("OHAC", "MAUI")]
        Maui = 79,

        [Name("OHAD", "OAHU")]
        Oahu = 80,

        [Name("OHIA")]
        HawaiiInternational = 81,

        [Name("OHIB")]
        KauaiInternational = 82,

        [Name("OHIC")]
        MauiInternational = 83,

        [Name("OHID")]
        OahuInternational = 84,

        [Name("TIL", "TIMBA")]
        Timbalai = 85,

        [Name("TOYM", "TOKYO")]
        Tokyo = 86
    }
}
