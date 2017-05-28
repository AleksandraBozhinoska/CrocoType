# CrocoType

Проектна задача по Визуелно Програмирање 

Игра: CROCO TYPE

Професор: др. Дејан Ѓорѓевиќ

Изработиле: Александра Божиноска и Сара Велјаноска

ОПИС НА ИГРА: CrocoType претставува едноставна игра за практицирање на вештините на брзо пишување. Идејата ја добивме од некои слични игри како Typeracer (http://play.typeracer.com/). При стартување на апликацијата се прикажува централно поставена форма со лого на играта и копче за почеток. При почеток на играта се прикажува слика од исплашено дете во левиот долен агол и крокодил кој се придвижува од десниот долен агол налево. Во горниот лев агол се прикажува моменталниот број на освоени поени, а во десниот бројот на животи. На грбот на крокодилот се испишуваат зборови од по 8 букви и целта на играта е играчот да ги испишува генерираните зборови што побргу при што со секој испишан збор се зголемува бројот на поени за еден. Истовремено, при стискање на копчиња од тастатура со погодување на следната буква која треба да се испише таа се прикажува на екранот и на таков начин се следи напредокот во испишување на моментално прикажаниот збор на грбот на крокодилот. При промашување на буква акцијата е проследена само со звучен ефект како (при соодветно погодување на збор исто така се емитува звучен ефект). Со комплетирање на генерираниот збор, нов збор се генерира и се прикажува на грбот на крокодилот. Во СrocoType играчот добива иницијално 3 животи и може да игра додека ги изгуби сите животи, при што му се прикажува освоениот број на поени и две копчиња за одново стартување на играта или крај на истата. Играчот губи живот кога крокодилот се приближува доволно блиску до исплашеното дете за да може да го изеде. Тогаш, во интервал од 50ms сликата на детето се заменува со соодветна слика. Играта завршува кога бројот на животи станува 0.

ИМПЛЕМЕНТАЦИЈА: Играта е имплементирана во програмскиот јазик C#. Зборовите кои се генерираат и прикажуваат на екранот се сместени во датотека која е сместена во проектот на играта и по барање на играчот може да се промени со додавање на нови зборови (words.txt). Користиме 3 различни форми и тоа StartGame - форма која се прикажува кога се стартува играта со копче старт за почеток, Form1 - главна форма, во која се одвиваат сите интеракции и GameOver - форма која се прикажува кога е крај на играта. Најголемиот дел од кодот е организиран во класата GameDoc, а другите делови во кодот на трите форми.

