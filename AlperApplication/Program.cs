
string[] musteriler = {"alper","hasan","serkan"};
DateTime[] girisSaatleri = new DateTime[3];
bool[] icerdeMi = new bool[3];
string isim;
int index = 0;
bool kontrol = false;
while (true)
{
    Console.WriteLine("isim giriniz");
    isim = Console.ReadLine();
    for (int i = 0; i < musteriler.Length; i++)
    {
        kontrol = false;
        if (isim == musteriler[i])
        {
            Console.WriteLine("devam ediniz");
            kontrol = true;
            index = i;
            break;
        }
    }
    
    if (kontrol == false)
    {
        Console.WriteLine("Yanlış İsim Girildi. Terkar deneyiniz.");
        continue;
    }
    Console.WriteLine("Seçim Yapınız:");
    Console.WriteLine("1)Giriş Yap");
    Console.WriteLine("2)Çıkış Yap");
    string secim = Console.ReadLine();
    if (secim == "1")
    {
        
        DateTime suan = DateTime.Now;
        DateTime kullaniciGirisSaati = girisSaatleri[index];
        int aradakiFark = Convert.ToInt32((suan - kullaniciGirisSaati).TotalHours);
        if (aradakiFark < 24)
        {
            Console.WriteLine("Günde 1 kere girebilirsiniz");
            continue;
        }
        else
        {
            Console.WriteLine("Giriş Başarılı");
            girisSaatleri[index] = DateTime.Now;
            icerdeMi[index] = true;
        }
    }
    else if (secim == "2")
    {
        if (icerdeMi[index] == true)
        {
            icerdeMi[index] = false;
            Console.WriteLine("Çıkış Yapıldı");
            continue;
        }
        else
        {
            Console.WriteLine("giriş yapmadan çıkış yapamazsınız");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Düzgün giriş yapınız");
        continue;
    }
}