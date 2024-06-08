namespace PylayCola.cola
{
    class Cola
    {
        //First In, First Out
        Queue<string> queue = new Queue<string>(); //Cola
        string? provicional;
        //bool Verified;

        private static Cola? _instancia;

        private Cola()
        {}

        public static Cola getInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Cola();
            }
            return _instancia;
        }
        public string[] Get()
        {
            if (!IsEmpty())
            {
                return queue.ToArray();
            }
            return [];
        }
        public void Enqueue(string Nombre)
        {
            queue.Enqueue(Nombre);
        }
        public string Peek()
        {
            if (!IsEmpty())
            {
                provicional = queue.Peek();
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
                return Convert.ToString(queue.Count());
            }
            else
            {
                provicional = "0";
            }
            return provicional;

        }
        public string Dequeue()
        {


            if (!IsEmpty())
            {
                provicional = queue.Dequeue();
            }
            else
            {
                provicional = "Lista vacia";
            }
            return provicional;

        }
        public bool IsEmpty()
        {
            if (queue.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
