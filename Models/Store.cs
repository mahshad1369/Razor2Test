namespace Razor2Test.Models;

public class Store
{
    public static List<Product> Products { get; set; } = new()
    {
        new Product { Id =1 ,Title="Smart Watch Galaxy Watch6",PhotoPath="/1.jpg",Questions=new List<Question>()
        {
           
            new Question(){Id=1,QuestionText="سلام خسته نباشید به گلکسی واچ3 میخوره??",CreationDate = DateTime.Now},
            new Question(){Id=2,QuestionText="سلام به گلکسی واچ۴ ۴۰میلیمتری میخوره؟ رنگ یاسیش همون بنفش کمرنگه تو عکساست؟",CreationDate = DateTime.Now},
            new Question(){Id=3,QuestionText="رنگ عکس اول چه رنگی هست؟",CreationDate = DateTime.Now},
            new Question(){Id=4,QuestionText="سلام ممنون از پاسخ شما جسارتا به واچ ۴ ۴۴ م م هم میخوره متشکرم",CreationDate = DateTime.Now},
            new Question(){Id=5,QuestionText="سلام لطفا بفرمائید بند چند م م است (۲۰ یا ۲۲) متشکرم",CreationDate = DateTime.Now},
            new Question(){Id=6,QuestionText="سلام. به watch 5 سایز 40 میل، میخوره ؟",CreationDate = DateTime.Now},
            new Question(){Id=7,QuestionText="سلام بند این مدل ساعت هوشمند سامسونگ رو از کجا میتونم تهیه کنم",CreationDate = DateTime.Now},
            new Question(){Id=8,QuestionText="آیا متن فارسی را نمایش می‌دهد؟",CreationDate = DateTime.Now},
            new Question(){Id=9,QuestionText="سلام آیا استفاده از اپلیکیشن اندرویدش تو ایران مشکلی نداره؟ یعنی کارایی ساعت بخاطر ایران محدود نمیشه",CreationDate = DateTime.Now},
            new Question(){Id=10,QuestionText="با سلام لطفا سایز صفحه نمایش و خود ساعت را بفرمایید. ممنون",CreationDate = DateTime.Now}
        },
            
            Comments=new List<Comment>()
        {
            new Comment(){Id=1,Text="پیشنهاد میکنم برای کادو",CreationDate = DateTime.Now}  ,
            new Comment(){Id=2,Text="آشغاله بعد دو روز اصلا دیگه کار نکرد خواستید پولتوتو دور بریزید بخرید",CreationDate = DateTime.Now},
            new Comment(){Id=3,Text="عالی", CreationDate = DateTime.Now},
            new Comment(){Id=4,Text="ی کپی ضعیف و ب شدت گیج", CreationDate = DateTime.Now},
            new Comment(){Id=5,Text="بد نیست پیشنهاد میشه", CreationDate = DateTime.Now},
            new Comment(){Id=6,Text="نسبت ب قیمتش عالیه", CreationDate = DateTime.Now},
            new Comment(){Id=7,Text="خوبه با توجه به قیمت", CreationDate = DateTime.Now}

        }
        },

        new Product { Id =2 ,Title="IPhone 13 CH" ,PhotoPath="/2.jpg",Questions=new List<Question>()
        {

            new Question(){Id=11,QuestionText="دوستان این گوشی تازه گرفتم.دوتا سوال.۱ چجور اندروید اپدیت میشه؟۲ گذینه نت خط جدا نیست؟",CreationDate = DateTime.Now},
            new Question(){Id=12,QuestionText="سلام برای مخاطب عکس بزاری موقعه تماس دریافتی عکس رو تمام صفحه نشون میده یا خیر؟",CreationDate = DateTime.Now},
            new Question(){Id=13,QuestionText="سلام دوربین از سامسونگ a14 بهتره؟",CreationDate = DateTime.Now},
            new Question(){Id=14,QuestionText="سلام هدفن داره",CreationDate = DateTime.Now},
            new Question(){Id=15,QuestionText="آیا وسیله های این گوشی نوکیا موقع خرابی باطری تاج ال سی دی سخت افزار در بازار است",CreationDate = DateTime.Now},
            new Question(){Id=16,QuestionText="با سلام ببخشید برای گیم مناسبه",CreationDate = DateTime.Now},
            new Question(){Id=17,QuestionText="ایاجلدکتابی هم موجود هست براش؟",CreationDate = DateTime.Now},
            new Question(){Id=18,QuestionText="این گوشی از قابلیت dual massager برای تلگرام و واتس آب پشتیبانی میکنه؟",CreationDate = DateTime.Now},
            new Question(){Id=19,QuestionText="سلام Nfc otg پش میکند؟",CreationDate = DateTime.Now},
            new Question(){Id=20,QuestionText="قابلیت نصب برنامه ضبط مکالمه رو داره یانه؟",CreationDate = DateTime.Now}
        }

            ,Comments=new List<Comment>()
        {

            new Comment(){Id=8,Text="تجربه خرید خوبی بود ممنون", CreationDate = DateTime.Now},

            new Comment(){Id=9,Text="با شرایط اقتصادی فعلی، گوشی خوبی بحساب میاد", CreationDate = DateTime.Now},

            new Comment(){Id=10,Text="نسبت به اندروید خیلی سرتره", CreationDate = DateTime.Now},

            new Comment(){Id=11,Text="بگیرید استفاده کنید لذت ببرید",CreationDate = DateTime.Now},

            new Comment(){Id=12,Text="عالی از همه نظرات به جز باطری و اپلیکیشن ها", CreationDate = DateTime.Now},

            new Comment(){Id=13,Text="عالی، برای دخترم گرفتم خیلی راضیه", CreationDate = DateTime.Now},

            new Comment(){Id=14,Text="همونی که میخواستم", CreationDate = DateTime.Now},

            new Comment(){Id=15,Text="عالییییییییییه", CreationDate = DateTime.Now}

        }
        },
             new Product { Id =3 ,Title="Tablet Redmi pad" ,PhotoPath="/3.jpg",Questions=new List<Question>()
        {

            new Question(){Id=21,QuestionText="لطفا یه قلم معرفی کنید برای این تبلت",CreationDate = DateTime.Now},
            new Question(){Id=22,QuestionText="سلام رنگ خاکستری موجود میشه؟؟؟",CreationDate = DateTime.Now},
            new Question(){Id=23,QuestionText="با این تبلت کالاف میشه بازی کنیم ؟",CreationDate = DateTime.Now},
            new Question(){Id=24,QuestionText="سلام ببخشید چه قلمی براش مناسبه ؟",CreationDate = DateTime.Now},
            new Question(){Id=25,QuestionText="گلس و کیف شما موجود دارید برا این مدل؟",CreationDate = DateTime.Now},
            new Question(){Id=26,QuestionText="از قلم پشتیبانی میکنه ؟ (هرقلمی که باشه )",CreationDate = DateTime.Now},
            new Question(){Id=27,QuestionText="برای مطالعه مناسب هست ؟",CreationDate = DateTime.Now},
            new Question(){Id=28,QuestionText="سلام هارد یک‌ترابایت رو‌باز میکنه؟",CreationDate = DateTime.Now},
            new Question(){Id=29,QuestionText="سلام ببخشید گلس در جعبه ی کالا وجود داره؟ چون میگن تا حدودی گلس براش سخت پیدا میشه",CreationDate = DateTime.Now},
            new Question(){Id=30,QuestionText="سلام برای مطالعه و نوشتن خوبه ؟ لگ نداره ؟",CreationDate = DateTime.Now}
        },
                 
             
            Comments=new List<Comment>()
        {

            new Comment(){Id=16,Text="خوب ولی گرون", CreationDate = DateTime.Now},

            new Comment(){Id=17,Text="اقلام جانبی تبلت خیلی گرون است", CreationDate = DateTime.Now},

            new Comment(){Id=18,Text="عالییییییییییه",CreationDate = DateTime.Now},

            new Comment(){Id=19,Text="پیشنهاد میکنم", CreationDate = DateTime.Now},

            new Comment(){Id=20,Text="تخفیف بزارید", CreationDate = DateTime.Now},

            new Comment(){Id=21,Text="لطفا یه قلم معرفی کنید برای این تبلت", CreationDate = DateTime.Now},

            new Comment(){Id=22,Text="سلام ببخشید چه قلمی براش مناسبه ؟", CreationDate = DateTime.Now},

            new Comment(){Id=23,Text="پیشنهاد نمیکنم", CreationDate = DateTime.Now}
        }
        },

        new Product { Id =4 ,Title="Speaker SPI 8040 GTS-1360" ,PhotoPath="/4.jpg"
            ,Questions=new List<Question>()
        {

            new Question(){Id=31,QuestionText="بیس داره !",CreationDate = DateTime.Now},
            new Question(){Id=32,QuestionText="سلام فلش خور هستش؟",CreationDate = DateTime.Now},
            new Question(){Id=33,QuestionText="سلام میکروفون هم بهش وصل میشه؟ برای سخنرانی میخوام",CreationDate = DateTime.Now},
            new Question(){Id=34,QuestionText="وقتی فلش می‌زنیم چطور صدا رو کم و زیاد کنیم ؟",CreationDate = DateTime.Now},
            new Question(){Id=35,QuestionText="میگم من خریدم ولی صداش کم نمیشه چکار کنم؟",CreationDate = DateTime.Now},
            new Question(){Id=36,QuestionText="سلام ببخشید میگم با فلش چی کار می‌کنه که بخوام با فلش کنم؟",CreationDate = DateTime.Now},
            new Question(){Id=37,QuestionText="یه سوال؟رقص نورش رو میشه خاموش کرد؟",CreationDate = DateTime.Now},
            new Question(){Id=38,QuestionText="سلام با این اسپیکر وقتی فیلم بهش با بلوتوث بفرستیم میخونه یا فقط فایل mp3 میخونه؟",CreationDate = DateTime.Now},
            new Question(){Id=39,QuestionText="قیمت چنده",CreationDate = DateTime.Now},
            new Question(){Id=40,QuestionText="سلام وقتی به شارژ متصل میکنم از کجا بدونم شارژش کامل شده یه چراغ قرمز رنگی روشن میشه دوساعته همونه؟",CreationDate = DateTime.Now}
        }


            ,Comments=new List<Comment>()
        {
            new Comment(){Id=24,Text="صدای قابل قبولی داره",CreationDate = DateTime.Now},
            new Comment(){Id=25,Text="خیلی خیلی خیلی خیلی خیلی خیلی خیلی خیلی خوبه خیلی صداش بلنده و فوق العاده است", CreationDate = DateTime.Now},
            new Comment(){Id=26,Text="معمولی بود",CreationDate = DateTime.Now},
            new Comment(){Id=27,Text="معمولی روبه بالا",CreationDate = DateTime.Now},
            new Comment(){Id=28,Text="توصیه میکنم بخریدصداش خوبه رم وفلش خوره ورقص نور هم داره ونسبت به قیمتش سایزش هم بزرگه", CreationDate = DateTime.Now},
            new Comment(){Id=29,Text="نسبت به قیمتش خیلی خوبه ، من یکی گرفته بودم این هفته هم دوتا دیگه گرفتم", CreationDate = DateTime.Now},
            new Comment(){Id=30,Text="نسبت به قیمت واقعا عالی و کاربردیست",CreationDate = DateTime.Now},
            new Comment(){Id=31,Text="تو این قیمت خوبه", CreationDate = DateTime.Now}
        }
        }
    };

    public static List<Menu> Menus = new()
    {
        new Menu()
        {
            DisplayName = "Products",
            Url = "/Products/index"
        },
          new Menu()
        {
            DisplayName = "AddNewProduct",
            Url = "/Products/AddNewProduct"
          }
    };
}


