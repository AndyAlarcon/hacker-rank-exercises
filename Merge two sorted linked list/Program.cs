TextWriter textWriter = new StreamWriter(System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

int tests = Convert.ToInt32(Console.ReadLine());

if (tests >= 1 && tests <= 10)
{
    for (int testsItr = 0; testsItr < tests; testsItr++)
    {
        SinglyLinkedList llist1 = new SinglyLinkedList();

        int llist1Count = Convert.ToInt32(Console.ReadLine());

        if (llist1Count >= 1 && llist1Count <= 1000)
        {
            for (int i = 0; i < llist1Count; i++)
            {
                int llist1Item = Convert.ToInt32(Console.ReadLine());
                if (llist1Item >= 1 && llist1Item <= 1000)
                {
                    llist1.InsertNode(llist1Item);
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            SinglyLinkedList llist2 = new SinglyLinkedList();

            int llist2Count = Convert.ToInt32(Console.ReadLine());

            if (llist2Count >= 1 && llist2Count <= 1000)
            {
                for (int i = 0; i < llist2Count; i++)
                {
                    int llist2Item = Convert.ToInt32(Console.ReadLine());
                    if (llist2Item >= 1 && llist2Item <= 1000)
                    {
                        llist2.InsertNode(llist2Item);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }

                SinglyLinkedListNode llist3 = mergeLists(llist1.head, llist2.head);

                PrintSinglyLinkedList(llist3, " ", textWriter);
                textWriter.WriteLine();
            }
        }
    }
}

textWriter.Flush();
textWriter.Close();

static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
{
    SinglyLinkedList List3 = new SinglyLinkedList();

    List<SinglyLinkedListNode> Nodos = [head1];

    while (head1.next != null)
    {
        Nodos.Add(head1.next);
        head1 = head1.next;
    }

    Nodos.Add(head2);

    while (head2.next != null)
    {
        Nodos.Add(head2.next);
        head2 = head2.next;
    }
    Nodos.Sort((p1, p2) => p1.data.CompareTo(p2.data));

    for (int i = 0; i < Nodos.Count; i++)
    {
        List3.InsertNode(Nodos[i].data);
    }

    return List3.head;
}

static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
{
    while (node != null)
    {
        textWriter.Write(node.data);

        node = node.next;

        if (node != null)
        {
            textWriter.Write(sep);
        }
    }
}

class SinglyLinkedListNode
{
    public int data;
    public SinglyLinkedListNode next;
    public SinglyLinkedListNode(int nodeData)
    {
        this.data = nodeData;
        this.next = null;
    }
}

class SinglyLinkedList
{
    public SinglyLinkedListNode head;
    public SinglyLinkedListNode tail;

    public SinglyLinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void InsertNode(int nodeData)
    {
        SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

        if (this.head == null)
        {
            this.head = node;
        }
        else
        {
            this.tail.next = node;
        }

        this.tail = node;
    }
}



