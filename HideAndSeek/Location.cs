using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HideAndSeek
{
    public class Location
    {
        /// <summary>
        /// The name of this location
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The exits out of this location
        /// </summary>
        public IDictionary<Direction, Location> Exits { get; private set; } = new Dictionary<Direction, Location>();

        /// <summary>
        /// Construct sets location name
        /// </summary>
        /// <param name="name"></param>
        public Location(string name) => Name = name;

        public override string ToString() => Name;

        /// <summary>
        /// Returns a sequence of descriptions of the exits, sorted by direction
        /// </summary>
        public IEnumerable<string> ExitList => throw new NotImplementedException();

        /// <summary>
        /// Adds an exit to this location
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="connectingLocation"></param>
        public void AddExit(Direction direction, Location connectingLocation)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the exit location in a direction
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public Location GetExit(Direction direction) =>
            new Location(Exits.Where(exit => Exits.ContainsKey(direction) && exit.Key == direction)
                .Select(exit => exit.Value)
                .ToString());
    }
}
