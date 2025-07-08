namespace MyClass_MyStruct
{
    /*
     * Створіть клас MyClass і структуру MyStruct, які містять поля public string change. 
     * У класі Program створіть два методи: static void ClassTaker(MyClass myClass), 
     * який надає полю change екземпляра myClass значення «змінено». 
     * static void StructTaker(MyStruct myStruct), який надає полю change екземпляра 
     * myStruct значення «змінено». Продемонструйте різницю у використанні класів та структур, 
     * створивши у методі Main() екземпляри структури та класу. Змініть значення полів екземплярів 
     * на «не змінено», а потім викличте методи ClassTaker і StructTaker. 
     * Виведіть на екран значення полів екземплярів. Проаналізуйте отримані результати.      
    */

    internal class Program
    {
        internal static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }

        internal static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(); //Class created with constructor call
            MyStruct myStruct; //Struct created without constructor call
            myClass.change = "not changed"; 
            myStruct.change = "not changed";
            ClassTaker(myClass);    //The field changed in the class
            StructTaker(myStruct);  //The field changed only in the struct copy inside StructTaker()
            Console.WriteLine($"The value of the change field for MyClass: {myClass.change}");
            Console.WriteLine($"The value of the change field for MyStruct: {myStruct.change}");
            
            // Delay.
            Console.ReadKey();
        }
    }
}
