namespace LearningDebugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string>() { "John", "Marsha", "Joe", "Rachel", "Monica", "Perry"};
            var partyFriends = GetPartyFriends(friends, 5);

            Console.WriteLine("Party invitation sent to the following friends:\n");
            foreach (var friend in partyFriends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("Original friends list:\n");
            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }
        }

        /// <summary>
        /// Returns the final list of friends to be invited
        /// </summary>
        /// <param name="friends"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<string> GetPartyFriends(List<string> friends, int count)
        {
            if(friends == null)
            {
                throw new ArgumentNullException("friends", "The list is empty");
            }
            if(count > friends.Count)
            {
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater than elements in the friends list");
            }
            var buffer = new List<string>(friends);
            var partyFriends = new List<string>();

            while(partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(buffer);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
            }
            return partyFriends;
        }

        /// <summary>
        /// Returns the friend with shortest name length
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for(var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
