//Paige Fenwick
//CIS 200-10
//Program 5
//1 July 2015
//This extra credit program is Part two of the extra credit and was created with the help of Dr. Wright and the text examples.
//This class explores the use of passes different array types into methods Populate and Traverse tree, which have been 
//formatted as generic methods. 
using System;
using BinaryTreeLibrary2;


public class TreeTest
{
   public static void Main( string[] args )
   {
       //creates the arrays
      int[] intArray = { 8, 2, 4, 3, 1, 7, 5, 6, 10, 9 };
      double[] doubleArray = { 8.8, 2.2, 4.4, 3.3, 1.1, 7.7, 5.5, 6.6, 10.10, 9.9 };
      string[] stringArray = { "eight", "two", "four", 
         "three", "one", "seven", "five", "six", "nine", "ten" };

      // create int Tree
      Tree<int> intTree = new Tree<int>();
      PopulateTree( intArray, intTree, "intTree" );
      TraverseTree( intTree, "intTree" );
      Pause();

      // create double Tree
      Tree<double> doubleTree = new Tree<double>();
      PopulateTree( doubleArray, doubleTree, "doubleTree" );
      TraverseTree( doubleTree, "doubleTree" );
      Pause();

      // create string Tree
      Tree<string> stringTree = new Tree<string>();
      PopulateTree( stringArray, stringTree, "stringTree" );
      TraverseTree( stringTree, "stringTree" );
      Pause();
   }

   //Precondition: none
   //Postcondition: populates the trees into the console
   private static int PopulateTree<T>( Array array, Tree<T> tree, string name )
       where T : IComparable<T>
   {
      Console.WriteLine( "\n\n\nInserting into " + name + ":" );//creates the title

      foreach ( IComparable data in array )//acepts the data and outputs it into the console
      {
         Console.Write( data + " " );
         tree.InsertNode( data );
      } 

      return 0;//returns 0
   } 

   //Precondition: none
   //Postcondition: returns the inorder traversal of the trees
   private static void TraverseTree<T>( Tree<T> tree, string treeType )
       where T : IComparable<T>
   {
      // perform inorder traveral of tree
      Console.WriteLine( "\n\nInorder traversal of " + treeType );
      tree.InorderTraversal();

   }

   // Precondition:  None
   // Postcondition: Pauses program execution until user presses Enter and
   //                then clears the screen
   public static void Pause()
   {
       Console.WriteLine("Press Enter to Continue...");
       Console.ReadLine();
       Console.Clear(); // Clear screen
   }
} 
