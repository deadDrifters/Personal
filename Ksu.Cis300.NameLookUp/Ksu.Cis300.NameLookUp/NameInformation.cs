/* NameInformation.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ksu.Cis300.NameLookup;


namespace Ksu.Cis300.NameLookup
{
    /// <summary>
    /// A structure containing a name, frequency, and rank.
    /// </summary>
    public struct NameInformation
    {
        /// <summary>
        /// The name.
        /// </summary>
        private string _name;

        /// <summary>
        /// The frequency.
        /// </summary>
        private float _frequency;

        /// <summary>
        /// The rank.
        /// </summary>
        private int _rank;

        /// <summary>
        /// The cumulative frequency
        /// </summary>
        private float _cumulativeFrequency;

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Gets the frequency.
        /// </summary>
        public float Frequency
        {
            get
            {
                return _frequency;
            }
        }

        /// <summary>
        /// Gets the rank.
        /// </summary>
        public int Rank
        {
            get
            {
                return _rank;
            }
        }

        public float CumulativeFrequency
        {
            get
            {
                return _cumulativeFrequency;
            }
        }

        /// <summary>
        /// Constructs a new NameInformation containing the given name,
        /// frequency, and rank.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="frequency">The frequency.</param>
        /// <param name="rank">The rank.</param>
        public NameInformation(string name, float frequency, int rank, float cumulativeFrequency)
        {
            _name = name;
            _frequency = frequency;
            _rank = rank;
            _cumulativeFrequency = cumulativeFrequency;
        }
    }
}
