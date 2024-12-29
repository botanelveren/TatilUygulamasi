using System;

namespace TatilUygulamasi
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Nereye tatile gitmek istersiniz? (Bodrum, Marmaris, Çeşme)");
                string location = Console.ReadLine().ToLower();

                if (location == "bodrum" || location == "marmaris" || location == "çeşme")
                {
                    Console.WriteLine("Tatile gidecek kişi sayısı nedir?");
                    int bodyCount = Convert.ToInt32(Console.ReadLine());

                    int price = 0;
                    switch (location)
                    {
                        case "bodrum":
                            price = 4000;
                            Console.WriteLine("Bodrum'da muhteşem bir deniz, güneş ve eğlence sizleri bekliyor!");
                            break;
                        case "marmaris":
                            price = 3000;
                            Console.WriteLine("Marmaris'te tarihi ve doğal güzellikleri keşfedin!");
                            break;
                        case "çeşme":
                            price = 5000;
                            Console.WriteLine("Çeşme'de rüzgar sörfü ve kite-surfing yapabilirsiniz!");
                            break;
                    }
                    Console.WriteLine("\nTatile ne şekilde gitmek istersiniz?\n\n1-Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)\n2-Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
                    Console.WriteLine("Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz. (1 veya 2)");
                    int travelChoice = Convert.ToInt32(Console.ReadLine());
                    int travelPrice = 0;
                    switch (travelChoice)
                    {
                        case 1:
                            travelPrice = 1500;
                            break;

                        case 2:
                            travelPrice = 4000;
                            break;

                        default:
                            Console.WriteLine("Yanlış bir seçim yaptınız lütfen 1 veya 2'yi seçin");
                            break;
                    }
                    int sum = (price + travelPrice) * bodyCount;
                    Console.WriteLine($"Toplam tatil maliyeti: {sum} TL");

                    Console.WriteLine("Başka bir tatil planı oluşturmak ister misiniz? (Evet/Hayır)");
                    string planB = Console.ReadLine().ToLower();
                    if (planB != "evet")
                        break;

                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir lokasyon seçiniz. Seçenekler:\nBodrum\nMarmaris\nÇeşme");
                }

            }

        }
    }
}