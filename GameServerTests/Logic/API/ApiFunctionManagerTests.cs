﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeagueSandbox.GameServer.Logic.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSandbox.GameServer.Logic.API;

namespace GameServerTests
{
    [TestClass()]
    public class ApiFunctionManagerTests
    {
        [TestMethod()]
        public void StringToByteArrayTest()
        {
            byte[] shouldBe = { 0xC6, 0x00, 0x10, 0x45, 0xF8};
            var byteArray = ApiFunctionManager.StringToByteArray("C6001045F8");
            Assert.AreEqual(shouldBe.Length, byteArray.Length);
            for (int i = 0; i < shouldBe.Length; i++)
            {
                Assert.AreEqual(shouldBe[i], byteArray[i]);
            }

            byteArray = ApiFunctionManager.StringToByteArray("C6 00 10 45 F8");
            for (int i = 0; i < shouldBe.Length; i++)
            {
                Assert.AreEqual(shouldBe[i], byteArray[i]);
            }

            byteArray = ApiFunctionManager.StringToByteArray("C60010       45F8");
            for (int i = 0; i < shouldBe.Length; i++)
            {
                Assert.AreEqual(shouldBe[i], byteArray[i]);
            }

            byteArray = ApiFunctionManager.StringToByteArray("C6001045F8      ");
            for (int i = 0; i < shouldBe.Length; i++)
            {
                Assert.AreEqual(shouldBe[i], byteArray[i]);
            }

            byteArray = ApiFunctionManager.StringToByteArray("    C6001045F8");
            for (int i = 0; i < shouldBe.Length; i++)
            {
                Assert.AreEqual(shouldBe[i], byteArray[i]);
            }

            byteArray = ApiFunctionManager.StringToByteArray("C600   1045  F8");
            for (int i = 0; i < shouldBe.Length; i++)
            {
                Assert.AreEqual(shouldBe[i], byteArray[i]);
            }
        }
    }
}