﻿using ISO._4217.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISO._4217
{
    /// <summary>
    /// Source is here https://www.currency-iso.org/dam/downloads/lists/list_one.xml
    /// </summary>
    public static class CurrencyCodesResolver
    {
        private static readonly List<Currency> Codes = new List<Currency>
        {
            new Currency { Country = "AFGHANISTAN", Code = "AFN", Name = "Afghani", Num = "971" },
            new Currency { Country = "ÅLAND ISLANDS", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "ALBANIA", Code = "ALL", Name = "Lek", Num = "008" },
            new Currency { Country = "ALGERIA", Code = "DZD", Name = "Algerian Dinar", Num = "012" },
            new Currency { Country = "AMERICAN SAMOA", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "ANDORRA", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "ANGOLA", Code = "AOA", Name = "Kwanza", Num = "973" },
            new Currency { Country = "ANGUILLA", Code = "XCD", Name = "East Caribbean Dollar", Num = "951" },
            new Currency { Country = "ANTARCTICA", Code = "", Name = "No universal currency", Num = "" },
            new Currency { Country = "ANTIGUA AND BARBUDA", Code = "XCD", Name = "East Caribbean Dollar", Num = "951" },
            new Currency { Country = "ARGENTINA", Code = "ARS", Name = "Argentine Peso", Num = "032" },
            new Currency { Country = "ARMENIA", Code = "AMD", Name = "Armenian Dram", Num = "051" },
            new Currency { Country = "ARUBA", Code = "AWG", Name = "Aruban Florin", Num = "533" },
            new Currency { Country = "AUSTRALIA", Code = "AUD", Name = "Australian Dollar", Num = "036" },
            new Currency { Country = "AUSTRIA", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "AZERBAIJAN", Code = "AZN", Name = "Azerbaijan Manat", Num = "944" },
            new Currency { Country = "BAHAMAS (THE)", Code = "BSD", Name = "Bahamian Dollar", Num = "044" },
            new Currency { Country = "BAHRAIN", Code = "BHD", Name = "Bahraini Dinar", Num = "048" },
            new Currency { Country = "BANGLADESH", Code = "BDT", Name = "Taka", Num = "050" },
            new Currency { Country = "BARBADOS", Code = "BBD", Name = "Barbados Dollar", Num = "052" },
            new Currency { Country = "BELARUS", Code = "BYN", Name = "Belarusian Ruble", Num = "933" },
            new Currency { Country = "BELGIUM", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "BELIZE", Code = "BZD", Name = "Belize Dollar", Num = "084" },
            new Currency { Country = "BENIN", Code = "XOF", Name = "CFA Franc BCEAO", Num = "952" },
            new Currency { Country = "BERMUDA", Code = "BMD", Name = "Bermudian Dollar", Num = "060" },
            new Currency { Country = "BHUTAN", Code = "INR", Name = "Indian Rupee", Num = "356" },
            new Currency { Country = "BHUTAN", Code = "BTN", Name = "Ngultrum", Num = "064" },
            new Currency { Country = "BOLIVIA (PLURINATIONAL STATE OF)", Code = "BOB", Name = "Boliviano", Num = "068" },
            new Currency { Country = "BOLIVIA (PLURINATIONAL STATE OF)", Code = "BOV", Name = "Mvdol", Num = "984" },
            new Currency { Country = "BONAIRE, SINT EUSTATIUS AND SABA", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "BOSNIA AND HERZEGOVINA", Code = "BAM", Name = "Convertible Mark", Num = "977" },
            new Currency { Country = "BOTSWANA", Code = "BWP", Name = "Pula", Num = "072" },
            new Currency { Country = "BOUVET ISLAND", Code = "NOK", Name = "Norwegian Krone", Num = "578" },
            new Currency { Country = "BRAZIL", Code = "BRL", Name = "Brazilian Real", Num = "986" },
            new Currency { Country = "BRITISH INDIAN OCEAN TERRITORY (THE)", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "BRUNEI DARUSSALAM", Code = "BND", Name = "Brunei Dollar", Num = "096" },
            new Currency { Country = "BULGARIA", Code = "BGN", Name = "Bulgarian Lev", Num = "975" },
            new Currency { Country = "BURKINA FASO", Code = "XOF", Name = "CFA Franc BCEAO", Num = "952" },
            new Currency { Country = "BURUNDI", Code = "BIF", Name = "Burundi Franc", Num = "108" },
            new Currency { Country = "CABO VERDE", Code = "CVE", Name = "Cabo Verde Escudo", Num = "132" },
            new Currency { Country = "CAMBODIA", Code = "KHR", Name = "Riel", Num = "116" },
            new Currency { Country = "CAMEROON", Code = "XAF", Name = "CFA Franc BEAC", Num = "950" },
            new Currency { Country = "CANADA", Code = "CAD", Name = "Canadian Dollar", Num = "124" },
            new Currency { Country = "CAYMAN ISLANDS (THE)", Code = "KYD", Name = "Cayman Islands Dollar", Num = "136" },
            new Currency { Country = "CENTRAL AFRICAN REPUBLIC (THE)", Code = "XAF", Name = "CFA Franc BEAC", Num = "950" },
            new Currency { Country = "CHAD", Code = "XAF", Name = "CFA Franc BEAC", Num = "950" },
            new Currency { Country = "CHILE", Code = "CLP", Name = "Chilean Peso", Num = "152" },
            new Currency { Country = "CHILE", Code = "CLF", Name = "Unidad de Fomento", Num = "990" },
            new Currency { Country = "CHINA", Code = "CNY", Name = "Yuan Renminbi", Num = "156" },
            new Currency { Country = "CHRISTMAS ISLAND", Code = "AUD", Name = "Australian Dollar", Num = "036" },
            new Currency { Country = "COCOS (KEELING) ISLANDS (THE)", Code = "AUD", Name = "Australian Dollar", Num = "036" },
            new Currency { Country = "COLOMBIA", Code = "COP", Name = "Colombian Peso", Num = "170" },
            new Currency { Country = "COLOMBIA", Code = "COU", Name = "Unidad de Valor Real", Num = "970" },
            new Currency { Country = "COMOROS (THE)", Code = "KMF", Name = "Comorian Franc ", Num = "174" },
            new Currency { Country = "CONGO (THE DEMOCRATIC REPUBLIC OF THE)", Code = "CDF", Name = "Congolese Franc", Num = "976" },
            new Currency { Country = "CONGO (THE)", Code = "XAF", Name = "CFA Franc BEAC", Num = "950" },
            new Currency { Country = "COOK ISLANDS (THE)", Code = "NZD", Name = "New Zealand Dollar", Num = "554" },
            new Currency { Country = "COSTA RICA", Code = "CRC", Name = "Costa Rican Colon", Num = "188" },
            new Currency { Country = "CÔTE D'IVOIRE", Code = "XOF", Name = "CFA Franc BCEAO", Num = "952" },
            new Currency { Country = "CROATIA", Code = "HRK", Name = "Kuna", Num = "191" },
            new Currency { Country = "CUBA", Code = "CUP", Name = "Cuban Peso", Num = "192" },
            new Currency { Country = "CUBA", Code = "CUC", Name = "Peso Convertible", Num = "931" },
            new Currency { Country = "CURAÇAO", Code = "ANG", Name = "Netherlands Antillean Guilder", Num = "532" },
            new Currency { Country = "CYPRUS", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "CZECHIA", Code = "CZK", Name = "Czech Koruna", Num = "203" },
            new Currency { Country = "DENMARK", Code = "DKK", Name = "Danish Krone", Num = "208" },
            new Currency { Country = "DJIBOUTI", Code = "DJF", Name = "Djibouti Franc", Num = "262" },
            new Currency { Country = "DOMINICA", Code = "XCD", Name = "East Caribbean Dollar", Num = "951" },
            new Currency { Country = "DOMINICAN REPUBLIC (THE)", Code = "DOP", Name = "Dominican Peso", Num = "214" },
            new Currency { Country = "ECUADOR", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "EGYPT", Code = "EGP", Name = "Egyptian Pound", Num = "818" },
            new Currency { Country = "EL SALVADOR", Code = "SVC", Name = "El Salvador Colon", Num = "222" },
            new Currency { Country = "EL SALVADOR", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "EQUATORIAL GUINEA", Code = "XAF", Name = "CFA Franc BEAC", Num = "950" },
            new Currency { Country = "ERITREA", Code = "ERN", Name = "Nakfa", Num = "232" },
            new Currency { Country = "ESTONIA", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "ETHIOPIA", Code = "ETB", Name = "Ethiopian Birr", Num = "230" },
            new Currency { Country = "EUROPEAN UNION", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "FALKLAND ISLANDS (THE) [MALVINAS]", Code = "FKP", Name = "Falkland Islands Pound", Num = "238" },
            new Currency { Country = "FAROE ISLANDS (THE)", Code = "DKK", Name = "Danish Krone", Num = "208" },
            new Currency { Country = "FIJI", Code = "FJD", Name = "Fiji Dollar", Num = "242" },
            new Currency { Country = "FINLAND", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "FRANCE", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "FRENCH GUIANA", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "FRENCH POLYNESIA", Code = "XPF", Name = "CFP Franc", Num = "953" },
            new Currency { Country = "FRENCH SOUTHERN TERRITORIES (THE)", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "GABON", Code = "XAF", Name = "CFA Franc BEAC", Num = "950" },
            new Currency { Country = "GAMBIA (THE)", Code = "GMD", Name = "Dalasi", Num = "270" },
            new Currency { Country = "GEORGIA", Code = "GEL", Name = "Lari", Num = "981" },
            new Currency { Country = "GERMANY", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "GHANA", Code = "GHS", Name = "Ghana Cedi", Num = "936" },
            new Currency { Country = "GIBRALTAR", Code = "GIP", Name = "Gibraltar Pound", Num = "292" },
            new Currency { Country = "GREECE", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "GREENLAND", Code = "DKK", Name = "Danish Krone", Num = "208" },
            new Currency { Country = "GRENADA", Code = "XCD", Name = "East Caribbean Dollar", Num = "951" },
            new Currency { Country = "GUADELOUPE", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "GUAM", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "GUATEMALA", Code = "GTQ", Name = "Quetzal", Num = "320" },
            new Currency { Country = "GUERNSEY", Code = "GBP", Name = "Pound Sterling", Num = "826" },
            new Currency { Country = "GUINEA", Code = "GNF", Name = "Guinean Franc", Num = "324" },
            new Currency { Country = "GUINEA-BISSAU", Code = "XOF", Name = "CFA Franc BCEAO", Num = "952" },
            new Currency { Country = "GUYANA", Code = "GYD", Name = "Guyana Dollar", Num = "328" },
            new Currency { Country = "HAITI", Code = "HTG", Name = "Gourde", Num = "332" },
            new Currency { Country = "HAITI", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "HEARD ISLAND AND McDONALD ISLANDS", Code = "AUD", Name = "Australian Dollar", Num = "036" },
            new Currency { Country = "HOLY SEE (THE)", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "HONDURAS", Code = "HNL", Name = "Lempira", Num = "340" },
            new Currency { Country = "HONG KONG", Code = "HKD", Name = "Hong Kong Dollar", Num = "344" },
            new Currency { Country = "HUNGARY", Code = "HUF", Name = "Forint", Num = "348" },
            new Currency { Country = "ICELAND", Code = "ISK", Name = "Iceland Krona", Num = "352" },
            new Currency { Country = "INDIA", Code = "INR", Name = "Indian Rupee", Num = "356" },
            new Currency { Country = "INDONESIA", Code = "IDR", Name = "Rupiah", Num = "360" },
            new Currency { Country = "INTERNATIONAL MONETARY FUND (IMF) ", Code = "XDR", Name = "SDR (Special Drawing Right)", Num = "960" },
            new Currency { Country = "IRAN (ISLAMIC REPUBLIC OF)", Code = "IRR", Name = "Iranian Rial", Num = "364" },
            new Currency { Country = "IRAQ", Code = "IQD", Name = "Iraqi Dinar", Num = "368" },
            new Currency { Country = "IRELAND", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "ISLE OF MAN", Code = "GBP", Name = "Pound Sterling", Num = "826" },
            new Currency { Country = "ISRAEL", Code = "ILS", Name = "New Israeli Sheqel", Num = "376" },
            new Currency { Country = "ITALY", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "JAMAICA", Code = "JMD", Name = "Jamaican Dollar", Num = "388" },
            new Currency { Country = "JAPAN", Code = "JPY", Name = "Yen", Num = "392" },
            new Currency { Country = "JERSEY", Code = "GBP", Name = "Pound Sterling", Num = "826" },
            new Currency { Country = "JORDAN", Code = "JOD", Name = "Jordanian Dinar", Num = "400" },
            new Currency { Country = "KAZAKHSTAN", Code = "KZT", Name = "Tenge", Num = "398" },
            new Currency { Country = "KENYA", Code = "KES", Name = "Kenyan Shilling", Num = "404" },
            new Currency { Country = "KIRIBATI", Code = "AUD", Name = "Australian Dollar", Num = "036" },
            new Currency { Country = "KOREA (THE DEMOCRATIC PEOPLE’S REPUBLIC OF)", Code = "KPW", Name = "North Korean Won", Num = "408" },
            new Currency { Country = "KOREA (THE REPUBLIC OF)", Code = "KRW", Name = "Won", Num = "410" },
            new Currency { Country = "KUWAIT", Code = "KWD", Name = "Kuwaiti Dinar", Num = "414" },
            new Currency { Country = "KYRGYZSTAN", Code = "KGS", Name = "Som", Num = "417" },
            new Currency { Country = "LAO PEOPLE’S DEMOCRATIC REPUBLIC (THE)", Code = "LAK", Name = "Lao Kip", Num = "418" },
            new Currency { Country = "LATVIA", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "LEBANON", Code = "LBP", Name = "Lebanese Pound", Num = "422" },
            new Currency { Country = "LESOTHO", Code = "LSL", Name = "Loti", Num = "426" },
            new Currency { Country = "LESOTHO", Code = "ZAR", Name = "Rand", Num = "710" },
            new Currency { Country = "LIBERIA", Code = "LRD", Name = "Liberian Dollar", Num = "430" },
            new Currency { Country = "LIBYA", Code = "LYD", Name = "Libyan Dinar", Num = "434" },
            new Currency { Country = "LIECHTENSTEIN", Code = "CHF", Name = "Swiss Franc", Num = "756" },
            new Currency { Country = "LITHUANIA", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "LUXEMBOURG", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "MACAO", Code = "MOP", Name = "Pataca", Num = "446" },
            new Currency { Country = "MACEDONIA (THE FORMER YUGOSLAV REPUBLIC OF)", Code = "MKD", Name = "Denar", Num = "807" },
            new Currency { Country = "MADAGASCAR", Code = "MGA", Name = "Malagasy Ariary", Num = "969" },
            new Currency { Country = "MALAWI", Code = "MWK", Name = "Malawi Kwacha", Num = "454" },
            new Currency { Country = "MALAYSIA", Code = "MYR", Name = "Malaysian Ringgit", Num = "458" },
            new Currency { Country = "MALDIVES", Code = "MVR", Name = "Rufiyaa", Num = "462" },
            new Currency { Country = "MALI", Code = "XOF", Name = "CFA Franc BCEAO", Num = "952" },
            new Currency { Country = "MALTA", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "MARSHALL ISLANDS (THE)", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "MARTINIQUE", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "MAURITANIA", Code = "MRU", Name = "Ouguiya", Num = "929" },
            new Currency { Country = "MAURITIUS", Code = "MUR", Name = "Mauritius Rupee", Num = "480" },
            new Currency { Country = "MAYOTTE", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "MEMBER COUNTRIES OF THE AFRICAN DEVELOPMENT BANK GROUP", Code = "XUA", Name = "ADB Unit of Account", Num = "965" },
            new Currency { Country = "MEXICO", Code = "MXN", Name = "Mexican Peso", Num = "484" },
            new Currency { Country = "MEXICO", Code = "MXV", Name = "Mexican Unidad de Inversion (UDI)", Num = "979" },
            new Currency { Country = "MICRONESIA (FEDERATED STATES OF)", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "MOLDOVA (THE REPUBLIC OF)", Code = "MDL", Name = "Moldovan Leu", Num = "498" },
            new Currency { Country = "MONACO", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "MONGOLIA", Code = "MNT", Name = "Tugrik", Num = "496" },
            new Currency { Country = "MONTENEGRO", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "MONTSERRAT", Code = "XCD", Name = "East Caribbean Dollar", Num = "951" },
            new Currency { Country = "MOROCCO", Code = "MAD", Name = "Moroccan Dirham", Num = "504" },
            new Currency { Country = "MOZAMBIQUE", Code = "MZN", Name = "Mozambique Metical", Num = "943" },
            new Currency { Country = "MYANMAR", Code = "MMK", Name = "Kyat", Num = "104" },
            new Currency { Country = "NAMIBIA", Code = "NAD", Name = "Namibia Dollar", Num = "516" },
            new Currency { Country = "NAMIBIA", Code = "ZAR", Name = "Rand", Num = "710" },
            new Currency { Country = "NAURU", Code = "AUD", Name = "Australian Dollar", Num = "036" },
            new Currency { Country = "NEPAL", Code = "NPR", Name = "Nepalese Rupee", Num = "524" },
            new Currency { Country = "NETHERLANDS (THE)", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "NEW CALEDONIA", Code = "XPF", Name = "CFP Franc", Num = "953" },
            new Currency { Country = "NEW ZEALAND", Code = "NZD", Name = "New Zealand Dollar", Num = "554" },
            new Currency { Country = "NICARAGUA", Code = "NIO", Name = "Cordoba Oro", Num = "558" },
            new Currency { Country = "NIGER (THE)", Code = "XOF", Name = "CFA Franc BCEAO", Num = "952" },
            new Currency { Country = "NIGERIA", Code = "NGN", Name = "Naira", Num = "566" },
            new Currency { Country = "NIUE", Code = "NZD", Name = "New Zealand Dollar", Num = "554" },
            new Currency { Country = "NORFOLK ISLAND", Code = "AUD", Name = "Australian Dollar", Num = "036" },
            new Currency { Country = "NORTHERN MARIANA ISLANDS (THE)", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "NORWAY", Code = "NOK", Name = "Norwegian Krone", Num = "578" },
            new Currency { Country = "OMAN", Code = "OMR", Name = "Rial Omani", Num = "512" },
            new Currency { Country = "PAKISTAN", Code = "PKR", Name = "Pakistan Rupee", Num = "586" },
            new Currency { Country = "PALAU", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "PALESTINE, STATE OF", Code = "", Name = "No universal currency", Num = "" },
            new Currency { Country = "PANAMA", Code = "PAB", Name = "Balboa", Num = "590" },
            new Currency { Country = "PANAMA", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "PAPUA NEW GUINEA", Code = "PGK", Name = "Kina", Num = "598" },
            new Currency { Country = "PARAGUAY", Code = "PYG", Name = "Guarani", Num = "600" },
            new Currency { Country = "PERU", Code = "PEN", Name = "Sol", Num = "604" },
            new Currency { Country = "PHILIPPINES (THE)", Code = "PHP", Name = "Philippine Peso", Num = "608" },
            new Currency { Country = "PITCAIRN", Code = "NZD", Name = "New Zealand Dollar", Num = "554" },
            new Currency { Country = "POLAND", Code = "PLN", Name = "Zloty", Num = "985" },
            new Currency { Country = "PORTUGAL", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "PUERTO RICO", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "QATAR", Code = "QAR", Name = "Qatari Rial", Num = "634" },
            new Currency { Country = "RÉUNION", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "ROMANIA", Code = "RON", Name = "Romanian Leu", Num = "946" },
            new Currency { Country = "RUSSIAN FEDERATION (THE)", Code = "RUB", Name = "Russian Ruble", Num = "643" },
            new Currency { Country = "RWANDA", Code = "RWF", Name = "Rwanda Franc", Num = "646" },
            new Currency { Country = "SAINT BARTHÉLEMY", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "SAINT HELENA, ASCENSION AND TRISTAN DA CUNHA", Code = "SHP", Name = "Saint Helena Pound", Num = "654" },
            new Currency { Country = "SAINT KITTS AND NEVIS", Code = "XCD", Name = "East Caribbean Dollar", Num = "951" },
            new Currency { Country = "SAINT LUCIA", Code = "XCD", Name = "East Caribbean Dollar", Num = "951" },
            new Currency { Country = "SAINT MARTIN (FRENCH PART)", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "SAINT PIERRE AND MIQUELON", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "SAINT VINCENT AND THE GRENADINES", Code = "XCD", Name = "East Caribbean Dollar", Num = "951" },
            new Currency { Country = "SAMOA", Code = "WST", Name = "Tala", Num = "882" },
            new Currency { Country = "SAN MARINO", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "SAO TOME AND PRINCIPE", Code = "STN", Name = "Dobra", Num = "930" },
            new Currency { Country = "SAUDI ARABIA", Code = "SAR", Name = "Saudi Riyal", Num = "682" },
            new Currency { Country = "SENEGAL", Code = "XOF", Name = "CFA Franc BCEAO", Num = "952" },
            new Currency { Country = "SERBIA", Code = "RSD", Name = "Serbian Dinar", Num = "941" },
            new Currency { Country = "SEYCHELLES", Code = "SCR", Name = "Seychelles Rupee", Num = "690" },
            new Currency { Country = "SIERRA LEONE", Code = "SLL", Name = "Leone", Num = "694" },
            new Currency { Country = "SINGAPORE", Code = "SGD", Name = "Singapore Dollar", Num = "702" },
            new Currency { Country = "SINT MAARTEN (DUTCH PART)", Code = "ANG", Name = "Netherlands Antillean Guilder", Num = "532" },
            new Currency { Country = "SISTEMA UNITARIO DE COMPENSACION REGIONAL DE PAGOS SUCRE", Code = "XSU", Name = "Sucre", Num = "994" },
            new Currency { Country = "SLOVAKIA", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "SLOVENIA", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "SOLOMON ISLANDS", Code = "SBD", Name = "Solomon Islands Dollar", Num = "090" },
            new Currency { Country = "SOMALIA", Code = "SOS", Name = "Somali Shilling", Num = "706" },
            new Currency { Country = "SOUTH AFRICA", Code = "ZAR", Name = "Rand", Num = "710" },
            new Currency { Country = "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", Code = "", Name = "No universal currency", Num = "" },
            new Currency { Country = "SOUTH SUDAN", Code = "SSP", Name = "South Sudanese Pound", Num = "728" },
            new Currency { Country = "SPAIN", Code = "EUR", Name = "Euro", Num = "978" },
            new Currency { Country = "SRI LANKA", Code = "LKR", Name = "Sri Lanka Rupee", Num = "144" },
            new Currency { Country = "SUDAN (THE)", Code = "SDG", Name = "Sudanese Pound", Num = "938" },
            new Currency { Country = "SURINAME", Code = "SRD", Name = "Surinam Dollar", Num = "968" },
            new Currency { Country = "SVALBARD AND JAN MAYEN", Code = "NOK", Name = "Norwegian Krone", Num = "578" },
            new Currency { Country = "ESWATINI", Code = "SZL", Name = "Lilangeni", Num = "748" },
            new Currency { Country = "SWEDEN", Code = "SEK", Name = "Swedish Krona", Num = "752" },
            new Currency { Country = "SWITZERLAND", Code = "CHF", Name = "Swiss Franc", Num = "756" },
            new Currency { Country = "SWITZERLAND", Code = "CHE", Name = "WIR Euro", Num = "947" },
            new Currency { Country = "SWITZERLAND", Code = "CHW", Name = "WIR Franc", Num = "948" },
            new Currency { Country = "SYRIAN ARAB REPUBLIC", Code = "SYP", Name = "Syrian Pound", Num = "760" },
            new Currency { Country = "TAIWAN (PROVINCE OF CHINA)", Code = "TWD", Name = "New Taiwan Dollar", Num = "901" },
            new Currency { Country = "TAJIKISTAN", Code = "TJS", Name = "Somoni", Num = "972" },
            new Currency { Country = "TANZANIA, UNITED REPUBLIC OF", Code = "TZS", Name = "Tanzanian Shilling", Num = "834" },
            new Currency { Country = "THAILAND", Code = "THB", Name = "Baht", Num = "764" },
            new Currency { Country = "TIMOR-LESTE", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "TOGO", Code = "XOF", Name = "CFA Franc BCEAO", Num = "952" },
            new Currency { Country = "TOKELAU", Code = "NZD", Name = "New Zealand Dollar", Num = "554" },
            new Currency { Country = "TONGA", Code = "TOP", Name = "Pa’anga", Num = "776" },
            new Currency { Country = "TRINIDAD AND TOBAGO", Code = "TTD", Name = "Trinidad and Tobago Dollar", Num = "780" },
            new Currency { Country = "TUNISIA", Code = "TND", Name = "Tunisian Dinar", Num = "788" },
            new Currency { Country = "TURKEY", Code = "TRY", Name = "Turkish Lira", Num = "949" },
            new Currency { Country = "TURKMENISTAN", Code = "TMT", Name = "Turkmenistan New Manat", Num = "934" },
            new Currency { Country = "TURKS AND CAICOS ISLANDS (THE)", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "TUVALU", Code = "AUD", Name = "Australian Dollar", Num = "036" },
            new Currency { Country = "UGANDA", Code = "UGX", Name = "Uganda Shilling", Num = "800" },
            new Currency { Country = "UKRAINE", Code = "UAH", Name = "Hryvnia", Num = "980" },
            new Currency { Country = "UNITED ARAB EMIRATES (THE)", Code = "AED", Name = "UAE Dirham", Num = "784" },
            new Currency { Country = "UNITED KINGDOM OF GREAT BRITAIN AND NORTHERN IRELAND (THE)", Code = "GBP", Name = "Pound Sterling", Num = "826" },
            new Currency { Country = "UNITED STATES MINOR OUTLYING ISLANDS (THE)", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "UNITED STATES OF AMERICA (THE)", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "UNITED STATES OF AMERICA (THE)", Code = "USN", Name = "US Dollar (Next day)", Num = "997" },
            new Currency { Country = "URUGUAY", Code = "UYU", Name = "Peso Uruguayo", Num = "858" },
            new Currency { Country = "URUGUAY", Code = "UYI", Name = "Uruguay Peso en Unidades Indexadas (UI)", Num = "940" },
            new Currency { Country = "URUGUAY", Code = "UYW", Name = "Unidad Previsional", Num = "927" },
            new Currency { Country = "UZBEKISTAN", Code = "UZS", Name = "Uzbekistan Sum", Num = "860" },
            new Currency { Country = "VANUATU", Code = "VUV", Name = "Vatu", Num = "548" },
            new Currency { Country = "VENEZUELA (BOLIVARIAN REPUBLIC OF)", Code = "VES", Name = "Bolívar Soberano", Num = "928" },
            new Currency { Country = "VIET NAM", Code = "VND", Name = "Dong", Num = "704" },
            new Currency { Country = "VIRGIN ISLANDS (BRITISH)", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "VIRGIN ISLANDS (U.S.)", Code = "USD", Name = "US Dollar", Num = "840" },
            new Currency { Country = "WALLIS AND FUTUNA", Code = "XPF", Name = "CFP Franc", Num = "953" },
            new Currency { Country = "WESTERN SAHARA", Code = "MAD", Name = "Moroccan Dirham", Num = "504" },
            new Currency { Country = "YEMEN", Code = "YER", Name = "Yemeni Rial", Num = "886" },
            new Currency { Country = "ZAMBIA", Code = "ZMW", Name = "Zambian Kwacha", Num = "967" },
            new Currency { Country = "ZIMBABWE", Code = "ZWL", Name = "Zimbabwe Dollar", Num = "932" },
            new Currency { Country = "ZZ01_Bond Markets Unit European_EURCO", Code = "XBA", Name = "Bond Markets Unit European Composite Unit (EURCO)", Num = "955" },
            new Currency { Country = "ZZ02_Bond Markets Unit European_EMU-6", Code = "XBB", Name = "Bond Markets Unit European Monetary Unit (E.M.U.-6)", Num = "956" },
            new Currency { Country = "ZZ03_Bond Markets Unit European_EUA-9", Code = "XBC", Name = "Bond Markets Unit European Unit of Account 9 (E.U.A.-9)", Num = "957" },
            new Currency { Country = "ZZ04_Bond Markets Unit European_EUA-17", Code = "XBD", Name = "Bond Markets Unit European Unit of Account 17 (E.U.A.-17)", Num = "958" },
            new Currency { Country = "ZZ06_Testing_Code", Code = "XTS", Name = "Codes specifically reserved for testing purposes", Num = "963" },
            new Currency { Country = "ZZ07_No_Currency", Code = "XXX", Name = "The codes assigned for transactions where no currency is involved", Num = "999" },
            new Currency { Country = "ZZ08_Gold", Code = "XAU", Name = "Gold", Num = "959" },
            new Currency { Country = "ZZ09_Palladium", Code = "XPD", Name = "Palladium", Num = "964" },
            new Currency { Country = "ZZ10_Platinum", Code = "XPT", Name = "Platinum", Num = "962" },
            new Currency { Country = "ZZ11_Silver", Code = "XAG", Name = "Silver", Num = "961" },
        };


        #region Get currency data by number
        public static IEnumerable<Currency> GetCurrenciesByNumber(string number)
        {
            return Codes.FindAll(x => x.Num == number);
        }

        public static string GetCodeByNumber(string number)
        {
            return Codes.FirstOrDefault(x => x.Num == number)?.Code;
        }

        public static string GetCurrencyNameByNumber(string number)
        {
            return Codes.FirstOrDefault(x => x.Num == number)?.Name;
        }
        #endregion
    }
}
