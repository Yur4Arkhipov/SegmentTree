public class Segment {
    public int Start { get; set; }
    public int End { get; set; }

    public Segment(int start, int end) {
        Start = start;
        End = end;
    }
}

public abstract class AssociativeOperation {
    public abstract int Apply(int a, int b);
    public abstract int GetNeutralElement();
}

public class SumOperation : AssociativeOperation {
    public override int Apply(int a, int b) {
        return a + b;
    }
    public override int GetNeutralElement() {
        return 0;
    }
}

public class MinOperation : AssociativeOperation {
    public override int Apply(int a, int b) {
        return Math.Min(a, b);
    }
    public override int GetNeutralElement() {
        return int.MaxValue;
    }
}

public class MaxOperation : AssociativeOperation {
    public override int Apply(int a, int b) {
        return Math.Max(a, b);
    }
    public override int GetNeutralElement() {
        return int.MinValue;
    }
}

public class MultiplyOperation : AssociativeOperation {
    public override int Apply(int a, int b) {
        return a * b;
    }
    public override int GetNeutralElement() {
        return 1;
    }
}

public class GcdOperation : AssociativeOperation {
    public override int Apply(int a, int b) {
        if (b == 0) {
            return a;
        } else {
            return Apply(b, a % b);
        }
    }
    public override int GetNeutralElement() {
        return 0;
    }
}

public class SegmentTree {
    private int[] tree;
    private int n;
    private AssociativeOperation operation;

    public SegmentTree(int[] data, AssociativeOperation operation) {
        this.operation = operation;
        n = data.Length;
        tree = new int[2 * n];
        Build(data);
    }

    private void Build(int[] data) {
        for (int i = 0; i < n; i++) {
            tree[n + i] = data[i];
        }

        for (int i = n - 1; i > 0; i--) {
            tree[i] = operation.Apply(tree[i * 2], tree[i * 2 + 1]);
        }
    }

    public void Update(int index, int value) {
        index += n;
        tree[index] = value;

        while (index > 1) {
            index /= 2;
            tree[index] = operation.Apply(tree[index * 2], tree[index * 2 + 1]);
        }
    }

    public int Query(int left, int right) {
        left += n;
        right += n;
        int result = operation.GetNeutralElement();

        while (left < right) {
            if ((left & 1) == 1) {
                result = operation.Apply(result, tree[left]);
                left++;
            }
            if ((right & 1) == 1) {
                right--;
                result = operation.Apply(result, tree[right]);
            }
            left /= 2;
            right /= 2;
        }
        return result;
    }

    /* public void Update(Segment segment, int value) {
        Update(segment.Start, value);
    } */

    public int Query(Segment segment) {
        return Query(segment.Start, segment.End);
    }

    public void PrintTree() {
        for (int i = 1; i < 2 * n; i++) {
            Console.Write(tree[i] + " ");
        }
        Console.WriteLine();
    }
}
