namespace BytesAndData
{
    using System;
    using System.IO;

    /// <summary>
    /// This class specifies the configuration for the 5211 Project.
    /// </summary>
    public class Config
    {
        private static readonly char Seperator = Path.AltDirectorySeparatorChar;

        /// <summary>
        /// Returns the absolute path of the project directory for this project.
        /// </summary>
        /// <returns>The absolute path of the project directory for this project.</returns>
        public string GetProjectDirectory()
        {
            // TODO: Update this
            // return "/Users/jcollard/git/ap-compsci-2021-2022/project_ideas/DataDiagrams/project/";
            return @"D:\git\ap-compsci-2021-2022\project_ideas\DataDiagrams\project";
        }

        /// <summary>
        /// Returns the <a cref="IFiveTwoOneOneDecoder">IFiveTwoOneOneDecoder</a> that should be used for testing.
        /// </summary>
        /// <returns>An instance of the Decoder to use.</returns>
        public IFiveTwoOneOneDecoder GetDecoder()
        {
            // TODO: Update to return your Decoder
            return new FiveTwoOneOneDecoder();
        }

        /// <summary>
        /// Returns the absolute path to the test_data directory which is used
        /// by <a cref="Support.ReadBytes(string, int)">Support.ReadBytes</a>.
        /// </summary>
        /// <returns>The path to the test_data directory.</returns>
        public string GetTestDirectory()
        {
            return this.GetProjectDirectory() + Seperator + "test_data" + Seperator;
        }
    }
}
