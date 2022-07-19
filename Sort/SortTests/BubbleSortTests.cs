using SortApp;

namespace SortTests
{
    public class BubbleSortTests
    {

        [TestCase(new int[] { 30, 29, 24, 4, 18 }, new int[] { 4, 18, 24, 29, 30 })]
        [TestCase(new int[] { 66, 21 }, new int[] { 21, 66 })]
        [TestCase(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void GivenAnArrayOfMultipeDifferentNumbers_BubbleSorting_ReturnsLowestToHighest(int[] array, int[] resultArray)
        {
            Assert.That(BubbleSort.BubbleSorting(array), Is.EqualTo(resultArray));
        }

        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 })]
        public void GivenAnArrayOfTheSameNumbers_BubbleSorting_ReturnsSameNumbers(int[] array)
        {
            Assert.That(BubbleSort.BubbleSorting(array), Is.EqualTo(array));
        }

        [TestCase(new int[] { }, new int[] { })]
        public void GivenAnEmptyArray_BubbleSorting_ReturnsEmptyArray(int[] array, int[] resultArray)
        {
            Assert.That(BubbleSort.BubbleSorting(array), Is.EqualTo(resultArray));
        }

        [TestCase(new int[] { -1, -10, -9, -12, -50 }, new int[] { -50, -12, -10, -9, -1 })]
        [TestCase(new int[] { -4, -2, -5 }, new int[] { -5, -4, -2 })]
        [TestCase(new int[] { 0, -10, 32, -5 }, new int[] { -10, -5, 0, 32 })]
        public void GivenAnArrayOfNegativeNumbers_BubbleSorting_ReturnsLowestToHighest(int[] array, int[] resultArray)
        {
            Assert.That(BubbleSort.BubbleSorting(array), Is.EqualTo(resultArray));
        }

        [TestCase(new int[] { -10, -4, 0, 1, 33, 67, 3002 })]
        public void GivenAnArrayOfSortedNumbers_BubbleSorting_ReturnsSameNumbers(int[] array)
        {
            Assert.That(BubbleSort.BubbleSorting(array), Is.EqualTo(array));
        }

        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { -48 })]
        public void GivenAnArrayOfOneNumber_BubbleSorting_ReturnsSameNumber(int[] array)
        {
            Assert.That(BubbleSort.BubbleSorting(array), Is.EqualTo(array));
        }
    }
}