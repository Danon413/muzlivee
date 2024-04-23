using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopWebsite.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2023, 4, 23, 23, 12, 25, 232, DateTimeKind.Local).AddTicks(333), 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 3, 1, DateTime.Now, "Creating a stylish animated cover for your song.", "https://static.tildacdn.one/tild3261-3538-4632-b062-653637623561/cover.svg", 100m, "Animated cover" },
                    { 4, 1, DateTime.Now, "Creation from scratch or revision of your instrumentals.", "https://static.tildacdn.one/tild3965-6239-4737-b731-363964633962/Group_151.svg", 100m, "Creation of musical instrumentals" },
                    { 5, 1, DateTime.Now, "Work with voice tuning, creating author's songs, ear/rhythm development and preparation for performance.", "https://static.tildacdn.one/tild6662-6465-4338-b262-616337333833/Group_150.svg", 30m, "Vocal lessons" },
                    { 6, 2, DateTime.Now, "Strings Scale:17\" (433 mm)\r\nBody Depth: 2 13/16\"-2 13/16\" (70-70 mm)\r\nFinger Board Width (Nut/Body): 1 7/8\" (48 mm)\r\nTop: Spruce\r\nBack: Meranti\r\nSide/Rib: Meranti\r\nNeck: Nato\r\nFinger Board: Rosewood\r\nBridge: Rosewood\r\nIncluded Accessories: Gig Bag.", "https://pvxmusic.ee/media/catalog/product/cache/3/thumbnail/900x1260/9df78eab33525d08d6e5fb8d27136e95/y/a/yamaha-gl1-guitalele-bl-black-157883_z.jpg", 40m, "Yamaha GL1 guitalele (Black)" },
                    { 7, 2, DateTime.Now, "Enables mobile creativity with integrated Arpeggiator and Phrase Recorder\r\n37 Velocity sensitive slim keys\r\n32 Voice polyphony\r\n42 Voices (instruments)\r\n138 Arpeggio types\r\nPhrase Recorder\r\nMotion effect\r\nUSB-MIDI connection for DAW home recording setup\r\nPower supply via battery or USB bus (USB power adapter sold separately)\r\n1.4 W speaker\r\nHeadphone jack\r\nUSB to Host connection (MIDI, USB micro B)\r\nDimensions: 506 x 54 x 201 mm\r\nWeight: 1.2 kg\r\nUSB cable included.", "https://uk.yamaha.com/en/files/index_pss-a50_11bef9e9fade43568f04c34cea00b6e1.jpg?impolicy=resize&imwid=2000&imhei=2000", 30m, "YAMAHA PSS-A50 KEYBOARD." },
                    { 8, 3, DateTime.Now, "Considered one of his most popular songs, “Magnolia” is an emblem of Playboi Carti’s fast and loose lifestyle—he rhymes about cops, sex, and drugs, all over a beat by Pi'erre Bourne. The title refers to the Magnolia Projects, which fits the bouncy New Orleans-inspired production.\r\n\r\nIn March 2017, Carti previewed the song during his SXSW performance with producer Southside. On March 19, Carti went on Twitter to drop a promotional trailer for his debut mixtape, which featured a segment of the song as a backdrop. Later that day, Carti and Southside played the full song on Instagram Live.", "https://t2.genius.com/unsafe/340x340/https%3A%2F%2Fimages.genius.com%2Fae805a20a66452747dad0296f0ed50a1.800x800x1.png", 60m, "Playboi Carti" },
                    { 9, 3, DateTime.Now, "“SICKO MODE” refers to Travis and Drake’s work ethic, showing they’re a cut above the competition by going into “sicko” or “beast” mode.\r\n\r\n“Sicko,” or “6icko” (the 6 referring to Drake’s hometown Toronto), is a term derived from Drake’s vernacular. It refers to his friends, brought to the limelight by Golden State Warriors All-Star Kevin Durant, when he tweeted his reaction to Drake’s 2015 diss track, “Charged Up.”", "https://t2.genius.com/unsafe/340x340/https%3A%2F%2Fimages.genius.com%2F1987364b224dd26f58c1ee324865b180.805x805x1.png", 0m, "Travis Scott" },
                    //{ 10, 3, DateTime.Now, "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", 0m, "Xbox" },
                    //{ 11, 3, DateTime.Now, "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", 0m, "Super Nintendo Entertainment System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2023, 4, 23, 23, 8, 35, 589, DateTimeKind.Local).AddTicks(5169), 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "DateCreated", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, new DateTime(2023, 4, 23, 23, 8, 35, 589, DateTimeKind.Local).AddTicks(5201), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", 8.19m, "Half-Life 2" });
        }
    }
}
