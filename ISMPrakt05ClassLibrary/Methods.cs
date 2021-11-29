using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMPrakt05ClassLibrary
{
    public class Methods
    {
        Random random = new Random();
        public int[] FillArrayWhithRandVall(long n) 
        {
            int[] arr = new int[n];
            for (long i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 11);
            }
            return arr;
        }
        public long SumNegEls(int[] arr)
        {
            long sumNegEls = 0;
            for(long i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) sumNegEls += arr[i];
            }
            return sumNegEls;
        }
        public long[] MaxOfPairEl(int[] arr)
        {
            int maxOfPair = -10;
            long indexMaxOfPair = -1;
            for (long i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] > maxOfPair)
                {
                    indexMaxOfPair = i;
                    maxOfPair = arr[i];
                }
            }
            long[] elemet =
            {
                indexMaxOfPair,
                maxOfPair
            };
            return elemet;
        }
        public long DobElWhithPairIndex(int[] arr)
        {
            long dobElWhithPairIndex = 1;
            for(long i = 0; i < arr.Length; i++)
            {
                if (i%2==0)
                {
                    dobElWhithPairIndex *= arr[i];
                }
            }
            return dobElWhithPairIndex;
        }
        public long IndexMaxEl(int[] arr)
        {
            long indexMaxEl=0;
            long maxEl = arr.Max();
            for(long i = 0; i < arr.Length; i++)
            {
                if (arr[i] == maxEl)
                {
                    indexMaxEl = i;
                    break;
                }
            }
            return indexMaxEl;
        }
        public long[] MaxOfAbsEl(int[] arr)
        {
            int maxOfAbsEl = 0;
            long indexMaxOfAbsEl = 0;
            for (long i=0;i<arr.Length;i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(maxOfAbsEl))
                {
                    indexMaxOfAbsEl = i;
                    maxOfAbsEl = arr[i];
                }
            }
            long[] element =
            {
                indexMaxOfAbsEl,
                maxOfAbsEl
            };
            return element;
        }
        public long SumIndexPossEl(int[] arr)
        {
            long sumIndexPossEl = -1;
            bool isPossInArr = false;
            for(long i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    if (!isPossInArr) 
                    {
                        sumIndexPossEl = 0;
                        isPossInArr = true;
                    }
                    sumIndexPossEl += i;
                }
            }
            return sumIndexPossEl;
        }
        public long ColsAnPairEl(int[] arr)
        {
            long colsAnPairEl = -1;
            bool anPairInArr = false;
            for (long i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (!anPairInArr)
                    {
                        colsAnPairEl = 0;
                        anPairInArr = true;
                    }
                    colsAnPairEl++;
                }
            }
            return colsAnPairEl;
        }
    }
}
