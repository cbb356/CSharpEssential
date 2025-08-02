namespace MyClass
{
    internal class ParameterlessClass
    {
        public string Name { get; set; } = "Default ParameterlessClass";

        public ParameterlessClass()
        {
            
        }

        public override string ToString()
        {
            return Name;
        }
    }

    internal class ParameterizedConstructorClass
    {
       public ParameterizedConstructorClass (string parameter)
       { 
            
       }
    }

    internal abstract class AbstractClass
    {

    }
}
