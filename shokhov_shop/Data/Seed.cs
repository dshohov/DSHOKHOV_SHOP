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
                            Category_id = 1
                            
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
                            Category_id = 9
                        },
                    }) ;
                    context.SaveChanges();
                }

            }
            }

        
    }
}
