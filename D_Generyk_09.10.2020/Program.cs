using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using DocumentFormat.OpenXml.Office2013.Theme;
using System;
using System.Collections;
using System.Collections.Generic;

//Тема: Коллекции

//Задание 1.
//Написать собственный класс generic типа содержащий массив объектов.
//В классе реализовать итератор для работы с циклом foreach.
//Подсказка! Для вывода объектов в цикле, в тестовом классе необходимо переопределить некий метод


public class MyClass<T>
{
   public  MyClass< T> []arr;
    int size;
   public  T value;


   

    public MyClass<T> this[int index]
    {
        get => arr[index];
        set { arr[index] = value; }
    }


    public MyClass()
    {
        size = 0;
       
    }

    public override string ToString()
    {
        return value.ToString();
    }

    public void addToArray(MyClass <T> obj)
    {
        size++;
        Array.Resize(ref arr, size);
        int i = size - 1;
        arr[i] = obj;

       
      
    }
   



}

class myVar<T>
{
    T var;

   

    public T SetGetmyVar
    {
        get { return var; }
        set { var = value; }
    }




}
namespace D_Generyk_09._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass<int> test = new MyClass<int>();
            test.addToArray(test);
            test.value = 15;
            MyClass<int> test2 = new MyClass<int>();
            test2.value = 999;
            test.addToArray(test2);

            foreach (var item in test.arr)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
