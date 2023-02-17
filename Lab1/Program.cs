using System;
using System.Collections.Generic;
using System.Diagnostics;
using DSA.DataStructures.Trees;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = 10_000_000;
            int ITERATIONS = 11;

            double totalOrderedCreate = 0;
            double totalOrderedGet = 0;
            double totalOrderedRemove = 0;

            double totalUnorderedCreate = 0;
            double totalUnorderedGet = 0;
            double totalUnorderedRemove = 0;

            double totalOrderedHeight = 0;
            double totalUnorderedHeight = 0;

            
            IKeyValueMap<int, int> keyValueMap = null;

            for (int c = 0; c < ITERATIONS; c++)
            {
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 42));
                }


                //Console.Write("Ordered\t");
                //Dictionary 
                //var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
                //keyValueMap = dictionaryKeyValueMap;
                //totalOrderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedRemove += RemoveKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedHeight += keyValueMap.Height;


                ////BST
                var bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();
                keyValueMap = bstKeyValueMap;
                totalOrderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                totalOrderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                totalOrderedRemove += RemoveKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);



                ////Red Black Tree
                //var RedBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();
                //keyValueMap = RedBlackKeyValueMap;
                //totalOrderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedRemove += RemoveKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);



                ////AVL Tree
                //var avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();
                //keyValueMap = avlKeyValueMap;
                //totalOrderedCreate += CreateKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedGet += QueryKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedRemove += RemoveKeyValueMap<int, int>(keyValueMap, intKeyValuePairs);
                //totalOrderedHeight += keyValueMap.Height;



                //Console.Write("Unordered\t");
                intKeyValuePairs.Shuffle();

                //Dictionary
                //dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
                //totalUnorderedCreate += CreateKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                //totalUnorderedGet += QueryKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                //totalUnorderedRemove += RemoveKeyValueMap<int, int>(dictionaryKeyValueMap, intKeyValuePairs);
                //totalUnorderedHeight += dictionaryKeyValueMap.Height;

                ////BST
                bstKeyValueMap = new BinarySearchTreeKeyValueMap<int, int>();
                totalUnorderedCreate += CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
                totalUnorderedGet += QueryKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
                totalUnorderedRemove += RemoveKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);
                totalUnorderedHeight += bstKeyValueMap.Height;

                ////Red Black 
                //RedBlackKeyValueMap = new RedBlackTreeKeyValueMap<int, int>();
                //totalUnorderedCreate += CreateKeyValueMap<int, int>(RedBlackKeyValueMap, intKeyValuePairs);
                //totalUnorderedGet += QueryKeyValueMap<int, int>(RedBlackKeyValueMap, intKeyValuePairs);
                //totalUnorderedRemove += RemoveKeyValueMap<int, int>(RedBlackKeyValueMap, intKeyValuePairs);
                //totalUnorderedHeight += RedBlackKeyValueMap.Height;

                ////AVL
                //avlKeyValueMap = new AVLTreeKeyValueMap<int, int>();
                //totalUnorderedCreate += CreateKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);
                //totalUnorderedGet += QueryKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);
                //totalUnorderedRemove += RemoveKeyValueMap<int, int>(avlKeyValueMap, intKeyValuePairs);
                //totalUnorderedHeight += avlKeyValueMap.Height;

            }

            Console.WriteLine(keyValueMap.GetType());

            Console.WriteLine("Ordered\t");
            Console.WriteLine(totalOrderedCreate / ITERATIONS);
            Console.WriteLine(totalOrderedGet / ITERATIONS);
            Console.WriteLine(totalOrderedRemove / ITERATIONS);
            Console.WriteLine(totalOrderedHeight / ITERATIONS);

            Console.WriteLine("Unordered\t");
            Console.WriteLine(totalUnorderedCreate / ITERATIONS);
            Console.WriteLine(totalUnorderedGet / ITERATIONS);
            Console.WriteLine(totalUnorderedRemove / ITERATIONS);
            Console.WriteLine(totalUnorderedHeight / ITERATIONS);
        }


        public static double CreateKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey,TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs )
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            foreach(var kvp in keyValuePairs)
            {
                keyValueMap.Add(kvp.Key, kvp.Value);
            }

            stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed.TotalSeconds);

            return stopwatch.Elapsed.TotalSeconds;


        }


        //TODO
        public static double QueryKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Get(kvp.Key);
            }

            stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed.TotalSeconds);

            return stopwatch.Elapsed.TotalSeconds;
            
        }



        //TODO
        public static double RemoveKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Remove(kvp.Key);
            }

            stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed.TotalSeconds);

            return stopwatch.Elapsed.TotalSeconds;

        }
    }
}
