using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = null;

            byte b=5;    //1 byte yer kaplar. 0-255 arası değerleri alabilir
            sbyte c=5;  //1 byte yer kaplar. -128 - 127  arası değerleri alabilir
            
            short s =5;    //2 byte.
            ushort us =5;  //2 byte. pozitif sayılar 

            Int16 i16=2;        //2 byte
            int i=5;              //4 byte
            Int32 i32= 2;    //4 byte
            Int64 i64 = 2;  //8 byte

            uint ui=2;    //4 byte
            long l=2 ;   //8 byte
            ulong ul=3; //8 byte

            float f = 1 ;    //4 byte
            double d=2;  //8 byte
            decimal de = 2; //16 byte

            char ch= '2';  //2 byte
            string st="Okan"; //sınırsız

            bool b1 = true; //true&false 

            DateTime dt= DateTime.Now;
            Console.WriteLine(dt);

            object o1= "x";
            object o2 = 'y';
            object o3= 8;
            object o4= 5.4;

            //string ifadeler 

            string str1=null;
            string str2 = string.Empty;
            str1= "Okan Şahin";

            // integer ifadler

            int integer1=5;
             int integer2=6;
              int integer3=integer1*integer2;

            //boolean

            bool bl1= 10<2;
            bool bl2 = 10>2;

            // Değiken dönüşümleri

            string str20 = "20";
            int int20 =20;
            string yeniString= str20 + int20.ToString();
             Console.WriteLine(yeniString);


             int int30 = int20 + Convert.ToInt32(str20);
             Console.WriteLine(int30);
            

            int int22 = int20+ int.Parse(str20);



        }
    }
}
