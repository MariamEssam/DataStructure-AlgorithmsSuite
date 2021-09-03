using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoSuite
{
    class KeysandRooms
    {
        bool VisitedRoom(IList<IList<int>> rooms,int curr,bool[] visited,int count)
        {
            if (visited[curr]) return count == rooms.Count;
            visited[curr] = true;
            count++;
            bool AllRoomsVisited = false;
            for(int i=0;i<rooms[curr].Count;i++)
            {
                AllRoomsVisited |= VisitedRoom(rooms, rooms[curr][i], visited, count);
            }
            return AllRoomsVisited;
        }
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            return VisitedRoom(rooms, 0, new bool[rooms.Count], 0);
        }
    }
}
