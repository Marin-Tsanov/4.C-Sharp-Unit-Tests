using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1.Unit_Demo_Bank;
using MSTestExtensions;
using NUnit.Framework;

[TestFixture]
public class TestAccount
{
    [Test]
    //[TestMethod]
    public void TestDeposit()
    {
        Account acc = new Account();
        acc.Deposit(200.00F);
        float balance = acc.Balance;
        Assert.AreEqual(balance, 200F);

    }
    [Test]
    //[TestMethod]
    //[ExpectedException(typeof(ArgumentException))]
    public void TestDepositZero()
    {
        Account acc = new Account();
        //acc.Deposit(0);

        //ThrowsAssert.Throws<ArgumentException>(() => acc.Deposit(0));

        ThrowsAssert.Throws < ArgumentException>(() => acc.Deposit(0));
    }

    [Test]
    //[TestMethod]
    public void TestDepositNegative()
    {
        Account acc = new Account();
        acc.Deposit(-150.30F);
        float balance = acc.Balance;
        Assert.AreEqual(balance, -150.30F);
    }

    [Test]
    //[TestMethod]
    public void TestWithdraw()
    {
        Account acc = new Account();
        acc.Withdraw(138.56F);
        float balance = acc.Balance;
        Assert.AreEqual(balance, -138.56F);
    }

    [Test]
    //[TestMethod]
    //[ExpectedException(typeof(ArgumentException))]
    public void TestWithdrawZero()
    {
        Account acc = new Account();
        //acc.Withdraw(0);
        Assert.Throws<ArgumentException>(() => acc.Withdraw(0));
    }

    [Test]
    //[TestMethod]
    public void TestWithdrawNegative()
    {
        Account acc = new Account();
        acc.Withdraw(-3.14F);
        float balance = acc.Balance;
        Assert.AreEqual(balance, -3.14F);
    }

    [Test]
    //[TestMethod]
    public void TestTransferFunds()
    {
        Account source = new Account();
        source.Deposit(200.00F);
        Account dest = new Account();
        dest.Deposit(150.00F);
        source.TransferFunds(dest, 100.00F);
        Assert.AreEqual(250.00F, dest.Balance);
        Assert.AreEqual(100.00F, source.Balance);
    }

    [Test]
    //[TestMethod]
    //[ExpectedException(typeof(NullReferenceException))]
    public void TestTransferFundsFromNullAccount()
    {
        Account source = null;
        Account dest = new Account();
        dest.Deposit(200.00F);
        //source.TransferFunds(dest, 100.00F);
        Assert.Throws<NullReferenceException>(() => source.TransferFunds(dest, 100.00F));
    }

    [Test]
    //[TestMethod]
    //[ExpectedException(typeof(NullReferenceException))]
    public void TestTransferFundsToNullAccount()
    {
        Account source = new Account();
        source.Deposit(200.00F);
        Account dest = null;
        //source.TransferFunds(dest, 100.00F);
        Assert.Throws<NullReferenceException>(() => source.TransferFunds(dest, 100.00F));

    }

    [Test]
    //[TestMethod]
    //[ExpectedException(typeof(ArgumentException))]
    public void TestTransferFundsSameAccount()
    {
        Account source = new Account();
        source.Deposit(200.00F);
        Account dest = source;
        //source.TransferFunds(dest, 100.00F);
        Assert.Throws<ArgumentException>(() => source.TransferFunds(dest, 100.00F));
    }

    [Test]
    //[TestMethod]
    public void TestDepositWithdrawTransferFunds()
    {
        Account source = new Account();
        source.Deposit(200.00F);
        source.Withdraw(100.00F);

        Account dest = new Account();
        dest.Deposit(150.00F);
        dest.Withdraw(50.00F);

        source.TransferFunds(dest, 100.00F);
        Assert.AreEqual(0.00F, source.Balance);
        Assert.AreEqual(200.00F, dest.Balance);
    }

    [TestCase(1,1,2)]
    [TestCase(0,-1,-1)]
    public void TestSumming(int a , int b, int result)
    {
        var bank = new Bank();
        // bank.Sum(a, b);
        Assert.AreEqual(result, bank.Sum(a, b));
    }
    
}