using BankingConsoleApp;
#region NOTES
/*//
    NOTES 1:
    When entering ERROR CODES, Please go to ErrorPrinter Method @ CW.cs to create errors if they do not exist. If they exist, please use the correct error ints.
    If you created a new error code, please note it here. The method ErrorPrinter( int errorNum) requires the number entered.
    Error number list:
    0: Default termination of system.
    1: Console.ReadLine() cannot be empty.
    404: Not understanding a user input mostly used in a while/do-while loop.
//*/
#endregion
//Printing Date and Time 
CW.PrintDT();
CW.PrintLB();

//Prints welcome and information about the beta
CW.PrintWelcomeScreen();
CW.PrintBetaDetails();
CW.PrintLB();

//User will ask if they would like to continue making a program. If they type Y, then it will continue. If they say N, program will terminate.
Methods.RunWouldYouLikeToCreateAnAccount();
//Console will clear
CW.ConsoleClear();

//User will be asked to enter the name of the account
string UserName = Methods.RunAccountNameCreationAndConfirm();

//Console will clear and user will have their username provided
CW.ConsoleClear();

Console.Write($"Your username will be ");
CW.Color("dg");
Console.WriteLine(UserName);
CW.Color();
