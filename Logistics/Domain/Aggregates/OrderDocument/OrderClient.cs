namespace Logistics.Domain.Aggregates.OrderDocument
{
    public class OrderClient 
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }

        public void Notify() { }
    }
}
