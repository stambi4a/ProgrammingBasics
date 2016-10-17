namespace Problem_01.Tables
{
    using System;

    internal class Program
    {
        private const long BundleCount = 4;
        private const long LegsInATable = 4;
        private const long TopsInATable = 1;
        private const string JustEnoughTablesMessage = "Just enough tables made: {0}";
        private const string MoreMessage = "more: {0}";
        private const string LessMessage = "less: {0}";
        private const string PartsNeededMessage = "tops needed: {0}, legs needed: {1}";
        private const string PartsLeftMessage = "tops left: {0}, legs left: {1}";

        private static void Main(string[] args)
        {
            var legsInAPackage = new [] { 1, 2, 3, 4 };
            var packagesInAbundle = new long[BundleCount];
            for (var i = 0; i < BundleCount; i++)
            {
                packagesInAbundle[i] = long.Parse(Console.ReadLine());
            }

            var legsCount = 0L;
            for (var i = 0; i < BundleCount; i++)
            {
                legsCount += packagesInAbundle[i] * legsInAPackage[i];
            }

            var topCount = long.Parse(Console.ReadLine());
            var tablesToMake = long.Parse(Console.ReadLine());
            var legComplects = legsCount / LegsInATable;
            var topComplects = topCount / TopsInATable;
            var maxComplects = legComplects < topComplects ? legComplects : topComplects;
            if (maxComplects == tablesToMake)
            {
                Console.WriteLine(JustEnoughTablesMessage, tablesToMake);
                return;
            }

            if (maxComplects < tablesToMake)
            {
                Console.WriteLine(LessMessage, maxComplects - tablesToMake);
                var topsToMake = tablesToMake * TopsInATable;
                topsToMake = topsToMake > topCount ? topsToMake - topCount : 0;
                var legsToMake = tablesToMake * LegsInATable;
                legsToMake = legsToMake > legsCount ? legsToMake - legsCount : 0;
                Console.WriteLine(PartsNeededMessage, topsToMake, legsToMake);
                return;
            }

            Console.WriteLine(MoreMessage, maxComplects - tablesToMake);
            var legsLeft = legsCount - tablesToMake * LegsInATable;
            var topsLeft = topCount - tablesToMake * TopsInATable;
            Console.WriteLine(PartsLeftMessage, topsLeft, legsLeft);
        }
    }
}
