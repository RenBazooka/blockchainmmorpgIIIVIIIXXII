namespace Shopify.Unity {
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Shopify.Unity.SDK;

    /// <summary>
    /// Currency codes.
    /// </summary>
    public enum CurrencyCode {
        /// <summary>
        /// If the SDK is not up to date with the schema in the Storefront API, it is possible
        /// to have enum values returned that are unknown to the SDK. In this case the value
        /// will actually be UNKNOWN.
        /// </summary>
        UNKNOWN,
        /// <summary>
        /// United Arab Emirates Dirham (AED).
        /// </summary>
        AED,
        /// <summary>
        /// Afghan Afghani (AFN).
        /// </summary>
        AFN,
        /// <summary>
        /// Albanian Lek (ALL).
        /// </summary>
        ALL,
        /// <summary>
        /// Armenian Dram (AMD).
        /// </summary>
        AMD,
        /// <summary>
        /// Netherlands Antillean Guilder.
        /// </summary>
        ANG,
        /// <summary>
        /// Angolan Kwanza (AOA).
        /// </summary>
        AOA,
        /// <summary>
        /// Argentine Pesos (ARS).
        /// </summary>
        ARS,
        /// <summary>
        /// Australian Dollars (AUD).
        /// </summary>
        AUD,
        /// <summary>
        /// Aruban Florin (AWG).
        /// </summary>
        AWG,
        /// <summary>
        /// Azerbaijani Manat (AZN).
        /// </summary>
        AZN,
        /// <summary>
        /// Bosnia and Herzegovina Convertible Mark (BAM).
        /// </summary>
        BAM,
        /// <summary>
        /// Barbadian Dollar (BBD).
        /// </summary>
        BBD,
        /// <summary>
        /// Bangladesh Taka (BDT).
        /// </summary>
        BDT,
        /// <summary>
        /// Bulgarian Lev (BGN).
        /// </summary>
        BGN,
        /// <summary>
        /// Bahraini Dinar (BHD).
        /// </summary>
        BHD,
        /// <summary>
        /// Burundian Franc (BIF).
        /// </summary>
        BIF,
        /// <summary>
        /// Bermudian Dollar (BMD).
        /// </summary>
        BMD,
        /// <summary>
        /// Brunei Dollar (BND).
        /// </summary>
        BND,
        /// <summary>
        /// Bolivian Boliviano (BOB).
        /// </summary>
        BOB,
        /// <summary>
        /// Brazilian Real (BRL).
        /// </summary>
        BRL,
        /// <summary>
        /// Bahamian Dollar (BSD).
        /// </summary>
        BSD,
        /// <summary>
        /// Bhutanese Ngultrum (BTN).
        /// </summary>
        BTN,
        /// <summary>
        /// Botswana Pula (BWP).
        /// </summary>
        BWP,
        /// <summary>
        /// Belize Dollar (BZD).
        /// </summary>
        BZD,
        /// <summary>
        /// Canadian Dollars (CAD).
        /// </summary>
        CAD,
        /// <summary>
        /// Congolese franc (CDF).
        /// </summary>
        CDF,
        /// <summary>
        /// Swiss Francs (CHF).
        /// </summary>
        CHF,
        /// <summary>
        /// Chilean Peso (CLP).
        /// </summary>
        CLP,
        /// <summary>
        /// Chinese Yuan Renminbi (CNY).
        /// </summary>
        CNY,
        /// <summary>
        /// Colombian Peso (COP).
        /// </summary>
        COP,
        /// <summary>
        /// Costa Rican Colones (CRC).
        /// </summary>
        CRC,
        /// <summary>
        /// Cape Verdean escudo (CVE).
        /// </summary>
        CVE,
        /// <summary>
        /// Czech Koruny (CZK).
        /// </summary>
        CZK,
        /// <summary>
        /// Djiboutian Franc (DJF).
        /// </summary>
        DJF,
        /// <summary>
        /// Danish Kroner (DKK).
        /// </summary>
        DKK,
        /// <summary>
        /// Dominican Peso (DOP).
        /// </summary>
        DOP,
        /// <summary>
        /// Algerian Dinar (DZD).
        /// </summary>
        DZD,
        /// <summary>
        /// Egyptian Pound (EGP).
        /// </summary>
        EGP,
        /// <summary>
        /// Ethiopian Birr (ETB).
        /// </summary>
        ETB,
        /// <summary>
        /// Euro (EUR).
        /// </summary>
        EUR,
        /// <summary>
        /// Fijian Dollars (FJD).
        /// </summary>
        FJD,
        /// <summary>
        /// Falkland Islands Pounds (FKP).
        /// </summary>
        FKP,
        /// <summary>
        /// United Kingdom Pounds (GBP).
        /// </summary>
        GBP,
        /// <summary>
        /// Georgian Lari (GEL).
        /// </summary>
        GEL,
        /// <summary>
        /// Ghanaian Cedi (GHS).
        /// </summary>
        GHS,
        /// <summary>
        /// Gibraltar Pounds (GIP).
        /// </summary>
        GIP,
        /// <summary>
        /// Gambian Dalasi (GMD).
        /// </summary>
        GMD,
        /// <summary>
        /// Guinean Franc (GNF).
        /// </summary>
        GNF,
        /// <summary>
        /// Guatemalan Quetzal (GTQ).
        /// </summary>
        GTQ,
        /// <summary>
        /// Guyanese Dollar (GYD).
        /// </summary>
        GYD,
        /// <summary>
        /// Hong Kong Dollars (HKD).
        /// </summary>
        HKD,
        /// <summary>
        /// Honduran Lempira (HNL).
        /// </summary>
        HNL,
        /// <summary>
        /// Croatian Kuna (HRK).
        /// </summary>
        HRK,
        /// <summary>
        /// Haitian Gourde (HTG).
        /// </summary>
        HTG,
        /// <summary>
        /// Hungarian Forint (HUF).
        /// </summary>
        HUF,
        /// <summary>
        /// Indonesian Rupiah (IDR).
        /// </summary>
        IDR,
        /// <summary>
        /// Israeli New Shekel (NIS).
        /// </summary>
        ILS,
        /// <summary>
        /// Indian Rupees (INR).
        /// </summary>
        INR,
        /// <summary>
        /// Iraqi Dinar (IQD).
        /// </summary>
        IQD,
        /// <summary>
        /// Iranian Rial (IRR).
        /// </summary>
        IRR,
        /// <summary>
        /// Icelandic Kronur (ISK).
        /// </summary>
        ISK,
        /// <summary>
        /// Jersey Pound.
        /// </summary>
        JEP,
        /// <summary>
        /// Jamaican Dollars (JMD).
        /// </summary>
        JMD,
        /// <summary>
        /// Jordanian Dinar (JOD).
        /// </summary>
        JOD,
        /// <summary>
        /// Japanese Yen (JPY).
        /// </summary>
        JPY,
        /// <summary>
        /// Kenyan Shilling (KES).
        /// </summary>
        KES,
        /// <summary>
        /// Kyrgyzstani Som (KGS).
        /// </summary>
        KGS,
        /// <summary>
        /// Cambodian Riel.
        /// </summary>
        KHR,
        /// <summary>
        /// Comorian Franc (KMF).
        /// </summary>
        KMF,
        /// <summary>
        /// South Korean Won (KRW).
        /// </summary>
        KRW,
        /// <summary>
        /// Kuwaiti Dinar (KWD).
        /// </summary>
        KWD,
        /// <summary>
        /// Cayman Dollars (KYD).
        /// </summary>
        KYD,
        /// <summary>
        /// Kazakhstani Tenge (KZT).
        /// </summary>
        KZT,
        /// <summary>
        /// Laotian Kip (LAK).
        /// </summary>
        LAK,
        /// <summary>
        /// Lebanese Pounds (LBP).
        /// </summary>
        LBP,
        /// <summary>
        /// Sri Lankan Rupees (LKR).
        /// </summary>
        LKR,
        /// <summary>
        /// Liberian Dollar (LRD).
        /// </summary>
        LRD,
        /// <summary>
        /// Lesotho Loti (LSL).
        /// </summary>
        LSL,
        /// <summary>
        /// Lithuanian Litai (LTL).
        /// </summary>
        LTL,
        /// <summary>
        /// Latvian Lati (LVL).
        /// </summary>
        LVL,
        /// <summary>
        /// Libyan Dinar (LYD).
        /// </summary>
        LYD,
        /// <summary>
        /// Moroccan Dirham.
        /// </summary>
        MAD,
        /// <summary>
        /// Moldovan Leu (MDL).
        /// </summary>
        MDL,
        /// <summary>
        /// Malagasy Ariary (MGA).
        /// </summary>
        MGA,
        /// <summary>
        /// Macedonia Denar (MKD).
        /// </summary>
        MKD,
        /// <summary>
        /// Burmese Kyat (MMK).
        /// </summary>
        MMK,
        /// <summary>
        /// Mongolian Tugrik.
        /// </summary>
        MNT,
        /// <summary>
        /// Macanese Pataca (MOP).
        /// </summary>
        MOP,
        /// <summary>
        /// Mauritian Rupee (MUR).
        /// </summary>
        MUR,
        /// <summary>
        /// Maldivian Rufiyaa (MVR).
        /// </summary>
        MVR,
        /// <summary>
        /// Malawian Kwacha (MWK).
        /// </summary>
        MWK,
        /// <summary>
        /// Mexican Pesos (MXN).
        /// </summary>
        MXN,
        /// <summary>
        /// Malaysian Ringgits (MYR).
        /// </summary>
        MYR,
        /// <summary>
        /// Mozambican Metical.
        /// </summary>
        MZN,
        /// <summary>
        /// Namibian Dollar.
        /// </summary>
        NAD,
        /// <summary>
        /// Nigerian Naira (NGN).
        /// </summary>
        NGN,
        /// <summary>
        /// Nicaraguan Córdoba (NIO).
        /// </summary>
        NIO,
        /// <summary>
        /// Norwegian Kroner (NOK).
        /// </summary>
        NOK,
        /// <summary>
        /// Nepalese Rupee (NPR).
        /// </summary>
        NPR,
        /// <summary>
        /// New Zealand Dollars (NZD).
        /// </summary>
        NZD,
        /// <summary>
        /// Omani Rial (OMR).
        /// </summary>
        OMR,
        /// <summary>
        /// Panamian Balboa (PAB).
        /// </summary>
        PAB,
        /// <summary>
        /// Peruvian Nuevo Sol (PEN).
        /// </summary>
        PEN,
        /// <summary>
        /// Papua New Guinean Kina (PGK).
        /// </summary>
        PGK,
        /// <summary>
        /// Philippine Peso (PHP).
        /// </summary>
        PHP,
        /// <summary>
        /// Pakistani Rupee (PKR).
        /// </summary>
        PKR,
        /// <summary>
        /// Polish Zlotych (PLN).
        /// </summary>
        PLN,
        /// <summary>
        /// Paraguayan Guarani (PYG).
        /// </summary>
        PYG,
        /// <summary>
        /// Qatari Rial (QAR).
        /// </summary>
        QAR,
        /// <summary>
        /// Romanian Lei (RON).
        /// </summary>
        RON,
        /// <summary>
        /// Serbian dinar (RSD).
        /// </summary>
        RSD,
        /// <summary>
        /// Russian Rubles (RUB).
        /// </summary>
        RUB,
        /// <summary>
        /// Rwandan Franc (RWF).
        /// </summary>
        RWF,
        /// <summary>
        /// Saudi Riyal (SAR).
        /// </summary>
        SAR,
        /// <summary>
        /// Solomon Islands Dollar (SBD).
        /// </summary>
        SBD,
        /// <summary>
        /// Seychellois Rupee (SCR).
        /// </summary>
        SCR,
        /// <summary>
        /// Sudanese Pound (SDG).
        /// </summary>
        SDG,
        /// <summary>
        /// Swedish Kronor (SEK).
        /// </summary>
        SEK,
        /// <summary>
        /// Singapore Dollars (SGD).
        /// </summary>
        SGD,
        /// <summary>
        /// Saint Helena Pounds (SHP).
        /// </summary>
        SHP,
        /// <summary>
        /// Sierra Leonean Leone (SLL).
        /// </summary>
        SLL,
        /// <summary>
        /// Surinamese Dollar (SRD).
        /// </summary>
        SRD,
        /// <summary>
        /// South Sudanese Pound (SSP).
        /// </summary>
        SSP,
        /// <summary>
        /// Sao Tome And Principe Dobra (STD).
        /// </summary>
        STD,
        /// <summary>
        /// Syrian Pound (SYP).
        /// </summary>
        SYP,
        /// <summary>
        /// Swazi Lilangeni (SZL).
        /// </summary>
        SZL,
        /// <summary>
        /// Thai baht (THB).
        /// </summary>
        THB,
        /// <summary>
        /// Tajikistani Somoni (TJS).
        /// </summary>
        TJS,
        /// <summary>
        /// Turkmenistani Manat (TMT).
        /// </summary>
        TMT,
        /// <summary>
        /// Tunisian Dinar (TND).
        /// </summary>
        TND,
        /// <summary>
        /// Tongan Pa'anga (TOP).
        /// </summary>
        TOP,
        /// <summary>
        /// Turkish Lira (TRY).
        /// </summary>
        TRY,
        /// <summary>
        /// Trinidad and Tobago Dollars (TTD).
        /// </summary>
        TTD,
        /// <summary>
        /// Taiwan Dollars (TWD).
        /// </summary>
        TWD,
        /// <summary>
        /// Tanzanian Shilling (TZS).
        /// </summary>
        TZS,
        /// <summary>
        /// Ukrainian Hryvnia (UAH).
        /// </summary>
        UAH,
        /// <summary>
        /// Ugandan Shilling (UGX).
        /// </summary>
        UGX,
        /// <summary>
        /// United States Dollars (USD).
        /// </summary>
        USD,
        /// <summary>
        /// Uruguayan Pesos (UYU).
        /// </summary>
        UYU,
        /// <summary>
        /// Uzbekistan som (UZS).
        /// </summary>
        UZS,
        /// <summary>
        /// Vietnamese đồng (VND).
        /// </summary>
        VND,
        /// <summary>
        /// Vanuatu Vatu (VUV).
        /// </summary>
        VUV,
        /// <summary>
        /// Samoan Tala (WST).
        /// </summary>
        WST,
        /// <summary>
        /// Central African CFA Franc (XAF).
        /// </summary>
        XAF,
        /// <summary>
        /// East Caribbean Dollar (XCD).
        /// </summary>
        XCD,
        /// <summary>
        /// West African CFA franc (XOF).
        /// </summary>
        XOF,
        /// <summary>
        /// CFP Franc (XPF).
        /// </summary>
        XPF,
        /// <summary>
        /// Yemeni Rial (YER).
        /// </summary>
        YER,
        /// <summary>
        /// South African Rand (ZAR).
        /// </summary>
        ZAR,
        /// <summary>
        /// Zambian Kwacha (ZMW).
        /// </summary>
        ZMW
    }
    }
