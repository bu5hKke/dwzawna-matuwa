using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4 {
    internal class predmeti
    {
        public static string[] opsta = new string[] {
            "Biologija",
            "Geografija",
            "Engleski jezik",
            "Istorija",
            "Italijanski jezik",
            "Nemački jezik",
            "Ruski jezik",
            "Srpski kao nematernji jezik",
            "Fizika",
            "Francuski jezik",
            "Hemija",
            "Španski jezik"
        };

        public static string[] umetnicka = new string[] {
            "Solfeđo i harmonija",
            "Nema 3. predmet"
        };

        public static Dictionary<string, string[]> strucni = new Dictionary<string, string[]>();

        public static string[] jezici =
            "Srpski jezik i književnost\r\nAlbanski jezik i književnost\r\nBosanski jezik i književnost\r\nBugarski jezik i književnost\r\nMađarski jezik i književnost\r\nRumunski jezik i književnost\r\nRusinski jezik i književnost\r\nSlovački jezik i književnost\r\nHrvatski jezik i književnost".Split("\r\n");

        static predmeti() {
            strucni.Add("Poljoprivreda", new string[] {
                "Zootehničar",
                "Tehničar za biotehnologiju",
                "Tehničar poljoprivredne tehnike",
                "Tehničar hortikulture"
            });
            strucni.Add("Šumarstvo", new string[] {
                "Tehničar za pejzažnu arhitekturu",
                "Šumarski tehničar"
            });
            strucni.Add("Geologija, rudarstvo i metalurgija",
                "Geološki tehničar za geotehniku i hidrogeologiju\r\nGeološki tehničar za istraživanje mineralnih sirovina\r\nRudarski tehničar\r\nRudarski tehničar za pripremu mineralnih sirovina".Split("\r\n")
                );
            strucni.Add("Mašinstvo i obrada metala",
                "Brodomašinski tehničar\r\nMašinski tehničar za kompjutersko konstruisanje\r\nMašinski tehničar merne i regulacione tehnike\r\nMašinski tehničar motornih vozila\r\nTehničar grejanja i klimatizacije\r\nTehničar za kompjutersko upravljanje (CNC) mašina\r\nTehničar za robotiku\r\nTehničar mašinske energetike\r\nTehničar optike"
                .Split("\r\n")
                );
            strucni.Add("Elektrotehnika",
                "Elektrotehničar automatike\r\nElektrotehničar elektromotornih pogona\r\nElektrotehničar elektronike\r\nElektrotehničar energetike\r\nElektrotehničar za termičke i rashladne uređaje\r\nElektrotehničar informacionih tehnologija\r\nElektrotehničar procesnog upravljanja\r\nElektrotehničar računara"
                .Split("\r\n")
                );
            strucni.Add("Hemija, nemetali i grafičarstvo",
                "Техничар графичке дораде\r\nТехничар за заштиту животне средине\r\nТехничар за индустријску фармацеутску технологију\r\nТехничар штампе\r\nФотограф\r\nХемијски лаборант\r\nХемијско-технолошки техничар"
                .Split("\r\n")
                );
            strucni.Add("Tekstilstvo i kožarstvo", "Tekstilni tehničar".Split("\r\n"));
            strucni.Add("Geodezija i građevinarstvo",
                "Građevinski tehničar za laboratorijska ispitivanja\r\nGrađevinski tehničar za hidrogradnju\r\nIzvođač instalaterskih i završnih građevinskih radova"
                .Split("\r\n")
                );
            strucni.Add("Saobraćaj",
                "Nautički tehničar – rečni smer\r\nSaobraćajno-transportni tehničar\r\nTehničar vuče\r\nTehničar PTT saobraćaja\r\nTehničar unutrašnjeg transporta\r\nTransportni komercijalista"
                .Split("\r\n")
                );
            strucni.Add("Trgovina, ugostiteljstvo i turizam",
                "Kulinarski tehničar\r\nUgostiteljski tehničar"
                .Split("\r\n")
                );
            strucni.Add("Ekonomija, pravo i administracija",
                "Ekonomski tehničar\r\nFinansijski tehničar\r\nCarinski tehničar"
                .Split("\r\n")
                );
            strucni.Add("Zdravstvo i socijalna zaštita",
                "Ginekološko-akušerska sestra\r\nZubni tehničar\r\nMedicinska sestra – vaspitač\r\nPedijatrijska sestra – tehničar\r\nSanitarno-ekološki tehničar"
                .Split("\r\n")
                );
            strucni.Add("Lične usluge", "Scenski masker i vlasuljar".Split(';'));
        }
    }
}
