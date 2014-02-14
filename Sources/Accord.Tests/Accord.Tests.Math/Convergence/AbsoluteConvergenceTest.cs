﻿// Accord Unit Tests
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2014
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Tests.Math
{
    using Accord.Math;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;    
    
    [TestClass()]
    public class AbsoluteConvergenceTest
    {


        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }



        [TestMethod()]
        public void AbsoluteConvergenceConstructorTest()
        {
            var criteria = new AbsoluteConvergence(iterations: 10, tolerance: 0.1);

            int progress = 1;

            do
            {
                // Do some processing...


                // Update current iteration information:
                criteria.NewValue = 12345.6 / progress++;

            } while (!criteria.HasConverged);


            // The method will converge after reaching the 
            // maximum of 10 iterations with a final value
            // of 1371.73:

            int iterations = criteria.CurrentIteration; // 10
            double value = criteria.OldValue; // 1371.7333333


            Assert.AreEqual(10, criteria.CurrentIteration);
            Assert.AreEqual(1371.7333333333333, criteria.OldValue);
        }
    }
}
