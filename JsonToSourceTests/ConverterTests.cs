using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonToSource.Interfaces;
using JsonToSource;
using JsonToSource.Models;
using System.IO;

namespace JsonToSourceTests
{
    [TestClass]
    public class ConverterTests
    {
        private IJsonConverter<Order> _converter;

        private readonly string _dirPath = "C:\\TestOutput\\ConvertedFile";
        private readonly string _fileName = DateTime.Now.ToFileTime() + ".xml";

        public ConverterTests()
        {
            //DI should be used along side an IoC Container. CTOR param (IJsonConverter<Order> converter)
            _converter = new JsonConverter<Order>(_dirPath);
        }

        [TestMethod]
        public void Test_Convert_From_RawJson_To_XML()
        {
            _converter.ConvertJsonToSource(Utilities.RawJson(),
                _fileName);

            Assert.IsTrue(File.Exists(Path.Combine(_dirPath,
                        _fileName)));
        }

        [TestMethod]
        public void Test_Convert_From_ObjectJson_To_XML()
        {
            
            _converter.ConvertObjectToSource(JsonToSource.Mocks.MockOrder.ToMock(),
                _fileName);

            Assert.IsTrue(File.Exists(Path.Combine(_dirPath,
                        _fileName)));
        }
    }
}
