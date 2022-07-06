using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class MyDictonary<T1,T2>
    {
        T1[] key;
        T2[] value;
        public MyDictonary()
        {
            key = new T1[0];
            value = new T2[0];
        }
        public void Add(T1 newKey,T2 newValue)
        {
            T1[] tempKey = key;
            T2[] tempValue = value;

            key = new T1[key.Length+1];
            value = new T2[value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
            }
            key[key.Length - 1] = newKey;
            value[value.Length - 1] = newValue;
        }


        public int Count
        {
            get { return key.Length; }
        }


        //tamamen kontrol amaçlı yazılmıştır içerdeki bilgilerin kayıt edilip edilmedini öğrenmek için
        public void Show(MyDictonary<T1,T2> myDictonary)
        {
            for (int i = 0; i < myDictonary.Count; i++)
            {
                Console.WriteLine("key : " + myDictonary.key[i]+ "value : " + myDictonary.value[i]);
            }
            
        }





    }
}
