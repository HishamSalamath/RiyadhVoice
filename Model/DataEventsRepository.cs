using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiyadhVoice.Model
{
    public class DataEventsRepository : IEventsRepository
    {
        private readonly ICategoryRepository _categoryRepository = new DataCategoryRepository();

        public IEnumerable<Events> AllEvents =>
            new List<Events>
            {
                new Events {Eventid = 1 , Name = "Wedding" , ShortDescription = " Life Changing moment for every Individual" ,LongDescription = "you somehow miss out on all the fun moments and celebration factor of your nuptial ceremonies as hosting a wedding is a tough task to do. If you are looking to embark your ceremonies wih glory , we can do this magic by our music" , ImageURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/Wedding-min.jpg" , Category = _categoryRepository.AllCategories.ToList()[0] , IsEventOfTheWeek = true , ImageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg" },
                new Events {Eventid = 2 , Name = "Restaurants/Coffee shops" , ShortDescription = " Let your customers sip your coffee surrounded by music in air" ,LongDescription = "Coffee shops and Restaurants are meant generally for relxation , spending time with your loved ones! We make the feel even better by our gentle music", ImageURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/coffee-shop-min.jpg" , Category = _categoryRepository.AllCategories.ToList()[0], IsEventOfTheWeek = false , ImageThumbnailURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/coffee-shop-min.jpg"},
                new Events {Eventid = 3 , Name = "Theaters" , ShortDescription = "Our Professional music band will make sure no corners of your theatre is left empty" ,LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you the best",ImageURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/theatre-min.jpg" ,Category = _categoryRepository.AllCategories.ToList()[0],IsEventOfTheWeek = false , ImageThumbnailURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/theatre-min.jpg" },
                new Events {Eventid = 4 , Name = "Concerts" , ShortDescription = "Our Professional music band will make sure audience get pumped up and chant loud enough to be heard miles apart" ,LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you the best" ,ImageURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/Concerts-min.jpg",Category = _categoryRepository.AllCategories.ToList()[0] , IsEventOfTheWeek = false ,ImageThumbnailURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/Concerts-min.jpg" },
                new Events {Eventid = 5 , Name = "Sports Events" , ShortDescription = "Let the Sport begin with a bang" ,LongDescription = "We have bunch of talented musicians outcasting mind blowing skills in their field of expertise. let us know the type of music you prefer , we will provide you wih the best",ImageURL="http://www.riyadhvoice.sa/wp-content/uploads/2021/05/sports-event-min.jpg" ,Category = _categoryRepository.AllCategories.ToList()[0], IsEventOfTheWeek = false , ImageThumbnailURL = "http://www.riyadhvoice.sa/wp-content/uploads/2021/05/sports-event-min.jpg"}

            };
        public IEnumerable<Events> EventOfTheWeek { get; }

        public Events GetEventByID (int eventid)
        {
            return AllEvents.FirstOrDefault(p => p.Eventid == eventid);

        }



    }
}
