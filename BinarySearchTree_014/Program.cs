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
			Node tmp, parent = null, currentNode = null;
			search(element, ref parent, ref currentNode);
			if (currentNode != null)/* Check if the node to be inserted already inserted or not*/
			{
				Console.WriteLine("Duplicate word not allowed");
				return;
			}
			else /* If the specified node is not present*/
			{
				tmp = new Node(element, null, null); /* Creates a Node */
				if (parent == null)/* If the trees is empty*/
				{
					ROOT = tmp;
				}
				else if (string.Compare(element, parent.info) < 0)
				{
					parent.leftchild = tmp;
				}
				else
				{
					parent.rightchild = tmp;
				}
			}
		}

		public void inOrder(Node ptr)
		{
			if (ROOT == null)
			{
				Console.WriteLine("Tree is Empty");
				return;
			}
			if (ptr != null)
			{
				inOrder(ptr.leftchild);
				Console.WriteLine(ptr.info + "");
				inOrder(ptr.rightchild);
			}
		}

		public void preOrder(Node ptr)
		{
			if (ROOT == null)
			{
				Console.WriteLine("Tree is Empty");
				return ;
			}
			if (ptr != null)
			{
				Console.WriteLine(ptr.info + "");
				preOrder(ptr.leftchild);
				preOrder(ptr.rightchild);
			}
		}
	}
}
