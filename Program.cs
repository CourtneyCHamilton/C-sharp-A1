namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet= new Pet();
            pet.Start();

            Console.WriteLine();

            Album album= new Album();
            album.Start();

            Console.WriteLine();

            TicketSeller ticketSeller = new TicketSeller();
            ticketSeller.Start();
        }
    }
}