﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomBuiltListTestProject
{
    [TestClass]

    public class CustomBuiltListTestClass
    {
        [TestMethod]
        public void TestCountOne()
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            testList.Add("String 1");
            Assert.AreEqual(testList.Count(), 1);
        }
        [TestMethod]
        public void TestCountMoreThanOne()
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            testList.Add("String 1");
            testList.Add("String 2");
            testList.Add("String 3");
            Assert.AreEqual(testList.Count(), 3);
        }
        [TestMethod]
        public void TestCountZero()
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            Assert.AreEqual(testList.Count(), 0);
        }
        [TestMethod]
        public void TestAdd()
        {
            CustomBuiltList<int> testList = new CustomBuiltList<int>();
            testList.Add(1);
            int[] numbers = new int[1];
            numbers[0] = 1;
            Assert.AreEqual(numbers[0], testList.elements[0]);
        }
        [TestMethod]
        public void TestAddWhenElementsExist()
        {
            CustomBuiltList<int> testList = new CustomBuiltList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            Assert.AreEqual(numbers[2], testList.elements[2]);
        }

        [TestMethod]
        public void TestRemoveToNoElementsThenAdd()
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            testList.Add("Hello");
            testList.Remove("Hello");
            testList.Add("World");
            Assert.AreEqual("World", testList.elements[0]);
        }
        [TestMethod]
        public void TestTryToRemoveWhenThereAreZeroElements()
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            bool result = testList.Remove("Hello");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestRemoveWithMoreThanOneElement()
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            testList.Add("Hello");
            testList.Add("World");
            testList.Remove("Hello");
            Assert.AreEqual("World", testList.elements[0]);
        }
        [TestMethod]
        public void TestRemoveWhenMoreThanOneCopyOfTheStringToRemovExistsInTheArray()
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            CustomBuiltList<string> testList2 = new CustomBuiltList<string>();
            CustomBuiltList<string> testList3 = new CustomBuiltList<string>();
            testList.Add("String 1");
            testList.Add("String 2");
            testList.Add("String 3");
            testList.Add("String 2");
            testList.Remove("String 2");
            string[] compareArray = new string[3];
            compareArray[0] = "String 1";
            compareArray[1] = "String 3";
            compareArray[2] = "String 2";
            Assert.AreEqual(testList.elements[0], compareArray[0]);
            Assert.AreEqual(testList.elements[1], compareArray[1]);
            Assert.AreEqual(testList.elements[2], compareArray[2]);
        }
        [TestMethod]
        public void TestToStringWithStrings()
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            testList.Add("Hello");
            testList.Add("World");
            Assert.AreEqual("HelloWorld", testList.ToString());

        }
        [TestMethod]
        public void TestToStringWithIntegers()
        {
            CustomBuiltList<int> testList = new CustomBuiltList<int>();
            testList.Add(1);
            testList.Add(2);
            Assert.AreEqual("12", testList.ToString());

        }
        [TestMethod]
        public void TestToStringWithDoubles()
        {
            CustomBuiltList<double> testList = new CustomBuiltList<double>();
            testList.Add(1.5);
            testList.Add(2.3);
            Assert.AreEqual("1.52.3", testList.ToString());

        }
        [TestMethod]
        public void TestToStringEmpty()
        {
            CustomBuiltList<double> testList = new CustomBuiltList<double>();
            Assert.AreEqual("", testList.ToString());
        }
        [TestMethod]
        public void TestSort()
        {
            CustomBuiltList<int> testList = new CustomBuiltList<int>();
            testList.Add(5);
            testList.Add(2);
            testList.Add(10);
            testList.Add(7);
            testList.Sort();
            int[] sorted = new int[4];
            sorted[0] = 2;
            sorted[1] = 5;
            sorted[2] = 7;
            sorted[3] = 10;

            Assert.AreEqual(testList.elements[0], sorted[0]);
            Assert.AreEqual(testList.elements[1], sorted[1]);
            Assert.AreEqual(testList.elements[2], sorted[2]);
            Assert.AreEqual(testList.elements[3], sorted[3]);
        }
        [TestMethod]
        public void TestOverloadPlus()
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            testList.Add("String 1");
            testList.Add("String 2");
            testList.Add("String 3");
            CustomBuiltList<string> testList2 = new CustomBuiltList<string>();
            testList2.Add("String 4");
            testList2.Add("String 5");
            testList2.Add("String 6");
            CustomBuiltList<string> testList3 = new CustomBuiltList<string>();
            testList3 = testList + testList2;
            Assert.AreEqual(testList3.elements[0], "String 1");
            Assert.AreEqual(testList3.elements[1], "String 2");
            Assert.AreEqual(testList3.elements[2], "String 3");
            Assert.AreEqual(testList3.elements[3], "String 4");
            Assert.AreEqual(testList3.elements[4], "String 5");
            Assert.AreEqual(testList3.elements[5], "String 6");
        }
        [TestMethod]
        public void TestOverloadMinus()
        {
            CustomBuiltList<string> testList = new CustomBuiltList<string>();
            testList.Add("String 1");
            testList.Add("String 2");
            testList.Add("String 3");
            testList.Add("String 4");
            CustomBuiltList<string> testList2 = new CustomBuiltList<string>();
            testList2.Add("String 2");
            testList2.Add("String 3");
            CustomBuiltList<string> testList3 = new CustomBuiltList<string>();
            testList3 = testList - testList2;
            Assert.AreEqual(testList3.elements[0], "String 1");
            Assert.AreEqual(testList3.elements[1], "String 4");
        }


    }
}
