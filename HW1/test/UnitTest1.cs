namespace test;

public class UnitTest1
{
    [Fact]
    public void Nam()
    {
     double[] testnumber = HW3.shop(8574.50);
         double[] myNum = { 8, 1, 0, 1, 0, 0 , 0, 2, 0, 1, 0 };
         Assert.Equal(testnumber,myNum);
    }
   
}