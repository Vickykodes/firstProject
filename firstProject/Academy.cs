using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{

    //non static class
    public class Academy
    {
        //non static method
        public void ClassRoom()
        { 
        }
    }

    //non static class
    public class Edibles
    {
        // static method
        public static void Food()
        {
        }
    }

    // static class or extension class

    public static class Subjects
    {
        // static method or extension method
        public static void MatheMatics()
        {
        }
    }


    //access modifiers
    public class Family //base class
    {
        //non static method
        internal string Couples() //accessible in the assemblies
        {
            Books books = new Books();
            return books.FirstName; //get means returning a value of a property name
        }

        protected void Children() //only accessible in the same class,nested class and inherited class
        {
            Books books = new Books();
            books.FirstName = "Mustapha Aisha"; //set means assigning a value to a property name
            int age = books.Age; //set means assigning a value to a property name
            age = 20;      //reassigning
            Console.WriteLine(books.FirstName);
            Console.WriteLine(age);

        }

        private void GrandChildren() //only accessible in the same class and nested class
        {
            
        }

        public virtual void Marriage() //only accessible in the same class and nested class
        {

        }

    }

    //derived class
    public  class ExtendedFamily : Family
    {
        public void GrandParents()
        {
            Family family = new Family();
            family.Couples();

            ExtendedFamily extendedFamily = new ExtendedFamily();
            extendedFamily.Children();

        }

        public override void Marriage()
        {
        }
    }


    public class Books 
    {
        //properties
        public int Age 
        {
            get;
            set;
        }
        internal string FirstName { get; set; }
    }


    //Abstract

    public abstract class Foods
    {
        //members
        public string? Rice {get; set;} //property
        internal string? beans; //field

        public abstract string? Garri(); //method
       
    }

    public class FoodClasses : Foods,IFoods
    {
        public void Fufu()
        {
            //enum
           Grade studentGrade = Grade.Third;
            return;
        }

        public override string? Garri()
        {
            throw new NotImplementedException();
        }
    }

    public interface IFoods
    {
        //members
        public string? Rice { get; set; } //property
        public abstract void Fufu(); //method

    }

    public enum Grade
    {
        First,
        Second, 
        Third   
    }

}

public class Fruit
{//non static method
    private string Apple()
    {
        return "";
    }
}