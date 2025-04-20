using System;
using System.IO;
using System.Text.Json;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batasan_hari_demam { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    public static string filePath = "covid_config.json";
    internal int batas_hari_deman;

    public CovidConfig()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            var config = JsonSerializer.Deserialize<CovidConfig>(json);
            satuan_suhu = config.satuan_suhu;
            batasan_hari_demam = config.batasan_hari_demam;
            pesan_ditolak = config.pesan_ditolak;
            pesan_diterima = config.pesan_diterima;
        }
        else
        {
            satuan_suhu = "celcius";
            batasan_hari_demam = 14;
            pesan_ditolak = "Anda tidak di perbolehkan masuk ke dalam gedung ini";
            pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

            SaveConfig();

        }
    }

    public void UbahSatuan()
    {
        if (satuan_suhu.ToLower() == "celcius")
        {
            satuan_suhu = "fahrenheit";
        }
        else
        {
            satuan_suhu = "celcius";
        }
        SaveConfig();
    }
    public void SaveConfig()
    {
        var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }
}