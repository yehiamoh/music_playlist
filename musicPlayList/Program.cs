using System.Xml.Linq;

namespace musicPlayList
{
    public class Node
    {
        public string title;
        public string author;
        public string description;
         public Node next;
        public Node Prev; 
        public Node() { }
        public Node(string title, string author, string description)
        {
            this.title = title;
            this.author = author;
            this.description = description;
        } 

    }
    public class dLinkedList
    {
        public Node head;
        public int getLenght()
        {
            Node p = head;
            int counter = 0;
            while (p != null)
            {
                p = p.next;
                counter++;
            }
            return counter;
        }

        public void addSongToplayList(string title, string author, string description)
        {
            Node newNode = new Node(title, author, description);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node p = head;
                while (p.next != null)
                {
                    p = p.next;
                }

                p.next = newNode;
                newNode.Prev = p; 
            }
        }

        public Node next()
        {
            if (head != null && head.next != null)
            {
                Node nextNode = head.next;
                return nextNode;
            }
            else
            {
                Console.WriteLine("No next node available.");
                return null;
            }
        }
        public Node Prev()
        {
            if (head != null && head.Prev != null)
            {
                Node prevNode = head.Prev;
                return prevNode;
            }
            else
            {
                Console.WriteLine("No previous node available.");
                return null;
            }
        }

        public void display()
        {
            
                Node p = head;
                while (p != null)
                {
                Console.WriteLine($" author : {head.author} \n title : {head.title} \n description : {head.description}"); p = p.next;
                }
                Console.WriteLine();
            
        }

        public void singleDisplay(Node node)
        {
            if (node != null)
            {
                Console.WriteLine($" author : {node.author} \n title : {node.title} \n description : {node.description}");
            }
            else
            {
                Console.WriteLine("Node is null.");
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            dLinkedList ourPlayList= new dLinkedList();
            ourPlayList.addSongToplayList("hi", "yehiamohamed", "funnny song");
            //ourPlayList.display();
            //ourPlayList.addSongToplayList("bye", "yossef", "sad song");
            //ourPlayList.addSongToplayList("wait", "yassen", "romance song");
            Console.WriteLine("do you want to add a new song ? y/n");
            string check=Console.ReadLine();
            while(check =="y") 
            {
                Console.WriteLine("Enter the title of the song : ");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the author of the song : ");
                string author = Console.ReadLine();
                Console.WriteLine("Enter the description of the song : ");
                string description = Console.ReadLine();
                ourPlayList.addSongToplayList(title, author, description);
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("do you want to add a new song ? y/n");
                check = Console.ReadLine();

            }

            Console.WriteLine("for the next song type => next ");
            string checker;
            string endProgram;
            Node currentSong = ourPlayList.head;
            Console.WriteLine("Here you are your first song at your play list ");
            Console.WriteLine($" author : {currentSong.author} \n title : {currentSong.title} \n description : {currentSong.description}");
            Console.WriteLine("----------------------------------------------------------------------------------");
            for (int i=0;i<=20;i++)
            {
                Console.WriteLine("for the next song type => next ");
                Console.WriteLine("for the prev song type => prev ");
                checker = Console.ReadLine();
                if (checker == "next")
                {
                    currentSong = currentSong.next;
                    ourPlayList.singleDisplay(currentSong);
                   

                }
                else if (checker == "prev")
                {
                    currentSong = currentSong.Prev;
                    ourPlayList.singleDisplay(currentSong);

                }

                if (i == 10)
                {

                    Console.WriteLine("do you want to exit the programm : => exit");
                    endProgram = Console.ReadLine();
                    if (endProgram == "exit") 
                    break;
                }


            }




        }
    }
}
