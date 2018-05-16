using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MerchantAquiringSystemWithWF;
using System.Linq;

using System.Configuration;
using System.Collections.Generic;

namespace MAS_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           DA.UnitOfWork unit = new DA.UnitOfWork();
            var request = new DA.Models.Request {

                CreatedBy = "user1"
                , CreatedDate = DateTime.Now
                ,RequestDescription="Test Request7",
                Status=1
                //RequiredApprovals.
                

            };

            unit.RequestRepository.Add(request);
            unit.Complete();


            var createdRequest = unit.RequestRepository.Find(x => x.CreatedBy.Equals("user1")).FirstOrDefault();

            Assert.AreNotEqual(createdRequest, null);
                unit.Dispose();


        }
        [TestMethod]
        public void TestRquestAndPOS()
        {
            DA.UnitOfWork unit = new DA.UnitOfWork();
            List<DA.Models.POSRequest> posList = new List<DA.Models.POSRequest> {
                new DA.Models.POSRequest {RequestDescription="Pos Request1",Status=1},
                new DA.Models.POSRequest {RequestDescription="Pos Request2",Status=1},
                new DA.Models.POSRequest {RequestDescription="Pos Request3",Status=1}

            };
            var request = new DA.Models.Request
            {

                CreatedBy = "user55"
                ,
                CreatedDate = DateTime.Now
                ,
                RequestDescription = "Test Request7",
                Status = 1,
                POSRequest= posList


            };

            unit.RequestRepository.Add(request);
            unit.Complete();


            var createdRequest = unit.RequestRepository.Find(x => x.CreatedBy.Equals("user55")).FirstOrDefault();

            Assert.AreNotEqual(createdRequest, null);
            unit.Dispose();


        }

        [TestMethod]
        public void GetRequestStatusTest()
        {
          //  ConfigurationManager
            var s = RequestState.DRAFT.Value;

            Assert.AreNotEqual(s, null);
            
        }
        }
}
