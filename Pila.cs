namespace PylayCola.pila
{
    class Pila
    {
        Stack<string> stack = new Stack<string>(); //Pila
        string? provicional;

        //Last In, First Out

        private  static Pila? _instancia;

        private Pila()
        { }

        public static Pila getInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Pila();
            }
            else { return _instancia; }
            return _instancia;
        }
        public string[] Get()
        {
            if (!IsEmpty())
            {
                return stack.ToArray();
            }
            return [];
        }
        public void Push(string Nombre)
        {
            stack.Push(Nombre);
        }
        public string Peek()
        {
            if (!IsEmpty())
            {
                provicional = stack.Peek();
            }
            else
            {
                provicional = "Lista vacia";
            }
            return provicional;

        }
        public string Count()
        {
            if (!IsEmpty())
            {
                return Convert.ToString(stack.Count());
            }
            else
            {
                provicional = "0";
            }
            return provicional;

        }
        public string Pop()
        {
            if (!IsEmpty())
            {
                provicional = stack.Pop();
            }
            else
            {
                provicional = "Lista vacia";
            }
            return provicional;

        }
        public bool IsEmpty()
        {
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }

}
