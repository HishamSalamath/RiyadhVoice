using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Model
{
    public class AvailedEvents
    {
        private readonly AppDBContext _appDbContext;

        public string AvailedEventID { get; set; }

        public List<AvailedEventItems> AvailedEventItems { get; set; }

        private AvailedEvents(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static AvailedEvents GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDBContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new AvailedEvents(context) { AvailedEventID = cartId };
        }

        public void AddToCart(Events events, int amount)
        {
            var shoppingCartItem =
                    _appDbContext.AvailedEvents.SingleOrDefault(
                        s => s.Events.Eventid == events.Eventid && s.EventAvailedID == AvailedEventID);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new AvailedEventItems
                {
                    EventAvailedID = AvailedEventID,
                    Events = events,
                    Amount = 1
                };

                _appDbContext.AvailedEvents.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Events events)
        {
            var shoppingCartItem =
                    _appDbContext.AvailedEvents.SingleOrDefault(
                        s => s.Events.Eventid == events.Eventid && s.EventAvailedID == AvailedEventID);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.AvailedEvents.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<AvailedEventItems> GetShoppingCartItems()
        {
            return AvailedEventItems ??
                   (AvailedEventItems =
                       _appDbContext.AvailedEvents.Where(c => c.EventAvailedID == AvailedEventID)
                           .Include(s => s.Events)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext
                .AvailedEvents
                .Where(cart => cart.EventAvailedID == AvailedEventID);

            _appDbContext.AvailedEvents.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        //public decimal GetShoppingCartTotal()
        //{
        //    var total = _appDbContext.AvailedEvents.Where(c => c.EventAvailedID == AvailedEventID)
        //        .Select(c => c.Events.Price * c.Amount).Sum();
        //    return total;
        //}
    }
}
