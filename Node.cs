namespace JogoGourmet
{
    public class Node
    {
        public Node(string data)
        {
            data_ = data;
        }

        public string Data
        {
            get { return data_; }
        }

        public Node? Left
        {
            get { return left_; }
            set { left_ = value; }
        }

        public Node? Right
        {
            get { return right_; }
            set { right_ = value; }
        }

        public bool IsLeaf()
        {
            return left_ is null && right_ is null;
        }

        private readonly string data_;
        private Node? left_;
        private Node? right_;
    }
}
