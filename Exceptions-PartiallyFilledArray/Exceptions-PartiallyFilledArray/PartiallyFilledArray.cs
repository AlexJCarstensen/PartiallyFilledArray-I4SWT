namespace PartiallyFilledArray
{
    class PartiallyFilledArray : IPartiallyFilledArray
    {
        public uint Size { get; }
        public uint Used { get; }
        public void Set(uint pos, int data)
        {
            throw new System.NotImplementedException();
        }

        public int Get(uint pos)
        {
            throw new System.NotImplementedException();
        }

        public uint Put(int data)
        {
            throw new System.NotImplementedException();
        }

        public uint Find(int data)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(uint pos)
        {
            throw new System.NotImplementedException();
        }
    }
}