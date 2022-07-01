using DarmankadehTest.Controllers;
using DarmankadehTest.Model;
using DarmankadehTest.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DarmankadehXUnitTestProject
{
    public class UserControllerTest 
    {
        private readonly UserController _controller;
        private readonly IUserRepository _service;

        public UserControllerTest()
        {
            _service = new UserRepositoryTest();
            _controller = new UserController(_service);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {           
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllUsers()
        {
            // Act
            var okResult = _controller.Get() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<User>>(okResult.Value);
            Assert.Equal(1, items.Count);
        }

        [Fact]
        public void GetById_UnknownIdPassed_ReturnsNotFoundResult()
        {           
            // Act
            var notFoundResult = _controller.Get(0);

            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult);
        }

        [Fact]
        public void GetById_ExistingIdPassed_ReturnsOkResult()
        {           
            // Act
            var okResult = _controller.Get(2);

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public void GetById_ExistingIdPassed_ReturnsRightUser()
        {           
            // Act
            var okResult = _controller.Get(2) as OkObjectResult;

            // Assert
            Assert.IsType<User>(okResult.Value);
            Assert.Equal(2, (okResult.Value as User).Id);
        }
    }
}
