namespace EshopSpareParts.Migrations
{
    using EshopSpareParts.Models.Db;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EshopSpareParts.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EshopSpareParts.Models.ApplicationDbContext context)
        {
            context.ItemStates.AddOrUpdate(c => c.Id,
             new ItemState { Id = 1, Name = "Nový" },
             new ItemState { Id = 2, Name = "Použitý" }
          );

            context.Categories.AddOrUpdate(c => c.Id,
            new Category { Id = 1, Title = "Náhradní díly", FilterWord = "Náhradní díly", ParentId = null, IsVisible = true },
                new Category { Id = 2, Title = "Autodoplòky", FilterWord = "Autodoplòky", ParentId = null, IsVisible = true },
                new Category { Id = 3, Title = "Pøestavba svìtel", FilterWord = "Pøestavba svìtel", ParentId = null, IsVisible = true },

                new Category { Id = 4, Title = "Škoda", FilterWord = "Škoda", ParentId = 1, IsVisible = true },

                new Category { Id = 5, Title = "Škoda Fabia", FilterWord = "Škoda Fabia", ParentId = 4, IsVisible = true },

                new Category { Id = 6, Title = "Škoda Octavia", FilterWord = "Škoda Octavia ", ParentId = 4, IsVisible = true },
                new Category { Id = 7, Title = "Škoda Octavia I", FilterWord = "Škoda Octavia I ", ParentId = 6, IsVisible = true },
                new Category { Id = 8, Title = "Škoda Octavia II", FilterWord = "Škoda Octavia II", ParentId = 6, IsVisible = true },
                new Category { Id = 9, Title = "Škoda Octavia III", FilterWord = "Škoda Octavia III", ParentId = 6, IsVisible = true },
                new Category { Id = 10, Title = "Volkswagen", FilterWord = "Volkswagen", ParentId = 1, IsVisible = true },
                new Category { Id = 11, Title = "Audi", FilterWord = "Audi", ParentId = 1, IsVisible = true },
                new Category { Id = 12, Title = "Seat", FilterWord = "Seat", ParentId = 1, IsVisible = true },
                new Category { Id = 13, Title = "BMW", FilterWord = "BMW", ParentId = 1, IsVisible = true },

                new Category { Id = 14, Title = "Karoserie", FilterWord = "Škoda Fabia karoserie", ParentId = 5, IsVisible = true },
                new Category { Id = 15, Title = "Interiér", FilterWord = "Škoda Fabia interiér", ParentId = 5, IsVisible = true },
                new Category { Id = 16, Title = "Motor", FilterWord = "Škoda Fabia I motor", ParentId = 5, IsVisible = true },
                new Category { Id = 17, Title = "Pøevodovka", FilterWord = "Škoda Fabia I pøevodovka", ParentId = 5, IsVisible = true },
                new Category { Id = 18, Title = "Klimatizace", FilterWord = "Škoda Fabia I klima kompresor", ParentId = 5, IsVisible = true },
                new Category { Id = 19, Title = "Elektroinstalace", FilterWord = "Škoda Fabia I kabeláž výhøevu sedaèek", ParentId = 5, IsVisible = true },
                new Category { Id = 20, Title = "Podvozek", FilterWord = "Škoda Fabia I podvozek", ParentId = 5, IsVisible = true },

                new Category { Id = 21, Title = "Pøední svìtla", FilterWord = "Škoda Fabia I pøední svìtla", ParentId = 14, IsVisible = false },
                new Category { Id = 22, Title = "Zadní svìtla", FilterWord = "Škoda Fabia I zadní svìtla", ParentId = 14, IsVisible = false },
                new Category { Id = 23, Title = "Levé pøední dveøe", FilterWord = "Škoda Fabia I levé pøední dveøe", ParentId = 14, IsVisible = false },
                new Category { Id = 24, Title = "Pravé pøední dveøe", FilterWord = "Škoda Fabia I pravé pøední dveøe", ParentId = 14, IsVisible = false },
                new Category { Id = 25, Title = "Levé zadní dveøe", FilterWord = "Škoda Fabia I levé zadní dveøe", ParentId = 14, IsVisible = false },
                new Category { Id = 26, Title = "Pravé zadní dveøe", FilterWord = "Škoda Fabia I pravé zadní dveøe", ParentId = 14, IsVisible = false },
                new Category { Id = 27, Title = "Páté dveøe", FilterWord = "Škoda Fabia I páté dveøe", ParentId = 14, IsVisible = false },
                new Category { Id = 28, Title = "Zadní nárazník", FilterWord = "Škoda Fabia I zadní nárazník", ParentId = 14, IsVisible = false },
                new Category { Id = 29, Title = "Pøední nárazník", FilterWord = "Škoda Fabia I pøední nárazník", ParentId = 14, IsVisible = false },
                new Category { Id = 30, Title = "Levé zrcátko", FilterWord = "Škoda Fabia I levé zrcátko", ParentId = 14, IsVisible = false },
                new Category { Id = 31, Title = "Pravé zrcátko", FilterWord = "Škoda Fabia I pravé zrcátko", ParentId = 14, IsVisible = false },
                new Category { Id = 32, Title = "Levý blatník", FilterWord = "Škoda Fabia I levý blatník", ParentId = 14, IsVisible = false },
                new Category { Id = 33, Title = "Pravý blatník", FilterWord = "Škoda Fabia I pravý blatník", ParentId = 14, IsVisible = false },
                new Category { Id = 34, Title = "Maska", FilterWord = "Škoda Fabia I maska", ParentId = 14, IsVisible = false },

                new Category { Id = 35, Title = "Volant", FilterWord = "Škoda Fabia I volant", ParentId = 15, IsVisible = false },
                new Category { Id = 36, Title = "Palubka", FilterWord = "Škoda Fabia I palubka", ParentId = 15, IsVisible = false },
                new Category { Id = 37, Title = "Støedový tunel", FilterWord = "Škoda Fabia I støedový tunel", ParentId = 15, IsVisible = false },
                new Category { Id = 38, Title = "Sedaèky", FilterWord = "Škoda Fabia I sedaèky", ParentId = 15, IsVisible = false },
                new Category { Id = 39, Title = "Loketní opìrka", FilterWord = "Škoda Fabia I loketní opìrka", ParentId = 15, IsVisible = false },
                new Category { Id = 40, Title = "Stropnice", FilterWord = "Škoda Fabia I stropnice", ParentId = 15, IsVisible = false },
                new Category { Id = 41, Title = "Plato kufru", FilterWord = "Škoda Fabia I plato kufru", ParentId = 15, IsVisible = false },
                new Category { Id = 42, Title = "Spínaè svìtel", FilterWord = "Škoda Fabia I spínaè svìtel", ParentId = 15, IsVisible = false },
                new Category { Id = 43, Title = "Roleta kufru", FilterWord = "Škoda Fabia I roleta kufru", ParentId = 15, IsVisible = false },


                new Category { Id = 44, Title = "Chladièová stìna", FilterWord = "Škoda Fabia I chladièová stìna", ParentId = 16, IsVisible = false },
                new Category { Id = 45, Title = "Chladièová stìna F3", FilterWord = "Škoda Fabia III chladièová stìna", ParentId = 16, IsVisible = false },


                new Category { Id = 46, Title = "Pøevodovka 1.9 TDI 96 kw", FilterWord = "Škoda Fabia I 1.9 TDI 96 kw pøevodovka", ParentId = 17, IsVisible = false },
                new Category { Id = 47, Title = "Pøevodovka 1.9 SDI 47 kw", FilterWord = "Škoda Fabia I 1.9 SDI pøevodovka", ParentId = 17, IsVisible = false },
                new Category { Id = 48, Title = "Startér", FilterWord = "Škoda Fabia 1.4 startér", ParentId = 17, IsVisible = false },


                new Category { Id = 49, Title = "Zadní náprava", FilterWord = "Škoda Fabia I zadní náprava", ParentId = 20, IsVisible = false },
                new Category { Id = 50, Title = "Brzdový systém", FilterWord = "Škoda Fabia I brzdový systém", ParentId = 20, IsVisible = false },
                new Category { Id = 51, Title = "Levý zadní tømen", FilterWord = "Škoda Fabia I levý zadní tømen", ParentId = 20, IsVisible = false },
                new Category { Id = 52, Title = "Pravý zadní tømen", FilterWord = "Škoda Fabia I pravý zadní tømen", ParentId = 20, IsVisible = false },


                new Category { Id = 53, Title = "Karoserie", FilterWord = "Škoda Octavia I karoserie", ParentId = 7, IsVisible = true },


                new Category { Id = 54, Title = "Pøední svìtla", FilterWord = "Škoda Octavia I pøední svìtla", ParentId = 53, IsVisible = false },
                new Category { Id = 45, Title = "Zadní svìtla", FilterWord = "Škoda Octavia I zadní svìtla", ParentId = 53, IsVisible = false },
                new Category { Id = 56, Title = "Levé pøední dveøe", FilterWord = "Škoda Octavia I levé pøední dveøe", ParentId = 53, IsVisible = false },
                new Category { Id = 57, Title = "Pravé pøední dveøe", FilterWord = "Škoda Octavia I pravé pøední dveøe", ParentId = 53, IsVisible = false },
                new Category { Id = 58, Title = "Levé zadní dveøe", FilterWord = "Škoda Octavia I levé zadní dveøe", ParentId = 53, IsVisible = false },
                new Category { Id = 59, Title = "Pravé zadní dveøe", FilterWord = "Škoda Octavia I pravé zadní dveøe", ParentId = 53, IsVisible = false },
                new Category { Id = 60, Title = "Páté dveøe", FilterWord = "Škoda Octavia I páté dveøe", ParentId = 53, IsVisible = false },
                new Category { Id = 61, Title = "Zadní nárazník", FilterWord = "Škoda Octavia I zadní nárazník", ParentId = 53, IsVisible = false },
                new Category { Id = 62, Title = "Pøední nárazník", FilterWord = "Škoda Octavia I pøední nárazník", ParentId = 53, IsVisible = false },
                new Category { Id = 63, Title = "Levé zrcátko", FilterWord = "Škoda Octavia I levé zrcátko", ParentId = 53, IsVisible = false },
                new Category { Id = 64, Title = "Pravé zrcátko", FilterWord = "Škoda Octavia I pravé zrcátko", ParentId = 53, IsVisible = false },
                new Category { Id = 65, Title = "Levý blatník", FilterWord = "Škoda Octavia I levý blatník", ParentId = 53, IsVisible = false },
                new Category { Id = 66, Title = "Pravý blatník", FilterWord = "Škoda Octavia I pravý blatník", ParentId = 53, IsVisible = false },
                new Category { Id = 67, Title = "Maska", FilterWord = "Škoda Octavia I maska", ParentId = 53, IsVisible = false },
                new Category { Id = 68, Title = "Kapota", FilterWord = "Škoda Octavia I kapota", ParentId = 53, IsVisible = false },
                new Category { Id = 69, Title = "Pøední nárazník RS", FilterWord = "Škoda Octavia I pøední nárazník RS", ParentId = 53, IsVisible = false },
                new Category { Id = 70, Title = "Levý blinkr èirý", FilterWord = "Škoda Octavia I levý blinkr", ParentId = 53, IsVisible = false },
                new Category { Id = 71, Title = "Pravý blinkr èirý", FilterWord = "Škoda Octavia I pravý blinkr", ParentId = 53, IsVisible = false },
                new Category { Id = 72, Title = "Levý pant", FilterWord = "Škoda Octavia I levý pant", ParentId = 53, IsVisible = false },
                new Category { Id = 73, Title = "Vzpìry kufru", FilterWord = "Škoda Octavia I vpìry kufru", ParentId = 53, IsVisible = false },
                new Category { Id = 74, Title = "Èelní sklo", FilterWord = "Škoda Octavia I èelní sklo", ParentId = 53, IsVisible = false },
                new Category { Id = 75, Title = "Lišty zadních svìtel", FilterWord = "Škoda Octavia I lišty zadních svìtel", ParentId = 53, IsVisible = false },

                new Category { Id = 76, Title = "Interiér", FilterWord = "Škoda Octavia I interiér", ParentId = 7, IsVisible = true },
                new Category { Id = 77, Title = "Volant", FilterWord = "Škoda Octavia I volant", ParentId = 76, IsVisible = false },
                new Category { Id = 78, Title = "Palubka", FilterWord = "Škoda Octavia I palubka", ParentId = 76, IsVisible = false },
                new Category { Id = 79, Title = "Støedový tunel", FilterWord = "Škoda Octavia I støedový tunel", ParentId = 76, IsVisible = false },
                new Category { Id = 80, Title = "Sedaèky", FilterWord = "Škoda Octavia I sedaèky", ParentId = 76, IsVisible = false },
                new Category { Id = 81, Title = "Loketní opìrka", FilterWord = "Škoda Octavia I loketní opìrka", ParentId = 76, IsVisible = false },
                new Category { Id = 82, Title = "Stropnice", FilterWord = "Škoda Octavia I stropnice", ParentId = 76, IsVisible = false },
                new Category { Id = 83, Title = "Plato kufru", FilterWord = "Škoda Octavia I plato kufru", ParentId = 76, IsVisible = false },
                new Category { Id = 84, Title = "Spínaè svìtel", FilterWord = "Škoda Octavia I spínaè svìtel", ParentId = 76, IsVisible = false },
                new Category { Id = 85, Title = "Roleta kufru", FilterWord = "Škoda Octavia I roleta kufru", ParentId = 76, IsVisible = false },
                new Category { Id = 86, Title = "Výdechy topení", FilterWord = "Škoda Octavia I výdechy topení", ParentId = 76, IsVisible = false },
                new Category { Id = 87, Title = "Levý výdech topení", FilterWord = "Škoda Octavia I levý výdech topení", ParentId = 76, IsVisible = false },
                new Category { Id = 88, Title = "Pravý výdech topení", FilterWord = "Škoda Octavia I pravý výdech topení", ParentId = 76, IsVisible = false },
                new Category { Id = 89, Title = "Støedový výdech topení", FilterWord = "Škoda Octavia I støedový výdech topení", ParentId = 76, IsVisible = false },
                new Category { Id = 90, Title = "Budíky", FilterWord = "Škoda Octavia I budíky", ParentId = 76, IsVisible = false },
                new Category { Id = 91, Title = "Levý pøední reproduktor", FilterWord = "Škoda Octavia I levý pøední reproduktor", ParentId = 76, IsVisible = false },
                new Category { Id = 92, Title = "Popelník", FilterWord = "Škoda Octavia I popelník", ParentId = 76, IsVisible = false },
                new Category { Id = 93, Title = "Pravý pøední reproduktor", FilterWord = "Škoda Octavia I pravý pøední reproduktor", ParentId = 76, IsVisible = false },
                new Category { Id = 94, Title = "Stropní svìtlo", FilterWord = "Škoda Octavia I stropní svìtlo", ParentId = 76, IsVisible = false },
                new Category { Id = 95, Title = "Levý pøední pás", FilterWord = "Škoda Octavia I levý pøední pás", ParentId = 76, IsVisible = false },
                new Category { Id = 96, Title = "Rámeèek klimatizace", FilterWord = "Škoda Octavia I rámeèek klimatizace", ParentId = 76, IsVisible = false },
                new Category { Id = 97, Title = "Madlo ruèní brzdy", FilterWord = "Škoda Octavia I madlo ruèní brzdy", ParentId = 76, IsVisible = false },
                new Category { Id = 98, Title = "Pravý pøední pás", FilterWord = "Škoda Octavia I pravý pøední pás", ParentId = 76, IsVisible = false },
                new Category { Id = 99, Title = "Levý pøední pás", FilterWord = "Škoda Octavia I levý pøední pás", ParentId = 76, IsVisible = false },

                new Category { Id = 100, Title = "Motor", FilterWord = "Škoda Octavia I motor", ParentId = 7, IsVisible = true },

                new Category { Id = 101, Title = "Škrtící klapka 1.8T", FilterWord = "Škoda Octavia 1.8T škrtící klapka", ParentId = 100, IsVisible = false },
                new Category { Id = 102, Title = "Chladièová stìna", FilterWord = "Škoda Octavia I chladièová stìna", ParentId = 100, IsVisible = false },
                new Category { Id = 103, Title = "Škrtící klapka 1.6i", FilterWord = "Škoda Octavia 1.6i škrtící klapka", ParentId = 100, IsVisible = false },
                new Category { Id = 104, Title = "Palivové èerpadlo 1.6i", FilterWord = "Škoda Octavia 1.6i palivové èerpadlo", ParentId = 100, IsVisible = false },
                new Category { Id = 105, Title = "Palivové èerpadlo 1.8T", FilterWord = "Škoda Octavia 1.8T palivové èerpadlo", ParentId = 100, IsVisible = false },
                new Category { Id = 106, Title = "Motor 1.9 TDI", FilterWord = "Škoda Octavia 1.9 TDI 66 kw motor", ParentId = 100, IsVisible = false },
                new Category { Id = 107, Title = "Váha vzduchu 1.9 TDI", FilterWord = "Škoda Octavia 1.9 TDI váha vzduchu", ParentId = 100, IsVisible = false },
                new Category { Id = 108, Title = "Intercooler 1.9 TDI", FilterWord = "Škoda Octavia 1.9 TDI intercooler", ParentId = 100, IsVisible = false },
                new Category { Id = 109, Title = "Intercooler 1.8T", FilterWord = "Škoda Octavia 1.8T intercooler", ParentId = 100, IsVisible = false },
                new Category { Id = 110, Title = "Svody", FilterWord = "Škoda Octavia 1.8T svody", ParentId = 100, IsVisible = false },
                new Category { Id = 111, Title = "Turbo 1.9 TDI", FilterWord = "Škoda Octavia 1.9 TDI turbo", ParentId = 100, IsVisible = false },
                new Category { Id = 112, Title = "Turbo 1.8T", FilterWord = "Škoda Octavia 1.8T turbo", ParentId = 100, IsVisible = false },


                new Category { Id = 113, Title = "Pøevodovka", FilterWord = "Škoda Octavia I pøevodovka", ParentId = 7, IsVisible = true },
                new Category { Id = 114, Title = "Startér 1.9 TDI", FilterWord = "Škoda Octavia 1.9 TDI startér", ParentId = 113, IsVisible = false },
                new Category { Id = 115, Title = "Startér 1.8T", FilterWord = "Škoda Octavia 1.8T startér", ParentId = 113, IsVisible = false },
                new Category { Id = 116, Title = "Pøevodovka 1.8T", FilterWord = "Škoda Octavia 1.8T pøevodovka", ParentId = 113, IsVisible = false },
                new Category { Id = 117, Title = "Pøevodovka 1.9 SDI", FilterWord = "Škoda Octavia 1.9 SDI pøevodovka", ParentId = 113, IsVisible = false },
                new Category { Id = 118, Title = "Pøevodovka 2.0i", FilterWord = "Škoda Octavia 2.0i pøevodovka", ParentId = 113, IsVisible = false },
                new Category { Id = 119, Title = "Pøevodovka 1.6i", FilterWord = "Škoda Octavia 1.6i pøevodovka", ParentId = 113, IsVisible = false },
                new Category { Id = 120, Title = "Pøevodovka 1.8i", FilterWord = "Škoda Octavia 1.8i pøevodovka", ParentId = 113, IsVisible = false },

                new Category { Id = 121, Title = "Klimatizace", FilterWord = "Škoda Octavia I kompletní set klimatizace", ParentId = 7, IsVisible = true },
                new Category { Id = 122, Title = "Klima kompresor", FilterWord = "Škoda Octavia I klima kompresor", ParentId = 121, IsVisible = false },
                new Category { Id = 123, Title = "Ovladaè klimatizace", FilterWord = "Škoda Octavia I ovladaè klimatizace", ParentId = 121, IsVisible = false },

                new Category { Id = 124, Title = "Podvozek", FilterWord = "Škoda Octavia I podvozek", ParentId = 7, IsVisible = true },
                new Category { Id = 125, Title = "Zadní náprava", FilterWord = "Škoda Octavia I zadní náprava", ParentId = 124, IsVisible = false },
                new Category { Id = 126, Title = "Levá poloosa", FilterWord = "Škoda Octavia I 1.9 TDI levá poloosa", ParentId = 124, IsVisible = false },
                new Category { Id = 127, Title = "Pravá poloosa", FilterWord = "Škoda Octavia I 1.9 TDI pravá poloosa", ParentId = 124, IsVisible = false },
                new Category { Id = 128, Title = "Øízení", FilterWord = "Škoda Octavia I øízení", ParentId = 124, IsVisible = false },
                new Category { Id = 129, Title = "Tlumièe", FilterWord = "Škoda Octavia I tlumièe", ParentId = 124, IsVisible = false },

                new Category { Id = 130, Title = "Brzdový systém", FilterWord = "Škoda Octavia I brzdový systém", ParentId = 7, IsVisible = true },
                new Category { Id = 131, Title = "Levý zadní tømen", FilterWord = "Škoda Octavia I levý zadní tømen", ParentId = 130, IsVisible = false },
                new Category { Id = 132, Title = "Pravý zadní tømen", FilterWord = "Škoda Octavia I pravý zadní tømen", ParentId = 130, IsVisible = false },
                new Category { Id = 133, Title = "Elektroinstalace", FilterWord = "Škoda Octavia I elektroinstalace", ParentId = 7, IsVisible = true },

                new Category { Id = 134, Title = "Komfortní jednotka", FilterWord = "1J0959799AH", ParentId = 133, IsVisible = false },
                new Category { Id = 135, Title = "Levá pøední stahovaèka", FilterWord = "Škoda Octavia I levá pøední stahovaèka", ParentId = 133, IsVisible = false },
                new Category { Id = 136, Title = "Pravá pøední stahovaèka", FilterWord = "Škoda Octavia I pravá pøední stahovaèka", ParentId = 133, IsVisible = false },
                new Category { Id = 137, Title = "Levá zadní stahovaèka", FilterWord = "Škoda Octavia I levá zadní stahovaèka", ParentId = 133, IsVisible = false },
                new Category { Id = 138, Title = "Pravá zadní stahovaèka", FilterWord = "Škoda Octavia I pravá zadní stahovaèka", ParentId = 133, IsVisible = false },
                new Category { Id = 139, Title = "Levý pøední zámek", FilterWord = "Škoda Octavia I levý pøední zámek", ParentId = 133, IsVisible = false },
                new Category { Id = 140, Title = "Pravý pøední zámek", FilterWord = "Škoda Octavia I pravý pøední zámek", ParentId = 133, IsVisible = false },
                new Category { Id = 141, Title = "Levý zadní zámek", FilterWord = "Škoda Octavia I levý zadní zámek", ParentId = 133, IsVisible = false },
                new Category { Id = 142, Title = "Pravý pøední zámek", FilterWord = "Škoda Octavia I pravý zadní zámek", ParentId = 133, IsVisible = false },
                new Category { Id = 143, Title = "Motorek zadního stìraèe", FilterWord = "Škoda Octavia I motorek zadního stìraèe", ParentId = 133, IsVisible = false },
                new Category { Id = 144, Title = "Mechanismus stìraèù", FilterWord = "Škoda Octavia I táhla stìraèù", ParentId = 133, IsVisible = false },
                new Category { Id = 145, Title = "Øídící jednotka ABS", FilterWord = "Škoda Octavia I øídící jednotka ABS", ParentId = 133, IsVisible = false },
                new Category { Id = 146, Title = "Alternátor 1.8T", FilterWord = "Škoda Octavia I 1.8T alternátor", ParentId = 133, IsVisible = false },
                new Category { Id = 147, Title = "Alternátor 1.9 TDI", FilterWord = "Škoda Octavia I 1.9 TDI alternátor", ParentId = 133, IsVisible = false },
                new Category { Id = 148, Title = "Øídící jednotka klimatizace", FilterWord = "Škoda Octavia I øídící jednotka klimatizace", ParentId = 133, IsVisible = false },
                new Category { Id = 149, Title = "Motorová kabeláž 1.6i", FilterWord = "Škoda Octavia I motorová kabeláž 1.6i", ParentId = 133, IsVisible = false },
                new Category { Id = 150, Title = "Motorová kabeláž 1.8T", FilterWord = "Škoda Octavia I motorová kabeláž 1.8T", ParentId = 133, IsVisible = false },
                new Category { Id = 151, Title = "Motorová kabeláž 1.8T RS", FilterWord = "Škoda Octavia I motorová kabeláž 1.8T RS", ParentId = 133, IsVisible = false },
                new Category { Id = 152, Title = "Motorová kabeláž 1.9 TDI", FilterWord = "Škoda Octavia I motorová kabeláž 1.9 TDI", ParentId = 133, IsVisible = false },
                new Category { Id = 153, Title = "Kabeláž výhøevu sedaèek", FilterWord = "Škoda Octavia I kabeláž výhøevu sedaèek", ParentId = 133, IsVisible = false },
                new Category { Id = 154, Title = "Senzor pøíèného zrychlení", FilterWord = "Škoda Octavia I senzor pøíèného zrychlení", ParentId = 133, IsVisible = false },
                new Category { Id = 155, Title = "Senzor podélného zrychlení", FilterWord = "Škoda Octavia I senzor podélného zrychlení", ParentId = 133, IsVisible = false },



                new Category { Id = 156, Title = "Karoserie", FilterWord = "Škoda Octavia II karoserie", ParentId = 8, IsVisible = true },
                new Category { Id = 157, Title = "Pøední svìtla", FilterWord = "Škoda Octavia II pøední svìtla", ParentId = 156, IsVisible = false },
                new Category { Id = 158, Title = "Pøední svìtla halogenová", FilterWord = "Škoda Octavia II halogenová pøední svìtla", ParentId = 157, IsVisible = false },
                new Category { Id = 159, Title = "Pøední svìtla xeny", FilterWord = "Škoda Octavia II xenony", ParentId = 157, IsVisible = false },
                new Category { Id = 160, Title = "Zadní svìtla", FilterWord = "Škoda Octavia II zadní svìtla", ParentId = 156, IsVisible = false },
                new Category { Id = 161, Title = "Levé pøední dveøe", FilterWord = "Škoda Octavia II levé pøední dveøe", ParentId = 156, IsVisible = false },
                new Category { Id = 162, Title = "Pravé pøední dveøe", FilterWord = "Škoda Octavia II pravé pøední dveøe", ParentId = 156, IsVisible = false },
                new Category { Id = 163, Title = "Levé zadní dveøe", FilterWord = "Škoda Octavia II levé zadní dveøe", ParentId = 156, IsVisible = false },
                new Category { Id = 164, Title = "Pravé zadní dveøe", FilterWord = "Škoda Octavia II pravé zadní dveøe", ParentId = 156, IsVisible = false },
                new Category { Id = 165, Title = "Páté dveøe", FilterWord = "Škoda Octavia II páté dveøe", ParentId = 156, IsVisible = false },
                new Category { Id = 166, Title = "Zadní nárazník", FilterWord = "Škoda Octavia II zadní nárazník", ParentId = 156, IsVisible = false },
                new Category { Id = 167, Title = "Pøední nárazník", FilterWord = "Škoda Octavia II pøední nárazník", ParentId = 156, IsVisible = false },
                new Category { Id = 168, Title = "Levé zrcátko", FilterWord = "Škoda Octavia II levé zrcátko", ParentId = 156, IsVisible = false },
                new Category { Id = 169, Title = "Pravé zrcátko", FilterWord = "Škoda Octavia II pravé zrcátko", ParentId = 156, IsVisible = false },
                new Category { Id = 170, Title = "Levý blatník", FilterWord = "Škoda Octavia II levý blatník", ParentId = 156, IsVisible = false },
                new Category { Id = 171, Title = "Pravý blatník", FilterWord = "Škoda Octavia II pravý blatník", ParentId = 156, IsVisible = false },
                new Category { Id = 172, Title = "Maska", FilterWord = "Škoda Octavia II maska", ParentId = 156, IsVisible = false },
                new Category { Id = 173, Title = "Kapota", FilterWord = "Škoda Octavia II kapota", ParentId = 156, IsVisible = false },
                new Category { Id = 174, Title = "Pøední nárazník RS", FilterWord = "Škoda Octavia II pøední nárazník RS", ParentId = 156, IsVisible = false },
                new Category { Id = 175, Title = "Èelní sklo", FilterWord = "Škoda Octavia II èelní sklo", ParentId = 156, IsVisible = false },
                new Category { Id = 176, Title = "Výztuha pøedního nárazníku", FilterWord = "Škoda Octavia II výztuha pøedního nárazníku", ParentId = 156, IsVisible = false },




                new Category { Id = 178, Title = "Interiér", FilterWord = "Škoda Octavia II interiér", ParentId = 8, IsVisible = true },
                new Category { Id = 179, Title = "Volant", FilterWord = "Škoda Octavia II volant", ParentId = 178, IsVisible = false },
                new Category { Id = 180, Title = "Palubka", FilterWord = "Škoda Octavia II palubka", ParentId = 178, IsVisible = false },
                new Category { Id = 181, Title = "Støedový tunel", FilterWord = "Škoda Octavia II støedový tunel", ParentId = 178, IsVisible = false },
                new Category { Id = 182, Title = "Sedaèky", FilterWord = "Škoda Octavia II sedaèky", ParentId = 178, IsVisible = false },
                new Category { Id = 183, Title = "Loketní opìrka", FilterWord = "Škoda Octavia II loketní opìrka", ParentId = 178, IsVisible = false },
                new Category { Id = 184, Title = "Stropnice", FilterWord = "Škoda Octavia II stropnice", ParentId = 178, IsVisible = false },
                new Category { Id = 185, Title = "Plato kufru", FilterWord = "Škoda Octavia II plato kufru", ParentId = 178, IsVisible = false },
                new Category { Id = 186, Title = "Spínaè svìtel", FilterWord = "Škoda Octavia II spínaè svìtel", ParentId = 178, IsVisible = false },
                new Category { Id = 187, Title = "Roleta kufru", FilterWord = "Škoda Octavia II roleta kufru", ParentId = 178, IsVisible = false },
                new Category { Id = 188, Title = "Výdechy topení", FilterWord = "Škoda Octavia II výdechy topení", ParentId = 178, IsVisible = false },
                new Category { Id = 189, Title = "Levý výdech topení", FilterWord = "Škoda Octavia II levý výdech topení", ParentId = 178, IsVisible = false },
                new Category { Id = 190, Title = "Pravý výdech topení", FilterWord = "Škoda Octavia II pravý výdech topení", ParentId = 178, IsVisible = false },
                new Category { Id = 191, Title = "Støedový výdech topení", FilterWord = "Škoda Octavia II støedový výdech topení", ParentId = 178, IsVisible = false },
                new Category { Id = 192, Title = "Budíky", FilterWord = "Škoda Octavia II 1.9 TDI budíky ", ParentId = 178, IsVisible = false },
                new Category { Id = 193, Title = "Popelník", FilterWord = "Škoda Octavia II popelník", ParentId = 178, IsVisible = false },
                new Category { Id = 194, Title = "Dvojité dno", FilterWord = "Škoda Octavia II dvojité dno", ParentId = 178, IsVisible = false },
                new Category { Id = 195, Title = "Stropní svìtlo", FilterWord = "Škoda Octavia II stropní svìtlo", ParentId = 178, IsVisible = false },
                new Category { Id = 196, Title = "Levý pøední pás", FilterWord = "Škoda Octavia II levý pøední pás", ParentId = 178, IsVisible = false },
                new Category { Id = 197, Title = "Rámeèek klimatizace", FilterWord = "Škoda Octavia II rámeèek klimatizace", ParentId = 178, IsVisible = false },
                new Category { Id = 198, Title = "Pravý pøední pás", FilterWord = "Škoda Octavia II pravý pøední pás", ParentId = 178, IsVisible = false },
                new Category { Id = 199, Title = "Zadní pásy", FilterWord = "Škoda Octavia II zadní pásy", ParentId = 178, IsVisible = false },
                new Category { Id = 200, Title = "Volant RS", FilterWord = "Škoda Octavia II RS volant", ParentId = 178, IsVisible = false },

                new Category { Id = 201, Title = "Motor", FilterWord = "Škoda Octavia II motor", ParentId = 8, IsVisible = true },
                new Category { Id = 202, Title = "Škrtící klapka 2.TDI", FilterWord = "Škoda Octavia 2.0 TDI škrtící klapka", ParentId = 201, IsVisible = false },
                new Category { Id = 203, Title = "Chladièová stìna", FilterWord = "Škoda Octavia II chladièová stìna", ParentId = 201, IsVisible = false },
                new Category { Id = 204, Title = "Palivové èerpadlo 1.9 TDI", FilterWord = "Škoda Octavia 1.9 TDI palivové èerpadlo", ParentId = 201, IsVisible = false },
                new Category { Id = 205, Title = "Turbo 1.9 TDI", FilterWord = "Škoda Octavia II 1.9 TDI turbo", ParentId = 201, IsVisible = false },
                new Category { Id = 206, Title = "Turbo 2.0 TDI", FilterWord = "Škoda Octavia II 2.0 TDI turbo", ParentId = 201, IsVisible = false },

                new Category { Id = 207, Title = "Pøevodovka", FilterWord = "Škoda Octavia II pøevodovka", ParentId = 8, IsVisible = true },
                new Category { Id = 208, Title = "Pøevodovka 1.9 TDI", FilterWord = "Škoda Octavia II 1.9 TDI pøevodovka", ParentId = 207, IsVisible = false },
                new Category { Id = 209, Title = "Pøevodovka 2.0 TDI", FilterWord = "Škoda Octavia II 2.0 TDI pøevodovka", ParentId = 207, IsVisible = false },
                new Category { Id = 210, Title = "Pøevodovka 1.9 TDI DSG", FilterWord = "Škoda Octavia II 1.9 TDI DSG pøevodovka", ParentId = 207, IsVisible = false },
                new Category { Id = 211, Title = "Pøevodovka 2.0 TDI DSG", FilterWord = "Škoda Octavia II 2.0 TDI DSG pøevodovka", ParentId = 207, IsVisible = false },
                new Category { Id = 212, Title = "Startér 1.9 TDI", FilterWord = "Škoda Octavia II 1.9 TDI startér", ParentId = 207, IsVisible = false },
                new Category { Id = 213, Title = "Startér 2.0 TDI", FilterWord = "Škoda Octavia II 2.0 TDI startér", ParentId = 207, IsVisible = false },

                new Category { Id = 214, Title = "Klimatizace", FilterWord = "Škoda Octavia II klimatizace", ParentId = 8, IsVisible = true },
                new Category { Id = 215, Title = "Klima kompresor", FilterWord = "Škoda Octavia II klima kompresor", ParentId = 214, IsVisible = false },
                new Category { Id = 216, Title = "Ovladaè klimatizace", FilterWord = "Škoda Octavia II ovladaè klimatizace", ParentId = 214, IsVisible = false },

                new Category { Id = 217, Title = "Podvozek", FilterWord = "Škoda Octavia II podvozek", ParentId = 8, IsVisible = true },
                new Category { Id = 218, Title = "Zadní náprava", FilterWord = "Škoda Octavia II zadní náprava", ParentId = 217, IsVisible = false },
                new Category { Id = 219, Title = "Levá poloosa", FilterWord = "Škoda Octavia II 1.9 TDI levá poloosa", ParentId = 217, IsVisible = false },
                new Category { Id = 220, Title = "Pravá poloosa", FilterWord = "Škoda Octavia II 1.9 TDI pravá poloosa", ParentId = 217, IsVisible = false },
                new Category { Id = 221, Title = "Øízení", FilterWord = "Škoda Octavia II øízení", ParentId = 217, IsVisible = false },


                new Category { Id = 222, Title = "Elektroinstalace", FilterWord = "Škoda Octavia II elektroinstalace", ParentId = 8, IsVisible = true },
                new Category { Id = 223, Title = "Motorek zadního stìraèe", FilterWord = "Škoda Octavia II motorek zadního stìraèe", ParentId = 222, IsVisible = false },
                new Category { Id = 224, Title = "Mechanismus stìraèù", FilterWord = "Škoda Octavia II táhla stìraèù", ParentId = 222, IsVisible = false },
                new Category { Id = 225, Title = "Øídící jednotka ABS", FilterWord = "Škoda Octavia II øídící jednotka ABS", ParentId = 222, IsVisible = false },
                new Category { Id = 226, Title = "Alternátor 2.0 TDI", FilterWord = "Škoda Octavia II 2.0 TDI alternátor", ParentId = 222, IsVisible = false },
                new Category { Id = 227, Title = "Alternátor 1.9 TDI", FilterWord = "Škoda Octavia I 1.9 TDI alternátor", ParentId = 222, IsVisible = false },
                new Category { Id = 228, Title = "Motorová kabeláž 1.9 TDI", FilterWord = "Škoda Octavia II motorová kabeláž 1.9 TDI", ParentId = 222, IsVisible = false },
                new Category { Id = 229, Title = "Kabeláž výhøevu sedaèek", FilterWord = "Škoda Octavia II kabeláž výhøevu sedaèek", ParentId = 222, IsVisible = false },








                new Category { Id = 230, Title = "Karoserie", FilterWord = "Škoda Octavia III karoserie", ParentId = 9, IsVisible = true },
                new Category { Id = 231, Title = "Pøední svìtla", FilterWord = "Škoda Octavia III pøední svìtla", ParentId = 230, IsVisible = false },
                new Category { Id = 232, Title = "Halogenová", FilterWord = "Škoda Octavia III halogenová pøední svìtla", ParentId = 231, IsVisible = false },
                new Category { Id = 233, Title = "Xenony", FilterWord = "Škoda Octavia III xenony", ParentId = 231, IsVisible = false },
                new Category { Id = 234, Title = "Zadní svìtla", FilterWord = "Škoda Octavia III zadní svìtla", ParentId = 230, IsVisible = false },
                new Category { Id = 235, Title = "Levé pøední dveøe", FilterWord = "Škoda Octavia III levé pøední dveøe", ParentId = 230, IsVisible = false },
                new Category { Id = 236, Title = "Pravé pøední dveøe", FilterWord = "Škoda Octavia III pravé pøední dveøe", ParentId = 230, IsVisible = false },
                new Category { Id = 237, Title = "Levé zadní dveøe", FilterWord = "Škoda Octavia III levé zadní dveøe", ParentId = 230, IsVisible = false },
                new Category { Id = 238, Title = "Pravé zadní dveøe", FilterWord = "Škoda Octavia III pravé zadní dveøe", ParentId = 230, IsVisible = false },
                new Category { Id = 239, Title = "Páté dveøe", FilterWord = "Škoda Octavia III páté dveøe", ParentId = 230, IsVisible = false },
                new Category { Id = 240, Title = "Zadní nárazník", FilterWord = "Škoda Octavia III zadní nárazník", ParentId = 230, IsVisible = false },
                new Category { Id = 241, Title = "Pøední nárazník", FilterWord = "Škoda Octavia III pøední nárazník", ParentId = 230, IsVisible = false },
                new Category { Id = 242, Title = "Levé zrcátko", FilterWord = "Škoda Octavia III levé zrcátko", ParentId = 230, IsVisible = false },
                new Category { Id = 243, Title = "Pravé zrcátko", FilterWord = "Škoda Octavia III pravé zrcátko", ParentId = 230, IsVisible = false },
                new Category { Id = 244, Title = "Levý blatník", FilterWord = "Škoda Octavia III levý blatník", ParentId = 230, IsVisible = false },
                new Category { Id = 245, Title = "Pravý blatník", FilterWord = "Škoda Octavia III pravý blatník", ParentId = 230, IsVisible = false },
                new Category { Id = 246, Title = "Maska", FilterWord = "Škoda Octavia III maska", ParentId = 230, IsVisible = false },
                new Category { Id = 247, Title = "Kapota", FilterWord = "Škoda Octavia III kapota", ParentId = 230, IsVisible = false },
                new Category { Id = 248, Title = "Pøední nárazník RS", FilterWord = "Škoda Octavia III pøední nárazník RS", ParentId = 230, IsVisible = false },
                new Category { Id = 249, Title = "Èelní sklo", FilterWord = "Škoda Octavia III èelní sklo", ParentId = 230, IsVisible = false },
                new Category { Id = 250, Title = "Výztuha pøedního nárazníku", FilterWord = "Škoda Octavia III výztuha pøedního nárazníku", ParentId = 230, IsVisible = false },


                new Category { Id = 251, Title = "Interiér", FilterWord = "Škoda Octavia III interiér", ParentId = 9, IsVisible = true },
                new Category { Id = 252, Title = "Volant", FilterWord = "Škoda Octavia III volant", ParentId = 251, IsVisible = false },
                new Category { Id = 253, Title = "Palubka", FilterWord = "Škoda Octavia III palubka", ParentId = 251, IsVisible = false },
                new Category { Id = 254, Title = "Støedový tunel", FilterWord = "Škoda Octavia III støedový tunel", ParentId = 251, IsVisible = false },
                new Category { Id = 255, Title = "Sedaèky", FilterWord = "Škoda Octavia III sedaèky", ParentId = 251, IsVisible = false },
                new Category { Id = 256, Title = "Loketní opìrka", FilterWord = "Škoda Octavia III loketní opìrka", ParentId = 251, IsVisible = false },
                new Category { Id = 257, Title = "Stropnice", FilterWord = "Škoda Octavia III stropnice", ParentId = 251, IsVisible = false },
                new Category { Id = 258, Title = "Plato kufru", FilterWord = "Škoda Octavia III plato kufru", ParentId = 251, IsVisible = false },
                new Category { Id = 259, Title = "Spínaè svìtel", FilterWord = "Škoda Octavia III spínaè svìtel", ParentId = 251, IsVisible = false },
                new Category { Id = 260, Title = "Roleta kufru", FilterWord = "Škoda Octavia III roleta kufru", ParentId = 251, IsVisible = false },
                new Category { Id = 261, Title = "Výdechy topení", FilterWord = "Škoda Octavia III výdechy topení", ParentId = 251, IsVisible = false },
                new Category { Id = 262, Title = "Levý výdech topení", FilterWord = "Škoda Octavia III levý výdech topení", ParentId = 251, IsVisible = false },
                new Category { Id = 263, Title = "Pravý výdech topení", FilterWord = "Škoda Octavia III pravý výdech topení", ParentId = 251, IsVisible = false },
                new Category { Id = 264, Title = "Støedový výdech topení", FilterWord = "Škoda Octavia III støedový výdech topení", ParentId = 251, IsVisible = false },
                new Category { Id = 265, Title = "Budíky", FilterWord = "Škoda Octavia III 2.0 TDI budíky ", ParentId = 251, IsVisible = false },
                new Category { Id = 266, Title = "Popelník", FilterWord = "Škoda Octavia III popelník", ParentId = 251, IsVisible = false },
                new Category { Id = 267, Title = "Dvojité dno", FilterWord = "Škoda Octavia III dvojité dno", ParentId = 251, IsVisible = false },
                new Category { Id = 268, Title = "Stropní svìtlo", FilterWord = "Škoda Octavia III stropní svìtlo", ParentId = 251, IsVisible = false },
                new Category { Id = 269, Title = "Levý pøední pás", FilterWord = "Škoda Octavia III levý pøední pás", ParentId = 251, IsVisible = false },
                new Category { Id = 270, Title = "Pravý pøední pás", FilterWord = "Škoda Octavia III pravý pøední pás", ParentId = 251, IsVisible = false },
                new Category { Id = 271, Title = "Zadní pásy", FilterWord = "Škoda Octavia III zadní pásy", ParentId = 251, IsVisible = false },
                new Category { Id = 272, Title = "Volant RS", FilterWord = "Škoda Octavia III RS volant", ParentId = 251, IsVisible = false },



                new Category { Id = 273, Title = "Motor", FilterWord = "Škoda Octavia III motor", ParentId = 9, IsVisible = true },
                new Category { Id = 274, Title = "Škrtící klapka 2.TDI", FilterWord = "Škoda Octavia III 2.0 TDI škrtící klapka", ParentId = 273, IsVisible = false },
                new Category { Id = 275, Title = "Chladièová stìna 1.6 TDI", FilterWord = "Škoda Octavia III chladièová stìna 1.6 TDI", ParentId = 273, IsVisible = false },
                new Category { Id = 276, Title = "Chladièová stìna 1.4 TSI", FilterWord = "Škoda Octavia III chladièová stìna 1.4 TSI", ParentId = 273, IsVisible = false },
                new Category { Id = 277, Title = "Chladièová stìna 2.0 TDI", FilterWord = "Škoda Octavia III chladièová stìna 2.0 TDI", ParentId = 273, IsVisible = false },
                new Category { Id = 278, Title = "Palivové èerpadlo", FilterWord = "Škoda Octavia III 2.0 TDI palivové èerpadlo", ParentId = 273, IsVisible = false },
                new Category { Id = 279, Title = "Turbo 2.0 TDI", FilterWord = "Škoda Octavia II 2.0 TDI turbo", ParentId = 273, IsVisible = false },



                new Category { Id = 280, Title = "Pøevodovka", FilterWord = "Škoda Octavia III pøevodovka", ParentId = 9, IsVisible = true },
                new Category { Id = 281, Title = "Pøevodovka 2.0 TDI", FilterWord = "Škoda Octavia III 2.0 TDI pøevodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 282, Title = "Pøevodovka 1.0 TSI", FilterWord = "Škoda Octavia III 1.0 TSI pøevodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 283, Title = "Pøevodovka 1.4 TSI", FilterWord = "Škoda Octavia III 1.4 TSI pøevodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 284, Title = "Pøevodovka 1.6 TDI", FilterWord = "Škoda Octavia III 1.6 TDI pøevodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 285, Title = "Pøevodovka 2.0 TDI DSG", FilterWord = "Škoda Octavia III 2.0 TDI DSG pøevodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 286, Title = "Pøevodovka 1.6 TDI DSG", FilterWord = "Škoda Octavia III 1.6 TDI DSG pøevodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 287, Title = "Pøevodovka 1.4 TSI DSG", FilterWord = "Škoda Octavia III 1.4 TSI DSG pøevodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 288, Title = "Startér 1.6 TDI", FilterWord = "Škoda Octavia III 1.6 TDI startér", ParentId = 280, IsVisible = false },
                new Category { Id = 289, Title = "Startér 2.0 TDI", FilterWord = "Škoda Octavia III 2.0 TDI startér", ParentId = 280, IsVisible = false },


                new Category { Id = 290, Title = "Klimatizace", FilterWord = "Škoda Octavia III klimatizace", ParentId = 9, IsVisible = true },
                new Category { Id = 291, Title = "Klima kompresor", FilterWord = "Škoda Octavia III klima kompresor", ParentId = 290, IsVisible = false },
                new Category { Id = 292, Title = "Ovladaè klimatizace", FilterWord = "Škoda Octavia III ovladaè klimatizace", ParentId = 290, IsVisible = false },

                new Category { Id = 293, Title = "Podvozek", FilterWord = "Škoda Octavia III podvozek", ParentId = 9, IsVisible = true },
                new Category { Id = 294, Title = "Zadní náprava", FilterWord = "Škoda Octavia III zadní náprava", ParentId = 293, IsVisible = false },
                new Category { Id = 295, Title = "Levá poloosa", FilterWord = "Škoda Octavia III 2.0 TDI levá poloosa", ParentId = 293, IsVisible = false },
                new Category { Id = 296, Title = "Pravá poloosa", FilterWord = "Škoda Octavia III 2.0 TDI pravá poloosa", ParentId = 293, IsVisible = false },
                new Category { Id = 297, Title = "Øízení", FilterWord = "Škoda Octavia III øízení", ParentId = 293, IsVisible = false },


                new Category { Id = 298, Title = "Elektroinstalace", FilterWord = "Škoda Octavia III elektroinstalace", ParentId = 9, IsVisible = true },
                new Category { Id = 299, Title = "Motorek zadního stìraèe", FilterWord = "Škoda Octavia III motorek zadního stìraèe", ParentId = 298, IsVisible = false },
                new Category { Id = 300, Title = "Mechanismus stìraèù", FilterWord = "Škoda Octavia III táhla stìraèù", ParentId = 298, IsVisible = false },
                new Category { Id = 301, Title = "Øídící jednotka ABS", FilterWord = "Škoda Octavia III øídící jednotka ABS", ParentId = 298, IsVisible = false },
                new Category { Id = 302, Title = "Alternátor 2.0 TDI", FilterWord = "Škoda Octavia III 2.0 TDI alternátor", ParentId = 298, IsVisible = false },
                new Category { Id = 303, Title = "Alternátor 1.6 TDI", FilterWord = "Škoda Octavia III 1.6 TDI alternátor", ParentId = 298, IsVisible = false },
                new Category { Id = 304, Title = "Alternátor 1.4 TSI", FilterWord = "Škoda Octavia III 1.4 TSI alternátor", ParentId = 298, IsVisible = false },




                new Category { Id = 305, Title = "Karoserie", FilterWord = "Volkswagen karoserie", ParentId = 10, IsVisible = true },
                new Category { Id = 306, Title = "Levé pøední dveøe", FilterWord = "Volkswagen Passat B6 levé pøední dveøe", ParentId = 305, IsVisible = false },
                new Category { Id = 307, Title = "Pravé pøední dveøe", FilterWord = "Volkswagen Passat B6 pravé pøední dveøe", ParentId = 305, IsVisible = false },
                new Category { Id = 308, Title = "Levé zadní dveøe", FilterWord = "Volkswagen Passat B6 levé zadní dveøe", ParentId = 305, IsVisible = false },
                new Category { Id = 309, Title = "Pravé zadní dveøe", FilterWord = "Volkswagen Passat B6 pravé zadní dveøe", ParentId = 305, IsVisible = false },
                new Category { Id = 310, Title = "Páté dveøe", FilterWord = "Volkswagen Passat B6 páté dveøe", ParentId = 305, IsVisible = false },
                new Category { Id = 311, Title = "Zadní nárazník", FilterWord = "Volkswagen Passat B6 zadní nárazník", ParentId = 305, IsVisible = false },
                new Category { Id = 312, Title = "Pøední nárazník", FilterWord = "Volkswagen Passat B6 pøední nárazník", ParentId = 305, IsVisible = false },
                new Category { Id = 313, Title = "Levý blatník", FilterWord = "Volkswagen Passat B6 levý blatník", ParentId = 305, IsVisible = false },
                new Category { Id = 314, Title = "Pravý blatník", FilterWord = "Volkswagen Passat B6 pravý blatník", ParentId = 305, IsVisible = false },

                new Category { Id = 315, Title = "Interiér", FilterWord = "Volkswagen interiér", ParentId = 10, IsVisible = true },
                new Category { Id = 316, Title = "Sedaèky", FilterWord = "Volkswagen Passat B6 sedaèky", ParentId = 315, IsVisible = false },
                new Category { Id = 317, Title = "Plato kufru", FilterWord = "Volkswagen Passat B6 plato kufru", ParentId = 315, IsVisible = false },
                new Category { Id = 318, Title = "Roleta kufru", FilterWord = "Volkswagen Passat B6 roleta kufru", ParentId = 315, IsVisible = false },



                new Category { Id = 319, Title = "Motor", FilterWord = "Volkswagen motor", ParentId = 10, IsVisible = true },
                new Category { Id = 320, Title = "Škrtící klapka 2.0 TDI VW Passat B6", FilterWord = "Volkswagen Passat B6 2.0 TDI škrtící klapka", ParentId = 319, IsVisible = false },
                new Category { Id = 321, Title = "Palivové èerpadlo 1.9 TDI VW Passat B6", FilterWord = "Volkswagen Passat B6 1.9 TDI palivové èerpadlo", ParentId = 319, IsVisible = false },
                new Category { Id = 322, Title = "Turbo 1.9 TDI VW Passat", FilterWord = "Volkswagen Passat B6 1.9 TDI turbo", ParentId = 319, IsVisible = false },
                new Category { Id = 323, Title = "Turbo 2.0 TDI VW Passat", FilterWord = "Volkswagen Passat B6 2.0 TDI turbo", ParentId = 319, IsVisible = false },


                new Category { Id = 324, Title = "Pøevodovka", FilterWord = "Volkswagen Passat B6 pøevodovka", ParentId = 10, IsVisible = true },
                new Category { Id = 325, Title = "Pøevodovka 1.9 TDI VW Passsat", FilterWord = "Volkswagen Passat B6 1.9 TDI pøevodovka", ParentId = 324, IsVisible = false },
                new Category { Id = 326, Title = "Pøevodovka 2.0 TDI DSG", FilterWord = "Volkswagen Passat B6 2.0 TDI DSG pøevodovka", ParentId = 324, IsVisible = false },



                new Category { Id = 327, Title = "Klimatizace", FilterWord = "Volkswagen Passat B6 klimatizace", ParentId = 10, IsVisible = true },
                new Category { Id = 328, Title = "Klima kompresor VW Passat B6", FilterWord = "Volkswagen Passat B6 klima kompresor", ParentId = 327, IsVisible = false },
                new Category { Id = 329, Title = "Klima kompresor VW Golf V", FilterWord = "Volkswagen Golf V klima kompresor", ParentId = 327, IsVisible = false },
                new Category { Id = 330, Title = "Klima kompresor VW Golf IV", FilterWord = "Volkswagen Golf IV klima kompresor", ParentId = 327, IsVisible = false },
                new Category { Id = 331, Title = "Ovladaè klimatizace", FilterWord = "Volkswagen Golf IV ovladaè klimatizace", ParentId = 327, IsVisible = false },


                new Category { Id = 332, Title = "Podvozek", FilterWord = "Volkswagen podvozek", ParentId = 10, IsVisible = true },
                new Category { Id = 333, Title = "Zadní náprava VW Passat B6", FilterWord = "Volkswagen Passat B6 zadní náprava", ParentId = 332, IsVisible = false },
                new Category { Id = 334, Title = "Zadní náprava VW Golf IV", FilterWord = "Volkswagen Golf IV zadní náprava", ParentId = 332, IsVisible = false },
                new Category { Id = 335, Title = "Øízení", FilterWord = "Volkswagen Passat B6 øízení", ParentId = 332, IsVisible = false },

                new Category { Id = 336, Title = "Brzdový systém", FilterWord = "Volkswagen brzdový systém", ParentId = 10, IsVisible = true },
                new Category { Id = 337, Title = "Levý zadní tømen", FilterWord = "Volkswagen Golf IV levý zadní tømen", ParentId = 336, IsVisible = false },
                new Category { Id = 338, Title = "Elektroinstalace", FilterWord = "Volkswagen Golf IV elektroinstalace", ParentId = 10, IsVisible = true },
                new Category { Id = 339, Title = "Motorek zadního stìraèe", FilterWord = "Volkswagen Passat B6 motorek zadního stìraèe", ParentId = 338, IsVisible = false },
                new Category { Id = 340, Title = "Mechanismus stìraèù VW Golf IV", FilterWord = "Volkswagen Golf IV táhla stìraèù", ParentId = 338, IsVisible = false },
                new Category { Id = 341, Title = "Mechanismus stìraèù VW Passat B6", FilterWord = "Volkswagen Passat B6 táhla stìraèù", ParentId = 338, IsVisible = false },
                new Category { Id = 342, Title = "Øídící jednotka ABS VW Golf IV", FilterWord = "Volkswagen Golf IV øídící jednotka ABS", ParentId = 338, IsVisible = false },
                new Category { Id = 343, Title = "Alternátor 2.0 TDI VW Passat B6", FilterWord = "Volkswagen Passat B6 2.0 TDI alternátor", ParentId = 338, IsVisible = false },
                new Category { Id = 344, Title = "Alternátor 1.9 TDI VW Passat B6", FilterWord = "Volkswagen Passat B6 1.9 TDI alternátor", ParentId = 338, IsVisible = false },




                new Category { Id = 345, Title = "Karoserie", FilterWord = "Seat karoserie", ParentId = 12, IsVisible = true },
                new Category { Id = 346, Title = "Pøední svìtla", FilterWord = "Seat Leon pøední svìtla", ParentId = 345, IsVisible = false },
                new Category { Id = 347, Title = "Pøední nárazník Seat Ibiza", FilterWord = "Seat Ibiza pøední nárazník", ParentId = 345, IsVisible = false },
                new Category { Id = 348, Title = "Pøední nárazník Seat Leon", FilterWord = "Seat Leon pøední nárazník", ParentId = 345, IsVisible = false },
                new Category { Id = 349, Title = "Zadní nárazník Seat Leon", FilterWord = "Seat Leon zadní nárazník", ParentId = 345, IsVisible = false },
                new Category { Id = 350, Title = "Pøední nárazník Seat Ibiza", FilterWord = "Seat Ibiza pøední nárazník", ParentId = 345, IsVisible = false },



                new Category { Id = 351, Title = "Interiér", FilterWord = "Seat interiér", ParentId = 12, IsVisible = true },
                new Category { Id = 352, Title = "Sedaèky", FilterWord = "Seat Leon sedaèky", ParentId = 351, IsVisible = false },
                new Category { Id = 353, Title = "Plato kufru", FilterWord = "Seat Leon plato kufru", ParentId = 351, IsVisible = false },

                new Category { Id = 354, Title = "Motor", FilterWord = "Volkswagen motor", ParentId = 12, IsVisible = true },
                new Category { Id = 355, Title = "Palivové èerpadlo 1.9 TDI Seat Leon", FilterWord = "Seat Leon 1.9 TDI palivové èerpadlo", ParentId = 354, IsVisible = false },
                new Category { Id = 356, Title = "Turbo 1.9 TDI", FilterWord = "Seat Leon 1.9 TDI turbo", ParentId = 354, IsVisible = false },

                new Category { Id = 357, Title = "Pøevodovka", FilterWord = "Seat Leon pøevodovka", ParentId = 12, IsVisible = true },
                new Category { Id = 358, Title = "Pøevodovka 1.9 TDI Seat Leon", FilterWord = "Seat Leon 1.9 TDI pøevodovka", ParentId = 357, IsVisible = false },

                new Category { Id = 359, Title = "Klimatizace", FilterWord = "Seat Leon klimatizace", ParentId = 12, IsVisible = true },
                new Category { Id = 360, Title = "Klima kompresor Seat Leon", FilterWord = "Seat Leon klima kompresor", ParentId = 359, IsVisible = false },
                new Category { Id = 361, Title = "Ovladaè klimatizace", FilterWord = "Seat Leon ovladaè klimatizace", ParentId = 359, IsVisible = false },

                new Category { Id = 362, Title = "Podvozek", FilterWord = "Seat Leon podvozek", ParentId = 12, IsVisible = true },
                new Category { Id = 363, Title = "Zadní náprava", FilterWord = "Seat Leon zadní náprava", ParentId = 362, IsVisible = false },
                new Category { Id = 364, Title = "Øízení", FilterWord = "Seat Leon øízení", ParentId = 362, IsVisible = false },

                new Category { Id = 365, Title = "Brzdový systém", FilterWord = "Seat brzdový systém", ParentId = 12, IsVisible = true },
                new Category { Id = 366, Title = "Levý zadní tømen", FilterWord = "Seat Leon levý zadní tømen", ParentId = 365, IsVisible = false },
                new Category { Id = 367, Title = "Pravý zadní tømen", FilterWord = "Seat Leon pravý zadní tømen", ParentId = 365, IsVisible = false },


                new Category { Id = 368, Title = "Elektroinstalace", FilterWord = "Seat Leon elektroinstalace", ParentId = 12, IsVisible = true },
                new Category { Id = 369, Title = "Øídící jednotka ABS", FilterWord = "Seat Leon øídící jednotka ABS", ParentId = 368, IsVisible = false },
                new Category { Id = 370, Title = "Alternátor 1.9 TDI", FilterWord = "Seat Leon 1.9 TDI alternátor", ParentId = 368, IsVisible = false },



                new Category { Id = 371, Title = "Karoserie", FilterWord = "Audi karoserie", ParentId = 11, IsVisible = true },
                new Category { Id = 372, Title = "Pøední svìtla", FilterWord = "Audi A6 pøední svìtla", ParentId = 371, IsVisible = false },
                new Category { Id = 373, Title = "Pøední nárazník Audi A6", FilterWord = "Audi A6 pøední nárazník", ParentId = 371, IsVisible = false },
                new Category { Id = 374, Title = "Zadní nárazník Audi A3", FilterWord = "Audi A3 zadní nárazník", ParentId = 371, IsVisible = false },
                new Category { Id = 375, Title = "Zadní nárazník Audi A6", FilterWord = "Audi A6 pøední nárazník", ParentId = 371, IsVisible = false },


                new Category { Id = 376, Title = "Interiér", FilterWord = "Audi interiér", ParentId = 11, IsVisible = true },
                new Category { Id = 377, Title = "Sedaèky", FilterWord = "Audi A6 sedaèky", ParentId = 376, IsVisible = false },


                new Category { Id = 378, Title = "Motor", FilterWord = "Audi motor", ParentId = 11, IsVisible = true },
                new Category { Id = 379, Title = "Palivové èerpadlo 1.9 TDI", FilterWord = "Audi A3 1.9 TDI palivové èerpadlo", ParentId = 378, IsVisible = false },
                new Category { Id = 380, Title = "Turbo 1.9 TDI", FilterWord = "Audi A3 1.9 TDI turbo", ParentId = 378, IsVisible = false },


                new Category { Id = 381, Title = "Pøevodovka", FilterWord = "Audi pøevodovka", ParentId = 11, IsVisible = true },
                new Category { Id = 382, Title = "Pøevodovka 1.9 TDI", FilterWord = "Audi A3 1.9 TDI pøevodovka", ParentId = 381, IsVisible = false },

                new Category { Id = 383, Title = "Klimatizace", FilterWord = "Audi klimatizace", ParentId = 11, IsVisible = true },
                new Category { Id = 384, Title = "Klima kompresor Seat Leon", FilterWord = "Audi klima kompresor", ParentId = 383, IsVisible = false },


                new Category { Id = 385, Title = "Podvozek", FilterWord = "Audi podvozek", ParentId = 11, IsVisible = true },
                new Category { Id = 386, Title = "Zadní náprava", FilterWord = "Audi A3 zadní náprava", ParentId = 385, IsVisible = false },
                new Category { Id = 387, Title = "Øízení", FilterWord = "Audi A3 øízení", ParentId = 385, IsVisible = false },

                new Category { Id = 388, Title = "Brzdový systém", FilterWord = "Audi brzdový systém", ParentId = 11, IsVisible = true },
                new Category { Id = 389, Title = "Levý zadní tømen", FilterWord = "Audi A6 levý zadní tømen", ParentId = 388, IsVisible = false },
                new Category { Id = 390, Title = "Pravý zadní tømen", FilterWord = "Audi A6 pravý zadní tømen", ParentId = 388, IsVisible = false },

                new Category { Id = 391, Title = "Elektroinstalace", FilterWord = "Audi elektroinstalace", ParentId = 11, IsVisible = true },
                new Category { Id = 392, Title = "Øídící jednotka ABS", FilterWord = "Audi A3 øídící jednotka ABS", ParentId = 391, IsVisible = false },
                new Category { Id = 393, Title = "Alternátor", FilterWord = "Audi A3 1.9 TDI alternátor", ParentId = 391, IsVisible = false },



                new Category { Id = 394, Title = "Karoserie", FilterWord = "BMW karoserie", ParentId = 13, IsVisible = true },
                new Category { Id = 395, Title = "Pøední svìtla", FilterWord = "BMW E90 pøední svìtla", ParentId = 394, IsVisible = false },
                new Category { Id = 396, Title = "Levé pøední dveøe E90", FilterWord = "BMW E90 levé pøední dveøe", ParentId = 394, IsVisible = false },
                new Category { Id = 397, Title = "Pravé pøední dveøe E90", FilterWord = "BMW E90 pravé pøední dveøe", ParentId = 394, IsVisible = false },
                new Category { Id = 399, Title = "Levé zadní dveøe", FilterWord = "BMW E90 levé zadní dveøe", ParentId = 394, IsVisible = false },
                new Category { Id = 400, Title = "Pravé zadní dveøe", FilterWord = "BMW E90 pravé zadní dveøe", ParentId = 394, IsVisible = false },
                new Category { Id = 401, Title = "Levé pøední dveøe E92", FilterWord = "BMW E92 levé pøední dveøe", ParentId = 394, IsVisible = false },
                new Category { Id = 402, Title = "Pravé pøední dveøe E92", FilterWord = "BMW E92 pravé pøední dveøe", ParentId = 394, IsVisible = false },
                new Category { Id = 403, Title = "Páté dveøe E91", FilterWord = "BMW E91 páté dveøe", ParentId = 394, IsVisible = false },
                new Category { Id = 404, Title = "Páté dveøe E61", FilterWord = "BMW E61 páté dveøe", ParentId = 394, IsVisible = false },
                new Category { Id = 405, Title = "Zadní nárazník", FilterWord = "BMW E90 zadní nárazník", ParentId = 394, IsVisible = false },
                new Category { Id = 406, Title = "Pøední nárazník M Paket E90", FilterWord = "BMW E90 pøední nárazník M Paket", ParentId = 394, IsVisible = false },
                new Category { Id = 407, Title = "Pøední nárazník M Paket E92", FilterWord = "BMW E92 pøední nárazník M Paket", ParentId = 394, IsVisible = false },
                new Category { Id = 408, Title = "Zadní nárazník E90 M paket", FilterWord = "BMW E90 zadní nárazník M Paket", ParentId = 394, IsVisible = false },
                new Category { Id = 409, Title = "Zadní nárazník E92 M paket", FilterWord = "BMW E92 zadní nárazník M Paket", ParentId = 394, IsVisible = false },
                new Category { Id = 410, Title = "Pøední nárazník E90", FilterWord = "BMW E90 pøední nárazník", ParentId = 394, IsVisible = false },
                new Category { Id = 411, Title = "Levé zrcátko", FilterWord = "BMW E90 levé zrcátko", ParentId = 394, IsVisible = false },
                new Category { Id = 412, Title = "Pravé zrcátko", FilterWord = "BMW E90 pravé zrcátko", ParentId = 394, IsVisible = false },
                new Category { Id = 413, Title = "Kapota E90", FilterWord = "BMW E90 kapota", ParentId = 394, IsVisible = false },
                new Category { Id = 414, Title = "Kapota E92", FilterWord = "BMW E92 kapota", ParentId = 394, IsVisible = false },


                new Category { Id = 415, Title = "Interiér", FilterWord = "BMW interiér", ParentId = 13, IsVisible = true },
                new Category { Id = 416, Title = "Volant", FilterWord = "BMW E90 volant", ParentId = 415, IsVisible = false },
                new Category { Id = 417, Title = "Støedový tunel", FilterWord = "BMW E90 støedový tunel", ParentId = 415, IsVisible = false },
                new Category { Id = 418, Title = "Sedaèky E90", FilterWord = "BMW E90 sedaèky", ParentId = 415, IsVisible = false },
                new Category { Id = 419, Title = "Sedaèky E92", FilterWord = "BMW E92 sedaèky", ParentId = 415, IsVisible = false },
                new Category { Id = 420, Title = "Loketní opìrka", FilterWord = "BMW E90 loketní opìrka", ParentId = 415, IsVisible = false },
                new Category { Id = 421, Title = "Spínaè svìtel", FilterWord = "BMW E90 spínaè svìtel", ParentId = 415, IsVisible = false },
                new Category { Id = 422, Title = "Roleta kufru", FilterWord = "BMW E91 roleta kufru", ParentId = 415, IsVisible = false },
                new Category { Id = 423, Title = "Výdechy topení", FilterWord = "BMW E90 výdechy topení", ParentId = 415, IsVisible = false },
                new Category { Id = 424, Title = "Levý výdech topení", FilterWord = "BMW E90 levý výdech topení", ParentId = 415, IsVisible = false },
                new Category { Id = 425, Title = "Pravý výdech topení", FilterWord = "BMW E90 pravý výdech topení", ParentId = 415, IsVisible = false },
                new Category { Id = 426, Title = "Støedový výdech topení", FilterWord = "BMW E90 støedový výdech topení", ParentId = 415, IsVisible = false },
                new Category { Id = 427, Title = "Popelník", FilterWord = "BMW E90 popelník", ParentId = 415, IsVisible = false },

                new Category { Id = 428, Title = "Motor", FilterWord = "BMW motor", ParentId = 13, IsVisible = true },
                new Category { Id = 429, Title = "Motor N46B20B", FilterWord = "BMW motor N46B20B motor", ParentId = 428, IsVisible = false },
                new Category { Id = 430, Title = "Motor N46B20A", FilterWord = "BMW motor N46B20A motor", ParentId = 428, IsVisible = false },
                new Category { Id = 431, Title = "Motor N47D20A ", FilterWord = "BMW motor N47D20A motor", ParentId = 428, IsVisible = false },
                new Category { Id = 432, Title = "Servo èerpadlo ", FilterWord = "BMW E90 320i servoèerpadlo", ParentId = 428, IsVisible = false },


                new Category { Id = 433, Title = "Klimatizace", FilterWord = "BMW klimatizace", ParentId = 12, IsVisible = true },
                new Category { Id = 434, Title = "Klima kompresor", FilterWord = "BMW E90 klima kompresor", ParentId = 433, IsVisible = false },

                new Category { Id = 435, Title = "Autorádia", FilterWord = "Autorádio", ParentId = 2, IsVisible = true },

                new Category { Id = 436, Title = "Øadící páky", FilterWord = "Øadící páka", ParentId = 2, IsVisible = true },

                new Category { Id = 437, Title = "LED osvìtlení", FilterWord = "LED osvìtlení", ParentId = 2, IsVisible = true },
                new Category { Id = 438, Title = "Škoda", FilterWord = "Škoda", ParentId = 437, IsVisible = true },
                new Category { Id = 439, Title = "Škoda Octavia 2", FilterWord = "Škoda Octavia 2", ParentId = 438, IsVisible = true },
                new Category { Id = 440, Title = "Exteriér", FilterWord = "Škoda Octavia 2 LED osvìtlení exteriéru", ParentId = 439, IsVisible = true },
                new Category { Id = 441, Title = "Denní svícení", FilterWord = "Škoda Octavia 2 denní svícení", ParentId = 440, IsVisible = true },
                new Category { Id = 442, Title = "Mlhovky", FilterWord = "Škoda Octavia 2 mlhovky", ParentId = 440, IsVisible = true },
                new Category { Id = 443, Title = "Osvìtlení SPZ", FilterWord = "Škoda Octavia 2 LED osvìtlení SPZ", ParentId = 440, IsVisible = true },
                new Category { Id = 444, Title = "Zpáteèka", FilterWord = "Škoda Octavia 2 LED osvìtlení zpáteèky", ParentId = 440, IsVisible = true },
                new Category { Id = 445, Title = "Osvìtlení nástupního prostoru", FilterWord = "Škoda Octavia 2 LED osvìtlení nástupního prostoru", ParentId = 440, IsVisible = true },
                new Category { Id = 446, Title = "Interiér", FilterWord = "Škoda Octavia 2 LED osvìtlení interiéru", ParentId = 439, IsVisible = true },

                new Category { Id = 447, Title = "Škoda Octavia 3", FilterWord = "Škoda", ParentId = 438, IsVisible = true },
                new Category { Id = 448, Title = "Exteriér", FilterWord = "Škoda Octavia 3 LED osvìtlení exteriér", ParentId = 447, IsVisible = true },
                new Category { Id = 449, Title = "Mlhovky", FilterWord = "Škoda Octavia 3 mlhovky", ParentId = 448, IsVisible = true },
                new Category { Id = 450, Title = "Osvìtlení SPZ", FilterWord = "Škoda Octavia 3 LED osvìtlení SPZ", ParentId = 448, IsVisible = true },
                new Category { Id = 451, Title = "Zpáteèka", FilterWord = "Škoda Octavia 3 LED osvìtlení zpáteèky", ParentId = 448, IsVisible = true },
                new Category { Id = 452, Title = "Osvìtlení nástupního prostoru", FilterWord = "Škoda Octavia 3 LED osvìtlení nástupního prostoru", ParentId = 448, IsVisible = true },
                new Category { Id = 453, Title = "Interiér", FilterWord = "Škoda Octavia 3 LED osvìtlení interiéru", ParentId = 447, IsVisible = true },

                new Category { Id = 454, Title = "BMW", FilterWord = "BMW", ParentId = 437, IsVisible = true },
                new Category { Id = 455, Title = "Exteriér", FilterWord = "BMW LED osvìtlení exteriéru", ParentId = 454, IsVisible = true },
                new Category { Id = 456, Title = "LED markery", FilterWord = "BMW E90 led markery", ParentId = 455, IsVisible = true },
                new Category { Id = 457, Title = "Mlhovky", FilterWord = "BMW LED osvìtlení mlhovek", ParentId = 455, IsVisible = true },
                new Category { Id = 458, Title = "Osvìtlení SPZ", FilterWord = "BMW E90 LED osvìtlení SPZ", ParentId = 455, IsVisible = true },
                new Category { Id = 459, Title = "Zpáteèka", FilterWord = "BMW LED osvìtlení zpáteèky", ParentId = 455, IsVisible = true },
                new Category { Id = 460, Title = "LED blinkry", FilterWord = "BMW E92 LED blinkry", ParentId = 455, IsVisible = true },
                new Category { Id = 461, Title = "Zadní lampy", FilterWord = "BMW E90 zadní svìtla", ParentId = 455, IsVisible = true },
                new Category { Id = 462, Title = "Interiér", FilterWord = "BMW E90 LED osvìtlení interiéru", ParentId = 454, IsVisible = true },

                new Category { Id = 463, Title = "Volkswagen", FilterWord = "Volkswagen", ParentId = 437, IsVisible = true },
                new Category { Id = 464, Title = "Exteriér", FilterWord = "Volkswagen Passat B6 osvìtlení exteriéru", ParentId = 463, IsVisible = true },
                new Category { Id = 465, Title = "Mlhovky", FilterWord = "Volkswagen Passat B6 mlhovky", ParentId = 464, IsVisible = true },
                new Category { Id = 466, Title = "Osvìtlení SPZ", FilterWord = "BMW E90 LED osvìtlení SPZ", ParentId = 464, IsVisible = true },
                new Category { Id = 467, Title = "Zpáteèka", FilterWord = "Volkswagen Passat B6 LED osvìtlení zpáteèky", ParentId = 464, IsVisible = true },
                new Category { Id = 468, Title = "Interiér", FilterWord = "Volkswagen Passat B6 LED osvìtlení interiéru", ParentId = 463, IsVisible = true },
                new Category { Id = 469, Title = "Univerzální", FilterWord = "Univerzální", ParentId = 437, IsVisible = true },



                new Category { Id = 470, Title = "Vany do kufru", FilterWord = "Vany do kufru", ParentId = 2, IsVisible = true },
                new Category { Id = 471, Title = "Znaky", FilterWord = "Znaky", ParentId = 2, IsVisible = true },
                new Category { Id = 472, Title = "Carbon design", FilterWord = "Carbon design", ParentId = 2, IsVisible = true },
                new Category { Id = 473, Title = "Autokosmetika", FilterWord = "Autokosmetika", ParentId = 2, IsVisible = true },
                new Category { Id = 474, Title = "Masky a spoilery", FilterWord = "Spoiler", ParentId = 2, IsVisible = true },
                new Category { Id = 475, Title = "Kobereèky", FilterWord = "Kobereèky", ParentId = 2, IsVisible = true },
                new Category { Id = 476, Title = "Škoda", FilterWord = "Škoda Octavia kobereèky", ParentId = 475, IsVisible = true },
                new Category { Id = 477, Title = "BMW", FilterWord = "BMW kobereèky", ParentId = 475, IsVisible = true },
                new Category { Id = 478, Title = "Volkswagen", FilterWord = "Volkswagen kobereèky", ParentId = 475, IsVisible = true },
                new Category { Id = 479, Title = "Pedály", FilterWord = "Pedály", ParentId = 2, IsVisible = true },
                new Category { Id = 480, Title = "Prahy", FilterWord = "Prahy", ParentId = 2, IsVisible = true },
                new Category { Id = 481, Title = "Ochranné lišty", FilterWord = "Ochranné lišty", ParentId = 2, IsVisible = true },
                new Category { Id = 482, Title = "Ostatní", FilterWord = "Ostatní", ParentId = 2, IsVisible = true },



                new Category { Id = 483, Title = "Chci pøestavbu svìtel", FilterWord = "pøestavba svìtel", ParentId = 3, IsVisible = true },
                new Category { Id = 484, Title = "Audi", FilterWord = "Audi LED pøední svìtla", ParentId = 483, IsVisible = true },
                new Category { Id = 485, Title = "BMW", FilterWord = "BMW LED pøední svìtla", ParentId = 483, IsVisible = true },
                new Category { Id = 486, Title = "Volkswagen", FilterWord = "Volkswagen LED pøední svìtla", ParentId = 483, IsVisible = true },
                new Category { Id = 487, Title = "Peugeot", FilterWord = "Peugeot LED pøední svìtla", ParentId = 483, IsVisible = true },
                new Category { Id = 488, Title = "Škoda", FilterWord = "Škoda LED pøední svìtla", ParentId = 483, IsVisible = true },
                new Category { Id = 489, Title = "Ford", FilterWord = "Ford Focus LED pøední svìtla", ParentId = 483, IsVisible = true },
                new Category { Id = 490, Title = "Chci koupit celá svìtla", FilterWord = "LED svìtlomety", ParentId = 3, IsVisible = true },
                new Category { Id = 491, Title = "Audi", FilterWord = "Audi LED svìtlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 492, Title = "BMW", FilterWord = "BMW LED svìtlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 493, Title = "Volkswagen", FilterWord = "Volkswagen LED svìtlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 494, Title = "Peugeot", FilterWord = "Peugeot LED svìtlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 495, Title = "Škoda", FilterWord = "Škoda LED svìtlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 496, Title = "Ford", FilterWord = "Ford Focus LED svìtlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 497, Title = "Škoda Superb", FilterWord = "Škoda Superb", ParentId = 4, IsVisible = true }
                 );
        }
    }
}
