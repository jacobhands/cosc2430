using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13Problem5
{
    class NumberStore
    {
        private StreamWriter _writer;
        private StreamReader _reader;

        public string FileName { get; set; }
        public int Columns { get; set; }
        public List<List<int>> Numbers = new List<List<int>>();
        public NumberStore() { }

        public NumberStore(string fileName)
        {
            FileName = fileName;
        }

        public NumberStore(string fileName, int columns)
        {
            Columns = columns;
            FileName = fileName;
        }

        /// <summary>
        /// Save to file
        /// </summary>
        public void Save(bool append = false)
        {
            using (_writer = new StreamWriter(FileName, append))
            {
                foreach (var line in Numbers)
                {
                    foreach (var i in line)
                    {
                        _writer.Write(i.ToString() + ',');
                    }
                    _writer.WriteLine();
                }
            }
        }
        /// <summary>
        /// Load a file
        /// </summary>
        public void Load()
        {
            if (FileName != null)
            {
                Load(FileName);
            }
            else
            {
                throw new ArgumentNullException("FileName cannot be null.");
            }
        }
        /// <summary>
        /// Load a file with given filename
        /// </summary>
        /// <param name="fileName"></param>
        public void Load(string fileName)
        {
            using (_reader = new StreamReader(fileName))
            {
                Numbers = new List<List<int>>();
                string line;
                while ((line = _reader.ReadLine()) != null)
                {
                    Numbers.Add(ParseLine(line));
                }
            }
            
        }
        /// <summary>
        /// Parse string of comma seprated ints
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public List<int> ParseLine(string line)
        {
            line = line.TrimEnd(',');
            return line.Split(',').Select(s => Convert.ToInt32(s)).ToList();
        }

        /// <summary>
        /// Add a number to the store
        /// </summary>
        /// <param name="number"></param>
        public void Add(int number)
        {
            int count = Numbers.Count;
            if (Numbers.Count == 0)
            {
                Numbers.Add(new List<int>());
                count++;
            }
            else if (Numbers[count-1].Count == Columns)
            {
                Numbers.Add(new List<int>());
                count++;
            }
            Numbers[count-1].Add(number);

        }
    }
}
