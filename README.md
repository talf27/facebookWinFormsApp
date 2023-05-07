# facebookWinFormsApp

The repository contains solution & project files and an API.\
After cloning, build the "Facebook WinForms app.sln" solution file.\
Usually some minutes are required to build the large "packages" folder,\
and only after several minutes and rebuild - the project runs successfully.

---

The app is a Desktop WinForms app developed in C#, using Facebook SDK and FbGraphApiWrapper.\
The app provides basic facebook features,\
such as viewing the user's posts, friends, albums, groups, events and liked pages.\
Moreover, two additional features were added:
- Ranking the best friends according to mutual characteristics level:\
Social engagement (comments and likes from the friend on the user's posts and albums)\
Mutual social life (mutual events attending)\
Mutual interests (mutual groups and liked pages)\
Shared experiences (mutual photos and check-ins)
- Showing days in selected month & year with:\
Events - with option to get details and change attending status\
Friends' birthdays - with option to write congratulations post

---

The project involves the following Design Patterns:
- Facade:\
The class "AppManagementFacade" contains the system's logic\
and accesses to the complex objects' classes and to the Facebook Graph API.
- Singleton:\
The generic class "Singleton<T>" is implemented for creating the "AppManagementFacade" class\
as the one and only instance of the class at running.
- Builder:\
By the characteristics the user chooses for ranking his friends in the form "FormBestFriends",\
the class "RankedFriendsBuilder" makes the ranking's logics implementation.
- Observer:\
the form "FormActivities" observes changes in the user's events' attending status,\
and by that maintains the shown events.
- Strategy:\
The class "Friend" has the field "Func<int, int, int> CalculateFriendshipPointsStrategyMethod" (auto-property in C#)\
that enables to change the strategy which the friends' ranking is made by.
- Iterator:\
Helps to maintain all the friends with their ranking number when showing them in the form "FormFullFriendsRanking".

---

- The project treats controls that don't allow thread synchronization.\
In order to let the user keep using the app while some big data (posts, albums, etc.) are loaded to some listbox,\
that loading process is done concurrently in a seperate thread.

- The project uses Visual Studio's data binding tools,\
for instance when showing the user's selected liked page details.

---

**Note:**\
Now adays, facebook doesn't provide the same permissions as before,\
so some features can't be shown in the app,\
although there is the proper using with the required API's methods and classes.
