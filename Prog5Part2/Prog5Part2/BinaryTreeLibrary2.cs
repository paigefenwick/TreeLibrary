//Paige Fenwick
//CIS 200-10
//Program 5
// 1 July 2015
//This extra credit program is Part two of the extra credit and was created with the help of Dr. Wright and the text examples.
//This class determines the creation of trees and tree nodes as generic classes to accept any type.
using System;

namespace BinaryTreeLibrary2
{
   // class TreeNode declaration
   class TreeNode<T>
       where T : IComparable<T>
   {
      // automatic property LeftNode
      public TreeNode<T> LeftNode { get; set; }

      // automatic property Data
      public IComparable Data { get; set; }

      // automatic property RightNode
      public TreeNode<T> RightNode { get; set; }

      // constructor that initialize Data and make this a leaf node
      public TreeNode( IComparable nodeData )
      {
         Data = nodeData;
         LeftNode = RightNode = null; // node has no children
      } 

      //Precondition: value cannot be null
      //Postcondition: compares the values and inserts them into the tree
      public void Insert( IComparable insertValue )
      {
         if ( insertValue.CompareTo(Data) < 0 ) // insert in left subtree
         {
            // insert new TreeNode
            if ( LeftNode == null )
               LeftNode = new TreeNode<T>( insertValue );
            else // continue traversing left subtree
               LeftNode.Insert( insertValue );
         } 
         else if ( insertValue.CompareTo( Data ) > 0 ) // insert in right
         {
            // insert new TreeNode
            if ( RightNode == null )
               RightNode = new TreeNode<T>( insertValue );
            else // continue traversing right subtree
               RightNode.Insert( insertValue );
         } 
      } 
   } 

   // class Tree declaration
   public class Tree<T>
       where T : IComparable<T>
   {
      private TreeNode<T> root;

      // construct an empty Tree of IComparable
      public Tree()
      {
         root = null;
      } // end constructor

      //Precondition: none
      //Postcondition: If the root node is null, create the root node here.
      //Otherwise, call the insert method of class TreeNode.
      public void InsertNode( IComparable insertValue )
      {
         if ( root == null )
            root = new TreeNode<T>( insertValue );
         else
            root.Insert( insertValue );
      } 

      //Precondition: none
      //Postcondition: begin inorder traversal
      public void InorderTraversal()
      {
         InorderHelper( root );
      } 

      //Precondition: none
      //Postcondition: recursive method to perform inorder traversal
      private void InorderHelper( TreeNode<T> node )
      {
         if ( node != null )
         {
            // traverse left subtree
            InorderHelper( node.LeftNode );

            // output node data
            Console.Write( node.Data + " " );

            // traverse right subtree
            InorderHelper( node.RightNode );
         } 
      } 

   } 
} 
