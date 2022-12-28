using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeNode_014
{
	class Node 
	{
		public string info;
		public Node leftchild;
		public Node rightchild;

		//Constructure for the Node Class
		public Node(string i, Node l , Node r)
		{
			info = i;
			leftchild = l;
			rightchild = r;
		}
	}
	/* A Node class consist of the three things, the information,
	 * references to the right child, and refrences to the left child */

	class Program
	{
		public Node ROOT;
		public Program()
		{
			ROOT = null; /* Initializing ROOT to null */
		}
		public void search(string element, ref Node parent, ref Node currentNode)
		{

		}
	}
}
