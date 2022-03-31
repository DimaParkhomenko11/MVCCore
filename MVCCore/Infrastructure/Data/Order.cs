namespace MVCCore.Infrastructure.Data
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}