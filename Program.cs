using System;
using System.Collections.Generic;
using System.Linq;
namespace Avila
{
    class Program
    {	
		static string PCNumber, user, pass, PCN, Check, YN;
		static string[] PCArray = new string[10];
		static string[] PCPasswords = new string[10];
		static List<string> PC1 = new List<string>();
		static List<string> PC2 = new List<string>();
		static List<string> PC3 = new List<string>();
		static List<string> PC4 = new List<string>();
		static List<string> PC5 = new List<string>();
		static List<string> PC6 = new List<string>();
		static List<string> PC7 = new List<string>();
		static List<string> PC8 = new List<string>();
		static List<string> PC9 = new List<string>();
		static List<string> PC10 = new List<string>();
		
		
		//User Login
		
		//No User
		static bool YesNo(string YN)
		{
			YN = Console.ReadLine();
			Console.WriteLine("");
			
			if(YN == "Y")
			{
				return(true);
			}
			else
			{
				return(false);
			}
		}
		
		//Registration of Passwords
		static string RegistrationPassword(string pass)
		{
			Console.WriteLine("Enter Password");
			Console.Write(">>");
			pass = Console.ReadLine();
			
			
			return pass;
		}
		
		//Registration of Username
		static string RegistrationUser(string user)
		{
			Console.WriteLine("Enter new Username");
			Console.Write(">>");
			user = Console.ReadLine();
			
			return user;
		}
		
		//Checking
		static void Checking(string Check)
		{
			string NewPass, NewUser;
			
			if(Check == "PC1")
			{
				if (PCArray[0] == null)
				{
					Console.WriteLine("PC has no user");
					Console.WriteLine("Do you wish to Register this PC [Y/N]");
					if(YesNo(YN) == true)
					{
						NewUser = RegistrationUser(user);
						NewPass = RegistrationPassword(pass);
						PCArray[0] = NewUser;
						PCPasswords[0] = NewPass;
						
						Console.WriteLine("");
						Check = PCSelection(PCNumber);
						Checking(Check);
						
						
					}
					else
					{
						Check = PCSelection(PCNumber);
						Checking(Check);
					}
					
				}
				else 
				{
					//UserLogin();
					LOG:
					Console.WriteLine("Enter PC1 Username");
					NewUser = Console.ReadLine();
					Console.WriteLine("Enter PC1 Password");
					NewPass = Console.ReadLine();
					Console.WriteLine("");
					
					if(PCArray[0] == NewUser && PCPasswords[0] == NewPass)
					{
						string choice, FileEdit;
						int insert;
						
						Console.WriteLine("This PC Contains: ");
						foreach (var files in PC1)
						{
							Console.WriteLine(files);
						}
						repeat:
						Console.WriteLine("");
						Console.WriteLine("What do you wish to do?");
						Console.WriteLine("Add");
						Console.WriteLine("Remove");
						Console.WriteLine("Insert");
						Console.Write(">> ");
						choice = Console.ReadLine();
						
						if (choice == "Add")
						{
							Console.WriteLine("Enter addition to files");
							FileEdit = Console.ReadLine();
							PC1.Add(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Added");
							Console.WriteLine("");
							foreach (var files in PC1)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Remove")
						{
							Console.WriteLine("Enter file you wish to remove");
							FileEdit = Console.ReadLine();
							PC1.Remove(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Removed");
							Console.WriteLine("");
							foreach (var files in PC1)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Insert")
						{
							Console.WriteLine("Enter file you wish to insert");
							FileEdit = Console.ReadLine();
							Console.WriteLine("Where do you wish to insert");
							insert = Convert.ToInt32(Console.ReadLine());
							PC1.Insert(insert,FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully inserted");
							Console.WriteLine("");
							foreach (var files in PC1)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else
						{
							Console.WriteLine("Invalid input");
							Console.WriteLine("");
							
							Console.WriteLine("Do you wish to continue [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
							
						}
						
					}
					else
					{
						Console.WriteLine("Incorrect username or password");
						Console.WriteLine("Do you wish to continue logging-in [Y/N]");
						if(YesNo(YN) == true)
						{
							goto LOG;
						}
						else
						{
							Check = PCSelection(PCNumber);
							Checking(Check);
						}
					}
					
				}
			}
			else if(Check == "PC2")
			{
				if (PCArray[1] == null)
				{
					Console.WriteLine("PC has no user");
					Console.WriteLine("Do you wish to Register this PC [Y/N]");
					if(YesNo(YN) == true)
					{
						NewUser = RegistrationUser(user);
						NewPass = RegistrationPassword(pass);
						PCArray[1] = NewUser;
						PCPasswords[1] = NewPass;
						
						Console.WriteLine("");
						Check = PCSelection(PCNumber);
						Checking(Check);
						
						
					}
					else
					{
						Check = PCSelection(PCNumber);
						Checking(Check);
					}
					
				}
				else 
				{
					//UserLogin();
					LOG:
					Console.WriteLine("Enter PC2 Username");
					NewUser = Console.ReadLine();
					Console.WriteLine("Enter PC2 Password");
					NewPass = Console.ReadLine();
					Console.WriteLine("");
					
					if(PCArray[1] == NewUser && PCPasswords[1] == NewPass)
					{
						string choice, FileEdit;
						int insert;
						
						Console.WriteLine("This PC Contains: ");
						foreach (var files in PC2)
						{
							Console.WriteLine(files);
						}
						repeat:
						Console.WriteLine("");
						Console.WriteLine("What do you wish to do?");
						Console.WriteLine("Add");
						Console.WriteLine("Remove");
						Console.WriteLine("Insert");
						Console.Write(">> ");
						choice = Console.ReadLine();
						
						if (choice == "Add")
						{
							Console.WriteLine("Enter addition to files");
							FileEdit = Console.ReadLine();
							PC2.Add(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Added");
							Console.WriteLine("");
							foreach (var files in PC2)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Remove")
						{
							Console.WriteLine("Enter file you wish to remove");
							FileEdit = Console.ReadLine();
							PC2.Remove(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Removed");
							Console.WriteLine("");
							foreach (var files in PC2)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Insert")
						{
							Console.WriteLine("Enter file you wish to insert");
							FileEdit = Console.ReadLine();
							Console.WriteLine("Where do you wish to insert");
							insert = Convert.ToInt32(Console.ReadLine());
							PC2.Insert(insert,FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully inserted");
							Console.WriteLine("");
							foreach (var files in PC2)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else
						{
							Console.WriteLine("Invalid input");
							Console.WriteLine("");
							
							Console.WriteLine("Do you wish to continue [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						
					}
					else
					{
						Console.WriteLine("Incorrect username or password");
						Console.WriteLine("Do you wish to continue logging-in [Y/N]");
						if(YesNo(YN) == true)
						{
							goto LOG;
						}
						else
						{
							Check = PCSelection(PCNumber);
							Checking(Check);
						}
					}
					
				}
			}
			else if(Check == "PC3")
			{
				if (PCArray[2] == null)
				{
					Console.WriteLine("PC has no user");
					Console.WriteLine("Do you wish to Register this PC [Y/N]");
					if(YesNo(YN) == true)
					{
						NewUser = RegistrationUser(user);
						NewPass = RegistrationPassword(pass);
						PCArray[2] = NewUser;
						PCPasswords[2] = NewPass;
						
						Console.WriteLine("");
						Check = PCSelection(PCNumber);
						Checking(Check);
						
						
					}
					else
					{
						Check = PCSelection(PCNumber);
						Checking(Check);
					}
					
				}
				else 
				{
					//UserLogin();
					LOG:
					Console.WriteLine("Enter PC3 Username");
					NewUser = Console.ReadLine();
					Console.WriteLine("Enter PC3 Password");
					NewPass = Console.ReadLine();
					Console.WriteLine("");
					
					if(PCArray[2] == NewUser && PCPasswords[2] == NewPass)
					{
						string choice, FileEdit;
						int insert;
						
						Console.WriteLine("This PC Contains: ");
						foreach (var files in PC3)
						{
							Console.WriteLine(files);
						}
						repeat:
						Console.WriteLine("");
						Console.WriteLine("What do you wish to do?");
						Console.WriteLine("Add");
						Console.WriteLine("Remove");
						Console.WriteLine("Insert");
						Console.Write(">> ");
						choice = Console.ReadLine();
						
						if (choice == "Add")
						{
							Console.WriteLine("Enter addition to files");
							FileEdit = Console.ReadLine();
							PC3.Add(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Added");
							Console.WriteLine("");
							foreach (var files in PC3)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Remove")
						{
							Console.WriteLine("Enter file you wish to remove");
							FileEdit = Console.ReadLine();
							PC3.Remove(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Removed");
							Console.WriteLine("");
							foreach (var files in PC3)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Insert")
						{
							Console.WriteLine("Enter file you wish to insert");
							FileEdit = Console.ReadLine();
							Console.WriteLine("Where do you wish to insert");
							insert = Convert.ToInt32(Console.ReadLine());
							PC3.Insert(insert,FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully inserted");
							Console.WriteLine("");
							foreach (var files in PC3)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else
						{
							Console.WriteLine("Invalid input");
							Console.WriteLine("");
							
							Console.WriteLine("Do you wish to continue [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						
					}
					else
					{
						Console.WriteLine("Incorrect username or password");
						Console.WriteLine("Do you wish to continue logging-in [Y/N]");
						if(YesNo(YN) == true)
						{
							goto LOG;
						}
						else
						{
							Check = PCSelection(PCNumber);
							Checking(Check);
						}
					}
					
				}
			}
			else if(Check == "PC4")
			{
				if (PCArray[3] == null)
				{
					Console.WriteLine("PC has no user");
					Console.WriteLine("Do you wish to Register this PC [Y/N]");
					if(YesNo(YN) == true)
					{
						NewUser = RegistrationUser(user);
						NewPass = RegistrationPassword(pass);
						PCArray[3] = NewUser;
						PCPasswords[3] = NewPass;
						
						Console.WriteLine("");
						Check = PCSelection(PCNumber);
						Checking(Check);
						
						
					}
					else
					{
						Check = PCSelection(PCNumber);
						Checking(Check);
					}
					
				}
				else 
				{
					//UserLogin();
					LOG:
					Console.WriteLine("Enter PC4 Username");
					NewUser = Console.ReadLine();
					Console.WriteLine("Enter PC4 Password");
					NewPass = Console.ReadLine();
					Console.WriteLine("");
					
					if(PCArray[3] == NewUser && PCPasswords[3] == NewPass)
					{
						string choice, FileEdit;
						int insert;
						
						Console.WriteLine("This PC Contains: ");
						foreach (var files in PC4)
						{
							Console.WriteLine(files);
						}
						repeat:
						Console.WriteLine("");
						Console.WriteLine("What do you wish to do?");
						Console.WriteLine("Add");
						Console.WriteLine("Remove");
						Console.WriteLine("Insert");
						Console.Write(">> ");
						choice = Console.ReadLine();
						
						if (choice == "Add")
						{
							Console.WriteLine("Enter addition to files");
							FileEdit = Console.ReadLine();
							PC4.Add(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Added");
							Console.WriteLine("");
							foreach (var files in PC4)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Remove")
						{
							Console.WriteLine("Enter file you wish to remove");
							FileEdit = Console.ReadLine();
							PC4.Remove(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Removed");
							Console.WriteLine("");
							foreach (var files in PC4)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Insert")
						{
							Console.WriteLine("Enter file you wish to insert");
							FileEdit = Console.ReadLine();
							Console.WriteLine("Where do you wish to insert");
							insert = Convert.ToInt32(Console.ReadLine());
							PC4.Insert(insert,FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully inserted");
							Console.WriteLine("");
							foreach (var files in PC4)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else
						{
							Console.WriteLine("Invalid input");
							Console.WriteLine("");
							
							Console.WriteLine("Do you wish to continue [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						
					}
					else
					{
						Console.WriteLine("Incorrect username or password");
						Console.WriteLine("Do you wish to continue logging-in [Y/N]");
						if(YesNo(YN) == true)
						{
							goto LOG;
						}
						else
						{
							Check = PCSelection(PCNumber);
							Checking(Check);
						}
					}
					
				}
			}
			else if(Check == "PC5")
			{
				if (PCArray[4] == null)
				{
					Console.WriteLine("PC has no user");
					Console.WriteLine("Do you wish to Register this PC [Y/N]");
					if(YesNo(YN) == true)
					{
						NewUser = RegistrationUser(user);
						NewPass = RegistrationPassword(pass);
						PCArray[4] = NewUser;
						PCPasswords[4] = NewPass;
						
						Console.WriteLine("");
						Check = PCSelection(PCNumber);
						Checking(Check);
						
						
					}
					else
					{
						Check = PCSelection(PCNumber);
						Checking(Check);
					}
					
				}
				else 
				{
					//UserLogin();
					LOG:
					Console.WriteLine("Enter PC5 Username");
					NewUser = Console.ReadLine();
					Console.WriteLine("Enter PC5 Password");
					NewPass = Console.ReadLine();
					Console.WriteLine("");
					
					if(PCArray[4] == NewUser && PCPasswords[4] == NewPass)
					{
						string choice, FileEdit;
						int insert;
						
						Console.WriteLine("This PC Contains: ");
						foreach (var files in PC5)
						{
							Console.WriteLine(files);
						}
						repeat:
						Console.WriteLine("");
						Console.WriteLine("What do you wish to do?");
						Console.WriteLine("Add");
						Console.WriteLine("Remove");
						Console.WriteLine("Insert");
						Console.Write(">> ");
						choice = Console.ReadLine();
						
						if (choice == "Add")
						{
							Console.WriteLine("Enter addition to files");
							FileEdit = Console.ReadLine();
							PC5.Add(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Added");
							Console.WriteLine("");
							foreach (var files in PC5)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Remove")
						{
							Console.WriteLine("Enter file you wish to remove");
							FileEdit = Console.ReadLine();
							PC5.Remove(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Removed");
							Console.WriteLine("");
							foreach (var files in PC5)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Insert")
						{
							Console.WriteLine("Enter file you wish to insert");
							FileEdit = Console.ReadLine();
							Console.WriteLine("Where do you wish to insert");
							insert = Convert.ToInt32(Console.ReadLine());
							PC5.Insert(insert,FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully inserted");
							Console.WriteLine("");
							foreach (var files in PC5)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else
						{
							Console.WriteLine("Invalid input");
							Console.WriteLine("");
							
							Console.WriteLine("Do you wish to continue [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						
					}
					else
					{
						Console.WriteLine("Incorrect username or password");
						Console.WriteLine("Do you wish to continue logging-in [Y/N]");
						if(YesNo(YN) == true)
						{
							goto LOG;
						}
						else
						{
							Check = PCSelection(PCNumber);
							Checking(Check);
						}
					}
					
				}
			} 
			else if(Check == "PC6")
			{
				if (PCArray[5] == null)
				{
					Console.WriteLine("PC has no user");
					Console.WriteLine("Do you wish to Register this PC [Y/N]");
					if(YesNo(YN) == true)
					{
						NewUser = RegistrationUser(user);
						NewPass = RegistrationPassword(pass);
						PCArray[5] = NewUser;
						PCPasswords[5] = NewPass;
						
						Console.WriteLine("");
						Check = PCSelection(PCNumber);
						Checking(Check);
						
						
					}
					else
					{
						Check = PCSelection(PCNumber);
						Checking(Check);
					}
					
				}
				else 
				{
					//UserLogin();
					LOG:
					Console.WriteLine("Enter PC6 Username");
					NewUser = Console.ReadLine();
					Console.WriteLine("Enter PC6 Password");
					NewPass = Console.ReadLine();
					Console.WriteLine("");
					
					if(PCArray[5] == NewUser && PCPasswords[5] == NewPass)
					{
						string choice, FileEdit;
						int insert;
						
						Console.WriteLine("This PC Contains: ");
						foreach (var files in PC6)
						{
							Console.WriteLine(files);
						}
						repeat:
						Console.WriteLine("");
						Console.WriteLine("What do you wish to do?");
						Console.WriteLine("Add");
						Console.WriteLine("Remove");
						Console.WriteLine("Insert");
						Console.Write(">> ");
						choice = Console.ReadLine();
						
						if (choice == "Add")
						{
							Console.WriteLine("Enter addition to files");
							FileEdit = Console.ReadLine();
							PC6.Add(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Added");
							Console.WriteLine("");
							foreach (var files in PC6)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Remove")
						{
							Console.WriteLine("Enter file you wish to remove");
							FileEdit = Console.ReadLine();
							PC6.Remove(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Removed");
							Console.WriteLine("");
							foreach (var files in PC6)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Insert")
						{
							Console.WriteLine("Enter file you wish to insert");
							FileEdit = Console.ReadLine();
							Console.WriteLine("Where do you wish to insert");
							insert = Convert.ToInt32(Console.ReadLine());
							PC6.Insert(insert,FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully inserted");
							Console.WriteLine("");
							foreach (var files in PC6)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else
						{
							Console.WriteLine("Invalid input");
							Console.WriteLine("");
							
							Console.WriteLine("Do you wish to continue [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						
					}
					else
					{
						Console.WriteLine("Incorrect username or password");
						Console.WriteLine("Do you wish to continue logging-in [Y/N]");
						if(YesNo(YN) == true)
						{
							goto LOG;
						}
						else
						{
							Check = PCSelection(PCNumber);
							Checking(Check);
						}
					}
					
				}
			}
			else if(Check == "PC7")
			{
				if (PCArray[6] == null)
				{
					Console.WriteLine("PC has no user");
					Console.WriteLine("Do you wish to Register this PC [Y/N]");
					if(YesNo(YN) == true)
					{
						NewUser = RegistrationUser(user);
						NewPass = RegistrationPassword(pass);
						PCArray[6] = NewUser;
						PCPasswords[6] = NewPass;
						
						Console.WriteLine("");
						Check = PCSelection(PCNumber);
						Checking(Check);
						
						
					}
					else
					{
						Check = PCSelection(PCNumber);
						Checking(Check);
					}
					
				}
				else 
				{
					//UserLogin();
					LOG:
					Console.WriteLine("Enter PC7 Username");
					NewUser = Console.ReadLine();
					Console.WriteLine("Enter PC7 Password");
					NewPass = Console.ReadLine();
					Console.WriteLine("");
					
					if(PCArray[6] == NewUser && PCPasswords[6] == NewPass)
					{
						string choice, FileEdit;
						int insert;
						
						Console.WriteLine("This PC Contains: ");
						foreach (var files in PC7)
						{
							Console.WriteLine(files);
						}
						repeat:
						Console.WriteLine("");
						Console.WriteLine("What do you wish to do?");
						Console.WriteLine("Add");
						Console.WriteLine("Remove");
						Console.WriteLine("Insert");
						Console.Write(">> ");
						choice = Console.ReadLine();
						
						if (choice == "Add")
						{
							Console.WriteLine("Enter addition to files");
							FileEdit = Console.ReadLine();
							PC7.Add(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Added");
							Console.WriteLine("");
							foreach (var files in PC7)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Remove")
						{
							Console.WriteLine("Enter file you wish to remove");
							FileEdit = Console.ReadLine();
							PC7.Remove(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Removed");
							Console.WriteLine("");
							foreach (var files in PC7)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Insert")
						{
							Console.WriteLine("Enter file you wish to insert");
							FileEdit = Console.ReadLine();
							Console.WriteLine("Where do you wish to insert");
							insert = Convert.ToInt32(Console.ReadLine());
							PC7.Insert(insert,FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully inserted");
							Console.WriteLine("");
							foreach (var files in PC7)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else
						{
							Console.WriteLine("Invalid input");
							Console.WriteLine("");
							
							Console.WriteLine("Do you wish to continue [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						
					}
					else
					{
						Console.WriteLine("Incorrect username or password");
						Console.WriteLine("Do you wish to continue logging-in [Y/N]");
						if(YesNo(YN) == true)
						{
							goto LOG;
						}
						else
						{
							Check = PCSelection(PCNumber);
							Checking(Check);
						}
					}
					
				}
			} 
			else if(Check == "PC8")
			{
				if (PCArray[7] == null)
				{
					Console.WriteLine("PC has no user");
					Console.WriteLine("Do you wish to Register this PC [Y/N]");
					if(YesNo(YN) == true)
					{
						NewUser = RegistrationUser(user);
						NewPass = RegistrationPassword(pass);
						PCArray[7] = NewUser;
						PCPasswords[7] = NewPass;
						
						Console.WriteLine("");
						Check = PCSelection(PCNumber);
						Checking(Check);
						
						
					}
					else
					{
						Check = PCSelection(PCNumber);
						Checking(Check);
					}
					
				}
				else 
				{
					//UserLogin();
					LOG:
					Console.WriteLine("Enter PC8 Username");
					NewUser = Console.ReadLine();
					Console.WriteLine("Enter PC8 Password");
					NewPass = Console.ReadLine();
					Console.WriteLine("");
					
					if(PCArray[7] == NewUser && PCPasswords[7] == NewPass)
					{
						string choice, FileEdit;
						int insert;
						
						Console.WriteLine("This PC Contains: ");
						foreach (var files in PC8)
						{
							Console.WriteLine(files);
						}
						repeat:
						Console.WriteLine("");
						Console.WriteLine("What do you wish to do?");
						Console.WriteLine("Add");
						Console.WriteLine("Remove");
						Console.WriteLine("Insert");
						Console.Write(">> ");
						choice = Console.ReadLine();
						
						if (choice == "Add")
						{
							Console.WriteLine("Enter addition to files");
							FileEdit = Console.ReadLine();
							PC8.Add(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Added");
							Console.WriteLine("");
							foreach (var files in PC8)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Remove")
						{
							Console.WriteLine("Enter file you wish to remove");
							FileEdit = Console.ReadLine();
							PC8.Remove(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Removed");
							Console.WriteLine("");
							foreach (var files in PC8)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Insert")
						{
							Console.WriteLine("Enter file you wish to insert");
							FileEdit = Console.ReadLine();
							Console.WriteLine("Where do you wish to insert");
							insert = Convert.ToInt32(Console.ReadLine());
							PC8.Insert(insert,FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully inserted");
							Console.WriteLine("");
							foreach (var files in PC8)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else
						{
							Console.WriteLine("Invalid input");
							Console.WriteLine("");
							
							Console.WriteLine("Do you wish to continue [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						
					}
					else
					{
						Console.WriteLine("Incorrect username or password");
						Console.WriteLine("Do you wish to continue logging-in [Y/N]");
						if(YesNo(YN) == true)
						{
							goto LOG;
						}
						else
						{
							Check = PCSelection(PCNumber);
							Checking(Check);
						}
					}
					
				}
			} 
			else if(Check == "PC9")
			{
				if (PCArray[8] == null)
				{
					Console.WriteLine("PC has no user");
					Console.WriteLine("Do you wish to Register this PC [Y/N]");
					if(YesNo(YN) == true)
					{
						NewUser = RegistrationUser(user);
						NewPass = RegistrationPassword(pass);
						PCArray[8] = NewUser;
						PCPasswords[8] = NewPass;
						
						Console.WriteLine("");
						Check = PCSelection(PCNumber);
						Checking(Check);
						
						
					}
					else
					{
						Check = PCSelection(PCNumber);
						Checking(Check);
					}
					
				}
				else 
				{
					//UserLogin();
					LOG:
					Console.WriteLine("Enter PC9 Username");
					NewUser = Console.ReadLine();
					Console.WriteLine("Enter PC9 Password");
					NewPass = Console.ReadLine();
					Console.WriteLine("");
					
					if(PCArray[8] == NewUser && PCPasswords[8] == NewPass)
					{
						string choice, FileEdit;
						int insert;
						
						Console.WriteLine("This PC Contains: ");
						foreach (var files in PC9)
						{
							Console.WriteLine(files);
						}
						repeat:
						Console.WriteLine("");
						Console.WriteLine("What do you wish to do?");
						Console.WriteLine("Add");
						Console.WriteLine("Remove");
						Console.WriteLine("Insert");
						Console.Write(">> ");
						choice = Console.ReadLine();
						
						if (choice == "Add")
						{
							Console.WriteLine("Enter addition to files");
							FileEdit = Console.ReadLine();
							PC9.Add(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Added");
							Console.WriteLine("");
							foreach (var files in PC9)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Remove")
						{
							Console.WriteLine("Enter file you wish to remove");
							FileEdit = Console.ReadLine();
							PC9.Remove(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Removed");
							Console.WriteLine("");
							foreach (var files in PC9)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Insert")
						{
							Console.WriteLine("Enter file you wish to insert");
							FileEdit = Console.ReadLine();
							Console.WriteLine("Where do you wish to insert");
							insert = Convert.ToInt32(Console.ReadLine());
							PC9.Insert(insert,FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully inserted");
							Console.WriteLine("");
							foreach (var files in PC9)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else
						{
							Console.WriteLine("Invalid input");
							Console.WriteLine("");
							
							Console.WriteLine("Do you wish to continue [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						
					}
					else
					{
						Console.WriteLine("Incorrect username or password");
						Console.WriteLine("Do you wish to continue logging-in [Y/N]");
						if(YesNo(YN) == true)
						{
							goto LOG;
						}
						else
						{
							Check = PCSelection(PCNumber);
							Checking(Check);
						}
					}
					
				}
			} 
			else if(Check == "PC10")
			{
				if (PCArray[9] == null)
				{
					Console.WriteLine("PC has no user");
					Console.WriteLine("Do you wish to Register this PC [Y/N]");
					if(YesNo(YN) == true)
					{
						NewUser = RegistrationUser(user);
						NewPass = RegistrationPassword(pass);
						PCArray[9] = NewUser;
						PCPasswords[9] = NewPass;
						
						Console.WriteLine("");
						Check = PCSelection(PCNumber);
						Checking(Check);
						
						
					}
					else
					{
						Check = PCSelection(PCNumber);
						Checking(Check);
					}
					
				}
				else 
				{
					//UserLogin();
					LOG:
					Console.WriteLine("Enter PC10 Username");
					NewUser = Console.ReadLine();
					Console.WriteLine("Enter PC10 Password");
					NewPass = Console.ReadLine();
					Console.WriteLine("");
					
					if(PCArray[9] == NewUser && PCPasswords[9] == NewPass)
					{
						string choice, FileEdit;
						int insert;
						
						Console.WriteLine("This PC Contains: ");
						foreach (var files in PC10)
						{
							Console.WriteLine(files);
						}
						repeat:
						Console.WriteLine("");
						Console.WriteLine("What do you wish to do?");
						Console.WriteLine("Add");
						Console.WriteLine("Remove");
						Console.WriteLine("Insert");
						Console.Write(">> ");
						choice = Console.ReadLine();
						
						if (choice == "Add")
						{
							Console.WriteLine("Enter addition to files");
							FileEdit = Console.ReadLine();
							PC10.Add(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Added");
							Console.WriteLine("");
							foreach (var files in PC10)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Remove")
						{
							Console.WriteLine("Enter file you wish to remove");
							FileEdit = Console.ReadLine();
							PC10.Remove(FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully Removed");
							Console.WriteLine("");
							foreach (var files in PC10)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else if (choice == "Insert")
						{
							Console.WriteLine("Enter file you wish to insert");
							FileEdit = Console.ReadLine();
							Console.WriteLine("Where do you wish to insert");
							insert = Convert.ToInt32(Console.ReadLine());
							PC10.Insert(insert,FileEdit);
							
							Console.WriteLine("");
							Console.WriteLine("Successfully inserted");
							Console.WriteLine("");
							foreach (var files in PC10)
							{
								Console.WriteLine(files);
							}
							Console.WriteLine("");
							Console.WriteLine("Do you wish to continue edititng [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						else
						{
							Console.WriteLine("Invalid input");
							Console.WriteLine("");
							
							Console.WriteLine("Do you wish to continue [Y/N]");
							if(YesNo(YN) == true)
							{
								goto repeat;
							}
							else
							{
								Check = PCSelection(PCNumber);
								Checking(Check);
							}
						}
						
					}
					else
					{
						Console.WriteLine("Incorrect username or password");
						Console.WriteLine("Do you wish to continue logging-in [Y/N]");
						if(YesNo(YN) == true)
						{
							goto LOG;
						}
						else
						{
							Check = PCSelection(PCNumber);
							Checking(Check);
						}
					}
					
				}
			} 
			else if (Check == "X")
			{
				Console.WriteLine("Shutting Down");
			}
			else
			{
				Console.WriteLine("PC does not exist");
				
				Check = PCSelection(PCNumber);
				Checking(Check);
			}
		}
		
		//AdminLogin
		static bool AdminLogin()
		{
			string AdminUser, AdminPassword;
			
			Console.WriteLine("Good Evening Admin");
			Console.Write("Username: ");
			AdminUser = Console.ReadLine();
			Console.Write("Password: ");
			AdminPassword = Console.ReadLine();
			Console.WriteLine("");
			
			if(AdminUser == "Keyboard" && AdminPassword == "Warrior")
			{
				return(true);
			}
			else
			{
				return(false);
			}
		}
		
		//PCSelection
		static string PCSelection(string PCNumber)
		{
			string PCN;
			Console.WriteLine("Which PC do you wish to manage");
				Console.WriteLine("PC1");
				Console.WriteLine("PC2");
				Console.WriteLine("PC3");
				Console.WriteLine("PC4");
				Console.WriteLine("PC5");
				Console.WriteLine("PC6");
				Console.WriteLine("PC7");
				Console.WriteLine("PC8");
				Console.WriteLine("PC9");
				Console.WriteLine("PC10");
				Console.WriteLine("X to Exit");
				Console.Write(">>");
				PCN = Console.ReadLine();
				Console.WriteLine("");
				
				return PCN;
		}
		//Main Method
		static void Main(string[] args)
        {
			
			
			Console.WriteLine("*****************");
			Console.WriteLine("");
			Console.WriteLine("          *");
			Console.WriteLine("         ***");
			Console.WriteLine("        *****");
			Console.WriteLine("       *******");
			Console.WriteLine("      ******* *");
			Console.WriteLine("     ******    *");
			Console.WriteLine("    *****    *  *");
			Console.WriteLine("   ****       *  *");
			Console.WriteLine("  * *          *  *");
			Console.WriteLine(" *              *  *");
			Console.WriteLine("");
			Console.WriteLine("*****************");
			Console.WriteLine("");
			
			login:
			if(AdminLogin() == true)
			{
				Check = PCSelection(PCNumber);
				Checking(Check);
			}
			else
			{
				Console.WriteLine("Try Again");
				goto login;
			}
        }
    }
}