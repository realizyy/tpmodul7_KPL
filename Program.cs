// See https://aka.ms/new-console-template for more information

using tpmodul7_1302204035;

Console.WriteLine("Hello, World!");
CovidConfig cfg = new CovidConfig();
Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + cfg.getCONFIG1() + " : ");
double suhu = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam ? : ");
int hari = Convert.ToInt32(Console.ReadLine());
//calculatedata
    Boolean hasilSuhu = false;
    Boolean hasilHari = false;
    if (cfg.getSatuanSuhu() == "celcius") {
        if (suhu >= 35.6 && suhu <= 37.5) {
            hasilSuhu = true;
        }
    }
    else if (cfg.getSatuanSuhu() == "fahrenheit") {
        if (suhu >= 97.7 && suhu <= 99.5) {
            hasilSuhu = true;
        }
    }

    if (hari < cfg.getBatasHariDeman()) { 
        hasilHari = true; 
    }

    if(hasilHari && hasilSuhu) {
        Console.WriteLine(cfg.PesanPositif());
    }
    else
    {
        Console.WriteLine(cfg.PesanNegatif());
    }
//merubah satuan suhu
    Console.WriteLine("Ubah satuan : ");
    cfg.setSatuanSuhu(Console.ReadLine());
