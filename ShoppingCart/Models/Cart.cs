namespace ShoppingCart.Models
{
    public class Cart
    {
        private List<CartItem> _items;

        public Cart()
        {
            _items = new List<CartItem>();
        }

        public void AddItem(Item item)
        {
            var match = _items.FirstOrDefault(x => x.Code.ToLowerInvariant() == item.Code.ToLowerInvariant());
            if (match == null)
            { 
                _items.Add(new CartItem() { Code=item.Code, Description=item.Description, Price=item.Price, Quantity=1});
            }
            else
            {
                match.Quantity++;
            }
        }

        public double CalculateTotalPrice()
        {
            return _items.Sum(itm => itm.Price * itm.Quantity);
        }
    }
}
