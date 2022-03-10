using BuildingAComputer;
using NUnit.Framework;
using System.Collections.Generic;
using BildingAComputerTest;
using Building_A_Computer;

namespace BildingAComputerTest
{
    public class Tests
    {
        [Test]
        public void BildingAComputer_IntelI5_TestForNullAndIncorrectValue()
        {
            // Arrange
            IntelI5 intelI5 = new IntelI5();
           
            if (intelI5.model is null)
            {
                Assert.Fail();
            }
            if (intelI5.numberOfCores < 1)
            {
                Assert.Fail();
            }
            if (intelI5.clockFrequencyMHz < 1000)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void BildingAComputer_AMD_TestForNullAndIncorrectValue()
        {
            // Arrange
            AMD aMD = new AMD();
            
            // Act&Assert
            
            if (aMD.model is null)
            {
                Assert.Fail();
            }
            if (aMD.numberOfCores < 1)
            {
                Assert.Fail();
            }
            if (aMD.clockFrequencyMHz < 1000)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void BildingAComputer_ASUSPrime_TestForNullAndIncorrectValue()
        {
            // Arrange
            ASUSPrime aSUSPrime = new ASUSPrime();

            // Act&Assert

            if (aSUSPrime.model is null)
            {
                Assert.Fail();
            }
            if (aSUSPrime.memorySlotsCount < 0)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void BildingAComputer_ASROCKA320M_TestForNullAndIncorrectValue()
        {
            // Arrange
            ASROCKA320M aSROCKA320M = new ASROCKA320M();

            // Act&Assert

            if (aSROCKA320M.model is null)
            {
                Assert.Fail();
            }
            if (aSROCKA320M.memorySlotsCount < 0)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void BildingAComputer_Crucial8Gb_TestForNullAndIncorrectValue()
        {
            // Arrange
            Crucial8Gb crucial8Gb = new Crucial8Gb();

            // Act&Assert

            if (crucial8Gb.model is null)
            {
                Assert.Fail();
            }
            if (crucial8Gb.memorySizeGb < 0)
            {
                Assert.Fail();
            }
            if (crucial8Gb.memoryType is null)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void BildingAComputer_PatriotSignature_TestForNullAndIncorrectValue()
        {
            // Arrange
            PatriotSignature patriotSignature = new PatriotSignature();

            // Act&Assert

            if (patriotSignature.model is null)
            {
                Assert.Fail();
            }
            if (patriotSignature.memorySizeGb < 0)
            {
                Assert.Fail();
            }
            if (patriotSignature.memoryType is null)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void BildingAComputer_NVIDIAGeForceGT1030_TestForNullAndIncorrectValue()
        {
            // Arrange
            NVIDIAGeForceGT1030 nVIDIAGeForceGT1030 = new NVIDIAGeForceGT1030();

            // Act&Assert

            if (nVIDIAGeForceGT1030.model is null)
            {
                Assert.Fail();
            }
            if (nVIDIAGeForceGT1030.gpuFrequencyMHz < 1000)
            {
                Assert.Fail();
            }
            if (nVIDIAGeForceGT1030.videoMmemorySizeMB < 1000)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void BildingAComputer_NVIDIAGeForceGTX1660TI_TestForNullAndIncorrectValue()
        {
            // Arrange
            NVIDIAGeForceGTX1660TI nVIDIAGeForceGTX1660TI = new NVIDIAGeForceGTX1660TI();

            // Act&Assert

            if (nVIDIAGeForceGTX1660TI.model is null)
            {
                Assert.Fail();
            }
            if (nVIDIAGeForceGTX1660TI.gpuFrequencyMHz < 1000)
            {
                Assert.Fail();
            }
            if (nVIDIAGeForceGTX1660TI.videoMmemorySizeMB < 1000)
            {
                Assert.Fail();
            }
        }
    }
}