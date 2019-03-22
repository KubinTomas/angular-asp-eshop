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
             new ItemState { Id = 1, Name = "Nov�" },
             new ItemState { Id = 2, Name = "Pou�it�" }
          );

            context.Categories.AddOrUpdate(c => c.Id,
            new Category { Id = 1, Title = "N�hradn� d�ly", FilterWord = "N�hradn� d�ly", ParentId = null, IsVisible = true },
                new Category { Id = 2, Title = "Autodopl�ky", FilterWord = "Autodopl�ky", ParentId = null, IsVisible = true },
                new Category { Id = 3, Title = "P�estavba sv�tel", FilterWord = "P�estavba sv�tel", ParentId = null, IsVisible = true },

                new Category { Id = 4, Title = "�koda", FilterWord = "�koda", ParentId = 1, IsVisible = true },

                new Category { Id = 5, Title = "�koda Fabia", FilterWord = "�koda Fabia", ParentId = 4, IsVisible = true },

                new Category { Id = 6, Title = "�koda Octavia", FilterWord = "�koda Octavia ", ParentId = 4, IsVisible = true },
                new Category { Id = 7, Title = "�koda Octavia I", FilterWord = "�koda Octavia I ", ParentId = 6, IsVisible = true },
                new Category { Id = 8, Title = "�koda Octavia II", FilterWord = "�koda Octavia II", ParentId = 6, IsVisible = true },
                new Category { Id = 9, Title = "�koda Octavia III", FilterWord = "�koda Octavia III", ParentId = 6, IsVisible = true },
                new Category { Id = 10, Title = "Volkswagen", FilterWord = "Volkswagen", ParentId = 1, IsVisible = true },
                new Category { Id = 11, Title = "Audi", FilterWord = "Audi", ParentId = 1, IsVisible = true },
                new Category { Id = 12, Title = "Seat", FilterWord = "Seat", ParentId = 1, IsVisible = true },
                new Category { Id = 13, Title = "BMW", FilterWord = "BMW", ParentId = 1, IsVisible = true },

                new Category { Id = 14, Title = "Karoserie", FilterWord = "�koda Fabia karoserie", ParentId = 5, IsVisible = true },
                new Category { Id = 15, Title = "Interi�r", FilterWord = "�koda Fabia interi�r", ParentId = 5, IsVisible = true },
                new Category { Id = 16, Title = "Motor", FilterWord = "�koda Fabia I motor", ParentId = 5, IsVisible = true },
                new Category { Id = 17, Title = "P�evodovka", FilterWord = "�koda Fabia I p�evodovka", ParentId = 5, IsVisible = true },
                new Category { Id = 18, Title = "Klimatizace", FilterWord = "�koda Fabia I klima kompresor", ParentId = 5, IsVisible = true },
                new Category { Id = 19, Title = "Elektroinstalace", FilterWord = "�koda Fabia I kabel� v�h�evu seda�ek", ParentId = 5, IsVisible = true },
                new Category { Id = 20, Title = "Podvozek", FilterWord = "�koda Fabia I podvozek", ParentId = 5, IsVisible = true },

                new Category { Id = 21, Title = "P�edn� sv�tla", FilterWord = "�koda Fabia I p�edn� sv�tla", ParentId = 14, IsVisible = false },
                new Category { Id = 22, Title = "Zadn� sv�tla", FilterWord = "�koda Fabia I zadn� sv�tla", ParentId = 14, IsVisible = false },
                new Category { Id = 23, Title = "Lev� p�edn� dve�e", FilterWord = "�koda Fabia I lev� p�edn� dve�e", ParentId = 14, IsVisible = false },
                new Category { Id = 24, Title = "Prav� p�edn� dve�e", FilterWord = "�koda Fabia I prav� p�edn� dve�e", ParentId = 14, IsVisible = false },
                new Category { Id = 25, Title = "Lev� zadn� dve�e", FilterWord = "�koda Fabia I lev� zadn� dve�e", ParentId = 14, IsVisible = false },
                new Category { Id = 26, Title = "Prav� zadn� dve�e", FilterWord = "�koda Fabia I prav� zadn� dve�e", ParentId = 14, IsVisible = false },
                new Category { Id = 27, Title = "P�t� dve�e", FilterWord = "�koda Fabia I p�t� dve�e", ParentId = 14, IsVisible = false },
                new Category { Id = 28, Title = "Zadn� n�razn�k", FilterWord = "�koda Fabia I zadn� n�razn�k", ParentId = 14, IsVisible = false },
                new Category { Id = 29, Title = "P�edn� n�razn�k", FilterWord = "�koda Fabia I p�edn� n�razn�k", ParentId = 14, IsVisible = false },
                new Category { Id = 30, Title = "Lev� zrc�tko", FilterWord = "�koda Fabia I lev� zrc�tko", ParentId = 14, IsVisible = false },
                new Category { Id = 31, Title = "Prav� zrc�tko", FilterWord = "�koda Fabia I prav� zrc�tko", ParentId = 14, IsVisible = false },
                new Category { Id = 32, Title = "Lev� blatn�k", FilterWord = "�koda Fabia I lev� blatn�k", ParentId = 14, IsVisible = false },
                new Category { Id = 33, Title = "Prav� blatn�k", FilterWord = "�koda Fabia I prav� blatn�k", ParentId = 14, IsVisible = false },
                new Category { Id = 34, Title = "Maska", FilterWord = "�koda Fabia I maska", ParentId = 14, IsVisible = false },

                new Category { Id = 35, Title = "Volant", FilterWord = "�koda Fabia I volant", ParentId = 15, IsVisible = false },
                new Category { Id = 36, Title = "Palubka", FilterWord = "�koda Fabia I palubka", ParentId = 15, IsVisible = false },
                new Category { Id = 37, Title = "St�edov� tunel", FilterWord = "�koda Fabia I st�edov� tunel", ParentId = 15, IsVisible = false },
                new Category { Id = 38, Title = "Seda�ky", FilterWord = "�koda Fabia I seda�ky", ParentId = 15, IsVisible = false },
                new Category { Id = 39, Title = "Loketn� op�rka", FilterWord = "�koda Fabia I loketn� op�rka", ParentId = 15, IsVisible = false },
                new Category { Id = 40, Title = "Stropnice", FilterWord = "�koda Fabia I stropnice", ParentId = 15, IsVisible = false },
                new Category { Id = 41, Title = "Plato kufru", FilterWord = "�koda Fabia I plato kufru", ParentId = 15, IsVisible = false },
                new Category { Id = 42, Title = "Sp�na� sv�tel", FilterWord = "�koda Fabia I sp�na� sv�tel", ParentId = 15, IsVisible = false },
                new Category { Id = 43, Title = "Roleta kufru", FilterWord = "�koda Fabia I roleta kufru", ParentId = 15, IsVisible = false },


                new Category { Id = 44, Title = "Chladi�ov� st�na", FilterWord = "�koda Fabia I chladi�ov� st�na", ParentId = 16, IsVisible = false },
                new Category { Id = 45, Title = "Chladi�ov� st�na F3", FilterWord = "�koda Fabia III chladi�ov� st�na", ParentId = 16, IsVisible = false },


                new Category { Id = 46, Title = "P�evodovka 1.9 TDI 96 kw", FilterWord = "�koda Fabia I 1.9 TDI 96 kw p�evodovka", ParentId = 17, IsVisible = false },
                new Category { Id = 47, Title = "P�evodovka 1.9 SDI 47 kw", FilterWord = "�koda Fabia I 1.9 SDI p�evodovka", ParentId = 17, IsVisible = false },
                new Category { Id = 48, Title = "Start�r", FilterWord = "�koda Fabia 1.4 start�r", ParentId = 17, IsVisible = false },


                new Category { Id = 49, Title = "Zadn� n�prava", FilterWord = "�koda Fabia I zadn� n�prava", ParentId = 20, IsVisible = false },
                new Category { Id = 50, Title = "Brzdov� syst�m", FilterWord = "�koda Fabia I brzdov� syst�m", ParentId = 20, IsVisible = false },
                new Category { Id = 51, Title = "Lev� zadn� t�men", FilterWord = "�koda Fabia I lev� zadn� t�men", ParentId = 20, IsVisible = false },
                new Category { Id = 52, Title = "Prav� zadn� t�men", FilterWord = "�koda Fabia I prav� zadn� t�men", ParentId = 20, IsVisible = false },


                new Category { Id = 53, Title = "Karoserie", FilterWord = "�koda Octavia I karoserie", ParentId = 7, IsVisible = true },


                new Category { Id = 54, Title = "P�edn� sv�tla", FilterWord = "�koda Octavia I p�edn� sv�tla", ParentId = 53, IsVisible = false },
                new Category { Id = 45, Title = "Zadn� sv�tla", FilterWord = "�koda Octavia I zadn� sv�tla", ParentId = 53, IsVisible = false },
                new Category { Id = 56, Title = "Lev� p�edn� dve�e", FilterWord = "�koda Octavia I lev� p�edn� dve�e", ParentId = 53, IsVisible = false },
                new Category { Id = 57, Title = "Prav� p�edn� dve�e", FilterWord = "�koda Octavia I prav� p�edn� dve�e", ParentId = 53, IsVisible = false },
                new Category { Id = 58, Title = "Lev� zadn� dve�e", FilterWord = "�koda Octavia I lev� zadn� dve�e", ParentId = 53, IsVisible = false },
                new Category { Id = 59, Title = "Prav� zadn� dve�e", FilterWord = "�koda Octavia I prav� zadn� dve�e", ParentId = 53, IsVisible = false },
                new Category { Id = 60, Title = "P�t� dve�e", FilterWord = "�koda Octavia I p�t� dve�e", ParentId = 53, IsVisible = false },
                new Category { Id = 61, Title = "Zadn� n�razn�k", FilterWord = "�koda Octavia I zadn� n�razn�k", ParentId = 53, IsVisible = false },
                new Category { Id = 62, Title = "P�edn� n�razn�k", FilterWord = "�koda Octavia I p�edn� n�razn�k", ParentId = 53, IsVisible = false },
                new Category { Id = 63, Title = "Lev� zrc�tko", FilterWord = "�koda Octavia I lev� zrc�tko", ParentId = 53, IsVisible = false },
                new Category { Id = 64, Title = "Prav� zrc�tko", FilterWord = "�koda Octavia I prav� zrc�tko", ParentId = 53, IsVisible = false },
                new Category { Id = 65, Title = "Lev� blatn�k", FilterWord = "�koda Octavia I lev� blatn�k", ParentId = 53, IsVisible = false },
                new Category { Id = 66, Title = "Prav� blatn�k", FilterWord = "�koda Octavia I prav� blatn�k", ParentId = 53, IsVisible = false },
                new Category { Id = 67, Title = "Maska", FilterWord = "�koda Octavia I maska", ParentId = 53, IsVisible = false },
                new Category { Id = 68, Title = "Kapota", FilterWord = "�koda Octavia I kapota", ParentId = 53, IsVisible = false },
                new Category { Id = 69, Title = "P�edn� n�razn�k RS", FilterWord = "�koda Octavia I p�edn� n�razn�k RS", ParentId = 53, IsVisible = false },
                new Category { Id = 70, Title = "Lev� blinkr �ir�", FilterWord = "�koda Octavia I lev� blinkr", ParentId = 53, IsVisible = false },
                new Category { Id = 71, Title = "Prav� blinkr �ir�", FilterWord = "�koda Octavia I prav� blinkr", ParentId = 53, IsVisible = false },
                new Category { Id = 72, Title = "Lev� pant", FilterWord = "�koda Octavia I lev� pant", ParentId = 53, IsVisible = false },
                new Category { Id = 73, Title = "Vzp�ry kufru", FilterWord = "�koda Octavia I vp�ry kufru", ParentId = 53, IsVisible = false },
                new Category { Id = 74, Title = "�eln� sklo", FilterWord = "�koda Octavia I �eln� sklo", ParentId = 53, IsVisible = false },
                new Category { Id = 75, Title = "Li�ty zadn�ch sv�tel", FilterWord = "�koda Octavia I li�ty zadn�ch sv�tel", ParentId = 53, IsVisible = false },

                new Category { Id = 76, Title = "Interi�r", FilterWord = "�koda Octavia I interi�r", ParentId = 7, IsVisible = true },
                new Category { Id = 77, Title = "Volant", FilterWord = "�koda Octavia I volant", ParentId = 76, IsVisible = false },
                new Category { Id = 78, Title = "Palubka", FilterWord = "�koda Octavia I palubka", ParentId = 76, IsVisible = false },
                new Category { Id = 79, Title = "St�edov� tunel", FilterWord = "�koda Octavia I st�edov� tunel", ParentId = 76, IsVisible = false },
                new Category { Id = 80, Title = "Seda�ky", FilterWord = "�koda Octavia I seda�ky", ParentId = 76, IsVisible = false },
                new Category { Id = 81, Title = "Loketn� op�rka", FilterWord = "�koda Octavia I loketn� op�rka", ParentId = 76, IsVisible = false },
                new Category { Id = 82, Title = "Stropnice", FilterWord = "�koda Octavia I stropnice", ParentId = 76, IsVisible = false },
                new Category { Id = 83, Title = "Plato kufru", FilterWord = "�koda Octavia I plato kufru", ParentId = 76, IsVisible = false },
                new Category { Id = 84, Title = "Sp�na� sv�tel", FilterWord = "�koda Octavia I sp�na� sv�tel", ParentId = 76, IsVisible = false },
                new Category { Id = 85, Title = "Roleta kufru", FilterWord = "�koda Octavia I roleta kufru", ParentId = 76, IsVisible = false },
                new Category { Id = 86, Title = "V�dechy topen�", FilterWord = "�koda Octavia I v�dechy topen�", ParentId = 76, IsVisible = false },
                new Category { Id = 87, Title = "Lev� v�dech topen�", FilterWord = "�koda Octavia I lev� v�dech topen�", ParentId = 76, IsVisible = false },
                new Category { Id = 88, Title = "Prav� v�dech topen�", FilterWord = "�koda Octavia I prav� v�dech topen�", ParentId = 76, IsVisible = false },
                new Category { Id = 89, Title = "St�edov� v�dech topen�", FilterWord = "�koda Octavia I st�edov� v�dech topen�", ParentId = 76, IsVisible = false },
                new Category { Id = 90, Title = "Bud�ky", FilterWord = "�koda Octavia I bud�ky", ParentId = 76, IsVisible = false },
                new Category { Id = 91, Title = "Lev� p�edn� reproduktor", FilterWord = "�koda Octavia I lev� p�edn� reproduktor", ParentId = 76, IsVisible = false },
                new Category { Id = 92, Title = "Popeln�k", FilterWord = "�koda Octavia I popeln�k", ParentId = 76, IsVisible = false },
                new Category { Id = 93, Title = "Prav� p�edn� reproduktor", FilterWord = "�koda Octavia I prav� p�edn� reproduktor", ParentId = 76, IsVisible = false },
                new Category { Id = 94, Title = "Stropn� sv�tlo", FilterWord = "�koda Octavia I stropn� sv�tlo", ParentId = 76, IsVisible = false },
                new Category { Id = 95, Title = "Lev� p�edn� p�s", FilterWord = "�koda Octavia I lev� p�edn� p�s", ParentId = 76, IsVisible = false },
                new Category { Id = 96, Title = "R�me�ek klimatizace", FilterWord = "�koda Octavia I r�me�ek klimatizace", ParentId = 76, IsVisible = false },
                new Category { Id = 97, Title = "Madlo ru�n� brzdy", FilterWord = "�koda Octavia I madlo ru�n� brzdy", ParentId = 76, IsVisible = false },
                new Category { Id = 98, Title = "Prav� p�edn� p�s", FilterWord = "�koda Octavia I prav� p�edn� p�s", ParentId = 76, IsVisible = false },
                new Category { Id = 99, Title = "Lev� p�edn� p�s", FilterWord = "�koda Octavia I lev� p�edn� p�s", ParentId = 76, IsVisible = false },

                new Category { Id = 100, Title = "Motor", FilterWord = "�koda Octavia I motor", ParentId = 7, IsVisible = true },

                new Category { Id = 101, Title = "�krt�c� klapka 1.8T", FilterWord = "�koda Octavia 1.8T �krt�c� klapka", ParentId = 100, IsVisible = false },
                new Category { Id = 102, Title = "Chladi�ov� st�na", FilterWord = "�koda Octavia I chladi�ov� st�na", ParentId = 100, IsVisible = false },
                new Category { Id = 103, Title = "�krt�c� klapka 1.6i", FilterWord = "�koda Octavia 1.6i �krt�c� klapka", ParentId = 100, IsVisible = false },
                new Category { Id = 104, Title = "Palivov� �erpadlo 1.6i", FilterWord = "�koda Octavia 1.6i palivov� �erpadlo", ParentId = 100, IsVisible = false },
                new Category { Id = 105, Title = "Palivov� �erpadlo 1.8T", FilterWord = "�koda Octavia 1.8T palivov� �erpadlo", ParentId = 100, IsVisible = false },
                new Category { Id = 106, Title = "Motor 1.9 TDI", FilterWord = "�koda Octavia 1.9 TDI 66 kw motor", ParentId = 100, IsVisible = false },
                new Category { Id = 107, Title = "V�ha vzduchu 1.9 TDI", FilterWord = "�koda Octavia 1.9 TDI v�ha vzduchu", ParentId = 100, IsVisible = false },
                new Category { Id = 108, Title = "Intercooler 1.9 TDI", FilterWord = "�koda Octavia 1.9 TDI intercooler", ParentId = 100, IsVisible = false },
                new Category { Id = 109, Title = "Intercooler 1.8T", FilterWord = "�koda Octavia 1.8T intercooler", ParentId = 100, IsVisible = false },
                new Category { Id = 110, Title = "Svody", FilterWord = "�koda Octavia 1.8T svody", ParentId = 100, IsVisible = false },
                new Category { Id = 111, Title = "Turbo 1.9 TDI", FilterWord = "�koda Octavia 1.9 TDI turbo", ParentId = 100, IsVisible = false },
                new Category { Id = 112, Title = "Turbo 1.8T", FilterWord = "�koda Octavia 1.8T turbo", ParentId = 100, IsVisible = false },


                new Category { Id = 113, Title = "P�evodovka", FilterWord = "�koda Octavia I p�evodovka", ParentId = 7, IsVisible = true },
                new Category { Id = 114, Title = "Start�r 1.9 TDI", FilterWord = "�koda Octavia 1.9 TDI start�r", ParentId = 113, IsVisible = false },
                new Category { Id = 115, Title = "Start�r 1.8T", FilterWord = "�koda Octavia 1.8T start�r", ParentId = 113, IsVisible = false },
                new Category { Id = 116, Title = "P�evodovka 1.8T", FilterWord = "�koda Octavia 1.8T p�evodovka", ParentId = 113, IsVisible = false },
                new Category { Id = 117, Title = "P�evodovka 1.9 SDI", FilterWord = "�koda Octavia 1.9 SDI p�evodovka", ParentId = 113, IsVisible = false },
                new Category { Id = 118, Title = "P�evodovka 2.0i", FilterWord = "�koda Octavia 2.0i p�evodovka", ParentId = 113, IsVisible = false },
                new Category { Id = 119, Title = "P�evodovka 1.6i", FilterWord = "�koda Octavia 1.6i p�evodovka", ParentId = 113, IsVisible = false },
                new Category { Id = 120, Title = "P�evodovka 1.8i", FilterWord = "�koda Octavia 1.8i p�evodovka", ParentId = 113, IsVisible = false },

                new Category { Id = 121, Title = "Klimatizace", FilterWord = "�koda Octavia I kompletn� set klimatizace", ParentId = 7, IsVisible = true },
                new Category { Id = 122, Title = "Klima kompresor", FilterWord = "�koda Octavia I klima kompresor", ParentId = 121, IsVisible = false },
                new Category { Id = 123, Title = "Ovlada� klimatizace", FilterWord = "�koda Octavia I ovlada� klimatizace", ParentId = 121, IsVisible = false },

                new Category { Id = 124, Title = "Podvozek", FilterWord = "�koda Octavia I podvozek", ParentId = 7, IsVisible = true },
                new Category { Id = 125, Title = "Zadn� n�prava", FilterWord = "�koda Octavia I zadn� n�prava", ParentId = 124, IsVisible = false },
                new Category { Id = 126, Title = "Lev� poloosa", FilterWord = "�koda Octavia I 1.9 TDI lev� poloosa", ParentId = 124, IsVisible = false },
                new Category { Id = 127, Title = "Prav� poloosa", FilterWord = "�koda Octavia I 1.9 TDI prav� poloosa", ParentId = 124, IsVisible = false },
                new Category { Id = 128, Title = "��zen�", FilterWord = "�koda Octavia I ��zen�", ParentId = 124, IsVisible = false },
                new Category { Id = 129, Title = "Tlumi�e", FilterWord = "�koda Octavia I tlumi�e", ParentId = 124, IsVisible = false },

                new Category { Id = 130, Title = "Brzdov� syst�m", FilterWord = "�koda Octavia I brzdov� syst�m", ParentId = 7, IsVisible = true },
                new Category { Id = 131, Title = "Lev� zadn� t�men", FilterWord = "�koda Octavia I lev� zadn� t�men", ParentId = 130, IsVisible = false },
                new Category { Id = 132, Title = "Prav� zadn� t�men", FilterWord = "�koda Octavia I prav� zadn� t�men", ParentId = 130, IsVisible = false },
                new Category { Id = 133, Title = "Elektroinstalace", FilterWord = "�koda Octavia I elektroinstalace", ParentId = 7, IsVisible = true },

                new Category { Id = 134, Title = "Komfortn� jednotka", FilterWord = "1J0959799AH", ParentId = 133, IsVisible = false },
                new Category { Id = 135, Title = "Lev� p�edn� stahova�ka", FilterWord = "�koda Octavia I lev� p�edn� stahova�ka", ParentId = 133, IsVisible = false },
                new Category { Id = 136, Title = "Prav� p�edn� stahova�ka", FilterWord = "�koda Octavia I prav� p�edn� stahova�ka", ParentId = 133, IsVisible = false },
                new Category { Id = 137, Title = "Lev� zadn� stahova�ka", FilterWord = "�koda Octavia I lev� zadn� stahova�ka", ParentId = 133, IsVisible = false },
                new Category { Id = 138, Title = "Prav� zadn� stahova�ka", FilterWord = "�koda Octavia I prav� zadn� stahova�ka", ParentId = 133, IsVisible = false },
                new Category { Id = 139, Title = "Lev� p�edn� z�mek", FilterWord = "�koda Octavia I lev� p�edn� z�mek", ParentId = 133, IsVisible = false },
                new Category { Id = 140, Title = "Prav� p�edn� z�mek", FilterWord = "�koda Octavia I prav� p�edn� z�mek", ParentId = 133, IsVisible = false },
                new Category { Id = 141, Title = "Lev� zadn� z�mek", FilterWord = "�koda Octavia I lev� zadn� z�mek", ParentId = 133, IsVisible = false },
                new Category { Id = 142, Title = "Prav� p�edn� z�mek", FilterWord = "�koda Octavia I prav� zadn� z�mek", ParentId = 133, IsVisible = false },
                new Category { Id = 143, Title = "Motorek zadn�ho st�ra�e", FilterWord = "�koda Octavia I motorek zadn�ho st�ra�e", ParentId = 133, IsVisible = false },
                new Category { Id = 144, Title = "Mechanismus st�ra��", FilterWord = "�koda Octavia I t�hla st�ra��", ParentId = 133, IsVisible = false },
                new Category { Id = 145, Title = "��d�c� jednotka ABS", FilterWord = "�koda Octavia I ��d�c� jednotka ABS", ParentId = 133, IsVisible = false },
                new Category { Id = 146, Title = "Altern�tor 1.8T", FilterWord = "�koda Octavia I 1.8T altern�tor", ParentId = 133, IsVisible = false },
                new Category { Id = 147, Title = "Altern�tor 1.9 TDI", FilterWord = "�koda Octavia I 1.9 TDI altern�tor", ParentId = 133, IsVisible = false },
                new Category { Id = 148, Title = "��d�c� jednotka klimatizace", FilterWord = "�koda Octavia I ��d�c� jednotka klimatizace", ParentId = 133, IsVisible = false },
                new Category { Id = 149, Title = "Motorov� kabel� 1.6i", FilterWord = "�koda Octavia I motorov� kabel� 1.6i", ParentId = 133, IsVisible = false },
                new Category { Id = 150, Title = "Motorov� kabel� 1.8T", FilterWord = "�koda Octavia I motorov� kabel� 1.8T", ParentId = 133, IsVisible = false },
                new Category { Id = 151, Title = "Motorov� kabel� 1.8T RS", FilterWord = "�koda Octavia I motorov� kabel� 1.8T RS", ParentId = 133, IsVisible = false },
                new Category { Id = 152, Title = "Motorov� kabel� 1.9 TDI", FilterWord = "�koda Octavia I motorov� kabel� 1.9 TDI", ParentId = 133, IsVisible = false },
                new Category { Id = 153, Title = "Kabel� v�h�evu seda�ek", FilterWord = "�koda Octavia I kabel� v�h�evu seda�ek", ParentId = 133, IsVisible = false },
                new Category { Id = 154, Title = "Senzor p���n�ho zrychlen�", FilterWord = "�koda Octavia I senzor p���n�ho zrychlen�", ParentId = 133, IsVisible = false },
                new Category { Id = 155, Title = "Senzor pod�ln�ho zrychlen�", FilterWord = "�koda Octavia I senzor pod�ln�ho zrychlen�", ParentId = 133, IsVisible = false },



                new Category { Id = 156, Title = "Karoserie", FilterWord = "�koda Octavia II karoserie", ParentId = 8, IsVisible = true },
                new Category { Id = 157, Title = "P�edn� sv�tla", FilterWord = "�koda Octavia II p�edn� sv�tla", ParentId = 156, IsVisible = false },
                new Category { Id = 158, Title = "P�edn� sv�tla halogenov�", FilterWord = "�koda Octavia II halogenov� p�edn� sv�tla", ParentId = 157, IsVisible = false },
                new Category { Id = 159, Title = "P�edn� sv�tla xeny", FilterWord = "�koda Octavia II xenony", ParentId = 157, IsVisible = false },
                new Category { Id = 160, Title = "Zadn� sv�tla", FilterWord = "�koda Octavia II zadn� sv�tla", ParentId = 156, IsVisible = false },
                new Category { Id = 161, Title = "Lev� p�edn� dve�e", FilterWord = "�koda Octavia II lev� p�edn� dve�e", ParentId = 156, IsVisible = false },
                new Category { Id = 162, Title = "Prav� p�edn� dve�e", FilterWord = "�koda Octavia II prav� p�edn� dve�e", ParentId = 156, IsVisible = false },
                new Category { Id = 163, Title = "Lev� zadn� dve�e", FilterWord = "�koda Octavia II lev� zadn� dve�e", ParentId = 156, IsVisible = false },
                new Category { Id = 164, Title = "Prav� zadn� dve�e", FilterWord = "�koda Octavia II prav� zadn� dve�e", ParentId = 156, IsVisible = false },
                new Category { Id = 165, Title = "P�t� dve�e", FilterWord = "�koda Octavia II p�t� dve�e", ParentId = 156, IsVisible = false },
                new Category { Id = 166, Title = "Zadn� n�razn�k", FilterWord = "�koda Octavia II zadn� n�razn�k", ParentId = 156, IsVisible = false },
                new Category { Id = 167, Title = "P�edn� n�razn�k", FilterWord = "�koda Octavia II p�edn� n�razn�k", ParentId = 156, IsVisible = false },
                new Category { Id = 168, Title = "Lev� zrc�tko", FilterWord = "�koda Octavia II lev� zrc�tko", ParentId = 156, IsVisible = false },
                new Category { Id = 169, Title = "Prav� zrc�tko", FilterWord = "�koda Octavia II prav� zrc�tko", ParentId = 156, IsVisible = false },
                new Category { Id = 170, Title = "Lev� blatn�k", FilterWord = "�koda Octavia II lev� blatn�k", ParentId = 156, IsVisible = false },
                new Category { Id = 171, Title = "Prav� blatn�k", FilterWord = "�koda Octavia II prav� blatn�k", ParentId = 156, IsVisible = false },
                new Category { Id = 172, Title = "Maska", FilterWord = "�koda Octavia II maska", ParentId = 156, IsVisible = false },
                new Category { Id = 173, Title = "Kapota", FilterWord = "�koda Octavia II kapota", ParentId = 156, IsVisible = false },
                new Category { Id = 174, Title = "P�edn� n�razn�k RS", FilterWord = "�koda Octavia II p�edn� n�razn�k RS", ParentId = 156, IsVisible = false },
                new Category { Id = 175, Title = "�eln� sklo", FilterWord = "�koda Octavia II �eln� sklo", ParentId = 156, IsVisible = false },
                new Category { Id = 176, Title = "V�ztuha p�edn�ho n�razn�ku", FilterWord = "�koda Octavia II v�ztuha p�edn�ho n�razn�ku", ParentId = 156, IsVisible = false },




                new Category { Id = 178, Title = "Interi�r", FilterWord = "�koda Octavia II interi�r", ParentId = 8, IsVisible = true },
                new Category { Id = 179, Title = "Volant", FilterWord = "�koda Octavia II volant", ParentId = 178, IsVisible = false },
                new Category { Id = 180, Title = "Palubka", FilterWord = "�koda Octavia II palubka", ParentId = 178, IsVisible = false },
                new Category { Id = 181, Title = "St�edov� tunel", FilterWord = "�koda Octavia II st�edov� tunel", ParentId = 178, IsVisible = false },
                new Category { Id = 182, Title = "Seda�ky", FilterWord = "�koda Octavia II seda�ky", ParentId = 178, IsVisible = false },
                new Category { Id = 183, Title = "Loketn� op�rka", FilterWord = "�koda Octavia II loketn� op�rka", ParentId = 178, IsVisible = false },
                new Category { Id = 184, Title = "Stropnice", FilterWord = "�koda Octavia II stropnice", ParentId = 178, IsVisible = false },
                new Category { Id = 185, Title = "Plato kufru", FilterWord = "�koda Octavia II plato kufru", ParentId = 178, IsVisible = false },
                new Category { Id = 186, Title = "Sp�na� sv�tel", FilterWord = "�koda Octavia II sp�na� sv�tel", ParentId = 178, IsVisible = false },
                new Category { Id = 187, Title = "Roleta kufru", FilterWord = "�koda Octavia II roleta kufru", ParentId = 178, IsVisible = false },
                new Category { Id = 188, Title = "V�dechy topen�", FilterWord = "�koda Octavia II v�dechy topen�", ParentId = 178, IsVisible = false },
                new Category { Id = 189, Title = "Lev� v�dech topen�", FilterWord = "�koda Octavia II lev� v�dech topen�", ParentId = 178, IsVisible = false },
                new Category { Id = 190, Title = "Prav� v�dech topen�", FilterWord = "�koda Octavia II prav� v�dech topen�", ParentId = 178, IsVisible = false },
                new Category { Id = 191, Title = "St�edov� v�dech topen�", FilterWord = "�koda Octavia II st�edov� v�dech topen�", ParentId = 178, IsVisible = false },
                new Category { Id = 192, Title = "Bud�ky", FilterWord = "�koda Octavia II 1.9 TDI bud�ky ", ParentId = 178, IsVisible = false },
                new Category { Id = 193, Title = "Popeln�k", FilterWord = "�koda Octavia II popeln�k", ParentId = 178, IsVisible = false },
                new Category { Id = 194, Title = "Dvojit� dno", FilterWord = "�koda Octavia II dvojit� dno", ParentId = 178, IsVisible = false },
                new Category { Id = 195, Title = "Stropn� sv�tlo", FilterWord = "�koda Octavia II stropn� sv�tlo", ParentId = 178, IsVisible = false },
                new Category { Id = 196, Title = "Lev� p�edn� p�s", FilterWord = "�koda Octavia II lev� p�edn� p�s", ParentId = 178, IsVisible = false },
                new Category { Id = 197, Title = "R�me�ek klimatizace", FilterWord = "�koda Octavia II r�me�ek klimatizace", ParentId = 178, IsVisible = false },
                new Category { Id = 198, Title = "Prav� p�edn� p�s", FilterWord = "�koda Octavia II prav� p�edn� p�s", ParentId = 178, IsVisible = false },
                new Category { Id = 199, Title = "Zadn� p�sy", FilterWord = "�koda Octavia II zadn� p�sy", ParentId = 178, IsVisible = false },
                new Category { Id = 200, Title = "Volant RS", FilterWord = "�koda Octavia II RS volant", ParentId = 178, IsVisible = false },

                new Category { Id = 201, Title = "Motor", FilterWord = "�koda Octavia II motor", ParentId = 8, IsVisible = true },
                new Category { Id = 202, Title = "�krt�c� klapka 2.TDI", FilterWord = "�koda Octavia 2.0 TDI �krt�c� klapka", ParentId = 201, IsVisible = false },
                new Category { Id = 203, Title = "Chladi�ov� st�na", FilterWord = "�koda Octavia II chladi�ov� st�na", ParentId = 201, IsVisible = false },
                new Category { Id = 204, Title = "Palivov� �erpadlo 1.9 TDI", FilterWord = "�koda Octavia 1.9 TDI palivov� �erpadlo", ParentId = 201, IsVisible = false },
                new Category { Id = 205, Title = "Turbo 1.9 TDI", FilterWord = "�koda Octavia II 1.9 TDI turbo", ParentId = 201, IsVisible = false },
                new Category { Id = 206, Title = "Turbo 2.0 TDI", FilterWord = "�koda Octavia II 2.0 TDI turbo", ParentId = 201, IsVisible = false },

                new Category { Id = 207, Title = "P�evodovka", FilterWord = "�koda Octavia II p�evodovka", ParentId = 8, IsVisible = true },
                new Category { Id = 208, Title = "P�evodovka 1.9 TDI", FilterWord = "�koda Octavia II 1.9 TDI p�evodovka", ParentId = 207, IsVisible = false },
                new Category { Id = 209, Title = "P�evodovka 2.0 TDI", FilterWord = "�koda Octavia II 2.0 TDI p�evodovka", ParentId = 207, IsVisible = false },
                new Category { Id = 210, Title = "P�evodovka 1.9 TDI DSG", FilterWord = "�koda Octavia II 1.9 TDI DSG p�evodovka", ParentId = 207, IsVisible = false },
                new Category { Id = 211, Title = "P�evodovka 2.0 TDI DSG", FilterWord = "�koda Octavia II 2.0 TDI DSG p�evodovka", ParentId = 207, IsVisible = false },
                new Category { Id = 212, Title = "Start�r 1.9 TDI", FilterWord = "�koda Octavia II 1.9 TDI start�r", ParentId = 207, IsVisible = false },
                new Category { Id = 213, Title = "Start�r 2.0 TDI", FilterWord = "�koda Octavia II 2.0 TDI start�r", ParentId = 207, IsVisible = false },

                new Category { Id = 214, Title = "Klimatizace", FilterWord = "�koda Octavia II klimatizace", ParentId = 8, IsVisible = true },
                new Category { Id = 215, Title = "Klima kompresor", FilterWord = "�koda Octavia II klima kompresor", ParentId = 214, IsVisible = false },
                new Category { Id = 216, Title = "Ovlada� klimatizace", FilterWord = "�koda Octavia II ovlada� klimatizace", ParentId = 214, IsVisible = false },

                new Category { Id = 217, Title = "Podvozek", FilterWord = "�koda Octavia II podvozek", ParentId = 8, IsVisible = true },
                new Category { Id = 218, Title = "Zadn� n�prava", FilterWord = "�koda Octavia II zadn� n�prava", ParentId = 217, IsVisible = false },
                new Category { Id = 219, Title = "Lev� poloosa", FilterWord = "�koda Octavia II 1.9 TDI lev� poloosa", ParentId = 217, IsVisible = false },
                new Category { Id = 220, Title = "Prav� poloosa", FilterWord = "�koda Octavia II 1.9 TDI prav� poloosa", ParentId = 217, IsVisible = false },
                new Category { Id = 221, Title = "��zen�", FilterWord = "�koda Octavia II ��zen�", ParentId = 217, IsVisible = false },


                new Category { Id = 222, Title = "Elektroinstalace", FilterWord = "�koda Octavia II elektroinstalace", ParentId = 8, IsVisible = true },
                new Category { Id = 223, Title = "Motorek zadn�ho st�ra�e", FilterWord = "�koda Octavia II motorek zadn�ho st�ra�e", ParentId = 222, IsVisible = false },
                new Category { Id = 224, Title = "Mechanismus st�ra��", FilterWord = "�koda Octavia II t�hla st�ra��", ParentId = 222, IsVisible = false },
                new Category { Id = 225, Title = "��d�c� jednotka ABS", FilterWord = "�koda Octavia II ��d�c� jednotka ABS", ParentId = 222, IsVisible = false },
                new Category { Id = 226, Title = "Altern�tor 2.0 TDI", FilterWord = "�koda Octavia II 2.0 TDI altern�tor", ParentId = 222, IsVisible = false },
                new Category { Id = 227, Title = "Altern�tor 1.9 TDI", FilterWord = "�koda Octavia I 1.9 TDI altern�tor", ParentId = 222, IsVisible = false },
                new Category { Id = 228, Title = "Motorov� kabel� 1.9 TDI", FilterWord = "�koda Octavia II motorov� kabel� 1.9 TDI", ParentId = 222, IsVisible = false },
                new Category { Id = 229, Title = "Kabel� v�h�evu seda�ek", FilterWord = "�koda Octavia II kabel� v�h�evu seda�ek", ParentId = 222, IsVisible = false },








                new Category { Id = 230, Title = "Karoserie", FilterWord = "�koda Octavia III karoserie", ParentId = 9, IsVisible = true },
                new Category { Id = 231, Title = "P�edn� sv�tla", FilterWord = "�koda Octavia III p�edn� sv�tla", ParentId = 230, IsVisible = false },
                new Category { Id = 232, Title = "Halogenov�", FilterWord = "�koda Octavia III halogenov� p�edn� sv�tla", ParentId = 231, IsVisible = false },
                new Category { Id = 233, Title = "Xenony", FilterWord = "�koda Octavia III xenony", ParentId = 231, IsVisible = false },
                new Category { Id = 234, Title = "Zadn� sv�tla", FilterWord = "�koda Octavia III zadn� sv�tla", ParentId = 230, IsVisible = false },
                new Category { Id = 235, Title = "Lev� p�edn� dve�e", FilterWord = "�koda Octavia III lev� p�edn� dve�e", ParentId = 230, IsVisible = false },
                new Category { Id = 236, Title = "Prav� p�edn� dve�e", FilterWord = "�koda Octavia III prav� p�edn� dve�e", ParentId = 230, IsVisible = false },
                new Category { Id = 237, Title = "Lev� zadn� dve�e", FilterWord = "�koda Octavia III lev� zadn� dve�e", ParentId = 230, IsVisible = false },
                new Category { Id = 238, Title = "Prav� zadn� dve�e", FilterWord = "�koda Octavia III prav� zadn� dve�e", ParentId = 230, IsVisible = false },
                new Category { Id = 239, Title = "P�t� dve�e", FilterWord = "�koda Octavia III p�t� dve�e", ParentId = 230, IsVisible = false },
                new Category { Id = 240, Title = "Zadn� n�razn�k", FilterWord = "�koda Octavia III zadn� n�razn�k", ParentId = 230, IsVisible = false },
                new Category { Id = 241, Title = "P�edn� n�razn�k", FilterWord = "�koda Octavia III p�edn� n�razn�k", ParentId = 230, IsVisible = false },
                new Category { Id = 242, Title = "Lev� zrc�tko", FilterWord = "�koda Octavia III lev� zrc�tko", ParentId = 230, IsVisible = false },
                new Category { Id = 243, Title = "Prav� zrc�tko", FilterWord = "�koda Octavia III prav� zrc�tko", ParentId = 230, IsVisible = false },
                new Category { Id = 244, Title = "Lev� blatn�k", FilterWord = "�koda Octavia III lev� blatn�k", ParentId = 230, IsVisible = false },
                new Category { Id = 245, Title = "Prav� blatn�k", FilterWord = "�koda Octavia III prav� blatn�k", ParentId = 230, IsVisible = false },
                new Category { Id = 246, Title = "Maska", FilterWord = "�koda Octavia III maska", ParentId = 230, IsVisible = false },
                new Category { Id = 247, Title = "Kapota", FilterWord = "�koda Octavia III kapota", ParentId = 230, IsVisible = false },
                new Category { Id = 248, Title = "P�edn� n�razn�k RS", FilterWord = "�koda Octavia III p�edn� n�razn�k RS", ParentId = 230, IsVisible = false },
                new Category { Id = 249, Title = "�eln� sklo", FilterWord = "�koda Octavia III �eln� sklo", ParentId = 230, IsVisible = false },
                new Category { Id = 250, Title = "V�ztuha p�edn�ho n�razn�ku", FilterWord = "�koda Octavia III v�ztuha p�edn�ho n�razn�ku", ParentId = 230, IsVisible = false },


                new Category { Id = 251, Title = "Interi�r", FilterWord = "�koda Octavia III interi�r", ParentId = 9, IsVisible = true },
                new Category { Id = 252, Title = "Volant", FilterWord = "�koda Octavia III volant", ParentId = 251, IsVisible = false },
                new Category { Id = 253, Title = "Palubka", FilterWord = "�koda Octavia III palubka", ParentId = 251, IsVisible = false },
                new Category { Id = 254, Title = "St�edov� tunel", FilterWord = "�koda Octavia III st�edov� tunel", ParentId = 251, IsVisible = false },
                new Category { Id = 255, Title = "Seda�ky", FilterWord = "�koda Octavia III seda�ky", ParentId = 251, IsVisible = false },
                new Category { Id = 256, Title = "Loketn� op�rka", FilterWord = "�koda Octavia III loketn� op�rka", ParentId = 251, IsVisible = false },
                new Category { Id = 257, Title = "Stropnice", FilterWord = "�koda Octavia III stropnice", ParentId = 251, IsVisible = false },
                new Category { Id = 258, Title = "Plato kufru", FilterWord = "�koda Octavia III plato kufru", ParentId = 251, IsVisible = false },
                new Category { Id = 259, Title = "Sp�na� sv�tel", FilterWord = "�koda Octavia III sp�na� sv�tel", ParentId = 251, IsVisible = false },
                new Category { Id = 260, Title = "Roleta kufru", FilterWord = "�koda Octavia III roleta kufru", ParentId = 251, IsVisible = false },
                new Category { Id = 261, Title = "V�dechy topen�", FilterWord = "�koda Octavia III v�dechy topen�", ParentId = 251, IsVisible = false },
                new Category { Id = 262, Title = "Lev� v�dech topen�", FilterWord = "�koda Octavia III lev� v�dech topen�", ParentId = 251, IsVisible = false },
                new Category { Id = 263, Title = "Prav� v�dech topen�", FilterWord = "�koda Octavia III prav� v�dech topen�", ParentId = 251, IsVisible = false },
                new Category { Id = 264, Title = "St�edov� v�dech topen�", FilterWord = "�koda Octavia III st�edov� v�dech topen�", ParentId = 251, IsVisible = false },
                new Category { Id = 265, Title = "Bud�ky", FilterWord = "�koda Octavia III 2.0 TDI bud�ky ", ParentId = 251, IsVisible = false },
                new Category { Id = 266, Title = "Popeln�k", FilterWord = "�koda Octavia III popeln�k", ParentId = 251, IsVisible = false },
                new Category { Id = 267, Title = "Dvojit� dno", FilterWord = "�koda Octavia III dvojit� dno", ParentId = 251, IsVisible = false },
                new Category { Id = 268, Title = "Stropn� sv�tlo", FilterWord = "�koda Octavia III stropn� sv�tlo", ParentId = 251, IsVisible = false },
                new Category { Id = 269, Title = "Lev� p�edn� p�s", FilterWord = "�koda Octavia III lev� p�edn� p�s", ParentId = 251, IsVisible = false },
                new Category { Id = 270, Title = "Prav� p�edn� p�s", FilterWord = "�koda Octavia III prav� p�edn� p�s", ParentId = 251, IsVisible = false },
                new Category { Id = 271, Title = "Zadn� p�sy", FilterWord = "�koda Octavia III zadn� p�sy", ParentId = 251, IsVisible = false },
                new Category { Id = 272, Title = "Volant RS", FilterWord = "�koda Octavia III RS volant", ParentId = 251, IsVisible = false },



                new Category { Id = 273, Title = "Motor", FilterWord = "�koda Octavia III motor", ParentId = 9, IsVisible = true },
                new Category { Id = 274, Title = "�krt�c� klapka 2.TDI", FilterWord = "�koda Octavia III 2.0 TDI �krt�c� klapka", ParentId = 273, IsVisible = false },
                new Category { Id = 275, Title = "Chladi�ov� st�na 1.6 TDI", FilterWord = "�koda Octavia III chladi�ov� st�na 1.6 TDI", ParentId = 273, IsVisible = false },
                new Category { Id = 276, Title = "Chladi�ov� st�na 1.4 TSI", FilterWord = "�koda Octavia III chladi�ov� st�na 1.4 TSI", ParentId = 273, IsVisible = false },
                new Category { Id = 277, Title = "Chladi�ov� st�na 2.0 TDI", FilterWord = "�koda Octavia III chladi�ov� st�na 2.0 TDI", ParentId = 273, IsVisible = false },
                new Category { Id = 278, Title = "Palivov� �erpadlo", FilterWord = "�koda Octavia III 2.0 TDI palivov� �erpadlo", ParentId = 273, IsVisible = false },
                new Category { Id = 279, Title = "Turbo 2.0 TDI", FilterWord = "�koda Octavia II 2.0 TDI turbo", ParentId = 273, IsVisible = false },



                new Category { Id = 280, Title = "P�evodovka", FilterWord = "�koda Octavia III p�evodovka", ParentId = 9, IsVisible = true },
                new Category { Id = 281, Title = "P�evodovka 2.0 TDI", FilterWord = "�koda Octavia III 2.0 TDI p�evodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 282, Title = "P�evodovka 1.0 TSI", FilterWord = "�koda Octavia III 1.0 TSI p�evodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 283, Title = "P�evodovka 1.4 TSI", FilterWord = "�koda Octavia III 1.4 TSI p�evodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 284, Title = "P�evodovka 1.6 TDI", FilterWord = "�koda Octavia III 1.6 TDI p�evodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 285, Title = "P�evodovka 2.0 TDI DSG", FilterWord = "�koda Octavia III 2.0 TDI DSG p�evodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 286, Title = "P�evodovka 1.6 TDI DSG", FilterWord = "�koda Octavia III 1.6 TDI DSG p�evodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 287, Title = "P�evodovka 1.4 TSI DSG", FilterWord = "�koda Octavia III 1.4 TSI DSG p�evodovka", ParentId = 280, IsVisible = false },
                new Category { Id = 288, Title = "Start�r 1.6 TDI", FilterWord = "�koda Octavia III 1.6 TDI start�r", ParentId = 280, IsVisible = false },
                new Category { Id = 289, Title = "Start�r 2.0 TDI", FilterWord = "�koda Octavia III 2.0 TDI start�r", ParentId = 280, IsVisible = false },


                new Category { Id = 290, Title = "Klimatizace", FilterWord = "�koda Octavia III klimatizace", ParentId = 9, IsVisible = true },
                new Category { Id = 291, Title = "Klima kompresor", FilterWord = "�koda Octavia III klima kompresor", ParentId = 290, IsVisible = false },
                new Category { Id = 292, Title = "Ovlada� klimatizace", FilterWord = "�koda Octavia III ovlada� klimatizace", ParentId = 290, IsVisible = false },

                new Category { Id = 293, Title = "Podvozek", FilterWord = "�koda Octavia III podvozek", ParentId = 9, IsVisible = true },
                new Category { Id = 294, Title = "Zadn� n�prava", FilterWord = "�koda Octavia III zadn� n�prava", ParentId = 293, IsVisible = false },
                new Category { Id = 295, Title = "Lev� poloosa", FilterWord = "�koda Octavia III 2.0 TDI lev� poloosa", ParentId = 293, IsVisible = false },
                new Category { Id = 296, Title = "Prav� poloosa", FilterWord = "�koda Octavia III 2.0 TDI prav� poloosa", ParentId = 293, IsVisible = false },
                new Category { Id = 297, Title = "��zen�", FilterWord = "�koda Octavia III ��zen�", ParentId = 293, IsVisible = false },


                new Category { Id = 298, Title = "Elektroinstalace", FilterWord = "�koda Octavia III elektroinstalace", ParentId = 9, IsVisible = true },
                new Category { Id = 299, Title = "Motorek zadn�ho st�ra�e", FilterWord = "�koda Octavia III motorek zadn�ho st�ra�e", ParentId = 298, IsVisible = false },
                new Category { Id = 300, Title = "Mechanismus st�ra��", FilterWord = "�koda Octavia III t�hla st�ra��", ParentId = 298, IsVisible = false },
                new Category { Id = 301, Title = "��d�c� jednotka ABS", FilterWord = "�koda Octavia III ��d�c� jednotka ABS", ParentId = 298, IsVisible = false },
                new Category { Id = 302, Title = "Altern�tor 2.0 TDI", FilterWord = "�koda Octavia III 2.0 TDI altern�tor", ParentId = 298, IsVisible = false },
                new Category { Id = 303, Title = "Altern�tor 1.6 TDI", FilterWord = "�koda Octavia III 1.6 TDI altern�tor", ParentId = 298, IsVisible = false },
                new Category { Id = 304, Title = "Altern�tor 1.4 TSI", FilterWord = "�koda Octavia III 1.4 TSI altern�tor", ParentId = 298, IsVisible = false },




                new Category { Id = 305, Title = "Karoserie", FilterWord = "Volkswagen karoserie", ParentId = 10, IsVisible = true },
                new Category { Id = 306, Title = "Lev� p�edn� dve�e", FilterWord = "Volkswagen Passat B6 lev� p�edn� dve�e", ParentId = 305, IsVisible = false },
                new Category { Id = 307, Title = "Prav� p�edn� dve�e", FilterWord = "Volkswagen Passat B6 prav� p�edn� dve�e", ParentId = 305, IsVisible = false },
                new Category { Id = 308, Title = "Lev� zadn� dve�e", FilterWord = "Volkswagen Passat B6 lev� zadn� dve�e", ParentId = 305, IsVisible = false },
                new Category { Id = 309, Title = "Prav� zadn� dve�e", FilterWord = "Volkswagen Passat B6 prav� zadn� dve�e", ParentId = 305, IsVisible = false },
                new Category { Id = 310, Title = "P�t� dve�e", FilterWord = "Volkswagen Passat B6 p�t� dve�e", ParentId = 305, IsVisible = false },
                new Category { Id = 311, Title = "Zadn� n�razn�k", FilterWord = "Volkswagen Passat B6 zadn� n�razn�k", ParentId = 305, IsVisible = false },
                new Category { Id = 312, Title = "P�edn� n�razn�k", FilterWord = "Volkswagen Passat B6 p�edn� n�razn�k", ParentId = 305, IsVisible = false },
                new Category { Id = 313, Title = "Lev� blatn�k", FilterWord = "Volkswagen Passat B6 lev� blatn�k", ParentId = 305, IsVisible = false },
                new Category { Id = 314, Title = "Prav� blatn�k", FilterWord = "Volkswagen Passat B6 prav� blatn�k", ParentId = 305, IsVisible = false },

                new Category { Id = 315, Title = "Interi�r", FilterWord = "Volkswagen interi�r", ParentId = 10, IsVisible = true },
                new Category { Id = 316, Title = "Seda�ky", FilterWord = "Volkswagen Passat B6 seda�ky", ParentId = 315, IsVisible = false },
                new Category { Id = 317, Title = "Plato kufru", FilterWord = "Volkswagen Passat B6 plato kufru", ParentId = 315, IsVisible = false },
                new Category { Id = 318, Title = "Roleta kufru", FilterWord = "Volkswagen Passat B6 roleta kufru", ParentId = 315, IsVisible = false },



                new Category { Id = 319, Title = "Motor", FilterWord = "Volkswagen motor", ParentId = 10, IsVisible = true },
                new Category { Id = 320, Title = "�krt�c� klapka 2.0 TDI VW Passat B6", FilterWord = "Volkswagen Passat B6 2.0 TDI �krt�c� klapka", ParentId = 319, IsVisible = false },
                new Category { Id = 321, Title = "Palivov� �erpadlo 1.9 TDI VW Passat B6", FilterWord = "Volkswagen Passat B6 1.9 TDI palivov� �erpadlo", ParentId = 319, IsVisible = false },
                new Category { Id = 322, Title = "Turbo 1.9 TDI VW Passat", FilterWord = "Volkswagen Passat B6 1.9 TDI turbo", ParentId = 319, IsVisible = false },
                new Category { Id = 323, Title = "Turbo 2.0 TDI VW Passat", FilterWord = "Volkswagen Passat B6 2.0 TDI turbo", ParentId = 319, IsVisible = false },


                new Category { Id = 324, Title = "P�evodovka", FilterWord = "Volkswagen Passat B6 p�evodovka", ParentId = 10, IsVisible = true },
                new Category { Id = 325, Title = "P�evodovka 1.9 TDI VW Passsat", FilterWord = "Volkswagen Passat B6 1.9 TDI p�evodovka", ParentId = 324, IsVisible = false },
                new Category { Id = 326, Title = "P�evodovka 2.0 TDI DSG", FilterWord = "Volkswagen Passat B6 2.0 TDI DSG p�evodovka", ParentId = 324, IsVisible = false },



                new Category { Id = 327, Title = "Klimatizace", FilterWord = "Volkswagen Passat B6 klimatizace", ParentId = 10, IsVisible = true },
                new Category { Id = 328, Title = "Klima kompresor VW Passat B6", FilterWord = "Volkswagen Passat B6 klima kompresor", ParentId = 327, IsVisible = false },
                new Category { Id = 329, Title = "Klima kompresor VW Golf V", FilterWord = "Volkswagen Golf V klima kompresor", ParentId = 327, IsVisible = false },
                new Category { Id = 330, Title = "Klima kompresor VW Golf IV", FilterWord = "Volkswagen Golf IV klima kompresor", ParentId = 327, IsVisible = false },
                new Category { Id = 331, Title = "Ovlada� klimatizace", FilterWord = "Volkswagen Golf IV ovlada� klimatizace", ParentId = 327, IsVisible = false },


                new Category { Id = 332, Title = "Podvozek", FilterWord = "Volkswagen podvozek", ParentId = 10, IsVisible = true },
                new Category { Id = 333, Title = "Zadn� n�prava VW Passat B6", FilterWord = "Volkswagen Passat B6 zadn� n�prava", ParentId = 332, IsVisible = false },
                new Category { Id = 334, Title = "Zadn� n�prava VW Golf IV", FilterWord = "Volkswagen Golf IV zadn� n�prava", ParentId = 332, IsVisible = false },
                new Category { Id = 335, Title = "��zen�", FilterWord = "Volkswagen Passat B6 ��zen�", ParentId = 332, IsVisible = false },

                new Category { Id = 336, Title = "Brzdov� syst�m", FilterWord = "Volkswagen brzdov� syst�m", ParentId = 10, IsVisible = true },
                new Category { Id = 337, Title = "Lev� zadn� t�men", FilterWord = "Volkswagen Golf IV lev� zadn� t�men", ParentId = 336, IsVisible = false },
                new Category { Id = 338, Title = "Elektroinstalace", FilterWord = "Volkswagen Golf IV elektroinstalace", ParentId = 10, IsVisible = true },
                new Category { Id = 339, Title = "Motorek zadn�ho st�ra�e", FilterWord = "Volkswagen Passat B6 motorek zadn�ho st�ra�e", ParentId = 338, IsVisible = false },
                new Category { Id = 340, Title = "Mechanismus st�ra�� VW Golf IV", FilterWord = "Volkswagen Golf IV t�hla st�ra��", ParentId = 338, IsVisible = false },
                new Category { Id = 341, Title = "Mechanismus st�ra�� VW Passat B6", FilterWord = "Volkswagen Passat B6 t�hla st�ra��", ParentId = 338, IsVisible = false },
                new Category { Id = 342, Title = "��d�c� jednotka ABS VW Golf IV", FilterWord = "Volkswagen Golf IV ��d�c� jednotka ABS", ParentId = 338, IsVisible = false },
                new Category { Id = 343, Title = "Altern�tor 2.0 TDI VW Passat B6", FilterWord = "Volkswagen Passat B6 2.0 TDI altern�tor", ParentId = 338, IsVisible = false },
                new Category { Id = 344, Title = "Altern�tor 1.9 TDI VW Passat B6", FilterWord = "Volkswagen Passat B6 1.9 TDI altern�tor", ParentId = 338, IsVisible = false },




                new Category { Id = 345, Title = "Karoserie", FilterWord = "Seat karoserie", ParentId = 12, IsVisible = true },
                new Category { Id = 346, Title = "P�edn� sv�tla", FilterWord = "Seat Leon p�edn� sv�tla", ParentId = 345, IsVisible = false },
                new Category { Id = 347, Title = "P�edn� n�razn�k Seat Ibiza", FilterWord = "Seat Ibiza p�edn� n�razn�k", ParentId = 345, IsVisible = false },
                new Category { Id = 348, Title = "P�edn� n�razn�k Seat Leon", FilterWord = "Seat Leon p�edn� n�razn�k", ParentId = 345, IsVisible = false },
                new Category { Id = 349, Title = "Zadn� n�razn�k Seat Leon", FilterWord = "Seat Leon zadn� n�razn�k", ParentId = 345, IsVisible = false },
                new Category { Id = 350, Title = "P�edn� n�razn�k Seat Ibiza", FilterWord = "Seat Ibiza p�edn� n�razn�k", ParentId = 345, IsVisible = false },



                new Category { Id = 351, Title = "Interi�r", FilterWord = "Seat interi�r", ParentId = 12, IsVisible = true },
                new Category { Id = 352, Title = "Seda�ky", FilterWord = "Seat Leon seda�ky", ParentId = 351, IsVisible = false },
                new Category { Id = 353, Title = "Plato kufru", FilterWord = "Seat Leon plato kufru", ParentId = 351, IsVisible = false },

                new Category { Id = 354, Title = "Motor", FilterWord = "Volkswagen motor", ParentId = 12, IsVisible = true },
                new Category { Id = 355, Title = "Palivov� �erpadlo 1.9 TDI Seat Leon", FilterWord = "Seat Leon 1.9 TDI palivov� �erpadlo", ParentId = 354, IsVisible = false },
                new Category { Id = 356, Title = "Turbo 1.9 TDI", FilterWord = "Seat Leon 1.9 TDI turbo", ParentId = 354, IsVisible = false },

                new Category { Id = 357, Title = "P�evodovka", FilterWord = "Seat Leon p�evodovka", ParentId = 12, IsVisible = true },
                new Category { Id = 358, Title = "P�evodovka 1.9 TDI Seat Leon", FilterWord = "Seat Leon 1.9 TDI p�evodovka", ParentId = 357, IsVisible = false },

                new Category { Id = 359, Title = "Klimatizace", FilterWord = "Seat Leon klimatizace", ParentId = 12, IsVisible = true },
                new Category { Id = 360, Title = "Klima kompresor Seat Leon", FilterWord = "Seat Leon klima kompresor", ParentId = 359, IsVisible = false },
                new Category { Id = 361, Title = "Ovlada� klimatizace", FilterWord = "Seat Leon ovlada� klimatizace", ParentId = 359, IsVisible = false },

                new Category { Id = 362, Title = "Podvozek", FilterWord = "Seat Leon podvozek", ParentId = 12, IsVisible = true },
                new Category { Id = 363, Title = "Zadn� n�prava", FilterWord = "Seat Leon zadn� n�prava", ParentId = 362, IsVisible = false },
                new Category { Id = 364, Title = "��zen�", FilterWord = "Seat Leon ��zen�", ParentId = 362, IsVisible = false },

                new Category { Id = 365, Title = "Brzdov� syst�m", FilterWord = "Seat brzdov� syst�m", ParentId = 12, IsVisible = true },
                new Category { Id = 366, Title = "Lev� zadn� t�men", FilterWord = "Seat Leon lev� zadn� t�men", ParentId = 365, IsVisible = false },
                new Category { Id = 367, Title = "Prav� zadn� t�men", FilterWord = "Seat Leon prav� zadn� t�men", ParentId = 365, IsVisible = false },


                new Category { Id = 368, Title = "Elektroinstalace", FilterWord = "Seat Leon elektroinstalace", ParentId = 12, IsVisible = true },
                new Category { Id = 369, Title = "��d�c� jednotka ABS", FilterWord = "Seat Leon ��d�c� jednotka ABS", ParentId = 368, IsVisible = false },
                new Category { Id = 370, Title = "Altern�tor 1.9 TDI", FilterWord = "Seat Leon 1.9 TDI altern�tor", ParentId = 368, IsVisible = false },



                new Category { Id = 371, Title = "Karoserie", FilterWord = "Audi karoserie", ParentId = 11, IsVisible = true },
                new Category { Id = 372, Title = "P�edn� sv�tla", FilterWord = "Audi A6 p�edn� sv�tla", ParentId = 371, IsVisible = false },
                new Category { Id = 373, Title = "P�edn� n�razn�k Audi A6", FilterWord = "Audi A6 p�edn� n�razn�k", ParentId = 371, IsVisible = false },
                new Category { Id = 374, Title = "Zadn� n�razn�k Audi A3", FilterWord = "Audi A3 zadn� n�razn�k", ParentId = 371, IsVisible = false },
                new Category { Id = 375, Title = "Zadn� n�razn�k Audi A6", FilterWord = "Audi A6 p�edn� n�razn�k", ParentId = 371, IsVisible = false },


                new Category { Id = 376, Title = "Interi�r", FilterWord = "Audi interi�r", ParentId = 11, IsVisible = true },
                new Category { Id = 377, Title = "Seda�ky", FilterWord = "Audi A6 seda�ky", ParentId = 376, IsVisible = false },


                new Category { Id = 378, Title = "Motor", FilterWord = "Audi motor", ParentId = 11, IsVisible = true },
                new Category { Id = 379, Title = "Palivov� �erpadlo 1.9 TDI", FilterWord = "Audi A3 1.9 TDI palivov� �erpadlo", ParentId = 378, IsVisible = false },
                new Category { Id = 380, Title = "Turbo 1.9 TDI", FilterWord = "Audi A3 1.9 TDI turbo", ParentId = 378, IsVisible = false },


                new Category { Id = 381, Title = "P�evodovka", FilterWord = "Audi p�evodovka", ParentId = 11, IsVisible = true },
                new Category { Id = 382, Title = "P�evodovka 1.9 TDI", FilterWord = "Audi A3 1.9 TDI p�evodovka", ParentId = 381, IsVisible = false },

                new Category { Id = 383, Title = "Klimatizace", FilterWord = "Audi klimatizace", ParentId = 11, IsVisible = true },
                new Category { Id = 384, Title = "Klima kompresor Seat Leon", FilterWord = "Audi klima kompresor", ParentId = 383, IsVisible = false },


                new Category { Id = 385, Title = "Podvozek", FilterWord = "Audi podvozek", ParentId = 11, IsVisible = true },
                new Category { Id = 386, Title = "Zadn� n�prava", FilterWord = "Audi A3 zadn� n�prava", ParentId = 385, IsVisible = false },
                new Category { Id = 387, Title = "��zen�", FilterWord = "Audi A3 ��zen�", ParentId = 385, IsVisible = false },

                new Category { Id = 388, Title = "Brzdov� syst�m", FilterWord = "Audi brzdov� syst�m", ParentId = 11, IsVisible = true },
                new Category { Id = 389, Title = "Lev� zadn� t�men", FilterWord = "Audi A6 lev� zadn� t�men", ParentId = 388, IsVisible = false },
                new Category { Id = 390, Title = "Prav� zadn� t�men", FilterWord = "Audi A6 prav� zadn� t�men", ParentId = 388, IsVisible = false },

                new Category { Id = 391, Title = "Elektroinstalace", FilterWord = "Audi elektroinstalace", ParentId = 11, IsVisible = true },
                new Category { Id = 392, Title = "��d�c� jednotka ABS", FilterWord = "Audi A3 ��d�c� jednotka ABS", ParentId = 391, IsVisible = false },
                new Category { Id = 393, Title = "Altern�tor", FilterWord = "Audi A3 1.9 TDI altern�tor", ParentId = 391, IsVisible = false },



                new Category { Id = 394, Title = "Karoserie", FilterWord = "BMW karoserie", ParentId = 13, IsVisible = true },
                new Category { Id = 395, Title = "P�edn� sv�tla", FilterWord = "BMW E90 p�edn� sv�tla", ParentId = 394, IsVisible = false },
                new Category { Id = 396, Title = "Lev� p�edn� dve�e E90", FilterWord = "BMW E90 lev� p�edn� dve�e", ParentId = 394, IsVisible = false },
                new Category { Id = 397, Title = "Prav� p�edn� dve�e E90", FilterWord = "BMW E90 prav� p�edn� dve�e", ParentId = 394, IsVisible = false },
                new Category { Id = 399, Title = "Lev� zadn� dve�e", FilterWord = "BMW E90 lev� zadn� dve�e", ParentId = 394, IsVisible = false },
                new Category { Id = 400, Title = "Prav� zadn� dve�e", FilterWord = "BMW E90 prav� zadn� dve�e", ParentId = 394, IsVisible = false },
                new Category { Id = 401, Title = "Lev� p�edn� dve�e E92", FilterWord = "BMW E92 lev� p�edn� dve�e", ParentId = 394, IsVisible = false },
                new Category { Id = 402, Title = "Prav� p�edn� dve�e E92", FilterWord = "BMW E92 prav� p�edn� dve�e", ParentId = 394, IsVisible = false },
                new Category { Id = 403, Title = "P�t� dve�e E91", FilterWord = "BMW E91 p�t� dve�e", ParentId = 394, IsVisible = false },
                new Category { Id = 404, Title = "P�t� dve�e E61", FilterWord = "BMW E61 p�t� dve�e", ParentId = 394, IsVisible = false },
                new Category { Id = 405, Title = "Zadn� n�razn�k", FilterWord = "BMW E90 zadn� n�razn�k", ParentId = 394, IsVisible = false },
                new Category { Id = 406, Title = "P�edn� n�razn�k M Paket E90", FilterWord = "BMW E90 p�edn� n�razn�k M Paket", ParentId = 394, IsVisible = false },
                new Category { Id = 407, Title = "P�edn� n�razn�k M Paket E92", FilterWord = "BMW E92 p�edn� n�razn�k M Paket", ParentId = 394, IsVisible = false },
                new Category { Id = 408, Title = "Zadn� n�razn�k E90 M paket", FilterWord = "BMW E90 zadn� n�razn�k M Paket", ParentId = 394, IsVisible = false },
                new Category { Id = 409, Title = "Zadn� n�razn�k E92 M paket", FilterWord = "BMW E92 zadn� n�razn�k M Paket", ParentId = 394, IsVisible = false },
                new Category { Id = 410, Title = "P�edn� n�razn�k E90", FilterWord = "BMW E90 p�edn� n�razn�k", ParentId = 394, IsVisible = false },
                new Category { Id = 411, Title = "Lev� zrc�tko", FilterWord = "BMW E90 lev� zrc�tko", ParentId = 394, IsVisible = false },
                new Category { Id = 412, Title = "Prav� zrc�tko", FilterWord = "BMW E90 prav� zrc�tko", ParentId = 394, IsVisible = false },
                new Category { Id = 413, Title = "Kapota E90", FilterWord = "BMW E90 kapota", ParentId = 394, IsVisible = false },
                new Category { Id = 414, Title = "Kapota E92", FilterWord = "BMW E92 kapota", ParentId = 394, IsVisible = false },


                new Category { Id = 415, Title = "Interi�r", FilterWord = "BMW interi�r", ParentId = 13, IsVisible = true },
                new Category { Id = 416, Title = "Volant", FilterWord = "BMW E90 volant", ParentId = 415, IsVisible = false },
                new Category { Id = 417, Title = "St�edov� tunel", FilterWord = "BMW E90 st�edov� tunel", ParentId = 415, IsVisible = false },
                new Category { Id = 418, Title = "Seda�ky E90", FilterWord = "BMW E90 seda�ky", ParentId = 415, IsVisible = false },
                new Category { Id = 419, Title = "Seda�ky E92", FilterWord = "BMW E92 seda�ky", ParentId = 415, IsVisible = false },
                new Category { Id = 420, Title = "Loketn� op�rka", FilterWord = "BMW E90 loketn� op�rka", ParentId = 415, IsVisible = false },
                new Category { Id = 421, Title = "Sp�na� sv�tel", FilterWord = "BMW E90 sp�na� sv�tel", ParentId = 415, IsVisible = false },
                new Category { Id = 422, Title = "Roleta kufru", FilterWord = "BMW E91 roleta kufru", ParentId = 415, IsVisible = false },
                new Category { Id = 423, Title = "V�dechy topen�", FilterWord = "BMW E90 v�dechy topen�", ParentId = 415, IsVisible = false },
                new Category { Id = 424, Title = "Lev� v�dech topen�", FilterWord = "BMW E90 lev� v�dech topen�", ParentId = 415, IsVisible = false },
                new Category { Id = 425, Title = "Prav� v�dech topen�", FilterWord = "BMW E90 prav� v�dech topen�", ParentId = 415, IsVisible = false },
                new Category { Id = 426, Title = "St�edov� v�dech topen�", FilterWord = "BMW E90 st�edov� v�dech topen�", ParentId = 415, IsVisible = false },
                new Category { Id = 427, Title = "Popeln�k", FilterWord = "BMW E90 popeln�k", ParentId = 415, IsVisible = false },

                new Category { Id = 428, Title = "Motor", FilterWord = "BMW motor", ParentId = 13, IsVisible = true },
                new Category { Id = 429, Title = "Motor N46B20B", FilterWord = "BMW motor N46B20B motor", ParentId = 428, IsVisible = false },
                new Category { Id = 430, Title = "Motor N46B20A", FilterWord = "BMW motor N46B20A motor", ParentId = 428, IsVisible = false },
                new Category { Id = 431, Title = "Motor N47D20A ", FilterWord = "BMW motor N47D20A motor", ParentId = 428, IsVisible = false },
                new Category { Id = 432, Title = "Servo �erpadlo ", FilterWord = "BMW E90 320i servo�erpadlo", ParentId = 428, IsVisible = false },


                new Category { Id = 433, Title = "Klimatizace", FilterWord = "BMW klimatizace", ParentId = 12, IsVisible = true },
                new Category { Id = 434, Title = "Klima kompresor", FilterWord = "BMW E90 klima kompresor", ParentId = 433, IsVisible = false },

                new Category { Id = 435, Title = "Autor�dia", FilterWord = "Autor�dio", ParentId = 2, IsVisible = true },

                new Category { Id = 436, Title = "�ad�c� p�ky", FilterWord = "�ad�c� p�ka", ParentId = 2, IsVisible = true },

                new Category { Id = 437, Title = "LED osv�tlen�", FilterWord = "LED osv�tlen�", ParentId = 2, IsVisible = true },
                new Category { Id = 438, Title = "�koda", FilterWord = "�koda", ParentId = 437, IsVisible = true },
                new Category { Id = 439, Title = "�koda Octavia 2", FilterWord = "�koda Octavia 2", ParentId = 438, IsVisible = true },
                new Category { Id = 440, Title = "Exteri�r", FilterWord = "�koda Octavia 2 LED osv�tlen� exteri�ru", ParentId = 439, IsVisible = true },
                new Category { Id = 441, Title = "Denn� sv�cen�", FilterWord = "�koda Octavia 2 denn� sv�cen�", ParentId = 440, IsVisible = true },
                new Category { Id = 442, Title = "Mlhovky", FilterWord = "�koda Octavia 2 mlhovky", ParentId = 440, IsVisible = true },
                new Category { Id = 443, Title = "Osv�tlen� SPZ", FilterWord = "�koda Octavia 2 LED osv�tlen� SPZ", ParentId = 440, IsVisible = true },
                new Category { Id = 444, Title = "Zp�te�ka", FilterWord = "�koda Octavia 2 LED osv�tlen� zp�te�ky", ParentId = 440, IsVisible = true },
                new Category { Id = 445, Title = "Osv�tlen� n�stupn�ho prostoru", FilterWord = "�koda Octavia 2 LED osv�tlen� n�stupn�ho prostoru", ParentId = 440, IsVisible = true },
                new Category { Id = 446, Title = "Interi�r", FilterWord = "�koda Octavia 2 LED osv�tlen� interi�ru", ParentId = 439, IsVisible = true },

                new Category { Id = 447, Title = "�koda Octavia 3", FilterWord = "�koda", ParentId = 438, IsVisible = true },
                new Category { Id = 448, Title = "Exteri�r", FilterWord = "�koda Octavia 3 LED osv�tlen� exteri�r", ParentId = 447, IsVisible = true },
                new Category { Id = 449, Title = "Mlhovky", FilterWord = "�koda Octavia 3 mlhovky", ParentId = 448, IsVisible = true },
                new Category { Id = 450, Title = "Osv�tlen� SPZ", FilterWord = "�koda Octavia 3 LED osv�tlen� SPZ", ParentId = 448, IsVisible = true },
                new Category { Id = 451, Title = "Zp�te�ka", FilterWord = "�koda Octavia 3 LED osv�tlen� zp�te�ky", ParentId = 448, IsVisible = true },
                new Category { Id = 452, Title = "Osv�tlen� n�stupn�ho prostoru", FilterWord = "�koda Octavia 3 LED osv�tlen� n�stupn�ho prostoru", ParentId = 448, IsVisible = true },
                new Category { Id = 453, Title = "Interi�r", FilterWord = "�koda Octavia 3 LED osv�tlen� interi�ru", ParentId = 447, IsVisible = true },

                new Category { Id = 454, Title = "BMW", FilterWord = "BMW", ParentId = 437, IsVisible = true },
                new Category { Id = 455, Title = "Exteri�r", FilterWord = "BMW LED osv�tlen� exteri�ru", ParentId = 454, IsVisible = true },
                new Category { Id = 456, Title = "LED markery", FilterWord = "BMW E90 led markery", ParentId = 455, IsVisible = true },
                new Category { Id = 457, Title = "Mlhovky", FilterWord = "BMW LED osv�tlen� mlhovek", ParentId = 455, IsVisible = true },
                new Category { Id = 458, Title = "Osv�tlen� SPZ", FilterWord = "BMW E90 LED osv�tlen� SPZ", ParentId = 455, IsVisible = true },
                new Category { Id = 459, Title = "Zp�te�ka", FilterWord = "BMW LED osv�tlen� zp�te�ky", ParentId = 455, IsVisible = true },
                new Category { Id = 460, Title = "LED blinkry", FilterWord = "BMW E92 LED blinkry", ParentId = 455, IsVisible = true },
                new Category { Id = 461, Title = "Zadn� lampy", FilterWord = "BMW E90 zadn� sv�tla", ParentId = 455, IsVisible = true },
                new Category { Id = 462, Title = "Interi�r", FilterWord = "BMW E90 LED osv�tlen� interi�ru", ParentId = 454, IsVisible = true },

                new Category { Id = 463, Title = "Volkswagen", FilterWord = "Volkswagen", ParentId = 437, IsVisible = true },
                new Category { Id = 464, Title = "Exteri�r", FilterWord = "Volkswagen Passat B6 osv�tlen� exteri�ru", ParentId = 463, IsVisible = true },
                new Category { Id = 465, Title = "Mlhovky", FilterWord = "Volkswagen Passat B6 mlhovky", ParentId = 464, IsVisible = true },
                new Category { Id = 466, Title = "Osv�tlen� SPZ", FilterWord = "BMW E90 LED osv�tlen� SPZ", ParentId = 464, IsVisible = true },
                new Category { Id = 467, Title = "Zp�te�ka", FilterWord = "Volkswagen Passat B6 LED osv�tlen� zp�te�ky", ParentId = 464, IsVisible = true },
                new Category { Id = 468, Title = "Interi�r", FilterWord = "Volkswagen Passat B6 LED osv�tlen� interi�ru", ParentId = 463, IsVisible = true },
                new Category { Id = 469, Title = "Univerz�ln�", FilterWord = "Univerz�ln�", ParentId = 437, IsVisible = true },



                new Category { Id = 470, Title = "Vany do kufru", FilterWord = "Vany do kufru", ParentId = 2, IsVisible = true },
                new Category { Id = 471, Title = "Znaky", FilterWord = "Znaky", ParentId = 2, IsVisible = true },
                new Category { Id = 472, Title = "Carbon design", FilterWord = "Carbon design", ParentId = 2, IsVisible = true },
                new Category { Id = 473, Title = "Autokosmetika", FilterWord = "Autokosmetika", ParentId = 2, IsVisible = true },
                new Category { Id = 474, Title = "Masky a spoilery", FilterWord = "Spoiler", ParentId = 2, IsVisible = true },
                new Category { Id = 475, Title = "Kobere�ky", FilterWord = "Kobere�ky", ParentId = 2, IsVisible = true },
                new Category { Id = 476, Title = "�koda", FilterWord = "�koda Octavia kobere�ky", ParentId = 475, IsVisible = true },
                new Category { Id = 477, Title = "BMW", FilterWord = "BMW kobere�ky", ParentId = 475, IsVisible = true },
                new Category { Id = 478, Title = "Volkswagen", FilterWord = "Volkswagen kobere�ky", ParentId = 475, IsVisible = true },
                new Category { Id = 479, Title = "Ped�ly", FilterWord = "Ped�ly", ParentId = 2, IsVisible = true },
                new Category { Id = 480, Title = "Prahy", FilterWord = "Prahy", ParentId = 2, IsVisible = true },
                new Category { Id = 481, Title = "Ochrann� li�ty", FilterWord = "Ochrann� li�ty", ParentId = 2, IsVisible = true },
                new Category { Id = 482, Title = "Ostatn�", FilterWord = "Ostatn�", ParentId = 2, IsVisible = true },



                new Category { Id = 483, Title = "Chci p�estavbu sv�tel", FilterWord = "p�estavba sv�tel", ParentId = 3, IsVisible = true },
                new Category { Id = 484, Title = "Audi", FilterWord = "Audi LED p�edn� sv�tla", ParentId = 483, IsVisible = true },
                new Category { Id = 485, Title = "BMW", FilterWord = "BMW LED p�edn� sv�tla", ParentId = 483, IsVisible = true },
                new Category { Id = 486, Title = "Volkswagen", FilterWord = "Volkswagen LED p�edn� sv�tla", ParentId = 483, IsVisible = true },
                new Category { Id = 487, Title = "Peugeot", FilterWord = "Peugeot LED p�edn� sv�tla", ParentId = 483, IsVisible = true },
                new Category { Id = 488, Title = "�koda", FilterWord = "�koda LED p�edn� sv�tla", ParentId = 483, IsVisible = true },
                new Category { Id = 489, Title = "Ford", FilterWord = "Ford Focus LED p�edn� sv�tla", ParentId = 483, IsVisible = true },
                new Category { Id = 490, Title = "Chci koupit cel� sv�tla", FilterWord = "LED sv�tlomety", ParentId = 3, IsVisible = true },
                new Category { Id = 491, Title = "Audi", FilterWord = "Audi LED sv�tlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 492, Title = "BMW", FilterWord = "BMW LED sv�tlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 493, Title = "Volkswagen", FilterWord = "Volkswagen LED sv�tlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 494, Title = "Peugeot", FilterWord = "Peugeot LED sv�tlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 495, Title = "�koda", FilterWord = "�koda LED sv�tlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 496, Title = "Ford", FilterWord = "Ford Focus LED sv�tlomety", ParentId = 490, IsVisible = true },
                new Category { Id = 497, Title = "�koda Superb", FilterWord = "�koda Superb", ParentId = 4, IsVisible = true }
                 );
        }
    }
}
