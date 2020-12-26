using System;
/// <summary>
/// The program demonstrates the use of XML comments
/// 
/// Employee class users constructor to inizialze ID and 
/// name of the employee and displays them
/// </summary>
/// <remarks>
/// This program users both parmenterized and
/// non-paramenterized constructors.
/// </remarks>

namespace Lab1
{
    class VD4
    {
        /// <summary>
        /// Interger field to Store employee ID.
        /// </summary>
        private int _id;
        /// <summary>
        /// String field to Store emplpoyee name.
        /// </summary>
        private string _name;
        /// <summary>
        /// This constructor initializes the id and name to -1 and null
        /// </summary>
        /// <remarks>
        /// <seealsocref = "Employee(int , string ) " > Employee(int, string)</seealsocref>
        /// </remarks>
        public VD4()
        {
            _id = -1;
            _name = null;
        }

        public VD4(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        static void Main4(string[] args)
        {
            VD4 objVD4 = new VD4(101, "DavidSmith");
            Console.WriteLine("EmployeeID : {0} \nEmployyeName : {1} ", objVD4._id, objVD4._name);
        }
    }
}

