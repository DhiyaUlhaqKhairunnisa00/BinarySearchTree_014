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
			/* This function searchs the currentNode of the specified Node as well
			 * as the current Node of its parents */
			currentNode = ROOT;
			parent = null;
			while((currentNode != null) && (currentNode.info != element))
			{
				parent = currentNode;
				if (string.Compare(element, currentNode.info) < 0)
					currentNode = currentNode.leftchild;
				else
					currentNode = currentNode.rightchild;
			}
		}
		public void insert(string element)/* Insert a node in the binary search tree */
		{

		}
	}
}
