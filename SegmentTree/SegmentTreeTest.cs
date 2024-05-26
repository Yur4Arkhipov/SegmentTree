/* using NUnit.Framework;

[TestFixture]
public class SegmentTreeTests {
    private int[] data;
    private SegmentTree sumTree;
    private SegmentTree minTree;
    private SegmentTree maxTree;
    private SegmentTree multiplyTree;
    private SegmentTree gcdTree;

    [SetUp]
    public void SetUp() {
        data = new int[] {1, 2, 3, 4, 5};
        sumTree = new SegmentTree(data, new SumOperation());
        minTree = new SegmentTree(data, new MinOperation());
        maxTree = new SegmentTree(data, new MaxOperation());
        multiplyTree = new SegmentTree(data, new MultiplyOperation());
        gcdTree = new SegmentTree(data, new GcdOperation());
    }

    [Test]
    public void TestSumQuery() {
        Segment segment = new Segment(1, 3);
        Assert.AreEqual(9, sumTree.Query(segment));
    }

    [Test]
    public void TestMinQuery() {
        Segment segment = new Segment(1, 3);
        Assert.AreEqual(2, minTree.Query(segment));
    }

    [Test]
    public void TestMaxQuery() {
        Segment segment = new Segment(1, 3);
        Assert.AreEqual(4, maxTree.Query(segment));
    }

    [Test]
    public void TestMultiplyQuery() {
        Segment segment = new Segment(1, 3);
        Assert.AreEqual(24, multiplyTree.Query(segment));
    }

    [Test]
    public void TestGcdQuery() {
        Segment segment = new Segment(1, 3);
        Assert.AreEqual(1, gcdTree.Query(segment));
    }

    [Test]
    public void TestUpdate() {
        Segment segment = new Segment(1, 3);
        sumTree.Update(segment, 10);
        Assert.AreEqual(30, sumTree.Query(segment));
    }
} */