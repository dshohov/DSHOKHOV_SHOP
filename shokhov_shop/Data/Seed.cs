using shokhov_shop.Models;

namespace shokhov_shop.Data
{
    public class Seed
    {
 
 
            public static void SeedData(IApplicationBuilder applicationBuilder)
            {
                using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                    context.Database.EnsureCreated();

                    if (!context.Categories.Any())
                    {
                        context.Categories.AddRange(new List<Category>()
                    {
                        //Woman Category
                        new Category()
                        {
                            Name = "Sales_for_woman",
                            Name_For_User = "Осінній роспродаж",
                            Description = "Ексклюзивна коллекція яскравих товарів та ще , зі знижками",
                            People = Enum.People.Women,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "New_for_woman",
                            Name_For_User = "Нове",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Gift_for_woman",
                            Name_For_User = "Подарунки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Party_for_woman",
                            Name_For_User = "Свята та вечірки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Classic_for_woman",
                            Name_For_User = "Классика",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Coat_for_woman",
                            Name_For_User = "Пальто",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Bags_for_woman",
                            Name_For_User = "Сумки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Dress_for_woman",
                            Name_For_User = "Сукні та комбенізони",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Jeans_for_woman",
                            Name_For_User = "Джинси",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        //Man Category
                        new Category()
                        {
                            Name = "Sales_for_man",
                            Name_For_User = "Осінній роспродаж",
                            Description = "Ексклюзивна коллекція яскравих товарів та ще , зі знижками",
                            People = Enum.People.Men,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "New_for_man",
                            Name_For_User = "Нове",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Gift_for_man",
                            Name_For_User = "Подарунки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Party_for_man",
                            Name_For_User = "Свята та вечірки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Classic_for_man",
                            Name_For_User = "Класичні костюми",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Coat_for_man",
                            Name_For_User = "Верхній одяг",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Bags_for_man",
                            Name_For_User = "Сумки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Trousers_for_man",
                            Name_For_User = "Штани",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Jeans_for_man",
                            Name_For_User = "Джинси",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        //Child Category
                        new Category()
                        {
                            Name = "Sales_for_child",
                            Name_For_User = "Осінній роспродаж",
                            Description = "Ексклюзивна коллекція яскравих товарів та ще , зі знижками",
                            People = Enum.People.Child,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "New_for_child",
                            Name_For_User = "Нове",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Gift_for_child",
                            Name_For_User = "Подарунки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Party_for_child",
                            Name_For_User = "Одяг для вечіок",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Classic_for_child",
                            Name_For_User = "Шкільна форма",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Coat_for_child",
                            Name_For_User = "Верхній одяг",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Bags_for_child",
                            Name_For_User = "Сумки та портфелі",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Trousers_for_child",
                            Name_For_User = "Штани",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                        new Category()
                        {
                            Name = "Jeans_for_child",
                            Name_For_User = "Джинси",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360"
                         },
                    });
                        context.SaveChanges();
                    }
                }
            }

        
    }
}
