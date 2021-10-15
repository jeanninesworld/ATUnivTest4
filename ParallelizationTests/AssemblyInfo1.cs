using NUnit.Framework;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: Parallelizable(ParallelScope.All)]
[assembly:LevelOfParallelism(2)]
