﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Helpers;

namespace Tests.HelpersUT
{
    public class CalculationsUT
    {
        [Fact]
        public void TestGCD()
        {
            var gcd = Calculations.GCD(1, 2);
            Assert.Equal(1, gcd);
            gcd = Calculations.GCD(2, 6);
            Assert.Equal(2, gcd);
            gcd = Calculations.GCD(4, 8);
            Assert.Equal(4, gcd);
            gcd = Calculations.GCD(6, 76);
            Assert.Equal(2, gcd);
            gcd = Calculations.GCD(9, 81);
            Assert.Equal(9, gcd);
        }

        [Fact]
        public void TestGCDList()
        {
            List<long> numbers = new List<long>();

            numbers = new List<long>() { 2, 7, 3, 9, 4 };
            var gcd = Calculations.GCD(numbers);
            Assert.Equal(1, gcd);
            numbers = new List<long>() { 455, 8405, 150, 2379520 };
            gcd = Calculations.GCD(numbers);
            Assert.Equal(5, gcd);
            numbers = new List<long>() { 24253, 21797, 14429, 16271, 20569, 13201 };
            gcd = Calculations.GCD(numbers);
            Assert.Equal(307, gcd);
        }

        [Fact]
        public void TestLCM()
        {
            var lcm = Calculations.LCM(1, 2);
            Assert.Equal(2, lcm);
            lcm = Calculations.LCM(2, 6);
            Assert.Equal(6, lcm);
            lcm = Calculations.LCM(4, 8);
            Assert.Equal(8, lcm);
            lcm = Calculations.LCM(6, 76);
            Assert.Equal(228, lcm);
            lcm = Calculations.LCM(24253, 21797);
            Assert.Equal(1721963, lcm);
        }

        [Fact]
        public void TestLCMList()
        {
            List<long> numbers = new List<long>();

            numbers = new List<long>() { 2, 7, 3, 9, 4 };
            var lcm = Calculations.LCM(numbers);
            Assert.Equal(252, lcm);
            numbers = new List<long>() { 24253, 21797, 14429, 16271, 20569, 13201 };
            lcm = Calculations.LCM(numbers);
            Assert.Equal(12357789728873, lcm);
        }
    }
}
