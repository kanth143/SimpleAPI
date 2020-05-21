using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.test
{
    public class UnitTest1
    {
        ValuesController  cntrl =new ValuesController();
        [Fact]
           
    public void Test0()
    {
        var returnvalue = cntrl.Get(1);
        Assert.Equal("Kanth", returnvalue.Value);
        
    }
      
        [Fact]
        public void Test1()
        {

        }
    }
}
