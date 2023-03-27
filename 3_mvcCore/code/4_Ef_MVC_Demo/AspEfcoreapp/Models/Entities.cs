namespace Festivals.Library
{
     public class Festival
    {
        public int FestivalId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Location { get; set; }
        public int NoOfDays { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        /**
        * Many to Many Relationship
        * For every Festival there can be many Fooditems
        * And also the same FoodItem can be made for many other Festivals also
        * So in the festival class add list of "FoodDish" as navigation property
        */
        public List<FoodDish> Sweets { get; } = new List<FoodDish>();
       /**
        * Many to 1 Relationship
        * For every Festival there is only one Religion
        * But for every Religion there are many Festivals
        * So in the festival class add "ReligionId" as foreign Key
        * and an instance of "Religion" as navigation property
        */
        // Navigation Property
        public Religion Religion { get; set; }
        // Foreign Key
        public int ReligionId { get; set; }

    }
    public class FoodDish
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int CookingTime { get; set; }
        public String CookingMethod { get; set; }
        public String DishType { get; set; }
        public List<Festival> Festivals { get; } = new List<Festival>();
        //public Recipe Recipe { get; set; }
    }
    public class FestivalDishDetails
    {
        public int FestivalId { get; set; }
        public int DishId { get; set; }
    }
    public class Religion
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        /**
         * 1 to Many Relationship
         * For every Religion there are many Festivals
         * But for every Festival there is only one Religion
         * So in the Religion class add a list of "Festival" as navigation property
         */
        public List<Festival> Festivals { get; } = new List<Festival>();
    }
    //public class Recipe
    //{
    //    public int RecipeId { get; set; }
    //    public int FoodId { get; set; }
    //    public String Description { get; set; }
    //    public FoodDish FoodItem { get; set; }
    //}
}
