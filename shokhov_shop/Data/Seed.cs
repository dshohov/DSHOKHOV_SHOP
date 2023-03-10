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
                            Name_For_User = "Осінній роспродаж",
                            Description = "Ексклюзивна коллекція яскравих товарів та ще , зі знижками",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668356999/lm1pr2lsosib7e4f6rpl.png"
                         },
                        new Category()
                        {
                            Name_For_User = "Нове",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668358394/go2oad91mnupwmvql9dv.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Подарунки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357392/jvj1hb49iikwgljuwwbm.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Свята та вечірки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357411/xklos76rkzg7a8yaso5t.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Классика",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357447/x4mzsdezocomu1lbupob.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Пальто",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357463/skto3qtd67a0afhn7eik.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Сумки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357498/snfcixpd08lg4hamsxdk.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Сукні та комбенізони",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357510/sxascimf22jzuzesj9ns.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Джинси",
                            Description = "Дізнатися більше",
                            People = Enum.People.Women,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668357522/dt9joolcasognye0dmhn.jpg"
                         },
                        //Man Category
                        new Category()
                        {
                            Name_For_User = "Осінній роспродаж",
                            Description = "Ексклюзивна коллекція яскравих товарів та ще , зі знижками",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668359425/fh0wrzahsdv0dvn9xefo.png"
                         },
                        new Category()
                        {
                            Name_For_User = "Нове",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668361247/g8kzozjfwlk3m6cl7jrb.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Подарунки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668359760/ugai98f1piw8zbnpa9le.png"
                         },
                        new Category()
                        {
                            Name_For_User = "Свята та вечірки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668360681/s7hbo0vgnz10tnehotvw.png"
                         },
                        new Category()
                        {
                            Name_For_User = "Класичні костюми",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668360693/xp7jiutqflhimsvugqgl.png"
                         },
                        new Category()
                        {
                            Name_For_User = "Верхній одяг",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668360704/pjdil41pdfux1doars8b.png"
                         },
                        new Category()
                        {
                            Name_For_User = "Сумки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668364153/ro5fqtwonzu8sivvo9v3.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Штани",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668360741/dx6a4gmlo2figkktmhzk.png"
                         },
                        new Category()
                        {
                            Name_For_User = "Джинси",
                            Description = "Дізнатися більше",
                            People = Enum.People.Men,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668363931/ffvlvkoc11efduvjeaa8.jpg"
                         },
                        //Child Category
                        new Category()
                        {
                            Name_For_User = "Осінній роспродаж",
                            Description = "Ексклюзивна коллекція яскравих товарів та ще , зі знижками",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668364271/zfp2jqlk6frkcl7bnqw4.png"
                         },
                        new Category()
                        {
                            Name_For_User = "Нове",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668364931/fow1rk6bzzgadl92op1t.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Подарунки",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668365389/un3gth3xucqveuophwie.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Одяг для вечіок",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668365111/ntkamo7pxr8wgemgqstc.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Шкільна форма",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668365563/xuptkllvbx6ndewlwv8s.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Верхній одяг",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668365286/brunatmat8tf5hocnvqa.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Сумки та портфелі",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668365686/qncw1wpvjud0qqkkrx2w.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Штани",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668366511/l5dylsqqkx62izl3oswh.jpg"
                         },
                        new Category()
                        {
                            Name_For_User = "Джинси",
                            Description = "Дізнатися більше",
                            People = Enum.People.Child,
                            Image = "http://res.cloudinary.com/dcoeealak/image/upload/v1668366674/axsvpfpgx9um58du5czg.jpg"
                         },
                    });
                        context.SaveChanges();
                    }
                    if (!context.Products.Any())
                    {
                    context.Products.AddRange(new List<Product>()
                        {
                            //Women product
                            //Sales
                            new Product(){
                                Name_For_User = "Зимове пальто",
                                Description = "Тепле зимове пальто , дуже добре підходить до теплої зими.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 99,
                                People = Enum.People.Women,
                                Sub_category = "Пальто",
                                Category_id = 1,
                                Sizes = "XS,S,M,L,XL"

                            },
                            new Product(){
                                Name_For_User = "Пухова желетка",
                                Description = "Тепла річ, гарно підійде для коротких прогулянок.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 49,
                                People = Enum.People.Women,
                                Sub_category = "Желетка",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 1
                            },
                            new Product(){
                                Name_For_User = "В'язана кофта",
                                Description = "Тепла яскрава кофта ідеально підійде до базового стилю.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 20,
                                People = Enum.People.Women,
                                Sub_category = "Кофта",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 1
                            },
                            //New
                            new Product(){
                                Name_For_User = "В'язана зимова кофта",
                                Description = "Тепла яскрава кофта ідеально підійде до святкуання різдва та нового року.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 20,
                                People = Enum.People.Women,
                                Sub_category = "Кофта",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 2
                            },
                            new Product(){
                                Name_For_User = "В'язана зимова кофта з ялинкою",
                                Description = "Тепла яскрава кофта ідеально підійде до святкуання різдва та нового року.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 20,
                                People = Enum.People.Women,
                                Sub_category = "Кофта",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 2
                            },
                            new Product(){
                                Name_For_User = "Теплий шарф",
                                Description = "Великий шарф який буде виділяти вас.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 20,
                                People = Enum.People.Women,
                                Sub_category = "Шарф",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 2
                            },
                            //Gift
                            new Product(){
                                Name_For_User = "Свічка",
                                Description = "Ароматична свччка з запахом ванілі.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 5,
                                People = Enum.People.Women,
                                Sub_category = "Свічки",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 3
                            },
                            new Product(){
                                Name_For_User = "Подарунковий календар",
                                Description = "Набір з подарунками які можна відкривати кожен день увесь місяць.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 15,
                                People = Enum.People.Women,
                                Sub_category = "Календар",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 3
                            },
                            new Product(){
                                Name_For_User = "Парфум",
                                Description = "Парфум популярного бренду.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 10,
                                People = Enum.People.Women,
                                Sub_category = "Парфум",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 3
                            },
                            //Party
                            new Product(){
                                Name_For_User = "Свякова коктельна сукня",
                                Description = "Сукня яка подарує вам нові ємоції і погляди на себе.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 35,
                                People = Enum.People.Women,
                                Sub_category = "Коктельні сукні",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 4
                            },
                            new Product(){
                                Name_For_User = "Святковий костюм",
                                Description = "Костюм який дає новий погляд на классику.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 60,
                                People = Enum.People.Women,
                                Sub_category = "Костюм",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 4
                            },
                            new Product(){
                                Name_For_User = "Свякова сукня",
                                Description = "Сукня яка подарує вам нові ємоції і погляди на себе.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 45,
                                People = Enum.People.Women,
                                Sub_category = "Коктельні сукні",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 4
                            },
                            //Classik
                            new Product(){
                                Name_For_User = "Чорний класичний костюм",
                                Description = "Классика яка завжди личить до будьякого образу.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 60,
                                People = Enum.People.Women,
                                Sub_category = "Костюми",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 5
                            },
                            new Product(){
                                Name_For_User = "Класичні штани у клітинку",
                                Description = "Штани які гарно пасують до вашої фігури.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 30,
                                People = Enum.People.Women,
                                Sub_category = "Штани",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 5
                            },
                            new Product(){
                                Name_For_User = "Oversize сорочка",
                                Description = "Базова річ у гардеробі кожної жінки.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 20,
                                People = Enum.People.Women,
                                Sub_category = "Сорочки",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 5
                            },
                            //Coat
                            new Product(){
                                Name_For_User = "Чорне класичне пальто",
                                Description = "Классика яка завжди личить до будьякого образу.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 60,
                                People = Enum.People.Women,
                                Sub_category = "Пальто класичні",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 6
                            },
                            new Product(){
                                Name_For_User = "Легкий тренч",
                                Description = "Збереже вас від вітру та додасть вишуконасті вашому образу.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 60,
                                People = Enum.People.Women,
                                Sub_category = "Тренч",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 6
                            },
                            new Product(){
                                Name_For_User = "Дизайнерське пальто",
                                Description = "Пальто яке міняє сприянятя про класику.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 80,
                                People = Enum.People.Women,
                                Sub_category = "Щось яскраве",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 6
                            },
                            //Bags
                            new Product(){
                                Name_For_User = "Тоут Сумка",
                                Description = "Сумка відрізняється формою прямокутника, оснащена парою ручок, для зручності її використання.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 30,
                                People = Enum.People.Women,
                                Sub_category = "Тоут",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 7
                            },
                            new Product(){
                                Name_For_User = "Шоппер",
                                Description = "Зручна велика сумка для міста.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 15,
                                People = Enum.People.Women,
                                Sub_category = "Шоппер",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 7
                            },
                            new Product(){
                                Name_For_User = "Месседжер",
                                Description = "Маленьа зручна сумка для вечірки.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 25,
                                People = Enum.People.Women,
                                Sub_category = "Мессенджер",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 7
                            },
                            //Dress
                            new Product(){
                                Name_For_User = "Рожева сукня",
                                Description = "Базова сукня.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 50,
                                People = Enum.People.Women,
                                Sub_category = "Сукні",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 8
                            },
                            new Product(){
                                Name_For_User = "Джинсовий комбінезон",
                                Description = "Незвичайна річ яка потрібна для вашого гардероба.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 60,
                                People = Enum.People.Women,
                                Sub_category = "Комбінезон",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 8
                            },
                            //Jeans
                            new Product(){
                                Name_For_User = "Короткі блакитні джинси",
                                Description = "Укорочені жіночі джинси.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 25,
                                People = Enum.People.Women,
                                Sub_category = "Короткі джинси",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 9
                            },
                            new Product(){
                                Name_For_User = "Чорні джинси",
                                Description = "Стильні чорні дизанерські джински з дірками на колінах.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 30,
                                People = Enum.People.Women,
                                Sub_category = "Джинси з дірками",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 9
                            },
                            new Product(){
                                Name_For_User = "Широкі джинси",
                                Description = "Ми не носимо штани в обтяжку, у нас тільки конкретні шаровари для грошей. Впав-віджався і штовхай землю *****.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 40,
                                People = Enum.People.Women,
                                Sub_category = "Широкі джинси",
                                Sizes = "XS,S,M,L,XL",
                                Category_id = 9
                            },

                            //Man
                            //Sales
                            new Product(){
                                Name_For_User = "Джинсова куртка",
                                Description = "Стильна куртка з твердого джинсу для чоловіків.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 350,
                                People = Enum.People.Men,
                                Sub_category = "Куртки",
                                Category_id = 10,
                                Sizes = "S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Спортивні штани",
                                Description = "Зручні та стильні спортивні штани для чоловіків.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 150,
                                People = Enum.People.Men,
                                Sub_category = "Штани",
                                Category_id = 10,
                                Sizes = "S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Класична куртка",
                                Description = "Ця класична куртка зроблена з високоякісного матеріалу і має водовідштовхувальне покриття.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/kv6rrrw7a2fhej8sp7qr.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/kv6rrrw7a2fhej8sp7qr.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/kv6rrrw7a2fhej8sp7qr.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/kv6rrrw7a2fhej8sp7qr.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/kv6rrrw7a2fhej8sp7qr.png",
                                Price = 299,
                                People = Enum.People.Men,
                                Sub_category = "Куртки",
                                Category_id = 10,
                                Sizes = "M,L,XL,XXL"
                                },
                            new Product(){
                                Name_For_User = "Джинсові штани",
                                Description = "Ці джинсові штани мають модний вигляд і зручність для повсякденного носіння.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/hjmfbfkhj1k04tumozpy.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/hjmfbfkhj1k04tumozpy.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/hjmfbfkhj1k04tumozpy.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/hjmfbfkhj1k04tumozpy.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/hjmfbfkhj1k04tumozpy.png",
                                Price = 89,
                                People = Enum.People.Men,
                                Sub_category = "Штани",
                                Category_id = 10,
                                Sizes = "S,M,L,XL"
                                },
                            //new
                            new Product(){
                                Name_For_User = "Футболка з коротким рукавом",
                                Description = "Ця футболка з коротким рукавом зроблена з м'якого бавовни і має приємний на дотик матеріал.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wivaj7r3q3z8j7a03wwt.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wivaj7r3q3z8j7a03wwt.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wivaj7r3q3z8j7a03wwt.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wivaj7r3q3z8j7a03wwt.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wivaj7r3q3z8j7a03wwt.png",
                                Price = 49,
                                People = Enum.People.Men,
                                Sub_category = "Футболки",
                                Category_id = 11,
                                Sizes = "S,M,L,XL,XXL"
                                },
                            new Product(){
                                Name_For_User = "Костюм з штанами і піджаком",
                                Description = "Цей костюм з штанами і піджаком зроблений з високоякісного матеріалу і має добре приталений крій.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/fryinj0h9f9yxlpzny4s.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/fryinj0h9f9yxlpzny4s.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/fryinj0h9f9yxlpzny4s.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/fryinj0h9f9yxlpzny4s.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/fryinj0h9f9yxlpzny4s.png",
                                Price = 699,
                                People = Enum.People.Men,
                                Sub_category = "Костюми",
                                Category_id = 11,
                                Sizes = "M,L,XL,XXL"
                                },
                             new Product(){
                                Name_For_User = "Куртка",
                                Description = "Класична куртка для чоловіків, ідеальна для весняних та осінніх днів.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 399,
                                People = Enum.People.Men,
                                Sub_category = "Куртки",
                                Category_id = 11,
                                Sizes = "S,M,L,XL"
                            },
                             new Product(){
                                Name_For_User = "Спортивні штани",
                                Description = "Створені для комфорту під час занять спортом. Виготовлені з якісних матеріалів.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 299,
                                People = Enum.People.Men,
                                Sub_category = "Штани",
                                Category_id = 11,
                                Sizes = "XS,S,M,L,XL"
                            },
                             new Product(){
                                Name_For_User = "Кофта з капюшоном",
                                Description = "Кофта з капюшоном, виготовлена з м'якого матеріалу для забезпечення комфорту та тепла.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 149,
                                People = Enum.People.Men,
                                Sub_category = "Світшот",
                                Category_id = 11,
                                Sizes = "XS,S,M,L,XL"
                            },
                             //Gift
                             new Product(){
                                Name_For_User = "Наручний годинник",
                                Description = "Класичний наручний годинник із стильним дизайном, який стане прекрасним подарунком для чоловіка",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/watch1_jvqyje.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/watch1_jvqyje.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/watch1_jvqyje.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/watch1_jvqyje.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/watch1_jvqyje.png",
                                Price = 650,
                                People = Enum.People.Men,
                                Sub_category = "Годинники",
                                Category_id = 12,
                                Sizes = "One Size"
                            },
                             new Product(){
                                Name_For_User = "Гаманець",
                                Description = "Стильний гаманець з натуральної шкіри з багатьма відділеннями для грошей та кредитних карток. Ідеальний подарунок для чоловіка",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Price = 400,
                                People = Enum.People.Men,
                                Sub_category = "Гаманеці",
                                Category_id = 12,
                                Sizes = "One Size"
                                },
                             new Product(){
                                Name_For_User = "Шкіряний гаманець",
                                Description = "Елегантний гаманець зі знімним кишенею для монет. Виготовлений з натуральної шкіри.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Price = 850,
                                People = Enum.People.Women,
                                Sub_category = "Гаманці",
                                Category_id = 12,
                                Sizes = "One size"
                            },
                             new Product(){
                                Name_For_User = "Кавовий набір",
                                Description = "Класичний кавовий набір з кавової кружки та кавоваркою, зроблений з високоякісної кераміки.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/wallet1_kpnd6g.png",
                                Price = 400,
                                People = Enum.People.Men,
                                Sub_category = "Кава",
                                Category_id = 12,
                                Sizes = "One size"
                            },
                             //Party
                             new Product(){
                                Name_For_User = "Сорочка чорного кольору",
                                Description = "Чоловіча сорочка, виконана зі 100% бавовни, чорного кольору.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 350,
                                People = Enum.People.Men,
                                Sub_category = "Сорочка",
                                Category_id = 13,
                                Sizes = "S,M,L,XL"
                             },
                             new Product(){
                                Name_For_User = "Чоловічий костюм",
                                Description = "Костюм для чоловіків, який підійде для будь-якої вечірки або свята. Складається з чорного піджака і брюк, виконаних з якісного матеріалу.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 800,
                                People = Enum.People.Men,
                                Sub_category = "Костюм",
                                Category_id = 13,
                                Sizes = "M,L,XL"
                             },
                             new Product(){
                                Name_For_User = "Біла сорочка",
                                Description = "Стильна біла сорочка, яка підійде для будь-якого святкового заходу.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 250,
                                People = Enum.People.Men,
                                Sub_category = "Сорочки",
                                Category_id = 13,
                                Sizes = "S,M,L,XL"
                                },
                             new Product(){
                                Name_For_User = "Чорні штани",
                                Description = "Класичні чорні штани, ідеальні для вечірок та святкових подій.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 250,
                                People = Enum.People.Men,
                                Sub_category = "Штани",
                                Category_id = 13,
                                Sizes = "S,M,L,XL"
                                },
                             //Класика
                             new Product(){
                                Name_For_User = "Сорочка",
                                Description = "Класична чоловіча сорочка з ідеальним кроєм.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 299,
                                People = Enum.People.Men,
                                Sub_category = "Сорочки",
                                Category_id = 14,
                                Sizes = "S,M,L,XL"
                            },
                             new Product(){
                                Name_For_User = "Костюм",
                                Description = "Класичний чоловічий костюм з ідеальним кроєм.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 899,
                                People = Enum.People.Men,
                                Sub_category = "Костюми",
                                Category_id = 14,
                                Sizes = "S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Пальто",
                                Description = "Класичне чоловіче пальто з високоякісної тканини.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 599,
                                People = Enum.People.Men,
                                Sub_category = "Пальта",
                                Category_id = 14,
                                Sizes = "S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Краватка",
                                Description = "Класична шовкова краватка.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 199,
                                People = Enum.People.Men,
                                Sub_category = "Краватки",
                                Category_id = 14,
                                Sizes = "One size"
                            },
                            //Пальто
                            new Product(){
                                Name_For_User = "Класичне пальто",
                                Description = "Класичне пальто з високоякісної шерсті, прикрашене гудзиками у вигляді кісточок",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 599,
                                People = Enum.People.Men,
                                Sub_category = "Пальто з шерсті",
                                Category_id = 15,
                                Sizes = "S,M,L,XL,XXL"
                                },
                            new Product(){
                                Name_For_User = "Пальто з горизонтальними смугами",
                                Description = "Пальто з горизонтальними смугами в двох кольорах, відмінний вибір для стильного образу",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 799,
                                People = Enum.People.Men,
                                Sub_category = "Пальто з принтом",
                                Category_id = 15,
                                Sizes = "S,M,L,XL,XXL"
                                },
                            new Product(){
                                Name_For_User = "Чоловіче пальто з віскози",
                                Description = "Класичне чоловіче пальто з віскози, підходить для офісного та повсякденного одягу.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 399,
                                People = Enum.People.Men,
                                Sub_category = "Дизайнерскі пальта",
                                Category_id = 15,
                                Sizes = "S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Чоловіче пальто з кашеміру",
                                Description = "Класичне чоловіче пальто з кашеміру, дуже тепле та зручне, підходить для вечірнього виходу.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 899,
                                People = Enum.People.Men,
                                Sub_category = "Кашемір",
                                Category_id = 15,
                                Sizes = "M,L,XL"
                            },
                            //Bags
                            new Product(){
                                Name_For_User = "Стильна чоловіча сумка",
                                Description = "Сумка з шкіри з відділенням для лаптопа та додатковими кишенями.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 299,
                                People = Enum.People.Men,
                                Sub_category = "Маленькі сумки",
                                Category_id = 16,
                                Sizes = "One size"
                                },
                            new Product(){
                                Name_For_User = "Чоловіча шкіряна портфель",
                                Description = "Класичний шкіряний портфель для офісних документів.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 599,
                                People = Enum.People.Men,
                                Sub_category = "Портфель",
                                Category_id = 16,
                                Sizes = "One size"
                                },
                            new Product(){
                                Name_For_User = "Стильний портфель",
                                Description = "Чоловічий портфель виконаний з натуральної шкіри в чорному кольорі. Ідеальний варіант для бізнесу та повсякденного використання.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668893094/ztcofu2cczdkfujli8jo.jpg",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668893094/ztcofu2cczdkfujli8jo.jpg",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668893094/ztcofu2cczdkfujli8jo.jpg",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668893094/ztcofu2cczdkfujli8jo.jpg",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668893094/ztcofu2cczdkfujli8jo.jpg",
                                Price = 250,
                                People = Enum.People.Men,
                                Sub_category = "Портфелі",
                                Category_id = 16,
                                Sizes = "One Size"
                            },
                            new Product(){
                                Name_For_User = "Сумка для ноутбука",
                                Description = "Чоловіча сумка для ноутбука виконана з міцної тканини та оснащена великою кількістю кишеньок для зберігання різних речей.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668893535/bbprftw6ixjlddsyhpbp.jpg",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668893535/bbprftw6ixjlddsyhpbp.jpg",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668893535/bbprftw6ixjlddsyhpbp.jpg",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668893535/bbprftw6ixjlddsyhpbp.jpg",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668893535/bbprftw6ixjlddsyhpbp.jpg",
                                Price = 150,
                                People = Enum.People.Men,
                                Sub_category = "Сумки для ноутбуків",
                                Category_id = 16,
                                Sizes = "One Size"
                            },
                            //Trousers
                            new Product(){
                                Name_For_User = "Штани з кишенями",
                                Description = "Комфортні штани з бічними кишенями, що підійдуть для будь-якої ситуації.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 120,
                                People = Enum.People.Men,
                                Sub_category = "Штани з кишенями",
                                Category_id = 17,
                                Sizes = "S,M,L,XL,XXL"
                            },
                            new Product(){
                                Name_For_User = "Штани класичні",
                                Description = "Штани з класичним кроєм та відмінним качеством пошиття.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 200,
                                People = Enum.People.Men,
                                Sub_category = "Класика",
                                Category_id = 17,
                                Sizes = "XS,S,M,L,XL"
                            },

                            new Product(){
                                Name_For_User = "Джинси для чоловіків",
                                Description = "Класичні джинси, ідеально підходять для будь-якої ситуації.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 499,
                                People = Enum.People.Men,
                                Sub_category = "Джинси",
                                Category_id = 17,
                                Sizes = "XS,S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Чорні штани",
                                Description = "Класичні чорні штани, відмінно підходять для бізнес-образу.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 299,
                                People = Enum.People.Men,
                                Sub_category = "Штани",
                                Category_id = 17,
                                Sizes = "XS,S,M,L,XL"
                            },
                            //Jeans
                            new Product(){
                                Name_For_User = "Чорні джинси",
                                Description = "Класичні чорні джинси зі стильним дизайном, підійдуть для будь-якої ситуації.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 750,
                                People = Enum.People.Men,
                                Sub_category = "Чорні джинси",
                                Category_id = 18,
                                Sizes = "XS,S,M,L,XL"
                                },
                            new Product(){
                                    Name_For_User = "Зносені джинси",
                                    Description = "Зносені джинси з ефектом старіння, підходять для стильного вигляду.",
                                    Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                    Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                    Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                    Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                    Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                    Price = 500,
                                    People = Enum.People.Men,
                                    Sub_category = "Зносені джинси",
                                    Category_id = 18,
                                    Sizes = "XS,S,M,L,XL"
                                    },
                            new Product(){
                                    Name_For_User = "Джинсові шорти",
                                    Description = "Стильні шорти з деніму на літо.",
                                    Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/qpzksttuc7xq8msqsfzm.png",
                                    Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/qpzksttuc7xq8msqsfzm.png",
                                    Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/qpzksttuc7xq8msqsfzm.png",
                                    Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/qpzksttuc7xq8msqsfzm.png",
                                    Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/qpzksttuc7xq8msqsfzm.png",
                                    Price = 250,
                                    People = Enum.People.Men,
                                    Sub_category = "Шорти",
                                    Category_id = 18,
                                    Sizes = "XS,S,M,L,XL"
                            },
                            new Product(){
                                    Name_For_User = "Джинсові штани",
                                    Description = "Класичні джинсові штани зі стильним дизайном",
                                    Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/denim-pants.jpg",
                                    Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/denim-pants.jpg",
                                    Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/denim-pants.jpg",
                                    Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/denim-pants.jpg",
                                    Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/denim-pants.jpg",
                                    Price = 299,
                                    People = Enum.People.Men,
                                    Sub_category = "Прямі джинси",
                                    Category_id = 18,
                                    Sizes = "XS,S,M,L,XL"
                            },
                            //Child
                            //Sale
                            new Product(){
                            Name_For_User = "Джинсова куртка",
                            Description = "Ця куртка зроблена з джинсової тканини, що дозволяє їй бути легкою і зносостійкою. Вона має чотири кишені, що забезпечує великий простір для зберігання ваших речей.",
                            Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/jacket1.png",
                            Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/jacket1.png",
                            Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/jacket1.png",
                            Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/jacket1.png",
                            Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/jacket1.png",
                            Price = 350,
                            People = Enum.People.Child,
                            Sub_category = "Куртки",
                            Category_id = 19,
                            Sizes = "XS,S,M,L,XL"
                            },
                            new Product(){
                            Name_For_User = "Джинсові шорти",
                            Description = "Ці джинсові шорти - ідеальний вибір для спекотного літа. Вони зроблені з високоякісної джинсової тканини, що забезпечує комфорт і легкість у використанні.",
                            Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/shorts1.png",
                            Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/shorts1.png",
                            Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/shorts1.png",
                            Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/shorts1.png",
                            Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/shorts1.png",
                            Price = 180,
                            People = Enum.People.Child,
                            Sub_category = "Шорти",
                            Category_id = 19,
                            Sizes = "XS,S,M,L,XL"
                            },
                            //New
                            new Product(){
                                Name_For_User = "Дитячі штани",
                                Description = "Зручні дитячі штани з тканини, яка дозволяє шкірі дихати.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 200,
                                People = Enum.People.Child,
                                Sub_category = "Штани",
                                Category_id = 20,
                                Sizes = "XS,S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Дитяча футболка",
                                Description = "Класична біла футболка для дітей з високоякісного матеріалу.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 150,
                                People = Enum.People.Child,
                                Sub_category = "Футболки",
                                Category_id = 20,
                                Sizes = "XS,S,M,L,XL"
                            },
                            //Gift
                            new Product(){
                                Name_For_User = "Дитяча іграшка Рухайко",
                                Description = "Ця іграшка забезпечує безліч годин руханки та веселощів для дітей різного віку.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 199,
                                People = Enum.People.Child,
                                Sub_category = "Іграшки",
                                Category_id = 21,
                                Sizes = "Один розмір"
                            },
                            new Product(){
                                Name_For_User = "Дитяча книжка Пригоди Маленького Ведмедика",
                                Description = "Ця чудова книжка розповідає про пригоди маленького ведмедика та його друзів. Ідеальний подарунок для малюка.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 299,
                                People = Enum.People.Child,
                                Sub_category = "Книги",
                                Category_id = 21,
                                Sizes = "Один розмір"
                            },
                            //Party
                            new Product(){
                                Name_For_User = "Дитяча сукня з тюлем",
                                Description = "Гарна дитяча сукня з тюлем для вечірок та свят.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/s3xbuwky8hvfjwfdscb0.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/s3xbuwky8hvfjwfdscb0.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/s3xbuwky8hvfjwfdscb0.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/s3xbuwky8hvfjwfdscb0.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/s3xbuwky8hvfjwfdscb0.png",
                                Price = 250,
                                People = Enum.People.Child,
                                Sub_category = "Сукні",
                                Category_id = 22,
                                Sizes = "XS,S,M,L,XL"
                                },
                            new Product(){
                                Name_For_User = "Дитячий костюм супергероя",
                                Description = "Костюм супергероя для дітей, що допоможе їм відчути себе справжніми героями.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/oiep9fzixg0i4rwjwr7s.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/oiep9fzixg0i4rwjwr7s.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/oiep9fzixg0i4rwjwr7s.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/oiep9fzixg0i4rwjwr7s.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/oiep9fzixg0i4rwjwr7s.png",
                                Price = 450,
                                People = Enum.People.Child,
                                Sub_category = "Костюми",
                                Category_id = 22,
                                Sizes = "XS,S,M,L,XL"
                                },
                            //School
                            new Product(){
                                Name_For_User = "Шкільна сукня",
                                Description = "Класична сукня для дівчаток на шкільні свята і заходи.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 399,
                                People = Enum.People.Child,
                                Sub_category = "Сукні",
                                Category_id = 23,
                                Sizes = "XS,S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Шкільний костюм",
                                Description = "Комплект з брюк і жакета для дівчаток на шкільні заходи.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 799,
                                People = Enum.People.Child,
                                Sub_category = "Костюми",
                                Category_id = 23,
                                Sizes = "XS,S,M,L,XL"
                                },
                            new Product(){
                                Name_For_User = "Дитячий комбінезон",
                                Description = "Теплий комбінезон для дітей, добре підходить для зимової погоди.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 400,
                                People = Enum.People.Child,
                                Sub_category = "Комбінезони",
                                Category_id = 24,
                                Sizes = "XS,S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Дитяча куртка",
                                Description = "Тепла куртка для дітей, ідеальна для прохолодної осені та зими.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 250,
                                People = Enum.People.Child,
                                Sub_category = "Куртки",
                                Category_id = 24,
                                Sizes = "XS,S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Дитячий портфель",
                                Description = "Креативний та зручний портфель для дитини.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 199,
                                People = Enum.People.Child,
                                Sub_category = "Портфелі",
                                Category_id = 25,
                                Sizes = "S,M,L"
                            },
                            new Product(){
                                Name_For_User = "Дитяча сумка",
                                Description = "Гарна сумочка для дівчинки, щоб носити різні дрібнички.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 299,
                                People = Enum.People.Child,
                                Sub_category = "Сумки",
                                Category_id = 25,
                                Sizes = "XS,S,M,L"
                            },
                            new Product(){
                                Name_For_User = "Дитячі штани з гумкою",
                                Description = "Зручні і м'які дитячі штани з гумкою на поясі, підходять для повсякденного носіння.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 250,
                                People = Enum.People.Child,
                                Sub_category = "Хлопчики",
                                Category_id = 26,
                                Sizes = "XS,S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Дитячі штани-джогери",
                                Description = "Комфортні і стильні дитячі штани-джогери, зручні для активних ігор та повсякденного носіння.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 350,
                                People = Enum.People.Child,
                                Sub_category = "Дівчатка",
                                Category_id = 26,
                                Sizes = "XS,S,M,L,XL"
                            },
                            new Product(){
                                Name_For_User = "Дитячі джинси",
                                Description = "Класичні джинси для дітей, дуже зручні і практичні.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 299,
                                People = Enum.People.Child,
                                Sub_category = "Хлопчики",
                                Category_id = 27,
                                Sizes = "XS,S,M,L,XL"
                                },
                            new Product(){
                                Name_For_User = "Джинсові штаники для дівчинки",
                                Description = "Комфортні та стильні джинсові штаники для маленьких принцес.",
                                Image = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image2 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image3 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image4 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Image5 = "https://res.cloudinary.com/dcoeealak/image/upload/v1668886183/vmgxbaoi4mdxydlzfpgu.png",
                                Price = 199,
                                People = Enum.People.Child,
                                Sub_category = "Дівчатка",
                                Category_id = 27,
                                Sizes = "XS,S,M,L,XL"
                                }

                        });
                        context.SaveChanges();
                    }

                }
            }

        
    }
}
