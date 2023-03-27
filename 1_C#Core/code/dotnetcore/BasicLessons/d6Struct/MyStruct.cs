namespace BasicLessons.d6Struct
{
    internal struct MyStruct:IProcess
    {
        private int v;

        public MyStruct(int v)
        {
            this.v = v;
        }

        public void Process()
        {
            throw new System.NotImplementedException();
        }
    }
}