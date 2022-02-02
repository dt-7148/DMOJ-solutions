using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		//stores amount of unique emails per dataset
		List<int> amtUnique = new List<int>();
		
		//outer for loop, runs 10 times
		for (int i = 0; i <= 9; i++){
			//use list.distinct
			
			//will store all emails per dataset
			List<string> emails = new List<string>();
			
			//amount of emails in dataset
			int datasetCount = Int32.Parse(Console.ReadLine());
			
			for(int iii = 0; iii <= datasetCount - 1; iii++){
				//getting all emails in dataset
				emails.Add(Console.ReadLine());
			}
			
			
			for (int ii = 0; ii <= emails.Count - 1; ii++){
				emails[ii] = emails[ii].ToString().ToLower();
				
				//
				string userName;
				
				if (emails[ii].Contains("+")){
					userName = emails[ii].Substring(0, emails[ii].IndexOf("+"));
				} else {
					userName = emails[ii].Substring(0, emails[ii].IndexOf("@"));	
				}
				userName = userName.Replace(".", "");
				
				string address = emails[ii].Substring(emails[ii].IndexOf("@"));
				string finalAddress = userName + address;
				
				emails[ii] = finalAddress;
			}
			emails = emails.Distinct().ToList();
			amtUnique.Add(emails.Count());
			emails.Clear();
		}
		foreach(int numUnique in amtUnique){
			Console.WriteLine(numUnique);	
		}
	}
}
