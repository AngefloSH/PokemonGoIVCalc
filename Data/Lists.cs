using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokémonGoManager.Data
{

    //Enums
    public enum Type : byte { Normal = 0, Fighting, Flying, Poison, Ground, Rock, Bug, Ghost, Steel, Fire, Water, Grass, Electric, Psychic, Ice, Dragon, Dark, Fairy }
    public enum MoveStyle : byte { Auto = 0, Charge}


    public static class Lists
    {


        internal static List<Pokemon> PokemonList;
        internal static List<Move> MoveList;

        internal static List<string> NamesEN;
        internal static List<string> NamesFR;
        internal static List<string> NamesDE;
        internal static List<string> NamesES;
        internal static List<string> NamesIT;
        internal static List<string> NamesJP;
        internal static List<string> NamesKR;
        internal static List<string> TextMystic;
        internal static List<string> TextValor;
        internal static List<string> TextInstinct;

        internal static int[] overallThreshold = new int[] { 23, 30, 37 };
        internal static int[] statThreshold = new int[] { 8, 13, 15 };


        internal static double[] cpM = new double[] {
        0.0940000, 0.1351374, 0.1663979, 0.1926509, 0.2157325,
        0.2365727, 0.2557201, 0.2735304, 0.2902499, 0.3060574,
        0.3210876, 0.3354450, 0.3492127, 0.3624578, 0.3752356,
        0.3875924, 0.3995673, 0.4111936, 0.4225000, 0.4329264,
        0.4431076, 0.4530600, 0.4627984, 0.4723361, 0.4816850,
        0.4908558, 0.4998584, 0.5087018, 0.5173940, 0.5259425,
        0.5343543, 0.5426358, 0.5507927, 0.5588306, 0.5667545,
        0.5745692, 0.5822789, 0.5898879, 0.5974000, 0.6048188,
        0.6121573, 0.6194041, 0.6265671, 0.6336492, 0.6406530,
        0.6475810, 0.6544356, 0.6612193, 0.6679340, 0.6745819,
        0.6811649, 0.6876849, 0.6941437, 0.7005429, 0.7068842,
        0.7131691, 0.7193991, 0.7255756, 0.7317000, 0.7347410,
        0.7377695, 0.7407856, 0.7437894, 0.7467812, 0.7497610,
        0.7527291, 0.7556855, 0.7586304, 0.7615638, 0.7644861,
        0.7673972, 0.7702973, 0.7731865, 0.7760650, 0.7789328,
        0.7817901, 0.7846370, 0.7874736, 0.7903000};


        static short[] natIDs = new short[] {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
            61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
            91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120,
            121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150,
            151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180,
            181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210,
            211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240,
            241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270,
            271, 272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289, 290, 291, 292, 293, 294, 295, 296, 297, 298, 299, 300,
            301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330,
            331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360,
            361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 386, 386, 386, 387,
            388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 413, 413, 414, 415,
            416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445,
            446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475,
            476, 477, 478, 479, 479, 479, 479, 479, 479, 480, 481, 482, 483, 484, 485, 486, 487, 487, 488, 489, 490, 491, 492, 492, 493, 494, 495, 496, 497, 498,
            499, 500, 501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516, 517, 518, 519, 520, 521, 522, 523, 524, 525, 526, 527, 528,
            529, 530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550, 551, 552, 553, 554, 555, 555, 556, 557,
            558, 559, 560, 561, 562, 563, 564, 565, 566, 567, 568, 569, 570, 571, 572, 573, 574, 575, 576, 577, 578, 579, 580, 581, 582, 583, 584, 585, 586, 587,
            588, 589, 590, 591, 592, 593, 594, 595, 596, 597, 598, 599, 600, 601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617,
            618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 641, 642, 642, 643, 644, 645,
            645, 646, 646, 646, 647, 648, 648, 649, 650, 651, 652, 653, 654, 655, 656, 657, 658, 659, 660, 661, 662, 663, 664, 665, 666, 667, 668, 669, 670, 671,
            672, 673, 674, 675, 676, 677, 678, 679, 680, 681, 681, 682, 683, 684, 685, 686, 687, 688, 689, 690, 691, 692, 693, 694, 695, 696, 697, 698, 699, 700,
            701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 710, 710, 710, 711, 711, 711, 711, 712, 713, 714, 715, 716, 717, 718, 719, 720, 721
        };

        public static void initializePokemon()
        {
            int released = Properties.Settings.Default.ReleasedPokemon;
            string[] englishNames = Properties.Resources.NamesEN.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] frenchNames = Properties.Resources.NamesFR.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            NamesEN = new List<string>();
            NamesFR = new List<string>();
            NamesES = new List<string>();
            NamesIT = new List<string>();
            TextMystic = new List<string>();
            TextValor = new List<string>();
            TextInstinct = new List<string>();
            TextMystic.AddRange(Properties.Resources.TextMystic.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));
            TextValor.AddRange(Properties.Resources.TextValor.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));
            TextInstinct.AddRange(Properties.Resources.TextInstinct.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));

            PokemonList = new List<Pokemon>();
            for (int i = 0; natIDs[i] <= released; i++)
            {
                NamesEN.Add(englishNames[i]);
                NamesES.Add(englishNames[i]);
                NamesIT.Add(englishNames[i]);
                NamesFR.Add(frenchNames[i]);
                byte[] data = new byte[8];
                Array.Copy(Properties.Resources.Pokemon, (i) * 8, data, 0, 8);
                PokemonList.Add(new Pokemon(natIDs[i], data));
            }
        }
    }
}
