using GuestBookMiniProject;

List<Guest> guests = new List<Guest>();

Console.WriteLine("Welcome to Guest Book!");

bool isBookFilled = false;

do
{
    string guestName = GuestBookMethods.AskForGuestName();
    int guestCompanionsCount = GuestBookMethods.AskForGuestCompanionsCount(guestName);

    guests.Add(new Guest(guestName, guestCompanionsCount));

    isBookFilled = GuestBookMethods.AskIfGuestBookFilled();
}
while (!isBookFilled);

GuestBookMethods.PrintGuestList(guests);