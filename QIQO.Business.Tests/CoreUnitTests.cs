﻿using QIQO.Business.Core;
using System;
using Xunit;

namespace QIQO.Business.Tests
{
    public class CoreUnitTests
    {
        [Fact]
        public void AuthorizationValidationExceptionTests()
        {
            AuthorizationValidationException ex1 = new AuthorizationValidationException();
            Assert.NotNull(ex1);

            AuthorizationValidationException ex2 = new AuthorizationValidationException("Run for you life!");
            Assert.NotNull(ex2);

            AuthorizationValidationException ex3 = new AuthorizationValidationException("Run for you life!", new Exception());
            Assert.NotNull(ex3);

            //var fc = new Mock<IFormatterConverter>();
            ////var info = new Mock<SerializationInfo>();
            //var info = new SerializationInfo(typeof(AuthorizationValidationException), fc.Object);
            //var sc = new StreamingContext();
            //var ex4 = new AuthorizationValidationException(null, sc);
            //Assert.NotNull(ex4);
        }
        [Fact]
        public void NotFoundExceptionTests()
        {
            NotFoundException ex1 = new NotFoundException();
            Assert.NotNull(ex1);

            NotFoundException ex2 = new NotFoundException("Run for you life!");
            Assert.NotNull(ex2);

            NotFoundException ex3 = new NotFoundException("Run for you life!", new Exception());
            Assert.NotNull(ex3);

            //var fc = new Mock<IFormatterConverter>();
            //var info = new SerializationInfo(typeof(NotFoundException), fc.Object);
            //var sc = new StreamingContext();
            //var ex4 = new NotFoundException(info, sc);
            //Assert.NotNull(ex4);
        }
    }
}
