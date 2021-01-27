Sistem kullanarak;
Sistem kullanarak.Koleksiyonlar.Genel ;
Sistem kullanarak.Metin ;

ad alanı  Jenerik Giriş
{
    sınıf  MyList < T >
    {
        T [] öğe;
// yapıcı
genel MyList()
{
    öğeler = yeni  T[0];
}
public void Ekle(T öğesi)
{
    T[] tempArray = öğeler;
    öğeler = yeni  T[öğeler.Uzunluk + 1];
    for (int i = 0; i < tempArray.Length; i++)
    {
        öğeler[i] = tempArray[i];
    }

    öğeler[öğeler.Uzunluk - 1] = öğe;

}

public int Uzunluk
{
    olsun { return öğeleri.Uzunluk; }
}

genel T[] Öğeler
        {
            olsun { return  öğeleri ; }
        }


    }
}