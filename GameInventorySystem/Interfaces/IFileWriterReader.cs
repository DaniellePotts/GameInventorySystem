using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventorySystem
{

    /// <summary>
    /// interface for filereading and writing. this can be easily converted to work with text files. for now it only works with serialization
    /// </summary>
    public interface IFileWriterReader
    {
        /// <summary>
        /// save a serializableObject and pass in the file name 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filePath"></param>
         void SaveGameData(GameData obj, string filePath);

        /// <summary>
        /// load game data from a data file.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
         GameData LoadGameData(GameData obj, string filePath);
    }
}
