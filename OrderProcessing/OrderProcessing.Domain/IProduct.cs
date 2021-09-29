using System;

namespace OrderProcessing.Domain
{
    public interface IProduct
    { }

    public class PhysicalProduct : IProduct
    { }

    public class Book : IProduct
    {}

    public class Membership : IProduct
    {}

    public class UpgradeMemberShip : IProduct
    { }

    public class VideoLearning : IProduct
    { }
}
