using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Check_Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckPw_Click(object sender, EventArgs e)
        {
            pictureLogo.Visible = false;
            if (txtPassword.Text.Length >= 6)
            {
                #region Emojiler
                guvenli.Visible = false;
                istersen.Visible = false;
                riskli.Visible = false;
                onerilmez.Visible = false;
                kesinlikleonerilmez.Visible = false;
                #endregion
                #region Şifre Kombinasyonları
                string[] numaraKombineleri = { "123456", "1234567", "12345678", "147258", "258369", "000000", "25802580", "147258369", "12369874", "1234567890", "123", "1234", "12345", "054", "05", "+90", "90", "905", "0553", "055", "054", "54", "53", "52", "51", "50", "56", "57", "58", "59" };
                string[] dogumTarihleri = { "19", "20", "199", "200", "201", "198" };
                string[] takimlar = { "galatasaray", "fenerbahce", "besiktas", "trabzonspor", "adanademir", "antalyaspor", "goztepe", "rizespor", "ankaragucu", "akhisar", "karagumruk", "mersinidmanyurdu", "adanaspor", "adanademirspor", "bursaspor", "karsıyaka", "menemen", "basaksehir", "alanyaspor", "kasimpasa", "yenimalatya" };
                string[] sehirler = { "Adana", "Adiyaman", "Afyonkarahisar", "Agri", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydin", "Balikesir", "Bartin", "Batman", "Bayburt", "Bilecik", "Bingol", "Bitlis", "Bolu", "Burdur", "Bursa", "Canakkale", "Cankiri", "Corum", "Denizli", "Diyarbakir", "Duzce", "Edirne", "Elazig", "Erzincan", "Erzurum", "Eskisehir", "Gaziantep", "Giresun", "Gümüshane", "Hakkari", "Hatay", "Igdir", "Isparta", "İstanbul", "İzmir", "Kahramanmaras", "Karabuk", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırsehir", "Kocaeli", "Konya", "Kutahya", "Malatya", "Manisa", "Mardin", "Mersin", "Mugla", "Mus", "Nevsehir", "Nigde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Sanlıurfa", "Siirt", "Sinop", "Sivas", "Sırnak", "Tekirdag", "Tokat", "Trabzon", "Tunceli", "Usak", "Van", "Yalova", "Yozgat", "Zonguldak" };
                string[] plakalar = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81" };
                string[] renkler = { "sarı", "kırmızı", "mavi", "yesil", "siyah", "mor", "bordo", "koyu", "gri", "beyaz", "pembe", "kahverengi" };
                string[] ulkeIsimleri = { "Türkiye", "Suriye", "İran", "Afganistan", "Ermenistan", "Azerbaycan", "Japonya", "Çin", "Irak", "Hindistan", "Maldivler", "Pakistan", "Mogolistan", "Nepal", "SuudiArabistan", "Tayland", "Urdun", "Gürcistan", "Lübnan", "Vietnam", "KuzeyKore", "Filipinler", "Güney Kore", "Arabistan", "Malezya", "Tayvan", "Katar", "Fransa", "Almanya", "İspanya", "İtalya", "Luksemburg", "Hollanda", "İsviçre", "Belçika", "Avusturya", "Rusya", "Slovakya", "Romanya", "Ukrayna", "Danimarka", "Estonya", "Litvanya", "Hırvatistan", "Norvec", "Finlandiya", "İsvec", "Arnavutluk", "BosnaHersek", "Letonya", "Andorra", "Karadag", "Makedonya", "Yunanistan", "KuzeyKıbrıs", "Slovenya", "Sırbistan", "SanMarino", "Malta", "Kosova", "Vatikan", "Portekiz", "Bulgaristan", "Rusya", " Mısır", "Kenya", "Fas", "Gana", "Cezayir", "Gina", "Tunus", "Gana", "Yeşilburun", "Fildisi", "Avustralya", "Endonezya" };
                string[] aylar = { "ocak", "subat", "mart", "nisan", "mayıs", "haziran", "temmuz", "agustos", "eylul", "ekim", "kasım", "aralık" };
                string[] isimler = { "JALE", "ALİ", "MAHMUT", "MANSUR KÜRŞAD", "GAMZE", "MİRAÇ", "YÜCEL", "KUBİLAY", "HAYATİ", "BEDRİYE MÜGE", "BİRSEN", "SERDAL", "BÜNYAMİN", "ÖZGÜR", "FERDİ", "REYHAN", "İLHAN", "GÜLŞAH", "NALAN", "SEMİH", "ERGÜN", "FATİH", "ŞENAY", "SERKAN", "EMRE", "BAHATTİN", "IRAZCA", "HATİCE", "BARIŞ", "REZAN", "FATİH", "FUAT", "GÖKHAN", "ORHAN", "MEHMET", "EVREN", "OKTAY", "HARUN", "YAVUZ", "PINAR", "MEHMET", "UMUT", "MESUDE", "HÜSEYİN CAHİT", "HAŞİM ONUR", "EYYUP SABRİ", "MUSTAFA", "MUSTAFA", "UFUK", "AHMET ALİ", "MEDİHA", "HASAN", "KAMİL", "NEBİ", "ÖZCAN", "NAGİHAN", "CEREN", "SERKAN", "HASAN", "YUSUF KENAN", "ÇETİN", "TARKAN", "MERAL LEMAN", "ERGÜN", "KENAN AHMET", "URAL", "YAHYA", "BENGÜ", "FATİH NAZMİ", "DİLEK", "MEHMET", "TUFAN AKIN", "MEHMET", "TURGAY YILMAZ", "GÜLDEHEN", "GÖKMEN", "BÜLENT", "EROL", "BAHRİ", "ÖZEN ÖZLEM", "SELMA", "TUĞSEM", "TESLİME NAZLI", "GÜLÇİN", "İSMAİL", "MURAT", "EBRU", "TÜMAY", "AHMET", "EBRU", "HÜSEYİN YAVUZ", "BAŞAK", "AYŞEGÜL", "EVRİM", "YASER", "ÜLKÜ", "ÖZHAN", "UFUK", "AKSEL", "FULYA", "BURCU", "TAYLAN", "YILMAZ", "ZEYNEP", "BAYRAM", "GÜLAY", "RABİA", "SEVDA", "SERHAT", "ENGİN", "ASLI", "TUBA", "BARIŞ", "SEVGİ", "KALENDER", "HALİL", "BİLGE", "FERDA", "EZGİ", "AYSUN", "SEDA", "ÖZLEM", "ÖZDEN", "KORAY", "SENEM", "ZEYNEP", "EMEL", "BATURAY KANSU", "NURAY", "AYDOĞAN", "ÖZLEM", "DENİZ", "İLKNUR", "TEVFİK ÖZGÜN", "HASAN SERKAN", "KÜRŞAT", "SEYFİ", "ŞEYMA", "ÖZLEM", "ERSAGUN", "DİLBER", "MESUT", "ELİF", "MUHAMMET FATİH", "ÖZGÜR SİNAN", "MEHMET ÖZGÜR", "MAHPERİ", "ONUR", "İBRAHİM", "FATİH", "SEVİL", "SÜHEYLA", "VOLKAN", "İLKAY", "İLKNUR", "ZÜMRÜT ELA", "HALE", "YENER", "SEDEF", "FADIL", "SERPİL", "ZÜLFİYE", "SULTAN", "MUAMMER HAYRİ", "DERVİŞ", "YAŞAR GÖKHAN", "TUBA HANIM", "MEHRİ", "MUSTAFA FERHAT", "SERDAR", "MUSTAFA ERSAGUN", "ONAT", "ŞÜKRÜ", "OLCAY BAŞAK", "SERDAR", "YILDIZ", "AYDIN", "ALİ HALUK", "NİHAT BERKAY", "İSMAİL", "AYKAN", "SELÇUK", "MEHMET", "NEZİH", "MUSTAFA", "TİMUR", "ERHAN", "MUSTAFA", "MUTLU", "MEHMET HÜSEYİN", "İSMAİL EVREN", "OSMAN ERSEGUN", "MEHMET", "ELİF", "SERKAN", "MESUT", "MEHMET HİLMİ", "ASUDAN TUĞÇE", "AHMET GÖKHAN", "BAŞAK", "CEYHAN", "MUHAMMET TAYYİP", "ESİN", "ZEYNEP GÖKÇE", "EVRİM", "YASİN", "SALİHA", "DENİZ", "BELGİN", "ÖZLEM", "GONCA", "ESRA", "SEÇKİN", "ESRA", "FATİH", "MUSTAFA", "FEVZİYE", "MUSTAFA ARİF", "BİRGÜL", "ÖZLEM", "ÖZLEM", "FUNDA", "BERFİN", "DEMET", "SONAY", "SERÇİN", "ALMALA PINAR", "ÜMİT", "SENEM", "DENİZ", "MÜNEVER", "HATİCE", "ÖZLEM", "ÖZLEM", "ALİ SEÇKİN", "COŞKUN", "ÖZGE", "ZELİHA", "PINAR", "AYBÜKE", "HASİBE", "GÜRKAN", "ZÜHAL", "NAZIM", "ZEYNEP", "OSMAN", "AYLA", "BEYZA", "ELİF", "ERAY", "DİANA", "TUBA", "SEMRA", "VELAT", "BELGİN EMİNE", "SİBEL", "GÖKMEN ALPASLAN", "BENHUR ŞİRVAN", "DİLEK", "HANDE", "ŞAHABETTİN", "MİRAY", "ZERRİN", "İLKNUR", "ELİF", "MÜMTAZ", "TUĞBA", "DİLEK", "MEHMET BURHAN", "FUAT", "NİHAL", "AYŞEGÜL", "SEMA", "ZAFER", "NURSEL", "GÜLPERİ", "BİLGE", "FATİH", "CENGİZ", "SİMGE", "SEMA NİLAY", "EMİNE", "RİFAT CAN", "SİNAN", "LATİFE", "MEHMET", "NURDAN", "MELTEM", "ÜLKÜHAN", "HASAN", "GÜLDEN", "SAMET", "BERNA", "ÖZLEM", "NAFİYE", "KENAN", "SERKAN FAZLI", "NURSEL", "ABDULLAH", "ERGÜL", "HASAN", "MUSTAFA", "SEBAHAT", "EMİNE", "ERDAL", "LEZİZ", "BİRSEN", "TUBA", "AYŞEN", "EBRU", "TAYFUR", "MELTEM", "SERHAT", "AYCAN ÖZDEN", "ELİF", "SEVGÜL", "SELDA", "IŞIL", "SİBEL", "JÜLİDE ZEHRA", "BERİL GÜLÜŞ", "İNCİ", "ENGİN", "GÜLBAHAR", "MÜBECCEL", "NURDAN", "HANDE", "ÖZNUR", "HANDAN", "OSMAN TURGUT", "EMİN TONYUKUK", "NEJDET", "MUSTAFA", "GÜLİZ", "İPEK", "NİHAL", "MELDA", "DERYA", "DEMET", "MAHMUT", "EMEL", "ÖZNUR", "SONGÜL", "RESA", "GAMZE", "ÜMİT", "DENİZ", "MUAMMER MÜSLİM", "ÖMER FARUK", "TUĞÇE", "VELİ ENES", "ZAHİDE", "NURETTİN İREM", "SEDAT", "REMZİYE", "SİBEL", "İLKNUR", "YASEMİN", "AYLİN", "EMEL", "EMEL CENNET", "ŞAFAK", "METİN", "SÜLEYMAN", "MUKADDES", "BARIŞ", "MEHMET ALİ", "TEVFİK", "SERDAR", "EMİNE", "MÜRŞİT", "MUTLU", "FEZA", "İBRAHİM TAYFUN", "SERKAN", "AHMET SERKAN", "FATMA", "BERKER", "SERDAR", "KUBİLAY", "ERKAN", "KERİM", "İLKNUR", "SERKAN", "MUSTAFA", "RUKİYE", "GÖKTEN", "SEZGİ", "TUĞBA", "MURAT", "HATİCE", "HATİCE EYLÜL", "AYŞE GÜL", "NEVİN", "HABİBE", "KEZBAN", "AYSEL", "TALHA", "DUYGU", "GÖZDE", "FIRAT", "EBRU", "GÜLEN ECE", "SİBEL", "FULYA", "VEDAT", "HARUN", "FİLİZ", "NURAY", "ŞİRİN", "ÖZLEM", "BURCU", "PINAR", "HATUN", "CEYDA", "BURCU", "AYŞE", "ALPER", "FEYZA", "HACI MURAT", "MÜCELLA", "FEYZAHAN", "ŞENAY", "MERİH", "YUSUF", "ARDA", "EVRE", "KONURALP", "KIVANÇ", "EMİNE", "VOLKAN", "NİHAT", "RENGİN ASLIHAN", "EMRE", "ARİFE ESRA", "SEDAT", "MURAT", "CEM", "ERHAN", "ÖMÜR", "UMUT CAN", "MUSTAFA NAFİZ", "DAMLA", "MÜSLİM", "ABDULKADİR", "SAADET", "REZZAN", "SEDAT", "İBRAHİM", "LEYLA", "TÜLAY", "ENDER", "YELİZ", "ÖZGÜL", "HALE", "BERÇEM", "MUSTAFA", "TUBA", "SABAHATTİN", "ŞAFAK", "EVRİM", "REŞAT", "MUMUN", "FUNDA ÖZLEM", "NUR", "METE", "TÜLAY", "ÖZLEM", "HATİCE NİLDEN", "MELTEM", "EDA", "MELTEM", "MUSTAFA", "YURDUN", "SEMA", "TUBA", "SERPİL", "CENK", "TANER", "ZEKERİYA", "MUHAMMED ALİ", "TUĞRUL", "YÜCEL", "ESMA ÖZLEM", "AHMET", "SEVDE NUR", "SAMİ", "GAMZE", "GÜLSÜM", "SERHAT", "BARIŞ", "GÜLSEREN", "SULTAN", "İLKER", "DERAM", "AHMET", "BALA BAŞAK", "FEVZİ FIRAT", "GÖZDE", "FERHAN", "İLKER", "SALİM", "EMİNE", "MURAT", "ATAKAN", "REFİK", "MUSTAFA", "ÖZGÜR", "İKLİL", "ZÜHAL GÜLSÜM", "MEHTAP", "DENİZ", "ÜMİT", "MEHMET", "VOLKAN", "İLKNUR", "SELÇUK", "ÖZLEM", "GÖKHAN", "METE", "HÜMEYRA", "PAPATYA", "LEVENT", "FADİME SEVGİ", "ERSEN", "ŞULE MİNE", "MELİA", "ŞERMİN", "AYLİA", "AHMETEMRE", "VEDAT", "HALUK", "SEZGİN", "ZEHRA BETÜL", "VOLKAN", "ÜNSAL", "KORAY", "GÜLŞAH", "HİCRAN", "YUSUF KENAN", "YUSUF", "ORHAN", "FÜSUN", "ÖZLEM", "MEHMET", "SERKAN", "İKRAM", "ÜLKÜHAN", "NUH", "İSMAİL", "GÜLŞAH", "AYKUT", "NEŞE", "NEZAKET", "MUHAMMET DEVRAN", "HANDAN", "ATİLLA", "AYŞEGÜL", "PINAR", "ARZU", "NEŞE", "CEYHAN", "HASAN SAMİ", "MEHMET", "SALİH", "FERDA", "DİLEK", "AYHAN", "HASAN ULAŞ", "SUNA", "SELAMİ", "SÜREYYA", "BURCU", "CEM YAŞAR", "ÇAĞDAŞ", "DOĞAN", "AHMET", "HATİCE", "HAYRİ", "GÜHER", "SUNA", "ARZU", "AHMET", "AHMET", "SEMİH", "YUSUF", "ALİ", "ELİF ÇİLER", "ELİF", "YETKİN", "BURAK", "VEYSEL", "BURCU", "REFAETTİN", "AYŞE GÜL", "HÜSEYİN KUNTER", "EMİNE", "EBRU", "ESRA NUR", "SAMİ", "MUSTAFA GÜRHAN", "ORHAN", "HAÇÇE", "MEHMET MURAT", "NAZAN", "TUĞBA", "OĞUZHAN", "BERFİN CAN", "ÖZGÜR", "CİHAN", "DERMAN", "NİHAL", "IŞIN", "HATİCE", "DİDEM", "SUAT", "SİMENDER", "ADNAN", "SEZİN", "ŞERAFETTİN", "BERRİN", "ÖZGÜR", "TAYFUR", "SERHAT", "FUNDA", "NESLİHAN", "SERVET", "EMRE", "ORÇUN", "FATMA ESİN", "DERYA", "DUYGU", "HÜSEYİN", "AYKUT", "AYŞE", "SEHER ÖZLEM", "SEDA", "ESRA CAN", "EVREN", "NİLÜFER", "MURAT", "YUSUF", "MUSTAFA BARAN", "GÜNEŞ", "FATİH", "MEHMET", "ORHAN", "PINAR", "ERHAN", "GÜLDEN", "LATİFE", "SİBEL", "FATMA SELCEN", "HALİS", "YELDA", "ZEHRA", "MEHMET REŞİT", "EMCED", "OKAN", "ABDULLAH ARİF", "ÖZLEM", "AYDEMİR", "FATİH", "AYDIN", "BENGÜHAN", "AHMET", "TOLUNAY", "TUĞRA", "ÖZGÜR", "YUSUF", "ÖNDER TURGUT", "BARAN", "SEYHAN", "ZEKİ", "KADİR", "MURAT", "İHSAN", "DEMİR", "MUHAMMET MURAT", "MUHAMMED", "BAHADIR", "İLHAN", "YILDIRIM", "OĞUZ KAAN", "EFTAL MURAT", "GÖKAY", "FATİH RIFAT", "NURAN", "HABİL", "ÖMER ÖZKAN", "SELMA", "NURETTİN", "AHMET", "UTKU", "SÜLEYMAN", "CAN", "ONUR KADİR", "FİLİZ", "CANSU SELCAN", "ABDULLAH", "NESLİHAN", "SEDA ELÇİM", "KÜBRA", "HÜSEYİN", "BELMA", "MÜCAHİT", "CEYHUN", "GÜLTEKİN  GÜNHAN", "HANDE", "GÜLHANIM", "ÖMER", "ZİYA", "ÇAĞRI", "SERKAN", "LEVENT", "İSA", "CEM", "HÜSEYİN", "CEMİLE ÇİĞDEM", "MAHMUT", "ÖNDER", "RAŞAN", "İSMAİL YAVUZ", "ÖMER", "KENAN SELÇUK", "EMRE", "SERDAR", "SONER", "ENVER", "MUHLİS", "TİMUR", "LEMAN", "ELA", "CEMİL", "BURCU", "SALİHA SANEM", "ZELİHA", "ALEVTİNA", "ARZU", "MEHMET", "BİREYLÜL", "AYSEL", "ÖZGÜL", "SIDIKA", "TUNA", "ÖVGÜ ANIL", "EMİŞ", "NİLGÜN", "ELİF", "SEBİHA", "YUSUF ALPER", "IŞIL", "AYŞEGÜL", "TÜMAY", "ZERİN", "MEHMET", "FATMA ECE", "AHMET", "NEVROZ", "SEMA", "GAMZE PINAR", "FATMA", "MELTEM HALE", "SELMA", "İBRAHİM", "ASLIHAN", "FİLİZ", "BİLGİ", "TUĞBA", "HÜSEYİN", "EVREN", "FERDİ", "BURÇİN", "BARIŞ", "BAVER", "MAHMUT", "EMRAH KEMAL", "MURAT", "MEHMET ÖZER", "GÖKAY", "NECİP", "ERKAN", "ÜMİT", "GANİM", "BARAN", "FATİH", "SANCAR", "MUSTAFA KEMAL", "DURAN", "HASAN", "GÖRKEM", "ALİ OZAN", "VELİ ÇAĞLAR", "İRFAN", "SEYFİ CEM", "CÜNEYT", "ALİ", "FIRAT", "MUHAMMED TAHA", "BURAK", "MUSTAFA", "NİZAMETTİN", "RECEP GANİ", "ARZU", "MAHMUT NURİ", "GÜNAY", "BESTE", "CEM", "EMRAH", "HALİL İBRAHİM", "ESEN İBRAHİM", "MELİKE", "MÜRSEL", "KORAY", "UMUT SİNAN", "İBRAHİM BARIŞ", "BURHAN", "MUSTAFA KÜRŞAT", "SERDAR BORA", "FUAT", "ELİF", "SİBEL", "ADEM", "CEM İNAN", "GÖKTEKİN", "DİLARA", "SEDA", "CUMHUR", "HALUK", "PINAR", "AYKUT", "ÖYKÜ", "BAŞAK", "ÖMER", "SERHAN", "SULTAN", "MİNE CANSU", "SUAT", "ÇİĞDEM", "HANDE", "UMUT SEDA", "EVRİM", "DİCLE", "İREM", "FATMA", "İLKNUR", "CEMİLE AYŞE", "FEYZA", "MUAMMER", "EBRU", "DİNÇER AYDIN", "AYŞE AHSEN", "PINAR", "SÜREYYA BURCU", "MARİA", "SEÇİL", "BARIŞ", "ŞAHİNDE", "MEHMET", "NEVRİYE", "NİLAY", "RÜŞTÜ", "ASLI", "TANSU", "ASLIHAN", "NURCAN", "DEMET", "ERDEM", "BETÜL EMİNE", "ÇETİN", "PINAR", "RASİM", "AHMET", "ZEHRA", "SELİM", "DENİZ", "MESUT", "AYSEL", "MÜMÜNE", "DUÇEM", "YAKUP", "ERCAN", "MEHMET GÖKÇE", "ATİLLA SÜLEYMAN", "MERAL", "NURDAN", "SEÇİL", "ELİF", "HASAN BİLEN", "NİLAY", "HİLAL", "MUSTAFA", "ŞEYMA MELİHA", "MÜJDAT", "BURCU", "ARİF", "AYŞE", "HACİ HALİL", "IŞIK", "SERAY", "SERHAT BURKAY", "EMİN", "ÇAVLAN", "ŞEREF CAN", "KADİR", "MÜBERRA", "AYŞE", "HASAN", "SAVAŞ", "AYŞE NUR", "SÜLEYMAN", "DUYGU", "HACI MEHMET", "MEHTAP", "ERKAN", "SEMİNE", "ELİF", "RAMAZAN", "AHMET EMRE", "SERKAN", "DENİZ", "MİNE", "FATİH", "İREM", "ENDER", "YASEMİN", "SEMA", "MUSTAFA ULAŞ", "ALİ", "EMİNE", "TÜLAY", "BİRSEN", "GÜLSEN", "TUBA", "HAYRİYE", "BAHADIR", "SEZEN", "EDİP GÜVENÇ", "MEHTAP", "FİLİZ", "EYLEM", "RAMAZAN", "BİLGİN", "ESRA", "ATİYE MELTEM", "METİN", "ÖZLEM", "OSMAN", "AYŞE", "HİLAL", "YAVUZ", "ÖZLEM", "AYŞE", "MUSTAFA", "ASUMAN", "ÖMER", "ŞENAY", "GÜLNAME", "ÖZLEM", "BETÜL", "EMİNE DİLEK", "ZELİHA", "ESİN SEREN", "FİLİZ", "ULAŞ", "HALE", "ADEM", "İLKER", "ERHAN", "FARUK", "İBRAHİM", "SERKAN", "MAHMUT ESAT", "ERAY", "OKTAY", "DENİZ", "OSMAN", "İZZET", "İHSAN", "URAL", "ARİF", "AZİZ", "FUAT ERNİS", "HAKAN", "MUZAFFER OĞUZ", "MAHİR", "TAYYAR ALP", "EREM", "CİHAN", "MEHMET", "ÜMİT", "MEHMET", "YASEMİN", "CEYDA", "FATIMA İLAY", "NİLAY", "HURİYE", "MERVE", "ŞEYMA", "SELAHATTİN", "İLKER", "ÖMER", "SÜLEYMAN", "TAYFUN", "ESER", "MEHMET CİHAT", "İSMAİL", "ABDULLAH", "MURAT", "MUSTAFA", "AYDOĞAN", "HAMDİYE", "KERİME RUMEYSA", "MELAHAT", "UYSAN", "EMRAH", "HAYRİ ÜSTÜN", "MURAT", "HÜSEYİN SAİD", "SELİM", "ZEKERİYA", "FATİH", "DERYA", "NEVAL", "SEZER", "ÖZGE", "HATİKE", "ÖZGÜR", "ŞAFAK", "AHMET TUNÇ", "ÖZDEN", "OKAN", "RAZİYE DAMLA", "MAHMUT", "LALE", "EYÜP", "DERYA", "SELAHATTİN", "ZEKİ", "HÜSEYİN", "MELEK", "BİNNUR", "ONUR SALİH", "ERKİN", "MURAT", "ERHAN", "BURAK", "AYŞE CEREN", "NUMAN", "ÖZLEM", "ÜZEYİR", "CAN", "MUSTAFA", "KORHAN", "ALPER", "FUNDA", "HAMZA", "MUSTAFA RAŞİD", "YUSUF", "MELİKE", "ŞÜKRÜ", "KASIM", "GÖKSEL", "HİKMET", "ASIM", "ÜMRAN", "TEKİN", "MURAT", "HACER", "BERAY", "HANIM", "EDA", "NURAY", "ÖMER FARUK", "FERHAT", "OĞUZ", "BENGÜ", "AHMET MERT", "PINAR", "EMRE", "KÜBRA", "SELÇUK", "ŞENOL", "ORHAN", "MÜMÜN FATİH", "MURAT", "MERT", "KADİR", "KAAN SUAT", "ERCAN", "GÖKHAN", "DENİZ", "CİHAN", "CEM", "ALİŞAN", "ALİ SAİP", "ABİDE MERVE", "YUSUF", "ÖMER", "SERDAR", "YÜKSEL", "AHMET", "MAHMUT", "BURAK", "YASEMİN", "İBRAHİM FUAT", "MUSTAFA", "BİLGE MERVE", "AHMET CEVDET", "SEHER", "MEHMET DENİZ", "SAMET", "SAMET SANCAR", "ŞULE", "SELİM", "KADİR", "CAHİT", "HAYRUNNİSA", "UĞUR", "RESUL", "MUSTAFA BUĞRA", "İSHAK", "ESRA", "SANEM GÖKÇEN MERVE", "EZGİ", "MUSTAFA GÜVENÇ", "OĞUZ KAĞAN", "ESMA", "ÖMER AYKUT", "MEHMET ŞİRİN", "OSMAN", "AHMET", "NAİL", "İREM", "ELA", "BAHRİ", "ALİ RIZA", "ADEM", "MEHMET", "BAYRAM FURKAN", "HALİL", "KÜBRA", "SEFA", "MEHTAP", "FATİH", "BERKAN", "HÜSEYİN", "VOLKAN", "ŞEBNEM", "TUBA", "AYHAN", "ENNUR", "ALİ RIZA", "FATİH", "GÖZDE", "SEVİL", "EDA", "HATİCE", "ZARİFE", "BURAK", "İREM", "KÜBRA", "EMİNE", "DİLEK", "TUBA", "HALİL", "ESER", "EBUBEKİR ONUR", "MEHMET VEYSEL", "BURCU", "AYŞEGÜL", "DERYA SEMA", "ÇAĞLA", "KADİR", "BURAK", "MELİKE", "BAYRAM", "AYŞEGÜL", "TUĞBA", "MEHMET", "ELİF", "TÜRKER", "SEMİH", "HATİCE", "CANSU", "SERHAT", "TANER", "İDRİS", "SEVİNÇ", "FERİDE", "EVREN", "TUĞBA", "MUHAMMED MUCAHİD", "HİLAL", "DİLEK", "NAZLI", "ŞİFA", "GÜLÇİN", "KEZBAN", "YELDA", "SEDA", "CEYLAN", "BURAK", "UĞUR", "ŞEYMA", "SELMA", "EMRE", "MUHAMMED FATİH", "AHMET", "HASAN", "RUKİYE", "ADİL", "MUSTAFA", "MUSTAFA ASIM", "METİN", "CEREN", "SÜLEYMAN", "MELİKE", "TUĞBA", "ÇAĞRI", "BURHANETTİN", "İBRAHİM", "YUNUS EMRE", "KADİR", "MEHMET", "İLKER", "GÖKHAN", "KEMAL KÜRŞAT", "AHMET", "ZEHRA", "AZİZ", "İSA", "GÖKHAN", "BARIŞ", "MEHMET SUPHİ", "ASİYE BURCU", "ZEYNEP", "YÜKSEL UĞUR", "VOLKAN", "UFUK", "TUĞBA", "SELİM", "SELÇUK", "SALİHA DİLEK", "ÖZKAN", "ÖVÜNÇ", "OSMAN", "NUR ALEYNA", "MUHAMMED FURKAN", "MEHMET VEHBİ", "MEHMET İKBAL", "MEHMET", "LEYLA", "İZZETTİN", "İSMAİL", "İSMAİL", "İHSAN BURAK", "İBRAHİM", "HİLAL", "HAYRİYE", "GİZEM", "ESİN", "ERCAN", "ENES TAHİR", "DİDEM", "DENİZ", "BUĞRA", "BİLGİN", "ALİ MUHARREM", "ALİ", "ADEM", "ADEM", "IŞIL", "YUSUF", "MUSTAFA", "HÜSEYİN", "EZEL", "EMİNE", "ELİF CEREN", "AYŞE GİZEM", "DEMET", "DİDEM AYŞE", "ESER", "AYŞE GÜLÇİN", "HACER", "FERAT", "ZEYNEP", "KIYMET", "ASLAN", "ALİ", "GİZEM", "CUMA", "MEHTAP", "HAMDİ", "ORHAN", "NURİ ANIL", "SEMRA", "ÖKKEŞ", "VEYSEL", "ŞERİFE YASEMİN", "MEHMET", "MEHMET", "TOLGA", "OĞUZHAN", "MUSTAFA", "MAHSUM", "İSMAİL", "MEHMET", "PERVİN", "MURAT", "SALİM", "YUNUS", "VEYSEL", "ÖMER", "AHMET", "AYDIN", "ABDULKADİR", "AHMET", "AYŞEGÜL", "AZİZ", "ABDULLAH", "ABDULLAH", "YILDIRIM", "AYŞEGÜL", "İBRAHİM", "SİBEL", "MUZAFFER", "MUHAMMED YUSUF", "HAMZA", "HAKAN", "NESRİN", "EMRAH", "KEZİBAN", "MEHMET ALİ", "MELİKE ELİF", "BURHAN", "CEVAHİR", "CİHAN", "EMRAH", "MEHMET ALİ", "FATİH", "MAHMUT", "FATİH", "DAVUT", "EDA", "ÖMER FARUK", "PELİN", "SALİH", "YUSUF ZİYA", "ZERİN", "ÖZKAN", "YUSUF", "UMUT", "EMRAH", "ŞEYHMUS", "MERT METİN", "MUKADDES", "HAZAN", "HALİM", "MEHMET AKİF", "AYCAN", "CEMİL", "BERNA", "AHMET", "HÜSEYİN", "ERKAN", "HAKAN", "BAYRAM", "RUMEYSA", "ÇİLE", "VEYSİ", "ZUHAL", "YÜCEL", "ESMERALDA", "NİLÜFER", "BURÇHAN", "VOLKAN", "SELCEN", "MUSTAFA", "HATİCE", "BURCU", "AHMET BURAK", "BÜLENT", "MÜCADİYE", "SONGÜL", "IŞIK MELİKE", "MEHMET RAŞİT", "AYHAN", "SERDAR", "ERKAN", "EMRAH", "ERDAL", "RAHİME", "GÜLDEN SİNEM", "İHSAN", "ABDUL AZİM", "ÖZTAN", "ŞENOL", "MEHMET HAZBİN", "İSMAİL ŞENOL", "BORA", "HAMZA", "SEDA", "FATİH", "UĞUR", "KEMAL", "ADİL", "MAZLUM", "CEM ATAKAN", "VOLKAN ", "MUHAMMED ", "ERDEM", "FATMA", "HATİCE", "MEHMET EVREN", "ATACAN", "FATMA", "ŞADİ", "GÜLCAN", "MERYEM", "KAMERCAN", "ESRA", "ŞERİFE SEÇİL", "ZEHRA", "VAZİR AKBER", "ZEYNEP", "ALİ SAİD", "MURAT", "UTKU", "SAİD", "İRFAN", "HALİME", "ÜMMÜ GÜLSÜM", "ŞAFAK", "BETÜL", "BAŞAK", "ZEYNEP EZGİ", "VASFİYE", "ERDEM", "İBRAHİM", "AYŞE", "MEHMET VEHBİ", "FATMA", "EMEL", "ADEM", "ESEN", "HACI KEMAL", "EMRE", "ÖZGÜR", "OSMAN", "ÇETİN", "SONGÜL", "MUSTAFA", "ÖZLEM", "ZAFER", "FATİH", "MAKBULE SEDA", "FATMA BEGÜM", "TUĞBA", "OSMAN", "SİNEM", "ANIL", "KEMAL", "EREN", "BİLAL BARIŞ", "İBRAHİM", "ATILGAN", "BERNA", "SERAP", "BEKİR", "EYÜP", "EGEMEN", "ALİ", "YÜCEL", "TANER", "VAHDETTİN TALHA", "TOLGAHAN", "MUKADDER", "ENGİN", "SERTAÇ", "CİHAN", "PINAR", "AYŞE", "UĞURAY", "MUSTAFA", "EDA", "ELİF", "TAYLAN UĞUR", "ABİDİN", "BULUT", "CUNDULLAH", "ADNAN", "ERSİN", "ERHAN HÜSEYİN", "OĞUZ", "HAYRİ", "NURİ", "SELMA", "ESİN", "YAKUP İLKER", "AHMET", "ABDULLATİF", "FATİH", "ÖZLEM", "İNANÇ", "HALİL İBRAHİM", "ÖZGE", "HASAN", "PINAR", "AYŞE", "AYŞE", "HALİL CAN", "CEM ÖZGÜR", "SEDA", "UMUT", "VOLKAN ONUR", "EMRAH", "NAGİHAN", "HÜSEYİN", "MEHMET DİRİM", "MİNE", "GİZEM", "ÖMER", "TUĞBA", "MERVE", "YÜCE", "AYŞE PINAR", "AHMET CAN", "MERVE", "EMRE", "ERDİNÇ", "NİLAY", "BUŞRA", "ZÜHAL", "CAFER", "İLKER", "TURAN", "RECEP", "EBRU", "ÖMER FARUK", "MEHMET NURİ", "HİLAL", "NURHAN", "YASEMİN", "NAGİHAN", "ALİ KEMAL", "PINAR", "GİZEM", "UYGAR", "SEFA", "NURULLAH", "GİZEM", "SEVAL", "ŞERİF", "BERFU", "SEMİH", "SIDDIKA", "TUĞBA", "İRFAN YILDIRIM", "FAHRİ", "CANSU", "PETEK", "ELİF", "CEM", "EMRAH", "BÜŞRA", "NAFİZ", "ŞEYMA", "EKREM", "YASEMİN", "AYŞE", "ÇAĞRI", "MEHMET", "ÖMER GÖKHAN", "REYHAN", "HÜSEYİN", "ÖZGE", "DERYA", "MUSTAFA", "ESMA", "ÖZLEM", "GÖZDE", "SELİM", "EMİNE", "ÇİĞDEM", "ŞERİFE EZGİ", "NEFİSE", "TAYFUN", "PELİN", "ÖZGE", "KADER", "BELGİN", "ABDULAZİZ", "EMEL", "NUR", "BURCU", "CEYDA", "VEHBİ", "RAHİME", "ALİ", "DENİZ", "MUHAMMED", "EMRE", "HASAN", "ÜBEYDULLAH", "EYÜP GÖKHAN", "KÜBRA", "İTİBAR", "MUSTAFA ABDULLAH", "TUBA", "NURDAN", "HATİCE", "BÜŞRA", "ZEHRA", "CANAN", "OSMAN BİLGE", "TUBA", "FARİS", "AYHAN", "TURĞUT", "ONUR", "MERVE", "HİDAYET", "TUBA", "ABDULKERİM", "MUHAMMED RIZA", "DİLEK", "ARDA NERMİN", "FAİK", "HALİL", "HASAN HÜSEYİN", "SEMA", "MUSA", "AYŞEGÜL", "BÜŞRA", "ZEYNEP", "METİN", "CİHAN", "MERAL", "HİLAL", "DİDEM", "İSMAİL", "HASAN CIVAN", "MEHMET AKİF", "FATİH", "CEM", "YUSUF", "HÜSEYİN", "TUBA", "TAYFUN", "MUSTAFA", "HASAN", "RUKİYE ÖZDEN", "MEHMET", "ESRA", "HASAN", "MUSTAFA CİHAD", "EYÜP", "MURAT", "İBRAHİM HALİL", "SEDAT", "MEHMET", "HÜSEYİN", "MURAT", "HACI", "AYŞE FULYA", "FAİK", "RAMAZAN", "MEHMET", "SAVAŞ", "AYHAN", "NAİME SILA", "RIFAT", "MURAT", "FİKRİ", "HASAN", "YURDAGÜL", "MUHAMMET MUSTAFA", "ERCAN", "TUĞBA", "MEHTAP", "HAMİT", "FERİT", "DENİZ", "MUSTAFA", "ŞAHİKA", "SERDAR", "TAHSİN BATUHAN", "ONUR", "MURAT", "EMİNE AYÇA", "İLYAS", "ECE", "MUSTAFA", "MURAT", "AHMET ÇAĞRI", "NİLGÜN", "MUSTAFA", "ERHAN", "VEYSEL", "HAKAN", "FATİH", "BARIŞ", "ANDAÇ", "ŞENOL", "HASAN", "KEMAL", "CEYHUN", "ABDÜLSAMET", "İBRAHİM", "AHMET", "SERPİL", "ÜMMÜGÜLSÜM", "YAVUZ", "SÜHEYLA AYÇA", "ÖZGE", "TUBA", "MERT", "ÖZGÜR", "MELİHA ESRA", "BETÜL", "ABDULLAH", "SİNAN", "GÜNDEM", "KEZİBAN", "DERYA", "OĞUZ", "BEDRİ", "MEHMET", "EMRE", "ÜMİT", "HALİL İBRAHİM", "ÖZGE", "HAZEL", "FATMA BETÜL", "MUSTAFA", "AHMET BİLGEHAN", "HİKMET EKİN", "EMİN", "YİĞİT", "ABDULSAMET", "PINAR", "MUSACİDE ZEHRA", "BURAK", "TUĞÇE", "MAHMUT BAKIR", "ELİF TUĞÇE", "EKİN", "ASLIHAN ESRA", "İSMAİL MİKDAT", "UFUK", "MEHMET NURİ", "BİLGE", "ELİF AYŞE", "ERKAN SABRİ", "İREM", "BÜŞRA SULTAN", "MUSTAFA ALİCAN", "AYBEGÜM", "NEFİSE", "ZEKERİYA ERSİN", "AHMETCAN", "ABDURRAHMAN FUAT", "ZEYNEP", "FATİH", "ÇAĞDAŞ", "UĞURAY", "SARE", "ONUR", "SERAP", "MURAT", "EMİNE", "MUSTAFA", "BAHADIR", "ZEYNEP", "GÖZDE KÜBRA", "BURAK", "MEHMET", "MUHAMMED HASAN", "İSMAİL", "SAYGIN", "GÖKHAN", "ALPER", "ÇAĞLAR", "CEMAL", "HÜSEYİN ONUR", "CEMRE", "MELTEM", "CEYHUN", "ASLI", "İBRAHİM", "GÖZDEM", "HİLAYDA", "HASRET", "ŞEBNEM", "ONUR", "CAN", "AYŞEGÜL", "EMİNE", "PELİN", "ARMAN", "MERVE", "GAMZE", "ALİŞAN", "ERDEM", "ENES", "ORGÜL DERYA", "BAŞAK", "HASAN KADİR", "ŞADİYE SELİN", "CEREN", "ELİFCAN", "SEVAL", "GÖKÇEN", "ÖMER FARUK", "ALİ HASAN", "MUSTAFA", "KÜBRA", "HACI HASAN", "GÖKHAN", "MERİÇ", "İREM", "MAHMUT SAMİ", "MURAT", "SÜLEYMAN SERDAR", "NİHAN", "HANİFE TUĞÇE", "ŞULE", "ERTAN", "MUHAMMED", "ÇAĞDAŞ", "ALİ", "YUSUF", "HATUN", "İBRAHİM", "MEHMET YAVUZ", "MEHMET", "ERTAN", "SÜMEYRA", "FATMA EFSUN", "RAMAZAN", "MEHMET ALİ", "BERKAN", "DAVUT", "YAVUZ SELİM", "İBRAHİM", "OKAN", "MEHMET", "MERT", "EMRAH", "BURAK", "ALAADDİN", "İDRİS BUGRA", "KÜBRA", "AYŞEGÜL", "MERVE NUR", "SUNA", "ELZEM", "ABDURRAHMAN", "BURAK", "MİHRİMAH SELCEN", "RABİA", "MERİÇ", "DERYA", "SERKAN", "CEYDA", "AYŞENUR", "MEHMET AKİF", "TUĞBA", "SERHAT", "BAYRAM", "MEHMED UĞUR", "DAMLA", "MUSTAFA", "VEYSEL", "AHMET SERKAN", "GÖKHAN", "ABDULSELAM", "MEHMET YILDIRIM", "HÜSEYİN", "BİLAL", "YAKUP", "GÜLLÜ SELCEN", "VEHBİ", "DİLAN", "ÖMER FARUK", "EMRE", "MEVLÜT", "NEBİL", "SIDIKA", "FATMA", "MARUF", "FIRAT", "EBRU", "MAHMUT", "PINAR", "ALİ", "OSMAN", "HİLAL", "NİLGÜN", "BARIŞ", "ERKAN", "CİHAN", "ÖMER", "BEGÜM", "SÜLEYMAN", "ÖMER", "ELİF", "MEHMET ZİYA", "HAKAN", "AHMET SERCAN", "BİŞAR", "MUSTAFA", "NUR", "SERKAN", "ELİF", "HALİL İBRAHİM", "EMİNE", "FATİH MEHMET", "EREN", "AYTAÇ", "ENGİN", "YURDAGÜL", "FULYA", "YASEMİN", "ETHEM", "YASİN", "METİN", "ELİF", "FERAT", "YUSUF", "CİHAN", "MUHAMMED", "GÜLŞEN", "ABDULMELİK", "MERVE", "ALİ", "YASEMİN", "MUHAMMET BAĞBUR", "YUSUF ZİYA", "ERDAL", "MURAT", "MERVE", "RAMAZAN", "GÜL", "BEGÜM", "ORHAN UYGAR", "HASAN", "SEMA", "GÜNEŞ", "BEYZA", "FIRAT", "YİĞİT", "MUHSİN", "HAMZA", "SABAHATTİN", "EMİN", "AHMET ÇAĞRI", "NAZLI", "MEHMET", "GÖKSEL", "BAŞAK", "HASAN YAVUZHAN", "GÖKHAN", "MUHAMMED SAMİ", "ENGİN", "EBRU", "METANET MEHRALİ", "EZGİ GİZEM", "NESLİHAN", "İLYAS", "SERKAN", "MEHMET SELAHATTİN", "MUSTAFA", "MEHMET", "CİHAN", "MURAT", "KASIM", "RAHİME MERVE", "OZAN", "ÖZKAN", "ZAFER", "SENAN", "BEDREDDİN", "MURAT", "ZEYNALABİDİN", "CAHİT", "DENİZ", "MEHMET EMRAH", "ESRA", "TUNCAY", "HÜSEYİN", "YİĞİT", "BÜNYAMİN", "PERVER", "ERDEM", "ÖMER", "SERHAT", "EMRE MERTER", "ABDÜLKADİR", "ENGİN", "NURULLAH", "ABDULLAH", "MEHMET", "HASAN", "AHMET MELİH", "ÖKKEŞ YILMAZ", "BURAK", "TOLGAHAN", "SÜLEYMAN", "SUAT", "ONUR", "MURAT VOLKAN", "OSMAN", "ALPER", "ERHAN", "AKIN", "ALİ", "ÖMER", "MUSTAFA", "FATMA DUYGU", "TÜRKER", "HASAN", "MUSTAFA TURAN", "ERGÜN", "ÖZLEM", "NİMET", "NİHAT", "SERHAT", "RAHMİ TUNA", "NEZİR", "YUSUF EMRE", "SERDAR", "RUKİYE", "HACI ÖMER", "ÇAĞLA", "ÜMİT", "MEHMET FATİH", "NAZIM", "HATİCE", "SİDAR", "MEHMET", "ALİ BURÇ", "YUNUS", "ÇAĞRI", "SİNAN DİNÇER", "AYSUN", "MUSTAFA", "İLKER", "PINAR", "MAHİR", "CEBRAİL", "RAMAZAN", "SELAHATTİN", "NEVİN", "MEHMET NEDİM", "YASİN", "BURHAN", "SEVCAN", "OSMAN SALİH", "MAHMUT EMRE", "TEYFİK", "SERTAÇ", "HALİM", "AYSU", "EMRE", "GİZEM", "ASUMAN", "GÖKÇE", "ZEHRA", "ORKUN", "SAVAŞ", "SELİM", "MURAT", "ERHAN", "FATİH", "ÖMER FARUK", "ZÜHRE", "AHMET", "ASENA", "EMRE", "İSMAİL", "MEHMET FURKAN", "HABİP", "İSMAİL", "ENDER", "HAKAN", "NURGÜL", "BURCU", "SELÇUK", "MAHMUT BURAK", "MURAT", "İLKER", "NİMET DİDEM", "NİHAL", "ŞÜKRİYE TUĞÇE", "REŞİT VOLKAN", "SELİM OZAN", "HASAN", "ZEYNEP", "SERKAN", "AHMAD TAHER", "HÜSEYİN", "ZAFER", "RAMAZAN", "SELKAN MURAD", "CANSEN", "KAMİL", "YÜCEL", "DERYA", "YASEMİN", "TOLGA", "ABDULKADİR", "ALİ", "ÖZEN", "FATMA", "MUSTAFA", "HAMZA", "MURAT", "CÖMERT", "BÜNYAMİN", "HÜLYA GÖZDE", "BERK", "AHMET FURKAN", "YUSUF", "EMRAH", "EMRE", "ABDULSEMET", "EYLEM", "İSMAİL", "ÇAĞLAR", "YASEMİN", "MELTEM", "TOLGA CAN", "EMRE", "MUSTAFA", "EMİR MURAT", "FUNDA", "ELİF NUR", "NİLAY", "AHMET ÇAĞRI", "MERVE SETENAY", "SAMET", "ERDEM CAN", "SERKAN", "ÖZNUR", "ÖZNUR", "İSMAİL", "RAMAZAN", "FATİH", "ŞUAYIP", "ALİ", "SULTAN", "EMRAH", "GÜLBERAT", "UFUK", "ZEYNEP", "MUSA", "NURAN", "GÜLAY", "SERDAR", "CANAN", "AHMET", "HÜSEYİN", "ALPER", "CÜNEYT", "İLYAS", "HALİLİBRAHİM", "CANSU", "EMEL", "SEVAL", "EBRU", "MUSTAFA KEMAL", "MEHMET", "AYSU", "DUYGU", "ASLI", "NİHAL", "LEYLA", "BURÇİN MERYEM", "MAHMUT ARDA", "SERPİL", "AHMET KÜRŞAD", "EZGİ", "İPEK", "HAVVA", "ŞAHİN", "DENİZ ARMAĞAN", "GAMZE", "YAŞAR", "İLKAY", "SAADET NİLAY", "HÜSEYİN KALKAN", "TAMER", "HİDİR", "ADEM", "AHMET", "DERYA", "FATİH", "YAVUZ SELİM", "BEYZA", "ÜMİT", "AHMET", "FETHİ", "HİDAYET", "MEVLÜT", "YAVUZ SELİM", "MEHMET FATİH", "FETHİYE", "MERVE", "MEHMET KORAY", "EMİNE", "MELİKE", "MEHTAP", "SEVDA", "EMİN", "EMİR KAAN", "MEHMET HİLMİ", "HAVVA", "LÜTFİ", "EMİNE", "ELÇİN", "MUSTAFA", "GÖZDE GİZEM", "TEVHİD", "AYŞE GÜL", "FATMA", "TİMUÇİN", "BİROL", "MUAMMER", "DİLŞAH", "YAŞAR BARBAROS", "ELİF NİHAL", "YASEMİN", "ŞAHİN", "ALİ", "EMRAH", "AYŞE", "YAKUP ONUR", "ÇAĞRI", "BAHADIR", "KURTULUŞ", "KADİR", "MUSTAFA", "YALÇIN", "CEREN BUĞLEM", "ESRA", "ÜMİT", "ŞERİFE", "ŞEYDA", "ASLI", "NESLİHAN", "ESRA", "ÇAĞRI SERDAR", "MEHMET ALİ", "KAMURAN", "DERYA PINAR", "MERYEM", "ŞİRİN", "HARUN", "HARUN", "PINAR", "BARIŞ", "FATİH AVNİ", "İBRAHİM", "DAMLA", "MERVE", "ÖKKEŞ CELİL", "AYŞE", "RECEP", "EMRE", "HALİL", "MURAT", "SERKAN", "ALEV", "MÜŞERREF", "FATİH", "AHMET", "ADNAN", "HİSAR CAN", "ONUR", "ALP", "MUSTAFA", "ÇİĞDEM", "SERKAN", "ELİF", "HASAN", "AHMET", "BAKİ", "SEDA", "HANDAN", "AYLİN SEVİL", "NECMİYE GÜL", "ÖZLEM", "VOLKAN", "SERDAR", "EBRU", "ERTUNÇ ONUR", "EMRE", "PINAR", "MUHAMMED", "SONGÜL", "SÜMEYYE", "MEVSİM", "TUĞBERK", "UĞUR", "AHMET BURAK", "EMRE", "YİĞİT CAN", "FATİH MEHMET", "METE CAN", "ESRA", "FERHAT", "YELİZ", "SEVGÜL", "CÜNEYT", "SEYFULLAH", "HALİL CANSUN", "FATMA ESRA", "SERDAR", "YUNUS EMRE", "SEZAİ", "TAHİR", "VEYSİ", "YILDIRAY", "ELİF", "SERHAT", "ÖMER", "ÖZGE", "GÜLSÜM", "DENİZ", "SELİN", "GÜL", "BİLGE", "ŞEHMUS", "DİDEM", "MERVE", "EYYÜP", "NAZLI HİLAL", "HATİCE ÖZGE", "ABDULLAH", "MURAT", "HAYATİ CAN", "MERVE", "FERAY", "HASAN", "GAMZE", "HASAN", "RAMAZAN FERHAD", "BETÜL", "NESLİHAN", "MUSTAFA", "AYTAÇ", "SENA", "ZÜHTÜ BENER", "EMRE", "OSMAN", "BULUT", "ERSİN", "HALİL İBRAHİM", "AHMET", "SELÇUK", "NURMUHAMMET", "YASİN", "ÖZGE", "ZEKİYE SEVAL", "ERDEM", "DİLEK", "ŞULE", "GÖKNUR", "SALİHA", "VELİT", "MUHAMMED NURİ", "İBRAHİM", "TURGAY", "ENGİN", "HÜSEYİN", "MESUT", "LEYLA", "TUBA", "MEHMET ALİ", "SALMAN", "ŞEYHMUS", "ZEHRA", "NURDAN", "CEBBAR", "ÖMER", "AHMET", "SİNAN", "ALPEREN", "MEHMET SELAMİ", "ABDULAZİZ", "LEYLA", "FATMA", "MÜNEVER", "MÜRSELİN", "EMRULLAH", "EDA", "ÜMİT", "BÜNYAMİN", "RIDVAN", "ADEM", "ORHAN", "EMİNE", "KEMAL", "FATMA", "ALİ", "MEHMET", "MUSTAFA", "NEVZAT", "OSMAN", "ONUR", "MUSTAFA ALİ", "MEHTAP", "MURAT", "MUSA", "FİLİZ", "HALENUR", "KEZİBAN", "EFRUZ", "EMİN", "FATİH", "ÜNAL", "VOLKAN", "BAYRAM", "BERAAT", "MEHMET", "MÜCAHİT", "SABRİ SEFA", "RAŞAN", "RABİA ŞEBNEM", "AHMET", "AHMET", "ZÜBEYDE", "BÜŞRA", "BURCU", "ALİ", "IŞIL", "GÖZDE", "ESMA", "KÜBRA", "YAŞAR GÖZDE", "YILMAZ", "ZEYNEP", "CANER", "VOLKAN", "EMRE KAĞAN" };
                #endregion
                progressBar1.Value = 100;
                string depotxt = txtPassword.Text;
                txtPassword.Text = txtPassword.Text.ToLower();

                #region Kontrol Bölgesi
                int i1 = 0, i2 = 0, i3 = 0, i4 = 0, i5 = 0, i6 = 0, i7 = 0, i8 = 0, i9 = 0;
                if (txtPassword.Text.Contains("123"))
                {
                    progressBar1.Value -=50;
                }
                foreach (var nk in numaraKombineleri)
                {
                    if (txtPassword.Text.Contains(nk.ToLower()))
                    {
                        i1++;
                        if (progressBar1.Value > 5)
                        {
                            progressBar1.Value -= 5;
                        }
                        else
                        {
                            progressBar1.Value = 0;
                        }
                    }
                }
                foreach (var nk in dogumTarihleri)
                {
                    if (txtPassword.Text.Contains(nk.ToLower()))
                    {
                        i2++;
                        if (progressBar1.Value > 5)
                        {
                            progressBar1.Value -= 5;
                        }
                        else
                        {
                            progressBar1.Value = 0;
                        }
                    }
                }
                foreach (var nk in takimlar)
                {
                    if (txtPassword.Text.Contains(nk.ToLower()))
                    {
                        i3++;
                        if (progressBar1.Value > 5)
                        {
                            progressBar1.Value -= 5;
                        }
                        else
                        {
                            progressBar1.Value = 0;
                        }
                    }
                }
                foreach (var nk in sehirler)
                {
                    if (txtPassword.Text.Contains(nk.ToLower()))
                    {
                        i4++;
                        if (progressBar1.Value > 5)
                        {
                            progressBar1.Value -= 5;
                        }
                        else
                        {
                            progressBar1.Value = 0;
                        }
                    }
                }
                foreach (var nk in plakalar)
                {
                    if (txtPassword.Text.Contains(nk.ToLower()))
                    {
                        i5++;
                        if (progressBar1.Value > 5)
                        {
                            progressBar1.Value -= 5;
                        }
                        else
                        {
                            progressBar1.Value = 0;
                        }
                    }
                }
                foreach (var nk in renkler)
                {
                    if (txtPassword.Text.Contains(nk.ToLower()))
                    {
                        i6++;
                        if (progressBar1.Value > 5)
                        {
                            progressBar1.Value -= 5;
                        }
                        else
                        {
                            progressBar1.Value = 0;
                        }
                    }
                }
                foreach (var nk in ulkeIsimleri)
                {
                    if (txtPassword.Text.Contains(nk.ToLower()))
                    {
                        i7++;
                        if (progressBar1.Value > 5)
                        {
                            progressBar1.Value -= 5;
                        }
                        else
                        {
                            progressBar1.Value = 0;
                        }
                    }
                }
                foreach (var nk in aylar)
                {
                    if (txtPassword.Text.Contains(nk.ToLower()))
                    {
                        i8++;
                        if (progressBar1.Value > 5)
                        {
                            progressBar1.Value -= 5;
                        }
                        else
                        {
                            progressBar1.Value = 0;
                        }
                    }
                }
                foreach (var nk in isimler)
                {
                    if (txtPassword.Text.Contains(nk.ToLower()))
                    {
                        i9++;
                        if (progressBar1.Value > 5)
                        {
                            progressBar1.Value -= 5;
                        }
                        else
                        {
                            progressBar1.Value = 0;
                        }
                    }
                }
                #endregion

                #region Olası Tehdiler
                string tehditler = "";
                if (i1 > 0)
                {
                    tehditler += "\n-Numara Kombinasyonu";
                }
                if (i2 > 0)
                {
                    tehditler += "\n-Doğum Tarihi";
                }
                if (i3 > 0)
                {
                    tehditler += "\n-Takım isimleri";
                }
                if (i4 > 0)
                {
                    tehditler += "\n-Şehir isimleri";
                }
                if (i5 > 0)
                {
                    tehditler += "\n-Şehir Plakaları";
                }
                if (i6 > 0)
                {
                    tehditler += "\n-Renk isimleri";
                }
                if (i7 > 0)
                {
                    tehditler += "\n-Ülke isimleri";
                }
                if (i8 > 0)
                {
                    tehditler += "\n-Yılın Ayları";
                }
                if (i9 > 0)
                {
                    tehditler += "\n-İsim/Ad kullanımı";
                }
                #endregion

                #region Öneri Yazısı
                if (progressBar1.Value >= 0 && progressBar1.Value < 25)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Girilen Şifreyi Parola olarak kullanmanız kesinlikle önerilmez";
                    kesinlikleonerilmez.Visible = true;
                }
                else if (progressBar1.Value >= 25 && progressBar1.Value < 50)
                {
                    lblStatus.ForeColor = Color.OrangeRed;
                    lblStatus.Text = "Girilen Şifreyi Parola olarak kullanmanız önerilmez";
                    onerilmez.Visible = true;
                }
                else if (progressBar1.Value >= 50 && progressBar1.Value < 75)
                {
                    lblStatus.ForeColor = Color.Orange;
                    lblStatus.Text = "Girilen Şifreyi Parolanız olarak kullanmanız riskli olabilir";
                    riskli.Visible = true;
                }
                else if (progressBar1.Value >= 75 && progressBar1.Value < 100)
                {
                    lblStatus.ForeColor = Color.LightGreen;
                    lblStatus.Text = "Girilen Şifreyi isterseniz Parola olarak kullanabilirsiniz";
                    istersen.Visible = true;
                }
                else if (progressBar1.Value == 100)
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Girilen Şifreyi Parola olarak kullanabilirsiniz.";
                    guvenli.Visible = true;
                }
                #endregion

                lblRiskStatus.ForeColor = Color.Red;
                lblRiskStatus.Text = tehditler;
                txtPassword.Text = depotxt;
            }
            else
            {
                MessageBox.Show("Şifre en az 6 haneli olmalıdır");
                pictureLogo.Visible = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCheckPw_Click(sender, e);
            }
        }

        private void btnPwEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar -= '*';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private string sifreOlustur(int karakterSayisi)
        {
            char[] sifre = new char[karakterSayisi];
            string kucukHarfler = "abcçdefgğhıijklmnoöprsştvyz";
            string buyukHarfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
            string sayilar = "1234567890";
            string karakterler = "@*?.!-){_#$(";

            Random rnd = new Random();
            int x = 0;
            while (x <= 300 || sifre.Length < karakterSayisi)
            {
                sifre[rnd.Next(0, karakterSayisi)] = kucukHarfler[rnd.Next(0, kucukHarfler.Length)];
                sifre[rnd.Next(0, karakterSayisi)] = sayilar[rnd.Next(0, sayilar.Length)];
                sifre[rnd.Next(0, karakterSayisi)] = buyukHarfler[rnd.Next(0, buyukHarfler.Length)];
                sifre[rnd.Next(0, karakterSayisi)] = sayilar[rnd.Next(0, sayilar.Length)];
                sifre[rnd.Next(0, karakterSayisi)] = karakterler[rnd.Next(0, karakterler.Length)];
                sifre[rnd.Next(0, karakterSayisi)] = kucukHarfler[rnd.Next(0, kucukHarfler.Length)];
                sifre[rnd.Next(0, karakterSayisi)] = buyukHarfler[rnd.Next(0, buyukHarfler.Length)];
                sifre[rnd.Next(0, karakterSayisi)] = karakterler[rnd.Next(0, karakterler.Length)];
                x++;
            }
            string resultSifre = "";
            for (int i = 0; i < karakterSayisi; i++)
            {
                resultSifre += sifre[i];
            }
            return resultSifre;
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (cbKarakterSayisi.SelectedIndex != -1)
            {
                if (Convert.ToInt32(cbKarakterSayisi.SelectedItem.ToString()) >= 6 && Convert.ToInt32(cbKarakterSayisi.SelectedItem.ToString()) <= 15)
                {
                    int karakterSayisi = Convert.ToInt32(cbKarakterSayisi.SelectedItem.ToString());
                    txtYeniSifre.Text = sifreOlustur(karakterSayisi);
                }
                else
                {
                    cbKarakterSayisi.ForeColor = Color.Red;
                    System.Threading.Thread.Sleep(1000);
                    cbKarakterSayisi.ForeColor = Color.Transparent;
                }
            }
            else
            {
                MessageBox.Show("Karakter Sayısını Kontrol Edin!");
            }

        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text.Length >= 0)
            {
                Clipboard.SetText(txtYeniSifre.Text);
            }
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
    }
}
