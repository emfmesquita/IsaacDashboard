﻿using System.Collections.Generic;

namespace IsaacDashboard.Isaac {
    public class Items {
        public static readonly Dictionary<int, Item> RebirthItems = new Dictionary<int, Item>() {
            {1, new Item("The Sad Onion", 1)},
            {2, new Item("The Inner Eye", 2)},
            {3, new Item("Spoon Bender", 3)},
            {4, new Item("Cricket's Head", 4)},
            {5, new Item("My Reflection", 5)},
            {6, new Item("Number One", 6)},
            {7, new Item("Blood of the Martyr", 7)},
            {8, new Item("Brother Bobby", 8)},
            {9, new Item("Skatole", 9)},
            {10, new Item("Halo of Flies", 10)},
            {11, new Item("1UP", 11)},
            {12, new Item("Magic Mushroom", 12)},
            {13, new Item("The Virus", 13)},
            {14, new Item("Roid Rage", 14)},
            {15, new Item("<3", 15)},
            {16, new Item("Raw Liver", 16)},
            {17, new Item("Skeleton Key", 17)},
            {18, new Item("A Dollar", 18)},
            {19, new Item("Boom!", 19)},
            {20, new Item("Transcendence", 20)},
            {21, new Item("The Compass", 21)},
            {22, new Item("Lunch", 22)},
            {23, new Item("Dinner", 23)},
            {24, new Item("Dessert", 24)},
            {25, new Item("Breakfast", 25)},
            {26, new Item("Rotten Meat", 26)},
            {27, new Item("Wooden Spoon", 27)},
            {28, new Item("The Belt", 28)},
            {29, new Item("Mom's Underwear", 29)},
            {30, new Item("Mom's Heels", 30)},
            {31, new Item("Mom's Lipstick", 31)},
            {32, new Item("Wire Coat Hanger", 32)},
            {33, new Item("The Bible", 33)},
            {34, new Item("The Book of Belial", 34)},
            {35, new Item("The Necronomicon", 35)},
            {36, new Item("The Poop", 36)},
            {37, new Item("Mr. Boom", 37)},
            {38, new Item("Tammy's Head", 38)},
            {39, new Item("Mom's Bra", 39)},
            {40, new Item("Kamikaze", 40)},
            {41, new Item("Mom's Pad", 41)},
            {42, new Item("Bob's Rotten Head", 42)},
            {44, new Item("Teleport", 44)},
            {45, new Item("Yum Heart", 45)},
            {46, new Item("Lucky Foot", 46)},
            {47, new Item("Doctor's Remote", 47)},
            {48, new Item("Cupid's Arrow", 48)},
            {49, new Item("Shoop Da Whoop", 49)},
            {50, new Item("Steven", 50)},
            {51, new Item("Pentagram", 51)},
            {52, new Item("Dr. Fetus", 52)},
            {53, new Item("Magneto", 53)},
            {54, new Item("Treasure Map", 54)},
            {55, new Item("Mom's Eye", 55)},
            {56, new Item("Lemon Mishap", 56)},
            {57, new Item("Distant Admiration", 57)},
            {58, new Item("Book of Shadows", 58)},
            {60, new Item("The Ladder", 60)},
            {62, new Item("Charm of the Vampire", 62)},
            {63, new Item("The Battery", 63)},
            {64, new Item("Steam Sale", 64)},
            {65, new Item("Anarchist's Cookbook", 65)},
            {66, new Item("The Hourglass", 66)},
            {67, new Item("Sister Maggy", 67)},
            {68, new Item("Technology", 68)},
            {69, new Item("Chocolate Milk", 69)},
            {70, new Item("Growth Hormones", 70)},
            {71, new Item("Mini Mush", 71)},
            {72, new Item("Rosary", 72)},
            {73, new Item("Cube of Meat", 73)},
            {74, new Item("A Quarter", 74)},
            {75, new Item("PhD", 75)},
            {76, new Item("X-Ray Vision", 76)},
            {77, new Item("My Little Unicorn", 77)},
            {78, new Item("Book of Revelations", 78)},
            {79, new Item("The Mark", 79)},
            {80, new Item("The Pact", 80)},
            {81, new Item("Dead Cat", 81)},
            {82, new Item("Lord of the Pit", 82)},
            {83, new Item("The Nail", 83)},
            {84, new Item("We Need To Go Deeper", 84)},
            {85, new Item("Deck of Cards", 85)},
            {86, new Item("Monstro's Tooth", 86)},
            {87, new Item("Loki's Horns", 87)},
            {88, new Item("Little Chubby", 88)},
            {89, new Item("Spider Bite", 89)},
            {90, new Item("The Small Rock", 90)},
            {91, new Item("Spelunker Hat", 91)},
            {92, new Item("Super Bandage", 92)},
            {93, new Item("The Gamekid", 93)},
            {94, new Item("Sack of Pennies", 94)},
            {95, new Item("Robo-Baby", 95)},
            {96, new Item("Little C.H.A.D.", 96)},
            {97, new Item("The Book of Sin", 97)},
            {98, new Item("The Relic", 98)},
            {99, new Item("Little Gish", 99)},
            {100, new Item("Little Steven", 100)},
            {101, new Item("The Halo", 101)},
            {102, new Item("Mom's Bottle of Pills", 102)},
            {103, new Item("The Common Cold", 103)},
            {104, new Item("The Parasite", 104)},
            {105, new Item("The D6", 105)},
            {106, new Item("Mr. Mega", 106)},
            {107, new Item("Pinking Shears", 107)},
            {108, new Item("The Wafer", 108)},
            {109, new Item("Money = Power", 109)},
            {110, new Item("Mom's Contacts", 110)},
            {111, new Item("The Bean", 111)},
            {112, new Item("Guardian Angel", 112)},
            {113, new Item("Demon Baby", 113)},
            {114, new Item("Mom's Knife", 114)},
            {115, new Item("Ouija Board", 115)},
            {116, new Item("9 Volt", 116)},
            {117, new Item("Dead Bird", 117)},
            {118, new Item("Brimstone", 118)},
            {119, new Item("Blood Bag", 119)},
            {120, new Item("Odd Mushroom (Thin)", 120)},
            {121, new Item("Odd Mushroom (Thick)", 121)},
            {122, new Item("Whore of Babylon", 122)},
            {123, new Item("Monster Manual", 123)},
            {124, new Item("Dead Sea Scrolls", 124)},
            {125, new Item("Bobby - Bomb", 125)},
            {126, new Item("Razor Blade", 126)},
            {127, new Item("Forget Me Now", 127)},
            {128, new Item("Forever Alone", 128)},
            {129, new Item("Bucket of Lard", 129)},
            {130, new Item("A Pony", 130)},
            {131, new Item("Bomb Bag", 131)},
            {132, new Item("A Lump of Coal", 132)},
            {133, new Item("Guppy's Paw", 133)},
            {134, new Item("Guppy's Tail", 134)},
            {135, new Item("IV Bag", 135)},
            {136, new Item("Best Friend", 136)},
            {137, new Item("Remote Detonator", 137)},
            {138, new Item("Stigmata", 138)},
            {139, new Item("Mom's Purse", 139)},
            {140, new Item("Bob's Curse", 140)},
            {141, new Item("Pageant Boy", 141)},
            {142, new Item("Scapular", 142)},
            {143, new Item("Speed Ball", 143)},
            {144, new Item("Bum Friend", 144)},
            {145, new Item("Guppy's Head", 145)},
            {146, new Item("Prayer Card", 146)},
            {147, new Item("Notched Axe", 147)},
            {148, new Item("Infestation", 148)},
            {149, new Item("Ipecac", 149)},
            {150, new Item("Tough Love", 150)},
            {151, new Item("The Mulligan", 151)},
            {152, new Item("Technology 2", 152)},
            {153, new Item("Mutant Spider", 153)},
            {154, new Item("Chemical Peel", 154)},
            {155, new Item("The Peeper", 155)},
            {156, new Item("Habit", 156)},
            {157, new Item("Bloody Lust", 157)},
            {158, new Item("Crystal Ball", 158)},
            {159, new Item("Spirit of the Night", 159)},
            {160, new Item("Crack The Sky", 160)},
            {161, new Item("Ankh", 161)},
            {162, new Item("Celtic Cross", 162)},
            {163, new Item("Ghost Baby", 163)},
            {164, new Item("The Candle", 164)},
            {165, new Item("Cat-O-Nine-Tails", 165)},
            {166, new Item("D20", 166)},
            {167, new Item("Harlequin Baby", 167)},
            {168, new Item("Epic Fetus", 168)},
            {169, new Item("Polyphemus", 169)},
            {170, new Item("Daddy Longlegs", 170)},
            {171, new Item("Spider Butt", 171)},
            {172, new Item("Sacrificial Dagger", 172)},
            {173, new Item("Mitre", 173)},
            {174, new Item("Rainbow Baby", 174)},
            {175, new Item("Dad's Key", 175)},
            {176, new Item("Stem Cells", 176)},
            {177, new Item("Portable Slot", 177)},
            {178, new Item("Holy Water", 178)},
            {179, new Item("Fate", 179)},
            {180, new Item("The Black Bean", 180)},
            {181, new Item("White Pony", 181)},
            {182, new Item("Sacred Heart", 182)},
            {183, new Item("Toothpicks", 183)},
            {184, new Item("Holy Grail", 184)},
            {185, new Item("Dead Dove", 185)},
            {186, new Item("Blood Rights", 186)},
            {187, new Item("Guppy's Hairball", 187)},
            {188, new Item("Abel", 188)},
            {189, new Item("SMB Super Fan", 189)},
            {190, new Item("Pyro", 190)},
            {191, new Item("3 Dollar Bill", 191)},
            {192, new Item("Telepathy for Dummies", 192)},
            {193, new Item("MEAT!", 193)},
            {194, new Item("Magic 8 Ball", 194)},
            {195, new Item("Mom's Coin Purse", 195)},
            {196, new Item("Squeezy", 196)},
            {197, new Item("Jesus Juice", 197)},
            {198, new Item("Box", 198)},
            {199, new Item("Mom's Key", 199)},
            {200, new Item("Mom's Eyeshadow", 200)},
            {201, new Item("Iron Bar", 201)},
            {202, new Item("Midas Touch", 202)},
            {203, new Item("Humbleing Bundle", 203)},
            {204, new Item("Fanny pack", 204)},
            {205, new Item("Sharp plug", 205)},
            {206, new Item("The Guillotine", 206)},
            {207, new Item("Ball of Bandages", 207)},
            {208, new Item("Champion Belt", 208)},
            {209, new Item("Butt Bombs", 209)},
            {210, new Item("Gnawed Leaf", 210)},
            {211, new Item("Spiderbaby", 211)},
            {212, new Item("Guppy's Collar", 212)},
            {213, new Item("Lost Contact", 213)},
            {214, new Item("Anemic", 214)},
            {215, new Item("Goat Head", 215)},
            {216, new Item("Ceremonial Robes", 216)},
            {217, new Item("Mom's Wig", 217)},
            {218, new Item("Placenta", 218)},
            {219, new Item("Old Bandage", 219)},
            {220, new Item("Sad Bombs", 220)},
            {221, new Item("Rubber Cement", 221)},
            {222, new Item("Anti-Gravity", 222)},
            {223, new Item("Pyromaniac", 223)},
            {224, new Item("Cricket's Body", 224)},
            {225, new Item("Gimpy", 225)},
            {226, new Item("Black Lotus", 226)},
            {227, new Item("Piggy Bank", 227)},
            {228, new Item("Mom's Perfume:", 228)},
            {229, new Item("Monstro's Lung", 229)},
            {230, new Item("Abaddon", 230)},
            {231, new Item("Ball of Tar", 231)},
            {232, new Item("Stop Watch", 232)},
            {233, new Item("Tiny Planet", 233)},
            {234, new Item("Infestation 2", 234)},
            {236, new Item("E. Coli", 236)},
            {237, new Item("Death's Touch", 237)},
            {238, new Item("Key Piece #1", 238)},
            {239, new Item("Key Piece #2", 239)},
            {240, new Item("Experimental Treatment", 240)},
            {241, new Item("Contract From Below", 241)},
            {242, new Item("Infamy", 242)},
            {243, new Item("Trinity Shield", 243)},
            {244, new Item("Tech.5", 244)},
            {245, new Item("20/20", 245)},
            {246, new Item("Blue Map", 246)},
            {247, new Item("BFFS!", 247)},
            {248, new Item("Hive Mind", 248)},
            {249, new Item("There's Options", 249)},
            {250, new Item("Bogo Bombs", 250)},
            {251, new Item("Starter Deck", 251)},
            {252, new Item("Little Baggy", 252)},
            {253, new Item("Magic Scab", 253)},
            {254, new Item("Blood Clot", 254)},
            {255, new Item("Screw", 255)},
            {256, new Item("Hot Bombs", 256)},
            {257, new Item("Fire Mind", 257)},
            {258, new Item("Missing No.", 258)},
            {259, new Item("Dark Matter", 259)},
            {260, new Item("Black Candle", 260)},
            {261, new Item("Proptosis", 261)},
            {262, new Item("Missing Page 2", 262)},
            {264, new Item("Smart Fly", 264)},
            {265, new Item("Dry Baby", 265)},
            {266, new Item("Juicy Sack", 266)},
            {267, new Item("Robo-Baby 2.0", 267)},
            {268, new Item("Rotten Baby", 268)},
            {269, new Item("Headless Baby", 269)},
            {270, new Item("Leech", 270)},
            {271, new Item("Mystery Sack", 271)},
            {272, new Item("BBF", 272)},
            {273, new Item("Bob's Brain", 273)},
            {274, new Item("Best Bud", 274)},
            {275, new Item("Lil' Brimstone", 275)},
            {276, new Item("Isaac's Heart", 276)},
            {277, new Item("Lil' Haunt", 277)},
            {278, new Item("Dark Bum", 278)},
            {279, new Item("Big Fan", 279)},
            {280, new Item("Sissy Long Legs", 280)},
            {281, new Item("Punching Bag", 281)},
            {282, new Item("How To Jump", 282)},
            {283, new Item("D100", 283)},
            {284, new Item("D4", 284)},
            {285, new Item("D10", 285)},
            {286, new Item("Blank Card", 286)},
            {287, new Item("Book of Secrets", 287)},
            {288, new Item("Box of Spiders", 288)},
            {289, new Item("Red Candle", 289)},
            {290, new Item("The Jar", 290)},
            {291, new Item("FLUSH!", 291)},
            {292, new Item("The Satanic Bible", 292)},
            {293, new Item("Head of Krampus", 293)},
            {294, new Item("Butter Bean", 294)},
            {295, new Item("Magic Fingers", 295)},
            {296, new Item("Converter", 296)},
            {297, new Item("Pandora's Box", 297)},
            {298, new Item("Unicorn Stump", 298)},
            {299, new Item("Taurus", 299)},
            {300, new Item("Aries", 300)},
            {301, new Item("Cancer", 301)},
            {302, new Item("Leo", 302)},
            {303, new Item("Virgo", 303)},
            {304, new Item("Libra", 304)},
            {305, new Item("Scorpio", 305)},
            {306, new Item("Sagittarius", 306)},
            {307, new Item("Capricorn", 307)},
            {308, new Item("Aquarius", 308)},
            {309, new Item("Pisces", 309)},
            {310, new Item("Eve's Mascara", 310)},
            {311, new Item("Judas' Shadow", 311)},
            {312, new Item("Maggy's Bow", 312)},
            {313, new Item("Holy Mantle", 313)},
            {314, new Item("Thunder Thighs", 314)},
            {315, new Item("Strange Attractor", 315)},
            {316, new Item("Cursed Eye", 316)},
            {317, new Item("Mysterious Liquid", 317)},
            {318, new Item("Gemini", 318)},
            {319, new Item("Cain's Other Eye", 319)},
            {320, new Item("???'s Only Friend", 320)},
            {321, new Item("Samson's Chains", 321)},
            {322, new Item("Mongo Baby", 322)},
            {323, new Item("Isaac's Tears", 323)},
            {324, new Item("Undefined", 324)},
            {325, new Item("Scissors", 325)},
            {326, new Item("Breath of Life", 326)},
            {327, new Item("The Polaroid", 327)},
            {328, new Item("The Negative", 328)},
            {329, new Item("The Ludovico Technique", 329)},
            {330, new Item("Soy Milk", 330)},
            {331, new Item("GodHead", 331)},
            {332, new Item("Lazarus' Rags", 332)},
            {333, new Item("The Mind", 333)},
            {334, new Item("The Body", 334)},
            {335, new Item("The Soul", 335)},
            {336, new Item("Dead Onion", 336)},
            {337, new Item("Broken Watch", 337)},
            {338, new Item("Boomerang", 338)},
            {339, new Item("Safety Pin", 339)},
            {340, new Item("Caffeine Pill", 340)},
            {341, new Item("Torn Photo", 341)},
            {342, new Item("Blue Cap", 342)},
            {343, new Item("Latch Key", 343)},
            {344, new Item("Match Book", 344)},
            {345, new Item("Synthoil", 345)},
            {346, new Item("A Snack", 346)}
        };

        public static readonly Dictionary<int, Item> AfterbirthItems = new Dictionary<int, Item> {
            {347, new Item("Diplopia", 347)},
            {348, new Item("Placebo", 348)},
            {349, new Item("Wooden Nickel", 349)},
            {350, new Item("Toxic Shock", 350)},
            {351, new Item("Mega Bean", 351)},
            {352, new Item("Glass Cannon", 352)},
            {353, new Item("Bomber Boy", 353)},
            {354, new Item("Crack Jacks", 354)},
            {355, new Item("Mom's Pearls", 355)},
            {356, new Item("Car Battery", 356)},
            {357, new Item("Box of Friends", 357)},
            {358, new Item("The Wiz", 358)},
            {359, new Item("8 Inch Nails", 359)},
            {360, new Item("Incubus", 360)},
            {361, new Item("Fate's Reward", 361)},
            {362, new Item("Lil Chest", 362)},
            {363, new Item("Sworn Protector", 363)},
            {364, new Item("Friend Zone", 364)},
            {365, new Item("Lost Fly", 365)},
            {366, new Item("Scatter Bombs", 366)},
            {367, new Item("Sticky Bombs", 367)},
            {368, new Item("Epiphora", 368)},
            {369, new Item("Continuum", 369)},
            {370, new Item("Mr. Dolly", 370)},
            {371, new Item("Curse of The Tower", 371)},
            {372, new Item("Charged Baby", 372)},
            {373, new Item("Dead Eye", 373)},
            {374, new Item("Holy Light!", 374)},
            {375, new Item("Host Hat", 375)},
            {376, new Item("Restock", 376)},
            {377, new Item("Bursting Sack", 377)},
            {378, new Item("No. 2", 378)},
            {379, new Item("Pupula Duplex", 379)},
            {380, new Item("Pay To Play", 380)},
            {381, new Item("Eden's Blessing", 381)},
            {382, new Item("Friendly Ball", 382)},
            {383, new Item("Tear Detonator", 383)},
            {384, new Item("Lil Gurdy", 384)},
            {385, new Item("Bumbo", 385)},
            {386, new Item("D12", 386)},
            {387, new Item("Censer", 387)},
            {388, new Item("Key Bum", 388)},
            {389, new Item("Rune Bag", 389)},
            {390, new Item("Seraphim", 390)},
            {391, new Item("Betrayal", 391)},
            {392, new Item("Zodiac", 392)},
            {393, new Item("Serpent's Kiss", 393)},
            {394, new Item("Marked", 394)},
            {395, new Item("Tech X", 395)},
            {396, new Item("Ventricle Razor", 396)},
            {397, new Item("Tractor Beam", 397)},
            {398, new Item("God's Flesh", 398)},
            {399, new Item("Maw of The Void", 399)},
            {400, new Item("Spear of Destiny", 400)},
            {401, new Item("Explosivo", 401)},
            {402, new Item("Chaos", 402)},
            {403, new Item("Spider Mod", 403)},
            {404, new Item("Farting Baby", 404)},
            {405, new Item("GB Bug", 405)},
            {406, new Item("D8", 406)},
            {407, new Item("Purity", 407)},
            {408, new Item("Athame", 408)},
            {409, new Item("Empty Vessel", 409)},
            {410, new Item("Evil Eye", 410)},
            {411, new Item("Lusty Blood", 411)},
            {412, new Item("Cambion Conception", 412)},
            {413, new Item("Immaculate Conception", 413)},
            {414, new Item("More Options", 414)},
            {415, new Item("Crown of Light", 415)},
            {416, new Item("Deep Pockets", 416)},
            {417, new Item("Succubus", 417)},
            {418, new Item("Fruit Cake", 418)},
            {419, new Item("Teleport 2.0", 419)},
            {420, new Item("Black Powder", 420)},
            {421, new Item("Kidney Bean", 421)},
            {422, new Item("Glowing Hour Glass", 422)},
            {423, new Item("Circle of Protection", 423)},
            {424, new Item("Sack Head", 424)},
            {425, new Item("Night Light", 425)},
            {426, new Item("Obsessed Fan", 426)},
            {427, new Item("Mine Crafter", 427)},
            {428, new Item("PJs", 428)},
            {429, new Item("Head of the Keeper", 429)},
            {430, new Item("Papa Fly", 430)},
            {431, new Item("Multidimensional Baby", 431)},
            {432, new Item("Glitter Bombs", 432)},
            {433, new Item("My Shadow", 433)},
            {434, new Item("Jar of Flies", 434)},
            {435, new Item("Lil Loki", 435)},
            {436, new Item("Milk!", 436)},
            {437, new Item("D7", 437)},
            {438, new Item("Binky", 438)},
            {439, new Item("Mom's Box", 439)},
            {440, new Item("Kidney Stone", 440)},
            {441, new Item("Mega Blast", 441)}
        };

        public static readonly Dictionary<int, Item> AfterbirthPlusItems = new Dictionary<int, Item>() {
            {442, new Item("Dark Princes Crown", 442)},
            {443, new Item("Apple!", 443)},
            {444, new Item("Lead Pencil", 444)},
            {445, new Item("Dog Tooth", 445)},
            {446, new Item("Dead Tooth", 446)},
            {447, new Item("Linger Bean", 447)},
            {448, new Item("Shard of Glass", 448)},
            {449, new Item("Metal Plate", 449)},
            {450, new Item("Eye of Greed", 450)},
            {451, new Item("Tarot Cloth", 451)},
            {452, new Item("Varicose Veins", 452)},
            {453, new Item("Compound Fracture", 453)},
            {454, new Item("Polydactyly", 454)},
            {455, new Item("Dad's Lost Coin", 455)},
            {456, new Item("Moldy Bread", 456)},
            {457, new Item("Cone Head", 457)},
            {458, new Item("Belly Button", 458)},
            {459, new Item("Sinus Infection", 459)},
            {460, new Item("Glaucoma", 460)},
            {461, new Item("Parasitoid", 461)},
            {462, new Item("Eye of Belial", 462)},
            {463, new Item("Sulfuric Acid", 463)},
            {464, new Item("Glyph of Balance", 464)},
            {465, new Item("Analog Stick", 465)},
            {466, new Item("Contagion", 466)},
            {467, new Item("Finger!", 467)},
            {468, new Item("Shade", 468)},
            {469, new Item("Depression", 469)},
            {470, new Item("Hushy", 470)},
            {471, new Item("Lil Monstro", 471)},
            {472, new Item("King Baby", 472)},
            {473, new Item("Big Chubby", 473)},
            {475, new Item("Plan C", 475)},
            {476, new Item("D1", 476)},
            {477, new Item("Void", 477)},
            {478, new Item("Pause", 478)},
            {479, new Item("Smelter", 479)},
            {480, new Item("Compost", 480)},
            {481, new Item("Dataminer", 481)},
            {482, new Item("Clicker", 482)},
            {483, new Item("MaMa Mega!", 483)},
            {484, new Item("Wait What?", 484)},
            {485, new Item("Crooked Penny", 485)},
            {486, new Item("Dull Razor", 486)},
            {487, new Item("Potato Peeler", 487)},
            {488, new Item("Metronome", 488)},
            {489, new Item("D infinity", 489)},
            {490, new Item("Eden's Soul", 490)},
            {491, new Item("Acid Baby", 491)},
            {492, new Item("YO LISTEN!", 492)},
            {493, new Item("Adderline", 493)},
            {494, new Item("Jacob's Ladder", 494)},
            {495, new Item("Ghost Pepper", 495)},
            {496, new Item("Euthanasia", 496)},
            {497, new Item("Camo Undies", 497)},
            {498, new Item("Duality", 498)},
            {499, new Item("Eucharist", 499)},
            {500, new Item("Sack of Sacks", 500)},
            {501, new Item("Greed's Gullet", 501)},
            {502, new Item("Large Zit", 502)},
            {503, new Item("Little Horn", 503)},
            {504, new Item("Brown Nugget", 504)},
            {505, new Item("Poke Go", 505)},
            {506, new Item("BackStabber", 506)},
            {507, new Item("Sharp Straw", 507)},
            {508, new Item("Mom's Razor", 508)},
            {509, new Item("Bloodshot Eye", 509)},
            {510, new Item("Delirious", 510)},
            {511, new Item("Angry Fly", 511)},
            {512, new Item("Black Hole", 512)},
            {513, new Item("Bozo", 513)},
            {514, new Item("Broken Modem", 514)},
            {515, new Item("Mystery Gift", 515)},
            {516, new Item("Sprinkler", 516)},
            {517, new Item("Fast Bombs", 517)},
            {518, new Item("Buddy in a Box", 518)},
            {519, new Item("Lil Delirium", 519)},
            {520, new Item("Jumper Cables", 520)},
            {521, new Item("Coupon", 521)},
            {522, new Item("Telekinesis", 522)},
            {523, new Item("Moving Box", 523)},
            {524, new Item("Technology Zero", 524)},
            {525, new Item("Leprosy", 525)},
            {526, new Item("7 Seals", 526)},
            {527, new Item("Mr. ME!", 527)},
            {528, new Item("Angelic Prism", 528)},
            {529, new Item("Pop!", 529)}
        };

        public static readonly Dictionary<int, Item> AntibirthItems = new Dictionary<int, Item>() {
            {1000, new Item("Mucormycosis", 1000)},
            {1001, new Item("2Spooky", 1001)},
            {1002, new Item("Schoolbag", 1002)},
            {1003, new Item("Sulfur", 1003)},
            {1004, new Item("Fortune Cookie", 1004)},
            {1005, new Item("Eye Sore", 1005)},
            {1006, new Item("120 Volt", 1006)},
            {1007, new Item("It Hurts", 1007)},
            {1008, new Item("Almond Milk", 1008)},
            {1009, new Item("Rock Bottom", 1009)},
            {1010, new Item("Enigma Bombs", 1010)},
            {1011, new Item("A Bar of Soap", 1011)},
            {1012, new Item("Book of Despair", 1012)},
            {1013, new Item("D12", 1013)},
            {1014, new Item("Paschal Candle", 1014)},
            {1015, new Item("Bowl of Tears", 1015)},
            {1016, new Item("Blood Oath", 1016)},
            {1017, new Item("Playdoh Cookie", 1017)},
            {1018, new Item("Orphan Socks", 1018)},
            {1019, new Item("Eye of the Occult", 1019)},
            {1020, new Item("Immaculate Heart", 1020)},
            {1021, new Item("Monstrance", 1021)},
            {1022, new Item("The Intruder", 1022)},
            {1023, new Item("Dirty Mind", 1023)},
            {1024, new Item("Damocles", 1024)},
            {1025, new Item("Free Lemonade", 1025)},
            {1026, new Item("Spirit Sword", 1026)},
            {1027, new Item("Red Key", 1027)},
            {1028, new Item("Psy Fly", 1028)},
            {1029, new Item("Black Mushroom", 1029)},
            {1030, new Item("Rocket in a Jar", 1030)},
            {1031, new Item("Book of Virtues", 1031)},
            {1032, new Item("Alabaster Box", 1032)},
            {1033, new Item("Jacob's Ladder", 1033)},
            {1034, new Item("Menorah", 1034)},
            {1035, new Item("Sol", 1035)},
            {1036, new Item("Luna", 1036)},
            {1037, new Item("Mercurius", 1037)},
            {1038, new Item("Venus", 1038)},
            {1039, new Item("Terra", 1039)},
            {1040, new Item("Mars", 1040)},
            {1042, new Item("Saturnus", 1042)},
            {1043, new Item("Uranus", 1043)},
            {1045, new Item("Pluto", 1045)},
            {1046, new Item("Voodoo Head", 1046)},
            {1047, new Item("Eye Drops", 1047)},
            {1048, new Item("Act of Contrition", 1048)},
            {1049, new Item("Member Card", 1049)},
            {1050, new Item("Battery Pack", 1050)},
            {1051, new Item("Mom's Bracelet", 1051)},
            {1052, new Item("The Scooper", 1052)},
            {1053, new Item("Oculus Rift", 1053)},
            {1054, new Item("Boiled Baby", 1054)},
            {1055, new Item("Freezer Baby", 1055)},
            {1056, new Item("Eternal D6", 1056)},
            {1057, new Item("Bird Cage", 1057)},
            {1058, new Item("Donkey Jawbone", 1058)},
            {1059, new Item("Lost Soul", 1059)},
            {1061, new Item("Blood Bombs", 1061)},
            {1062, new Item("Lil' Dumpy", 1062)},
            {1063, new Item("Bird's Eye", 1063)},
            {1064, new Item("Lodestone", 1064)},
            {1065, new Item("Rotten Tomato", 1065)},
            {1066, new Item("Birthright", 1066)},
            {1067, new Item("Voodoo Pin", 1067)},
            {1068, new Item("Red Stew", 1068)},
            {1069, new Item("Sausage", 1069)},
            {1070, new Item("Sharp Key", 1070)},
            {1071, new Item("Booster Pack", 1071)},
            {1072, new Item("Mega Mush", 1072)},
            {1073, new Item("Knife Piece 1", 1073)},
            {1074, new Item("Knife Piece 2", 1074)},
            {1075, new Item("Knife Piece 3", 1075)},
            {1076, new Item("Bot Fly", 1076)},
            {1078, new Item("Meat Cleaver", 1078)},
            {1079, new Item("Evil Charm", 1079)},
            {1080, new Item("Stone Bombs", 1080)},
            {1082, new Item("Stitches", 1082)},
            {1083, new Item("R Key", 1083)},
            {1084, new Item("Knockout Drops", 1084)},
            {1085, new Item("Eraser", 1085)},
            {1086, new Item("Yuck Heart", 1086)},
            {1088, new Item("Akeldama", 1088)},
            {1089, new Item("Magic Skin", 1089)},
            {1090, new Item("Revelation", 1090)},
            {1091, new Item("Consolation Prize", 1091)},
            {1092, new Item("Tinytoma", 1092)}
        };
    }
}
