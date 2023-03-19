// See https://aka.ms/new-console-template for more information



namespace generic_method
{
    class HaloGeneric
    {
        public void SapaUSer()
        {
            String x = Console.ReadLine();
            Console.WriteLine("Halo User " + x);
        }
    }

   class main
    {
        static void Main(String[] args)
        {
            String x;
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUSer();
        }
    }
}
