// See https://aka.ms/new-console-template for more information



namespace generic_method
{
    class HaloGeneric
    {
        public void SapaUSer()
        {
            Console.WriteLine("Tuliskan nama");
            String x = Console.ReadLine();
            Console.WriteLine("Halo User " + x);
        }
    }

    class ClassGeneric<T>
    {
        private T data;

        public void DataGeneric<T>(T data)
        {
            data = data;
        }

        public void printData()
        {
            int z = 1302210110;
            Console.WriteLine("Data yang tersimpan adalah : " + z);
        }


    }

   class main
    {
        static void Main(String[] args)
        {
            String x;
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUSer();
            ClassGeneric<int> hai = new ClassGeneric<int>();
            hai.DataGeneric<int>(1302210110);
            hai.printData();


        }
    }
}
