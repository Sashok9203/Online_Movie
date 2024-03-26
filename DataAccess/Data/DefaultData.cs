﻿using BusinessLogic.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Data
{
	internal static class DefaultData
	{
		public static void Initialize(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Country>().HasData(Countries);
			modelBuilder.Entity<Genre>().HasData(Genres);
			modelBuilder.Entity<StafRole>().HasData(StafRoles);
			modelBuilder.Entity<Quality>().HasData(Qualities);
			modelBuilder.Entity<Premium>().HasData(Premiums);
			modelBuilder.Entity<Staf>().HasData(Stafs);
			modelBuilder.Entity<Feedback>().HasData(Feedbacks);
			modelBuilder.Entity<Movie>().HasData(Movies);
			modelBuilder.Entity<StafMovie>().HasData(StafMovies);
			modelBuilder.Entity<StafStafRole>().HasData(StafStafRoles);
			modelBuilder.Entity<MovieGenre>().HasData(MovieGenres);
			modelBuilder.Entity<Image>().HasData(Images);
		}


		static readonly Feedback[] Feedbacks =
		[
			new() { Id = 1, MovieId = 1, UserId = "d1901b2435594da2a255db13fc57509b", Text="Чудовий фільм",Rating = 4 },
			new() { Id = 2, MovieId = 1, UserId = "c86dc56aedf549f6afe5ceb4d414ebf1" , Text = "Фільм дуже сподобався", Rating = 4 },
			new() { Id = 3, MovieId = 2, UserId = "028582c83a914a45b330b5234f4131fb", Text = "Один з найкащих фільмів", Rating = 4 },
			new() { Id = 4, MovieId = 2, UserId = "eb05f9548a2c4cf8adcc2be7305fc732", Text = "Фільм дуже сподобався", Rating = 5 },
			new() { Id = 5, MovieId = 3, UserId = "eb05f9548a2c4cf8adcc2be7305fc732", Text = "Один з найкащих фільмів", Rating = 5 },
			new() { Id = 6, MovieId = 3, UserId = "d1901b2435594da2a255db13fc57509b", Text = "Фільм дуже сподобався", Rating = 5 },
			new() { Id = 7, MovieId = 4, UserId = "d1901b2435594da2a255db13fc57509b", Text="Чудовий фільм",Rating = 5 },
			new() { Id = 8, MovieId = 4, UserId = "028582c83a914a45b330b5234f4131fb", Text = "Один з найкащих фільмів", Rating = 5 },
			new() { Id = 9, MovieId = 5, UserId = "c86dc56aedf549f6afe5ceb4d414ebf1" , Text = "Фільм дуже сподобався", Rating = 5 },
			new() { Id = 10, MovieId = 5, UserId = "028582c83a914a45b330b5234f4131fb", Text = "Один з найкащих фільмів", Rating = 4 },
		];


		static readonly Image[] Images =
		[
			//Braveheart screeshots
			new() { Id = 1, MovieId = 1, Name = "78f6bd3dff214a149d2b819d2bb2f596.jpg" },
			new() { Id = 2, MovieId = 1, Name = "e8709c9c252c4d0680054104be5d200a.jpg" },
			new() { Id = 3, MovieId = 1, Name = "9d02da5822204216838b18237d0752bc.jpg" },
			new() { Id = 4, MovieId = 1, Name = "cadc26fad170460196200194d40a718a.jpg" },
			new() { Id = 5, MovieId = 1, Name = "9a43056743774ef592a36559134f5be2.jpg" },
			new() { Id = 6, MovieId = 1, Name = "d14d399aa31d45678ad8cb2b317d6d5b.jpg" },
			new() { Id = 7, MovieId = 1, Name = "342c6b26fb544d43914ad1060677b2b8.jpg" },
			//Inception screeshots
			new() { Id = 8,  MovieId = 2, Name = "2d0627d1199a466c8486c07dc446e1b1.jpg" },
			new() { Id = 9,  MovieId = 2, Name = "fc404272f1b34d2e9f887073b58831b9.jpg" },
			new() { Id = 10, MovieId = 2, Name = "3ad737531a5c4b35b0bf99250208badd.jpg" },
			new() { Id = 11, MovieId = 2, Name = "c0299b7d354d4aa79f21d7e7b49519a5.jpg" },
			new() { Id = 12, MovieId = 2, Name = "978e2ab0753c4161bbd7f3af865df208.jpg" },
			new() { Id = 13, MovieId = 2, Name = "80c0e4e646d8435e9d7a4e9211a3be96.jpg" },
			new() { Id = 14, MovieId = 2, Name = "3484dbfface144648621281a62b40d81.jpg" },

			//Shutter Island screeshots
			new() { Id = 15,  MovieId = 3, Name = "9c5c4b7d933b436fa7ff5f8971d7ffb6.webp" },
			new() { Id = 16,  MovieId = 3, Name = "05c1fa41bf324157a1df9c1eb6f556e4.webp" },
			new() { Id = 17, MovieId = 3, Name = "bc68599bf067498bba00894694b36a41.webp" },
			new() { Id = 18, MovieId = 3, Name = "fc1dfd25a97646ea8576c6785666dcc5.webp" },

			//Prince of Persia screeshots
			new() { Id = 19,  MovieId = 4, Name = "4fc5360c83e548b5bda7db0d237ea701.webp" },
			new() { Id = 20,  MovieId = 4, Name = "cc3b110a147a4bef9a04598974409199.webp" },
			new() { Id = 21, MovieId = 4, Name = "6f91954d9fd949f690f4d9f8bba4bc0d.webp" },
			new() { Id = 22, MovieId = 4, Name = "e97a5e1f56ab443f9484bd52fcd38325.webp" },

			//Sherlock Holmes a screeshots
			new() { Id = 23,  MovieId = 5, Name = "8eda6b7d745644229ef6ea0830fa4034.webp" },
			new() { Id = 24,  MovieId = 5, Name = "88acda2dbc9741a08fcc66a288edf169.webp" },
			new() { Id = 25, MovieId = 5, Name = "3b4eed90465840c78b5160d8613b4350.webp" },
			new() { Id = 26, MovieId = 5, Name = "bc68599bf067498bba00894694b36a412.webp" },



		];

		
		static readonly MovieGenre[] MovieGenres =
		[
			new() { Id = 1, MovieId = 1, GenreId = 18 },
			new() { Id = 2, MovieId = 1, GenreId = 4 },
			new() { Id = 3, MovieId = 1, GenreId = 2 },
			new() { Id = 4, MovieId = 2, GenreId = 1 },
			new() { Id = 5, MovieId = 2, GenreId = 7 },
			new() { Id = 6, MovieId = 2, GenreId = 2 },
			new() { Id = 7, MovieId = 3, GenreId = 20 },
			new() { Id = 8, MovieId = 3, GenreId = 9 },
			new() { Id = 9, MovieId = 3, GenreId = 4 },
			new() { Id = 10, MovieId = 4, GenreId = 2 },
			new() { Id = 11, MovieId = 4, GenreId = 1 },
			new() { Id = 12, MovieId = 4, GenreId = 6 },
			new() { Id = 13, MovieId = 4, GenreId = 8 },
			new() { Id = 14, MovieId = 5, GenreId = 9 },
			new() { Id = 15, MovieId = 5, GenreId = 2 },
			new() { Id = 16, MovieId = 5, GenreId = 1 },
			new() { Id = 17, MovieId = 5, GenreId = 10 },
			new() { Id = 18, MovieId = 5, GenreId = 20 },

		];


		static readonly StafStafRole[] StafStafRoles =
		[
			new() { Id = 1, StafRoleId = 1, StafId = 1 },
			new() { Id = 2, StafRoleId = 2, StafId = 1 },
			new() { Id = 3, StafRoleId = 4, StafId = 1 },
			new() { Id = 4, StafRoleId = 2, StafId = 2 },
			new() { Id = 5, StafRoleId = 2, StafId = 3 },
			new() { Id = 6, StafRoleId = 1, StafId = 4 },
			new() { Id = 7, StafRoleId = 2, StafId = 5 },
			new() { Id = 8, StafRoleId = 2, StafId = 6 },
			new() { Id = 9, StafRoleId = 2, StafId = 7 },
			new() { Id = 10, StafRoleId = 2, StafId = 8 },
			new() { Id = 11, StafRoleId = 2, StafId = 9 },
			new() { Id = 12, StafRoleId = 2, StafId = 10 },
			new() { Id = 13, StafRoleId = 1, StafId = 11 },
			new() { Id = 14, StafRoleId = 2, StafId = 12 },
			new() { Id = 16, StafRoleId = 1, StafId = 12 },
			new() { Id = 17, StafRoleId = 2, StafId = 13 },
			new() { Id = 18, StafRoleId = 2, StafId = 14 },
			new() { Id = 19, StafRoleId = 1, StafId = 15 },
			new() { Id = 20, StafRoleId = 2, StafId = 16 },
			new() { Id = 21, StafRoleId = 2, StafId = 17 },
			new() { Id = 22, StafRoleId = 2, StafId = 18 },
			new() { Id = 23, StafRoleId = 2, StafId = 19 },
			new() { Id = 24, StafRoleId = 1, StafId = 20 },
			new() { Id = 25, StafRoleId = 2, StafId = 21 },
			new() { Id = 26, StafRoleId = 2, StafId = 22 },
			new() { Id = 27, StafRoleId = 2, StafId = 23 },
			new() { Id = 28, StafRoleId = 2, StafId = 24 },

		];

		static readonly StafMovie[] StafMovies =
		[
			new() { Id = 1, MovieId = 1, StafId = 1 },
			new() { Id = 2, MovieId = 1, StafId = 2 },
			new() { Id = 3, MovieId = 1, StafId = 3 },
			//Inception staf
			new() { Id = 4, MovieId = 2, StafId = 4 },
			new() { Id = 5, MovieId = 2, StafId = 5 },
			new() { Id = 6, MovieId = 2, StafId = 6 },
			new() { Id = 7, MovieId = 2, StafId = 7 },
			new() { Id = 8, MovieId = 2, StafId = 8 },
			new() { Id = 9, MovieId = 2, StafId = 9 },
			new() { Id = 10, MovieId = 2, StafId = 10 },
			//Shutter Island staf
			new() { Id = 11, MovieId = 3, StafId = 5 },
			new() { Id = 12, MovieId = 3, StafId = 11 },
			new() { Id = 13, MovieId = 3, StafId = 12 },
			new() { Id = 14, MovieId = 3, StafId = 13 },
			new() { Id = 15, MovieId = 3, StafId = 14 },
			//Prince of Persia staf
			new() { Id = 16, MovieId = 4, StafId = 13 },
			new() { Id = 17, MovieId = 4, StafId = 15 },
			new() { Id = 18, MovieId = 4, StafId = 16 },
			new() { Id = 19, MovieId = 4, StafId = 17 },
			new() { Id = 20, MovieId = 4, StafId = 18 },
			//Sherlok Holms staf
			new() { Id = 21, MovieId = 5, StafId = 19 },
			new() { Id = 22, MovieId = 5, StafId = 20 },
			new() { Id = 23, MovieId = 5, StafId = 21 },
			new() { Id = 24, MovieId = 5, StafId = 22 },
			new() { Id = 25, MovieId = 5, StafId = 23 },
			new() { Id = 26, MovieId = 5, StafId = 24 },
		];


		static readonly Movie[] Movies =
		[
			new()
			{
				Id = 1,
				Name = "Хоробре серце",
				OriginalName = "Braveheart",
				Description = "Фільм, що розповідає про боротьбу Шотландського королівства за незалежність проти англійського панування. Головний герой фільму — Вільям Воллес, ватажок шотландців, у виконанні Мела Гібсона.одії фільму починаються 1280 року. Це історія легендарного національного шотландського героя Вільяма Воллеса, який присвятив себе боротьбі з англійцями за часів короля Едуарда Довгоногого. Вільям рано втратив батька, що загинув від рук англійців, але його дядько зумів дати хлопцеві навчання в Європі. На батьківщину Вільям повертається вже дорослим чоловіком, що мріє завести родину і жити мирним життям. Та доля вирішила інакше. Його наречену вбили англійці, і він почав свій «хрестовий похід» за свободу.",
				Poster = "82ff372d46f44895af282106fe13a201.jpg",
				CountryId = 2,
				Date = new DateTime(1995, 4, 25,2,57,0),
				QualityId = 3,
				MovieUrl = @"https://pixel.stream.voidboost.cc/52806ed4b4d47c4a8297f9e4983a9659:2024022221:4c97894d-562e-4330-9154-0facb485bda1/7/8/1/6/3/byf31.mp4",
				TrailerUrl = @"https://www.youtube.com/watch?v=277chVHPQSA&t=39s",
				PremiumId = 1
			},
			new()
			{
				Id = 2,
				Name = "Початок",
				OriginalName = "Inception",
				Description = "Ми звикли, що в нашому розумінні злодій - це людина здатна вкрасти якісь цінності або гроші. Сюжет фантастичного бойовика «Початок» розповідає про злодіїв здатних вкрасти ідею прямо у людини з підсвідомості. Одним з таких є головний герой фільму Домінік Кобб. Після того як його дружина померла, він змушений ховатися, і не може навіть повернутися в країну, щоб побачити дітей. Якось раз Кобб отримує дуже неординарне замовлення: йому потрібно не вкрасти, а навпаки впровадити нову ідею в підсвідомість людини. Домініку не надто хотітися братися за цю справу, але замовник в обмін пропонує можливість повернутися додому. Заручившись підтримкою професіоналів цієї справи, Кобб починає розробляти план як все провернути. Все потрібно дуже добре продумати, адже злодіям доведеться відтворити багатошарову реальність в підсвідомості об'єкта, в результаті чого межі можуть почати стиратися.",
				Poster = "7d4159900afd4481881c42483b369f3e.jpeg",
				CountryId = 2,
				Date = new DateTime(2010, 7, 22, 2, 28, 0),
				QualityId = 2,
				MovieUrl = @"https://aura.stream.voidboost.cc/e86eaadc35a0ecfb807054393e269605:2024022217:a95fa9f9-d7d0-4039-ad6f-4e785486da15/5/9/1/7/7/to9f8.mp4",
				TrailerUrl = @"https://www.youtube.com/watch?v=85Zz1CCXyDI",
				PremiumId = 2
			},
		
			new()
			{
				Id = 3,
				Name = "Острів проклятих",
				OriginalName = "Shutter Island",
				Description = "Фільм «Острів проклятих» - психологічний ретро-трилер, знятий за романом письменника і кіносценариста Денніса Ліхейна.\r\n\r\n1954 рік. Два бостонських федеральних маршала - досвідчений Тедді Деніелс і нещодавно переведений з Сіетла Чак Аулі - пливуть на острів Шаттер (Острів проклятих). Там знаходиться психлікарня, яка добре охороняється а порядками нагадує в'язницю, куди поміщені божевільні злочинці. Незважаючи на охорону, замки і справну сигналізацію з режимної лікарні примудрилася втекти особливо небезпечна божевільна - Рейчел Соландо, яка в божевіллі втопила своїх дітей.\r\n\r\nНа ділі для Деніелса це відрядження - лише привід відвідати каземати для божевільних: на острові міститься піроман Ендрю Леддіс, винуватець загибелі дружини маршала. Знайти його і утікачку Рейчел - ось завдання для Деніелса, проте розслідування чиновників наштовхується на опір двох завідуючих лікарнею і всього медперсоналу. У їхніх діях змученому головним болем федеральному маршалу починає бачитися якась змова, яка заважає розпочатому розслідуванню.",
				Poster = "9c5c4b7d933b436fa7ff5f8971d7ffb6.jpg",
				CountryId = 2,
				Date = new DateTime(2010, 2, 13,2,18,0),
				QualityId = 3,
				MovieUrl = @"https://pixel.stream.voidboost.cc/52806ed4b4d47c4a8297f9e4983a9659:2024022221:4c97894d-562e-4330-9154-0facb485bda1/7/8/1/6/3/byf31.mp4",
				TrailerUrl = @"https://www.youtube.com/watch?v=1jERdYDWG8g",
				PremiumId = 2
			},

			new()
			{
				Id = 4,
				Name = "Принц Персії:Піски часу",
				OriginalName = "Prince of Persia: The Sands of Time",
				Description = "Фільм 'Принц Персії: Піски часу' - пригодницький бойовик від режисера Майка Н'юелла, знятий за мотивами однойменної комп'ютерної гри. Головний герой фільму - Дастан. Одного разу в юнацькому віці він рятує від смерті свого кращого друга, якого впіймали вартові за злодійство, тим самим, мимоволі демонструючи свої дивовижні навички та хоробрість, перед королем Персії, який випадково опинився поруч, Захопившись настільки цінними задатками хлопчика, правитель робить юнака одним зі своїх приймачів, і з перших же днів починає навчати його військовому ремеслу.",
				Poster = "d4cfbb16be9b4ae384a612d336e18bdb.webp",
				CountryId = 2,
				Date = new DateTime(2010, 6, 3, 1, 56, 0),
				QualityId = 2,
				MovieUrl = @"https://aura.stream.voidboost.cc/e86eaadc35a0ecfb807054393e269605:2024022217:a95fa9f9-d7d0-4039-ad6f-4e785486da15/5/9/1/7/7/to9f8.mp4",
				TrailerUrl = @"https://www.youtube.com/watch?v=WcN_kcbSsMU",
				PremiumId = 1
			},

			new()
			{
				Id = 5,
				Name = "Шерлок Холмс: Гра тіней",
				OriginalName = "Sherlock Holmes: A Game of Shadows",
				Description = "Шерлок Холмс знову береться за справу, після того як трапляється серія терактів у Відні і Страсбурзі, які на думку уряду влаштували анархісти. До всього іншого, в Європі відбувається серія вбивств, які з боку здаються ніяк не пов'язаними між собою. Однак Холмса не так просто провести, і вивчивши всі докази, він розуміє, що це справа рук професора Моріарті - злого генія і його давнього ворога.\r\nДоктор Ватсон тільки одружився, і дуже цьому радий, і більше не бажає брати участь в справах свого друга детектива. Однак завдяки збігу обставин, вони все ж об'єднують свої зусилля, і відправляються на пошуки Моріарті, щоб зруйнувати підступні плани злого професора.",
				Poster = "3d1d88ddddaa4dafaad6da31477b6ef6.webp",
				CountryId = 2,
				Date = new DateTime(2011, 12, 16,2,9,0),
				QualityId = 3,
				MovieUrl = @"https://pixel.stream.voidboost.cc/52806ed4b4d47c4a8297f9e4983a9659:2024022221:4c97894d-562e-4330-9154-0facb485bda1/7/8/1/6/3/byf31.mp4",
				TrailerUrl = @"https://www.youtube.com/watch?v=wvKznq9CUuY",
				PremiumId = 2
			},

			
		];



		static readonly Staf[] Stafs =
		[
			new()
			{
				Id = 1,
				Name = "Мел",
				Surname = "Гибсон",
				Description = "Народився 3 січня 1956 року.\r\n\r\nСин ірландців-католиків Гаттона Гібсона та Ен Райлі Гібсон, яка народилася в парафії Колм-Кіллє графства Лонгфорд, Ірландія. Його бабця по батькові Ева Майлот була австралійською оперною співачкою. Мел народився у місті Пікскілл (округ Вестчестер, штат Нью-Йорк) і був шостим з одинадцяти дітей. Один із молодших братів Мела, Донал, також актор.",
				ImageName = "d5d49574945f45c8be24f00cc02923af.webp",
				CountryId = 2,
				Birthdate = new DateTime(1956, 1, 3),
				IsOscar = true
			},
			new()
			{
				Id = 2,
				Name = "Енгус",
				Surname = "Макфадьєн",
				Description = "Народився у сім'ї лікаря. У дитинстві подорожував між трьома країнами — Філіппінами, Сингапуром і Францією. Вищу освіту Енгус отримав у стінах Університету Единбурга, Шотландія. Паралельно з гризенням граніту науки молодий чоловік відвідував заняття в Центральній школі Мовлення та Драми в Лондоні, Англія.",
				ImageName = "da0240d0882b4ec1942342ec6cf72505.jpg",
				CountryId = 21,
				Birthdate = new DateTime(1963, 9, 21),
				IsOscar = false
			},
			new()
			{
				Id = 3,
				Name = "Софі",
				Surname = "Марсо",
				Description = "Народилася 17 листопада 1966 року в Париж, Франція.\r\n\r\nПрославилася підлітком, дебютувавши у «Вечірці» (La Boum, 1980). Вдало знайдений образ «ідеальної французької дівчини», якою Марсо визнали за підсумками глядацького опитування, було розмножено у фільмах «Вечірка-2» (фр. La Boum 2, 1982), «Щасливого Великодня» (1984), «Студентка» (1988), «Аромат кохання. Фанфан» (1993) тощо. Актрису часто залучали до найамбітніших проектів національної кіноіндустрії: «Форт Саґан», «Шуани!», «Дочка Д'Артаньяна», де вона втілювала ідеальну француженку, перетворившись із чарівного підлітка на одну з найкрасивіших актрис світового кіно.\r\n\r\n1999 року зіграла дівчину Бонда у черговому, 19-му за ліком, епізоді Бондіани — підступну, але дуже вразливу Електру Кінґ. Продовжує активно зніматися.",
				ImageName = "c9b0972dd8b6431193cd50e9c272416f.jpg",
				CountryId = 8,
				Birthdate = new DateTime(1966, 11, 17),
				IsOscar = false
			},
			new()
			{
				Id = 4,
				Name = "Крістофер",
				Surname = "Нолан",
				Description = "Крістофер Джонатан Джеймс Нолан - англійський кінорежисер, сценарист і продюсер, який має британське і американське громадянства.[3][4][5] Його 12 фільмів були схвально прийняті світовою кінокритикою та зібрали понад 4 млрд доларів касових зборів, що робить його одним з найуспішніших режисерів сучасності.\r\n\r\nОтримав перше визнання після виходу психологічного трилера Мементо (2000), композиція якого побудована на викривленнях часу. Це дало йому змогу зняти високобюджетний трилер Безсоння (2002) та драму Престиж (2006). Подальший успіх режисерові принесли трилогія Темний лицар (2005—2012), фільм про проникання в чужі сни Початок (2010), науково-фантастичний фільм Інтерстеллар (2014), військову драму Дюнкерк (2017) та науково-фантастичний бойовик Тенет (2020).",
				ImageName = "2dbb31f7096740559fba2c8a22a870b2.jpg",
				CountryId = 22,
				Birthdate = new DateTime(1970, 7, 30),
				IsOscar = false
			},
			new()
			{
				Id = 5,
				Name = "Леонардо",
				Surname = "Ді Капріо",
				Description = "Леона́рдо Вільгельм Ді Ка́пріо (англ. Leonardo Wilhelm DiCaprio; нар. 11 листопада 1974, Лос-Анджелес, США) — американський актор, кінопродюсер. Лауреат премії «Оскар» за найкращу чоловічу роль у фільмі «Легенда Г'ю Гласса» (2016), та нагороди BAFTA і Гільдії кіноакторів США за виконання ролі Г'ю Гласса. Лауреат трьох премій «Золотий глобус» у категорії «Найкращий актор в драматичній картині» і «Найкращий актор — комедія або мюзикл» за головні ролі в картинах «Авіатор», «Вовк з Уолл-стріт» і «Легенда Г'ю Гласса». Лауреат нагороди Берлінського кінофестивалю «Срібний ведмідь» в категорії «Найкращий актор» за виконання ролі Ромео Монтеккі в картині «Ромео + Джульєтта».\r\n\r\nПовноцінну акторську кар'єру почав в шістнадцять років на початку 1990-х років. У 2000-х роках отримав визнання публіки і критиків за роботу в широкому діапазоні кіно і акторську майстерність.",
				ImageName = "1d4e8a9fea6146a887c774ffa2db33d7.jpg",
				CountryId = 2,
				Birthdate = new DateTime(1974, 11, 11),
				IsOscar = true
			},

			new()
			{
				Id = 6,
				Name = "Том",
				Surname = "Харді",
				Description = "Едвард Томас Гарді (англ. Edward Thomas Hardy) (нар. 15 вересня 1977, Гаммерсміт, Лондон, Велика Британія), знаніший як Том Гарді (англ. Tom Hardy) — британський актор театру та кіно, відомий за головною роллю у фільмі «Бронсон» (2009), а також завдяки участі в голлівудських блокбастерах «Зоряний шлях: Відплата» (2002), «Початок» (2010), «Воїн» (2011) та «Темний лицар повертається» (2012), «Шалений Макс: Дорога гніву» (2015), «Легенда Г'ю Гласса» (2015)",
				ImageName = "42713c2fa8b64141a74b4fa6b3d05a0c.jpg",
				CountryId = 20,
				Birthdate = new DateTime(1977, 9, 15),
				IsOscar = false
			},
			new()
			{
				Id = 7,
				Name = "Маріон",
				Surname = "Котіяр",
				Description = "Маріо́н Котія́р (фр. Marion Cotillard; нар. 30 вересня 1975, Париж, Франція) — французька акторка театру, телебачення та кіно. Володарка премій Оскар, Золотий глобус та BAFTA. Кавалерка та офіцерка ордена мистецтв та літератури.\r\n\r\nЗа роль у стрічці «Довгі заручини» (2004) отримала премію «Сезар» у номінації «Найкраща акторка другого плану». 2008 року удостоєна премії «Оскар» у номінації «Найкраща акторка» за фільм «Життя у рожевому кольорі», в якому виконала роль Едіт Піаф. Маріон Котіяр стала другою акторкою, що здобула премію «Оскар» за роль у фільмі іноземною мовою. Раніше цей рекорд утримувала Софі Лорен, володарка «Оскар» 1962 року. Також за фільм «Життя у рожевому кольорі» Котіяр отримала премію «Золотий глобус» у номінації «Найкраща жіноча роль (комедія або мюзикл)» і премію Британської академії телебачення та кіномистецтва (BAFTA) у номінації «Найкраща акторка».",
				ImageName = "a9141daeb1e04aff947474ad3f2d07d7.jpg",
				CountryId = 8,
				Birthdate = new DateTime(1975, 9, 30),
				IsOscar = true
			},
			new()
			{
				Id = 8,
				Name = "Майкл",
				Surname = "Кейн",
				Description = "Сер Мо́ріс Джо́зеф Міклвайт (англ. Sir Maurice Joseph Micklewhite), відоміший за акторським (артистичним) псевдонімом як Майкл Кейн (англ. Michael Caine, народився 14 березня 1933 в Лондоні) — один з найпопулярніших британських акторів (знявся більш ніж у 100 фільмах). Це один з двох акторів (другий — Джек Ніколсон), який був номінований на премію «Оскар» у 1960-х, 1970-х, 1980-х, 1990-х та 2000-х роках.",
				ImageName = "7adf0a94c3da4d8ea8809a79c6ea3eda.jpg",
				CountryId = 20,
				Birthdate = new DateTime(1933, 3, 14),
				IsOscar = true
			},
			new()
			{
				Id = 9,
				Name = "Кілліан",
				Surname = "Мерфі",
				Description = "Кілліан Мерфі (англ. Cillian Murphy; нар. 25 травня 1976, Дуглас, графство Корк, Ірландія) — ірландський актор театру і кіно. Колишній співак, гітарист та автор пісень гурту The Sons of Mr. Green Genes. Наприкінці 90-х почав свою акторську кар'єру граючи на сцені, в короткометражних та незалежних фільмах. Свою першу помітну роль він зіграв у фільмі \"28 днів потому\" (2002), в чорній комедії \"Розрив\" (2003), в трилері \"Нічний рейс\" (2005). Також зіграв ірландську жінку-трансвестита в комедійній драмі \"Сніданок на Плутоні\" (2005), за що був номінований на премію Золотий глобус в категорії \"найкращий актор в мюзиклі або комедії\". З 2013 по 2022 знімався у кримінально-драматичному серіалі \"Гострі картузи\", де зіграв Томаса Шелбі.",
				ImageName = "f39d0a89af744d498bc8aac540fefe4d.jpg",
				CountryId = 23,
				Birthdate = new DateTime(1976, 5, 25),
				IsOscar = true
			},
			new()
			{
				Id = 10,
				Name = "Джозеф",
				Surname = "Гордон-Левітт",
				Description = "Джозеф Леонард Гордон-Левітт (англ. Joseph Leonard Gordon-Levitt; нар. 17 лютого 1981, Лос-Анджелес, Каліфорнія, США) — американський актор, режисер, сценарист та продюсер. Отримав популярність завдяки ролі Томмі Соломона у комедійному серіалі «Третя планета від Сонця» (1996—2001), а також фільмам «Цеглина» (2005), «500 днів літа» (2009), «Початок» (2010), «Темний лицар повертається» (2012) та «Петля часу».",
				ImageName = "7d4159900afd4481881c42483b369f3e.jpg",
				CountryId = 2,
				Birthdate = new DateTime(1981, 2, 17),
				IsOscar = false
			},

			new()
			{
				Id = 11,
				Name = "Мартін",
				Surname = "Скорсезе",
				Description = "Aмериканський кінорежисер, сценарист, продюсер та історик кіно, знаний також під зменшувальним ім'ям Марті.\r\n\r\nВін є засновником «Світового фонду кіно» та лауреатом премії Американського інституту кіномистецтва за внесок у кінематограф. Скорсезе є також лауреатом численних премій, серед яких «Оскар», «Золотий глобус», БАФТА та премія Гільдії кінорежисерів Америки.",
				ImageName = "787ac3b0103c491fbf323f6830551bd4.webp",
				CountryId = 2,
				Birthdate = new DateTime(1942, 11, 17),
				IsOscar = true
			},

			new()
			{
				Id = 12,
				Name = "Mapk",
				Surname = "Руффало",
				Description = "Aмериканський актор, режисер, сценарист і продюсер. Народився в Кеноші, Вісконсін, США. Повне ім'я — Марк Алан Руффало. \r\n\r\nБатько Марка — художник, мати — перукар. Окрім Марка в сім'ї було ще троє дітей. Дитинство Руффало пройшло у Вісконсіні, а пізніше — в Сан-Дієго. Закінчивши школу, Марк вчився в Консерваторії Стелли Адлер у Лос- Анджелесі",
				ImageName = "7bb3ad83cc8f486296ad7953dcdc8985.jpg",
				CountryId = 2,
				Birthdate = new DateTime(1967, 11, 22),
				IsOscar = true
			},

			new()
			{
				Id = 13,
				Name = "Бен",
				Surname = "Кінґслі",
				Description = "Бен Кінґслі народився 31 грудня 1943 року в Скарборо, графство Йоркшир. Батько — лікар індійського походження з острова Занзібар (Танзанія), мати — британська акторка та модель російського єврейського походження. Свою кар'єру почав з театральної сцени. За порадою батька взяв сценічний псевдонім. Із 1967 член трупи Королівського Шекспірівського театру. Перша роль у кіно — у фільмі «Страх - це ключ» (1972). Після цього знімається в телесеріалах. У 1982 зіграв у картині Річарда Аттенборо «Ганді», за роль у якій отримав премію «Оскар».",
				ImageName = "8302c710ae0c4ff2aa68c7d41d4ea795.jpg",
				CountryId = 20,
				Birthdate = new DateTime(1943, 1, 31),
				IsOscar = true
			},

			new()
			{
				Id = 14,
				Name = "Мішель",
				Surname = "Вільямс",
				Description = "Американська акторка телебачення, театру та кіно, кінорежисерка.Народилась у місті Каліспелл (штат Монтана, США)[6] в сім'ї домогосподарки Карли Свенсон та трейдера Ларрі Вільямса[7][8]. Має норвезькі корені[9]. Коли їй було 9, сім'я переїхала до Сан-Дієго, й дівчинка стала цікавитись акторським мистецтвом.",
				ImageName = "238f660b10ed449bbca6bf5ab913a457.jpg",
				CountryId = 2,
				Birthdate = new DateTime(1980, 9, 9),
				IsOscar = true
			},

			new()
			{
				Id = 15,
				Name = "Майк",
				Surname = "Ньюелл",
				Description = "Англійський режисер і продюсер кіно і телебачення. Він отримав премію BAFTA за найкращу режисуру за фільм «Чотири весілля і похорон», який також отримав премію BAFTA за найкращий фільм, а також зняв фільми «Донні Браско» та «Гаррі Поттер і келих вогню».",
				ImageName = "65f199489b9a4e84aed0428cb9d5621c.jpg",
				CountryId = 20,
				Birthdate = new DateTime(1942, 3, 28),
				IsOscar = false
			},

			new()
			{
				Id = 16,
				Name = "Джейк",
				Surname = "Джилленгол",
				Description = "Американський актор, номінант на премію «Оскар» у 2006 році, лауреат премії BAFTA. Син режисера Стівена Джилленгола і сценаристки Наомі Фонер, молодший брат актриси Меггі Джилленгол.Народився 19 грудня 1980 року в Лос-Анджелес, США. Син режисера Стівена Джилленгола і сценаристки Наомі Фонер. Мати Джилленгола — єврейка, яка народилася в сім'ї іммігрантів зі Східної Європи (Латвія та Польща).",
				ImageName = "05c1fa41bf324157a1df9c1eb6f556e4.jpg",
				CountryId = 2,
				Birthdate = new DateTime(1980, 12, 19),
				IsOscar = true
			},

			new()
			{
				Id = 17,
				Name = "Джемма",
				Surname = "Артертон",
				Description = "Aнглійська акторка, найвідоміші ролі у фільмах «Квант милосердя» (2008), «Битва титанів» (2010), «Принц Персії: піски часу» (2009), «Тамара і секс» (2010) та «Мисливці за відьмами» (2013).Народилася 2 лютого 1986 в Грейвсенді, графство Кент, Велика Британія. Її мати Саллі-Енн була прибиральницею, а батько Баррі Артертон зварювальником.[5] Молодша сестра Ханна Джейн Артертон. Артертон народилася зі шістьма пальцями на кожній руці,полідактилія була усунена хірургічним методом ще в дитинстві",
				ImageName = "b0b532cb865a4271a6de3352c6c70cf1.jpg",
				CountryId = 20,
				Birthdate = new DateTime(1986, 2, 2),
				IsOscar = true
			},

			new()
			{
				Id = 18,
				Name = "Тобі",
				Surname = "Кеббелл",
				Description = "Aнглійський кіно- та телеактор, відомий за ролями у фільмах «Олександр», «Рок-н-рольник», «Принц Персії: Піски часу», «Учень чаклуна», «Бойовий кінь» та «Бен-Гур».",
				ImageName = "4a3a7e7116614e4d990abf7e9cb94438.jpg",
				CountryId = 20,
				Birthdate = new DateTime(1982, 7, 9),
				IsOscar = false
			},

			new()
			{
				Id = 19,
				Name = "Роберт",
				Surname = "Дауні (молодший)",
				Description = "Aмериканський актор, продюсер і музикант. Став широко відомий після релізу байопіку «Чаплін», в якому виконав головну роль коміка Чарлі Чапліна. Лауреат премії «Оскар» (2024), триразовий лауреат «Золотого глобуса» (2001, 2010, 2024), дворазовий володар премії BAFTA (1993, 2024). Почав акторську кар'єру ще дитиною, зігравши у фільмі свого батька «Загін» (1970). Ближче до початку 1990-х Дауні став популярним актором, зокрема, завдяки ролям у фільмах «Ейр Америка» (1990), «Велика піна» (1991) і «Природжені вбивці» (1994). Найбільш відомою й успішною роллю Роберта в XX столітті вважається роль Чарлі Чапліна в однойменному байопіку Річарда Аттенборо, що принесла йому премію BAFTA і першу номінацію на «Оскар».",
				ImageName = "4e36bbaa11564827bb141b4db1b5238b.jpg",
				CountryId = 2,
				Birthdate = new DateTime(1965, 4, 4),
				IsOscar = false
			},

			new()
			{
				Id = 20,
				Name = "Ґай",
				Surname = "Річі",
				Description = "Народився у Гатфілді, графстві Гартфордшир. У віці п'ятнадцяти років покинув школу і почав працювати посильним. Сертифікат про середню освіту Річі отримав пізніше. Мріяв стати режисером, проте в кіношколу йти не збирався, бо, на його думку, вона „плодить нудних, одноманітних кінорежисерів“, тому намагався навчатись самостійно. Спочатку знімав рекламні і музичні кліпи. Після перших успіхів, заробивши трохи грошей, поставив свою першу короткометражну стрічку «Важка справа» (1995). Того ж року написав сценарій до свого наступного фільму, але фінансування для нього вдалось знайти тільки за три роки, за допомогою фірми «Поліграм».",
				ImageName = "6cf090472b844901b58aa971368e3b51.jpg",
				CountryId = 20,
				Birthdate = new DateTime(1968, 9, 10),
				IsOscar = false
			},
			new()
			{
				Id = 21,
				Name = "Джуд",
				Surname = "Лоу",
				Description = "Британський кіноактор і театральний актор. Дворазовий номінант на премію «Оскар» (2000, 2004), чотириразовий — на премію «Золотий глобус». Найбільшу популярність отримав після фільмів «Талановитий містер Ріплі» (1999, премія БАФТА за найкращу чоловічу роль другого плану), «Холодна гора» (2003, номінації на «Оскар» і «Золотий глобус»), «Близькість» (2004).",
				ImageName = "06c07b4b9d9e493f8141626f1ce4e4ec.jpg",
				CountryId = 20,
				Birthdate = new DateTime(1972, 12, 29),
				IsOscar = true
			},
			new()
			{
				Id = 22,
				Name = "Джаред",
				Surname = "Гарріс",
				Description = "Гарріс народився у Лондоні, він є одним з трьох синів ірландського актора Річарда Гарріса і його першої дружини, уельської актриси Елізабет Ріс-Вільямс. Його молодший брат актор Джеймі Гарріс, старший — режисер Деміан Гарріс. З 1971 по 1975 актор Рекс Гаррісон був одружений з його матір'ю. В 1984 він отримав бакалавр витончених мистецтв (Bachelor of Fine Arts, BFA) в Дюкському університеті.",
				ImageName = "1bb5b31e95fb4d8d9b835793a946b34d.jpg",
				CountryId = 20,
				Birthdate = new DateTime(1961, 8, 24),
				IsOscar = false
			},
			new()
			{
				Id = 23,
				Name = "Рейчел",
				Surname = "МакАдамс",
				Description = "Гарріс народився у Лондоні, він є одним з трьох синів ірландського актора Річарда Гарріса і його першої дружини, уельської актриси Елізабет Ріс-Вільямс. Його молодший брат актор Джеймі Гарріс, старший — режисер Деміан Гарріс. З 1971 по 1975 актор Рекс Гаррісон був одружений з його матір'ю. В 1984 він отримав бакалавр витончених мистецтв (Bachelor of Fine Arts, BFA) в Дюкському університеті.",
				ImageName = "a6d715ddc91e47b1a5f5fbaa514b1358.jpg",
				CountryId = 20,
				Birthdate = new DateTime(1978, 11, 17),
				IsOscar = false
			},
			new()
			{
				Id = 24,
				Name = "Нумі",
				Surname = "Рапас",
				Description = "Шведська актриса, найбільш відома за головною роллю у шведсько-данській-німецько-норвезькій екранізації трилогії Стіґа Ларссона «Міленіум»: «Дівчина з татуюванням дракона», «Дівчина, яка грала з вогнем» і «Дівчина, яка підривала повітряні замки». У 2011 році вона зіграла одну з головних ролей у фільмі «Шерлок Холмс: Гра тіней».",
				ImageName = "7ddc87bfddd4183a366b371fa3d57d8.jpg",
				CountryId = 18,
				Birthdate = new DateTime(1979, 12, 28),
				IsOscar = false
			},

		];

		static readonly Premium[] Premiums =
		[
			new() { Id = 1, Name = "Free",Rate = 0 },
			new() { Id = 2, Name = "Light", Rate = 20 },
			new() { Id = 3, Name = "Midle", Rate = 40 },
			new() { Id = 5, Name = "Full", Rate = 60 },
		];

		static readonly Quality[] Qualities =
		[
			new() { Id = 1, Name = "Web-DL" },
			new() { Id = 2, Name = "1080p" },
			new() { Id = 3, Name = "720p" },
			new() { Id = 5, Name = "480p" },
			new() { Id = 6, Name = "2K" },
			new() { Id = 7, Name = "4K" },
			new() { Id = 8, Name = "8K" }
		];

		static readonly Country[] Countries =
		[
		    new() { Id = 1, Name = "Україна" },
			new() { Id = 2, Name = "США" },
			new() { Id = 3, Name = "Китай" },
			new() { Id = 4, Name = "Індія" },
			new() { Id = 5, Name = "Бразилія" },
			new() { Id = 6, Name = "Німеччина" },
			new() { Id = 7, Name = "Японія" },
			new() { Id = 8, Name = "Франція" },
			new() { Id = 9, Name = "Канада" },
			new() { Id = 10, Name = "Італія" },
			new() { Id = 11, Name = "Австралія" },
			new() { Id = 12, Name = "Іспанія" },
			new() { Id = 13, Name = "Мексика" },
			new() { Id = 14, Name = "Південна Корея" },
			new() { Id = 15, Name = "Індонезія" },
			new() { Id = 16, Name = "Нідерланди" },
			new() { Id = 17, Name = "Польща" },
			new() { Id = 18, Name = "Швеція" },
			new() { Id = 19, Name = "Швейцарія" },
			new() { Id = 20, Name = "Британія" },
			new() { Id = 21, Name = "Шотландія" },
			new() { Id = 22, Name = "Англія" },
			new() { Id = 23, Name = "Ірландія" }
		];
		static readonly StafRole[] StafRoles =
		[
			new() { Id = 1, Name = "Режисер" },
			new() { Id = 2, Name = "Актор" },
			new() { Id = 3, Name = "Оператор" },
			new() { Id = 4, Name = "Продюсер" },
			new() { Id = 5, Name = "Автор сценарію" },
		];

		static readonly Genre[] Genres =
		[
			new() { Id = 1, Name = "Екшн" },
			new() { Id = 2, Name = "Пригоди" },
			new() { Id = 3, Name = "Комедія" },
			new() { Id = 4, Name = "Драма" },
			new() { Id = 5, Name = "Жахи" },
			new() { Id = 6, Name = "Фентезі" },
			new() { Id = 7, Name = "Фантастика" },
			new() { Id = 8, Name = "Романтика" },
			new() { Id = 9, Name = "Трилер" },
			new() { Id = 10, Name = "Кримінал" },
			new() { Id = 11, Name = "Вестерн" },
			new() { Id = 12, Name = "Воєнний" },
			new() { Id = 13, Name = "Документальний" },
			new() { Id = 14, Name = "Містика" },
			new() { Id = 15, Name = "Мюзикл" },
			new() { Id = 16, Name = "Аніме" },
			new() { Id = 17, Name = "Спорт" },
			new() { Id = 18, Name = "Історичний" },
			new() { Id = 19, Name = "Біографія" },
			new() { Id = 20, Name = "Детектив" },
			new() { Id = 21, Name = "Хоррор" },
			new() { Id = 22, Name = "Мелодрама" }
		];
	}
}
