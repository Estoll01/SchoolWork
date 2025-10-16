using System;
using static System.Console;
using System.Globalization;
class Admission
{
	static void Main()
	{
		//QUIT
		const string SENTINEL = "quit";

		while (true)
		{

			// Write your code here
			//varibles
			string rawInputgpa;
			string rawInputTest;
			double gpa;
			double admitTest;
			double admitGPA = 3;
			double admitTestHigh = 80;
			double admitTestLow = 60;

			//input
			WriteLine("Input GPA here: ");
			rawInputgpa = ReadLine();
			bool isGPAvalid = double.TryParse(rawInputgpa, out gpa);

			//SENTINEL
			if(rawInputgpa == SENTINEL)
            {
				break;
            }

			WriteLine("Input test score here: ");
			rawInputTest = ReadLine();
			bool isTestvalid = double.TryParse(rawInputTest, out admitTest);

			//SENTINEL
			if(rawInputTest == SENTINEL)
            {
				break;
            }

			//LOGIC
			if (isGPAvalid && isTestvalid)
			{
				if (gpa >= admitGPA && admitTest >= admitTestLow)
				{
					WriteLine("Accept");
					WriteLine("Type quit to exit: ");
				}

				else if (gpa < admitGPA && admitTest >= admitTestHigh)
				{
					WriteLine("Accept");
					WriteLine("Type quit to exit: ");
				}

				else
				{
					WriteLine("Reject");
					WriteLine("Type quit to exit: ");
				}

			}

			else
			{
				WriteLine("Please enter a valid GPA and test score.");
				WriteLine("Type quit to exit: ");
			}
		}








	}
}