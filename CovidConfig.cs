using Newtonsoft.Json;

namespace tpmodul7_1302204035;

public class CovidConfig
{
    private String CONFIG1;
    private int CONFIG2;
    private String CONFIG3;
    private String CONFIG4;
    public CovidConfig()
    {
        //get path
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        //get file
        string file = File.ReadAllText(path+"\\CovidConfig.json");
        //convert json
        dynamic data = JsonConvert.DeserializeObject(file);
        //set config value from json
        CONFIG1 = data.satuan_suhu;
        CONFIG2 = data.batas_hari_deman;
        CONFIG3 = data.pesan_ditolak;
        CONFIG4 = data.pesan_diterima;
    }
    
    //getter
    public String getCONFIG1()
    {
        return CONFIG1;
    }

    public String getSatuanSuhu()
    {
        return CONFIG1;
    }
    
    public int getBatasHariDeman()
    {
        return CONFIG2;
    }
    
    public String PesanPositif()
    {
        return CONFIG3;
    }

    public String PesanNegatif()
    {
        return CONFIG4;
    }
    
    public void setSatuanSuhu(String suhu)
    {
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        string file = File.ReadAllText(path+"\\CovidConfig.json");
        dynamic data = JsonConvert.DeserializeObject(file);
        data.satuan_suhu = suhu;
        string output = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(path+"\\CovidConfig.json", output);
    }

}