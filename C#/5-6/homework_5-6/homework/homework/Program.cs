
using methods;

namespace homework_5_6
{
    //Описать структуру Article, содержащую следующие
    //поля: код товара; название товара; цену товара
    struct Article
    {
        private int id;
        private string name;
        private int price;
        ArticleType articleType;

        public int Price
        {
            get => price;
            private set => price = value;
        }
        public ArticleType ArticleType
        {
            get => articleType;
            private set => articleType = value;
        }
        public Article()
        {
            this.id = alg.RAND(0, 50);
            this.name = alg.randString(7);
            this.price = alg.RAND(50000, 100000);
            this.articleType = (ArticleType)alg.RAND(0, Enum.GetValues(typeof(ArticleType)).Length - 1);
        }
        public Article(int id, string name, int price, ArticleType articleType)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.articleType = articleType;
        }
        public void print()
        {
            Console.WriteLine("Article");
            Console.Write($"id = {id} | ");
            Console.Write($"name = {name} | ");
            Console.Write($"price = {price} | ");
            Console.Write($"articletype = {articleType}  | ");
            Console.WriteLine();
        }

    }
    //    Описать перечисление ArticleType определяющее
    //типы товаров, и добавить соответствующее поле
    //в структуру Article из задания 1
    enum ArticleType
    {
        Furniture,
        Textile,
        Electronics,
        Toy
    }
    //    Описать структуру Client содержащую поля: код
    //клиента; ФИО; адрес; телефон; количество заказов
    //осуществленных клиентом; общая сумма заказов
    //клиента
    struct Client
    {
        private int id;
        private string name;
        private string phoneNumber;
        private int orderCnt;
        private int orderSumm;
        private ClientType clientType;

        public Client()
        {
            this.id = alg.RAND(0, 60);
            this.name = alg.randString(7);
            this.phoneNumber = alg.RAND(11111, 99999).ToString() + alg.RAND(11111, 99999).ToString();
            this.orderCnt = alg.RAND(1, 6);
            this.orderSumm = alg.RAND(10000, 60000);
            this.clientType = (ClientType)alg.RAND(0, Enum.GetValues(typeof(ClientType)).Length - 1);
        }

        public Client(int id, string name, string phoneNumber, int orderCnt, int orderSumm, ClientType clientType)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.orderCnt = orderCnt;
            this.orderSumm = orderSumm;
            this.clientType = clientType;
        }
        public void print()
        {
            Console.WriteLine("(Client)");
            Console.Write($"id = {id} | ");
            Console.Write($"name = {name} | ");
            Console.Write($"phoneNumber = {phoneNumber} | ");
            Console.Write($"orderCnt = {orderCnt} | ");
            Console.Write($"orderSumm = {orderSumm} | ");
            Console.Write($"clientType = {clientType}  | ");
            Console.WriteLine();
        }

    }
    //Описать перечисление ClientType определяющее
    //важность клиента, и добавить соответствующее поле
    //в структуру Client из задания №2 
    enum ClientType
    {
        notImportant,
        Important,
        veryImportant
    }

    //Описать структуру RequestItem содержащую поля:
    //товар; количество единиц товара
    struct RequestItem
    {
        private Article article;
        private int articlesCnt;

        public Article Article
        {
            get => article;
            private set => article = value;
        }

        public RequestItem()
        {
            article = new Article();
            articlesCnt = alg.RAND(1, 10);
        }
        public RequestItem(Article article, int articlesCnt)
        {
            this.article = article;
            this.articlesCnt = articlesCnt;
        }
        public void print()
        {
            Console.Write("(RequestItem)");
            article.print();
            Console.WriteLine($"articlesCnt = {articlesCnt}");
        }
    }
    //Описать структуру Request содержащую поля: код
    //заказа; клиент; дата заказа; перечень заказанных товаров;
    //сумма заказа(реализовать вычисляемым свойством)
    struct Request
    {
        private int id;
        private Client client;
        private string date;
        private List<RequestItem> requestItems;
        private int summ;
        private PayType payType;
        public Request()
        {
            id = alg.RAND(1, 100);
            client = new Client();
            date = $"{alg.RAND(1, 30)}.{alg.RAND(1, 12)}.{alg.RAND(2015, 2023)}";
            requestItems = new List<RequestItem>();
            this.payType = (PayType)alg.RAND(0, Enum.GetValues(typeof(PayType)).Length - 1);
            summ = 0;
            summCalc();
        }
        public void addItems(int cnt)
        {
            for (int i = 0; i < cnt; i++)
            {
                requestItems.Add(new RequestItem());
            }
            summCalc();
        }
        public void summCalc()
        {
            int sum = 0;
            for (int i = 0; i < requestItems.Count; i++)
            {
                sum += requestItems[i].Article.Price;
            }
            summ = sum;
        }
        public void print()
        {
            Console.WriteLine("(Request)");
            Console.WriteLine($"id = {id}");
            client.print();
            Console.WriteLine($"date = {date}");
            Console.Write("ArticlesTypes { ");
            foreach (RequestItem item in requestItems)
            {
                Console.Write(item.Article.ArticleType + " ");
            }
            Console.WriteLine("}");
            Console.WriteLine($"summ = {summ}");
            Console.WriteLine($"payType = {payType}");
        }

    }
    //Описать перечисление PayType определяющее форму
    //оплаты клиентом заказа, и добавить соответствующее
    //поле в структуру Request из задания №4
    enum PayType
    {
        card,
        cash
    }
    class homework
    {
        public void Problem_01()
        {
            Article article = new Article(41, "Armchair", 40000, (ArticleType)0);
            article.print();
        }
        public void Problem_02()
        {
            Client client = new Client(23, "Ilya Kanishev", "87020540223", 6, 50100, (ClientType)2);
            client.print();
        }
        public void Problem_03()
        {
            Request request = new Request();
            request.addItems(8);
            request.print();
        }
        public void Problem_04()
        {
            Student student = new Student();

            student.initStudent();
            int key = -1;
            while (key != 0)
            {
                Console.WriteLine("1.Print data \n2.Get Average Grade \n3.Change grades \n0.Exit");
                key = alg.toIntTryParse("Enter a key: ");
                switch (key)
                {
                    case 0:
                        return;
                    case 1:
                        student.Print();
                        break;
                    case 2:
                        {
                            int select = -1;
                            while (select < 1 || select > 3)
                            {
                                select = alg.toIntTryParse("Enter a discipline to get an average grade (>=1 && <= 3): ");
                            }
                            select--;
                            Console.WriteLine($"Average grade for {Enum.GetValues(typeof(Discipline)).GetValue(select)}: {student.averageGrade(select)}");
                        }
                            break;
                    case 3:

                        {
                            int select = -1;
                            while (select < 1 || select > 3)
                            {
                                select = alg.toIntTryParse("Enter a discipline to change grades (>=1 && <= 3): ");
                            }
                            select--;
                            student.randFillGradesSingle(select);
                            Console.Write($"Change grades for {Enum.GetValues(typeof(Discipline)).GetValue(select)}: ");

                            alg.PrintArr(student.Grades[select]);

                        }
                            break;

                }
                Console.WriteLine();

            }
        }

        public void Problem_05()
        {
            Door door = new Door();
            door.Start();
        }
        public void Problem_06()
        {
            DoorForCountry doorForCountry = new DoorForCountry();
            doorForCountry.Start();
        }
        public static void Main(string[] args)
        {
            homework hw = new homework();
            Console.WriteLine("\nTask (1, 5)\n");
            hw.Problem_01();
            Console.WriteLine("\nTask (2, 6)\n");
            hw.Problem_02();
            Console.WriteLine("\nTask (3, 4, 7)\n");
            hw.Problem_03();
            Console.WriteLine("\nTask (8)\n");
            hw.Problem_04();
            Console.WriteLine("\nTask (9)\n");
            hw.Problem_05();
            Console.WriteLine("\nTask (10)\n");
            hw.Problem_06();
        }

    }



}