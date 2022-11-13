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
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668356999/lm1pr2lsosib7e4f6rpl.png"
                         },
                        new Category()
                        {
                            Name = "New_for_woman",
                            Name_For_User = "Нове",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668358394/go2oad91mnupwmvql9dv.jpg"
                         },
                        new Category()
                        {
                            Name = "Gift_for_woman",
                            Name_For_User = "Подарунки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357392/jvj1hb49iikwgljuwwbm.jpg"
                         },
                        new Category()
                        {
                            Name = "Party_for_woman",
                            Name_For_User = "Свята та вечірки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357411/xklos76rkzg7a8yaso5t.jpg"
                         },
                        new Category()
                        {
                            Name = "Classic_for_woman",
                            Name_For_User = "Классика",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357447/x4mzsdezocomu1lbupob.jpg"
                         },
                        new Category()
                        {
                            Name = "Coat_for_woman",
                            Name_For_User = "Пальто",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357463/skto3qtd67a0afhn7eik.jpg"
                         },
                        new Category()
                        {
                            Name = "Bags_for_woman",
                            Name_For_User = "Сумки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357498/snfcixpd08lg4hamsxdk.jpg"
                         },
                        new Category()
                        {
                            Name = "Dress_for_woman",
                            Name_For_User = "Сукні та комбенізони",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357510/sxascimf22jzuzesj9ns.jpg"
                         },
                        new Category()
                        {
                            Name = "Jeans_for_woman",
                            Name_For_User = "Джинси",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357522/dt9joolcasognye0dmhn.jpg"
                         },
                        //Man Category
                        new Category()
                        {
                            Name = "Sales_for_man",
                            Name_For_User = "Осінній роспродаж",
                            Description = "Ексклюзивна коллекція яскравих товарів та ще , зі знижками",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668359425/fh0wrzahsdv0dvn9xefo.png"
                         },
                        new Category()
                        {
                            Name = "New_for_man",
                            Name_For_User = "Нове",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668361247/g8kzozjfwlk3m6cl7jrb.jpg"
                         },
                        new Category()
                        {
                            Name = "Gift_for_man",
                            Name_For_User = "Подарунки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668359760/ugai98f1piw8zbnpa9le.png"
                         },
                        new Category()
                        {
                            Name = "Party_for_man",
                            Name_For_User = "Свята та вечірки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668360681/s7hbo0vgnz10tnehotvw.png"
                         },
                        new Category()
                        {
                            Name = "Classic_for_man",
                            Name_For_User = "Класичні костюми",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668360693/xp7jiutqflhimsvugqgl.png"
                         },
                        new Category()
                        {
                            Name = "Coat_for_man",
                            Name_For_User = "Верхній одяг",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668360704/pjdil41pdfux1doars8b.png"
                         },
                        new Category()
                        {
                            Name = "Bags_for_man",
                            Name_For_User = "Сумки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668364153/ro5fqtwonzu8sivvo9v3.jpg"
                         },
                        new Category()
                        {
                            Name = "Trousers_for_man",
                            Name_For_User = "Штани",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668360741/dx6a4gmlo2figkktmhzk.png"
                         },
                        new Category()
                        {
                            Name = "Jeans_for_man",
                            Name_For_User = "Джинси",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668363931/ffvlvkoc11efduvjeaa8.jpg"
                         },
                        //Child Category
                        new Category()
                        {
                            Name = "Sales_for_child",
                            Name_For_User = "Осінній роспродаж",
                            Description = "Ексклюзивна коллекція яскравих товарів та ще , зі знижками",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668364271/zfp2jqlk6frkcl7bnqw4.png"
                         },
                        new Category()
                        {
                            Name = "New_for_child",
                            Name_For_User = "Нове",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668364931/fow1rk6bzzgadl92op1t.jpg"
                         },
                        new Category()
                        {
                            Name = "Gift_for_child",
                            Name_For_User = "Подарунки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668365389/un3gth3xucqveuophwie.jpg"
                         },
                        new Category()
                        {
                            Name = "Party_for_child",
                            Name_For_User = "Одяг для вечіок",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668365111/ntkamo7pxr8wgemgqstc.jpg"
                         },
                        new Category()
                        {
                            Name = "Classic_for_child",
                            Name_For_User = "Шкільна форма",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668365563/xuptkllvbx6ndewlwv8s.jpg"
                         },
                        new Category()
                        {
                            Name = "Coat_for_child",
                            Name_For_User = "Верхній одяг",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668365286/brunatmat8tf5hocnvqa.jpg"
                         },
                        new Category()
                        {
                            Name = "Bags_for_child",
                            Name_For_User = "Сумки та портфелі",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668365686/qncw1wpvjud0qqkkrx2w.jpg"
                         },
                        new Category()
                        {
                            Name = "Trousers_for_child",
                            Name_For_User = "Штани",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668366511/l5dylsqqkx62izl3oswh.jpg"
                         },
                        new Category()
                        {
                            Name = "Jeans_for_child",
                            Name_For_User = "Джинси",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668366674/axsvpfpgx9um58du5czg.jpg"
                         },
                    });
                        context.SaveChanges();
                    }
                }
            }

        
    }
}
